namespace main_menu
{
    partial class Inventory
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventoryToOrders = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.seniorDesignNewSIPDataSet4 = new main_menu.SeniorDesignNewSIPDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTextDes = new System.Windows.Forms.TextBox();
            this.txtTextretail = new System.Windows.Forms.TextBox();
            this.txtTextSku = new System.Windows.Forms.TextBox();
            this.txtTextVendor = new System.Windows.Forms.TextBox();
            this.txtTextName = new System.Windows.Forms.TextBox();
            this.txtTextOnHands = new System.Windows.Forms.TextBox();
            this.txtTextItemSize = new System.Windows.Forms.TextBox();
            this.lbldesdisplay = new System.Windows.Forms.Label();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblOnHands = new System.Windows.Forms.Label();
            this.lblCloseProgram = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblItemSize = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.editInventory = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seniorDesignNewSIPDataSet2 = new main_menu.SeniorDesignNewSIPDataSet2();
            this.seniorDesignNewSIPDataSet = new main_menu.SeniorDesignNewSIPDataSet();
            this.seniorDesignNewSIPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seniorDesignNewSIPDataSet1 = new main_menu.SeniorDesignNewSIPDataSet1();
            this.seniorDesignNewSIPDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new main_menu.SeniorDesignNewSIPDataSet2TableAdapters.itemsTableAdapter();
            this.seniorDesignNewSIPDataSet3 = new main_menu.SeniorDesignNewSIPDataSet3();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter1 = new main_menu.SeniorDesignNewSIPDataSet3TableAdapters.itemsTableAdapter();
            this.itemsTableAdapter2 = new main_menu.SeniorDesignNewSIPDataSet4TableAdapters.itemsTableAdapter();
            this.process1 = new System.Diagnostics.Process();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Candara", 16F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.textBox1.Location = new System.Drawing.Point(0, 254);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(217, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Inventory";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.inventoryToOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 472);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::main_menu.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 203);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // inventoryToOrders
            // 
            this.inventoryToOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.inventoryToOrders.Location = new System.Drawing.Point(21, 427);
            this.inventoryToOrders.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryToOrders.Name = "inventoryToOrders";
            this.inventoryToOrders.Size = new System.Drawing.Size(176, 39);
            this.inventoryToOrders.TabIndex = 1;
            this.inventoryToOrders.Text = "Go To Orders";
            this.inventoryToOrders.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 472);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skuDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemSizeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(28, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(451, 362);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "sku";
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            this.skuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "itemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemSizeDataGridViewTextBoxColumn
            // 
            this.itemSizeDataGridViewTextBoxColumn.DataPropertyName = "itemSize";
            this.itemSizeDataGridViewTextBoxColumn.HeaderText = "itemSize";
            this.itemSizeDataGridViewTextBoxColumn.Name = "itemSizeDataGridViewTextBoxColumn";
            this.itemSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemsBindingSource2
            // 
            this.itemsBindingSource2.DataMember = "items";
            this.itemsBindingSource2.DataSource = this.seniorDesignNewSIPDataSet4;
            // 
            // seniorDesignNewSIPDataSet4
            // 
            this.seniorDesignNewSIPDataSet4.DataSetName = "SeniorDesignNewSIPDataSet4";
            this.seniorDesignNewSIPDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(24, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search  for Item:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTextDes);
            this.panel3.Controls.Add(this.txtTextretail);
            this.panel3.Controls.Add(this.txtTextSku);
            this.panel3.Controls.Add(this.txtTextVendor);
            this.panel3.Controls.Add(this.txtTextName);
            this.panel3.Controls.Add(this.txtTextOnHands);
            this.panel3.Controls.Add(this.txtTextItemSize);
            this.panel3.Controls.Add(this.lbldesdisplay);
            this.panel3.Controls.Add(this.lblRetailPrice);
            this.panel3.Controls.Add(this.lblDescription);
            this.panel3.Controls.Add(this.lblOnHands);
            this.panel3.Controls.Add(this.lblCloseProgram);
            this.panel3.Controls.Add(this.lblVendor);
            this.panel3.Controls.Add(this.lblItemSize);
            this.panel3.Controls.Add(this.lbl);
            this.panel3.Controls.Add(this.lblItemName);
            this.panel3.Controls.Add(this.editInventory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel3.Location = new System.Drawing.Point(508, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 472);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtTextDes
            // 
            this.txtTextDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.txtTextDes.Font = new System.Drawing.Font("Candara", 12F);
            this.txtTextDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txtTextDes.Location = new System.Drawing.Point(129, 290);
            this.txtTextDes.Multiline = true;
            this.txtTextDes.Name = "txtTextDes";
            this.txtTextDes.ReadOnly = true;
            this.txtTextDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextDes.Size = new System.Drawing.Size(224, 117);
            this.txtTextDes.TabIndex = 30;
            // 
            // txtTextretail
            // 
            this.txtTextretail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.txtTextretail.Font = new System.Drawing.Font("Candara", 12F);
            this.txtTextretail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txtTextretail.Location = new System.Drawing.Point(129, 244);
            this.txtTextretail.Name = "txtTextretail";
            this.txtTextretail.ReadOnly = true;
            this.txtTextretail.Size = new System.Drawing.Size(224, 27);
            this.txtTextretail.TabIndex = 29;
            // 
            // txtTextSku
            // 
            this.txtTextSku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.txtTextSku.Font = new System.Drawing.Font("Candara", 12F);
            this.txtTextSku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txtTextSku.Location = new System.Drawing.Point(129, 60);
            this.txtTextSku.Name = "txtTextSku";
            this.txtTextSku.ReadOnly = true;
            this.txtTextSku.Size = new System.Drawing.Size(224, 27);
            this.txtTextSku.TabIndex = 28;
            // 
            // txtTextVendor
            // 
            this.txtTextVendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.txtTextVendor.Font = new System.Drawing.Font("Candara", 12F);
            this.txtTextVendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txtTextVendor.Location = new System.Drawing.Point(129, 152);
            this.txtTextVendor.Name = "txtTextVendor";
            this.txtTextVendor.ReadOnly = true;
            this.txtTextVendor.Size = new System.Drawing.Size(224, 27);
            this.txtTextVendor.TabIndex = 27;
            // 
            // txtTextName
            // 
            this.txtTextName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.txtTextName.Font = new System.Drawing.Font("Candara", 12F);
            this.txtTextName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txtTextName.Location = new System.Drawing.Point(129, 14);
            this.txtTextName.Name = "txtTextName";
            this.txtTextName.ReadOnly = true;
            this.txtTextName.Size = new System.Drawing.Size(224, 27);
            this.txtTextName.TabIndex = 26;
            this.txtTextName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTextOnHands
            // 
            this.txtTextOnHands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.txtTextOnHands.Font = new System.Drawing.Font("Candara", 12F);
            this.txtTextOnHands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txtTextOnHands.Location = new System.Drawing.Point(129, 198);
            this.txtTextOnHands.Name = "txtTextOnHands";
            this.txtTextOnHands.Size = new System.Drawing.Size(224, 27);
            this.txtTextOnHands.TabIndex = 25;
            // 
            // txtTextItemSize
            // 
            this.txtTextItemSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.txtTextItemSize.Font = new System.Drawing.Font("Candara", 12F);
            this.txtTextItemSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txtTextItemSize.Location = new System.Drawing.Point(129, 106);
            this.txtTextItemSize.Name = "txtTextItemSize";
            this.txtTextItemSize.ReadOnly = true;
            this.txtTextItemSize.Size = new System.Drawing.Size(224, 27);
            this.txtTextItemSize.TabIndex = 24;
            // 
            // lbldesdisplay
            // 
            this.lbldesdisplay.AutoSize = true;
            this.lbldesdisplay.Font = new System.Drawing.Font("Candara", 12F);
            this.lbldesdisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.lbldesdisplay.Location = new System.Drawing.Point(112, 312);
            this.lbldesdisplay.Name = "lbldesdisplay";
            this.lbldesdisplay.Size = new System.Drawing.Size(0, 19);
            this.lbldesdisplay.TabIndex = 16;
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRetailPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.lblRetailPrice.Location = new System.Drawing.Point(16, 247);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(85, 19);
            this.lblRetailPrice.TabIndex = 15;
            this.lblRetailPrice.Text = "RetailPrice:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Candara", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.lblDescription.Location = new System.Drawing.Point(16, 293);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 19);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // lblOnHands
            // 
            this.lblOnHands.AutoSize = true;
            this.lblOnHands.Font = new System.Drawing.Font("Candara", 12F);
            this.lblOnHands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.lblOnHands.Location = new System.Drawing.Point(16, 201);
            this.lblOnHands.Name = "lblOnHands";
            this.lblOnHands.Size = new System.Drawing.Size(79, 19);
            this.lblOnHands.TabIndex = 13;
            this.lblOnHands.Text = "Hand Ons:";
            // 
            // lblCloseProgram
            // 
            this.lblCloseProgram.AutoSize = true;
            this.lblCloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCloseProgram.Font = new System.Drawing.Font("Candara", 18F);
            this.lblCloseProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.lblCloseProgram.Location = new System.Drawing.Point(377, 7);
            this.lblCloseProgram.Name = "lblCloseProgram";
            this.lblCloseProgram.Size = new System.Drawing.Size(26, 29);
            this.lblCloseProgram.TabIndex = 5;
            this.lblCloseProgram.Text = "X";
            this.lblCloseProgram.Click += new System.EventHandler(this.lblCloseProgram_Click);
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Candara", 12F);
            this.lblVendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.lblVendor.Location = new System.Drawing.Point(16, 155);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(63, 19);
            this.lblVendor.TabIndex = 12;
            this.lblVendor.Text = "Vendor:";
            // 
            // lblItemSize
            // 
            this.lblItemSize.AutoSize = true;
            this.lblItemSize.Font = new System.Drawing.Font("Candara", 12F);
            this.lblItemSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.lblItemSize.Location = new System.Drawing.Point(16, 109);
            this.lblItemSize.Name = "lblItemSize";
            this.lblItemSize.Size = new System.Drawing.Size(73, 19);
            this.lblItemSize.TabIndex = 11;
            this.lblItemSize.Text = "Item Size:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Candara", 12F);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.lbl.Location = new System.Drawing.Point(16, 63);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(38, 19);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Sku:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Candara", 12F);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.lblItemName.Location = new System.Drawing.Point(16, 17);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(87, 19);
            this.lblItemName.TabIndex = 9;
            this.lblItemName.Text = "Item Name:";
            // 
            // editInventory
            // 
            this.editInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.editInventory.Location = new System.Drawing.Point(20, 421);
            this.editInventory.Margin = new System.Windows.Forms.Padding(2);
            this.editInventory.Name = "editInventory";
            this.editInventory.Size = new System.Drawing.Size(363, 27);
            this.editInventory.TabIndex = 3;
            this.editInventory.Text = "Edit Inventory";
            this.editInventory.UseVisualStyleBackColor = true;
            this.editInventory.Click += new System.EventHandler(this.editInventory_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(28, 428);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(451, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.seniorDesignNewSIPDataSet2;
            // 
            // seniorDesignNewSIPDataSet2
            // 
            this.seniorDesignNewSIPDataSet2.DataSetName = "SeniorDesignNewSIPDataSet2";
            this.seniorDesignNewSIPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seniorDesignNewSIPDataSet
            // 
            this.seniorDesignNewSIPDataSet.DataSetName = "SeniorDesignNewSIPDataSet";
            this.seniorDesignNewSIPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seniorDesignNewSIPDataSetBindingSource
            // 
            this.seniorDesignNewSIPDataSetBindingSource.DataSource = this.seniorDesignNewSIPDataSet;
            this.seniorDesignNewSIPDataSetBindingSource.Position = 0;
            // 
            // seniorDesignNewSIPDataSet1
            // 
            this.seniorDesignNewSIPDataSet1.DataSetName = "SeniorDesignNewSIPDataSet1";
            this.seniorDesignNewSIPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seniorDesignNewSIPDataSet1BindingSource
            // 
            this.seniorDesignNewSIPDataSet1BindingSource.DataSource = this.seniorDesignNewSIPDataSet1;
            this.seniorDesignNewSIPDataSet1BindingSource.Position = 0;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // seniorDesignNewSIPDataSet3
            // 
            this.seniorDesignNewSIPDataSet3.DataSetName = "SeniorDesignNewSIPDataSet3";
            this.seniorDesignNewSIPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "items";
            this.itemsBindingSource1.DataSource = this.seniorDesignNewSIPDataSet3;
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // itemsTableAdapter2
            // 
            this.itemsTableAdapter2.ClearBeforeFill = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1134, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDesignNewSIPDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button inventoryToOrders;
        private void inventoryToOrders_Click(object sender, System.EventArgs e)
        {
            OrdersPage ToOrders = new OrdersPage();
            ToOrders.ShowDialog(); // Shows Orders Page
        }
        private System.Windows.Forms.BindingSource seniorDesignNewSIPDataSetBindingSource;
        private SeniorDesignNewSIPDataSet seniorDesignNewSIPDataSet;
        private System.Windows.Forms.BindingSource seniorDesignNewSIPDataSet1BindingSource;
        private SeniorDesignNewSIPDataSet1 seniorDesignNewSIPDataSet1;
        private SeniorDesignNewSIPDataSet2 seniorDesignNewSIPDataSet2;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SeniorDesignNewSIPDataSet2TableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private SeniorDesignNewSIPDataSet3 seniorDesignNewSIPDataSet3;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private SeniorDesignNewSIPDataSet3TableAdapters.itemsTableAdapter itemsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SeniorDesignNewSIPDataSet4 seniorDesignNewSIPDataSet4;
        private System.Windows.Forms.BindingSource itemsBindingSource2;
        private SeniorDesignNewSIPDataSet4TableAdapters.itemsTableAdapter itemsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTextSku;
        private System.Windows.Forms.TextBox txtTextVendor;
        private System.Windows.Forms.TextBox txtTextName;
        private System.Windows.Forms.TextBox txtTextOnHands;
        private System.Windows.Forms.TextBox txtTextItemSize;
        private System.Windows.Forms.Label lbldesdisplay;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOnHands;
        private System.Windows.Forms.Label lblCloseProgram;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblItemSize;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button editInventory;
        private System.Windows.Forms.TextBox txtTextDes;
        private System.Windows.Forms.TextBox txtTextretail;
        private System.Diagnostics.Process process1;
    }
}