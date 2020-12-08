using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
 

namespace main_menu
{
    public partial class ReportForm : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");
        MySqlDataAdapter da;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT order_product.*, SeniorDesignNewSIP.Order.vendor, SeniorDesignNewSIP.Order.date, SeniorDesignNewSIP.Order.employeeID," +
                "items.itemName, items.itemSize, CAST(order_product.quanity as decimal(10,0)) * order_product.buyInPrice1 as ItemTotal FROM ((order_product INNER JOIN items ON order_product.product_id = items.sku) INNER JOIN SeniorDesignNewSIP.Order ON order_product.order_id = SeniorDesignNewSIP.Order.idOrder)" +
                " WHERE order_id ="+ globals.orderNumber +"";
            cnn.Open();

            da = new MySqlDataAdapter(cmd,cnn);
            DataSet dst = new DataSet();
            da.Fill(dst, "DataReport");
            cryrpt.Load("OrderReport.rpt");
            cryrpt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = cryrpt;
            cnn.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
