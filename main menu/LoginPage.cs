using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


//lit
namespace main_menu
{

    public partial class Login : Form
    {



        public Login()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
        private void labelSendToUp_Click(object sender, EventArgs e)
        {
            //Going to send the user into the other form
            this.Hide();
            SignUp f = new SignUp();
            f.ShowDialog();
        }
        private void labelSendToPassReset_Click(object sender, EventArgs e)
        {
            //Going to send the user into the other form
            this.Hide();
            ForgetPassword f = new ForgetPassword();
            f.ShowDialog();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this is going to check the data base if the login is correct

            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT userName,password from Users WHERE userName ='"+ txtUserName.Text +"' AND password ='" + txtPassword.Text + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                this.Hide();
                Dashboard d = new Dashboard();
                d.ShowDialog();

            }
            else
            {
                MessageBox.Show("Wrong Username And/Or Password");
                txtPassword.Clear();
            }

            cnn.Close();

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeft_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

}

