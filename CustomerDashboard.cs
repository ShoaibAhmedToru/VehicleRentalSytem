using System;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();

            Load += (sender, e) => RefreshDashboard();
            Activated += (sender, e) => RefreshDashboard();

            btnDashboard.Click += (sender, e) => RefreshDashboard();
            btnAvailableVehicles.Click += (sender, e) => OpenForm(new AvailableVehiclesForm());
            btnBrowseVehicles.Click += (sender, e) => OpenForm(new AvailableVehiclesForm());
            btnMyRentals.Click += (sender, e) => OpenForm(new MyRentalsForm());
            btnLogout.Click += (sender, e) => Close();

            lblWelcomeCustomer.Text = "Welcome, " + UserSession.Username;
        }

        private void OpenForm(Form form)
        {
            using (form)
            {
                form.ShowDialog(this);
            }

            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    lblAvailableCount.Text = Convert.ToString(
                        dataAccess.ExecuteScalar(@"
                            SELECT COUNT(*) FROM Vehicles
                            WHERE VehicleStatus = 'Available'"));

                    lblActiveRentals.Text = Convert.ToString(
                        dataAccess.ExecuteScalar(@"
                            SELECT COUNT(*) FROM Rentals
                            WHERE CustomerID = @CustomerID
                              AND RentalStatus IN ('Booked', 'Active')",
                            FormUtilities.P("@CustomerID", UserSession.CustomerID)));

                    decimal pendingAmount = Convert.ToDecimal(
                        dataAccess.ExecuteScalar(@"
                            SELECT ISNULL(SUM(P.Amount), 0)
                            FROM Payments AS P
                            INNER JOIN Rentals AS R ON R.RentalID = P.RentalID
                            WHERE R.CustomerID = @CustomerID
                              AND P.PaymentStatus = 'Pending'",
                            FormUtilities.P("@CustomerID", UserSession.CustomerID)));

                    lblPendingAmount.Text = "৳" + pendingAmount.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }
    }
}
