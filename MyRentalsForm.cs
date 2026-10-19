using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class MyRentalsForm : Form
    {
        private readonly int customerID;

        public MyRentalsForm() : this(UserSession.CustomerID)
        {
        }

        public MyRentalsForm(int selectedCustomerID)
        {
            customerID = selectedCustomerID;
            InitializeComponent();

            Load += MyRentalsForm_Load;
            btnFilter.Click += (sender, e) => LoadRentals();
            btnRefresh.Click += (sender, e) => LoadRentals();
            btnCancelBooking.Click += btnCancelBooking_Click;
            btnReturnVehicle.Click += btnReturnVehicle_Click;
            btnPayNow.Click += btnPayNow_Click;
            btnBack.Click += (sender, e) => Close();
            dgvMyRentals.CellClick += (sender, e) => ShowSelectedRental();
        }

        private void MyRentalsForm_Load(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void LoadRentals()
        {
            string selectedStatus = cmbRentalStatusFilter.Text;
            if (selectedStatus == "")
            {
                selectedStatus = "All";
            }

            string query = @"
                SELECT R.RentalID,
                       R.VehicleID,
                       V.RegistrationNumber,
                       V.Brand + ' ' + V.Model AS Vehicle,
                       R.RentalDate,
                       R.ReturnDate,
                       R.ActualReturnDate,
                       R.RentalDuration,
                       R.PricePerDay,
                       R.LateCharge,
                       R.TotalCost,
                       R.RentalStatus,
                       ISNULL(P.PaymentStatus, 'N/A') AS PaymentStatus,
                       ISNULL(P.PaymentMethod, 'N/A') AS PaymentMethod
                FROM Rentals AS R
                INNER JOIN Vehicles AS V ON V.VehicleID = R.VehicleID
                LEFT JOIN Payments AS P ON P.RentalID = R.RentalID
                WHERE R.CustomerID = @CustomerID
                  AND (@Status = 'All' OR R.RentalStatus = @Status)
                ORDER BY R.RentalID DESC";

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    DataTable rentals = dataAccess.ExecuteQueryTable(
                        query,
                        FormUtilities.P("@CustomerID", customerID),
                        FormUtilities.P("@Status", selectedStatus));

                    FormUtilities.Bind(dgvMyRentals, rentals);
                }
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void ShowSelectedRental()
        {
            txtRentalID.Text = FormUtilities.Cell(dgvMyRentals, "RentalID");
            txtVehicle.Text = FormUtilities.Cell(dgvMyRentals, "Vehicle");
            txtRentalPeriod.Text =
                FormUtilities.Cell(dgvMyRentals, "RentalDate") + " to " +
                FormUtilities.Cell(dgvMyRentals, "ReturnDate");
            txtRentalStatus.Text = FormUtilities.Cell(dgvMyRentals, "RentalStatus");
            txtTotalCost.Text = FormUtilities.Cell(dgvMyRentals, "TotalCost");
            txtPaymentStatus.Text = FormUtilities.Cell(dgvMyRentals, "PaymentStatus");

            string paymentMethod = FormUtilities.Cell(dgvMyRentals, "PaymentMethod");
            if (cmbPaymentMethod.Items.Contains(paymentMethod))
            {
                cmbPaymentMethod.SelectedItem = paymentMethod;
            }
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            if (txtRentalID.Text == "")
            {
                MessageBox.Show("Please select a rental.");
                return;
            }

            if (txtPaymentStatus.Text != "Pending")
            {
                MessageBox.Show("This rental does not have a pending payment.");
                return;
            }

            string query = @"
                UPDATE P
                SET P.PaymentDate = GETDATE(),
                    P.PaymentMethod = @PaymentMethod,
                    P.PaymentStatus = 'Paid'
                FROM Payments AS P
                INNER JOIN Rentals AS R ON R.RentalID = P.RentalID
                WHERE P.RentalID = @RentalID
                  AND R.CustomerID = @CustomerID
                  AND P.PaymentStatus = 'Pending'";

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.ExecuteDMLQuery(
                        query,
                        FormUtilities.P("@PaymentMethod", cmbPaymentMethod.Text),
                        FormUtilities.P("@RentalID", Convert.ToInt32(txtRentalID.Text)),
                        FormUtilities.P("@CustomerID", customerID));
                }

                MessageBox.Show("Payment completed successfully.");
                LoadRentals();
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (txtRentalID.Text == "" || txtRentalStatus.Text != "Booked")
            {
                MessageBox.Show("Please select a booked rental.");
                return;
            }

            if (txtPaymentStatus.Text == "Paid")
            {
                MessageBox.Show("A paid booking cannot be cancelled here.");
                return;
            }

            if (!FormUtilities.Confirm("Do you want to cancel this booking?"))
            {
                return;
            }

            string query = @"
                UPDATE Vehicles
                SET VehicleStatus = 'Available'
                WHERE VehicleID =
                (
                    SELECT VehicleID FROM Rentals
                    WHERE RentalID = @RentalID
                      AND CustomerID = @CustomerID
                      AND RentalStatus = 'Booked'
                );

                UPDATE Rentals
                SET RentalStatus = 'Cancelled'
                WHERE RentalID = @RentalID
                  AND CustomerID = @CustomerID
                  AND RentalStatus = 'Booked';

                DELETE FROM Payments
                WHERE RentalID = @RentalID
                  AND PaymentStatus = 'Pending';";

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.ExecuteDMLQuery(
                        query,
                        FormUtilities.P("@RentalID", Convert.ToInt32(txtRentalID.Text)),
                        FormUtilities.P("@CustomerID", customerID));
                }

                MessageBox.Show("Booking cancelled.");
                LoadRentals();
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void btnReturnVehicle_Click(object sender, EventArgs e)
        {
            if (txtRentalID.Text == "" ||
                (txtRentalStatus.Text != "Booked" && txtRentalStatus.Text != "Active"))
            {
                MessageBox.Show("Please select an active or booked rental.");
                return;
            }

            if (!FormUtilities.Confirm("Do you want to return this vehicle today?"))
            {
                return;
            }

            try
            {
                RentalActions.ReturnVehicle(
                    Convert.ToInt32(txtRentalID.Text),
                    DateTime.Today,
                    customerID);

                MessageBox.Show("Vehicle returned successfully.");
                LoadRentals();
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }
    }
}
