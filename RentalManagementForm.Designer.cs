using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class RentalManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblFilterStatus;
        private ComboBox cmbStatusFilter;
        private Button btnSearch;
        private Button btnRefresh;

        private DataGridView dgvRentals;

        private GroupBox grpRentalAction;
        private Label lblRentalID;
        private TextBox txtRentalID;
        private Label lblCustomer;
        private TextBox txtCustomer;
        private Label lblVehicle;
        private TextBox txtVehicle;
        private Label lblRentalStatus;
        private TextBox txtRentalStatus;
        private Label lblTotalCost;
        private TextBox txtTotalCost;
        private Label lblActualReturnDate;
        private DateTimePicker dtpActualReturnDate;

        private Button btnStartRental;
        private Button btnCancelRental;
        private Button btnReturnVehicle;
        private Button btnShowSummary;
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
            this.lblFilterStatus = new Label();
            this.cmbStatusFilter = new ComboBox();
            this.btnSearch = new Button();
            this.btnRefresh = new Button();

            this.dgvRentals = new DataGridView();

            this.grpRentalAction = new GroupBox();
            this.lblRentalID = new Label();
            this.txtRentalID = new TextBox();
            this.lblCustomer = new Label();
            this.txtCustomer = new TextBox();
            this.lblVehicle = new Label();
            this.txtVehicle = new TextBox();
            this.lblRentalStatus = new Label();
            this.txtRentalStatus = new TextBox();
            this.lblTotalCost = new Label();
            this.txtTotalCost = new TextBox();
            this.lblActualReturnDate = new Label();
            this.dtpActualReturnDate = new DateTimePicker();

            this.btnStartRental = new Button();
            this.btnCancelRental = new Button();
            this.btnReturnVehicle = new Button();
            this.btnShowSummary = new Button();
            this.btnClear = new Button();
            this.btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvRentals)).BeginInit();

            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.grpRentalAction.SuspendLayout();
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

            // Title

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(30, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(330, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "RENTAL MANAGEMENT";

            // Subtitle

            this.lblSubtitle.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font =
                new Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = Color.LightGray;
            this.lblSubtitle.Location = new Point(1020, 28);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new Size(180, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Manage all vehicle rentals";

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
            this.pnlSearch.Controls.Add(this.lblFilterStatus);
            this.pnlSearch.Controls.Add(this.cmbStatusFilter);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnRefresh);
            this.pnlSearch.Location = new Point(25, 95);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new Size(800, 65);
            this.pnlSearch.TabIndex = 1;

            // Search Label

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblSearch.ForeColor = Color.MidnightBlue;
            this.lblSearch.Location = new Point(15, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new Size(55, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";

            // Search TextBox

            this.txtSearch.Font =
                new Font("Segoe UI", 10F);
            this.txtSearch.Location = new Point(78, 18);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(200, 25);
            this.txtSearch.TabIndex = 0;

            // Filter Label

            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblFilterStatus.ForeColor =
                Color.MidnightBlue;
            this.lblFilterStatus.Location =
                new Point(295, 22);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new Size(50, 17);
            this.lblFilterStatus.TabIndex = 2;
            this.lblFilterStatus.Text = "Status:";

            // Status Filter ComboBox

            this.cmbStatusFilter.DropDownStyle =
                ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.Font =
                new Font("Segoe UI", 10F);
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Items.AddRange(
                new object[]
                {
                    "All",
                    "Booked",
                    "Active",
                    "Returned",
                    "Cancelled"
                });
            this.cmbStatusFilter.Location =
                new Point(350, 18);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new Size(145, 25);
            this.cmbStatusFilter.SelectedIndex = 0;
            this.cmbStatusFilter.TabIndex = 1;

            // Search Button

            this.btnSearch.BackColor = Color.MidnightBlue;
            this.btnSearch.Cursor = Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new Point(515, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(120, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;

            // Refresh Button

            this.btnRefresh.BackColor = Color.SteelBlue;
            this.btnRefresh.Cursor = Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Location = new Point(650, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(125, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;

            // =====================================
            // Rentals DataGridView
            // =====================================

            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AllowUserToDeleteRows = false;
            this.dgvRentals.AllowUserToResizeRows = false;
            this.dgvRentals.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;
            this.dgvRentals.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentals.BackgroundColor = Color.White;
            this.dgvRentals.BorderStyle =
                BorderStyle.FixedSingle;
            this.dgvRentals.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new Point(25, 180);
            this.dgvRentals.MultiSelect = false;
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new Size(800, 515);
            this.dgvRentals.TabIndex = 4;

            // =====================================
            // Rental Action GroupBox
            // =====================================

            this.grpRentalAction.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Right;
            this.grpRentalAction.BackColor = Color.White;
            this.grpRentalAction.Controls.Add(this.lblRentalID);
            this.grpRentalAction.Controls.Add(this.txtRentalID);
            this.grpRentalAction.Controls.Add(this.lblCustomer);
            this.grpRentalAction.Controls.Add(this.txtCustomer);
            this.grpRentalAction.Controls.Add(this.lblVehicle);
            this.grpRentalAction.Controls.Add(this.txtVehicle);
            this.grpRentalAction.Controls.Add(
                this.lblRentalStatus);
            this.grpRentalAction.Controls.Add(
                this.txtRentalStatus);
            this.grpRentalAction.Controls.Add(
                this.lblTotalCost);
            this.grpRentalAction.Controls.Add(
                this.txtTotalCost);
            this.grpRentalAction.Controls.Add(
                this.lblActualReturnDate);
            this.grpRentalAction.Controls.Add(
                this.dtpActualReturnDate);
            this.grpRentalAction.Controls.Add(
                this.btnStartRental);
            this.grpRentalAction.Controls.Add(
                this.btnCancelRental);
            this.grpRentalAction.Controls.Add(
                this.btnReturnVehicle);
            this.grpRentalAction.Controls.Add(
                this.btnShowSummary);
            this.grpRentalAction.Controls.Add(this.btnClear);
            this.grpRentalAction.Controls.Add(this.btnBack);

            this.grpRentalAction.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            this.grpRentalAction.ForeColor =
                Color.MidnightBlue;
            this.grpRentalAction.Location =
                new Point(850, 95);
            this.grpRentalAction.Name = "grpRentalAction";
            this.grpRentalAction.Size = new Size(375, 600);
            this.grpRentalAction.TabIndex = 2;
            this.grpRentalAction.TabStop = false;
            this.grpRentalAction.Text =
                "Selected Rental Information";

            // =====================================
            // Rental ID
            // =====================================

            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font =
                new Font("Segoe UI", 9.5F);
            this.lblRentalID.ForeColor = Color.Black;
            this.lblRentalID.Location = new Point(25, 35);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new Size(65, 17);
            this.lblRentalID.TabIndex = 0;
            this.lblRentalID.Text = "Rental ID";

            this.txtRentalID.BackColor = Color.Gainsboro;
            this.txtRentalID.Font =
                new Font("Segoe UI", 10F);
            this.txtRentalID.Location = new Point(25, 60);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.ReadOnly = true;
            this.txtRentalID.Size = new Size(325, 25);
            this.txtRentalID.TabStop = false;

            // =====================================
            // Customer
            // =====================================

            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font =
                new Font("Segoe UI", 9.5F);
            this.lblCustomer.ForeColor = Color.Black;
            this.lblCustomer.Location = new Point(25, 100);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new Size(70, 17);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer";

            this.txtCustomer.BackColor = Color.Gainsboro;
            this.txtCustomer.Font =
                new Font("Segoe UI", 10F);
            this.txtCustomer.Location = new Point(25, 125);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new Size(325, 25);
            this.txtCustomer.TabStop = false;

            // =====================================
            // Vehicle
            // =====================================

            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font =
                new Font("Segoe UI", 9.5F);
            this.lblVehicle.ForeColor = Color.Black;
            this.lblVehicle.Location = new Point(25, 165);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new Size(55, 17);
            this.lblVehicle.TabIndex = 4;
            this.lblVehicle.Text = "Vehicle";

            this.txtVehicle.BackColor = Color.Gainsboro;
            this.txtVehicle.Font =
                new Font("Segoe UI", 10F);
            this.txtVehicle.Location = new Point(25, 190);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.ReadOnly = true;
            this.txtVehicle.Size = new Size(325, 25);
            this.txtVehicle.TabStop = false;

            // =====================================
            // Rental Status
            // =====================================

            this.lblRentalStatus.AutoSize = true;
            this.lblRentalStatus.Font =
                new Font("Segoe UI", 9.5F);
            this.lblRentalStatus.ForeColor = Color.Black;
            this.lblRentalStatus.Location =
                new Point(25, 230);
            this.lblRentalStatus.Name = "lblRentalStatus";
            this.lblRentalStatus.Size = new Size(90, 17);
            this.lblRentalStatus.TabIndex = 6;
            this.lblRentalStatus.Text = "Rental Status";

            this.txtRentalStatus.BackColor =
                Color.Gainsboro;
            this.txtRentalStatus.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.txtRentalStatus.Location =
                new Point(25, 255);
            this.txtRentalStatus.Name = "txtRentalStatus";
            this.txtRentalStatus.ReadOnly = true;
            this.txtRentalStatus.Size = new Size(150, 25);
            this.txtRentalStatus.TabStop = false;

            // =====================================
            // Total Cost
            // =====================================

            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font =
                new Font("Segoe UI", 9.5F);
            this.lblTotalCost.ForeColor = Color.Black;
            this.lblTotalCost.Location =
                new Point(200, 230);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new Size(70, 17);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Total Cost";

            this.txtTotalCost.BackColor = Color.Gainsboro;
            this.txtTotalCost.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.txtTotalCost.ForeColor = Color.Firebrick;
            this.txtTotalCost.Location =
                new Point(200, 255);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new Size(150, 25);
            this.txtTotalCost.TabStop = false;
            this.txtTotalCost.Text = "0.00";
            this.txtTotalCost.TextAlign =
                HorizontalAlignment.Right;

            // =====================================
            // Actual Return Date
            // =====================================

            this.lblActualReturnDate.AutoSize = true;
            this.lblActualReturnDate.Font =
                new Font("Segoe UI", 9.5F);
            this.lblActualReturnDate.ForeColor =
                Color.Black;
            this.lblActualReturnDate.Location =
                new Point(25, 295);
            this.lblActualReturnDate.Name =
                "lblActualReturnDate";
            this.lblActualReturnDate.Size =
                new Size(125, 17);
            this.lblActualReturnDate.TabIndex = 10;
            this.lblActualReturnDate.Text =
                "Actual Return Date";

            this.dtpActualReturnDate.CustomFormat =
                "dd-MM-yyyy";
            this.dtpActualReturnDate.Font =
                new Font("Segoe UI", 10F);
            this.dtpActualReturnDate.Format =
                DateTimePickerFormat.Custom;
            this.dtpActualReturnDate.Location =
                new Point(25, 320);
            this.dtpActualReturnDate.Name =
                "dtpActualReturnDate";
            this.dtpActualReturnDate.Size =
                new Size(325, 25);
            this.dtpActualReturnDate.TabIndex = 5;

            // =====================================
            // Start Rental Button
            // =====================================

            this.btnStartRental.BackColor = Color.SeaGreen;
            this.btnStartRental.Cursor = Cursors.Hand;
            this.btnStartRental.FlatAppearance.BorderSize = 0;
            this.btnStartRental.FlatStyle = FlatStyle.Flat;
            this.btnStartRental.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnStartRental.ForeColor = Color.White;
            this.btnStartRental.Location =
                new Point(25, 375);
            this.btnStartRental.Name = "btnStartRental";
            this.btnStartRental.Size = new Size(150, 38);
            this.btnStartRental.TabIndex = 6;
            this.btnStartRental.Text = "START RENTAL";
            this.btnStartRental.UseVisualStyleBackColor =
                false;

            // Cancel Rental Button

            this.btnCancelRental.BackColor = Color.Firebrick;
            this.btnCancelRental.Cursor = Cursors.Hand;
            this.btnCancelRental.FlatAppearance.BorderSize = 0;
            this.btnCancelRental.FlatStyle = FlatStyle.Flat;
            this.btnCancelRental.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnCancelRental.ForeColor = Color.White;
            this.btnCancelRental.Location =
                new Point(200, 375);
            this.btnCancelRental.Name = "btnCancelRental";
            this.btnCancelRental.Size = new Size(150, 38);
            this.btnCancelRental.TabIndex = 7;
            this.btnCancelRental.Text = "CANCEL RENTAL";
            this.btnCancelRental.UseVisualStyleBackColor =
                false;

            // Return Vehicle Button

            this.btnReturnVehicle.BackColor = Color.DarkOrange;
            this.btnReturnVehicle.Cursor = Cursors.Hand;
            this.btnReturnVehicle.FlatAppearance.BorderSize = 0;
            this.btnReturnVehicle.FlatStyle = FlatStyle.Flat;
            this.btnReturnVehicle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnReturnVehicle.ForeColor = Color.White;
            this.btnReturnVehicle.Location =
                new Point(25, 430);
            this.btnReturnVehicle.Name = "btnReturnVehicle";
            this.btnReturnVehicle.Size = new Size(325, 38);
            this.btnReturnVehicle.TabIndex = 8;
            this.btnReturnVehicle.Text = "RETURN VEHICLE";
            this.btnReturnVehicle.UseVisualStyleBackColor =
                false;

            // Summary Button

            this.btnShowSummary.BackColor = Color.SteelBlue;
            this.btnShowSummary.Cursor = Cursors.Hand;
            this.btnShowSummary.FlatAppearance.BorderSize = 0;
            this.btnShowSummary.FlatStyle = FlatStyle.Flat;
            this.btnShowSummary.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnShowSummary.ForeColor = Color.White;
            this.btnShowSummary.Location =
                new Point(25, 485);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new Size(150, 38);
            this.btnShowSummary.TabIndex = 9;
            this.btnShowSummary.Text = "SHOW SUMMARY";
            this.btnShowSummary.UseVisualStyleBackColor =
                false;

            // Clear Button

            this.btnClear.BackColor = Color.DimGray;
            this.btnClear.Cursor = Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Location = new Point(200, 485);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(150, 38);
            this.btnClear.TabIndex = 10;
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
            this.btnBack.Location = new Point(25, 540);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(325, 38);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;

            // =====================================
            // RentalManagementForm
            // =====================================

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(1250, 720);
            this.Controls.Add(this.grpRentalAction);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(1100, 650);
            this.Name = "RentalManagementForm";
            this.StartPosition =
                FormStartPosition.CenterScreen;
            this.Text = "Vehicle Rental System - Rental Management";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvRentals)).EndInit();

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.grpRentalAction.ResumeLayout(false);
            this.grpRentalAction.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
