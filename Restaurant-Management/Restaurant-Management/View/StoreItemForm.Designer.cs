﻿
using Bunifu.Framework.UI;

namespace Restaurant_Management.View
{
    partial class StoreItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreItemForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.restaurantManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManagementDataSet = new Restaurant_Management.RestaurantManagementDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.rowCount = new System.Windows.Forms.Label();
            this.searchBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.deleteBtn = new Guna.UI.WinForms.GunaButton();
            this.ITypeLbl = new Guna.UI.WinForms.GunaLabel();
            this.PriceLbl = new Guna.UI.WinForms.GunaLabel();
            this.RequiredAmountLbl = new Guna.UI.WinForms.GunaLabel();
            this.CurrentAmountLbl = new Guna.UI.WinForms.GunaLabel();
            this.ItemnameLbl = new Guna.UI.WinForms.GunaLabel();
            this.IdLbl = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.saveBtn = new Guna.UI.WinForms.GunaButton();
            this.ITypeCombo = new System.Windows.Forms.ComboBox();
            this.storeItemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PriceText = new Guna.UI.WinForms.GunaTextBox();
            this.NameText = new Guna.UI.WinForms.GunaTextBox();
            this.RequiredAmountText = new Guna.UI.WinForms.GunaTextBox();
            this.CurrentAmountText = new Guna.UI.WinForms.GunaTextBox();
            this.IdText = new Guna.UI.WinForms.GunaTextBox();
            this.storeItemTypeTableAdapter = new Restaurant_Management.RestaurantManagementDataSetTableAdapters.StoreItemTypeTableAdapter();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.PullBtn = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeItemTypeBindingSource)).BeginInit();
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
            this.searchTextBox.Location = new System.Drawing.Point(125, 35);
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
            this.panel1.Size = new System.Drawing.Size(711, 762);
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
            this.refreshBtn.Location = new System.Drawing.Point(30, 693);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(193)))), ((int)(((byte)(52)))));
            this.refreshBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshBtn.OnHoverImage = null;
            this.refreshBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.refreshBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.refreshBtn.Radius = 2;
            this.refreshBtn.Size = new System.Drawing.Size(134, 42);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // rowCount
            // 
            this.rowCount.AutoSize = true;
            this.rowCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rowCount.ForeColor = System.Drawing.Color.Gray;
            this.rowCount.Location = new System.Drawing.Point(584, 686);
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
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImagePosition = 0;
            this.searchBtn.ImageZoom = 50;
            this.searchBtn.LabelPosition = 0;
            this.searchBtn.LabelText = "";
            this.searchBtn.Location = new System.Drawing.Point(524, 38);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(66, 35);
            this.searchBtn.TabIndex = 2;
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
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid.ColumnHeadersHeight = 35;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.dataGrid.Size = new System.Drawing.Size(668, 588);
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
            this.groupBox.Controls.Add(this.gunaImageButton1);
            this.groupBox.Controls.Add(this.deleteBtn);
            this.groupBox.Controls.Add(this.ITypeLbl);
            this.groupBox.Controls.Add(this.PriceLbl);
            this.groupBox.Controls.Add(this.RequiredAmountLbl);
            this.groupBox.Controls.Add(this.CurrentAmountLbl);
            this.groupBox.Controls.Add(this.ItemnameLbl);
            this.groupBox.Controls.Add(this.IdLbl);
            this.groupBox.Controls.Add(this.gunaButton1);
            this.groupBox.Controls.Add(this.saveBtn);
            this.groupBox.Controls.Add(this.ITypeCombo);
            this.groupBox.Controls.Add(this.PriceText);
            this.groupBox.Controls.Add(this.NameText);
            this.groupBox.Controls.Add(this.RequiredAmountText);
            this.groupBox.Controls.Add(this.CurrentAmountText);
            this.groupBox.Controls.Add(this.IdText);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.groupBox.Location = new System.Drawing.Point(726, 117);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(515, 553);
            this.groupBox.TabIndex = 20;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Create item";
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(100, 100);
            this.gunaImageButton1.Location = new System.Drawing.Point(216, -70);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(70, 35);
            this.gunaImageButton1.TabIndex = 18;
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
            this.deleteBtn.Location = new System.Drawing.Point(130, 489);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.deleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnHoverImage = null;
            this.deleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteBtn.Radius = 2;
            this.deleteBtn.Size = new System.Drawing.Size(96, 44);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ITypeLbl
            // 
            this.ITypeLbl.AutoSize = true;
            this.ITypeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITypeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ITypeLbl.Location = new System.Drawing.Point(24, 409);
            this.ITypeLbl.Name = "ITypeLbl";
            this.ITypeLbl.Size = new System.Drawing.Size(46, 23);
            this.ITypeLbl.TabIndex = 14;
            this.ITypeLbl.Text = "Type";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PriceLbl.Location = new System.Drawing.Point(23, 188);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(47, 23);
            this.PriceLbl.TabIndex = 12;
            this.PriceLbl.Text = "Price";
            // 
            // RequiredAmountLbl
            // 
            this.RequiredAmountLbl.AutoSize = true;
            this.RequiredAmountLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequiredAmountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.RequiredAmountLbl.Location = new System.Drawing.Point(24, 336);
            this.RequiredAmountLbl.Name = "RequiredAmountLbl";
            this.RequiredAmountLbl.Size = new System.Drawing.Size(146, 23);
            this.RequiredAmountLbl.TabIndex = 11;
            this.RequiredAmountLbl.Text = "Required Amount";
            // 
            // CurrentAmountLbl
            // 
            this.CurrentAmountLbl.AutoSize = true;
            this.CurrentAmountLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAmountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.CurrentAmountLbl.Location = new System.Drawing.Point(22, 262);
            this.CurrentAmountLbl.Name = "CurrentAmountLbl";
            this.CurrentAmountLbl.Size = new System.Drawing.Size(135, 23);
            this.CurrentAmountLbl.TabIndex = 10;
            this.CurrentAmountLbl.Text = "Current Amount";
            // 
            // ItemnameLbl
            // 
            this.ItemnameLbl.AutoSize = true;
            this.ItemnameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemnameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ItemnameLbl.Location = new System.Drawing.Point(24, 115);
            this.ItemnameLbl.Name = "ItemnameLbl";
            this.ItemnameLbl.Size = new System.Drawing.Size(56, 23);
            this.ItemnameLbl.TabIndex = 9;
            this.ItemnameLbl.Text = "Name";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.IdLbl.Location = new System.Drawing.Point(23, 43);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(27, 23);
            this.IdLbl.TabIndex = 3;
            this.IdLbl.Text = "ID";
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
            this.gunaButton1.Location = new System.Drawing.Point(401, 489);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(193)))), ((int)(((byte)(52)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 2;
            this.gunaButton1.Size = new System.Drawing.Size(94, 44);
            this.gunaButton1.TabIndex = 10;
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
            this.saveBtn.Location = new System.Drawing.Point(28, 489);
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
            // ITypeCombo
            // 
            this.ITypeCombo.DataSource = this.storeItemTypeBindingSource;
            this.ITypeCombo.DisplayMember = "Name";
            this.ITypeCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ITypeCombo.FormattingEnabled = true;
            this.ITypeCombo.Location = new System.Drawing.Point(26, 434);
            this.ITypeCombo.Name = "ITypeCombo";
            this.ITypeCombo.Size = new System.Drawing.Size(470, 36);
            this.ITypeCombo.TabIndex = 7;
            this.ITypeCombo.ValueMember = "ID";
            // 
            // storeItemTypeBindingSource
            // 
            this.storeItemTypeBindingSource.DataMember = "StoreItemType";
            this.storeItemTypeBindingSource.DataSource = this.restaurantManagementDataSetBindingSource;
            // 
            // PriceText
            // 
            this.PriceText.BaseColor = System.Drawing.Color.White;
            this.PriceText.BorderColor = System.Drawing.Color.Silver;
            this.PriceText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceText.FocusedBaseColor = System.Drawing.Color.White;
            this.PriceText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.PriceText.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.PriceText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PriceText.ForeColor = System.Drawing.Color.Black;
            this.PriceText.Location = new System.Drawing.Point(27, 211);
            this.PriceText.Name = "PriceText";
            this.PriceText.PasswordChar = '\0';
            this.PriceText.SelectedText = "";
            this.PriceText.Size = new System.Drawing.Size(470, 41);
            this.PriceText.TabIndex = 4;
            this.PriceText.Text = "Enter price";
            this.PriceText.TextChanged += new System.EventHandler(this.PriceText_TextChanged);
            this.PriceText.Enter += new System.EventHandler(this.formText_Enter);
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
            this.NameText.Location = new System.Drawing.Point(25, 139);
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.SelectedText = "";
            this.NameText.Size = new System.Drawing.Size(470, 41);
            this.NameText.TabIndex = 3;
            this.NameText.Text = "Enter name";
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            this.NameText.Enter += new System.EventHandler(this.formText_Enter);
            // 
            // RequiredAmountText
            // 
            this.RequiredAmountText.BaseColor = System.Drawing.Color.White;
            this.RequiredAmountText.BorderColor = System.Drawing.Color.Silver;
            this.RequiredAmountText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RequiredAmountText.FocusedBaseColor = System.Drawing.Color.White;
            this.RequiredAmountText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.RequiredAmountText.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.RequiredAmountText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RequiredAmountText.ForeColor = System.Drawing.Color.Black;
            this.RequiredAmountText.Location = new System.Drawing.Point(28, 362);
            this.RequiredAmountText.Name = "RequiredAmountText";
            this.RequiredAmountText.PasswordChar = '\0';
            this.RequiredAmountText.SelectedText = "";
            this.RequiredAmountText.Size = new System.Drawing.Size(467, 41);
            this.RequiredAmountText.TabIndex = 6;
            this.RequiredAmountText.Text = "Enter Required Amount";
            this.RequiredAmountText.TextChanged += new System.EventHandler(this.RequiredAmountText_TextChanged);
            this.RequiredAmountText.Enter += new System.EventHandler(this.formText_Enter);
            // 
            // CurrentAmountText
            // 
            this.CurrentAmountText.BaseColor = System.Drawing.Color.White;
            this.CurrentAmountText.BorderColor = System.Drawing.Color.Silver;
            this.CurrentAmountText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CurrentAmountText.FocusedBaseColor = System.Drawing.Color.White;
            this.CurrentAmountText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.CurrentAmountText.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.CurrentAmountText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CurrentAmountText.ForeColor = System.Drawing.Color.Black;
            this.CurrentAmountText.Location = new System.Drawing.Point(25, 286);
            this.CurrentAmountText.Name = "CurrentAmountText";
            this.CurrentAmountText.PasswordChar = '\0';
            this.CurrentAmountText.SelectedText = "";
            this.CurrentAmountText.Size = new System.Drawing.Size(470, 41);
            this.CurrentAmountText.TabIndex = 5;
            this.CurrentAmountText.Text = "Enter Current Amount";
            this.CurrentAmountText.TextChanged += new System.EventHandler(this.CurrentAmountText_TextChanged);
            this.CurrentAmountText.Enter += new System.EventHandler(this.formText_Enter);
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
            this.IdText.Location = new System.Drawing.Point(25, 66);
            this.IdText.Name = "IdText";
            this.IdText.PasswordChar = '\0';
            this.IdText.SelectedText = "";
            this.IdText.Size = new System.Drawing.Size(470, 41);
            this.IdText.TabIndex = 1;
            this.IdText.Text = "ID";
            this.IdText.Enter += new System.EventHandler(this.formText_Enter);
            // 
            // storeItemTypeTableAdapter
            // 
            this.storeItemTypeTableAdapter.ClearBeforeFill = true;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(100, 100);
            this.gunaImageButton2.Location = new System.Drawing.Point(908, 32);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(121, 90);
            this.gunaImageButton2.TabIndex = 19;
            // 
            // PullBtn
            // 
            this.PullBtn.Animated = true;
            this.PullBtn.AnimationHoverSpeed = 0.07F;
            this.PullBtn.AnimationSpeed = 0.03F;
            this.PullBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PullBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.PullBtn.BorderColor = System.Drawing.Color.Black;
            this.PullBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PullBtn.FocusedColor = System.Drawing.Color.Empty;
            this.PullBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PullBtn.ForeColor = System.Drawing.Color.White;
            this.PullBtn.Image = null;
            this.PullBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.PullBtn.Location = new System.Drawing.Point(1106, 86);
            this.PullBtn.Name = "PullBtn";
            this.PullBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.PullBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PullBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.PullBtn.OnHoverImage = null;
            this.PullBtn.OnPressedColor = System.Drawing.Color.Black;
            this.PullBtn.Radius = 2;
            this.PullBtn.Size = new System.Drawing.Size(135, 44);
            this.PullBtn.TabIndex = 20;
            this.PullBtn.Text = "Pull";
            this.PullBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PullBtn.Click += new System.EventHandler(this.PullBtn_Click);
            // 
            // StoreItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1468, 762);
            this.Controls.Add(this.PullBtn);
            this.Controls.Add(this.gunaImageButton2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StoreItemForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StoreItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeItemTypeBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid;
        private BunifuTileButton searchBtn;
        private Guna.UI.WinForms.GunaLineTextBox searchTextBox;
        private System.Windows.Forms.Label rowCount;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox ITypeCombo;
        private Guna.UI.WinForms.GunaTextBox PriceText;
        private Guna.UI.WinForms.GunaTextBox NameText;
        private Guna.UI.WinForms.GunaTextBox RequiredAmountText;
        private Guna.UI.WinForms.GunaTextBox CurrentAmountText;
        private Guna.UI.WinForms.GunaTextBox IdText;
        private Guna.UI.WinForms.GunaButton saveBtn;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel ITypeLbl;
        private Guna.UI.WinForms.GunaLabel PriceLbl;
        private Guna.UI.WinForms.GunaLabel RequiredAmountLbl;
        private Guna.UI.WinForms.GunaLabel CurrentAmountLbl;
        private Guna.UI.WinForms.GunaLabel ItemnameLbl;
        private Guna.UI.WinForms.GunaLabel IdLbl;
        private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
        private Guna.UI.WinForms.GunaButton deleteBtn;
        private System.Windows.Forms.BindingSource storeItemTypeBindingSource;
        private RestaurantManagementDataSetTableAdapters.StoreItemTypeTableAdapter storeItemTypeTableAdapter;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaButton PullBtn;
    }
}