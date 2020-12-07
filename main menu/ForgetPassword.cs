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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        

        private void labelGreeting_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelGreeting_Click_1(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }
        
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "" || txtUsername.Text == "" || txtConfirmPassword.Text == "" || txtEmployeeID.Text == "")
                MessageBox.Show("Please fill out all the fields");
            else if (txtConfirmPassword.Text != txtNewPassword.Text)
                MessageBox.Show("Passwords do not match");
            else
            {
                string hash = hashing(txtNewPassword.Text);
                try
                {
                    MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE Users SET password = '" + hash + "' WHERE idUsers = '" + txtEmployeeID.Text + "' AND userName = '" + txtUsername.Text + "'", cnn);
                    int ret = cmd.ExecuteNonQuery();

                    //Used the commented out command below to test and see the return value of the rows affected by the SQL Query
                    //Console.WriteLine(ret);

                    if (ret == 0)
                        MessageBox.Show("Employee Id and Username do not match");
                    else if (ret == 1)
                    {
                        MessageBox.Show("Password Reset Successful");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful password change");
                    }

                    cnn.Close();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }
        
        void Clear()
        {
            txtConfirmPassword.Text = txtEmployeeID.Text = txtNewPassword.Text = txtUsername.Text = "";

        }

        private string hashing(String str)
        {
            string hash;

            MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT sha2('" + txtNewPassword.Text + "',512)", cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                hash = reader.GetValue(0).ToString();
                cnn.Close();
                return hash;

            }
            else
            {
                cnn.Close();
                return null;
            }

        }

    }
}
