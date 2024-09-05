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
    public partial class CreditReport : Form
    {
        private Dbconnection dbConnection;
        private string query = "SELECT * FROM sales  where Status='Unpaid' or Status='Partial'";

        public CreditReport()
        {
            InitializeComponent();
            dbConnection = new Dbconnection();
        }
        private void LoadData()
        {
            DataTable dataTable = dbConnection.ExecuteQuery(query);
            db_creditViewReport.DataSource = dataTable;

            // Calculate the total quantity from the Qty column
            int totalamount = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                totalamount += Convert.ToInt32(row["Balance"]);
            }

            // Display the total quantity in the text box
            txt_totalcreditamount.Text = totalamount.ToString();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_filterDate_Click(object sender, EventArgs e)
        {
                try
                {
                    Dbconnection dbConnection = new Dbconnection();
                    SqlConnection con = dbConnection.GetConnections();

                    SqlDataAdapter da = new SqlDataAdapter("select * from sales where Bill_NO='"+txt_search.Text+"' ", con);
                    DataSet1 ds = new DataSet1();
                    da.Fill(ds, "sales");

                    if (ds.Tables["sales"].Rows.Count > 0)
                    {
                        ReportDataSource datasource = new ReportDataSource("DataSetcredit", ds.Tables["sales"]);

                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(datasource);
                        this.reportViewer1.RefreshReport();

                    PerformSearch();
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
        private void PerformSearch()
        {
            string searchQuery = txt_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                try
                {
                    string query = "SELECT * FROM sales WHERE Bill_NO LIKE @SearchQuery ";
                    SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                    cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    db_creditViewReport.DataSource = dataTable;

                    int totalamount = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        totalamount += Convert.ToInt32(row["Balance"]);
                    }

                    // Display the total quantity in the text box
                    txt_totalcreditamount.Text = totalamount.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching for Bill: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search query.");
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CreditReport_Load(object sender, EventArgs e)
        {
            loadreportviewer();
            LoadData();
            this.reportViewer1.RefreshReport();

            
        }
        public void loadreportviewer()
        {
            try
            {
                Dbconnection dbConnection = new Dbconnection();
                SqlConnection con = dbConnection.GetConnections();

                SqlDataAdapter da = new SqlDataAdapter("select * from sales where Status='Unpaid' or Status='Partial' ", con);
                DataSet1 ds = new DataSet1();
                da.Fill(ds, "sales");

                if (ds.Tables["sales"].Rows.Count > 0)
                {
                    ReportDataSource datasource = new ReportDataSource("DataSetcredit", ds.Tables["sales"]);

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
            LoadData();
            loadreportviewer();
            txt_search.Clear();
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
