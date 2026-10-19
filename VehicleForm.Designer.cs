using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class VehicleForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        private GroupBox grpVehicleInfo;
        private Label lblVehicleID;
        private TextBox txtVehicleID;
        private Label lblRegistrationNumber;
        private TextBox txtRegistrationNumber;
        private Label lblBrand;
        private TextBox txtBrand;
        private Label lblModel;
        private TextBox txtModel;
        private Label lblVehicleYear;
        private NumericUpDown nudVehicleYear;
        private Label lblVehicleType;
        private ComboBox cmbVehicleType;
        private Label lblColor;
        private TextBox txtColor;
        private Label lblDailyPrice;
        private NumericUpDown nudDailyPrice;
        private Label lblVehicleStatus;
        private ComboBox cmbVehicleStatus;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;

        private DataGridView dgvVehicles;
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpVehicleInfo = new System.Windows.Forms.GroupBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblVehicleYear = new System.Windows.Forms.Label();
            this.nudVehicleYear = new System.Windows.Forms.NumericUpDown();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblDailyPrice = new System.Windows.Forms.Label();
            this.nudDailyPrice = new System.Windows.Forms.NumericUpDown();
            this.lblVehicleStatus = new System.Windows.Forms.Label();
            this.cmbVehicleStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpVehicleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyPrice)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1250, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(326, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "VEHICLE MANAGEMENT";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitle.Location = new System.Drawing.Point(1010, 28);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(166, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Manage all rental vehicles";
            // 
            // grpVehicleInfo
            // 
            this.grpVehicleInfo.BackColor = System.Drawing.Color.White;
            this.grpVehicleInfo.Controls.Add(this.lblVehicleID);
            this.grpVehicleInfo.Controls.Add(this.txtVehicleID);
            this.grpVehicleInfo.Controls.Add(this.lblRegistrationNumber);
            this.grpVehicleInfo.Controls.Add(this.txtRegistrationNumber);
            this.grpVehicleInfo.Controls.Add(this.lblBrand);
            this.grpVehicleInfo.Controls.Add(this.txtBrand);
            this.grpVehicleInfo.Controls.Add(this.lblModel);
            this.grpVehicleInfo.Controls.Add(this.txtModel);
            this.grpVehicleInfo.Controls.Add(this.lblVehicleYear);
            this.grpVehicleInfo.Controls.Add(this.nudVehicleYear);
            this.grpVehicleInfo.Controls.Add(this.lblVehicleType);
            this.grpVehicleInfo.Controls.Add(this.cmbVehicleType);
            this.grpVehicleInfo.Controls.Add(this.lblColor);
            this.grpVehicleInfo.Controls.Add(this.txtColor);
            this.grpVehicleInfo.Controls.Add(this.lblDailyPrice);
            this.grpVehicleInfo.Controls.Add(this.nudDailyPrice);
            this.grpVehicleInfo.Controls.Add(this.lblVehicleStatus);
            this.grpVehicleInfo.Controls.Add(this.cmbVehicleStatus);
            this.grpVehicleInfo.Controls.Add(this.btnAdd);
            this.grpVehicleInfo.Controls.Add(this.btnUpdate);
            this.grpVehicleInfo.Controls.Add(this.btnDelete);
            this.grpVehicleInfo.Controls.Add(this.btnClear);
            this.grpVehicleInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpVehicleInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpVehicleInfo.Location = new System.Drawing.Point(25, 95);
            this.grpVehicleInfo.Name = "grpVehicleInfo";
            this.grpVehicleInfo.Size = new System.Drawing.Size(375, 565);
            this.grpVehicleInfo.TabIndex = 1;
            this.grpVehicleInfo.TabStop = false;
            this.grpVehicleInfo.Text = "Vehicle Information";
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblVehicleID.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleID.Location = new System.Drawing.Point(25, 35);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(64, 17);
            this.lblVehicleID.TabIndex = 0;
            this.lblVehicleID.Text = "Vehicle ID";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtVehicleID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVehicleID.Location = new System.Drawing.Point(25, 60);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.ReadOnly = true;
            this.txtVehicleID.Size = new System.Drawing.Size(320, 25);
            this.txtVehicleID.TabIndex = 1;
            this.txtVehicleID.TabStop = false;
            // 
            // lblRegistrationNumber
            // 
            this.lblRegistrationNumber.AutoSize = true;
            this.lblRegistrationNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRegistrationNumber.ForeColor = System.Drawing.Color.Black;
            this.lblRegistrationNumber.Location = new System.Drawing.Point(25, 100);
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            this.lblRegistrationNumber.Size = new System.Drawing.Size(130, 17);
            this.lblRegistrationNumber.TabIndex = 2;
            this.lblRegistrationNumber.Text = "Registration Number";
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistrationNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegistrationNumber.Location = new System.Drawing.Point(25, 125);
            this.txtRegistrationNumber.MaxLength = 50;
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(320, 25);
            this.txtRegistrationNumber.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBrand.ForeColor = System.Drawing.Color.Black;
            this.lblBrand.Location = new System.Drawing.Point(25, 165);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(42, 17);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBrand.Location = new System.Drawing.Point(25, 190);
            this.txtBrand.MaxLength = 50;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(150, 25);
            this.txtBrand.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblModel.ForeColor = System.Drawing.Color.Black;
            this.lblModel.Location = new System.Drawing.Point(195, 165);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtModel.Location = new System.Drawing.Point(195, 190);
            this.txtModel.MaxLength = 50;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 25);
            this.txtModel.TabIndex = 2;
             
            // 
            // lblVehicleYear
            // 
            this.lblVehicleYear.AutoSize = true;
            this.lblVehicleYear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblVehicleYear.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleYear.Location = new System.Drawing.Point(25, 230);
            this.lblVehicleYear.Name = "lblVehicleYear";
            this.lblVehicleYear.Size = new System.Drawing.Size(77, 17);
            this.lblVehicleYear.TabIndex = 5;
            this.lblVehicleYear.Text = "Vehicle Year";
            // 
            // nudVehicleYear
            // 
            this.nudVehicleYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudVehicleYear.Location = new System.Drawing.Point(25, 255);
            this.nudVehicleYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudVehicleYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nudVehicleYear.Name = "nudVehicleYear";
            this.nudVehicleYear.Size = new System.Drawing.Size(150, 25);
            this.nudVehicleYear.TabIndex = 3;
            this.nudVehicleYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudVehicleYear.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblVehicleType.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleType.Location = new System.Drawing.Point(195, 230);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(79, 17);
            this.lblVehicleType.TabIndex = 6;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "Car",
            "Bike",
            "Van",
            "Motorcycle",
            "Bicycle"});
            this.cmbVehicleType.Location = new System.Drawing.Point(195, 255);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(150, 25);
            this.cmbVehicleType.SelectedIndex = 0;
            this.cmbVehicleType.TabIndex = 4;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblColor.ForeColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(25, 295);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 17);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtColor.Location = new System.Drawing.Point(25, 320);
            this.txtColor.MaxLength = 30;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(150, 25);
            this.txtColor.TabIndex = 5;
            // 
            // lblDailyPrice
            // 
            this.lblDailyPrice.AutoSize = true;
            this.lblDailyPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDailyPrice.ForeColor = System.Drawing.Color.Black;
            this.lblDailyPrice.Location = new System.Drawing.Point(195, 295);
            this.lblDailyPrice.Name = "lblDailyPrice";
            this.lblDailyPrice.Size = new System.Drawing.Size(68, 17);
            this.lblDailyPrice.TabIndex = 8;
            this.lblDailyPrice.Text = "Daily Price";
            // 
            // nudDailyPrice
            // 
            this.nudDailyPrice.DecimalPlaces = 2;
            this.nudDailyPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudDailyPrice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudDailyPrice.Location = new System.Drawing.Point(195, 320);
            this.nudDailyPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDailyPrice.Name = "nudDailyPrice";
            this.nudDailyPrice.Size = new System.Drawing.Size(150, 25);
            this.nudDailyPrice.TabIndex = 6;
            this.nudDailyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDailyPrice.ThousandsSeparator = true;
            // 
            // lblVehicleStatus
            // 
            this.lblVehicleStatus.AutoSize = true;
            this.lblVehicleStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblVehicleStatus.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleStatus.Location = new System.Drawing.Point(25, 360);
            this.lblVehicleStatus.Name = "lblVehicleStatus";
            this.lblVehicleStatus.Size = new System.Drawing.Size(87, 17);
            this.lblVehicleStatus.TabIndex = 9;
            this.lblVehicleStatus.Text = "Vehicle Status";
            // 
            // cmbVehicleStatus
            // 
            this.cmbVehicleStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVehicleStatus.FormattingEnabled = true;
            this.cmbVehicleStatus.Items.AddRange(new object[] {
            "Available",
            "Rented",
            "Under Maintenance"});
            this.cmbVehicleStatus.Location = new System.Drawing.Point(25, 385);
            this.cmbVehicleStatus.Name = "cmbVehicleStatus";
            this.cmbVehicleStatus.Size = new System.Drawing.Size(320, 25);
            this.cmbVehicleStatus.SelectedIndex = 0;
            this.cmbVehicleStatus.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 445);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(195, 445);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(25, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(195, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnRefresh);
            this.pnlSearch.Location = new System.Drawing.Point(425, 95);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(800, 65);
            this.pnlSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSearch.Location = new System.Drawing.Point(20, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 19);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(85, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(405, 25);
            this.txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(510, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 34);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(650, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 34);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            this.dgvVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(425, 180);
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.RowHeadersVisible = false;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(800, 465);
            this.dgvVehicles.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Location = new System.Drawing.Point(1105, 665);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.grpVehicleInfo);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "VehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Rental System - Vehicle Management";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpVehicleInfo.ResumeLayout(false);
            this.grpVehicleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyPrice)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
