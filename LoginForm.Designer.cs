using System.Drawing;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlWelcome;
        private Panel pnlLogin;
        private Label lblSystemTitle;
        private Label lblSystemTitle2;
        private Label lblDescription;
        private Label lblLoginTitle;
        private Label lblLoginSubtitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlWelcome = new Panel();
            this.pnlLogin = new Panel();
            this.lblSystemTitle = new Label();
            this.lblSystemTitle2 = new Label();
            this.lblDescription = new Label();
            this.lblLoginTitle = new Label();
            this.lblLoginSubtitle = new Label();
            this.lblUsername = new Label();
            this.lblPassword = new Label();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.chkShowPassword = new CheckBox();
            this.btnLogin = new Button();
            this.btnRegister = new Button();
            this.btnExit = new Button();

            this.pnlWelcome.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();

            // pnlWelcome
            this.pnlWelcome.BackColor = Color.MidnightBlue;
            this.pnlWelcome.Controls.Add(this.lblSystemTitle);
            this.pnlWelcome.Controls.Add(this.lblSystemTitle2);
            this.pnlWelcome.Controls.Add(this.lblDescription);
            this.pnlWelcome.Dock = DockStyle.Left;
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new Size(380, 560);

            // lblSystemTitle
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Font =
                new Font("Segoe UI", 23F, FontStyle.Bold);
            this.lblSystemTitle.ForeColor = Color.White;
            this.lblSystemTitle.Location = new Point(45, 180);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Text = "VEHICLE RENTAL";

            // lblSystemTitle2
            this.lblSystemTitle2.AutoSize = true;
            this.lblSystemTitle2.Font =
                new Font("Segoe UI", 23F, FontStyle.Bold);
            this.lblSystemTitle2.ForeColor = Color.DeepSkyBlue;
            this.lblSystemTitle2.Location = new Point(45, 225);
            this.lblSystemTitle2.Name = "lblSystemTitle2";
            this.lblSystemTitle2.Text = "SYSTEM";

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new Font("Segoe UI", 11F);
            this.lblDescription.ForeColor = Color.LightGray;
            this.lblDescription.Location = new Point(48, 285);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text =
                "Rent your perfect vehicle easily.";

            // pnlLogin
            this.pnlLogin.BackColor = Color.White;
            this.pnlLogin.Controls.Add(this.lblLoginTitle);
            this.pnlLogin.Controls.Add(this.lblLoginSubtitle);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.chkShowPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.btnExit);
            this.pnlLogin.Location = new Point(445, 45);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new Size(430, 470);

            // lblLoginTitle
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font =
                new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblLoginTitle.ForeColor = Color.MidnightBlue;
            this.lblLoginTitle.Location = new Point(52, 25);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Text = "Welcome Back";

            // lblLoginSubtitle
            this.lblLoginSubtitle.AutoSize = true;
            this.lblLoginSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblLoginSubtitle.ForeColor = Color.Gray;
            this.lblLoginSubtitle.Location = new Point(54, 73);
            this.lblLoginSubtitle.Name = "lblLoginSubtitle";
            this.lblLoginSubtitle.Text = "Please log in to continue";

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblUsername.Location = new Point(52, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Username";

            // txtUsername
            this.txtUsername.Font = new Font("Segoe UI", 11F);
            this.txtUsername.Location = new Point(52, 148);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(325, 27);
            this.txtUsername.TabIndex = 0;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPassword.Location = new Point(52, 200);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Password";

            // txtPassword
            this.txtPassword.Font = new Font("Segoe UI", 11F);
            this.txtPassword.Location = new Point(52, 228);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(325, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;

            // chkShowPassword
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Cursor = Cursors.Hand;
            this.chkShowPassword.Location = new Point(52, 270);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new Size(110, 23);
            this.chkShowPassword.TabIndex = 2;
            this.chkShowPassword.Text = "Show password";

            // btnLogin
            this.btnLogin.BackColor = Color.MidnightBlue;
            this.btnLogin.Cursor = Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnLogin.ForeColor = Color.White;
            this.btnLogin.Location = new Point(52, 310);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(325, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;

            // btnRegister
            this.btnRegister.BackColor = Color.White;
            this.btnRegister.Cursor = Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor =
                Color.MidnightBlue;
            this.btnRegister.FlatAppearance.BorderSize = 1;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRegister.ForeColor = Color.MidnightBlue;
            this.btnRegister.Location = new Point(52, 365);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(325, 40);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "CREATE CUSTOMER ACCOUNT";
            this.btnRegister.UseVisualStyleBackColor = false;

            // btnExit
            this.btnExit.BackColor = Color.White;
            this.btnExit.Cursor = Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = Color.Firebrick;
            this.btnExit.FlatStyle = FlatStyle.Flat;
            this.btnExit.ForeColor = Color.Firebrick;
            this.btnExit.Location = new Point(297, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(80, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;

            // LoginForm
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new Size(930, 560);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlWelcome);
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Vehicle Rental System - Login";

            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
