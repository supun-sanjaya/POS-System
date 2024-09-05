using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_SYSTEM
{
    public partial class StockForm : Form
    {
        private Dbconnection dbConnection;
        //private string query = "SELECT Barcode,Product_Key,Product_Description,Category,Stock_In_Date,QTY,Price FROM products";
        private string query = "SELECT * FROM products";

        public StockForm()
        {
            InitializeComponent();
            dbConnection = new Dbconnection();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            LoadData();

            categoryLoad();

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

                    db_stockView.DataSource = dataTable;
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
                string query = "SELECT DISTINCT Category FROM products";
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

        private void LoadData()
        {
            DataTable dataTable = dbConnection.ExecuteQuery(query);
            db_stockView.DataSource = dataTable;
        }


        private void PerformSearch()
        {
            string searchQuery = txt_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                try
                {
                    string query = "SELECT * FROM products WHERE Barcode LIKE @SearchQuery OR Product_Description LIKE @SearchQuery OR Category LIKE @SearchQuery";
                    SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                    cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    db_stockView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching for products: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search query.");
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void btn_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformSearch();
                e.Handled = true; // Prevent the beep sound
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_search.Clear();
        }

        private void com_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedData();
            txt_search.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterAndDisplayData();
            txt_search.Clear();
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

                db_stockView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering and displaying data: " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
