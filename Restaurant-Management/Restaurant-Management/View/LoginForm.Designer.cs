
namespace Restaurant_Management.View
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.ErrorLbl = new Guna.UI.WinForms.GunaLabel();
            this.viewPassCheck = new Guna.UI.WinForms.GunaImageCheckBox();
            this.rememberCheck = new Guna.UI.WinForms.GunaCheckBox();
            this.loginBtn = new Guna.UI.WinForms.GunaButton();
            this.passwordText = new Guna.UI.WinForms.GunaLineTextBox();
            this.usernameText = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.ErrorLbl);
            this.gunaShadowPanel1.Controls.Add(this.viewPassCheck);
            this.gunaShadowPanel1.Controls.Add(this.rememberCheck);
            this.gunaShadowPanel1.Controls.Add(this.loginBtn);
            this.gunaShadowPanel1.Controls.Add(this.passwordText);
            this.gunaShadowPanel1.Controls.Add(this.usernameText);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(482, 143);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(620, 500);
            this.gunaShadowPanel1.TabIndex = 3;
            this.gunaShadowPanel1.UseTransfarantBackground = true;
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrorLbl.Location = new System.Drawing.Point(73, 60);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(55, 28);
            this.ErrorLbl.TabIndex = 5;
            this.ErrorLbl.Text = "Error";
            // 
            // viewPassCheck
            // 
            this.viewPassCheck.Checked = true;
            this.viewPassCheck.ImageCheckedOff = ((System.Drawing.Image)(resources.GetObject("viewPassCheck.ImageCheckedOff")));
            this.viewPassCheck.ImageCheckedOn = ((System.Drawing.Image)(resources.GetObject("viewPassCheck.ImageCheckedOn")));
            this.viewPassCheck.ImageSize = new System.Drawing.Size(30, 30);
            this.viewPassCheck.Location = new System.Drawing.Point(512, 190);
            this.viewPassCheck.Name = "viewPassCheck";
            this.viewPassCheck.Size = new System.Drawing.Size(41, 35);
            this.viewPassCheck.TabIndex = 4;
            this.viewPassCheck.CheckedChanged += new System.EventHandler(this.viewPassCheck_CheckedChanged);
            // 
            // rememberCheck
            // 
            this.rememberCheck.BaseColor = System.Drawing.Color.White;
            this.rememberCheck.CheckedOffColor = System.Drawing.SystemColors.GrayText;
            this.rememberCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.rememberCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rememberCheck.FillColor = System.Drawing.Color.White;
            this.rememberCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rememberCheck.Location = new System.Drawing.Point(73, 254);
            this.rememberCheck.Name = "rememberCheck";
            this.rememberCheck.Radius = 3;
            this.rememberCheck.Size = new System.Drawing.Size(157, 25);
            this.rememberCheck.TabIndex = 2;
            this.rememberCheck.Text = "Remember me";
            this.rememberCheck.CheckedChanged += new System.EventHandler(this.rememberCheck_CheckedChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Animated = true;
            this.loginBtn.AnimationHoverSpeed = 0.07F;
            this.loginBtn.AnimationSpeed = 0.03F;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.loginBtn.BorderColor = System.Drawing.Color.Black;
            this.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Image = null;
            this.loginBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.loginBtn.Location = new System.Drawing.Point(73, 318);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.loginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.loginBtn.OnHoverImage = null;
            this.loginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.loginBtn.Radius = 2;
            this.loginBtn.Size = new System.Drawing.Size(480, 52);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordText
            // 
            this.passwordText.Animated = true;
            this.passwordText.BackColor = System.Drawing.Color.White;
            this.passwordText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.passwordText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.LineColor = System.Drawing.Color.Gainsboro;
            this.passwordText.Location = new System.Drawing.Point(73, 190);
            this.passwordText.Name = "passwordText";
            this.passwordText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.passwordText.PasswordChar = '●';
            this.passwordText.SelectedText = "";
            this.passwordText.Size = new System.Drawing.Size(480, 39);
            this.passwordText.TabIndex = 1;
            this.passwordText.Text = "Enter password";
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.Enter += new System.EventHandler(this.passwordText_Enter);
            this.passwordText.Leave += new System.EventHandler(this.passwordText_Leave);
            // 
            // usernameText
            // 
            this.usernameText.Animated = true;
            this.usernameText.BackColor = System.Drawing.Color.White;
            this.usernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameText.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.usernameText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.LineColor = System.Drawing.Color.Gainsboro;
            this.usernameText.Location = new System.Drawing.Point(73, 116);
            this.usernameText.Name = "usernameText";
            this.usernameText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.usernameText.PasswordChar = '\0';
            this.usernameText.SelectedText = "";
            this.usernameText.Size = new System.Drawing.Size(480, 39);
            this.usernameText.TabIndex = 0;
            this.usernameText.Text = "Enter email/username";
            this.usernameText.Enter += new System.EventHandler(this.usernameText_Enter);
            this.usernameText.Leave += new System.EventHandler(this.usernameText_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1497, 798);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1091, 623);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLineTextBox passwordText;
        private Guna.UI.WinForms.GunaLineTextBox usernameText;
        private Guna.UI.WinForms.GunaCheckBox rememberCheck;
        private Guna.UI.WinForms.GunaButton loginBtn;
        private Guna.UI.WinForms.GunaImageCheckBox viewPassCheck;
        private Guna.UI.WinForms.GunaLabel ErrorLbl;
    }
}