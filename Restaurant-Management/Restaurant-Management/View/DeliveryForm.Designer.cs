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
            this.searchTextBox.Location = new System.Drawing.Point(355, 29);
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
            this.searchBtn.Location = new System.Drawing.Point(758, 29);
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
            this.CustomernameLbl.Location = new System.Drawing.Point(290, 175);
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
            this.CustomernameText.Location = new System.Drawing.Point(389, 168);
            this.CustomernameText.Name = "CustomernameText";
            this.CustomernameText.PasswordChar = '\0';
            this.CustomernameText.SelectedText = "";
            this.CustomernameText.Size = new System.Drawing.Size(530, 41);
            this.CustomernameText.TabIndex = 22;
            this.CustomernameText.Text = "Customername";
            // 
            // AddresLbl
            // 
            this.AddresLbl.AutoSize = true;
            this.AddresLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.AddresLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.AddresLbl.Location = new System.Drawing.Point(290, 283);
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
            this.AddressText.Location = new System.Drawing.Point(389, 277);
            this.AddressText.Name = "AddressText";
            this.AddressText.PasswordChar = '\0';
            this.AddressText.SelectedText = "";
            this.AddressText.Size = new System.Drawing.Size(530, 41);
            this.AddressText.TabIndex = 24;
            this.AddressText.Text = "CustomerAddress";
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.AddresLbl);
            this.Controls.Add(this.CustomernameText);
            this.Controls.Add(this.CustomernameLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeliveryForm";
            this.Text = "DeliveryForm";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton searchBtn;
        private Guna.UI.WinForms.GunaLineTextBox searchTextBox;
        private Guna.UI.WinForms.GunaLabel CustomernameLbl;
        private Guna.UI.WinForms.GunaTextBox CustomernameText;
        private Guna.UI.WinForms.GunaLabel AddresLbl;
        private Guna.UI.WinForms.GunaTextBox AddressText;
    }
}