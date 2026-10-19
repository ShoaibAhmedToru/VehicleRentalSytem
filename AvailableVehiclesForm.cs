using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class AvailableVehiclesForm : Form
    {
        public AvailableVehiclesForm()
        {
            InitializeComponent();
            Load += AvailableVehiclesForm_Load;
            btnSearch.Click += (sender, e) => LoadVehicles();
            btnRefresh.Click += btnRefresh_Click;
            btnCalculate.Click += (sender, e) => CalculateCost();
            btnBook.Click += btnBook_Click;
            btnClear.Click += (sender, e) => ClearForm();
            btnBack.Click += (sender, e) => Close();
            dgvAvailableVehicles.CellClick += (sender, e) => SelectVehicle();
            dtpRentalDate.ValueChanged += (sender, e) => CalculateCost();
            dtpReturnDate.ValueChanged += (sender, e) => CalculateCost();
        }

        private void AvailableVehiclesForm_Load(object sender, EventArgs e)
        {
            dtpRentalDate.MinDate = DateTime.Today;
            dtpReturnDate.MinDate = DateTime.Today;
            LoadVehicles();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilterType.SelectedIndex = 0;
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            string type = cmbFilterType.Text == "" ? "All" : cmbFilterType.Text;
            string query = @"
                SELECT VehicleID, RegistrationNumber, Brand, Model,
                       VehicleYear, VehicleType, Color, DailyRentalPrice
                FROM Vehicles
                WHERE VehicleStatus = 'Available'
                  AND (@Search = '' OR RegistrationNumber LIKE '%' + @Search + '%'
                       OR Brand LIKE '%' + @Search + '%'
                       OR Model LIKE '%' + @Search + '%')
                  AND (@Type = 'All' OR VehicleType = @Type)
                ORDER BY Brand, Model";

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    DataTable vehicles = dataAccess.ExecuteQueryTable(
                        query,
                        FormUtilities.P("@Search", txtSearch.Text.Trim()),
                        FormUtilities.P("@Type", type));
                    FormUtilities.Bind(dgvAvailableVehicles, vehicles);

                    DataTable types = dataAccess.ExecuteQueryTable(
                        "SELECT DISTINCT VehicleType FROM Vehicles ORDER BY VehicleType");
                    foreach (DataRow row in types.Rows)
                    {
                        if (!cmbFilterType.Items.Contains(row[0]))
                        {
                            cmbFilterType.Items.Add(row[0]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void SelectVehicle()
        {
            txtSelectedVehicleID.Text = FormUtilities.Cell(dgvAvailableVehicles, "VehicleID");
            txtRegistrationNumber.Text = FormUtilities.Cell(dgvAvailableVehicles, "RegistrationNumber");
            txtVehicleDetails.Text =
                FormUtilities.Cell(dgvAvailableVehicles, "Brand") + " " +
                FormUtilities.Cell(dgvAvailableVehicles, "Model") + " (" +
                FormUtilities.Cell(dgvAvailableVehicles, "VehicleType") + ")";
            txtPricePerDay.Text = FormUtilities.Cell(dgvAvailableVehicles, "DailyRentalPrice");
            CalculateCost();
        }

        private bool CalculateCost()
        {
            decimal price;
            if (!decimal.TryParse(txtPricePerDay.Text, out price))
            {
                return false;
            }

            DateTime startDate = dtpRentalDate.Value.Date;
            DateTime endDate = dtpReturnDate.Value.Date;
            if (startDate < DateTime.Today || endDate < startDate)
            {
                txtRentalDuration.Clear();
                txtTotalCost.Clear();
                return false;
            }

            int days = (endDate - startDate).Days + 1;
            txtRentalDuration.Text = days.ToString();
            txtTotalCost.Text = (days * price).ToString("0.00");
            return true;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtSelectedVehicleID.Text == "" || !CalculateCost())
            {
                MessageBox.Show("Please select a vehicle and valid rental dates.");
                return;
            }

            try
            {
                CreateBooking();
                MessageBox.Show("Vehicle booked successfully.");
                ClearForm();
                LoadVehicles();
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void CreateBooking()
        {
            using (DataAccess dataAccess = new DataAccess())
            using (SqlTransaction transaction = dataAccess.Sqlcon.BeginTransaction())
            {
                try
                {
                    ValidateCustomer(dataAccess, transaction);
                    int vehicleID = Convert.ToInt32(txtSelectedVehicleID.Text);
                    ReserveVehicle(dataAccess, transaction, vehicleID);
                    int rentalID = InsertRental(dataAccess, transaction, vehicleID);
                    InsertPayment(dataAccess, transaction, rentalID);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private void ValidateCustomer(DataAccess dataAccess, SqlTransaction transaction)
        {
            string query = @"
                SELECT COUNT(*) FROM Customers
                WHERE CustomerID = @CustomerID
                  AND CustomerStatus = 'Active'
                  AND LicenseExpiryDate >= CAST(GETDATE() AS DATE)";

            using (SqlCommand command = new SqlCommand(query, dataAccess.Sqlcon, transaction))
            {
                command.Parameters.AddWithValue("@CustomerID", UserSession.CustomerID);
                if (Convert.ToInt32(command.ExecuteScalar()) == 0)
                {
                    throw new Exception("Your account or driving licence is not valid.");
                }
            }
        }

        private void ReserveVehicle(
            DataAccess dataAccess,
            SqlTransaction transaction,
            int vehicleID)
        {
            string query = @"
                UPDATE Vehicles SET VehicleStatus = 'Rented'
                WHERE VehicleID = @VehicleID AND VehicleStatus = 'Available'";

            using (SqlCommand command = new SqlCommand(query, dataAccess.Sqlcon, transaction))
            {
                command.Parameters.AddWithValue("@VehicleID", vehicleID);
                if (command.ExecuteNonQuery() != 1)
                {
                    throw new Exception("This vehicle is no longer available.");
                }
            }
        }

        private int InsertRental(
            DataAccess dataAccess,
            SqlTransaction transaction,
            int vehicleID)
        {
            string query = @"
                INSERT INTO Rentals
                (CustomerID, VehicleID, RentalDate, ReturnDate,
                 RentalDuration, PricePerDay, LateCharge, TotalCost, RentalStatus)
                OUTPUT INSERTED.RentalID
                VALUES
                (@CustomerID, @VehicleID, @RentalDate, @ReturnDate,
                 @Duration, @Price, 0, @TotalCost, 'Booked')";

            using (SqlCommand command = new SqlCommand(query, dataAccess.Sqlcon, transaction))
            {
                command.Parameters.AddWithValue("@CustomerID", UserSession.CustomerID);
                command.Parameters.AddWithValue("@VehicleID", vehicleID);
                command.Parameters.AddWithValue("@RentalDate", dtpRentalDate.Value.Date);
                command.Parameters.AddWithValue("@ReturnDate", dtpReturnDate.Value.Date);
                command.Parameters.AddWithValue("@Duration", Convert.ToInt32(txtRentalDuration.Text));
                command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPricePerDay.Text));
                command.Parameters.AddWithValue("@TotalCost", Convert.ToDecimal(txtTotalCost.Text));
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void InsertPayment(
            DataAccess dataAccess,
            SqlTransaction transaction,
            int rentalID)
        {
            string query = @"
                INSERT INTO Payments (RentalID, Amount, PaymentStatus)
                VALUES (@RentalID, @Amount, 'Pending')";

            using (SqlCommand command = new SqlCommand(query, dataAccess.Sqlcon, transaction))
            {
                command.Parameters.AddWithValue("@RentalID", rentalID);
                command.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtTotalCost.Text));
                command.ExecuteNonQuery();
            }
        }

        private void ClearForm()
        {
            txtSelectedVehicleID.Clear();
            txtRegistrationNumber.Clear();
            txtVehicleDetails.Clear();
            txtPricePerDay.Clear();
            txtRentalDuration.Clear();
            txtTotalCost.Clear();
            dtpRentalDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today;
        }
    }
}
