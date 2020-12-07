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
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }
        
       

        /* DISCLAIMER!!!!!!
           I messed up some code at the beginning of the redesign for POS, and made an accidental mistake.
           The dataviewset named dataViewPOS is the data view of the CART section.
           The dataviewset named dataViewPOSCart is the data view of the ITEM SEARCH section
           I realized too late I mixed them up and didnt want to waste time changing the name of the tables everywhere
        */

        //used to perform separate instance between first add item and future add item's
        int i = 0;

        //Creates Middleman database used to store which items to add and remove

        DataTable dt = new DataTable();

        //Define variables used to display and keep track of subtotal, tax and total. Tax Rate is hard coded for now, can be changed for the future
        double subTotal = 0;
        double taxRate = 0.08875;
        double tax = 0;
        double total = 0;

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            
            //Differentiates between first addition to cart and later additions
            //First addition needs to be separate because first addition creates middleman data table, later additions add to it.
            //Simultaniously Functions as a 'Start Sale' button, since first iteration is separate from future iterations.

            if (i == 0)
            {
                //Middleman Data Table
                dt.Columns.Add("sku");
                dt.Columns.Add("Item Name");
                dt.Columns.Add("Retail Price");
                dt.Columns.Add("Item Size");
                

                foreach (DataGridViewRow row in dataViewPOSCart.Rows)
                {

                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                    if (isSelected)
                    {
                        //Adds data to Middleman data table
                        dt.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);

                        //Gets Double value of price, displays that value in subtotal text box.
                        subTotal = subTotal + Convert.ToDouble(row.Cells[3].Value);
                        txtSubTotal.Text = "$" + subTotal.ToString();

                        //Gets value of Tax and displays that value in tax text box.
                        tax = subTotal * taxRate;
                        txtTax.Text = "$" + Math.Round(tax, 2, MidpointRounding.AwayFromZero).ToString();

                        //Gets value of Total and displays that value in total text box.
                        total = subTotal + tax;
                        txtTotal.Text = "$" + Math.Round(total, 2, MidpointRounding.AwayFromZero).ToString();


                    }

                }
                //transfers rows from middleman data table to datagridview
                dataViewPOS.DataSource = dt;
                //ensures table doesn't try to recreate itself
                i = i + 1;
            }
            else
            {
                foreach (DataGridViewRow row in dataViewPOSCart.Rows)
                {

                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                    if (isSelected)
                    {

                        dt.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
                        //Gets Double value of price, displays that value in subtotal text box.
                        subTotal = subTotal + Convert.ToDouble(row.Cells[3].Value);
                        txtSubTotal.Text = "$" + Math.Round(subTotal, 2, MidpointRounding.AwayFromZero).ToString();

                        //Gets value of Tax and displays that value in tax text box.
                        tax = subTotal * taxRate;
                        txtTax.Text = "$" + Math.Round(tax, 2, MidpointRounding.AwayFromZero).ToString();

                        //Gets value of Total and displays that value in total text box.
                        total = subTotal + tax;
                        txtTotal.Text = "$" + Math.Round(total, 2, MidpointRounding.AwayFromZero).ToString();
                    }

                }
                dataViewPOS.DataSource = dt;
               
            }
            
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {

            }
            else
            {
                foreach (DataGridViewRow row in dataViewPOS.Rows)
                {
                  

                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn2"].Value);
                    if (isSelected)
                    {

                        
                        //Gets Double value of price, displays that value in subtotal text box.
                        subTotal = subTotal - Convert.ToDouble(row.Cells[3].Value);
                        txtSubTotal.Text = "$" + Math.Round(subTotal, 2, MidpointRounding.AwayFromZero).ToString();

                        //Gets value of Tax and displays that value in tax text box.
                        tax = subTotal * taxRate;
                        txtTax.Text = "$" + Math.Round(tax, 2, MidpointRounding.AwayFromZero).ToString();

                        //Gets value of Total and displays that value in total text box.
                        total = subTotal + tax;
                        txtTotal.Text = "$" + Math.Round(total, 2, MidpointRounding.AwayFromZero).ToString();

                        //Removes Row from the Cart
                        dataViewPOS.Rows.RemoveAt(row.Index);
                    }

                   



                }


                //Updates the Cart Data Table
                dataViewPOS.Update();
                dataViewPOS.Refresh();
            }
        }   

        private void lblOrders_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard x = new Dashboard();
            x.ShowDialog();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seniorDesignNewSIPDataSet5.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter3.Fill(this.seniorDesignNewSIPDataSet5.items);

           //Sets up a checkbox in Item Search Data Table. Used in Add Item Function
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dataViewPOSCart.Columns.Insert(0, checkBoxColumn);

           //Sets up a checkbox in Cart Data Table. Used in Remove Item Function
            DataGridViewCheckBoxColumn checkBoxColumn2 = new DataGridViewCheckBoxColumn();
            checkBoxColumn2.HeaderText = "";
            checkBoxColumn2.Width = 30;
            checkBoxColumn2.Name = "checkBoxColumn2";
            dataViewPOS.Columns.Insert(0, checkBoxColumn2);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void upDownPOS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HomeIconPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard m = new Dashboard();
            m.ShowDialog();
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          
            //this is going to searh the database for word that matchs item
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT sku,itemName,itemSize,Quantity from items WHERE itemName LIKE '%" + txtSearch.Text + "%'", cnn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataViewPOSCart.DataSource = dt;
            cnn.Close();
        }

        private void dataViewPOSCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            Inventory ToInventory = new Inventory();
            ToInventory.ShowDialog(); // Shows Orders Page
        }
    }
}