using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace POS_SYSTEM
{
    public partial class addproduct : Form
    {

        private Dbconnection dbConnection;
        private string query = "SELECT * FROM products";
        public addproduct()
        {
            InitializeComponent();
            dbConnection = new Dbconnection();
            
        }

        private void addproduct_Load(object sender, EventArgs e)
        {
            LoadData();
            categoryLoad();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string barcode = txt_barcode.Text;
            string procode = txt_proCode.Text;
            string description = txt_description.Text;
            string category = com_category.SelectedItem.ToString();
            DateTime indate = txt_date.Value;
            string qty = txt_Qty.Text;
            string one_procost = txt_costonePro.Text;
            string selling_price = txt_sellingPrice.Text;
            string totalAmount = txt_totalAmount.Text;
            String grn_no = txt_grn.Text;

            // Execute a query to insert data into the database
            string query = "INSERT INTO products (Barcode ,Product_Key ,Product_Description ,Category ,Stock_In_Date ,QTY ,Price ,Pro_CostAmount ,Total_CostAmount ,GRN_NO ) VALUES (@Barcode ,@Product_Key ,@Product_Description ,@Category ,@Stock_In_Date ,@QTY ,@Price ,@Pro_CostAmount ,@Total_CostAmount ,@GRN_NO)";
            SqlCommand cmd = new SqlCommand(query, dbConnection.con);
            cmd.Parameters.AddWithValue("@Barcode", barcode);
            cmd.Parameters.AddWithValue("@Product_Key", procode);
            cmd.Parameters.AddWithValue("@Product_Description", description);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@Stock_In_Date", indate);
            cmd.Parameters.AddWithValue("@QTY", qty);
            cmd.Parameters.AddWithValue("@Price", selling_price);
            cmd.Parameters.AddWithValue("@Pro_CostAmount", one_procost);
            cmd.Parameters.AddWithValue("@Total_CostAmount", totalAmount);
            cmd.Parameters.AddWithValue("@GRN_NO", grn_no);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!");
                LoadData();
                textClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string barcode = txt_barcode.Text;
            string procode = txt_proCode.Text;
            string description = txt_description.Text;
            string category = com_category.SelectedItem.ToString();
            DateTime indate = txt_date.Value;
            string qty = txt_Qty.Text;
            string one_procost = txt_costonePro.Text;
            string selling_price = txt_sellingPrice.Text;
            string totalAmount = txt_totalAmount.Text;
            String grn_no = txt_grn.Text;

            // Execute a query to update the existing product
            string query = "UPDATE products SET Product_Description = @Product_Description, Category = @Category, Stock_In_Date = @Stock_In_Date, QTY = @QTY, Price = @Price, Pro_CostAmount = @Pro_CostAmount, Total_CostAmount = @Total_CostAmount, GRN_NO = @GRN_NO WHERE Barcode = @Barcode OR Product_Key = @Product_Key";
            SqlCommand cmd = new SqlCommand(query, dbConnection.con);
            cmd.Parameters.AddWithValue("@Product_Description", description);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@Stock_In_Date", indate);
            cmd.Parameters.AddWithValue("@QTY", qty);
            cmd.Parameters.AddWithValue("@Price", selling_price);
            cmd.Parameters.AddWithValue("@Pro_CostAmount", one_procost);
            cmd.Parameters.AddWithValue("@Total_CostAmount", totalAmount);
            cmd.Parameters.AddWithValue("@Barcode", barcode);
            cmd.Parameters.AddWithValue("@Product_Key", procode);
            cmd.Parameters.AddWithValue("@GRN_NO", grn_no); 

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully!");
                LoadData();
                textClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }

        }
        private void LoadData()
        {
            DataTable dataTable = dbConnection.ExecuteQuery(query);
            db_productsView.DataSource = dataTable;
        }

        private void db_productsView_SelectionChanged(object sender, EventArgs e)
        {
            if (db_productsView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = db_productsView.SelectedRows[0];

                txt_barcode.Text = row.Cells["Barcode"].Value.ToString();
                txt_proCode.Text = row.Cells["Product_Key"].Value.ToString();
                txt_description.Text = row.Cells["Product_Description"].Value.ToString();
                com_category.SelectedItem = row.Cells["Category"].Value.ToString();
                txt_date.Value = Convert.ToDateTime(row.Cells["Stock_In_Date"].Value);
                txt_Qty.Text = row.Cells["QTY"].Value.ToString();
                txt_costonePro.Text = row.Cells["Pro_CostAmount"].Value.ToString();
                txt_sellingPrice.Text = row.Cells["Price"].Value.ToString();
                txt_totalAmount.Text = row.Cells["Total_CostAmount"].Value.ToString();
                txt_grn.Text = row.Cells["GRN_NO"].Value.ToString();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
                SearchProducts(txt_search.Text.Trim());

        }
        private void SearchProducts(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText))
            {
                // Filter the DataTable based on the search text
                string filterExpression = $"Barcode LIKE '%{searchText}%' OR Product_Key LIKE '%{searchText}%' OR Product_Description LIKE '%{searchText}%' OR Category LIKE '%{searchText}%' OR GRN_NO LIKE '%{searchText}%'";
                (db_productsView.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
            }
            else
            {
                // If the search text is empty, show all rows in the DataGridView
                (db_productsView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {/*
            if (e.KeyCode == Keys.Enter)
            {
                // Call your search method here
                SearchProducts(txt_search.Text.Trim());
            }*/
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

        private void btn_addCetagory_Click(object sender, EventArgs e)
        {
             string categoryName = txt_categoryadd.Text;

             // Check if the category name is not empty
             if (!string.IsNullOrEmpty(categoryName))
             {
                 // Insert the category name into the Category table
                 InsertCategoryData(categoryName);
                RefreshCategoryComboBox();
                txt_categoryadd.Clear();
             }
             else
             {
                 MessageBox.Show("Please enter a category name.");
             }

           
                 
        }


        private void InsertCategoryData(string categoryName)
        {
            // Assuming you have a method to insert data into your Category table
            string query = "INSERT INTO Category (Category) VALUES (@Category)";
            SqlCommand cmd = new SqlCommand(query, dbConnection.con);
            cmd.Parameters.AddWithValue("@Category", categoryName);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting category: " + ex.Message);
            }
        }

        private void RefreshCategoryComboBox()
        {
            // Assuming your ComboBox is named com_category
            com_category.Items.Clear();

            // Reload the category items from the database
            // For example, if you have a method to populate the ComboBox:
            PopulateCategoryComboBox();
        }

        private void PopulateCategoryComboBox()
        {
            // Assuming you have a method to populate the ComboBox items from the database
            // Clear existing items
            com_category.Items.Clear();

            // Query to fetch categories from the Category table
            string query = "SELECT Category FROM Category";

            // Execute the query and populate the ComboBox
            using (SqlCommand cmd = new SqlCommand(query, dbConnection.con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        com_category.Items.Add(reader["Category"].ToString());
                    }
                }
            }
        }

        private void com_category_TextChanged(object sender, EventArgs e)
        {/*
            // Clear the existing items
            com_category.Items.Clear();

            // Get the text entered by the user
            string searchText = com_category.Text.ToLower();

            // Query to fetch categories from the Category table
            string query = "SELECT Category FROM Category WHERE LOWER(Category) LIKE @SearchText";

            // Assuming you have a method to execute the query and fetch data
            using (SqlCommand cmd = new SqlCommand(query, dbConnection.con))
            {
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        com_category.Items.Add(reader["Category"].ToString());
                    }
                }
            }

            // Show the dropdown
            com_category.DroppedDown = true;*/
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (db_productsView.SelectedRows.Count > 0)
            {
                // Get the value of the first cell in the selected row
                string barcode = db_productsView.SelectedRows[0].Cells["Barcode"].Value.ToString();

                // Execute a query to delete the record from the database
                string query = "DELETE FROM products WHERE Barcode = @Barcode ";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                cmd.Parameters.AddWithValue("@Barcode", barcode);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data deleted successfully!");
                    LoadData();
                    textClear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        public void textClear()
        {
            if (radioButton1.Checked)
            {
                txt_barcode.Clear();
                txt_proCode.Clear();
                txt_categoryadd.Clear();
                txt_Qty.Clear();
                txt_sellingPrice.Clear();
                txt_totalAmount.Clear();
                txt_costonePro.Clear();
                txt_search.Clear();
            }
            else if(radioButton2.Checked)
            {
                txt_grn.Clear();
                txt_barcode.Clear();
                txt_proCode.Clear();
                txt_categoryadd.Clear();
                txt_description.Clear();
                txt_Qty.Clear();
                txt_sellingPrice.Clear();
                txt_totalAmount.Clear();
                txt_costonePro.Clear();
                txt_search.Clear();

                com_category.SelectedIndex = -1;

                // Add the "Select" option if it's not already in the ComboBox items
                if (!com_category.Items.Contains("Select"))
                {
                    com_category.Items.Insert(0, "Select");
                }
            }
            else
            {
                txt_grn.Clear();
                txt_barcode.Clear();
                txt_proCode.Clear();
                txt_categoryadd.Clear();
                txt_description.Clear();
                txt_Qty.Clear();
                txt_sellingPrice.Clear();
                txt_totalAmount.Clear();
                txt_costonePro.Clear();
                txt_search.Clear();

                com_category.SelectedIndex = -1;

                // Add the "Select" option if it's not already in the ComboBox items
                if (!com_category.Items.Contains("Select"))
                {
                    com_category.Items.Insert(0, "Select");
                }
            }
        }

        private void txt_totalAmount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txt_costonePro_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }
        private void CalculateTotalAmount()
        {
            if (decimal.TryParse(txt_Qty.Text, out decimal quantity) && decimal.TryParse(txt_costonePro.Text, out decimal price))
            {
                decimal totalAmount = quantity * price;
                txt_totalAmount.Text = totalAmount.ToString();
            }
            else
            {
                txt_totalAmount.Text = "0"; // or any default value
            }
        }

        private void com_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
