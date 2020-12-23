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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seniorDesignNewSIPDataSet.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.seniorDesignNewSIPDataSet.Transaction);
            lblWelcomeUser.Text = "Welcome " + globals.name + " ";
            lblSales.Text = "$" + todaySales();
            lblSalesGoalWeek.Text = "$3,000";
            lblItemsSold.Text = "" + howMany();
            lblHotItem.Text = bestItem();
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

        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");

        private decimal todaySales()
        {
            decimal i;
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(`subtotal`) from `Transaction` where str_to_date(`date`, '%m/%d/%y') = date_format(curdate(), '%y/%m/%d')", cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string b = reader.GetValue(0).ToString();
                if (b.Equals(""))
                {
                    cnn.Close();
                    return 0;
                }
                else
                {
                    i = decimal.Parse(b);
                    cnn.Close();
                    return i;
                }
            }
            else
            {
                cnn.Close();
                return 0;
            }
        }

        private int howMany()
        {
            int i;
            cnn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(transaction_item.tranId) AS Expr1 FROM transaction_item INNER JOIN Transaction ON transaction_item.tranId = Transaction.idTransaction " +
                "WHERE(str_to_date(Transaction.`date`, '%m/%d/%y') = date_format(CURDATE(), '%y/%m/%d'))", cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                i = int.Parse(reader.GetValue(0).ToString());
                cnn.Close();
                return i;
            }
            else
            {
                cnn.Close();
                return 0;
            }

        }
        private string bestItem()
        {
            string str;
            cnn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT items.itemName, COUNT(transaction_item.itemId) AS Expr1 FROM transaction_item INNER JOIN Transaction ON transaction_item.tranId = Transaction.idTransaction INNER JOIN items ON transaction_item.itemId = items.sku" +
                " WHERE(STR_TO_DATE(Transaction.`date`, '%m/%d/%y') = DATE_FORMAT(CURDATE(), '%y/%m/%d')) GROUP BY transaction_item.itemId ORDER BY Expr1 DESC LIMIT 1", cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                str = reader.GetValue(0).ToString();
                cnn.Close();
                return str;
            }
            else
            {
                cnn.Close();
                return null;
            }

        }

    }
}
