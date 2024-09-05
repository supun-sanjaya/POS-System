using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class QtyRefillstock : Form
    {
        public QtyRefillstock()
        {
            InitializeComponent();
        }

        private void QtyRefillstock_Load(object sender, EventArgs e)
        {
            loadreportviewer();
        }
        public void loadreportviewer()
        {
            Dbconnection dbConnection = new Dbconnection();
            SqlConnection con = dbConnection.GetConnections();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM products WHERE QTY <=8", con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "products");
            ReportDataSource datasource = new ReportDataSource("DataSetReport", ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }

        private void btn_filterDate_Click(object sender, EventArgs e)
        {
            try
            {
                Dbconnection dbConnection = new Dbconnection();
                SqlConnection con = dbConnection.GetConnections();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM products WHERE QTY <=8 AND Bill_NO='" + txt_search.Text + "' ", con);
                DataSet1 ds = new DataSet1();
                da.Fill(ds, "products");

                if (ds.Tables["products"].Rows.Count > 0)
                {
                    ReportDataSource datasource = new ReportDataSource("DataSetReport", ds.Tables["products"]);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);
                    this.reportViewer1.RefreshReport();

                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadreportviewer();
        }
    }
}
