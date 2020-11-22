using MySql.Data.MySqlClient;
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

        private void OrdersPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seniorDesignNewSIPDataSet5.Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.seniorDesignNewSIPDataSet5.Vendor);

        }

        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");

        private void button1_Click(object sender, EventArgs e)
        {
            string vendor = cbVendorName.Text;
            string date = DateTime.UtcNow.ToString("yyyy-mm-dd");
            string empLevel = globals.level;

            if (empLevel.Equals("Manager"))
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO Order(idOrder,vendor,date,employeeID) Value(@idOrder, @vendor, @date, @employeeID)", cnn);
                cmd.Parameters.AddWithValue("@idOrder", null);
                cmd.Parameters.AddWithValue("@vendor", vendor);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@employeeID", empLevel);

                MySqlCommand cmd1 = new MySqlCommand("SELECT idOrder FROM Order ORDER BY idOrder DESC", cnn);



            }
            else
            {
                MessageBox.Show("Does not have access for this fucntion.", "Error");
            }
          

        }
    }
}
