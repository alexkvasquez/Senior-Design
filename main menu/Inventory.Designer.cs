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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OnHands = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.editInventory = new System.Windows.Forms.Button();
            this.inventoryToOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Candara", 16F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.textBox1.Location = new System.Drawing.Point(0, 254);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 471);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.editInventory);
            this.panel2.Controls.Add(this.inventoryToOrders);
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 471);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.OnHands,
            this.Items});
            this.listView1.Font = new System.Drawing.Font("Candara", 10F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(65, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 234);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Type
            // 
            this.Type.DisplayIndex = 1;
            this.Type.Text = "Package Type";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 160;
            // 
            // OnHands
            // 
            this.OnHands.DisplayIndex = 2;
            this.OnHands.Text = "On Hands";
            this.OnHands.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OnHands.Width = 166;
            // 
            // Items
            // 
            this.Items.DisplayIndex = 0;
            this.Items.Text = "Item Name";
            this.Items.Width = 157;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 348);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(454, 20);
            this.textBox3.TabIndex = 4;
            // 
            // editInventory
            // 
            this.editInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.editInventory.Location = new System.Drawing.Point(65, 413);
            this.editInventory.Margin = new System.Windows.Forms.Padding(2);
            this.editInventory.Name = "editInventory";
            this.editInventory.Size = new System.Drawing.Size(176, 39);
            this.editInventory.TabIndex = 3;
            this.editInventory.Text = "Edit Inventory";
            this.editInventory.UseVisualStyleBackColor = true;
            // 
            // inventoryToOrders
            // 
            this.inventoryToOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.inventoryToOrders.Location = new System.Drawing.Point(344, 413);
            this.inventoryToOrders.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryToOrders.Name = "inventoryToOrders";
            this.inventoryToOrders.Size = new System.Drawing.Size(176, 39);
            this.inventoryToOrders.TabIndex = 1;
            this.inventoryToOrders.Text = "Go To Orders";
            this.inventoryToOrders.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(801, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inventory";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button inventoryToOrders;
        private System.Windows.Forms.Button editInventory;
        private void inventoryToOrders_Click(object sender, System.EventArgs e)
        {
            OrdersPage ToOrders = new OrdersPage();
            ToOrders.ShowDialog(); // Shows Orders Page
        }

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader OnHands;
        private System.Windows.Forms.ColumnHeader Items;
    }
}