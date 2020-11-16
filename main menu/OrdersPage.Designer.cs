namespace main_menu
{
    partial class OrdersPage
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
            this.ordersToInventory = new System.Windows.Forms.Button();
            this.editInventory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeIconPic = new System.Windows.Forms.PictureBox();
            this.orderItem7 = new System.Windows.Forms.Button();
            this.orderItem3 = new System.Windows.Forms.Button();
            this.orderItem6 = new System.Windows.Forms.Button();
            this.orderItem1 = new System.Windows.Forms.Button();
            this.orderItem5 = new System.Windows.Forms.Button();
            this.orderItem2 = new System.Windows.Forms.Button();
            this.orderItem4 = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.lblOrders);
            this.panel1.Controls.Add(this.ordersToInventory);
            this.panel1.Controls.Add(this.editInventory);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 470);
            this.panel1.TabIndex = 0;
            // 
            // ordersToInventory
            // 
            this.ordersToInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ordersToInventory.Location = new System.Drawing.Point(11, 420);
            this.ordersToInventory.Margin = new System.Windows.Forms.Padding(2);
            this.ordersToInventory.Name = "ordersToInventory";
            this.ordersToInventory.Size = new System.Drawing.Size(164, 39);
            this.ordersToInventory.TabIndex = 13;
            this.ordersToInventory.Text = "View Inventory";
            this.ordersToInventory.UseVisualStyleBackColor = true;
            this.ordersToInventory.Click += new System.EventHandler(this.ordersToInventory_Click_1);
            // 
            // editInventory
            // 
            this.editInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.editInventory.Location = new System.Drawing.Point(11, 377);
            this.editInventory.Margin = new System.Windows.Forms.Padding(2);
            this.editInventory.Name = "editInventory";
            this.editInventory.Size = new System.Drawing.Size(164, 39);
            this.editInventory.TabIndex = 12;
            this.editInventory.Text = "View In-Place Orders";
            this.editInventory.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::main_menu.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.HomeIconPic);
            this.panel2.Controls.Add(this.orderItem7);
            this.panel2.Controls.Add(this.orderItem3);
            this.panel2.Controls.Add(this.orderItem6);
            this.panel2.Controls.Add(this.orderItem1);
            this.panel2.Controls.Add(this.orderItem5);
            this.panel2.Controls.Add(this.orderItem2);
            this.panel2.Controls.Add(this.orderItem4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(679, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 470);
            this.panel2.TabIndex = 4;
            // 
            // HomeIconPic
            // 
            this.HomeIconPic.Image = global::main_menu.Properties.Resources.Home_Icon;
            this.HomeIconPic.Location = new System.Drawing.Point(70, 12);
            this.HomeIconPic.Name = "HomeIconPic";
            this.HomeIconPic.Size = new System.Drawing.Size(29, 29);
            this.HomeIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeIconPic.TabIndex = 18;
            this.HomeIconPic.TabStop = false;
            this.HomeIconPic.Click += new System.EventHandler(this.HomeIconPic_Click);
            // 
            // orderItem7
            // 
            this.orderItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.orderItem7.Location = new System.Drawing.Point(4, 312);
            this.orderItem7.Margin = new System.Windows.Forms.Padding(2);
            this.orderItem7.Name = "orderItem7";
            this.orderItem7.Size = new System.Drawing.Size(100, 26);
            this.orderItem7.TabIndex = 17;
            this.orderItem7.Text = "Order Item";
            this.orderItem7.UseVisualStyleBackColor = true;
            // 
            // orderItem3
            // 
            this.orderItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.orderItem3.Location = new System.Drawing.Point(4, 205);
            this.orderItem3.Margin = new System.Windows.Forms.Padding(2);
            this.orderItem3.Name = "orderItem3";
            this.orderItem3.Size = new System.Drawing.Size(100, 26);
            this.orderItem3.TabIndex = 13;
            this.orderItem3.Text = "Order Item";
            this.orderItem3.UseVisualStyleBackColor = true;
            // 
            // orderItem6
            // 
            this.orderItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.orderItem6.Location = new System.Drawing.Point(4, 285);
            this.orderItem6.Margin = new System.Windows.Forms.Padding(2);
            this.orderItem6.Name = "orderItem6";
            this.orderItem6.Size = new System.Drawing.Size(100, 26);
            this.orderItem6.TabIndex = 16;
            this.orderItem6.Text = "Order Item";
            this.orderItem6.UseVisualStyleBackColor = true;
            // 
            // orderItem1
            // 
            this.orderItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.orderItem1.Location = new System.Drawing.Point(4, 150);
            this.orderItem1.Margin = new System.Windows.Forms.Padding(2);
            this.orderItem1.Name = "orderItem1";
            this.orderItem1.Size = new System.Drawing.Size(100, 26);
            this.orderItem1.TabIndex = 11;
            this.orderItem1.Text = "Order Item";
            this.orderItem1.UseVisualStyleBackColor = true;
            // 
            // orderItem5
            // 
            this.orderItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.orderItem5.Location = new System.Drawing.Point(4, 258);
            this.orderItem5.Margin = new System.Windows.Forms.Padding(2);
            this.orderItem5.Name = "orderItem5";
            this.orderItem5.Size = new System.Drawing.Size(100, 26);
            this.orderItem5.TabIndex = 15;
            this.orderItem5.Text = "Order Item";
            this.orderItem5.UseVisualStyleBackColor = true;
            // 
            // orderItem2
            // 
            this.orderItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.orderItem2.Location = new System.Drawing.Point(4, 177);
            this.orderItem2.Margin = new System.Windows.Forms.Padding(2);
            this.orderItem2.Name = "orderItem2";
            this.orderItem2.Size = new System.Drawing.Size(100, 26);
            this.orderItem2.TabIndex = 12;
            this.orderItem2.Text = "Order Item";
            this.orderItem2.UseVisualStyleBackColor = true;
            // 
            // orderItem4
            // 
            this.orderItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.orderItem4.Location = new System.Drawing.Point(4, 232);
            this.orderItem4.Margin = new System.Windows.Forms.Padding(2);
            this.orderItem4.Name = "orderItem4";
            this.orderItem4.Size = new System.Drawing.Size(100, 26);
            this.orderItem4.TabIndex = 14;
            this.orderItem4.Text = "Order Item";
            this.orderItem4.UseVisualStyleBackColor = true;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Candara", 18F);
            this.lblOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.lblOrders.Location = new System.Drawing.Point(51, 87);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(83, 29);
            this.lblOrders.TabIndex = 14;
            this.lblOrders.Text = "Orders";
            this.lblOrders.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrdersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(790, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdersPage";
            this.Text = "OrdersPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeIconPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button orderItem7;
        private System.Windows.Forms.Button orderItem3;
        private System.Windows.Forms.Button orderItem6;
        private System.Windows.Forms.Button orderItem1;
        private System.Windows.Forms.Button orderItem5;
        private System.Windows.Forms.Button orderItem2;
        private System.Windows.Forms.Button orderItem4;
        private System.Windows.Forms.Button ordersToInventory;
        private System.Windows.Forms.Button editInventory;
        private void ordersToInventory_Click(object sender, System.EventArgs e)
        {
            Inventory ToInventory = new Inventory();
            ToInventory.ShowDialog(); // Shows Orders Page
        }

        private System.Windows.Forms.PictureBox HomeIconPic;
        private System.Windows.Forms.Label lblOrders;
    }
}