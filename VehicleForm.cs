using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class VehicleForm : Form
    {
        public VehicleForm()
        {
            InitializeComponent();

            Load += VehicleForm_Load;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += (sender, e) => ClearForm();
            btnSearch.Click += (sender, e) => LoadVehicles();
            btnRefresh.Click += btnRefresh_Click;
            btnBack.Click += (sender, e) => Close();
            dgvVehicles.CellClick += (sender, e) => ShowSelectedVehicle();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            string query = @"
                SELECT VehicleID, RegistrationNumber, Brand, Model,
                       VehicleYear, VehicleType, Color,
                       DailyRentalPrice, VehicleStatus
                FROM Vehicles
                WHERE @Search = ''
                   OR RegistrationNumber LIKE '%' + @Search + '%'
                   OR Brand LIKE '%' + @Search + '%'
                   OR Model LIKE '%' + @Search + '%'
                ORDER BY VehicleID DESC";

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    DataTable vehicles = dataAccess.ExecuteQueryTable(
                        query,
                        FormUtilities.P("@Search", txtSearch.Text.Trim()));

                    FormUtilities.Bind(dgvVehicles, vehicles);
                }
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private bool ValidateVehicle()
        {
            if (txtRegistrationNumber.Text.Trim() == "" ||
                txtBrand.Text.Trim() == "" ||
                txtModel.Text.Trim() == "" ||
                nudDailyPrice.Value <= 0)
            {
                MessageBox.Show(
                    "Registration number, brand, model and daily price are required.");
                return false;
            }

            return true;
        }

        private SqlParameter[] GetVehicleParameters()
        {
            return new SqlParameter[]
            {
                FormUtilities.P("@Registration", txtRegistrationNumber.Text.Trim()),
                FormUtilities.P("@Brand", txtBrand.Text.Trim()),
                FormUtilities.P("@Model", txtModel.Text.Trim()),
                FormUtilities.P("@Year", (int)nudVehicleYear.Value),
                FormUtilities.P("@Type", cmbVehicleType.Text),
                FormUtilities.P("@Color", txtColor.Text.Trim()),
                FormUtilities.P("@Price", nudDailyPrice.Value),
                FormUtilities.P("@Status", cmbVehicleStatus.Text)
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateVehicle())
            {
                return;
            }

            string query = @"
                INSERT INTO Vehicles
                (RegistrationNumber, Brand, Model, VehicleYear,
                 VehicleType, Color, DailyRentalPrice, VehicleStatus)
                VALUES
                (@Registration, @Brand, @Model, @Year,
                 @Type, @Color, @Price, @Status)";

            try
            {
                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.ExecuteDMLQuery(query, GetVehicleParameters());
                }

                MessageBox.Show("Vehicle added successfully.");
                ClearForm();
                LoadVehicles();
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show("This registration number already exists.");
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtVehicleID.Text == "" || !ValidateVehicle())
            {
                MessageBox.Show("Please select a vehicle first.");
                return;
            }

            string query = @"
                UPDATE Vehicles
                SET RegistrationNumber = @Registration,
                    Brand = @Brand,
                    Model = @Model,
                    VehicleYear = @Year,
                    VehicleType = @Type,
                    Color = @Color,
                    DailyRentalPrice = @Price,
                    VehicleStatus = @Status
                WHERE VehicleID = @VehicleID";

            try
            {
                SqlParameter[] parameters = GetVehicleParameters();
                Array.Resize(ref parameters, parameters.Length + 1);
                parameters[parameters.Length - 1] =
                    FormUtilities.P("@VehicleID", Convert.ToInt32(txtVehicleID.Text));

                using (DataAccess dataAccess = new DataAccess())
                {
                    dataAccess.ExecuteDMLQuery(query, parameters);
                }

                MessageBox.Show("Vehicle updated successfully.");
                LoadVehicles();
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtVehicleID.Text == "")
            {
                MessageBox.Show("Please select a vehicle first.");
                return;
            }

            if (!FormUtilities.Confirm("Do you want to delete this vehicle?"))
            {
                return;
            }

            string query = @"
                DELETE FROM Vehicles
                WHERE VehicleID = @VehicleID
                  AND NOT EXISTS
                  (
                      SELECT 1 FROM Rentals
                      WHERE VehicleID = @VehicleID
                  )";

            try
            {
                int affectedRows;
                using (DataAccess dataAccess = new DataAccess())
                {
                    affectedRows = dataAccess.ExecuteDMLQuery(
                        query,
                        FormUtilities.P("@VehicleID", Convert.ToInt32(txtVehicleID.Text)));
                }

                MessageBox.Show(affectedRows == 1
                    ? "Vehicle deleted successfully."
                    : "A vehicle with rental history cannot be deleted.");

                ClearForm();
                LoadVehicles();
            }
            catch (Exception ex)
            {
                FormUtilities.Error(ex);
            }
        }

        private void ShowSelectedVehicle()
        {
            txtVehicleID.Text = FormUtilities.Cell(dgvVehicles, "VehicleID");
            txtRegistrationNumber.Text = FormUtilities.Cell(dgvVehicles, "RegistrationNumber");
            txtBrand.Text = FormUtilities.Cell(dgvVehicles, "Brand");
            txtModel.Text = FormUtilities.Cell(dgvVehicles, "Model");
            txtColor.Text = FormUtilities.Cell(dgvVehicles, "Color");

            decimal number;
            if (decimal.TryParse(FormUtilities.Cell(dgvVehicles, "VehicleYear"), out number))
            {
                nudVehicleYear.Value = number;
            }

            if (decimal.TryParse(FormUtilities.Cell(dgvVehicles, "DailyRentalPrice"), out number))
            {
                nudDailyPrice.Value = number;
            }

            string type = FormUtilities.Cell(dgvVehicles, "VehicleType");
            string status = FormUtilities.Cell(dgvVehicles, "VehicleStatus");

            if (cmbVehicleType.Items.Contains(type))
            {
                cmbVehicleType.SelectedItem = type;
            }

            if (cmbVehicleStatus.Items.Contains(status))
            {
                cmbVehicleStatus.SelectedItem = status;
            }
        }

        private void ClearForm()
        {
            txtVehicleID.Clear();
            txtRegistrationNumber.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtColor.Clear();
            nudDailyPrice.Value = 0;

            if (cmbVehicleType.Items.Count > 0)
            {
                cmbVehicleType.SelectedIndex = 0;
            }

            if (cmbVehicleStatus.Items.Count > 0)
            {
                cmbVehicleStatus.SelectedIndex = 0;
            }
        }
    }
}
