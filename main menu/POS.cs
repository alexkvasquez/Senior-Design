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

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020";
                string Query = "delete from student.studentinfo where idStudentInfo='" + this.txtSearch.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            {
                Int32 btnAddItem = dataViewPOS.Columns
                    .GetColumnCount(DataGridViewElementStates.Selected);
                if (btnAddItem > 0)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    for (int i = 0; i < btnAddItem; i++)
                    {
                        sb.Append("Column: ");
                        sb.Append(dataViewPOS.SelectedColumns[i].Index
                            .ToString());
                        sb.Append(Environment.NewLine);
                    }

                    sb.Append("Total: " + btnAddItem.ToString());
                    MessageBox.Show(sb.ToString(), "Selected Columns");
                }
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
            // TODO: This line of code loads data into the 'seniorDesignNewSIPDataSet2.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter2.Fill(this.seniorDesignNewSIPDataSet2.items);
            // TODO: This line of code loads data into the 'seniorDesignNewSIPDataSet3.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.seniorDesignNewSIPDataSet3.items);
          

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
    }
}