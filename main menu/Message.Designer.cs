namespace main_menu
{
    partial class Message
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HomeIconPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.HomeIconPic);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Controls.Add(this.lblWelcomeUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 569);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 437);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 380;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Subject";
            this.columnHeader1.Width = 183;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 177;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btnRefresh.Location = new System.Drawing.Point(596, 505);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 29);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.button1.Location = new System.Drawing.Point(308, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Decline";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btnApprove.Location = new System.Drawing.Point(17, 505);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(133, 29);
            this.btnApprove.TabIndex = 9;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Candara", 18F);
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.lblWelcomeUser.Location = new System.Drawing.Point(12, 9);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(175, 29);
            this.lblWelcomeUser.TabIndex = 1;
            this.lblWelcomeUser.Text = "Message Center";
            this.lblWelcomeUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeIconPic
            // 
            this.HomeIconPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.HomeIconPic.Image = global::main_menu.Properties.Resources.Home_Icon;
            this.HomeIconPic.Location = new System.Drawing.Point(705, 12);
            this.HomeIconPic.Name = "HomeIconPic";
            this.HomeIconPic.Size = new System.Drawing.Size(29, 29);
            this.HomeIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeIconPic.TabIndex = 20;
            this.HomeIconPic.TabStop = false;
            this.HomeIconPic.Click += new System.EventHandler(this.HomeIconPic_Click);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 569);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIconPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox HomeIconPic;
    }
}