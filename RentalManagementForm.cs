using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class RentalManagementForm : Form
    {
        private readonly bool reportMode;

        public RentalManagementForm() : this(false)
        {
        }

        public RentalManagementForm(bool openAsReport)
        {
            reportMode = openAsReport;
            InitializeComponent();

            Load += RentalManagementForm_Load;
            btnSearch.Click += (sender, e) => LoadRentals();
            btnRefresh.Click += btnRefresh_Click;
            btnStartRental.Click += btnStartRental_Click;
            btnCancelRental.Click += btnCancelRental_Click;
            btnReturnVehicle.Click += btnReturnVehicle_Click;
            btnShowSummary.Click += btnSummary_Click;
            btnClear.Click += (sender, e) => ClearSelection();
            btnBack.Click += (sender, e) => Close();
            dgvRentals.CellClick += (sender, e) => ShowSelectedRental();
        }

        private void RentalManagementForm_Load(object sender, EventArgs e)
        {
            if (reportMode)
            {
                Text = "Rental Reports";
                lblTitle.Text = "RENTAL REPORTS";
                lblSubtitle.Text = "Filter rental records and view a summary";
            }

            LoadRentals();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatusFilter.SelectedIndex = 0;
            LoadRentals();
        }

        private void LoadRentals()
        {
            string selectedStatus = cmbStatusFilter.Text;
            if (selectedStatus == "")
            {
                selectedStatus = "All";
            }

            string query = @"
                SELECT R.RentalID,
                       R.CustomerID,
                       C.CustomerName,
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
                INNER JOIN Customers AS C ON C.CustomerID = R.CustomerID
                INNER JOIN Vehicles AS V ON V.VehicleID = R.VehicleID
                LEFT JOIN Payments AS P ON P.RentalID = R.RentalID
                WHERE
                (
                    @Search = '' OR
                    C.CustomerName LIKE '%' + @Search + '%' OR
                    V.RegistrationNumber LIKE '%' + @Search + '%' OR
                    CONVERT(VARCHAR, R.RentalID) = @Search
                )
                AND (@Status = 'All' OR R.RentalStatus = @Status)
                ORDER BY R.RentalID DESC";

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    DataTable rentals = dataAccess.ExecuteQueryTable(
                        query,
                        FormUtilities.P("@Search", txtSearch.Text.Trim()),
                        FormUtilities.P("@Status", selectedStatus));

                    FormUtilities.Bind(dgvRentals, rentals);
                }
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void ShowSelectedRental()
        {
            txtRentalID.Text = FormUtilities.Cell(dgvRentals, "RentalID");
            txtCustomer.Text = FormUtilities.Cell(dgvRentals, "CustomerName");
            txtVehicle.Text = FormUtilities.Cell(dgvRentals, "Vehicle");
            txtRentalStatus.Text = FormUtilities.Cell(dgvRentals, "RentalStatus");
            txtTotalCost.Text = FormUtilities.Cell(dgvRentals, "TotalCost");

            DateTime actualReturnDate;
            bool hasReturnDate = DateTime.TryParse(
                FormUtilities.Cell(dgvRentals, "ActualReturnDate"),
                out actualReturnDate);

            dtpActualReturnDate.Value = hasReturnDate
                ? actualReturnDate
                : DateTime.Today;
        }

        private void btnStartRental_Click(object sender, EventArgs e)
        {
            if (txtRentalID.Text == "" || txtRentalStatus.Text != "Booked")
            {
                MessageBox.Show("Please select a booked rental.");
                return;
            }

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.ExecuteDMLQuery(@"
                        UPDATE Rentals
                        SET RentalStatus = 'Active'
                        WHERE RentalID = @RentalID
                          AND RentalStatus = 'Booked'",
                        FormUtilities.P("@RentalID", Convert.ToInt32(txtRentalID.Text)));
                }

                MessageBox.Show("Rental started.");
                LoadRentals();
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void btnCancelRental_Click(object sender, EventArgs e)
        {
            if (txtRentalID.Text == "" || txtRentalStatus.Text != "Booked")
            {
                MessageBox.Show("Please select a booked rental.");
                return;
            }

            if (FormUtilities.Cell(dgvRentals, "PaymentStatus") == "Paid")
            {
                MessageBox.Show("A paid rental cannot be cancelled here.");
                return;
            }

            if (!FormUtilities.Confirm("Do you want to cancel this rental?"))
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
                      AND RentalStatus = 'Booked'
                );

                UPDATE Rentals
                SET RentalStatus = 'Cancelled'
                WHERE RentalID = @RentalID
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
                        FormUtilities.P("@RentalID", Convert.ToInt32(txtRentalID.Text)));
                }

                MessageBox.Show("Rental cancelled.");
                LoadRentals();
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void btnReturnVehicle_Click(object sender, EventArgs e)
        {
            if (txtRentalID.Text == "")
            {
                MessageBox.Show("Please select a rental.");
                return;
            }

            try
            {
                RentalActions.ReturnVehicle(
                    Convert.ToInt32(txtRentalID.Text),
                    dtpActualReturnDate.Value.Date);

                MessageBox.Show("Vehicle returned successfully.");
                LoadRentals();
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            DataTable data = dgvRentals.DataSource as DataTable;
            if (data == null)
            {
                return;
            }

            decimal total = 0;
            foreach (DataRow row in data.Rows)
            {
                if (row["TotalCost"] != DBNull.Value)
                {
                    total += Convert.ToDecimal(row["TotalCost"]);
                }
            }

            MessageBox.Show(
                "Total rental records: " + data.Rows.Count +
                "\nTotal rental amount: ৳" + total.ToString("N2"),
                "Rental Summary");
        }

        private void ClearSelection()
        {
            txtRentalID.Clear();
            txtCustomer.Clear();
            txtVehicle.Clear();
            txtRentalStatus.Clear();
            txtTotalCost.Clear();
        }
    }
}
