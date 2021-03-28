
using Bunifu.Framework.UI;

namespace Restaurant_Management.View
{
    partial class ItemShipmentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemShipmentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManagementDataSet = new Restaurant_Management.RestaurantManagementDataSet();
            this.usersTableAdapter = new Restaurant_Management.RestaurantManagementDataSetTableAdapters.UsersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.rowCount = new System.Windows.Forms.Label();
            this.searchBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new Guna.UI.WinForms.GunaButton();
            this.StoreItemLbl = new Guna.UI.WinForms.GunaLabel();
            this.SupplierLbl = new Guna.UI.WinForms.GunaLabel();
            this.ExperiedTimeLbl = new Guna.UI.WinForms.GunaLabel();
            this.ArrivalTimeLbl = new Guna.UI.WinForms.GunaLabel();
            this.CountLbl = new Guna.UI.WinForms.GunaLabel();
            this.IdLbl = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.saveBtn = new Guna.UI.WinForms.GunaButton();
            this.storeItemCombo = new System.Windows.Forms.ComboBox();
            this.storeItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersCombo = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CountText = new Guna.UI.WinForms.GunaTextBox();
            this.IdText = new Guna.UI.WinForms.GunaTextBox();
            this.userTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTypeTableAdapter = new Restaurant_Management.RestaurantManagementDataSetTableAdapters.UserTypeTableAdapter();
            this.supplierTableAdapter = new Restaurant_Management.RestaurantManagementDataSetTableAdapters.SupplierTableAdapter();
            this.storeItemTableAdapter = new Restaurant_Management.RestaurantManagementDataSetTableAdapters.StoreItemTableAdapter();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).BeginInit();
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
            this.searchTextBox.Location = new System.Drawing.Point(132, 31);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(469, 45);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TabStop = false;
            this.searchTextBox.Text = "What do you want to seach?";
            this.searchTextBox.TextOffsetX = 6;
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.restaurantManagementDataSetBindingSource;
            // 
            // restaurantManagementDataSetBindingSource
            // 
            this.restaurantManagementDataSetBindingSource.DataSource = this.restaurantManagementDataSet;
            this.restaurantManagementDataSetBindingSource.Position = 0;
            // 
            // restaurantManagementDataSet
            // 
            this.restaurantManagementDataSet.DataSetName = "RestaurantManagementDataSet";
            this.restaurantManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.rowCount);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.dataGrid);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 769);
            this.panel1.TabIndex = 1;
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
            this.refreshBtn.Location = new System.Drawing.Point(30, 694);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(193)))), ((int)(((byte)(52)))));
            this.refreshBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshBtn.OnHoverImage = null;
            this.refreshBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.refreshBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.refreshBtn.Radius = 2;
            this.refreshBtn.Size = new System.Drawing.Size(129, 42);
            this.refreshBtn.TabIndex = 16;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // rowCount
            // 
            this.rowCount.AutoSize = true;
            this.rowCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rowCount.ForeColor = System.Drawing.Color.Gray;
            this.rowCount.Location = new System.Drawing.Point(577, 686);
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(94, 23);
            this.rowCount.TabIndex = 0;
            this.rowCount.Text = "row counts";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.color = System.Drawing.Color.White;
            this.searchBtn.colorActive = System.Drawing.Color.White;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImagePosition = 0;
            this.searchBtn.ImageZoom = 50;
            this.searchBtn.LabelPosition = 0;
            this.searchBtn.LabelText = "";
            this.searchBtn.Location = new System.Drawing.Point(535, 36);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(66, 35);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Click += new System.EventHandler(this.search);
            this.searchBtn.MouseEnter += new System.EventHandler(this.searchBtn_active);
            this.searchBtn.MouseLeave += new System.EventHandler(this.searchBtn_disactive);
            this.searchBtn.MouseHover += new System.EventHandler(this.searchBtn_active);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
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
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid.ColumnHeadersHeight = 35;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(30, 95);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 40;
            this.dataGrid.RowTemplate.Height = 32;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(660, 588);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.TabStop = false;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGrid_DataBindingComplete);
            this.dataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGrid_rowCountChange);
            this.dataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGrid_rowCountChange);
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            this.dataGrid.Leave += new System.EventHandler(this.dataGrid_Leave);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dateTimePicker2);
            this.groupBox.Controls.Add(this.dateTimePicker1);
            this.groupBox.Controls.Add(this.deleteBtn);
            this.groupBox.Controls.Add(this.StoreItemLbl);
            this.groupBox.Controls.Add(this.SupplierLbl);
            this.groupBox.Controls.Add(this.ExperiedTimeLbl);
            this.groupBox.Controls.Add(this.ArrivalTimeLbl);
            this.groupBox.Controls.Add(this.CountLbl);
            this.groupBox.Controls.Add(this.IdLbl);
            this.groupBox.Controls.Add(this.gunaButton1);
            this.groupBox.Controls.Add(this.saveBtn);
            this.groupBox.Controls.Add(this.storeItemCombo);
            this.groupBox.Controls.Add(this.suppliersCombo);
            this.groupBox.Controls.Add(this.CountText);
            this.groupBox.Controls.Add(this.IdText);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.groupBox.Location = new System.Drawing.Point(733, 153);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(522, 504);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Create Shipment";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(263, 224);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(234, 34);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 34);
            this.dateTimePicker1.TabIndex = 16;
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
            this.deleteBtn.Location = new System.Drawing.Point(127, 423);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.deleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnHoverImage = null;
            this.deleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteBtn.Radius = 2;
            this.deleteBtn.Size = new System.Drawing.Size(96, 44);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // StoreItemLbl
            // 
            this.StoreItemLbl.AutoSize = true;
            this.StoreItemLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreItemLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.StoreItemLbl.Location = new System.Drawing.Point(21, 263);
            this.StoreItemLbl.Name = "StoreItemLbl";
            this.StoreItemLbl.Size = new System.Drawing.Size(90, 23);
            this.StoreItemLbl.TabIndex = 14;
            this.StoreItemLbl.Text = "Store Item";
            // 
            // SupplierLbl
            // 
            this.SupplierLbl.AutoSize = true;
            this.SupplierLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SupplierLbl.Location = new System.Drawing.Point(24, 330);
            this.SupplierLbl.Name = "SupplierLbl";
            this.SupplierLbl.Size = new System.Drawing.Size(72, 23);
            this.SupplierLbl.TabIndex = 14;
            this.SupplierLbl.Text = "Supplier";
            // 
            // ExperiedTimeLbl
            // 
            this.ExperiedTimeLbl.AutoSize = true;
            this.ExperiedTimeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExperiedTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ExperiedTimeLbl.Location = new System.Drawing.Point(259, 194);
            this.ExperiedTimeLbl.Name = "ExperiedTimeLbl";
            this.ExperiedTimeLbl.Size = new System.Drawing.Size(118, 23);
            this.ExperiedTimeLbl.TabIndex = 11;
            this.ExperiedTimeLbl.Text = "Experied Time";
            // 
            // ArrivalTimeLbl
            // 
            this.ArrivalTimeLbl.AutoSize = true;
            this.ArrivalTimeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ArrivalTimeLbl.Location = new System.Drawing.Point(22, 194);
            this.ArrivalTimeLbl.Name = "ArrivalTimeLbl";
            this.ArrivalTimeLbl.Size = new System.Drawing.Size(101, 23);
            this.ArrivalTimeLbl.TabIndex = 10;
            this.ArrivalTimeLbl.Text = "Arrival Time";
            // 
            // CountLbl
            // 
            this.CountLbl.AutoSize = true;
            this.CountLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.CountLbl.Location = new System.Drawing.Point(24, 122);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(57, 23);
            this.CountLbl.TabIndex = 9;
            this.CountLbl.Text = "Count";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.IdLbl.Location = new System.Drawing.Point(23, 53);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(105, 23);
            this.IdLbl.TabIndex = 3;
            this.IdLbl.Text = "Shipment ID";
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(401, 423);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(193)))), ((int)(((byte)(52)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 2;
            this.gunaButton1.Size = new System.Drawing.Size(96, 44);
            this.gunaButton1.TabIndex = 9;
            this.gunaButton1.Text = "Clear";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
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
            this.saveBtn.Location = new System.Drawing.Point(25, 423);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.saveBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.saveBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.saveBtn.OnHoverImage = null;
            this.saveBtn.OnPressedColor = System.Drawing.Color.Black;
            this.saveBtn.Radius = 2;
            this.saveBtn.Size = new System.Drawing.Size(87, 44);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // storeItemCombo
            // 
            this.storeItemCombo.DataSource = this.storeItemBindingSource;
            this.storeItemCombo.DisplayMember = "name";
            this.storeItemCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.storeItemCombo.FormattingEnabled = true;
            this.storeItemCombo.Location = new System.Drawing.Point(25, 289);
            this.storeItemCombo.Name = "storeItemCombo";
            this.storeItemCombo.Size = new System.Drawing.Size(472, 36);
            this.storeItemCombo.TabIndex = 7;
            this.storeItemCombo.ValueMember = "ID";
            // 
            // storeItemBindingSource
            // 
            this.storeItemBindingSource.DataMember = "StoreItem";
            this.storeItemBindingSource.DataSource = this.restaurantManagementDataSet;
            // 
            // suppliersCombo
            // 
            this.suppliersCombo.DataSource = this.supplierBindingSource;
            this.suppliersCombo.DisplayMember = "name";
            this.suppliersCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.suppliersCombo.FormattingEnabled = true;
            this.suppliersCombo.Location = new System.Drawing.Point(25, 356);
            this.suppliersCombo.Name = "suppliersCombo";
            this.suppliersCombo.Size = new System.Drawing.Size(472, 36);
            this.suppliersCombo.TabIndex = 7;
            this.suppliersCombo.ValueMember = "ID";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.restaurantManagementDataSet;
            // 
            // CountText
            // 
            this.CountText.BaseColor = System.Drawing.Color.White;
            this.CountText.BorderColor = System.Drawing.Color.Silver;
            this.CountText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CountText.FocusedBaseColor = System.Drawing.Color.White;
            this.CountText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.CountText.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.CountText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CountText.ForeColor = System.Drawing.Color.Black;
            this.CountText.Location = new System.Drawing.Point(25, 146);
            this.CountText.Name = "CountText";
            this.CountText.PasswordChar = '\0';
            this.CountText.SelectedText = "";
            this.CountText.Size = new System.Drawing.Size(472, 41);
            this.CountText.TabIndex = 2;
            this.CountText.Text = "Count";
            this.CountText.TextChanged += new System.EventHandler(this.UsernameText_TextChanged);
            this.CountText.Enter += new System.EventHandler(this.CountText_Enter);
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
            this.IdText.Location = new System.Drawing.Point(25, 76);
            this.IdText.Name = "IdText";
            this.IdText.PasswordChar = '\0';
            this.IdText.SelectedText = "";
            this.IdText.Size = new System.Drawing.Size(472, 41);
            this.IdText.TabIndex = 1;
            this.IdText.Text = "ID";
            // 
            // userTypeBindingSource
            // 
            this.userTypeBindingSource.DataMember = "UserType";
            this.userTypeBindingSource.DataSource = this.restaurantManagementDataSetBindingSource;
            // 
            // userTypeTableAdapter
            // 
            this.userTypeTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // storeItemTableAdapter
            // 
            this.storeItemTableAdapter.ClearBeforeFill = true;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(100, 100);
            this.gunaImageButton1.Location = new System.Drawing.Point(916, 46);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(133, 111);
            this.gunaImageButton1.TabIndex = 10;
            // 
            // ItemShipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1418, 769);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemShipmentForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fristNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private RestaurantManagementDataSet restaurantManagementDataSet;
        private System.Windows.Forms.BindingSource restaurantManagementDataSetBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private RestaurantManagementDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid;
        private BunifuTileButton searchBtn;
        private Guna.UI.WinForms.GunaLineTextBox searchTextBox;
        private System.Windows.Forms.Label rowCount;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox suppliersCombo;
        private Guna.UI.WinForms.GunaTextBox CountText;
        private Guna.UI.WinForms.GunaTextBox IdText;
        private System.Windows.Forms.BindingSource userTypeBindingSource;
        private RestaurantManagementDataSetTableAdapters.UserTypeTableAdapter userTypeTableAdapter;
        private Guna.UI.WinForms.GunaButton saveBtn;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel SupplierLbl;
        private Guna.UI.WinForms.GunaLabel ExperiedTimeLbl;
        private Guna.UI.WinForms.GunaLabel ArrivalTimeLbl;
        private Guna.UI.WinForms.GunaLabel CountLbl;
        private Guna.UI.WinForms.GunaLabel IdLbl;
        private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
        private Guna.UI.WinForms.GunaButton deleteBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI.WinForms.GunaLabel StoreItemLbl;
        private System.Windows.Forms.ComboBox storeItemCombo;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private RestaurantManagementDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource storeItemBindingSource;
        private RestaurantManagementDataSetTableAdapters.StoreItemTableAdapter storeItemTableAdapter;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}