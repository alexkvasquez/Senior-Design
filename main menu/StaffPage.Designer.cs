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
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeOff = new System.Windows.Forms.Button();
            this.viewSchedule = new System.Windows.Forms.Button();
            this.clockOut = new System.Windows.Forms.Button();
            this.ClockIn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 573);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.timeOff);
            this.panel2.Controls.Add(this.viewSchedule);
            this.panel2.Controls.Add(this.clockOut);
            this.panel2.Controls.Add(this.ClockIn);
            this.panel2.Location = new System.Drawing.Point(18, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 399);
            this.panel2.TabIndex = 8;
            // 
            // timeOff
            // 
            this.timeOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.timeOff.Location = new System.Drawing.Point(17, 208);
            this.timeOff.Name = "timeOff";
            this.timeOff.Size = new System.Drawing.Size(235, 48);
            this.timeOff.TabIndex = 7;
            this.timeOff.Text = "Request Time Off";
            this.timeOff.UseVisualStyleBackColor = true;
            // 
            // viewSchedule
            // 
            this.viewSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.viewSchedule.Location = new System.Drawing.Point(17, 115);
            this.viewSchedule.Name = "viewSchedule";
            this.viewSchedule.Size = new System.Drawing.Size(235, 48);
            this.viewSchedule.TabIndex = 6;
            this.viewSchedule.Text = "View Weekly Schedule";
            this.viewSchedule.UseVisualStyleBackColor = true;
            // 
            // clockOut
            // 
            this.clockOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.clockOut.Location = new System.Drawing.Point(17, 305);
            this.clockOut.Name = "clockOut";
            this.clockOut.Size = new System.Drawing.Size(235, 48);
            this.clockOut.TabIndex = 5;
            this.clockOut.Text = "Clock Out";
            this.clockOut.UseVisualStyleBackColor = true;
            // 
            // ClockIn
            // 
            this.ClockIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClockIn.Location = new System.Drawing.Point(17, 34);
            this.ClockIn.Name = "ClockIn";
            this.ClockIn.Size = new System.Drawing.Size(235, 37);
            this.ClockIn.TabIndex = 4;
            this.ClockIn.Text = "Clock In";
            this.ClockIn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBox2.Location = new System.Drawing.Point(113, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 46);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Staff";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(177)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1065, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button timeOff;
        private System.Windows.Forms.Button viewSchedule;
        private System.Windows.Forms.Button clockOut;
        private System.Windows.Forms.Button ClockIn;
    }
}