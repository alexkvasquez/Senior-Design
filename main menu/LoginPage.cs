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
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to close the program", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this is going to check the data base if the login is correct

            string hashedPassword = hashing(txtPassword.Text);


            cnn.Open();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT idUsers,userName,password,level,Name from Users WHERE userName ='"+ txtUserName.Text +"' AND password ='" + hashedPassword + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                globals.userid = int.Parse(reader.GetValue(0).ToString());
                globals.username = reader.GetValue(1).ToString();
                globals.level = reader.GetValue(3).ToString();
                globals.name = reader.GetValue(4).ToString();
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

        private void lblForgotUserName_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword f = new ForgetPassword();
            f.ShowDialog();
        }

        private string hashing(String str)
        {
            string hash;

            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT sha2('"+ txtPassword.Text +"',512)", cnn);
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

