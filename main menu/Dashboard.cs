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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void lblInventory_Click(object sender, EventArgs e)
        {

        }

        private void lblOrders_Click(object sender, EventArgs e)
        {

        }

        private void lblStaff_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomers_Click(object sender, EventArgs e)
        {
            Customer d = new Customer();
            d.ShowDialog();
        }

        private void lblMessages_Click(object sender, EventArgs e)
        {
            Message m = new Message();
            m.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCloseProgram_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to close the porgram", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
