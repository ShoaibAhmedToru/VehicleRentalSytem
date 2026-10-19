using System;
using System.Data.SqlClient;

namespace VehicleRentalSystem
{
    internal static class RentalActions
    {
        public static void ReturnVehicle(
            int rentalID,
            DateTime actualReturnDate,
            int customerID = 0)
        {
            using (DataAccess dataAccess = new DataAccess())
            using (SqlTransaction transaction = dataAccess.Sqlcon.BeginTransaction())
            {
                try
                {
                    RentalReturnData rental = GetRental(
                        dataAccess,
                        transaction,
                        rentalID,
                        customerID);

                    if (rental.Status != "Booked" && rental.Status != "Active")
                    {
                        throw new Exception(
                            "Only booked or active rentals can be returned.");
                    }

                    int lateDays = Math.Max(
                        0,
                        (actualReturnDate.Date - rental.ExpectedReturnDate).Days);

                    decimal lateCharge = lateDays * rental.PricePerDay;
                    decimal finalTotal = rental.CurrentTotal + lateCharge;

                    UpdateReturn(
                        dataAccess,
                        transaction,
                        rentalID,
                        rental.VehicleID,
                        actualReturnDate.Date,
                        lateCharge,
                        finalTotal);

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private static RentalReturnData GetRental(
            DataAccess dataAccess,
            SqlTransaction transaction,
            int rentalID,
            int customerID)
        {
            string query = @"
                SELECT VehicleID, ReturnDate, PricePerDay, TotalCost, RentalStatus
                FROM Rentals
                WHERE RentalID = @RentalID
                  AND (@CustomerID = 0 OR CustomerID = @CustomerID)";

            using (SqlCommand command = new SqlCommand(
                query,
                dataAccess.Sqlcon,
                transaction))
            {
                command.Parameters.AddWithValue("@RentalID", rentalID);
                command.Parameters.AddWithValue("@CustomerID", customerID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        throw new Exception("Rental not found.");
                    }

                    return new RentalReturnData
                    {
                        VehicleID = reader.GetInt32(0),
                        ExpectedReturnDate = reader.GetDateTime(1).Date,
                        PricePerDay = reader.GetDecimal(2),
                        CurrentTotal = reader.GetDecimal(3),
                        Status = reader.GetString(4)
                    };
                }
            }
        }

        private static void UpdateReturn(
            DataAccess dataAccess,
            SqlTransaction transaction,
            int rentalID,
            int vehicleID,
            DateTime actualReturnDate,
            decimal lateCharge,
            decimal finalTotal)
        {
            string query = @"
                UPDATE Rentals
                SET ActualReturnDate = @ActualReturnDate,
                    LateCharge = @LateCharge,
                    TotalCost = @TotalCost,
                    RentalStatus = 'Returned'
                WHERE RentalID = @RentalID;

                UPDATE Vehicles
                SET VehicleStatus = 'Available'
                WHERE VehicleID = @VehicleID;

                UPDATE Payments
                SET Amount = @TotalCost
                WHERE RentalID = @RentalID
                  AND PaymentStatus = 'Pending';";

            using (SqlCommand command = new SqlCommand(
                query,
                dataAccess.Sqlcon,
                transaction))
            {
                command.Parameters.AddWithValue("@ActualReturnDate", actualReturnDate);
                command.Parameters.AddWithValue("@LateCharge", lateCharge);
                command.Parameters.AddWithValue("@TotalCost", finalTotal);
                command.Parameters.AddWithValue("@RentalID", rentalID);
                command.Parameters.AddWithValue("@VehicleID", vehicleID);
                command.ExecuteNonQuery();
            }
        }

        private class RentalReturnData
        {
            public int VehicleID { get; set; }
            public DateTime ExpectedReturnDate { get; set; }
            public decimal PricePerDay { get; set; }
            public decimal CurrentTotal { get; set; }
            public string Status { get; set; }
        }
    }
}
