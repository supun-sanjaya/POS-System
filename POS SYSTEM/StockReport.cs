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
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using System.Runtime.InteropServices.ComTypes;

namespace POS_SYSTEM
{
    public partial class StockReport : Form
    {
        private Dbconnection dbConnection;
        private string query = "SELECT * FROM products";
        private object printDialog;

        public StockReport()
        {
            InitializeComponent();
            dbConnection = new Dbconnection();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
             LoadData();
             com_category.Text = "Search Category ";
            loadreportviewer();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
        private void StockReport_Load(object sender, EventArgs e)
        {
            LoadData();
            loadreportviewer();
            categoryLoad();
            this.reportViewer1.RefreshReport();
        }
        private void DisplaySelectedData()
        {
            string selectedCategory = com_category.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                try
                {
                    string query = "SELECT * FROM products WHERE Category = @Category";
                    SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                    cmd.Parameters.AddWithValue("@Category", selectedCategory);

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    db_stockViewReport.DataSource = dataTable;

                    // Calculate the total quantity from the Qty column
                  /*  int totalQty = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        totalQty += Convert.ToInt32(row["QTY"]);
                    }

                    // Display the total quantity in the text box
                    txt_totalQtyre.Text = totalQty.ToString();*/

                    // Calculate the total cost from the totalcost column
                    double totalCost = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        totalCost += Convert.ToDouble(row["Total_CostAmount"]);
                    }

                    // Display the total cost in the text box
                    txt_totalcostRe.Text = totalCost.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying data: " + ex.Message);
                }
            }
        }
        public void categoryLoad()
        {
            try
            {
                string query = "SELECT * FROM Category";//DISTINCT Category
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string category = reader["Category"].ToString();
                    com_category.Items.Add(category);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void btn_filterDate_Click(object sender, EventArgs e)
        {
            
            try
            {
                DateTime startDate = dateTimePickerst.Value.Date;
                DateTime endDate = dateTimePickered.Value.Date.AddDays(1).AddSeconds(-1);

                Dbconnection dbConnection = new Dbconnection();
                SqlConnection conn = dbConnection.GetConnections();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM products WHERE Stock_In_Date BETWEEN @StartDate AND @EndDate", conn);

                // Add parameters
                da.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                da.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                DataSet1 ds = new DataSet1();
                da.Fill(ds, "products");
                ReportDataSource datasource = new ReportDataSource("DataSetReport", ds.Tables[0]);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();

                FilterAndDisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            DataTable dataTable = dbConnection.ExecuteQuery(query);
            db_stockViewReport.DataSource = dataTable;

            double totalCost = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                totalCost += Convert.ToDouble(row["Total_CostAmount"]);
            }

            // Display the total cost in the text box
            txt_totalcostRe.Text = totalCost.ToString();
        }
        private void FilterAndDisplayData()
        {
            DateTime startDate = dateTimePickerst.Value.Date;
            DateTime endDate = dateTimePickered.Value.Date.AddDays(1).AddSeconds(-1);

            try
            {
                string query = "SELECT * FROM products WHERE Stock_In_Date BETWEEN @StartDate AND @EndDate";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                db_stockViewReport.DataSource = dataTable;

                // Calculate the total quantity from the Qty column
              /*  int totalQty = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalQty += Convert.ToInt32(row["QTY"]);
                }

                // Display the total quantity in the text box
                txt_totalQtyre.Text = totalQty.ToString();*/

                // Calculate the total cost from the totalcost column
                double totalCost = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    totalCost += Convert.ToDouble(row["Total_CostAmount"]);
                }

                // Display the total cost in the text box
                txt_totalcostRe.Text = totalCost.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering and displaying data: " + ex.Message);
            }
        }


        private void com_category_SelectedIndexChanged(object sender, EventArgs e)
        {           
            searchcategory();
        }
        public void loadreportviewer()
        {
            Dbconnection dbConnection = new Dbconnection();
            SqlConnection con = dbConnection.GetConnections();

            SqlDataAdapter da = new SqlDataAdapter("select * from products", con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "products");
            ReportDataSource datasource = new ReportDataSource("DataSetReport", ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
        public void searchcategory()
        {
            try
            {
                // Get the selected category from the ComboBox
                string selectedCategory = com_category.SelectedItem.ToString();

                // Create a new database connection
                Dbconnection dbConnection = new Dbconnection();
                SqlConnection conn = dbConnection.GetConnections();

                // Use a parameterized query to avoid SQL injection
                string query = "SELECT * FROM products WHERE Category=@Category";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Category", selectedCategory);

                // Fill the DataSet and set it as the report's data source
                DataSet1 ds = new DataSet1();
                da.Fill(ds, "products");
                ReportDataSource datasource = new ReportDataSource("DataSetReport", ds.Tables[0]);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();

                DisplaySelectedData(); // This method is not defined in your provided code
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


        }

        private void btn_search_Click(object sender, EventArgs e)
        {


        }
    }
}
