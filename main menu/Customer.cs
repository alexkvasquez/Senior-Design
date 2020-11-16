using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_menu
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void HomeIconPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard x = new Dashboard();
            x.ShowDialog();
        }
    }
}
