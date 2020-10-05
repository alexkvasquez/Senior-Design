using System;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelSendToUp_Click(object sender, EventArgs e)
        {
            //Going to send the user into the other form
            this.Hide();
            SignUp f = new SignUp();
            f.ShowDialog();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblForgotUserName_Click(object sender, EventArgs e)
        {

        }
    }

}
