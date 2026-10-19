using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class MyRentalsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlFilter;
        private Label lblFilterStatus;
        private ComboBox cmbRentalStatusFilter;
        private Button btnFilter;
        private Button btnRefresh;

        private DataGridView dgvMyRentals;

        private GroupBox grpSelectedRental;
        private Label lblRentalID;
        private TextBox txtRentalID;
        private Label lblVehicle;
        private TextBox txtVehicle;
        private Label lblRentalPeriod;
        private TextBox txtRentalPeriod;
        private Label lblRentalStatus;
        private TextBox txtRentalStatus;
        private Label lblTotalCost;
        private TextBox txtTotalCost;
        private Label lblPaymentStatus;
        private TextBox txtPaymentStatus;
        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;

        private Button btnCancelBooking;
        private Button btnReturnVehicle;
        private Button btnPayNow;
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

            this.pnlFilter = new Panel();
            this.lblFilterStatus = new Label();
            this.cmbRentalStatusFilter = new ComboBox();
            this.btnFilter = new Button();
            this.btnRefresh = new Button();

            this.dgvMyRentals = new DataGridView();

            this.grpSelectedRental = new GroupBox();
            this.lblRentalID = new Label();
            this.txtRentalID = new TextBox();
            this.lblVehicle = new Label();
            this.txtVehicle = new TextBox();
            this.lblRentalPeriod = new Label();
            this.txtRentalPeriod = new TextBox();
            this.lblRentalStatus = new Label();
            this.txtRentalStatus = new TextBox();
            this.lblTotalCost = new Label();
            this.txtTotalCost = new TextBox();
            this.lblPaymentStatus = new Label();
            this.txtPaymentStatus = new TextBox();
            this.lblPaymentMethod = new Label();
            this.cmbPaymentMethod = new ComboBox();

            this.btnCancelBooking = new Button();
            this.btnReturnVehicle = new Button();
            this.btnPayNow = new Button();
            this.btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvMyRentals)).BeginInit();

            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.grpSelectedRental.SuspendLayout();
            this.SuspendLayout();

            // =====================================
            // Header
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
            this.lblTitle.Text = "MY RENTALS";

            this.lblSubtitle.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = Color.LightGray;
            this.lblSubtitle.Location = new Point(1000, 28);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "View and manage your rentals";

            // =====================================
            // Filter Panel
            // =====================================

            this.pnlFilter.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;
            this.pnlFilter.BackColor = Color.White;
            this.pnlFilter.Controls.Add(this.lblFilterStatus);
            this.pnlFilter.Controls.Add(
                this.cmbRentalStatusFilter);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.btnRefresh);
            this.pnlFilter.Location = new Point(25, 95);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new Size(800, 65);
            this.pnlFilter.TabIndex = 1;

            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblFilterStatus.ForeColor = Color.MidnightBlue;
            this.lblFilterStatus.Location = new Point(20, 22);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Text = "Rental Status:";

            this.cmbRentalStatusFilter.DropDownStyle =
                ComboBoxStyle.DropDownList;
            this.cmbRentalStatusFilter.Font =
                new Font("Segoe UI", 10F);
            this.cmbRentalStatusFilter.FormattingEnabled = true;
            this.cmbRentalStatusFilter.Items.AddRange(
                new object[]
                {
                    "All",
                    "Booked",
                    "Active",
                    "Returned",
                    "Cancelled"
                });
            this.cmbRentalStatusFilter.Location =
                new Point(135, 18);
            this.cmbRentalStatusFilter.Name =
                "cmbRentalStatusFilter";
            this.cmbRentalStatusFilter.Size =
                new Size(210, 25);
            this.cmbRentalStatusFilter.SelectedIndex = 0;
            this.cmbRentalStatusFilter.TabIndex = 0;

            this.btnFilter.BackColor = Color.MidnightBlue;
            this.btnFilter.Cursor = Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = FlatStyle.Flat;
            this.btnFilter.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnFilter.ForeColor = Color.White;
            this.btnFilter.Location = new Point(370, 15);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new Size(120, 34);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = false;

            this.btnRefresh.BackColor = Color.SteelBlue;
            this.btnRefresh.Cursor = Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Location = new Point(510, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(120, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;

            // =====================================
            // Rentals DataGridView
            // =====================================

            this.dgvMyRentals.AllowUserToAddRows = false;
            this.dgvMyRentals.AllowUserToDeleteRows = false;
            this.dgvMyRentals.AllowUserToResizeRows = false;
            this.dgvMyRentals.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;
            this.dgvMyRentals.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyRentals.BackgroundColor = Color.White;
            this.dgvMyRentals.BorderStyle =
                BorderStyle.FixedSingle;
            this.dgvMyRentals.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyRentals.Location = new Point(25, 180);
            this.dgvMyRentals.MultiSelect = false;
            this.dgvMyRentals.Name = "dgvMyRentals";
            this.dgvMyRentals.ReadOnly = true;
            this.dgvMyRentals.RowHeadersVisible = false;
            this.dgvMyRentals.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyRentals.Size = new Size(800, 515);
            this.dgvMyRentals.TabIndex = 3;

            // =====================================
            // Selected Rental GroupBox
            // =====================================

            this.grpSelectedRental.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Right;
            this.grpSelectedRental.BackColor = Color.White;
            this.grpSelectedRental.Controls.Add(this.lblRentalID);
            this.grpSelectedRental.Controls.Add(this.txtRentalID);
            this.grpSelectedRental.Controls.Add(this.lblVehicle);
            this.grpSelectedRental.Controls.Add(this.txtVehicle);
            this.grpSelectedRental.Controls.Add(
                this.lblRentalPeriod);
            this.grpSelectedRental.Controls.Add(
                this.txtRentalPeriod);
            this.grpSelectedRental.Controls.Add(
                this.lblRentalStatus);
            this.grpSelectedRental.Controls.Add(
                this.txtRentalStatus);
            this.grpSelectedRental.Controls.Add(
                this.lblTotalCost);
            this.grpSelectedRental.Controls.Add(
                this.txtTotalCost);
            this.grpSelectedRental.Controls.Add(
                this.lblPaymentStatus);
            this.grpSelectedRental.Controls.Add(
                this.txtPaymentStatus);
            this.grpSelectedRental.Controls.Add(
                this.lblPaymentMethod);
            this.grpSelectedRental.Controls.Add(
                this.cmbPaymentMethod);
            this.grpSelectedRental.Controls.Add(
                this.btnCancelBooking);
            this.grpSelectedRental.Controls.Add(
                this.btnReturnVehicle);
            this.grpSelectedRental.Controls.Add(
                this.btnPayNow);
            this.grpSelectedRental.Controls.Add(this.btnBack);

            this.grpSelectedRental.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            this.grpSelectedRental.ForeColor = Color.MidnightBlue;
            this.grpSelectedRental.Location =
                new Point(850, 95);
            this.grpSelectedRental.Name = "grpSelectedRental";
            this.grpSelectedRental.Size = new Size(375, 600);
            this.grpSelectedRental.TabIndex = 2;
            this.grpSelectedRental.TabStop = false;
            this.grpSelectedRental.Text =
                "Selected Rental Information";

            // Rental ID

            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font = new Font("Segoe UI", 9.5F);
            this.lblRentalID.ForeColor = Color.Black;
            this.lblRentalID.Location = new Point(25, 40);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Text = "Rental ID";

            this.txtRentalID.BackColor = Color.Gainsboro;
            this.txtRentalID.Font = new Font("Segoe UI", 10F);
            this.txtRentalID.Location = new Point(25, 65);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.ReadOnly = true;
            this.txtRentalID.Size = new Size(325, 25);
            this.txtRentalID.TabStop = false;

            // Vehicle

            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new Font("Segoe UI", 9.5F);
            this.lblVehicle.ForeColor = Color.Black;
            this.lblVehicle.Location = new Point(25, 105);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Text = "Vehicle";

            this.txtVehicle.BackColor = Color.Gainsboro;
            this.txtVehicle.Font = new Font("Segoe UI", 10F);
            this.txtVehicle.Location = new Point(25, 130);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.ReadOnly = true;
            this.txtVehicle.Size = new Size(325, 25);
            this.txtVehicle.TabStop = false;

            // Rental Period

            this.lblRentalPeriod.AutoSize = true;
            this.lblRentalPeriod.Font =
                new Font("Segoe UI", 9.5F);
            this.lblRentalPeriod.ForeColor = Color.Black;
            this.lblRentalPeriod.Location =
                new Point(25, 170);
            this.lblRentalPeriod.Name = "lblRentalPeriod";
            this.lblRentalPeriod.Text = "Rental Period";

            this.txtRentalPeriod.BackColor = Color.Gainsboro;
            this.txtRentalPeriod.Font =
                new Font("Segoe UI", 10F);
            this.txtRentalPeriod.Location =
                new Point(25, 195);
            this.txtRentalPeriod.Name = "txtRentalPeriod";
            this.txtRentalPeriod.ReadOnly = true;
            this.txtRentalPeriod.Size = new Size(325, 25);
            this.txtRentalPeriod.TabStop = false;

            // Rental Status

            this.lblRentalStatus.AutoSize = true;
            this.lblRentalStatus.Font =
                new Font("Segoe UI", 9.5F);
            this.lblRentalStatus.ForeColor = Color.Black;
            this.lblRentalStatus.Location =
                new Point(25, 235);
            this.lblRentalStatus.Name = "lblRentalStatus";
            this.lblRentalStatus.Text = "Rental Status";

            this.txtRentalStatus.BackColor = Color.Gainsboro;
            this.txtRentalStatus.Font =
                new Font("Segoe UI", 10F);
            this.txtRentalStatus.Location =
                new Point(25, 260);
            this.txtRentalStatus.Name = "txtRentalStatus";
            this.txtRentalStatus.ReadOnly = true;
            this.txtRentalStatus.Size = new Size(325, 25);
            this.txtRentalStatus.TabStop = false;

            // Total Cost

            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font =
                new Font("Segoe UI", 9.5F);
            this.lblTotalCost.ForeColor = Color.Black;
            this.lblTotalCost.Location =
                new Point(25, 300);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Text = "Total Cost";

            this.txtTotalCost.BackColor = Color.Gainsboro;
            this.txtTotalCost.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.txtTotalCost.ForeColor = Color.Firebrick;
            this.txtTotalCost.Location = new Point(25, 325);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new Size(150, 25);
            this.txtTotalCost.TabStop = false;
            this.txtTotalCost.Text = "0.00";
            this.txtTotalCost.TextAlign =
                HorizontalAlignment.Right;

            // Payment Status

            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font =
                new Font("Segoe UI", 9.5F);
            this.lblPaymentStatus.ForeColor = Color.Black;
            this.lblPaymentStatus.Location =
                new Point(200, 300);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Text = "Payment Status";

            this.txtPaymentStatus.BackColor = Color.Gainsboro;
            this.txtPaymentStatus.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.txtPaymentStatus.Location =
                new Point(200, 325);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.ReadOnly = true;
            this.txtPaymentStatus.Size = new Size(150, 25);
            this.txtPaymentStatus.TabStop = false;

            // Payment Method

            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font =
                new Font("Segoe UI", 9.5F);
            this.lblPaymentMethod.ForeColor = Color.Black;
            this.lblPaymentMethod.Location =
                new Point(25, 365);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new Size(105, 17);
            this.lblPaymentMethod.TabIndex = 4;
            this.lblPaymentMethod.Text = "Payment Method";

            this.cmbPaymentMethod.DropDownStyle =
                ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font =
                new Font("Segoe UI", 10F);
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(
                new object[]
                {
                    "Cash",
                    "Credit Card",
                    "Debit Card",
                    "Online Payment"
                });
            this.cmbPaymentMethod.Location =
                new Point(150, 360);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new Size(200, 25);
            this.cmbPaymentMethod.SelectedIndex = 0;
            this.cmbPaymentMethod.TabIndex = 5;

            // Cancel Booking Button

            this.btnCancelBooking.BackColor = Color.Firebrick;
            this.btnCancelBooking.Cursor = Cursors.Hand;
            this.btnCancelBooking.FlatAppearance.BorderSize = 0;
            this.btnCancelBooking.FlatStyle = FlatStyle.Flat;
            this.btnCancelBooking.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnCancelBooking.ForeColor = Color.White;
            this.btnCancelBooking.Location =
                new Point(25, 405);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new Size(150, 40);
            this.btnCancelBooking.TabIndex = 4;
            this.btnCancelBooking.Text = "CANCEL BOOKING";
            this.btnCancelBooking.UseVisualStyleBackColor =
                false;

            // Return Vehicle Button

            this.btnReturnVehicle.BackColor = Color.SeaGreen;
            this.btnReturnVehicle.Cursor = Cursors.Hand;
            this.btnReturnVehicle.FlatAppearance.BorderSize = 0;
            this.btnReturnVehicle.FlatStyle = FlatStyle.Flat;
            this.btnReturnVehicle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnReturnVehicle.ForeColor = Color.White;
            this.btnReturnVehicle.Location =
                new Point(200, 405);
            this.btnReturnVehicle.Name = "btnReturnVehicle";
            this.btnReturnVehicle.Size = new Size(150, 40);
            this.btnReturnVehicle.TabIndex = 5;
            this.btnReturnVehicle.Text = "RETURN VEHICLE";
            this.btnReturnVehicle.UseVisualStyleBackColor =
                false;

            // Pay Now Button

            this.btnPayNow.BackColor = Color.SteelBlue;
            this.btnPayNow.Cursor = Cursors.Hand;
            this.btnPayNow.FlatAppearance.BorderSize = 0;
            this.btnPayNow.FlatStyle = FlatStyle.Flat;
            this.btnPayNow.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnPayNow.ForeColor = Color.White;
            this.btnPayNow.Location =
                new Point(25, 465);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new Size(325, 40);
            this.btnPayNow.TabIndex = 6;
            this.btnPayNow.Text = "PAY NOW";
            this.btnPayNow.UseVisualStyleBackColor =
                false;

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
            this.btnBack.Location = new Point(25, 525);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(325, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;

            // =====================================
            // MyRentalsForm
            // =====================================

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(1250, 720);
            this.Controls.Add(this.grpSelectedRental);
            this.Controls.Add(this.dgvMyRentals);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(1100, 650);
            this.Name = "MyRentalsForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Vehicle Rental System - My Rentals";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvMyRentals)).EndInit();

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.grpSelectedRental.ResumeLayout(false);
            this.grpSelectedRental.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
