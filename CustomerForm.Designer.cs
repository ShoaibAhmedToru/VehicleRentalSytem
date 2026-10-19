using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        private GroupBox grpCustomerInfo;
        private Label lblCustomerID;
        private TextBox txtCustomerID;
        private Label lblUserID;
        private TextBox txtUserID;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblLicenseNumber;
        private TextBox txtLicenseNumber;
        private Label lblLicenseExpiry;
        private DateTimePicker dtpLicenseExpiry;
        private Label lblCustomerStatus;
        private ComboBox cmbCustomerStatus;

        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnViewHistory;

        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;

        private DataGridView dgvCustomers;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();

            this.grpCustomerInfo = new GroupBox();
            this.lblCustomerID = new Label();
            this.txtCustomerID = new TextBox();
            this.lblUserID = new Label();
            this.txtUserID = new TextBox();
            this.lblCustomerName = new Label();
            this.txtCustomerName = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblAddress = new Label();
            this.txtAddress = new TextBox();
            this.lblLicenseNumber = new Label();
            this.txtLicenseNumber = new TextBox();
            this.lblLicenseExpiry = new Label();
            this.dtpLicenseExpiry = new DateTimePicker();
            this.lblCustomerStatus = new Label();
            this.cmbCustomerStatus = new ComboBox();

            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            this.btnViewHistory = new Button();

            this.pnlSearch = new Panel();
            this.lblSearch = new Label();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.btnRefresh = new Button();

            this.dgvCustomers = new DataGridView();
            this.btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCustomers)).BeginInit();

            this.pnlHeader.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();

            // =====================================
            // Header Panel
            // =====================================

            this.pnlHeader.BackColor = Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Location = new Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new Size(1250, 75);
            this.pnlHeader.TabIndex = 0;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(30, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "CUSTOMER MANAGEMENT";

            this.lblSubtitle.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font =
                new Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = Color.LightGray;
            this.lblSubtitle.Location = new Point(994, 28);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Manage registered customers";

            // =====================================
            // Customer Information GroupBox
            // =====================================

            this.grpCustomerInfo.BackColor = Color.White;
            this.grpCustomerInfo.Controls.Add(this.lblCustomerID);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerID);
            this.grpCustomerInfo.Controls.Add(this.lblUserID);
            this.grpCustomerInfo.Controls.Add(this.txtUserID);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerName);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerName);
            this.grpCustomerInfo.Controls.Add(this.lblPhone);
            this.grpCustomerInfo.Controls.Add(this.txtPhone);
            this.grpCustomerInfo.Controls.Add(this.lblEmail);
            this.grpCustomerInfo.Controls.Add(this.txtEmail);
            this.grpCustomerInfo.Controls.Add(this.lblAddress);
            this.grpCustomerInfo.Controls.Add(this.txtAddress);
            this.grpCustomerInfo.Controls.Add(this.lblLicenseNumber);
            this.grpCustomerInfo.Controls.Add(this.txtLicenseNumber);
            this.grpCustomerInfo.Controls.Add(this.lblLicenseExpiry);
            this.grpCustomerInfo.Controls.Add(this.dtpLicenseExpiry);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerStatus);
            this.grpCustomerInfo.Controls.Add(this.cmbCustomerStatus);
            this.grpCustomerInfo.Controls.Add(this.btnUpdate);
            this.grpCustomerInfo.Controls.Add(this.btnDelete);
            this.grpCustomerInfo.Controls.Add(this.btnClear);
            this.grpCustomerInfo.Controls.Add(this.btnViewHistory);

            this.grpCustomerInfo.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            this.grpCustomerInfo.ForeColor = Color.MidnightBlue;
            this.grpCustomerInfo.Location = new Point(25, 95);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new Size(390, 565);
            this.grpCustomerInfo.TabIndex = 1;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Information";

            // =====================================
            // Customer ID
            // =====================================

            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new Font("Segoe UI", 9.5F);
            this.lblCustomerID.ForeColor = Color.Black;
            this.lblCustomerID.Location = new Point(25, 35);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Text = "Customer ID";

            this.txtCustomerID.BackColor = Color.Gainsboro;
            this.txtCustomerID.Font = new Font("Segoe UI", 10F);
            this.txtCustomerID.Location = new Point(25, 60);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new Size(155, 25);
            this.txtCustomerID.TabStop = false;

            // =====================================
            // User ID
            // =====================================

            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new Font("Segoe UI", 9.5F);
            this.lblUserID.ForeColor = Color.Black;
            this.lblUserID.Location = new Point(205, 35);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Text = "User ID";

            this.txtUserID.BackColor = Color.Gainsboro;
            this.txtUserID.Font = new Font("Segoe UI", 10F);
            this.txtUserID.Location = new Point(205, 60);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new Size(155, 25);
            this.txtUserID.TabStop = false;

            // =====================================
            // Customer Name
            // =====================================

            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font =
                new Font("Segoe UI", 9.5F);
            this.lblCustomerName.ForeColor = Color.Black;
            this.lblCustomerName.Location = new Point(25, 100);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Text = "Customer Name";

            this.txtCustomerName.Font =
                new Font("Segoe UI", 10F);
            this.txtCustomerName.Location = new Point(25, 125);
            this.txtCustomerName.MaxLength = 100;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new Size(335, 25);
            this.txtCustomerName.TabIndex = 0;

            // =====================================
            // Phone
            // =====================================

            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new Font("Segoe UI", 9.5F);
            this.lblPhone.ForeColor = Color.Black;
            this.lblPhone.Location = new Point(25, 165);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Text = "Phone";

            this.txtPhone.Font = new Font("Segoe UI", 10F);
            this.txtPhone.Location = new Point(25, 190);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(155, 25);
            this.txtPhone.TabIndex = 1;

            // =====================================
            // Email
            // =====================================

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 9.5F);
            this.lblEmail.ForeColor = Color.Black;
            this.lblEmail.Location = new Point(205, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email";

            this.txtEmail.Font = new Font("Segoe UI", 10F);
            this.txtEmail.Location = new Point(205, 190);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(155, 25);
            this.txtEmail.TabIndex = 2;

            // =====================================
            // Address
            // =====================================

            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new Font("Segoe UI", 9.5F);
            this.lblAddress.ForeColor = Color.Black;
            this.lblAddress.Location = new Point(25, 230);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Text = "Address";

            this.txtAddress.Font = new Font("Segoe UI", 10F);
            this.txtAddress.Location = new Point(25, 255);
            this.txtAddress.MaxLength = 250;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = ScrollBars.Vertical;
            this.txtAddress.Size = new Size(335, 55);
            this.txtAddress.TabIndex = 3;

            // =====================================
            // Driving Licence Number
            // =====================================

            this.lblLicenseNumber.AutoSize = true;
            this.lblLicenseNumber.Font =
                new Font("Segoe UI", 9.5F);
            this.lblLicenseNumber.ForeColor = Color.Black;
            this.lblLicenseNumber.Location =
                new Point(25, 325);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Text =
                "Driving Licence Number";

            this.txtLicenseNumber.CharacterCasing =
                CharacterCasing.Upper;
            this.txtLicenseNumber.Font =
                new Font("Segoe UI", 10F);
            this.txtLicenseNumber.Location =
                new Point(25, 350);
            this.txtLicenseNumber.MaxLength = 50;
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new Size(335, 25);
            this.txtLicenseNumber.TabIndex = 4;

            // =====================================
            // Licence Expiry
            // =====================================

            this.lblLicenseExpiry.AutoSize = true;
            this.lblLicenseExpiry.Font =
                new Font("Segoe UI", 9.5F);
            this.lblLicenseExpiry.ForeColor = Color.Black;
            this.lblLicenseExpiry.Location =
                new Point(25, 390);
            this.lblLicenseExpiry.Name = "lblLicenseExpiry";
            this.lblLicenseExpiry.Text = "Licence Expiry Date";

            this.dtpLicenseExpiry.CustomFormat = "dd-MM-yyyy";
            this.dtpLicenseExpiry.Font =
                new Font("Segoe UI", 10F);
            this.dtpLicenseExpiry.Format =
                DateTimePickerFormat.Custom;
            this.dtpLicenseExpiry.Location =
                new Point(25, 415);
            this.dtpLicenseExpiry.Name = "dtpLicenseExpiry";
            this.dtpLicenseExpiry.Size = new Size(155, 25);
            this.dtpLicenseExpiry.TabIndex = 5;

            // =====================================
            // Customer Status
            // =====================================

            this.lblCustomerStatus.AutoSize = true;
            this.lblCustomerStatus.Font =
                new Font("Segoe UI", 9.5F);
            this.lblCustomerStatus.ForeColor = Color.Black;
            this.lblCustomerStatus.Location =
                new Point(205, 390);
            this.lblCustomerStatus.Name = "lblCustomerStatus";
            this.lblCustomerStatus.Text = "Customer Status";

            this.cmbCustomerStatus.DropDownStyle =
                ComboBoxStyle.DropDownList;
            this.cmbCustomerStatus.Font =
                new Font("Segoe UI", 10F);
            this.cmbCustomerStatus.FormattingEnabled = true;
            this.cmbCustomerStatus.Items.AddRange(
                new object[]
                {
                    "Active",
                    "Inactive"
                });
            this.cmbCustomerStatus.Location =
                new Point(205, 415);
            this.cmbCustomerStatus.Name =
                "cmbCustomerStatus";
            this.cmbCustomerStatus.Size =
                new Size(155, 25);
            this.cmbCustomerStatus.SelectedIndex = 0;
            this.cmbCustomerStatus.TabIndex = 6;

            // =====================================
            // Update Button
            // =====================================

            this.btnUpdate.BackColor = Color.SteelBlue;
            this.btnUpdate.Cursor = Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnUpdate.ForeColor = Color.White;
            this.btnUpdate.Location = new Point(25, 465);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(155, 35);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;

            // Delete Button

            this.btnDelete.BackColor = Color.Firebrick;
            this.btnDelete.Cursor = Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.Location = new Point(205, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(155, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;

            // Clear Button

            this.btnClear.BackColor = Color.DimGray;
            this.btnClear.Cursor = Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Location = new Point(25, 515);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(155, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;

            // View History Button

            this.btnViewHistory.BackColor = Color.SeaGreen;
            this.btnViewHistory.Cursor = Cursors.Hand;
            this.btnViewHistory.FlatAppearance.BorderSize = 0;
            this.btnViewHistory.FlatStyle = FlatStyle.Flat;
            this.btnViewHistory.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnViewHistory.ForeColor = Color.White;
            this.btnViewHistory.Location =
                new Point(205, 515);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new Size(155, 35);
            this.btnViewHistory.TabIndex = 10;
            this.btnViewHistory.Text = "VIEW HISTORY";
            this.btnViewHistory.UseVisualStyleBackColor =
                false;

            // =====================================
            // Search Panel
            // =====================================

            this.pnlSearch.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;
            this.pnlSearch.BackColor = Color.White;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnRefresh);
            this.pnlSearch.Location = new Point(440, 95);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new Size(785, 65);
            this.pnlSearch.TabIndex = 2;

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSearch.ForeColor = Color.MidnightBlue;
            this.lblSearch.Location = new Point(20, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Search:";

            this.txtSearch.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;
            this.txtSearch.Font = new Font("Segoe UI", 10F);
            this.txtSearch.Location = new Point(85, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(390, 25);
            this.txtSearch.TabIndex = 11;

            this.btnSearch.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;
            this.btnSearch.BackColor = Color.MidnightBlue;
            this.btnSearch.Cursor = Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new Point(495, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(120, 34);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;

            this.btnRefresh.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;
            this.btnRefresh.BackColor = Color.SteelBlue;
            this.btnRefresh.Cursor = Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Location = new Point(635, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(125, 34);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;

            // =====================================
            // Customer DataGridView
            // =====================================

            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;
            this.dgvCustomers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = Color.White;
            this.dgvCustomers.BorderStyle =
                BorderStyle.FixedSingle;
            this.dgvCustomers.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new Point(440, 180);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new Size(785, 465);
            this.dgvCustomers.TabIndex = 14;

            // =====================================
            // Back Button
            // =====================================

            this.btnBack.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnBack.BackColor = Color.White;
            this.btnBack.Cursor = Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor =
                Color.MidnightBlue;
            this.btnBack.FlatAppearance.BorderSize = 1;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnBack.ForeColor = Color.MidnightBlue;
            this.btnBack.Location = new Point(1105, 665);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(120, 40);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;

            // =====================================
            // CustomerForm
            // =====================================

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(1250, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.pnlHeader);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(1100, 650);
            this.Name = "CustomerForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text =
                "Vehicle Rental System - Customer Management";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCustomers)).EndInit();

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
