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
    public partial class POSREPORT : Form
    {
        ReportDocument cryrpt1 = new ReportDocument();
        MySqlConnection cnn = new MySqlConnection("datasource=104.198.30.14;port=3306;database = SeniorDesignNewSIP;username=Alex Vazquez;password=NYIT2020");
        MySqlDataAdapter da1;
        public POSREPORT()
        {
            InitializeComponent();
        }

        private void POSREPORT_Load(object sender, EventArgs e)
        {
            cnn.Open();

            da1 = new MySqlDataAdapter("SELECT items.sku, items.itemName, items.itemSize, items.retailPrice, Transaction.idTransaction, Transaction.empId, Transaction.`date`, Transaction.subtotal, Transaction.grandTotal FROM items INNER JOIN transaction_item ON items.sku = transaction_item.itemId INNER JOIN Transaction ON transaction_item.tranId = Transaction.idTransaction WHERE(transaction_item.tranId =" + globals.transnumber + ")",cnn);
            DataSet dst = new DataSet();
            da1.Fill(dst, "Transrep1");
            cryrpt1.Load("receipt.rpt");
            cryrpt1.SetDataSource(dst);
            crystalReportViewer1.ReportSource = cryrpt1;
            cnn.Close();

        }

        private void POSREPORT_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            POS x = new POS();
            x.Show();
        }
    }
}
