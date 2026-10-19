using System;
using System.Data;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            btnLogin.Click += btnLogin_Click;
            btnExit.Click += (sender, e) => Close();
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            txtPassword.UseSystemPasswordChar = true;
            AcceptButton = btnLogin;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            string query = @"
                SELECT U.UserID, U.Username, U.Role,
                       ISNULL(C.CustomerID, 0) AS CustomerID
                FROM UserInfo AS U
                LEFT JOIN Customers AS C ON C.UserID = U.UserID
                WHERE U.Username = @Username
                  AND U.Password = @Password
                  AND U.IsActive = 1";

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    DataTable result = dataAccess.ExecuteQueryTable(
                        query,
                        FormUtilities.P("@Username", username),
                        FormUtilities.P("@Password", password));

                    if (result.Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid username or password.");
                        return;
                    }

                    DataRow user = result.Rows[0];
                    UserSession.UserID = Convert.ToInt32(user["UserID"]);
                    UserSession.CustomerID = Convert.ToInt32(user["CustomerID"]);
                    UserSession.Username = user["Username"].ToString();
                    UserSession.Role = user["Role"].ToString();
                }

                Hide();

                if (UserSession.Role == "Admin")
                {
                    using (AdminDashboard dashboard = new AdminDashboard())
                    {
                        dashboard.ShowDialog();
                    }
                }
                else
                {
                    using (CustomerDashboard dashboard = new CustomerDashboard())
                    {
                        dashboard.ShowDialog();
                    }
                }

                UserSession.Clear();
                txtPassword.Clear();
                Show();
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

    }
}
