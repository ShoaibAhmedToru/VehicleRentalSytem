using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            btnRegister.Click += btnRegister_Click;
            btnClear.Click += (sender, e) => ClearForm();
            btnBack.Click += (sender, e) => Close();
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool hidePassword = !chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = hidePassword;
            txtConfirmPassword.UseSystemPasswordChar = hidePassword;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                using (SqlTransaction transaction = dataAccess.Sqlcon.BeginTransaction())
                {
                    try
                    {
                        int userID = InsertUser(dataAccess, transaction);
                        InsertCustomer(dataAccess, transaction, userID);
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }

                MessageBox.Show("Customer account created successfully.");
                ClearForm();
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show("The username or driving licence number already exists.");
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private bool ValidateInput()
        {
            if (txtCustomerName.Text.Trim() == "" ||
                txtUsername.Text.Trim() == "" ||
                txtPassword.Text == "" ||
                txtPhone.Text.Trim() == "" ||
                txtLicenseNumber.Text.Trim() == "")
            {
                MessageBox.Show("Please complete all required fields.");
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("The passwords do not match.");
                return false;
            }

            if (dtpLicenseExpiry.Value.Date <= DateTime.Today)
            {
                MessageBox.Show("The driving licence must not be expired.");
                return false;
            }

            return true;
        }

        private int InsertUser(DataAccess dataAccess, SqlTransaction transaction)
        {
            string query = @"
                INSERT INTO UserInfo (Username, Password, Role, IsActive)
                OUTPUT INSERTED.UserID
                VALUES (@Username, @Password, 'Customer', 1)";

            using (SqlCommand command = new SqlCommand(query, dataAccess.Sqlcon, transaction))
            {
                command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                command.Parameters.AddWithValue("@Password", txtPassword.Text);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void InsertCustomer(
            DataAccess dataAccess,
            SqlTransaction transaction,
            int userID)
        {
            string query = @"
                INSERT INTO Customers
                (UserID, CustomerName, Phone, Email, Address,
                 DrivingLicenseNumber, LicenseExpiryDate, CustomerStatus)
                VALUES
                (@UserID, @Name, @Phone, @Email, @Address,
                 @Licence, @ExpiryDate, 'Active')";

            using (SqlCommand command = new SqlCommand(query, dataAccess.Sqlcon, transaction))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@Name", txtCustomerName.Text.Trim());
                command.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                command.Parameters.AddWithValue("@Licence", txtLicenseNumber.Text.Trim());
                command.Parameters.AddWithValue("@ExpiryDate", dtpLicenseExpiry.Value.Date);
                command.ExecuteNonQuery();
            }
        }

        private void ClearForm()
        {
            foreach (Control control in grpAccountInfo.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

            foreach (Control control in grpCustomerInfo.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

            dtpLicenseExpiry.Value = DateTime.Today.AddYears(1);
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

        }
    }
}
