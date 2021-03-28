namespace Restaurant_Management.View
{
    partial class DeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
            this.searchTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.searchBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.CustomernameLbl = new Guna.UI.WinForms.GunaLabel();
            this.CustomernameText = new Guna.UI.WinForms.GunaTextBox();
            this.AddresLbl = new Guna.UI.WinForms.GunaLabel();
            this.AddressText = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.UpdateBtn = new Guna.UI.WinForms.GunaButton();
            this.PhoneText = new Guna.UI.WinForms.GunaTextBox();
            this.PhoneLbl = new Guna.UI.WinForms.GunaLabel();
            this.FinishBtn = new Guna.UI.WinForms.GunaButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.AccessibleName = "";
            this.searchTextBox.Animated = true;
            this.searchTextBox.BackColor = System.Drawing.Color.White;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.LineColor = System.Drawing.Color.Gainsboro;
            this.searchTextBox.Location = new System.Drawing.Point(188, 48);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(469, 45);
            this.searchTextBox.TabIndex = 19;
            this.searchTextBox.TabStop = false;
            this.searchTextBox.Text = "What do you want to seach?";
            this.searchTextBox.TextOffsetX = 6;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.color = System.Drawing.Color.White;
            this.searchBtn.colorActive = System.Drawing.Color.White;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImagePosition = 0;
            this.searchBtn.ImageZoom = 50;
            this.searchBtn.LabelPosition = 0;
            this.searchBtn.LabelText = "";
            this.searchBtn.Location = new System.Drawing.Point(591, 51);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(66, 35);
            this.searchBtn.TabIndex = 20;
            this.searchBtn.MouseEnter += new System.EventHandler(this.searchBtn_active);
            this.searchBtn.MouseLeave += new System.EventHandler(this.searchBtn_disactive);
            this.searchBtn.MouseHover += new System.EventHandler(this.searchBtn_active);
            // 
            // CustomernameLbl
            // 
            this.CustomernameLbl.AutoSize = true;
            this.CustomernameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.CustomernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.CustomernameLbl.Location = new System.Drawing.Point(41, 78);
            this.CustomernameLbl.Name = "CustomernameLbl";
            this.CustomernameLbl.Size = new System.Drawing.Size(72, 30);
            this.CustomernameLbl.TabIndex = 21;
            this.CustomernameLbl.Text = "Name";
            // 
            // CustomernameText
            // 
            this.CustomernameText.BaseColor = System.Drawing.Color.White;
            this.CustomernameText.BorderColor = System.Drawing.Color.Silver;
            this.CustomernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomernameText.FocusedBaseColor = System.Drawing.Color.White;
            this.CustomernameText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.CustomernameText.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.CustomernameText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CustomernameText.ForeColor = System.Drawing.Color.Black;
            this.CustomernameText.Location = new System.Drawing.Point(136, 78);
            this.CustomernameText.Name = "CustomernameText";
            this.CustomernameText.PasswordChar = '\0';
            this.CustomernameText.SelectedText = "";
            this.CustomernameText.Size = new System.Drawing.Size(513, 41);
            this.CustomernameText.TabIndex = 22;
            this.CustomernameText.Text = "Customername";
            // 
            // AddresLbl
            // 
            this.AddresLbl.AutoSize = true;
            this.AddresLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.AddresLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.AddresLbl.Location = new System.Drawing.Point(41, 161);
            this.AddresLbl.Name = "AddresLbl";
            this.AddresLbl.Size = new System.Drawing.Size(92, 30);
            this.AddresLbl.TabIndex = 23;
            this.AddresLbl.Text = "Address";
            this.AddresLbl.Click += new System.EventHandler(this.AddresLbl_Click);
            // 
            // AddressText
            // 
            this.AddressText.BaseColor = System.Drawing.Color.White;
            this.AddressText.BorderColor = System.Drawing.Color.Silver;
            this.AddressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressText.FocusedBaseColor = System.Drawing.Color.White;
            this.AddressText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.AddressText.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.AddressText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddressText.ForeColor = System.Drawing.Color.Black;
            this.AddressText.Location = new System.Drawing.Point(136, 161);
            this.AddressText.Name = "AddressText";
            this.AddressText.PasswordChar = '\0';
            this.AddressText.SelectedText = "";
            this.AddressText.Size = new System.Drawing.Size(513, 41);
            this.AddressText.TabIndex = 24;
            this.AddressText.Text = "CustomerAddress";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.UpdateBtn);
            this.groupBox.Controls.Add(this.PhoneText);
            this.groupBox.Controls.Add(this.PhoneLbl);
            this.groupBox.Controls.Add(this.CustomernameLbl);
            this.groupBox.Controls.Add(this.AddresLbl);
            this.groupBox.Controls.Add(this.AddressText);
            this.groupBox.Controls.Add(this.CustomernameText);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.groupBox.Location = new System.Drawing.Point(114, 124);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(676, 421);
            this.groupBox.TabIndex = 30;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Customer Details";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Animated = true;
            this.UpdateBtn.AnimationHoverSpeed = 0.07F;
            this.UpdateBtn.AnimationSpeed = 0.03F;
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.UpdateBtn.BorderColor = System.Drawing.Color.Black;
            this.UpdateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateBtn.FocusedColor = System.Drawing.Color.Empty;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Image = null;
            this.UpdateBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.UpdateBtn.Location = new System.Drawing.Point(535, 311);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.UpdateBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UpdateBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.UpdateBtn.OnHoverImage = null;
            this.UpdateBtn.OnPressedColor = System.Drawing.Color.Black;
            this.UpdateBtn.Radius = 2;
            this.UpdateBtn.Size = new System.Drawing.Size(114, 50);
            this.UpdateBtn.TabIndex = 31;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // PhoneText
            // 
            this.PhoneText.BaseColor = System.Drawing.Color.White;
            this.PhoneText.BorderColor = System.Drawing.Color.Silver;
            this.PhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneText.FocusedBaseColor = System.Drawing.Color.White;
            this.PhoneText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.PhoneText.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.PhoneText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PhoneText.ForeColor = System.Drawing.Color.Black;
            this.PhoneText.Location = new System.Drawing.Point(136, 238);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.PasswordChar = '\0';
            this.PhoneText.SelectedText = "";
            this.PhoneText.Size = new System.Drawing.Size(513, 41);
            this.PhoneText.TabIndex = 31;
            this.PhoneText.Text = "Phone Number";
            this.PhoneText.Visible = false;
            this.PhoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.PhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PhoneLbl.Location = new System.Drawing.Point(41, 245);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(77, 30);
            this.PhoneLbl.TabIndex = 27;
            this.PhoneLbl.Text = "Phone";
            this.PhoneLbl.Visible = false;
            // 
            // FinishBtn
            // 
            this.FinishBtn.Animated = true;
            this.FinishBtn.AnimationHoverSpeed = 0.07F;
            this.FinishBtn.AnimationSpeed = 0.03F;
            this.FinishBtn.BackColor = System.Drawing.Color.Transparent;
            this.FinishBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.FinishBtn.BorderColor = System.Drawing.Color.Black;
            this.FinishBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FinishBtn.FocusedColor = System.Drawing.Color.Empty;
            this.FinishBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.ForeColor = System.Drawing.Color.White;
            this.FinishBtn.Image = null;
            this.FinishBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.FinishBtn.Location = new System.Drawing.Point(159, 595);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(193)))), ((int)(((byte)(52)))));
            this.FinishBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.FinishBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.FinishBtn.OnHoverImage = null;
            this.FinishBtn.OnPressedColor = System.Drawing.Color.Black;
            this.FinishBtn.Radius = 2;
            this.FinishBtn.Size = new System.Drawing.Size(568, 44);
            this.FinishBtn.TabIndex = 32;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1387, 745);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeliveryForm";
            this.Text = "DeliveryForm";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton searchBtn;
        private Guna.UI.WinForms.GunaLineTextBox searchTextBox;
        private Guna.UI.WinForms.GunaLabel CustomernameLbl;
        private Guna.UI.WinForms.GunaTextBox CustomernameText;
        private Guna.UI.WinForms.GunaLabel AddresLbl;
        private Guna.UI.WinForms.GunaTextBox AddressText;
        private System.Windows.Forms.GroupBox groupBox;
        private Guna.UI.WinForms.GunaButton UpdateBtn;
        private Guna.UI.WinForms.GunaTextBox PhoneText;
        private Guna.UI.WinForms.GunaLabel PhoneLbl;
        private Guna.UI.WinForms.GunaButton FinishBtn;
    }
}