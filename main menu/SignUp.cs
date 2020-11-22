using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace main_menu
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to close the program", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "" || txtCompanyCode.Text == "" || txtEnterFullName.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (txtPassword.Text != txtReenterPassword.Text)
                MessageBox.Show("Passwords do not match");
            else
            {
                try
                {
                    MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Users (Name, userName, password, CompanyCode) VALUES('" + txtEnterFullName.Text + "', '" + txtUserName.Text + "', '" + txtPassword.Text + "', '" + txtCompanyCode.Text + "')", cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    Clear();
                    MessageBox.Show("Registration Successful");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void Clear()
        {
            txtEnterFullName.Text = txtUserName.Text = txtPassword.Text = txtReenterPassword.Text = txtCompanyCode.Text = "";

        }
    }
}
