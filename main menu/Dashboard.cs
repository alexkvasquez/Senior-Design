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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcomeUser.Text = "Welcome " + globals.name + " ";
        }

        private void lblInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory d = new Inventory();
            d.ShowDialog();
        }

        private void lblOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersPage x = new OrdersPage();
            x.ShowDialog();
        }

        private void lblStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff x = new Staff();
            x.ShowDialog();
        }

        private void lblCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer d = new Customer();
            d.ShowDialog();
        }

        private void lblMessages_Click(object sender, EventArgs e)
        {
            this.Hide();
            Message m = new Message();
            m.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            POS P = new POS();
            P.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCloseProgram_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to close the program", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Inventory d = new Inventory();
            this.Hide();
            d.ShowDialog();
        }

        private void OrdersIconPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersPage x = new OrdersPage();
            x.ShowDialog();
        }

        private void StaffIconPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff x = new Staff();
            x.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer d = new Customer();
            d.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Message m = new Message();
            m.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

    }
}
