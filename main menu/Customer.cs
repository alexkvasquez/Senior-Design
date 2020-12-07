using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace main_menu
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void HomeIconPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard x = new Dashboard();
            x.ShowDialog();
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {

            txtCustomerID.Clear();
            txtEditName.Clear();
            txtEditPhone.Clear();

            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT idCustomer,name,phonenumber from Customer WHERE name LIKE '%" + txtCustomerSearch.Text + "%'", cnn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Customer (name, phonenumber) VALUES('" + txtAddName.Text + "', '" + txtAddPhone.Text + "')", cnn);
                cmd.ExecuteNonQuery(); 
                Clear();
                MessageBox.Show("Customer Successfully Added");

                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM SeniorDesignNewSIP.Customer;", cnn);
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd2.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Clear()
        {
            txtAddName.Text = txtAddPhone.Text = "";

        }
        void ClearEdited()
        {
            txtCustomerID.Text = txtEditName.Text = txtEditPhone.Text = "";

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCustomerID.Text = row.Cells[0].Value.ToString();
                txtEditName.Text = row.Cells[1].Value.ToString();
                txtEditPhone.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Customer SET name = '" + txtEditName.Text + "', phonenumber = '" + txtEditPhone.Text + "' WHERE idCustomer ='" + txtCustomerID.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Information Updated");

                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM SeniorDesignNewSIP.Customer;", cnn);
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd2.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Customer WHERE idCustomer ='" + txtCustomerID.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted");
                ClearEdited();

                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM SeniorDesignNewSIP.Customer;", cnn);
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd2.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
