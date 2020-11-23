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
            // TODO: This line of code loads data into the 'seniorDesignNewSIPDataSet6.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.seniorDesignNewSIPDataSet6.items);
        }

        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");

        private void button1_Click(object sender, EventArgs e)
        {
            string vendor = cbVendorName.Text;
            string empLevel = globals.level;
            int userid = globals.userid;
            DateTime date = DateTime.Now;

            if (empLevel.Equals("Manager"))
            {
                switch (vendor)
                {
                    case "Manhattan Beer Distributors":
                        globals.vendorId = 1145;
                        break;
                    case "SKI Beer Corporation":
                        globals.vendorId = 13546;
                        break;
                    case "Clare Rose Inc":
                        globals.vendorId = 15674;
                        break;
                    case "Boening Brothers Inc":
                        globals.vendorId = 32654;
                        break;
                    case "Union Beer Distributors":
                        globals.vendorId = 65498;
                        break;
                }

                cnn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into SeniorDesignNewSIP.Order(idOrder,vendor,date,employeeID) values( null,'" + globals.vendorId +"','"+ date +"','"+ userid +"')", cnn);
                MySqlCommand cmd1 = new MySqlCommand("SELECT idOrder FROM SeniorDesignNewSIP.Order ORDER BY idOrder DESC LIMIT 1", cnn);

                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    globals.orderNumber = dr.GetInt32(0);
                }

              
                cnn.Close();

                lblOrderNumber.Visible = true;
                lblOrderNumber.Text = "Order Number: " + globals.orderNumber;
                lblVendorName.Visible = true;
                lblVendorName.Text = "Vendor: " + vendor;
                dataGridView1.Visible = true;
                label2.Visible = true;
                txtSearch.Visible = true;
                btnAddItemOrder.Visible = true;
                dataGridView2.Visible = true;
            }
            else
            {
                MessageBox.Show("Does not have access for this fucntion.", "Error");
            }
          

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT sku,itemName,itemSize,Quantity from items WHERE itemName LIKE '%" + txtSearch.Text + "%'", cnn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }
    }
}
