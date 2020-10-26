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
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtLookupName = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnAddCust);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAddPhone);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtAddName);
            this.panel1.Controls.Add(this.txtLookupName);
            this.panel1.Controls.Add(this.lblCustomerTitle);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 560);
            this.panel1.TabIndex = 0;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Candara", 18F);
            this.lblCustomerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.lblCustomerTitle.Location = new System.Drawing.Point(12, 9);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(193, 29);
            this.lblCustomerTitle.TabIndex = 1;
            this.lblCustomerTitle.Text = "Customer Lookup";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("Candara", 18F);
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(359, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 560);
            this.listBox1.TabIndex = 0;
            // 
            // txtLookupName
            // 
            this.txtLookupName.BackColor = System.Drawing.Color.White;
            this.txtLookupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLookupName.Location = new System.Drawing.Point(17, 73);
            this.txtLookupName.Name = "txtLookupName";
            this.txtLookupName.Size = new System.Drawing.Size(191, 20);
            this.txtLookupName.TabIndex = 2;
            this.txtLookupName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAddName
            // 
            this.txtAddName.BackColor = System.Drawing.Color.White;
            this.txtAddName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddName.Location = new System.Drawing.Point(17, 291);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(191, 20);
            this.txtAddName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.BackColor = System.Drawing.Color.White;
            this.txtAddPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddPhone.Location = new System.Drawing.Point(17, 352);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(191, 20);
            this.txtAddPhone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label2.Location = new System.Drawing.Point(13, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.label3.Location = new System.Drawing.Point(13, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(17, 402);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(85, 23);
            this.btnAddCust.TabIndex = 9;
            this.btnAddCust.Text = "Enter";
            this.btnAddCust.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.TextBox txtLookupName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddPhone;
    }
}