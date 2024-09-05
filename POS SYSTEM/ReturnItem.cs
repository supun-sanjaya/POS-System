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

namespace POS_SYSTEM
{
    public partial class ReturnItem : Form
    {

        private Dbconnection dbConnection;
        private string query = "SELECT ID, Barcoder, Product_Keyr, Product_Descriptionr, Categoryr, Stock_In_Dater, QTYr, Pricer, Cus_Bill_No FROM returnproducts";

        public ReturnItem()
        {
            InitializeComponent();
            dbConnection = new Dbconnection();

        }

        private void btn_addreturn_Click(object sender, EventArgs e)
        {
            string barcode = txt_barcoder.Text;
            int requestedQty = int.Parse(text_reqtyr.Text);
            String billnore = txt_billno.Text;

            Dbconnection dbConnection = new Dbconnection();

            using (SqlConnection connection = dbConnection.GetConnections())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Retrieve product details from temproducts table
                    string selectQuery = "SELECT Barcodet, Product_Keyt, Product_Descriptiont, Categoryt, Stock_In_Datet, Pricet, Pro_CostAmountt, GRN_NO_ FROM temproducts WHERE Barcodet = @Barcode";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, connection, transaction);
                    selectCmd.Parameters.AddWithValue("@Barcode", barcode);

                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productKey = reader["Product_Keyt"].ToString();
                            string productName = reader["Product_Descriptiont"].ToString();
                            string category = reader["Categoryt"].ToString();
                            DateTime stockInDate = Convert.ToDateTime(reader["Stock_In_Datet"]);
                            decimal price = Convert.ToDecimal(reader["Pricet"]);
                            decimal proCostAmount = Convert.ToDecimal(reader["Pro_CostAmountt"]);
                            string grn = reader["GRN_NO_"].ToString();
                            // Calculate the new total cost amount
                            decimal newTotalCostAmount = requestedQty * proCostAmount;

                            // Close the reader before executing another command
                            reader.Close();

                            // Insert product details into returnproducts table
                            string insertQuery = "INSERT INTO returnproducts (Barcoder, Product_Keyr, Product_Descriptionr, Categoryr, Stock_In_Dater, QTYr, Pricer, Pro_CostAmountr, Total_CostAmountr, GRN_No, Cus_Bill_No) " +
                                                 "VALUES (@Barcoder, @ProductKeyr, @ProductDescriptionr, @Categoryr, @StockInDater, @Qtyr, @Pricer, @ProCostAmountr, @TotalCostAmountr, @GRN_NO, @Cus_Bill_No)";
                            SqlCommand insertCmd = new SqlCommand(insertQuery, connection, transaction);
                            insertCmd.Parameters.AddWithValue("@Barcoder", barcode);
                            insertCmd.Parameters.AddWithValue("@ProductKeyr", productKey);
                            insertCmd.Parameters.AddWithValue("@ProductDescriptionr", productName);
                            insertCmd.Parameters.AddWithValue("@Categoryr", category);
                            insertCmd.Parameters.AddWithValue("@StockInDater", stockInDate);
                            insertCmd.Parameters.AddWithValue("@Qtyr", requestedQty);
                            insertCmd.Parameters.AddWithValue("@Pricer", price);
                            insertCmd.Parameters.AddWithValue("@ProCostAmountr", proCostAmount);
                            insertCmd.Parameters.AddWithValue("@TotalCostAmountr", newTotalCostAmount);
                            insertCmd.Parameters.AddWithValue("@GRN_No", grn);
                            insertCmd.Parameters.AddWithValue("@Cus_Bill_No", billnore);
                            insertCmd.ExecuteNonQuery();

                            MessageBox.Show("Return Item Added");

                            txt_barcoder.Clear();
                            text_reqtyr.Clear();
                            txt_billno.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Product not found in temporary products table.");
                        }
                    }

                    transaction.Commit();
                    LoadData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void ReturnItem_Load(object sender, EventArgs e)
        {
            LoadData();
            btn_updatere.Visible = false;
        }
        private void LoadData()
        {
            DataTable dataTable = dbConnection.ExecuteQuery(query);
            db_returnitem.DataSource = dataTable;

            db_returnitem.Columns["ID"].Visible = false;
        }



        private void UpdateSalesData()
        {
            // Assuming 'db_returnitem' is your DataGridView and 'sales' is your SQL table.
            if (db_returnitem.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = db_returnitem.SelectedRows[0];
                string barcoder = selectedRow.Cells["Barcoder"].Value.ToString();
                int qtyr = Convert.ToInt32(selectedRow.Cells["QTYr"].Value);
                decimal pricer = Convert.ToDecimal(selectedRow.Cells["Pricer"].Value);

                // Fetch the current sales record using Bill_NO (assuming it's unique)
                string billNo = txt_billno.Text; // You need to define how to get the correct Bill_NO

                // Your SQL connection string
                Dbconnection dbConnection = new Dbconnection();

                using (SqlConnection connection = dbConnection.GetConnections())
                {
                    connection.Open();

                    // Get the current sales record
                    string selectQuery = "SELECT Total_Qty, Total_Bill, Discount, Discounted_Bill_Amount FROM sales WHERE Bill_NO = @Bill_NO";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@Bill_NO", billNo);

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        int currentTotalQty = reader.GetInt32(0);
                        decimal currentTotalBill = reader.GetDecimal(1);
                        decimal discount = reader.GetDecimal(2);
                        decimal currentDiscountedBillAmount = reader.GetDecimal(3);

                        // Calculate new values
                        int newTotalQty = currentTotalQty - qtyr;
                        decimal newTotalBill = currentTotalBill - (qtyr * pricer);
                        decimal newDiscountedBillAmount = currentDiscountedBillAmount - (qtyr * pricer);

                        reader.Close();

                        // Update the sales record
                        string updateQuery = "UPDATE sales SET Total_Qty = @Total_Qty, Total_Bill = @Total_Bill, Discounted_Bill_Amount = @Discounted_Bill_Amount WHERE Bill_NO = @Bill_NO";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@Total_Qty", newTotalQty);
                        updateCommand.Parameters.AddWithValue("@Total_Bill", newTotalBill);
                        updateCommand.Parameters.AddWithValue("@Discounted_Bill_Amount", newDiscountedBillAmount);
                        updateCommand.Parameters.AddWithValue("@Bill_NO", billNo);

                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        public void deletereturntablerow()
        {
            // Check if a row is selected
            if (db_returnitem.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = db_returnitem.SelectedRows[0];

                // Get the unique identifier from the selected row (e.g., ID)
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Define the delete query
                string deleteTempQuery = "DELETE FROM returnproducts WHERE ID = @ID";

                // Create the SQL command
                using (SqlCommand deleteTempCmd = new SqlCommand(deleteTempQuery, dbConnection.con))
                {
                    // Add the parameter to the command
                    deleteTempCmd.Parameters.AddWithValue("@ID", id);

                    // Open the connection if it's not already open
                    if (dbConnection.con.State != ConnectionState.Open)
                    {
                        dbConnection.con.Open();
                    }

                    // Execute the command
                    deleteTempCmd.ExecuteNonQuery();

                    // Optionally, close the connection
                    dbConnection.con.Close();
                }

                // Remove the row from the DataGridView
                db_returnitem.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Please select a row .");
            }
        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_billno.Text.Trim()))
            {
                MessageBox.Show("Bill number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (db_returnitem.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = db_returnitem.SelectedRows[0];
                    string barcode = selectedRow.Cells["Barcoder"].Value.ToString(); // Assuming "Barcoder" is the name of the column
                    int quantity = Convert.ToInt32(selectedRow.Cells["QTYr"].Value); // Assuming "QTYr" is the name of the column

                    // Open the connection
                    if (dbConnection.con.State == ConnectionState.Closed)
                    {
                        dbConnection.con.Open();
                    }

                    try
                    {
                        // Query to retrieve the current quantity of the product based on the barcode
                        string query = "SELECT QTY FROM products WHERE Barcode = @Barcode";
                        SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                        cmd.Parameters.AddWithValue("@Barcode", barcode);

                        // Execute the query to get the current quantity
                        object result = cmd.ExecuteScalar();

                        // Retrieve the current unit cost
                        string unitCostQuery = "SELECT Pro_CostAmount FROM products WHERE Barcode = @Barcode";
                        SqlCommand unitCostCmd = new SqlCommand(unitCostQuery, dbConnection.con);
                        unitCostCmd.Parameters.AddWithValue("@Barcode", barcode);
                        object unitCostResult = unitCostCmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Product found in products table
                            int currentQty = Convert.ToInt32(result);
                            int newQty = currentQty + quantity;

                            decimal unitCost = Convert.ToDecimal(unitCostResult);
                            decimal newTotalCostAmount = unitCost * newQty;

                            // Update the quantity in the products table
                            string updateQuery = "UPDATE products SET QTY = @NewQty, Total_CostAmount = @NewTotalCostAmount WHERE Barcode = @Barcode";
                            SqlCommand updateCmd = new SqlCommand(updateQuery, dbConnection.con);
                            updateCmd.Parameters.AddWithValue("@NewQty", newQty);
                            updateCmd.Parameters.AddWithValue("@NewTotalCostAmount", newTotalCostAmount);
                            updateCmd.Parameters.AddWithValue("@Barcode", barcode);
                            updateCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // Product not found in products table, check in temproducts table
                            string tempQuery = "SELECT * FROM returnproducts WHERE Barcoder = @Barcoder";
                            SqlCommand tempCmd = new SqlCommand(tempQuery, dbConnection.con);
                            tempCmd.Parameters.AddWithValue("@Barcoder", barcode);
                            SqlDataReader tempReader = tempCmd.ExecuteReader();

                            if (tempReader.Read())
                            {
                                // Product found in temproducts table
                                string productKey = tempReader["Product_Keyr"].ToString();
                                string productName = tempReader["Product_Descriptionr"].ToString();
                                string category = tempReader["Categoryr"].ToString();
                                DateTime stockInDate = Convert.ToDateTime(tempReader["Stock_In_Dater"]);
                                decimal price = Convert.ToDecimal(tempReader["Pricer"]);
                                decimal proCostAmount = Convert.ToDecimal(tempReader["Pro_CostAmountr"]);
                                decimal totalCostAmount = Convert.ToDecimal(tempReader["Total_CostAmountr"]);
                                string grn = tempReader["GRN_No"].ToString();
                                // string Cus_BillNo = tempReader["Cus_Bill_No"].ToString();

                                // Close the reader before executing another command
                                tempReader.Close();

                                // Insert the product back into products table with the quantity from the cart
                                string insertQuery = "INSERT INTO products (Barcode, Product_Key, Product_Description, Category, Stock_In_Date, QTY, Price, Pro_CostAmount, Total_CostAmount, GRN_NO) " +
                                                     "VALUES (@Barcode, @ProductKey, @ProductDescription, @Category, @StockInDate, @Qty, @Price, @ProCostAmount, @TotalCostAmount, @GRN_NO)";
                                SqlCommand insertCmd = new SqlCommand(insertQuery, dbConnection.con);
                                insertCmd.Parameters.AddWithValue("@Barcode", barcode);
                                insertCmd.Parameters.AddWithValue("@ProductKey", productKey);
                                insertCmd.Parameters.AddWithValue("@ProductDescription", productName);
                                insertCmd.Parameters.AddWithValue("@Category", category);
                                insertCmd.Parameters.AddWithValue("@StockInDate", stockInDate);
                                insertCmd.Parameters.AddWithValue("@Qty", quantity);
                                insertCmd.Parameters.AddWithValue("@Price", price);
                                insertCmd.Parameters.AddWithValue("@ProCostAmount", proCostAmount);
                                insertCmd.Parameters.AddWithValue("@TotalCostAmount", totalCostAmount);
                                insertCmd.Parameters.AddWithValue("@GRN_NO", grn);
                                insertCmd.ExecuteNonQuery();

                                /*string deleteTempQuery = "DELETE FROM returnproducts WHERE Barcoder = @Barcoder";
                                SqlCommand deleteTempCmd = new SqlCommand(deleteTempQuery, dbConnection.con);
                                deleteTempCmd.Parameters.AddWithValue("@Barcoder", barcode);
                                deleteTempCmd.ExecuteNonQuery();*/
                            }
                            else
                            {
                                // Product not found in both tables
                                tempReader.Close();
                                MessageBox.Show("Error: Product not found in both Products and Returnproducts tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        // Remove the selected row from the cart DataGridView
                        //cartDataGridView.Rows.RemoveAt(selectedRow.Index);
                        UpdateSalesData();
                        MessageBox.Show("Return Item Added To Stock ( Admin Part ).");
                        deletereturntablerow();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Adding Return Item : " + ex.Message);
                    }
                    finally
                    {
                        // Close the connection
                        if (dbConnection.con.State == ConnectionState.Open)
                        {
                            dbConnection.con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row.");
                }
                LoadData();

            }

        }

        private void db_returnitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = db_returnitem.Rows[e.RowIndex];
                txt_billno.Text = row.Cells["Cus_Bill_No"].Value.ToString();

            }
        }
    }
}
