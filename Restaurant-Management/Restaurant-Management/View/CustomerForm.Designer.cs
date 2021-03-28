namespace Restaurant_Management.View
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.rowCount = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.searchBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.AddresLbl = new Guna.UI.WinForms.GunaLabel();
            this.AddressText = new Guna.UI.WinForms.GunaTextBox();
            this.IdText = new Guna.UI.WinForms.GunaTextBox();
            this.IdLbl = new Guna.UI.WinForms.GunaLabel();
            this.deleteBtn = new Guna.UI.WinForms.GunaButton();
            this.PhoneLbl = new Guna.UI.WinForms.GunaLabel();
            this.CustomernameLbl = new Guna.UI.WinForms.GunaLabel();
            this.clearBtn = new Guna.UI.WinForms.GunaButton();
            this.saveBtn = new Guna.UI.WinForms.GunaButton();
            this.NameText = new Guna.UI.WinForms.GunaTextBox();
            this.PhoneText = new Guna.UI.WinForms.GunaTextBox();
            this.gunaImageButton5 = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowCount
            // 
            this.rowCount.AutoSize = true;
            this.rowCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rowCount.ForeColor = System.Drawing.Color.Gray;
            this.rowCount.Location = new System.Drawing.Point(763, 712);
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(94, 23);
            this.rowCount.TabIndex = 19;
            this.rowCount.Text = "row counts";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid.ColumnHeadersHeight = 35;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(71, 113);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 40;
            this.dataGrid.RowTemplate.Height = 32;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(832, 596);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.TabStop = false;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGrid_DataBindingComplete);
            this.dataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGrid_rowCountChange);
            this.dataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGrid_rowCountChange);
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            this.dataGrid.Leave += new System.EventHandler(this.dataGrid_Leave);
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
            this.searchTextBox.Location = new System.Drawing.Point(241, 44);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(469, 45);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "What do you want to seach?";
            this.searchTextBox.TextOffsetX = 6;
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaAdvenceButton1);
            this.panel1.Controls.Add(this.rowCount);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.dataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 806);
            this.panel1.TabIndex = 20;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(71, 721);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(193)))), ((int)(((byte)(52)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.gunaAdvenceButton1.Radius = 2;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(163, 42);
            this.gunaAdvenceButton1.TabIndex = 9;
            this.gunaAdvenceButton1.Text = "Refresh";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
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
            this.searchBtn.Location = new System.Drawing.Point(644, 50);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(66, 35);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Click += new System.EventHandler(this.search);
            this.searchBtn.MouseEnter += new System.EventHandler(this.searchBtn_active);
            this.searchBtn.MouseLeave += new System.EventHandler(this.searchBtn_disactive);
            this.searchBtn.MouseHover += new System.EventHandler(this.searchBtn_active);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Animated = true;
            this.refreshBtn.AnimationHoverSpeed = 0.07F;
            this.refreshBtn.AnimationSpeed = 0.03F;
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.refreshBtn.BorderColor = System.Drawing.Color.Black;
            this.refreshBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.refreshBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.refreshBtn.CheckedForeColor = System.Drawing.Color.White;
            this.refreshBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.CheckedImage")));
            this.refreshBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.refreshBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshBtn.FocusedColor = System.Drawing.Color.Empty;
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.refreshBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.refreshBtn.Location = new System.Drawing.Point(27, 696);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(193)))), ((int)(((byte)(52)))));
            this.refreshBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshBtn.OnHoverImage = null;
            this.refreshBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.refreshBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.refreshBtn.Radius = 2;
            this.refreshBtn.Size = new System.Drawing.Size(164, 42);
            this.refreshBtn.TabIndex = 17;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.AddresLbl);
            this.groupBox.Controls.Add(this.AddressText);
            this.groupBox.Controls.Add(this.IdText);
            this.groupBox.Controls.Add(this.IdLbl);
            this.groupBox.Controls.Add(this.deleteBtn);
            this.groupBox.Controls.Add(this.PhoneLbl);
            this.groupBox.Controls.Add(this.CustomernameLbl);
            this.groupBox.Controls.Add(this.clearBtn);
            this.groupBox.Controls.Add(this.saveBtn);
            this.groupBox.Controls.Add(this.NameText);
            this.groupBox.Controls.Add(this.PhoneText);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.groupBox.Location = new System.Drawing.Point(980, 175);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(652, 501);
            this.groupBox.TabIndex = 20;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Create Customer";
            // 
            // AddresLbl
            // 
            this.AddresLbl.AutoSize = true;
            this.AddresLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddresLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.AddresLbl.Location = new System.Drawing.Point(38, 292);
            this.AddresLbl.Name = "AddresLbl";
            this.AddresLbl.Size = new System.Drawing.Size(63, 23);
            this.AddresLbl.TabIndex = 19;
            this.AddresLbl.Text = "Addres";
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
            this.AddressText.Location = new System.Drawing.Point(42, 318);
            this.AddressText.Name = "AddressText";
            this.AddressText.PasswordChar = '\0';
            this.AddressText.SelectedText = "";
            this.AddressText.Size = new System.Drawing.Size(568, 41);
            this.AddressText.TabIndex = 5;
            this.AddressText.Text = "Enter address";
            this.AddressText.Enter += new System.EventHandler(this.formText_Enter);
            // 
            // IdText
            // 
            this.IdText.BaseColor = System.Drawing.Color.White;
            this.IdText.BorderColor = System.Drawing.Color.Silver;
            this.IdText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdText.FocusedBaseColor = System.Drawing.Color.White;
            this.IdText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.IdText.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.IdText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IdText.ForeColor = System.Drawing.Color.Black;
            this.IdText.Location = new System.Drawing.Point(42, 76);
            this.IdText.Name = "IdText";
            this.IdText.PasswordChar = '\0';
            this.IdText.SelectedText = "";
            this.IdText.Size = new System.Drawing.Size(568, 41);
            this.IdText.TabIndex = 17;
            this.IdText.Text = "ID";
            this.IdText.TextChanged += new System.EventHandler(this.IdText_TextChanged);
            this.IdText.Enter += new System.EventHandler(this.formText_Enter);
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.IdLbl.Location = new System.Drawing.Point(38, 50);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(106, 23);
            this.IdLbl.TabIndex = 16;
            this.IdLbl.Text = "Customer ID";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Animated = true;
            this.deleteBtn.AnimationHoverSpeed = 0.07F;
            this.deleteBtn.AnimationSpeed = 0.03F;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.deleteBtn.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = null;
            this.deleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteBtn.Location = new System.Drawing.Point(157, 406);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.deleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnHoverImage = null;
            this.deleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteBtn.Radius = 2;
            this.deleteBtn.Size = new System.Drawing.Size(96, 44);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PhoneLbl.Location = new System.Drawing.Point(38, 209);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(59, 23);
            this.PhoneLbl.TabIndex = 10;
            this.PhoneLbl.Text = "Phone";
            this.PhoneLbl.Click += new System.EventHandler(this.PhoneLbl_Click);
            // 
            // CustomernameLbl
            // 
            this.CustomernameLbl.AutoSize = true;
            this.CustomernameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.CustomernameLbl.Location = new System.Drawing.Point(38, 129);
            this.CustomernameLbl.Name = "CustomernameLbl";
            this.CustomernameLbl.Size = new System.Drawing.Size(56, 23);
            this.CustomernameLbl.TabIndex = 9;
            this.CustomernameLbl.Text = "Name";
            // 
            // clearBtn
            // 
            this.clearBtn.Animated = true;
            this.clearBtn.AnimationHoverSpeed = 0.07F;
            this.clearBtn.AnimationSpeed = 0.03F;
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.clearBtn.BorderColor = System.Drawing.Color.Black;
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clearBtn.FocusedColor = System.Drawing.Color.Empty;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Image = null;
            this.clearBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.clearBtn.Location = new System.Drawing.Point(481, 406);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(193)))), ((int)(((byte)(52)))));
            this.clearBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clearBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.clearBtn.OnHoverImage = null;
            this.clearBtn.OnPressedColor = System.Drawing.Color.Black;
            this.clearBtn.Radius = 2;
            this.clearBtn.Size = new System.Drawing.Size(129, 44);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearBtn.Click += new System.EventHandler(this.gunaButton1_Click);
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
            this.saveBtn.Location = new System.Drawing.Point(42, 406);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.saveBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.saveBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.saveBtn.OnHoverImage = null;
            this.saveBtn.OnPressedColor = System.Drawing.Color.Black;
            this.saveBtn.Radius = 2;
            this.saveBtn.Size = new System.Drawing.Size(97, 44);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // NameText
            // 
            this.NameText.BaseColor = System.Drawing.Color.White;
            this.NameText.BorderColor = System.Drawing.Color.Silver;
            this.NameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameText.FocusedBaseColor = System.Drawing.Color.White;
            this.NameText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.NameText.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NameText.ForeColor = System.Drawing.Color.Black;
            this.NameText.Location = new System.Drawing.Point(42, 155);
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.SelectedText = "";
            this.NameText.Size = new System.Drawing.Size(568, 41);
            this.NameText.TabIndex = 3;
            this.NameText.TabStop = false;
            this.NameText.Text = "Enter customer name";
            this.NameText.TextChanged += new System.EventHandler(this.CustomernameText_TextChanged);
            this.NameText.Enter += new System.EventHandler(this.formText_Enter);
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
            this.PhoneText.Location = new System.Drawing.Point(42, 235);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.PasswordChar = '\0';
            this.PhoneText.SelectedText = "";
            this.PhoneText.Size = new System.Drawing.Size(568, 41);
            this.PhoneText.TabIndex = 4;
            this.PhoneText.Text = "Enter phone number";
            this.PhoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            this.PhoneText.Enter += new System.EventHandler(this.formText_Enter);
            // 
            // gunaImageButton5
            // 
            this.gunaImageButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton5.Image")));
            this.gunaImageButton5.ImageSize = new System.Drawing.Size(100, 100);
            this.gunaImageButton5.Location = new System.Drawing.Point(1223, 44);
            this.gunaImageButton5.Name = "gunaImageButton5";
            this.gunaImageButton5.OnHoverImage = null;
            this.gunaImageButton5.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton5.Size = new System.Drawing.Size(155, 120);
            this.gunaImageButton5.TabIndex = 21;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1794, 806);
            this.Controls.Add(this.gunaImageButton5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
        private System.Windows.Forms.Label rowCount;
        private System.Windows.Forms.DataGridView dataGrid;
        private Guna.UI.WinForms.GunaLineTextBox searchTextBox;
        private Bunifu.Framework.UI.BunifuTileButton searchBtn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.GroupBox groupBox;
        private Guna.UI.WinForms.GunaLabel AddresLbl;
        private Guna.UI.WinForms.GunaTextBox AddressText;
        private Guna.UI.WinForms.GunaTextBox IdText;
        private Guna.UI.WinForms.GunaLabel IdLbl;
        private Guna.UI.WinForms.GunaButton deleteBtn;
        private Guna.UI.WinForms.GunaLabel PhoneLbl;
        private Guna.UI.WinForms.GunaLabel CustomernameLbl;
        private Guna.UI.WinForms.GunaButton clearBtn;
        private Guna.UI.WinForms.GunaButton saveBtn;
        private Guna.UI.WinForms.GunaTextBox NameText;
        private Guna.UI.WinForms.GunaTextBox PhoneText;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton5;
    }
}