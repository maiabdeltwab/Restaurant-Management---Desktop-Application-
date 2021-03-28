
namespace Restaurant_Management.View
{
    partial class RoleScreensForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleScreensForm));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaGroupBox = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.allUserList = new Guna.UI.WinForms.GunaCheckBox();
            this.userList = new System.Windows.Forms.CheckedListBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaSeparator3 = new Guna.UI.WinForms.GunaSeparator();
            this.allStoreList = new Guna.UI.WinForms.GunaCheckBox();
            this.storeList = new System.Windows.Forms.CheckedListBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaSeparator4 = new Guna.UI.WinForms.GunaSeparator();
            this.allCustomerList = new Guna.UI.WinForms.GunaCheckBox();
            this.customerList = new System.Windows.Forms.CheckedListBox();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.allMenuList = new Guna.UI.WinForms.GunaCheckBox();
            this.menuList = new System.Windows.Forms.CheckedListBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.saveBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VIPRawyBold-Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(87, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Role Screens";
            // 
            // gunaGroupBox
            // 
            this.gunaGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gunaGroupBox.Controls.Add(this.gunaSeparator2);
            this.gunaGroupBox.Controls.Add(this.allUserList);
            this.gunaGroupBox.Controls.Add(this.userList);
            this.gunaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gunaGroupBox.LineTop = 35;
            this.gunaGroupBox.Location = new System.Drawing.Point(59, 94);
            this.gunaGroupBox.Name = "gunaGroupBox";
            this.gunaGroupBox.Radius = 5;
            this.gunaGroupBox.Size = new System.Drawing.Size(414, 185);
            this.gunaGroupBox.TabIndex = 2;
            this.gunaGroupBox.Text = "User screens";
            this.gunaGroupBox.TextLocation = new System.Drawing.Point(5, 2);
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.gunaSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaSeparator2.Location = new System.Drawing.Point(46, 57);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(320, 10);
            this.gunaSeparator2.TabIndex = 5;
            // 
            // allUserList
            // 
            this.allUserList.BackColor = System.Drawing.Color.Transparent;
            this.allUserList.BaseColor = System.Drawing.Color.White;
            this.allUserList.CheckedOffColor = System.Drawing.Color.Gray;
            this.allUserList.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.allUserList.FillColor = System.Drawing.Color.White;
            this.allUserList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.allUserList.Location = new System.Drawing.Point(46, 34);
            this.allUserList.Name = "allUserList";
            this.allUserList.Size = new System.Drawing.Size(135, 33);
            this.allUserList.TabIndex = 3;
            this.allUserList.Text = "select all";
            this.allUserList.CheckedChanged += new System.EventHandler(this.allUserList_CheckedChanged);
            // 
            // userList
            // 
            this.userList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userList.CheckOnClick = true;
            this.userList.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userList.FormattingEnabled = true;
            this.userList.Items.AddRange(new object[] {
            "Users screen",
            "User Roles screen"});
            this.userList.Location = new System.Drawing.Point(46, 70);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(324, 60);
            this.userList.TabIndex = 0;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gunaGroupBox1.Controls.Add(this.gunaSeparator3);
            this.gunaGroupBox1.Controls.Add(this.allStoreList);
            this.gunaGroupBox1.Controls.Add(this.storeList);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gunaGroupBox1.LineTop = 35;
            this.gunaGroupBox1.Location = new System.Drawing.Point(59, 305);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(414, 206);
            this.gunaGroupBox1.TabIndex = 5;
            this.gunaGroupBox1.Text = "Store screens";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(5, 2);
            // 
            // gunaSeparator3
            // 
            this.gunaSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.gunaSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaSeparator3.Location = new System.Drawing.Point(46, 61);
            this.gunaSeparator3.Name = "gunaSeparator3";
            this.gunaSeparator3.Size = new System.Drawing.Size(309, 10);
            this.gunaSeparator3.TabIndex = 6;
            // 
            // allStoreList
            // 
            this.allStoreList.BackColor = System.Drawing.Color.Transparent;
            this.allStoreList.BaseColor = System.Drawing.Color.White;
            this.allStoreList.CheckedOffColor = System.Drawing.Color.Gray;
            this.allStoreList.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.allStoreList.FillColor = System.Drawing.Color.White;
            this.allStoreList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.allStoreList.Location = new System.Drawing.Point(46, 37);
            this.allStoreList.Name = "allStoreList";
            this.allStoreList.Size = new System.Drawing.Size(135, 33);
            this.allStoreList.TabIndex = 3;
            this.allStoreList.Text = "select all";
            this.allStoreList.CheckedChanged += new System.EventHandler(this.allStoreList_CheckedChanged);
            // 
            // storeList
            // 
            this.storeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storeList.CheckOnClick = true;
            this.storeList.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeList.FormattingEnabled = true;
            this.storeList.Items.AddRange(new object[] {
            "Store Categories screen",
            "Store Items screen",
            "Shipments screen",
            "Suppliers screen"});
            this.storeList.Location = new System.Drawing.Point(46, 73);
            this.storeList.Name = "storeList";
            this.storeList.Size = new System.Drawing.Size(324, 90);
            this.storeList.TabIndex = 0;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gunaGroupBox2.Controls.Add(this.gunaSeparator4);
            this.gunaGroupBox2.Controls.Add(this.allCustomerList);
            this.gunaGroupBox2.Controls.Add(this.customerList);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gunaGroupBox2.LineTop = 35;
            this.gunaGroupBox2.Location = new System.Drawing.Point(595, 305);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(390, 206);
            this.gunaGroupBox2.TabIndex = 6;
            this.gunaGroupBox2.Text = "Customer screens";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(5, 2);
            // 
            // gunaSeparator4
            // 
            this.gunaSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.gunaSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaSeparator4.Location = new System.Drawing.Point(44, 63);
            this.gunaSeparator4.Name = "gunaSeparator4";
            this.gunaSeparator4.Size = new System.Drawing.Size(315, 10);
            this.gunaSeparator4.TabIndex = 7;
            // 
            // allCustomerList
            // 
            this.allCustomerList.BackColor = System.Drawing.Color.Transparent;
            this.allCustomerList.BaseColor = System.Drawing.Color.White;
            this.allCustomerList.CheckedOffColor = System.Drawing.Color.Gray;
            this.allCustomerList.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.allCustomerList.FillColor = System.Drawing.Color.White;
            this.allCustomerList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.allCustomerList.Location = new System.Drawing.Point(46, 35);
            this.allCustomerList.Name = "allCustomerList";
            this.allCustomerList.Size = new System.Drawing.Size(135, 33);
            this.allCustomerList.TabIndex = 3;
            this.allCustomerList.Text = "select all";
            this.allCustomerList.CheckedChanged += new System.EventHandler(this.allCustomerList_CheckedChanged);
            // 
            // customerList
            // 
            this.customerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerList.CheckOnClick = true;
            this.customerList.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerList.FormattingEnabled = true;
            this.customerList.Items.AddRange(new object[] {
            "Customers screen",
            "Customer orders screen"});
            this.customerList.Location = new System.Drawing.Point(46, 75);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(313, 90);
            this.customerList.TabIndex = 0;
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gunaGroupBox3.Controls.Add(this.gunaSeparator1);
            this.gunaGroupBox3.Controls.Add(this.allMenuList);
            this.gunaGroupBox3.Controls.Add(this.menuList);
            this.gunaGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox3.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gunaGroupBox3.LineTop = 35;
            this.gunaGroupBox3.Location = new System.Drawing.Point(595, 94);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Radius = 5;
            this.gunaGroupBox3.Size = new System.Drawing.Size(390, 185);
            this.gunaGroupBox3.TabIndex = 6;
            this.gunaGroupBox3.Text = "Menu screens";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(5, 2);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(38, 58);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(308, 10);
            this.gunaSeparator1.TabIndex = 4;
            // 
            // allMenuList
            // 
            this.allMenuList.BackColor = System.Drawing.Color.Transparent;
            this.allMenuList.BaseColor = System.Drawing.Color.White;
            this.allMenuList.CheckedOffColor = System.Drawing.Color.Gray;
            this.allMenuList.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.allMenuList.FillColor = System.Drawing.Color.White;
            this.allMenuList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.allMenuList.Location = new System.Drawing.Point(38, 34);
            this.allMenuList.Name = "allMenuList";
            this.allMenuList.Size = new System.Drawing.Size(135, 33);
            this.allMenuList.TabIndex = 3;
            this.allMenuList.Text = "select all";
            this.allMenuList.CheckedChanged += new System.EventHandler(this.allMenuList_CheckedChanged);
            // 
            // menuList
            // 
            this.menuList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuList.CheckOnClick = true;
            this.menuList.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuList.FormattingEnabled = true;
            this.menuList.Items.AddRange(new object[] {
            "Menu Categories screen",
            "Menu Items screen"});
            this.menuList.Location = new System.Drawing.Point(38, 73);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(321, 60);
            this.menuList.TabIndex = 0;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.gunaImageButton1.Location = new System.Drawing.Point(44, 23);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.OnHoverImage")));
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(37, 43);
            this.gunaImageButton1.TabIndex = 7;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Animated = true;
            this.saveBtn.AnimationHoverSpeed = 0.07F;
            this.saveBtn.AnimationSpeed = 0.03F;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.saveBtn.BorderColor = System.Drawing.Color.Black;
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveBtn.FocusedColor = System.Drawing.Color.Empty;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = null;
            this.saveBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.saveBtn.Location = new System.Drawing.Point(849, 531);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.saveBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.saveBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.saveBtn.OnHoverImage = null;
            this.saveBtn.OnPressedColor = System.Drawing.Color.Black;
            this.saveBtn.Radius = 2;
            this.saveBtn.Size = new System.Drawing.Size(136, 41);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // RoleScreensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1109, 643);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.gunaGroupBox3);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaGroupBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoleScreensForm";
            this.Text = "RoleScreensForm";
            this.Load += new System.EventHandler(this.RoleScreensForm_Load);
            this.gunaGroupBox.ResumeLayout(false);
            this.gunaGroupBox.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.gunaGroupBox3.ResumeLayout(false);
            this.gunaGroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox;
        private Guna.UI.WinForms.GunaCheckBox allUserList;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaCheckBox allStoreList;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaCheckBox allCustomerList;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private Guna.UI.WinForms.GunaCheckBox allMenuList;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator3;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator4;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaButton saveBtn;
        private System.Windows.Forms.CheckedListBox userList;
        private System.Windows.Forms.CheckedListBox storeList;
        private System.Windows.Forms.CheckedListBox customerList;
        private System.Windows.Forms.CheckedListBox menuList;
    }
}