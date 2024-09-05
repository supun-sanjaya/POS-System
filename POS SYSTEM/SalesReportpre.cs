using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class SalesReportpre : Form
    {
        private Dbconnection dbConnection;
        private string query = "SELECT * FROM sales";
        private string querycredit = "select * from sales where Status='Unpaid' or Status='Partial'";

        public SalesReportpre()
        {
            InitializeComponent();
            dbConnection = new Dbconnection();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewSalesReport_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_filterDate_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime startDate = dateTimePickerst.Value.Date;
                DateTime endDate = dateTimePickered.Value.Date.AddDays(1).AddSeconds(-1);

                Dbconnection dbConnection = new Dbconnection();
                SqlConnection conn = dbConnection.GetConnections();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM sales WHERE Date BETWEEN @StartDate AND @EndDate", conn);

                // Add parameters
                da.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                da.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                DataSet1 ds = new DataSet1();
                da.Fill(ds, "sales");

                if (ds.Tables["sales"].Rows.Count > 0)
                {
                    ReportDataSource datasource = new ReportDataSource("DataSetsales", ds.Tables["sales"]);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No data found for the selected date range.");
                }

                FilterAndDisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void FilterAndDisplayData()
        {          

            DateTime startDate = dateTimePickerst.Value.Date;
            DateTime endDate = dateTimePickered.Value.Date.AddDays(1).AddSeconds(-1);

            try
            {
                string query = "SELECT * FROM sales WHERE Date BETWEEN @StartDate AND @EndDate";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                db_stockViewReport.DataSource = dataTable;

                // Calculate the total quantity from the Qty column
                int totalamount = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalamount += Convert.ToInt32(row["Discounted_Bill_Amount"]);
                }

                txt_totalincome.Text = totalamount.ToString();

                string querycr = "SELECT * FROM sales WHERE (Status='Unpaid' or Status='Partial') and Date BETWEEN @StartDate AND @EndDate";
                SqlCommand cmdd = new SqlCommand(querycr, dbConnection.con);
                cmdd.Parameters.AddWithValue("@StartDate", startDate);
                cmdd.Parameters.AddWithValue("@EndDate", endDate);

                DataTable dataTablecr = new DataTable();
                SqlDataAdapter adaptercr = new SqlDataAdapter(cmdd);
                adaptercr.Fill(dataTablecr);

                db_credittotalincome.DataSource = dataTablecr;

                double totalcredit = 0;
                foreach (DataRow row in dataTablecr.Rows)
                {
                    totalcredit += Convert.ToDouble(row["Balance"]);
                }

                txt_creditAmount.Text = totalcredit.ToString();

                double nettotal = totalamount + totalcredit;
                txt_netTotalincome.Text = nettotal.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering and displaying data: " + ex.Message);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
        }
        

        private void SalesReportpre_Load(object sender, EventArgs e)
        {
            loadreportviewer();
            LoadData();
            // this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }
        private void LoadData()
        {
            DataTable dataTable = dbConnection.ExecuteQuery(query);
            db_stockViewReport.DataSource = dataTable;

            double totalincome = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                totalincome += Convert.ToDouble(row["Discounted_Bill_Amount"]);
            }

            txt_totalincome.Text = totalincome.ToString();

            DataTable dataTablecred = dbConnection.ExecuteQuery(querycredit);
            db_credittotalincome.DataSource = dataTablecred;
            double totalcredit = 0;
            foreach (DataRow row in dataTablecred.Rows)
            {
                totalcredit += Convert.ToDouble(row["Balance"]);
            }

            txt_creditAmount.Text = totalcredit.ToString();

            double nettotal = 0;
            nettotal = totalincome + totalcredit;
            txt_netTotalincome.Text = nettotal.ToString();

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }
        public void loadreportviewer()
        {
            try
            {
                Dbconnection dbConnection = new Dbconnection();
                SqlConnection con = dbConnection.GetConnections();

                SqlDataAdapter da = new SqlDataAdapter("select * from sales", con);
                DataSet1 ds = new DataSet1();
                da.Fill(ds, "sales");

                if (ds.Tables["sales"].Rows.Count > 0)
                {
                    ReportDataSource datasource = new ReportDataSource("DataSetsales", ds.Tables["sales"]);

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
            LoadData();
        }
    }
}
