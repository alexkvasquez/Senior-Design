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
    public partial class OrdersPage : Form
    {
        public OrdersPage()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ordersToInventory_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Inventory I = new Inventory();
            I.ShowDialog();
        }

        private void HomeIconPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard m = new Dashboard();
            m.ShowDialog();
        }

        private void editInventory_Click(object sender, EventArgs e)
        {

        }
    }
}
