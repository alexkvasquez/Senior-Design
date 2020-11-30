namespace main_menu
{
    partial class Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblEditPhone = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HomeIconPic = new System.Windows.Forms.PictureBox();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.lblAddPhone = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.txtCustomerID);
            this.panel1.Controls.Add(this.lblCustomerID);
            this.panel1.Controls.Add(this.lblEditPhone);
            this.panel1.Controls.Add(this.lblEditName);
            this.panel1.Controls.Add(this.txtEditPhone);
            this.panel1.Controls.Add(this.txtEditName);
            this.panel1.Controls.Add(this.btnUpdateCustomer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAddCust);
            this.panel1.Controls.Add(this.lblAddPhone);
            this.panel1.Controls.Add(this.lblAddName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAddPhone);
            this.panel1.Controls.Add(this.txtAddName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 560);
            this.panel1.TabIndex = 0;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.White;
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Location = new System.Drawing.Point(17, 331);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(191, 20);
            this.txtCustomerID.TabIndex = 28;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblCustomerID.Location = new System.Drawing.Point(13, 309);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(93, 19);
            this.lblCustomerID.TabIndex = 27;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblEditPhone
            // 
            this.lblEditPhone.AutoSize = true;
            this.lblEditPhone.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEditPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblEditPhone.Location = new System.Drawing.Point(13, 425);
            this.lblEditPhone.Name = "lblEditPhone";
            this.lblEditPhone.Size = new System.Drawing.Size(112, 19);
            this.lblEditPhone.TabIndex = 26;
            this.lblEditPhone.Text = "Phone Number";
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEditName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblEditName.Location = new System.Drawing.Point(13, 367);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(49, 19);
            this.lblEditName.TabIndex = 25;
            this.lblEditName.Text = "Name";
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.BackColor = System.Drawing.Color.White;
            this.txtEditPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditPhone.Location = new System.Drawing.Point(17, 447);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(191, 20);
            this.txtEditPhone.TabIndex = 24;
            // 
            // txtEditName
            // 
            this.txtEditName.BackColor = System.Drawing.Color.White;
            this.txtEditName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditName.Location = new System.Drawing.Point(17, 389);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(191, 20);
            this.txtEditName.TabIndex = 23;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(17, 496);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(85, 23);
            this.btnUpdateCustomer.TabIndex = 22;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 18F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label4.Location = new System.Drawing.Point(12, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Edit Customer Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.txtCustomerSearch);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.HomeIconPic);
            this.panel2.Controls.Add(this.lblCustomerTitle);
            this.panel2.Location = new System.Drawing.Point(278, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 560);
            this.panel2.TabIndex = 20;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.txtCustomerSearch.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txtCustomerSearch.Location = new System.Drawing.Point(36, 463);
            this.txtCustomerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(358, 21);
            this.txtCustomerSearch.TabIndex = 21;
            this.txtCustomerSearch.Text = "Enter Customer Name Here";
            this.txtCustomerSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(358, 290);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // HomeIconPic
            // 
            this.HomeIconPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.HomeIconPic.Image = global::main_menu.Properties.Resources.Home_Icon;
            this.HomeIconPic.Location = new System.Drawing.Point(381, 12);
            this.HomeIconPic.Name = "HomeIconPic";
            this.HomeIconPic.Size = new System.Drawing.Size(29, 29);
            this.HomeIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeIconPic.TabIndex = 19;
            this.HomeIconPic.TabStop = false;
            this.HomeIconPic.Click += new System.EventHandler(this.HomeIconPic_Click);
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Candara", 18F);
            this.lblCustomerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.lblCustomerTitle.Location = new System.Drawing.Point(107, 88);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(229, 29);
            this.lblCustomerTitle.TabIndex = 1;
            this.lblCustomerTitle.Text = "Cutomer Information";
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(17, 188);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(85, 23);
            this.btnAddCust.TabIndex = 9;
            this.btnAddCust.Text = "Enter";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // lblAddPhone
            // 
            this.lblAddPhone.AutoSize = true;
            this.lblAddPhone.Font = new System.Drawing.Font("Candara", 12F);
            this.lblAddPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblAddPhone.Location = new System.Drawing.Point(13, 116);
            this.lblAddPhone.Name = "lblAddPhone";
            this.lblAddPhone.Size = new System.Drawing.Size(112, 19);
            this.lblAddPhone.TabIndex = 8;
            this.lblAddPhone.Text = "Phone Number";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Font = new System.Drawing.Font("Candara", 12F);
            this.lblAddName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblAddName.Location = new System.Drawing.Point(13, 55);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(49, 19);
            this.lblAddName.TabIndex = 7;
            this.lblAddName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Customer";
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.BackColor = System.Drawing.Color.White;
            this.txtAddPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddPhone.Location = new System.Drawing.Point(17, 138);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(191, 20);
            this.txtAddPhone.TabIndex = 5;
            // 
            // txtAddName
            // 
            this.txtAddName.BackColor = System.Drawing.Color.White;
            this.txtAddName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddName.Location = new System.Drawing.Point(17, 77);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(191, 20);
            this.txtAddName.TabIndex = 3;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(123, 496);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(85, 23);
            this.btnDeleteCustomer.TabIndex = 29;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 559);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIconPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Label lblAddPhone;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.PictureBox HomeIconPic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Label lblEditPhone;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnDeleteCustomer;
    }
}