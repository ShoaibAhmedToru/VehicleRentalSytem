using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

            Load += CustomerForm_Load;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += (sender, e) => ClearForm();
            btnViewHistory.Click += btnViewHistory_Click;
            btnSearch.Click += (sender, e) => LoadCustomers();
            btnRefresh.Click += btnRefresh_Click;
            btnBack.Click += (sender, e) => Close();
            dgvCustomers.CellClick += (sender, e) => ShowSelectedCustomer();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            string query = @"
                SELECT C.CustomerID, C.UserID, C.CustomerName,
                       C.Phone, C.Email, C.Address,
                       C.DrivingLicenseNumber, C.LicenseExpiryDate,
                       C.CustomerStatus, U.Username
                FROM Customers AS C
                INNER JOIN UserInfo AS U ON U.UserID = C.UserID
                WHERE @Search = ''
                   OR C.CustomerName LIKE '%' + @Search + '%'
                   OR C.Phone LIKE '%' + @Search + '%'
                   OR C.DrivingLicenseNumber LIKE '%' + @Search + '%'
                ORDER BY C.CustomerID DESC";

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    DataTable customers = dataAccess.ExecuteQueryTable(
                        query,
                        FormUtilities.P("@Search", txtSearch.Text.Trim()));

                    FormUtilities.Bind(dgvCustomers, customers);
                }
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomer())
            {
                return;
            }

            string query = @"
                UPDATE Customers
                SET CustomerName = @Name,
                    Phone = @Phone,
                    Email = @Email,
                    Address = @Address,
                    DrivingLicenseNumber = @Licence,
                    LicenseExpiryDate = @ExpiryDate,
                    CustomerStatus = @Status
                WHERE CustomerID = @CustomerID;

                UPDATE UserInfo
                SET IsActive = CASE WHEN @Status = 'Active' THEN 1 ELSE 0 END
                WHERE UserID = @UserID;";

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.ExecuteDMLQuery(
                        query,
                        FormUtilities.P("@Name", txtCustomerName.Text.Trim()),
                        FormUtilities.P("@Phone", txtPhone.Text.Trim()),
                        FormUtilities.P("@Email", txtEmail.Text.Trim()),
                        FormUtilities.P("@Address", txtAddress.Text.Trim()),
                        FormUtilities.P("@Licence", txtLicenseNumber.Text.Trim()),
                        FormUtilities.P("@ExpiryDate", dtpLicenseExpiry.Value.Date),
                        FormUtilities.P("@Status", cmbCustomerStatus.Text),
                        FormUtilities.P("@CustomerID", Convert.ToInt32(txtCustomerID.Text)),
                        FormUtilities.P("@UserID", Convert.ToInt32(txtUserID.Text)));
                }

                MessageBox.Show("Customer updated successfully.");
                LoadCustomers();
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show("This driving licence number already exists.");
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private bool ValidateCustomer()
        {
            if (txtCustomerID.Text == "" ||
                txtCustomerName.Text.Trim() == "" ||
                txtPhone.Text.Trim() == "" ||
                txtLicenseNumber.Text.Trim() == "")
            {
                MessageBox.Show("Please select a customer and complete the required fields.");
                return false;
            }

            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            if (!FormUtilities.Confirm("Do you want to deactivate this customer?"))
            {
                return;
            }

            cmbCustomerStatus.SelectedItem = "Inactive";
            btnUpdate_Click(sender, e);
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            int selectedCustomerID = Convert.ToInt32(txtCustomerID.Text);
            using (MyRentalsForm historyForm = new MyRentalsForm(selectedCustomerID))
            {
                historyForm.ShowDialog(this);
            }
        }

        private void ShowSelectedCustomer()
        {
            txtCustomerID.Text = FormUtilities.Cell(dgvCustomers, "CustomerID");
            txtUserID.Text = FormUtilities.Cell(dgvCustomers, "UserID");
            txtCustomerName.Text = FormUtilities.Cell(dgvCustomers, "CustomerName");
            txtPhone.Text = FormUtilities.Cell(dgvCustomers, "Phone");
            txtEmail.Text = FormUtilities.Cell(dgvCustomers, "Email");
            txtAddress.Text = FormUtilities.Cell(dgvCustomers, "Address");
            txtLicenseNumber.Text = FormUtilities.Cell(dgvCustomers, "DrivingLicenseNumber");

            DateTime expiryDate;
            if (DateTime.TryParse(
                FormUtilities.Cell(dgvCustomers, "LicenseExpiryDate"),
                out expiryDate))
            {
                dtpLicenseExpiry.Value = expiryDate;
            }

            string status = FormUtilities.Cell(dgvCustomers, "CustomerStatus");
            if (cmbCustomerStatus.Items.Contains(status))
            {
                cmbCustomerStatus.SelectedItem = status;
            }
        }

        private void ClearForm()
        {
            txtCustomerID.Clear();
            txtUserID.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtLicenseNumber.Clear();
            dtpLicenseExpiry.Value = DateTime.Today.AddYears(1);
            cmbCustomerStatus.SelectedIndex = 0;
        }
    }
}
