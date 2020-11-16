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
    public partial class Inventory : Form
    {

        public Inventory()
        {
            InitializeComponent();
        }

        private void lblCloseProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard m = new Dashboard();
            m.ShowDialog();

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");


        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seniorDesignNewSIPDataSet4.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter2.Fill(this.seniorDesignNewSIPDataSet4.items);

            //cnn.Open();
            ////SELECT userName,password from Users WHERE userName ='"+ txtUserName.Text +"' AND password ='" + txtPassword.Text + "'
            //string qu = "SELECT itemName,itemSize, Quantity from items";
            //MySqlCommand cmd = new MySqlCommand(qu,cnn);
            //MySqlDataReader rd;
            //rd = cmd.ExecuteReader();
            //listView1.Items.Clear();

            //while (rd.Read())
            //{
            //    ListViewItem lv = new ListViewItem(rd.GetString(1).ToString());
            //    lv.SubItems.Add(rd.GetString(2).ToString());
            //    lv.SubItems.Add(rd.GetString(0).ToString());

            //    listView1.Items.Add(lv);
            //}

            //rd.Close();
            //cmd.Dispose();
            //cnn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a test");

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];



        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT sku,itemName,itemSize,Quantity from items WHERE itemName LIKE '%" + txtSearch.Text + "%'", cnn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTextSku.Text = row.Cells[0].Value.ToString();
                txtTextName.Text = row.Cells[1].Value.ToString();
                txtTextItemSize.Text = row.Cells[2].Value.ToString();
                txtTextOnHands.Text = row.Cells[3].Value.ToString();
            }
            cnn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Description,Vendor,retailPrice from items WHERE sku = " + int.Parse(txtTextSku.Text) + "", cnn);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    switch (int.Parse(dr.GetValue(1).ToString()))
                    {
                        case 1145:
                            txtTextVendor.Text = "Manhattan Beer Distributors";
                            break;
                        case 13546:
                            txtTextVendor.Text = "SKI Beer Corporation";
                            break;
                        case 15674:
                            txtTextVendor.Text = "Clare Rose Inc";
                            break;
                        case 32654:
                            txtTextVendor.Text = "Boening Brothers Inc";
                            break;
                        case 65498:
                            txtTextVendor.Text = "Union Beer Distributors";
                            break;
                    }


                    txtTextDes.Text = (dr.GetValue(0).ToString());
                    //txtTextVendor.Text = (dr.GetValue(1).ToString());
                    txtTextretail.Text = (dr.GetValue(2).ToString());
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editInventory_Click(object sender, EventArgs e)
        {
            //cnn.Open();
            //MySqlCommand cmd = new MySqlCommand("SELECT level from Users WHERE userName =" + globals.username + "", cnn);
            //MySqlDataReader dr = cmd.ExecuteReader();

            //if (dr.Read())
            //{
            //   string hold = (dr.GetValue(0).ToString());
            //    if (hold.Equals("Manager"))
            //    {
            //        s
            //    }
            //    else
            //    {

            //    }
            //}
            //cnn.Close();
            try
            {
                if (globals.level.Equals("Employee"))
                {
                    MessageBox.Show("You do not hasve access", "SIP");
                }
                else
                {
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE items SET Quantity =" + int.Parse(txtTextOnHands.Text) + " WHERE sku =" +
                        int.Parse(txtTextSku.Text) + "", cnn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
