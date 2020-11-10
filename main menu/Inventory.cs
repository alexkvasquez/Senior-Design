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

        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Open();
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
        

            //SELECT userName,password from Users WHERE userName ='"+ txtUserName.Text +"' AND password ='" + txtPassword.Text + "'";
           string cmd = "SELECT itemName, itemSize, Quantity from employees";

            MySqlCommand sql = new MySqlCommand(cmd, cnn);
            MySqlDataReader rd;
            rd = sql.ExecuteReader();
            listView1.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetString(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString()); 
                lv.SubItems.Add(rd.GetString(2).ToString());

                listView1.Items.Add(lv);
            }

            rd.Close();
            sql.Dispose();
            cnn.Close();
        }

      
    }
}
