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
        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");

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

        private void OrdersPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seniorDesignNewSIPDataSet6.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.seniorDesignNewSIPDataSet6.items);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string vendor = cbVendorName.Text;
            string empLevel = globals.level;
            int userid = globals.userid;
            DateTime date = DateTime.Now;

            try
            {
                if (vendor.Equals(""))
                {
                    MessageBox.Show("Please enter a vendor\nbefore you enter order", "Error");
                }
                else
                {
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

                        MySqlCommand cmd = new MySqlCommand("insert into SeniorDesignNewSIP.Order(idOrder,vendor,date,employeeID) values( null,'" + globals.vendorId + "','" + date + "','" + userid + "')", cnn);
                        MySqlCommand cmd1 = new MySqlCommand("SELECT idOrder FROM SeniorDesignNewSIP.Order ORDER BY idOrder DESC LIMIT 1", cnn);

                        cmd.ExecuteNonQuery();

                        MySqlDataReader dr = cmd1.ExecuteReader();
                        while (dr.Read())
                        {
                            globals.orderNumber = dr.GetInt32(0);
                        }

                        cnn.Close();

                        displayinformation();

                        lblOrderNumber.Visible = true;
                        lblOrderNumber.Text = "Order Number: " + globals.orderNumber;
                        lblVendorName.Visible = true;
                        lblVendorName.Text = "Vendor: " + vendor;
                        dataGridView1.Visible = true;
                        label2.Visible = true;
                        txtSearch.Visible = true;
                        dataGridView2.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Does not have access for this fucntion.", "Error");
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayinformation()
        {
            cnn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select sku,itemName,itemSize,Vendor,buyInprice,Quantity FROM items WHERE Vendor ="+ globals.vendorId +"", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        //this is going to search the database
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT sku,itemName,itemSize,Vendor,buyInprice ,Quantity from items WHERE itemName LIKE '%" + txtSearch.Text + "%'" +
                " AND Vendor = "+ globals.vendorId +"", cnn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        //this is going to add the item from the the system to the order
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this item to the order.", "Adding Items to Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string itemName, itemSize, sku, quantity,buyPrice;

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    sku = row.Cells[0].Value.ToString();
                    itemName = row.Cells[1].Value.ToString();
                    itemSize = row.Cells[2].Value.ToString();
                    buyPrice = row.Cells[4].Value.ToString();
                    //vendor we have the global value for that
                    quantity = "0";

                    //Console.WriteLine("sku:" + sku +" item name:"+ itemName + " itemSize:" + itemSize + " buyPrice:"+
                      // buyPrice + "");

                    string[] insertrow = new string[] {sku, itemName, itemSize,globals.vendorId.ToString() ,buyPrice, quantity};
                    dataGridView2.Rows.Add(insertrow);
                }
            }
 
        }

        //when the button is click it is going to make sure the order has somthing
        //and then is going to add to the order product table.
        private void editInventory_Click(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count >=1) 
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want submmit the order.", "Adding Items to Order", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    for (int rows = 0; rows < dataGridView2.Rows.Count; rows++)
                    {
                        try
                        {
                            DataGridViewRow row = dataGridView2.Rows[rows];

                            int sku = int.Parse(row.Cells[0].Value.ToString());
                            int qu = int.Parse(row.Cells[5].Value.ToString());
                            decimal bip = Convert.ToDecimal(row.Cells[4].Value.ToString());

                            MySqlCommand cmd1 = new MySqlCommand("SELECT Quantity from items WHERE sku=" + sku + "", cnn);

                            cnn.Open();

                            MySqlDataReader reader = cmd1.ExecuteReader();
                            while (reader.Read())
                            {
                                globals.getQuan = int.Parse(reader.GetValue(0).ToString());
                            }

                            cnn.Close();

                            Console.WriteLine(sku + " " + globals.orderNumber);
                            MySqlCommand cmd = new MySqlCommand("insert into SeniorDesignNewSIP.order_product(order_id, product_id, quanity, buyInPrice1) values('" + globals.orderNumber
                                + "','" + sku + "','" + qu + "','" + bip + "')", cnn);

                            //"UPDATE Users SET password = '" + txtNewPassword.Text + "' WHERE idUsers = '" + txtEmployeeID.Text + "' AND userName = '" + txtUsername.Text + "'", cnn
                            MySqlCommand cmd2 = new MySqlCommand("UPDATE items SET Quantity =" + (qu + globals.getQuan) + " WHERE sku=" + sku + "", cnn);

                            cnn.Open();

                            cmd.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();

                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }

                    MessageBox.Show("Order has been successfully placed!");

                    this.Hide();
                    OrdersPage x = new OrdersPage();
                    x.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Sorry your order doesn't have any items.\n Please add item.\nIf you have any question contact Manager or Vendor.", "Adding Items to Order");
            }
            
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete item from order?", "Deleting Items from Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
        }
       
    }
}
