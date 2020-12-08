namespace main_menu
{
    partial class Staff
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeOff = new System.Windows.Forms.Button();
            this.viewSchedule = new System.Windows.Forms.Button();
            this.clockOut = new System.Windows.Forms.Button();
            this.ClockIn = new System.Windows.Forms.Button();
            this.HomeIconPic = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIconPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblStaff);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 600);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::main_menu.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(44, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Candara", 18F);
            this.lblStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.lblStaff.Location = new System.Drawing.Point(81, 33);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(61, 29);
            this.lblStaff.TabIndex = 16;
            this.lblStaff.Text = "Staff";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.timeOff);
            this.panel2.Controls.Add(this.viewSchedule);
            this.panel2.Controls.Add(this.clockOut);
            this.panel2.Controls.Add(this.ClockIn);
            this.panel2.Location = new System.Drawing.Point(11, 246);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 324);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // timeOff
            // 
            this.timeOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.timeOff.Location = new System.Drawing.Point(13, 169);
            this.timeOff.Margin = new System.Windows.Forms.Padding(2);
            this.timeOff.Name = "timeOff";
            this.timeOff.Size = new System.Drawing.Size(176, 39);
            this.timeOff.TabIndex = 7;
            this.timeOff.Text = "Request Time Off";
            this.timeOff.UseVisualStyleBackColor = true;
            // 
            // viewSchedule
            // 
            this.viewSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.viewSchedule.Location = new System.Drawing.Point(13, 93);
            this.viewSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.viewSchedule.Name = "viewSchedule";
            this.viewSchedule.Size = new System.Drawing.Size(176, 39);
            this.viewSchedule.TabIndex = 6;
            this.viewSchedule.Text = "View Weekly Schedule";
            this.viewSchedule.UseVisualStyleBackColor = true;
            this.viewSchedule.Click += new System.EventHandler(this.viewSchedule_Click);
            // 
            // clockOut
            // 
            this.clockOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.clockOut.Location = new System.Drawing.Point(13, 248);
            this.clockOut.Margin = new System.Windows.Forms.Padding(2);
            this.clockOut.Name = "clockOut";
            this.clockOut.Size = new System.Drawing.Size(176, 39);
            this.clockOut.TabIndex = 5;
            this.clockOut.Text = "Clock Out";
            this.clockOut.UseVisualStyleBackColor = true;
            this.clockOut.Click += new System.EventHandler(this.clockOut_Click);
            // 
            // ClockIn
            // 
            this.ClockIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClockIn.Location = new System.Drawing.Point(13, 28);
            this.ClockIn.Margin = new System.Windows.Forms.Padding(2);
            this.ClockIn.Name = "ClockIn";
            this.ClockIn.Size = new System.Drawing.Size(176, 30);
            this.ClockIn.TabIndex = 4;
            this.ClockIn.Text = "Clock In";
            this.ClockIn.UseVisualStyleBackColor = true;
            this.ClockIn.Click += new System.EventHandler(this.ClockIn_Click);
            // 
            // HomeIconPic
            // 
            this.HomeIconPic.Image = global::main_menu.Properties.Resources.Home_Icon;
            this.HomeIconPic.Location = new System.Drawing.Point(857, 12);
            this.HomeIconPic.Name = "HomeIconPic";
            this.HomeIconPic.Size = new System.Drawing.Size(29, 29);
            this.HomeIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeIconPic.TabIndex = 18;
            this.HomeIconPic.TabStop = false;
            this.HomeIconPic.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(526, 74);
            this.dataGridView1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(503, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Time Clock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(898, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HomeIconPic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Staff";
            this.Text = "Staff Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeIconPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button timeOff;
        private System.Windows.Forms.Button viewSchedule;
        private System.Windows.Forms.Button clockOut;
        private System.Windows.Forms.Button ClockIn;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox HomeIconPic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}