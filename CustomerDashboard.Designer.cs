using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class CustomerDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlSidebar;
        private Label lblLogo;
        private Label lblCustomerPanel;
        private Button btnDashboard;
        private Button btnAvailableVehicles;
        private Button btnMyRentals;
        private Button btnPayments;
        private Button btnProfile;
        private Button btnLogout;

        private Panel pnlMain;
        private Panel pnlHeader;
        private Label lblPageTitle;
        private Label lblWelcomeCustomer;

        private Panel pnlContent;

        private Panel pnlAvailableCard;
        private Label lblAvailableTitle;
        private Label lblAvailableCount;

        private Panel pnlRentalCard;
        private Label lblRentalTitle;
        private Label lblActiveRentals;

        private Panel pnlPaymentCard;
        private Label lblPaymentTitle;
        private Label lblPendingAmount;

        private Panel pnlWelcomeCard;
        private Label lblWelcomeTitle;
        private Label lblWelcomeMessage;
        private Button btnBrowseVehicles;

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
            this.pnlSidebar = new Panel();
            this.lblLogo = new Label();
            this.lblCustomerPanel = new Label();
            this.btnDashboard = new Button();
            this.btnAvailableVehicles = new Button();
            this.btnMyRentals = new Button();
            this.btnPayments = new Button();
            this.btnProfile = new Button();
            this.btnLogout = new Button();

            this.pnlMain = new Panel();
            this.pnlHeader = new Panel();
            this.lblPageTitle = new Label();
            this.lblWelcomeCustomer = new Label();

            this.pnlContent = new Panel();

            this.pnlAvailableCard = new Panel();
            this.lblAvailableTitle = new Label();
            this.lblAvailableCount = new Label();

            this.pnlRentalCard = new Panel();
            this.lblRentalTitle = new Label();
            this.lblActiveRentals = new Label();

            this.pnlPaymentCard = new Panel();
            this.lblPaymentTitle = new Label();
            this.lblPendingAmount = new Label();

            this.pnlWelcomeCard = new Panel();
            this.lblWelcomeTitle = new Label();
            this.lblWelcomeMessage = new Label();
            this.btnBrowseVehicles = new Button();

            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlAvailableCard.SuspendLayout();
            this.pnlRentalCard.SuspendLayout();
            this.pnlPaymentCard.SuspendLayout();
            this.pnlWelcomeCard.SuspendLayout();
            this.SuspendLayout();

            // =====================================
            // Sidebar panel
            // =====================================

            this.pnlSidebar.BackColor = Color.MidnightBlue;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblCustomerPanel);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(
                this.btnAvailableVehicles);
            this.pnlSidebar.Controls.Add(this.btnMyRentals);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = DockStyle.Left;
            this.pnlSidebar.Location = new Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new Size(240, 700);
            this.pnlSidebar.TabIndex = 0;

            // Logo

            this.lblLogo.Font =
                new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblLogo.ForeColor = Color.White;
            this.lblLogo.Location = new Point(20, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new Size(200, 40);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "VEHICLE RENTAL";
            this.lblLogo.TextAlign =
                ContentAlignment.MiddleCenter;

            // Customer panel label

            this.lblCustomerPanel.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblCustomerPanel.ForeColor =
    Color.DeepSkyBlue;
            this.lblCustomerPanel.Location =
                new Point(25, 70);
            this.lblCustomerPanel.Name =
                "lblCustomerPanel";
            this.lblCustomerPanel.Size =
                new Size(190, 25);
            this.lblCustomerPanel.TabIndex = 1;
            this.lblCustomerPanel.Text =
                "CUSTOMER PANEL";
            this.lblCustomerPanel.TextAlign =
                ContentAlignment.MiddleCenter;

            // =====================================
            // Dashboard button
            // =====================================

            this.btnDashboard.BackColor = Color.RoyalBlue;
            this.btnDashboard.Cursor = Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor =
                Color.RoyalBlue;
            this.btnDashboard.BackColor = Color.RoyalBlue;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor =
                Color.RoyalBlue;
            this.btnDashboard.FlatStyle = FlatStyle.Flat;
            this.btnDashboard.FlatStyle = FlatStyle.Flat;
            this.btnDashboard.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnDashboard.ForeColor = Color.White;
            this.btnDashboard.Location =
                new Point(20, 125);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding =
                new Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new Size(200, 48);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign =
                ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor =
                false;

            // =====================================
            // Available vehicles button
            // =====================================

            this.btnAvailableVehicles.BackColor =
                Color.MidnightBlue;
            this.btnAvailableVehicles.Cursor =
                Cursors.Hand;
            this.btnAvailableVehicles.FlatAppearance.BorderSize =
                0;
            this.btnAvailableVehicles.FlatAppearance.MouseOverBackColor =
                Color.RoyalBlue;
            this.btnAvailableVehicles.FlatStyle =
                FlatStyle.Flat;
            this.btnAvailableVehicles.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAvailableVehicles.ForeColor =
                Color.White;
            this.btnAvailableVehicles.Location =
                new Point(20, 185);
            this.btnAvailableVehicles.FlatAppearance.BorderSize =  0;
            this.btnAvailableVehicles.Padding =
                new Padding(20, 0, 0, 0);
            this.btnAvailableVehicles.Size =
                new Size(200, 48);
            this.btnAvailableVehicles.TabIndex = 1;
            this.btnAvailableVehicles.Text =
                "Available Vehicles";
            this.btnAvailableVehicles.TextAlign =
                ContentAlignment.MiddleLeft;
            this.btnAvailableVehicles.UseVisualStyleBackColor =
                false;

            // =====================================
            // My rentals button
            // =====================================

            this.btnMyRentals.BackColor =
                Color.MidnightBlue;
            this.btnMyRentals.Cursor = Cursors.Hand;
            this.btnMyRentals.FlatAppearance.BorderSize = 0;
            this.btnMyRentals.FlatAppearance.MouseOverBackColor =
                Color.RoyalBlue;
            this.btnMyRentals.FlatStyle = FlatStyle.Flat;
            this.btnMyRentals.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnMyRentals.ForeColor = Color.White;
            this.btnMyRentals.Location =
                new Point(20, 245);
            this.btnMyRentals.Name = "btnMyRentals";
            this.btnMyRentals.Padding =
                new Padding(20, 0, 0, 0);
            this.btnMyRentals.Size = new Size(200, 48);
            this.btnMyRentals.TabIndex = 2;
            this.btnMyRentals.Text = "My Rentals & Payments";
            this.btnMyRentals.TextAlign =
                ContentAlignment.MiddleLeft;
            this.btnMyRentals.UseVisualStyleBackColor =
                false;

            // =====================================
            // Payments button
            // =====================================

            this.btnPayments.BackColor =
                Color.MidnightBlue;
            this.btnPayments.Cursor = Cursors.Hand;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatAppearance.MouseOverBackColor =
                Color.RoyalBlue;
            this.btnPayments.FlatStyle = FlatStyle.Flat;
            this.btnPayments.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnPayments.ForeColor = Color.White;
            this.btnPayments.Location =
                new Point(20, 305);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding =
                new Padding(20, 0, 0, 0);
            this.btnPayments.Size = new Size(200, 48);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign =
     ContentAlignment.MiddleLeft;
            this.btnPayments.UseVisualStyleBackColor = false ;

            // =====================================
            // Profile button
            // =====================================

            this.btnProfile.BackColor =
                Color.MidnightBlue;
            this.btnProfile.Cursor = Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseOverBackColor =
                Color.RoyalBlue;
            this.btnProfile.FlatStyle = FlatStyle.Flat;
            this.btnProfile.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnProfile.ForeColor = Color.White;
            this.btnProfile.Location =
                new Point(20, 365);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding =
                new Padding(20, 0, 0, 0);
            this.btnProfile.Size = new Size(200, 48);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.TextAlign =
                ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor =
                false;

            // =====================================
            // Logout button
            // =====================================

            this.btnLogout.Anchor =
                AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnLogout.BackColor =
                Color.MidnightBlue;
            this.btnLogout.Cursor = Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor =
                Color.Firebrick;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogout.ForeColor = Color.LightCoral;
            this.btnLogout.Location =
                new Point(20, 625);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding =
                new Padding(20, 0, 0, 0);
            this.btnLogout.Size = new Size(200, 48);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign =
                ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor =
                false;

            // =====================================
            // Main panel
            // =====================================

            this.pnlMain.BackColor = Color.WhiteSmoke;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = DockStyle.Fill;
            this.pnlMain.Location = new Point(240, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new Size(960, 700);
            this.pnlMain.TabIndex = 1;

            // =====================================
            // Header panel
            // =====================================

            this.pnlHeader.BackColor = Color.White;
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(
                this.lblWelcomeCustomer);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Location = new Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new Size(960, 85);
            this.pnlHeader.TabIndex = 0;

            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font =
                new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblPageTitle.ForeColor =
                Color.MidnightBlue;
            this.lblPageTitle.Location =
                new Point(35, 22);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text =
                "CUSTOMER DASHBOARD";

            this.lblWelcomeCustomer.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;
            this.lblWelcomeCustomer.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            
            this.lblWelcomeCustomer.ForeColor =
                Color.DimGray;
            this.lblWelcomeCustomer.Location =
                new Point(720, 28);
            this.lblWelcomeCustomer.Name =
                "lblWelcomeCustomer";
            this.lblWelcomeCustomer.Size =
                new Size(200, 30);
            this.lblWelcomeCustomer.TabIndex = 1;
            this.lblWelcomeCustomer.Text =
                "Welcome, Customer";
            this.lblWelcomeCustomer.TextAlign =
                ContentAlignment.MiddleRight;

            // =====================================
            // Content panel
            // =====================================

            this.pnlContent.BackColor = Color.WhiteSmoke;
            this.pnlContent.Controls.Add(
                this.pnlAvailableCard);
            this.pnlContent.Controls.Add(
                this.pnlRentalCard);
            this.pnlContent.Controls.Add(
                this.pnlPaymentCard);
            this.pnlContent.Controls.Add(
                this.pnlWelcomeCard);
            this.pnlContent.Dock = DockStyle.Fill;
            this.pnlContent.Location = new Point(0, 85);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new Size(960, 615);
            this.pnlContent.TabIndex = 1;

            // =====================================
            // Available vehicles card
            // =====================================

            this.pnlAvailableCard.BackColor =
                Color.SteelBlue;
            this.pnlAvailableCard.Controls.Add(
                this.lblAvailableTitle);
            this.pnlAvailableCard.Controls.Add(
                this.lblAvailableCount);
            this.pnlAvailableCard.Location =
                new Point(35, 40);
            this.pnlAvailableCard.Name =
                "pnlAvailableCard";
            this.pnlAvailableCard.Size =
                new Size(270, 145);
            this.pnlAvailableCard.TabIndex = 0;

            this.lblAvailableTitle.AutoSize = true;
            this.lblAvailableTitle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblAvailableTitle.ForeColor =
                Color.White;
            this.lblAvailableTitle.Location =
                new Point(20, 20);
            this.lblAvailableTitle.Name =
                "lblAvailableTitle";
            this.lblAvailableTitle.TabIndex = 0;
            this.lblAvailableTitle.Text =
                "AVAILABLE VEHICLES";

            this.lblAvailableCount.AutoSize = true;
            this.lblAvailableCount.Font =
                new Font("Segoe UI", 28F, FontStyle.Bold);
            this.lblAvailableCount.ForeColor =
                Color.White;
            this.lblAvailableCount.Location =
                new Point(20, 58);
            this.lblAvailableCount.Name =
                "lblAvailableCount";
            this.lblAvailableCount.TabIndex = 1;
            this.lblAvailableCount.Text = "0";

            // =====================================
            // Active rentals card
            // =====================================

            this.pnlRentalCard.BackColor =
                Color.DarkOrange;
            this.pnlRentalCard.Controls.Add(
                this.lblRentalTitle);
            this.pnlRentalCard.Controls.Add(
                this.lblActiveRentals);
            this.pnlRentalCard.Location =
                new Point(345, 40);
            this.pnlRentalCard.Name = "pnlRentalCard";
            this.pnlRentalCard.Size =
                new Size(270, 145);
            this.pnlRentalCard.TabIndex = 1;

            this.lblRentalTitle.AutoSize = true;
            this.lblRentalTitle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblRentalTitle.ForeColor = Color.White;
            this.lblRentalTitle.Location =
                new Point(20, 20);
            this.lblRentalTitle.Name = "lblRentalTitle";
            this.lblRentalTitle.TabIndex = 0;
            this.lblRentalTitle.Text = "ACTIVE RENTALS";

            this.lblActiveRentals.AutoSize = true;
            this.lblActiveRentals.Font =
                new Font("Segoe UI", 28F, FontStyle.Bold);
            this.lblActiveRentals.ForeColor = Color.White;
            this.lblActiveRentals.Location =
                new Point(20, 58);
            this.lblActiveRentals.Name =
                "lblActiveRentals";
            this.lblActiveRentals.TabIndex = 1;
            this.lblActiveRentals.Text = "0";

            // =====================================
            // Pending payment card
            // =====================================

            this.pnlPaymentCard.BackColor =
                Color.IndianRed;
            this.pnlPaymentCard.Controls.Add(
                this.lblPaymentTitle);
            this.pnlPaymentCard.Controls.Add(
                this.lblPendingAmount);
            this.pnlPaymentCard.Location =
                new Point(655, 40);
            this.pnlPaymentCard.Name =
                "pnlPaymentCard";
            this.pnlPaymentCard.Size =
                new Size(270, 145);
            this.pnlPaymentCard.TabIndex = 2;

            this.lblPaymentTitle.AutoSize = true;
            this.lblPaymentTitle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPaymentTitle.ForeColor = Color.White;
            this.lblPaymentTitle.Location =
                new Point(20, 20);
            this.lblPaymentTitle.Name =
                "lblPaymentTitle";
            this.lblPaymentTitle.TabIndex = 0;
            this.lblPaymentTitle.Text =
                "PENDING PAYMENT";

            this.lblPendingAmount.AutoSize = true;
            this.lblPendingAmount.Font =
                new Font("Segoe UI", 28F, FontStyle.Bold);
            this.lblPendingAmount.ForeColor = Color.White;
            this.lblPendingAmount.Location =
                new Point(20, 58);
            this.lblPendingAmount.Name =
                "lblPendingAmount";
            this.lblPendingAmount.TabIndex = 1;
            this.lblPendingAmount.Text = "0.00";

            // =====================================
            // Welcome card
            // =====================================

            this.pnlWelcomeCard.BackColor = Color.White;
            this.pnlWelcomeCard.Controls.Add(
                this.lblWelcomeTitle);
            this.pnlWelcomeCard.Controls.Add(
                this.lblWelcomeMessage);
            this.pnlWelcomeCard.Controls.Add(
                this.btnBrowseVehicles);
            this.pnlWelcomeCard.Location =
                new Point(35, 225);
            this.pnlWelcomeCard.Name =
                "pnlWelcomeCard";
            this.pnlWelcomeCard.Size =
                new Size(890, 300);
            this.pnlWelcomeCard.TabIndex = 3;

            this.lblWelcomeTitle.Font =
                new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblWelcomeTitle.ForeColor =
                Color.MidnightBlue;
            this.lblWelcomeTitle.Location =
                new Point(195, 45);
            this.lblWelcomeTitle.Name =
                "lblWelcomeTitle";
            this.lblWelcomeTitle.Size =
                new Size(500, 45);
            this.lblWelcomeTitle.TabIndex = 0;
            this.lblWelcomeTitle.Text =
                "READY FOR YOUR NEXT RIDE?";
            this.lblWelcomeTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblWelcomeMessage.Font =
                new Font("Segoe UI", 11F);
            this.lblWelcomeMessage.ForeColor =
                Color.DimGray;
            this.lblWelcomeMessage.Location =
                new Point(145, 110);
            this.lblWelcomeMessage.Name =
                "lblWelcomeMessage";
            this.lblWelcomeMessage.Size =
                new Size(600, 55);
            this.lblWelcomeMessage.TabIndex = 1;
            this.lblWelcomeMessage.Text =
                "Browse available vehicles, select your rental dates,\r\n" +
                "and book your preferred vehicle.";
            this.lblWelcomeMessage.TextAlign =
                ContentAlignment.MiddleCenter;

            this.btnBrowseVehicles.BackColor =
                Color.MidnightBlue;
            this.btnBrowseVehicles.Cursor =
                Cursors.Hand;
            this.btnBrowseVehicles.FlatAppearance.BorderSize =
                0;
            this.btnBrowseVehicles.FlatStyle =
                FlatStyle.Flat;
            this.btnBrowseVehicles.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnBrowseVehicles.ForeColor =
                Color.White;
            this.btnBrowseVehicles.Location =
                new Point(295, 195);
            this.btnBrowseVehicles.Name =
                "btnBrowseVehicles";
            this.btnBrowseVehicles.Size =
                new Size(300, 42);
            this.btnBrowseVehicles.TabIndex = 6;
            this.btnBrowseVehicles.Text =
                "BROWSE AVAILABLE VEHICLES";
            this.btnBrowseVehicles.UseVisualStyleBackColor =
                false;

            // =====================================
            // CustomerDashboard
            // =====================================

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(1200, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(1100, 650);
            this.Name = "CustomerDashboard";
            this.StartPosition =
                FormStartPosition.CenterScreen;
            this.Text =
                "Vehicle Rental System - Customer Dashboard";

            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlAvailableCard.ResumeLayout(false);
            this.pnlAvailableCard.PerformLayout();
            this.pnlRentalCard.ResumeLayout(false);
            this.pnlRentalCard.PerformLayout();
            this.pnlPaymentCard.ResumeLayout(false);
            this.pnlPaymentCard.PerformLayout();
            this.pnlWelcomeCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
