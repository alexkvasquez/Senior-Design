namespace main_menu
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.OrdersIconPic = new System.Windows.Forms.PictureBox();
            this.StaffIconPic = new System.Windows.Forms.PictureBox();
            this.CustomersIconPic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMessages = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblCloseProgram = new System.Windows.Forms.Label();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersIconPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffIconPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersIconPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.sideMenu.Controls.Add(this.lblLogout);
            this.sideMenu.Controls.Add(this.OrdersIconPic);
            this.sideMenu.Controls.Add(this.StaffIconPic);
            this.sideMenu.Controls.Add(this.CustomersIconPic);
            this.sideMenu.Controls.Add(this.pictureBox2);
            this.sideMenu.Controls.Add(this.lblCustomers);
            this.sideMenu.Controls.Add(this.pictureBox1);
            this.sideMenu.Controls.Add(this.lblMessages);
            this.sideMenu.Controls.Add(this.button1);
            this.sideMenu.Controls.Add(this.lblStaff);
            this.sideMenu.Controls.Add(this.lblOrders);
            this.sideMenu.Controls.Add(this.lblInventory);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(193, 759);
            this.sideMenu.TabIndex = 0;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.lblLogout.Font = new System.Drawing.Font("Candara", 18F);
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.lblLogout.Location = new System.Drawing.Point(51, 9);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(86, 29);
            this.lblLogout.TabIndex = 14;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLogout.Click += new System.EventHandler(this.label8_Click);
            // 
            // OrdersIconPic
            // 
            this.OrdersIconPic.Image = global::main_menu.Properties.Resources.orders_icon;
            this.OrdersIconPic.Location = new System.Drawing.Point(16, 149);
            this.OrdersIconPic.Name = "OrdersIconPic";
            this.OrdersIconPic.Size = new System.Drawing.Size(29, 29);
            this.OrdersIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OrdersIconPic.TabIndex = 13;
            this.OrdersIconPic.TabStop = false;
            this.OrdersIconPic.Click += new System.EventHandler(this.OrdersIconPic_Click);
            // 
            // StaffIconPic
            // 
            this.StaffIconPic.Image = global::main_menu.Properties.Resources.staff_icon;
            this.StaffIconPic.Location = new System.Drawing.Point(16, 217);
            this.StaffIconPic.Name = "StaffIconPic";
            this.StaffIconPic.Size = new System.Drawing.Size(29, 29);
            this.StaffIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StaffIconPic.TabIndex = 12;
            this.StaffIconPic.TabStop = false;
            this.StaffIconPic.Click += new System.EventHandler(this.StaffIconPic_Click);
            // 
            // CustomersIconPic
            // 
            this.CustomersIconPic.Image = global::main_menu.Properties.Resources.personSilo1;
            this.CustomersIconPic.Location = new System.Drawing.Point(16, 285);
            this.CustomersIconPic.Name = "CustomersIconPic";
            this.CustomersIconPic.Size = new System.Drawing.Size(29, 29);
            this.CustomersIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CustomersIconPic.TabIndex = 11;
            this.CustomersIconPic.TabStop = false;
            this.CustomersIconPic.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::main_menu.Properties.Resources.mailSilo;
            this.pictureBox2.Location = new System.Drawing.Point(16, 356);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Candara", 18F);
            this.lblCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblCustomers.Location = new System.Drawing.Point(51, 285);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(122, 29);
            this.lblCustomers.TabIndex = 7;
            this.lblCustomers.Text = "Customers";
            this.lblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustomers.Click += new System.EventHandler(this.lblCustomers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Font = new System.Drawing.Font("Candara", 18F);
            this.lblMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblMessages.Location = new System.Drawing.Point(51, 356);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(112, 29);
            this.lblMessages.TabIndex = 9;
            this.lblMessages.Text = "Messages";
            this.lblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessages.Click += new System.EventHandler(this.lblMessages_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Candara", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.button1.Location = new System.Drawing.Point(12, 693);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start POS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Candara", 18F);
            this.lblStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblStaff.Location = new System.Drawing.Point(51, 217);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(61, 29);
            this.lblStaff.TabIndex = 6;
            this.lblStaff.Text = "Staff";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStaff.Click += new System.EventHandler(this.lblStaff_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Candara", 18F);
            this.lblOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblOrders.Location = new System.Drawing.Point(51, 149);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(83, 29);
            this.lblOrders.TabIndex = 5;
            this.lblOrders.Text = "Orders";
            this.lblOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrders.Click += new System.EventHandler(this.lblOrders_Click);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Candara", 18F);
            this.lblInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblInventory.Location = new System.Drawing.Point(51, 78);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(112, 29);
            this.lblInventory.TabIndex = 1;
            this.lblInventory.Text = "Inventory";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInventory.Click += new System.EventHandler(this.lblInventory_Click);
            // 
            // lblCloseProgram
            // 
            this.lblCloseProgram.AutoSize = true;
            this.lblCloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCloseProgram.Font = new System.Drawing.Font("Candara", 18F);
            this.lblCloseProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.lblCloseProgram.Location = new System.Drawing.Point(968, 9);
            this.lblCloseProgram.Name = "lblCloseProgram";
            this.lblCloseProgram.Size = new System.Drawing.Size(26, 29);
            this.lblCloseProgram.TabIndex = 4;
            this.lblCloseProgram.Text = "X";
            this.lblCloseProgram.Click += new System.EventHandler(this.lblCloseProgram_Click);
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Candara", 18F);
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.lblWelcomeUser.Location = new System.Drawing.Point(3, 9);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(172, 29);
            this.lblWelcomeUser.TabIndex = 0;
            this.lblWelcomeUser.Text = "Welcome Name";
            this.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblWelcomeUser);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.lblCloseProgram);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(193, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 759);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(752, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 99);
            this.panel5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Candara", 18F);
            this.label6.Location = new System.Drawing.Point(0, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "what the item is";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Candara", 18F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hot Items";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(499, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 99);
            this.panel4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Candara", 18F);
            this.label4.Location = new System.Drawing.Point(0, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "#";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Candara", 18F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Items Sold";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(253, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 99);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Candara", 18F);
            this.label2.Location = new System.Drawing.Point(0, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Candara", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sales Goal Weekly";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblTotalSales);
            this.panel3.Location = new System.Drawing.Point(25, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 99);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Candara", 18F);
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Font = new System.Drawing.Font("Candara", 18F);
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblTotalSales.Location = new System.Drawing.Point(3, 9);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(197, 29);
            this.lblTotalSales.TabIndex = 10;
            this.lblTotalSales.Text = "Today Sales";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 486);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1006, 273);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.sideMenu.ResumeLayout(false);
            this.sideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersIconPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffIconPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersIconPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblCloseProgram;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox CustomersIconPic;
        private System.Windows.Forms.PictureBox StaffIconPic;
        private System.Windows.Forms.PictureBox OrdersIconPic;
        private System.Windows.Forms.Label lblLogout;
    }
}