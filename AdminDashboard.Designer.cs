using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlSidebar;
        private Label lblLogo;
        private Label lblAdminPanel;

        private Button btnDashboard;
        private Button btnVehicles;
        private Button btnCustomers;
        private Button btnCreateCustomer;
        private Button btnRentals;
        private Button btnPayments;
        private Button btnReports;
        private Button btnLogout;

        private Panel pnlMain;
        private Panel pnlHeader;
        private Label lblPageTitle;
        private Label lblWelcome;

        private Panel pnlContent;

        private Panel pnlVehicleCard;
        private Label lblVehicleCardTitle;
        private Label lblTotalVehicles;

        private Panel pnlCustomerCard;
        private Label lblCustomerCardTitle;
        private Label lblTotalCustomers;

        private Panel pnlRentalCard;
        private Label lblRentalCardTitle;
        private Label lblActiveRentals;

        private Panel pnlPaymentCard;
        private Label lblPaymentCardTitle;
        private Label lblPendingPayments;

        private Label lblMessage;

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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnRentals = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlVehicleCard = new System.Windows.Forms.Panel();
            this.lblVehicleCardTitle = new System.Windows.Forms.Label();
            this.lblTotalVehicles = new System.Windows.Forms.Label();
            this.pnlCustomerCard = new System.Windows.Forms.Panel();
            this.lblCustomerCardTitle = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.pnlRentalCard = new System.Windows.Forms.Panel();
            this.lblRentalCardTitle = new System.Windows.Forms.Label();
            this.lblActiveRentals = new System.Windows.Forms.Label();
            this.pnlPaymentCard = new System.Windows.Forms.Panel();
            this.lblPaymentCardTitle = new System.Windows.Forms.Label();
            this.lblPendingPayments = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlVehicleCard.SuspendLayout();
            this.pnlCustomerCard.SuspendLayout();
            this.pnlRentalCard.SuspendLayout();
            this.pnlPaymentCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblAdminPanel);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnVehicles);
            this.pnlSidebar.Controls.Add(this.btnCustomers);
            this.pnlSidebar.Controls.Add(this.btnCreateCustomer);
            this.pnlSidebar.Controls.Add(this.btnRentals);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 700);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(200, 40);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "VEHICLE RENTAL";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdminPanel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAdminPanel.Location = new System.Drawing.Point(25, 70);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(190, 25);
            this.lblAdminPanel.TabIndex = 1;
            this.lblAdminPanel.Text = "ADMIN PANEL";
            this.lblAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(20, 125);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 48);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVehicles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehicles.FlatAppearance.BorderSize = 0;
            this.btnVehicles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnVehicles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.Location = new System.Drawing.Point(20, 185);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVehicles.Size = new System.Drawing.Size(200, 48);
            this.btnVehicles.TabIndex = 1;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(20, 245);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(200, 48);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCreateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCustomer.FlatAppearance.BorderSize = 0;
            this.btnCreateCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCreateCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCreateCustomer.Location = new System.Drawing.Point(20, 496);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCreateCustomer.Size = new System.Drawing.Size(200, 48);
            this.btnCreateCustomer.TabIndex = 3;
            this.btnCreateCustomer.Text = "Create Customer Account";
            this.btnCreateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCustomer.UseVisualStyleBackColor = false;
            // 
            // btnRentals
            // 
            this.btnRentals.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRentals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRentals.FlatAppearance.BorderSize = 0;
            this.btnRentals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRentals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRentals.ForeColor = System.Drawing.Color.White;
            this.btnRentals.Location = new System.Drawing.Point(20, 299);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRentals.Size = new System.Drawing.Size(200, 48);
            this.btnRentals.TabIndex = 4;
            this.btnRentals.Text = "Rentals";
            this.btnRentals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentals.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(20, 362);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(200, 48);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Location = new System.Drawing.Point(20, 610);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 48);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Location = new System.Drawing.Point(20, 425);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPayments.Size = new System.Drawing.Size(200, 48);
            this.btnPayments.TabIndex = 5;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(240, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(960, 700);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Controls.Add(this.pnlVehicleCard);
            this.pnlContent.Controls.Add(this.pnlCustomerCard);
            this.pnlContent.Controls.Add(this.pnlRentalCard);
            this.pnlContent.Controls.Add(this.pnlPaymentCard);
            this.pnlContent.Controls.Add(this.lblMessage);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 85);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(960, 615);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlVehicleCard
            // 
            this.pnlVehicleCard.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlVehicleCard.Controls.Add(this.lblVehicleCardTitle);
            this.pnlVehicleCard.Controls.Add(this.lblTotalVehicles);
            this.pnlVehicleCard.Location = new System.Drawing.Point(45, 40);
            this.pnlVehicleCard.Name = "pnlVehicleCard";
            this.pnlVehicleCard.Size = new System.Drawing.Size(390, 150);
            this.pnlVehicleCard.TabIndex = 0;
            // 
            // lblVehicleCardTitle
            // 
            this.lblVehicleCardTitle.AutoSize = true;
            this.lblVehicleCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblVehicleCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblVehicleCardTitle.Location = new System.Drawing.Point(25, 25);
            this.lblVehicleCardTitle.Name = "lblVehicleCardTitle";
            this.lblVehicleCardTitle.Size = new System.Drawing.Size(125, 20);
            this.lblVehicleCardTitle.TabIndex = 0;
            this.lblVehicleCardTitle.Text = "TOTAL VEHICLES";
            // 
            // lblTotalVehicles
            // 
            this.lblTotalVehicles.AutoSize = true;
            this.lblTotalVehicles.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblTotalVehicles.ForeColor = System.Drawing.Color.White;
            this.lblTotalVehicles.Location = new System.Drawing.Point(25, 65);
            this.lblTotalVehicles.Name = "lblTotalVehicles";
            this.lblTotalVehicles.Size = new System.Drawing.Size(46, 54);
            this.lblTotalVehicles.TabIndex = 1;
            this.lblTotalVehicles.Text = "0";
            // 
            // pnlCustomerCard
            // 
            this.pnlCustomerCard.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlCustomerCard.Controls.Add(this.lblCustomerCardTitle);
            this.pnlCustomerCard.Controls.Add(this.lblTotalCustomers);
            this.pnlCustomerCard.Location = new System.Drawing.Point(470, 40);
            this.pnlCustomerCard.Name = "pnlCustomerCard";
            this.pnlCustomerCard.Size = new System.Drawing.Size(390, 150);
            this.pnlCustomerCard.TabIndex = 1;
            // 
            // lblCustomerCardTitle
            // 
            this.lblCustomerCardTitle.AutoSize = true;
            this.lblCustomerCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCustomerCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblCustomerCardTitle.Location = new System.Drawing.Point(25, 25);
            this.lblCustomerCardTitle.Name = "lblCustomerCardTitle";
            this.lblCustomerCardTitle.Size = new System.Drawing.Size(145, 20);
            this.lblCustomerCardTitle.TabIndex = 0;
            this.lblCustomerCardTitle.Text = "TOTAL CUSTOMERS";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.White;
            this.lblTotalCustomers.Location = new System.Drawing.Point(25, 65);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(46, 54);
            this.lblTotalCustomers.TabIndex = 1;
            this.lblTotalCustomers.Text = "0";
            // 
            // pnlRentalCard
            // 
            this.pnlRentalCard.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlRentalCard.Controls.Add(this.lblRentalCardTitle);
            this.pnlRentalCard.Controls.Add(this.lblActiveRentals);
            this.pnlRentalCard.Location = new System.Drawing.Point(45, 225);
            this.pnlRentalCard.Name = "pnlRentalCard";
            this.pnlRentalCard.Size = new System.Drawing.Size(390, 150);
            this.pnlRentalCard.TabIndex = 2;
            // 
            // lblRentalCardTitle
            // 
            this.lblRentalCardTitle.AutoSize = true;
            this.lblRentalCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRentalCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblRentalCardTitle.Location = new System.Drawing.Point(25, 25);
            this.lblRentalCardTitle.Name = "lblRentalCardTitle";
            this.lblRentalCardTitle.Size = new System.Drawing.Size(130, 20);
            this.lblRentalCardTitle.TabIndex = 0;
            this.lblRentalCardTitle.Text = "ACTIVE RENTALS";
            // 
            // lblActiveRentals
            // 
            this.lblActiveRentals.AutoSize = true;
            this.lblActiveRentals.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblActiveRentals.ForeColor = System.Drawing.Color.White;
            this.lblActiveRentals.Location = new System.Drawing.Point(25, 65);
            this.lblActiveRentals.Name = "lblActiveRentals";
            this.lblActiveRentals.Size = new System.Drawing.Size(46, 54);
            this.lblActiveRentals.TabIndex = 1;
            this.lblActiveRentals.Text = "0";
            // 
            // pnlPaymentCard
            // 
            this.pnlPaymentCard.BackColor = System.Drawing.Color.IndianRed;
            this.pnlPaymentCard.Controls.Add(this.lblPaymentCardTitle);
            this.pnlPaymentCard.Controls.Add(this.lblPendingPayments);
            this.pnlPaymentCard.Location = new System.Drawing.Point(470, 225);
            this.pnlPaymentCard.Name = "pnlPaymentCard";
            this.pnlPaymentCard.Size = new System.Drawing.Size(390, 150);
            this.pnlPaymentCard.TabIndex = 3;
            // 
            // lblPaymentCardTitle
            // 
            this.lblPaymentCardTitle.AutoSize = true;
            this.lblPaymentCardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPaymentCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblPaymentCardTitle.Location = new System.Drawing.Point(25, 25);
            this.lblPaymentCardTitle.Name = "lblPaymentCardTitle";
            this.lblPaymentCardTitle.Size = new System.Drawing.Size(159, 20);
            this.lblPaymentCardTitle.TabIndex = 0;
            this.lblPaymentCardTitle.Text = "PENDING PAYMENTS";
            // 
            // lblPendingPayments
            // 
            this.lblPendingPayments.AutoSize = true;
            this.lblPendingPayments.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblPendingPayments.ForeColor = System.Drawing.Color.White;
            this.lblPendingPayments.Location = new System.Drawing.Point(25, 65);
            this.lblPendingPayments.Name = "lblPendingPayments";
            this.lblPendingPayments.Size = new System.Drawing.Size(46, 54);
            this.lblPendingPayments.TabIndex = 1;
            this.lblPendingPayments.Text = "0";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMessage.Location = new System.Drawing.Point(190, 450);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(580, 55);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Welcome to the Vehicle Rental Management System";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(960, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPageTitle.Location = new System.Drawing.Point(35, 22);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(288, 37);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "ADMIN DASHBOARD";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcome.Location = new System.Drawing.Point(740, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(180, 30);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Admin";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Rental System - Admin Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlVehicleCard.ResumeLayout(false);
            this.pnlVehicleCard.PerformLayout();
            this.pnlCustomerCard.ResumeLayout(false);
            this.pnlCustomerCard.PerformLayout();
            this.pnlRentalCard.ResumeLayout(false);
            this.pnlRentalCard.PerformLayout();
            this.pnlPaymentCard.ResumeLayout(false);
            this.pnlPaymentCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
