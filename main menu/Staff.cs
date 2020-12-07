using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace main_menu
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            try
            {
                cnn.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM SeniorDesignNewSIP.EmployeeTimeClock WHERE TimeClockID = '" + globals.TimeClockID + "'", cnn);
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[2].Width = 130;
                dataGridView1.Columns[3].Width = 130;
                cmd2.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard x = new Dashboard();
            x.ShowDialog();
        }

        private void ClockIn_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO EmployeeTimeClock (idUsers, TimeIn) VALUES('" + globals.userid + "', '" + time + "')", cnn);
                MySqlCommand cmd1 = new MySqlCommand("SELECT TimeClockID FROM SeniorDesignNewSIP.EmployeeTimeClock ORDER BY TimeClockID DESC LIMIT 1", cnn);

                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    globals.TimeClockID = dr.GetInt32(0);
                }

                MessageBox.Show("Clock-in Successful");
                cnn.Close();

                cnn.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM SeniorDesignNewSIP.EmployeeTimeClock WHERE TimeClockID = '" + globals.TimeClockID + "'", cnn);
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd2.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clockOut_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE EmployeeTimeClock SET TimeOut = '" + time + "' WHERE TimeClockID ='" + globals.TimeClockID + "'", cnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Clock-out Successful");

                cnn.Close();

                cnn.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM SeniorDesignNewSIP.EmployeeTimeClock WHERE TimeClockID = '" + globals.TimeClockID + "'", cnn);
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd2.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewSchedule_Click(object sender, EventArgs e)
        {

        }
    }
}