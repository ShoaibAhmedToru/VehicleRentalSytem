using System;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            Load += (sender, e) => RefreshDashboard();
            Activated += (sender, e) => RefreshDashboard();

            btnDashboard.Click += (sender, e) => RefreshDashboard();
            btnVehicles.Click += (sender, e) => OpenForm(new VehicleForm());
            btnCustomers.Click += (sender, e) => OpenForm(new CustomerForm());
            btnRentals.Click += (sender, e) => OpenForm(new RentalManagementForm());
            btnReports.Click += (sender, e) => OpenForm(new RentalManagementForm(true));
            btnCreateCustomer.Click += (sender, e) => OpenForm(new RegistrationForm());
            btnLogout.Click += (sender, e) => Close();

            lblWelcome.Text = "Welcome, " + UserSession.Username;
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
                    lblTotalVehicles.Text = Convert.ToString(
                        dataAccess.ExecuteScalar("SELECT COUNT(*) FROM Vehicles"));

                    lblTotalCustomers.Text = Convert.ToString(
                        dataAccess.ExecuteScalar(
                            "SELECT COUNT(*) FROM Customers WHERE CustomerStatus = 'Active'"));

                    lblActiveRentals.Text = Convert.ToString(
                        dataAccess.ExecuteScalar(@"
                            SELECT COUNT(*) FROM Rentals
                            WHERE RentalStatus IN ('Booked', 'Active')"));

                    lblPendingPayments.Text = Convert.ToString(
                        dataAccess.ExecuteScalar(@"
                            SELECT COUNT(*) FROM Payments
                            WHERE PaymentStatus = 'Pending'"));
                }

                lblMessage.Text = "System data is up to date.";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

    }
}
