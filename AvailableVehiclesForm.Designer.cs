using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class AvailableVehiclesForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblFilterType;
        private ComboBox cmbFilterType;
        private Button btnSearch;
        private Button btnRefresh;

        private DataGridView dgvAvailableVehicles;

        private GroupBox grpBooking;
        private Label lblSelectedVehicleID;
        private TextBox txtSelectedVehicleID;
        private Label lblRegistrationNumber;
        private TextBox txtRegistrationNumber;
        private Label lblVehicleDetails;
        private TextBox txtVehicleDetails;
        private Label lblPricePerDay;
        private TextBox txtPricePerDay;
        private Label lblRentalDate;
        private DateTimePicker dtpRentalDate;
        private Label lblReturnDate;
        private DateTimePicker dtpReturnDate;
        private Label lblRentalDuration;
        private TextBox txtRentalDuration;
        private Label lblTotalCost;
        private TextBox txtTotalCost;

        private Button btnCalculate;
        private Button btnBook;
        private Button btnClear;
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

            this.pnlSearch = new Panel();
            this.lblSearch = new Label();
            this.txtSearch = new TextBox();
            this.lblFilterType = new Label();
            this.cmbFilterType = new ComboBox();
            this.btnSearch = new Button();
            this.btnRefresh = new Button();

            this.dgvAvailableVehicles = new DataGridView();

            this.grpBooking = new GroupBox();
            this.lblSelectedVehicleID = new Label();
            this.txtSelectedVehicleID = new TextBox();
            this.lblRegistrationNumber = new Label();
            this.txtRegistrationNumber = new TextBox();
            this.lblVehicleDetails = new Label();
            this.txtVehicleDetails = new TextBox();
            this.lblPricePerDay = new Label();
            this.txtPricePerDay = new TextBox();
            this.lblRentalDate = new Label();
            this.dtpRentalDate = new DateTimePicker();
            this.lblReturnDate = new Label();
            this.dtpReturnDate = new DateTimePicker();
            this.lblRentalDuration = new Label();
            this.txtRentalDuration = new TextBox();
            this.lblTotalCost = new Label();
            this.txtTotalCost = new TextBox();

            this.btnCalculate = new Button();
            this.btnBook = new Button();
            this.btnClear = new Button();
            this.btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvAvailableVehicles)).BeginInit();

            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.grpBooking.SuspendLayout();
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
            this.lblTitle.Text = "AVAILABLE VEHICLES";

            this.lblSubtitle.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = Color.LightGray;
            this.lblSubtitle.Location = new Point(987, 28);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Select and book your preferred vehicle";

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
            this.pnlSearch.Controls.Add(this.lblFilterType);
            this.pnlSearch.Controls.Add(this.cmbFilterType);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnRefresh);
            this.pnlSearch.Location = new Point(25, 95);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new Size(795, 65);
            this.pnlSearch.TabIndex = 1;

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblSearch.ForeColor = Color.MidnightBlue;
            this.lblSearch.Location = new Point(15, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Search:";

            this.txtSearch.Font = new Font("Segoe UI", 10F);
            this.txtSearch.Location = new Point(80, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(215, 25);
            this.txtSearch.TabIndex = 0;

            this.lblFilterType.AutoSize = true;
            this.lblFilterType.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblFilterType.ForeColor = Color.MidnightBlue;
            this.lblFilterType.Location = new Point(310, 22);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Text = "Type:";

            this.cmbFilterType.DropDownStyle =
                ComboBoxStyle.DropDownList;
            this.cmbFilterType.Font = new Font("Segoe UI", 10F);
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Items.AddRange(
                new object[]
                {
                    "All",
                    "Car",
                    "Bike",
                    "Van",
                    "Microbus"
                });
            this.cmbFilterType.Location = new Point(360, 18);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new Size(140, 25);
            this.cmbFilterType.SelectedIndex = 0;
            this.cmbFilterType.TabIndex = 1;

            this.btnSearch.BackColor = Color.MidnightBlue;
            this.btnSearch.Cursor = Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new Point(520, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(115, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;

            this.btnRefresh.BackColor = Color.SteelBlue;
            this.btnRefresh.Cursor = Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Location = new Point(650, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(120, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;

            // =====================================
            // Available Vehicles DataGridView
            // =====================================

            this.dgvAvailableVehicles.AllowUserToAddRows = false;
            this.dgvAvailableVehicles.AllowUserToDeleteRows = false;
            this.dgvAvailableVehicles.AllowUserToResizeRows = false;
            this.dgvAvailableVehicles.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;
            this.dgvAvailableVehicles.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableVehicles.BackgroundColor =
                Color.White;
            this.dgvAvailableVehicles.BorderStyle =
                BorderStyle.FixedSingle;
            this.dgvAvailableVehicles.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableVehicles.Location =
                new Point(25, 180);
            this.dgvAvailableVehicles.MultiSelect = false;
            this.dgvAvailableVehicles.Name =
                "dgvAvailableVehicles";
            this.dgvAvailableVehicles.ReadOnly = true;
            this.dgvAvailableVehicles.RowHeadersVisible = false;
            this.dgvAvailableVehicles.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableVehicles.Size =
                new Size(795, 465);
            this.dgvAvailableVehicles.TabIndex = 4;

            // =====================================
            // Booking GroupBox
            // =====================================

            this.grpBooking.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Right;
            this.grpBooking.BackColor = Color.White;
            this.grpBooking.Controls.Add(
                this.lblSelectedVehicleID);
            this.grpBooking.Controls.Add(
                this.txtSelectedVehicleID);
            this.grpBooking.Controls.Add(
                this.lblRegistrationNumber);
            this.grpBooking.Controls.Add(
                this.txtRegistrationNumber);
            this.grpBooking.Controls.Add(
                this.lblVehicleDetails);
            this.grpBooking.Controls.Add(
                this.txtVehicleDetails);
            this.grpBooking.Controls.Add(this.lblPricePerDay);
            this.grpBooking.Controls.Add(this.txtPricePerDay);
            this.grpBooking.Controls.Add(this.lblRentalDate);
            this.grpBooking.Controls.Add(this.dtpRentalDate);
            this.grpBooking.Controls.Add(this.lblReturnDate);
            this.grpBooking.Controls.Add(this.dtpReturnDate);
            this.grpBooking.Controls.Add(
                this.lblRentalDuration);
            this.grpBooking.Controls.Add(
                this.txtRentalDuration);
            this.grpBooking.Controls.Add(this.lblTotalCost);
            this.grpBooking.Controls.Add(this.txtTotalCost);
            this.grpBooking.Controls.Add(this.btnCalculate);
            this.grpBooking.Controls.Add(this.btnBook);
            this.grpBooking.Controls.Add(this.btnClear);
            this.grpBooking.Controls.Add(this.btnBack);

            this.grpBooking.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            this.grpBooking.ForeColor = Color.MidnightBlue;
            this.grpBooking.Location = new Point(845, 95);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Size = new Size(380, 610);
            this.grpBooking.TabIndex = 2;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Rental Booking";

            // Selected Vehicle ID

            this.lblSelectedVehicleID.AutoSize = true;
            this.lblSelectedVehicleID.Font =
                new Font("Segoe UI", 9.5F);
            this.lblSelectedVehicleID.ForeColor = Color.Black;
            this.lblSelectedVehicleID.Location =
                new Point(25, 35);
            this.lblSelectedVehicleID.Name =
                "lblSelectedVehicleID";
            this.lblSelectedVehicleID.Text = "Vehicle ID";

            this.txtSelectedVehicleID.BackColor =
                Color.Gainsboro;
            this.txtSelectedVehicleID.Font =
                new Font("Segoe UI", 10F);
            this.txtSelectedVehicleID.Location =
                new Point(25, 60);
            this.txtSelectedVehicleID.Name =
                "txtSelectedVehicleID";
            this.txtSelectedVehicleID.ReadOnly = true;
            this.txtSelectedVehicleID.Size =
                new Size(330, 25);
            this.txtSelectedVehicleID.TabStop = false;

            // Registration Number

            this.lblRegistrationNumber.AutoSize = true;
            this.lblRegistrationNumber.Font =
                new Font("Segoe UI", 9.5F);
            this.lblRegistrationNumber.ForeColor =
                Color.Black;
            this.lblRegistrationNumber.Location =
                new Point(25, 100);
            this.lblRegistrationNumber.Name =
                "lblRegistrationNumber";
            this.lblRegistrationNumber.Text =
                "Registration Number";

            this.txtRegistrationNumber.BackColor =
                Color.Gainsboro;
            this.txtRegistrationNumber.Font =
                new Font("Segoe UI", 10F);
            this.txtRegistrationNumber.Location =
                new Point(25, 125);
            this.txtRegistrationNumber.Name =
                "txtRegistrationNumber";
            this.txtRegistrationNumber.ReadOnly = true;
            this.txtRegistrationNumber.Size =
                new Size(330, 25);
            this.txtRegistrationNumber.TabStop = false;

            // Vehicle Details

            this.lblVehicleDetails.AutoSize = true;
            this.lblVehicleDetails.Font =
                new Font("Segoe UI", 9.5F);
            this.lblVehicleDetails.ForeColor = Color.Black;
            this.lblVehicleDetails.Location =
                new Point(25, 165);
            this.lblVehicleDetails.Name = "lblVehicleDetails";
            this.lblVehicleDetails.Text =
                "Brand, Model and Type";

            this.txtVehicleDetails.BackColor =
                Color.Gainsboro;
            this.txtVehicleDetails.Font =
                new Font("Segoe UI", 10F);
            this.txtVehicleDetails.Location =
                new Point(25, 190);
            this.txtVehicleDetails.Name = "txtVehicleDetails";
            this.txtVehicleDetails.ReadOnly = true;
            this.txtVehicleDetails.Size =
                new Size(330, 25);
            this.txtVehicleDetails.TabStop = false;

            // Price Per Day

            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Font =
                new Font("Segoe UI", 9.5F);
            this.lblPricePerDay.ForeColor = Color.Black;
            this.lblPricePerDay.Location =
                new Point(25, 230);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Text = "Price Per Day";

            this.txtPricePerDay.BackColor = Color.Gainsboro;
            this.txtPricePerDay.Font =
                new Font("Segoe UI", 10F);
            this.txtPricePerDay.Location =
                new Point(25, 255);
            this.txtPricePerDay.Name = "txtPricePerDay";
            this.txtPricePerDay.ReadOnly = true;
            this.txtPricePerDay.Size = new Size(330, 25);
            this.txtPricePerDay.TabStop = false;
            this.txtPricePerDay.TextAlign =
                HorizontalAlignment.Right;

            // Rental Date

            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Font =
                new Font("Segoe UI", 9.5F);
            this.lblRentalDate.ForeColor = Color.Black;
            this.lblRentalDate.Location =
                new Point(25, 295);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Text = "Rental Date";

            this.dtpRentalDate.CustomFormat = "dd-MM-yyyy";
            this.dtpRentalDate.Font =
                new Font("Segoe UI", 10F);
            this.dtpRentalDate.Format =
                DateTimePickerFormat.Custom;
            this.dtpRentalDate.Location =
                new Point(25, 320);
            this.dtpRentalDate.Name = "dtpRentalDate";
            this.dtpRentalDate.Size = new Size(150, 25);
            this.dtpRentalDate.TabIndex = 5;

            // Return Date

            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font =
                new Font("Segoe UI", 9.5F);
            this.lblReturnDate.ForeColor = Color.Black;
            this.lblReturnDate.Location =
                new Point(205, 295);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Text = "Return Date";

            this.dtpReturnDate.CustomFormat = "dd-MM-yyyy";
            this.dtpReturnDate.Font =
                new Font("Segoe UI", 10F);
            this.dtpReturnDate.Format =
                DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location =
                new Point(205, 320);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new Size(150, 25);
            this.dtpReturnDate.TabIndex = 6;

            // Rental Duration

            this.lblRentalDuration.AutoSize = true;
            this.lblRentalDuration.Font =
                new Font("Segoe UI", 9.5F);
            this.lblRentalDuration.ForeColor = Color.Black;
            this.lblRentalDuration.Location =
                new Point(25, 360);
            this.lblRentalDuration.Name =
                "lblRentalDuration";
            this.lblRentalDuration.Text = "Rental Days";

            this.txtRentalDuration.BackColor =
                Color.Gainsboro;
            this.txtRentalDuration.Font =
                new Font("Segoe UI", 10F);
            this.txtRentalDuration.Location =
                new Point(25, 385);
            this.txtRentalDuration.Name =
                "txtRentalDuration";
            this.txtRentalDuration.ReadOnly = true;
            this.txtRentalDuration.Size =
                new Size(150, 25);
            this.txtRentalDuration.TabStop = false;
            this.txtRentalDuration.TextAlign =
                HorizontalAlignment.Center;

            // Total Cost

            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font =
                new Font("Segoe UI", 9.5F);
            this.lblTotalCost.ForeColor = Color.Black;
            this.lblTotalCost.Location =
                new Point(205, 360);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Text = "Total Cost";

            this.txtTotalCost.BackColor = Color.Gainsboro;
            this.txtTotalCost.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.txtTotalCost.ForeColor = Color.Firebrick;
            this.txtTotalCost.Location =
                new Point(205, 385);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new Size(150, 25);
            this.txtTotalCost.TabStop = false;
            this.txtTotalCost.Text = "0.00";
            this.txtTotalCost.TextAlign =
                HorizontalAlignment.Right;

            // Calculate Button

            this.btnCalculate.BackColor = Color.DarkOrange;
            this.btnCalculate.Cursor = Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = FlatStyle.Flat;
            this.btnCalculate.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnCalculate.ForeColor = Color.White;
            this.btnCalculate.Location =
                new Point(25, 440);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new Size(155, 40);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor =
                false;

            // Book Button

            this.btnBook.BackColor = Color.SeaGreen;
            this.btnBook.Cursor = Cursors.Hand;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = FlatStyle.Flat;
            this.btnBook.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnBook.ForeColor = Color.White;
            this.btnBook.Location = new Point(200, 440);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new Size(155, 40);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "BOOK VEHICLE";
            this.btnBook.UseVisualStyleBackColor = false;

            // Clear Button

            this.btnClear.BackColor = Color.DimGray;
            this.btnClear.Cursor = Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Location = new Point(25, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(155, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;

            // Back Button

            this.btnBack.BackColor = Color.White;
            this.btnBack.Cursor = Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor =
                Color.MidnightBlue;
            this.btnBack.FlatAppearance.BorderSize = 1;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnBack.ForeColor = Color.MidnightBlue;
            this.btnBack.Location = new Point(200, 500);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(155, 40);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;

            // =====================================
            // AvailableVehiclesForm
            // =====================================

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(1250, 720);
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.dgvAvailableVehicles);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(1100, 650);
            this.Name = "AvailableVehiclesForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text =
                "Vehicle Rental System - Available Vehicles";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvAvailableVehicles)).EndInit();

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
