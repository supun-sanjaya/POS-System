using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;///////
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.IO;
//using Epson.POSPrinter;



namespace POS_SYSTEM
{
    public partial class CashierForm : Form
    {
        private Dbconnection dbConnection;
        private int billNumber = 1; // Start from 1 or any other initial number

        public CashierForm()
        {
            InitializeComponent();
            dbConnection = new Dbconnection();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchByBarcode();
        }
        private void SearchByBarcode()
        {
            string barcode = txt_barcode.Text.Trim();

            try
            {
                string query = "SELECT * FROM products WHERE Barcode = @Barcode";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                cmd.Parameters.AddWithValue("@Barcode", barcode);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string productName = reader["Product_Description"].ToString(); // Assuming "ProductName" is a column in YourTable
                    decimal price = Convert.ToDecimal(reader["Price"]); // Assuming "Price" is a column in YourTable
                    int availble_qty = Convert.ToInt16(reader["QTY"]); 
                    String pro_key = reader["Product_Key"].ToString(); 
                    txt_description.Text = productName;
                    txt_proprice.Text = price.ToString();
                    txt_procode.Text = pro_key;
                    txt_availableqty.Text = availble_qty.ToString();
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for product: " + ex.Message);
            }
        }
        
        private void CashierForm_Load(object sender, EventArgs e)
        {
            DataLoadBillno();
            // Get the current date and format it as "dd/MM/yyyy"
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");

            // Display the current date in the txt_datecurr label
            txt_datecurr.Text = currentDate;

        }
        private void CalculateTotalAmount()
        {
            decimal billamount = 0;
            int totlproqty = 0;

            foreach (DataGridViewRow row in cartDataGridView.Rows)
            {
                billamount += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                totlproqty += Convert.ToInt16(row.Cells["QTY"].Value);
            }

            // Display the total amount in a label or text box
            txt_billamount.Text = billamount.ToString();
            txt_TotalQty.Text = totlproqty.ToString();
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {

            /*
                         string barcode = txt_barcode.Text.Trim();
                         int quantity = int.Parse(txt_qty.Text); // Assuming quantity is always a valid integer

                         // Query to retrieve product details based on barcode
                         string query = "SELECT * FROM products WHERE Barcode = @Barcode";
                         SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                         cmd.Parameters.AddWithValue("@Barcode", barcode);

                         try
                         {
                             // Execute the query
                             SqlDataReader reader = cmd.ExecuteReader();

                             if (reader.Read())
                             {
                                 string productName = reader["Product_Description"].ToString();
                                 decimal unitPrice = Convert.ToDecimal(reader["Price"]);
                                 decimal totalAmount = unitPrice * quantity;
                                 string productKey = reader["Product_Key"].ToString();
                                 int currentQty = Convert.ToInt32(reader["QTY"]);
                                 decimal proCostAmount = Convert.ToDecimal(reader["Pro_CostAmount"]);
                                 string grn = reader["GRN_NO"].ToString();

                                 // Check if the current quantity is enough
                                 if (currentQty >= quantity)
                                 {
                                     // Add the product to the cart DataGridView
                                     cartDataGridView.Rows.Add(barcode, productName, unitPrice, quantity, totalAmount);

                                     // Optionally, you can calculate and display the total amount in a label or text box
                                     CalculateTotalAmount();
                                     textClear();

                                     if (currentQty == quantity)
                                     {
                                         // Close the reader before executing another command
                                         reader.Close();

                                         // Use a transaction to ensure data integrity
                                         using (SqlTransaction transaction = dbConnection.con.BeginTransaction())
                                         {
                                             try
                                             {
                                                 // Move product details to temproducts table
                                                 string insertTemProductsQuery = "INSERT INTO temproducts (Barcodet, Product_Keyt, Product_Descriptiont, Categoryt, Stock_In_Datet, QTYt, Pricet, Pro_CostAmountt, Total_CostAmountt, GRN_NO_) " +
                                                                                 "SELECT Barcode, Product_Key, Product_Description, Category, Stock_In_Date, QTY, Price, Pro_CostAmount, Total_CostAmount, GRN_NO " +
                                                                                 "FROM products WHERE Product_Key = @ProductKey";
                                                 SqlCommand insertTemProductsCmd = new SqlCommand(insertTemProductsQuery, dbConnection.con, transaction);
                                                 insertTemProductsCmd.Parameters.AddWithValue("@ProductKey", productKey);
                                                 insertTemProductsCmd.ExecuteNonQuery();

                                                 // Delete the product from the products table
                                                 string deleteQuery = "DELETE FROM products WHERE Product_Key = @ProductKey";
                                                 SqlCommand deleteCmd = new SqlCommand(deleteQuery, dbConnection.con, transaction);
                                                 deleteCmd.Parameters.AddWithValue("@ProductKey", productKey);
                                                 deleteCmd.ExecuteNonQuery();

                                                 // Commit the transaction
                                                 transaction.Commit();
                                             }
                                             catch (Exception ex)
                                             {
                                                 // Rollback the transaction in case of an error
                                                 transaction.Rollback();
                                                 MessageBox.Show("Error moving product to temproducts: " + ex.Message);
                                             }
                                         }
                                     }
                                     else
                                     {

                                         int newQty = currentQty - quantity;
                                         decimal newTotalCostAmount = newQty * proCostAmount;

                                         decimal temTotalCostAmount = quantity * proCostAmount;

                                         // Close the reader before executing another command
                                         reader.Close();

                                         using (SqlTransaction transaction = dbConnection.con.BeginTransaction())
                                         {
                                             try
                                             {
                                                 // Update the products table
                                                 SqlCommand updateCommand = new SqlCommand("UPDATE products SET QTY = @NewQty, Total_CostAmount = @NewTotalCostAmount WHERE Product_Key = @ProductKey", dbConnection.con, transaction);
                                                 updateCommand.Parameters.AddWithValue("@NewQty", newQty);
                                                 updateCommand.Parameters.AddWithValue("@NewTotalCostAmount", newTotalCostAmount);
                                                 updateCommand.Parameters.AddWithValue("@ProductKey", productKey);
                                                 updateCommand.ExecuteNonQuery();

                                                 // Check if the product already exists in the temproducts table
                                                 string checkTemProductsQuery = "SELECT COUNT(*) FROM temproducts WHERE Product_Keyt = @ProductKey";
                                                 SqlCommand checkTemProductsCmd = new SqlCommand(checkTemProductsQuery, dbConnection.con, transaction);
                                                 checkTemProductsCmd.Parameters.AddWithValue("@ProductKey", productKey);
                                                 int temProductsCount = (int)checkTemProductsCmd.ExecuteScalar();



                                                     // If not exists, insert a new record into the temproducts table
                                                     string insertTemProductsQuery = "INSERT INTO temproducts (Barcodet, Product_Keyt, Product_Descriptiont, Categoryt, Stock_In_Datet, QTYt, Pricet, Pro_CostAmountt, Total_CostAmountt, GRN_NO_) " +
                                                                                     "SELECT Barcode, Product_Key, Product_Description, Category, Stock_In_Date, @Quantity, Price, Pro_CostAmount, @Total_CostAmount, GRN_NO " +
                                                                                     "FROM products WHERE Product_Key = @ProductKey";
                                                     SqlCommand insertTemProductsCmd = new SqlCommand(insertTemProductsQuery, dbConnection.con, transaction);
                                                     insertTemProductsCmd.Parameters.AddWithValue("@Quantity", quantity);
                                                      insertTemProductsCmd.Parameters.AddWithValue("@Total_CostAmount", temTotalCostAmount);
                                                     insertTemProductsCmd.Parameters.AddWithValue("@ProductKey", productKey);
                                                     insertTemProductsCmd.ExecuteNonQuery();


                                                 // Commit the transaction
                                                 transaction.Commit();
                                             }
                                             catch (Exception ex)
                                             {
                                                 // Rollback the transaction if any error occurs
                                                 transaction.Rollback();
                                                 throw new Exception("An error occurred while updating the product data.", ex);
                                             }
                                         }



                                     }
                                 }
                                 else
                                 {
                                     reader.Close();
                                     MessageBox.Show("Error: Current quantity is less than the required quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 }
                             }
                             else
                             {
                                 reader.Close();
                                 MessageBox.Show("Product not found.");
                             }
                         }
                         catch (Exception ex)
                         {
                             MessageBox.Show("Error adding product to cart: " + ex.Message);
                         }
             */

              string barcode = txt_barcode.Text.Trim();
                int quantity = int.Parse(txt_qty.Text); // Assuming quantity is always a valid integer

                // Query to retrieve product details based on barcode
                string query = "SELECT * FROM products WHERE Barcode = @Barcode";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                cmd.Parameters.AddWithValue("@Barcode", barcode);

                try
                {
                    // Execute the query
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string productName = reader["Product_Description"].ToString();
                        decimal unitPrice = Convert.ToDecimal(reader["Price"]);
                        decimal totalAmount = unitPrice * quantity;
                        string productKey = reader["Product_Key"].ToString();
                        int currentQty = Convert.ToInt32(reader["QTY"]);
                        decimal proCostAmount = Convert.ToDecimal(reader["Pro_CostAmount"]);
                        string grn = reader["GRN_NO"].ToString();

                        // Check if the current quantity is enough
                        if (currentQty >= quantity)
                        {
                            // Add the product to the cart DataGridView
                            cartDataGridView.Rows.Add(barcode, productName, unitPrice, quantity, totalAmount);

                            // Optionally, you can calculate and display the total amount in a label or text box
                            CalculateTotalAmount();
                            textClear();

                            // Update the quantity and total cost amount in the products table
                            int newQty = currentQty - quantity;
                            decimal newTotalCostAmount = newQty * proCostAmount;

                            // Close the reader before executing another command
                            reader.Close();

                            using (SqlTransaction transaction = dbConnection.con.BeginTransaction())
                            {
                                try
                                {
                                    // Update the products table
                                    SqlCommand updateCommand = new SqlCommand("UPDATE products SET QTY = @NewQty, Total_CostAmount = @NewTotalCostAmount WHERE Product_Key = @ProductKey", dbConnection.con, transaction);
                                    updateCommand.Parameters.AddWithValue("@NewQty", newQty);
                                    updateCommand.Parameters.AddWithValue("@NewTotalCostAmount", newTotalCostAmount);
                                    updateCommand.Parameters.AddWithValue("@ProductKey", productKey);
                                    updateCommand.ExecuteNonQuery();

                                    // Commit the transaction
                                    transaction.Commit();
                                }
                                catch (Exception ex)
                                {
                                    // Rollback the transaction if any error occurs
                                    transaction.Rollback();
                                    throw new Exception("An error occurred while updating the product data.", ex);
                                }
                            }
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Error: Current quantity is less than the required quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding product to cart: " + ex.Message);
                }
            


        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(txt_qty.Text))
                {
                    txt_totalItemsPrice.Text = "0.00";
                }
                else
                {
                    int quantity = Convert.ToInt32(txt_qty.Text);
                    decimal price = Convert.ToDecimal(txt_proprice.Text);

                    decimal total_onepro = price * quantity;
                    txt_totalItemsPrice.Text = total_onepro.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid quantity and price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textClear()
        {
            
            txt_barcode.Text="";
            txt_qty.Text="";
            txt_procode.Text = "";
            txt_proprice.Text = "";
            txt_description.Text = "";
            txt_availableqty.Text = "";
            txt_totalItemsPrice.Text = "";
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            textClear();
            //SaveLastInvoiceNumber();
            DataLoadBillno();
        }

        private void cartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            /*  if (cartDataGridView.SelectedRows.Count > 0)
              {
                  cartDataGridView.Rows.RemoveAt(cartDataGridView.SelectedRows[0].Index);
              }
              else
              {
                  MessageBox.Show("Please select a row to delete.");
              }*/

    if (cartDataGridView.SelectedRows.Count > 0)
    {

                DataGridViewRow selectedRow = cartDataGridView.SelectedRows[0];

            // Get the quantity and product key from the selected row
            int quantity = Convert.ToInt32(selectedRow.Cells["QTY"].Value); // Replace "QuantityColumnName" with your actual column name
            string productKey = selectedRow.Cells["barcode"].Value.ToString(); // Replace "ProductKeyColumnName" with your actual column name

            // Remove the selected row from the DataGridView
            cartDataGridView.Rows.RemoveAt(selectedRow.Index);

            try
            {
                    Dbconnection dbConnection = new Dbconnection();

                    using (SqlConnection connection = dbConnection.GetConnections())
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Retrieve the current quantity and cost amount from the products table
                            string selectQuery = "SELECT QTY, Pro_CostAmount FROM products WHERE Product_Key = @ProductKey";
                            SqlCommand selectCommand = new SqlCommand(selectQuery, connection, transaction);
                            selectCommand.Parameters.AddWithValue("@ProductKey", productKey);

                            SqlDataReader reader = selectCommand.ExecuteReader();

                            if (reader.Read())
                            {
                                int currentQty = Convert.ToInt32(reader["QTY"]);
                                decimal proCostAmount = Convert.ToDecimal(reader["Pro_CostAmount"]);
                                reader.Close();

                                // Calculate the new quantity and total cost amount
                                int newQty = currentQty + quantity;
                                decimal newTotalCostAmount = newQty * proCostAmount;

                                // Update the products table
                                string updateQuery = "UPDATE products SET QTY = @NewQty, Total_CostAmount = @NewTotalCostAmount WHERE Product_Key = @ProductKey";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                                updateCommand.Parameters.AddWithValue("@NewQty", newQty);
                                updateCommand.Parameters.AddWithValue("@NewTotalCostAmount", newTotalCostAmount);
                                updateCommand.Parameters.AddWithValue("@ProductKey", productKey);
                                updateCommand.ExecuteNonQuery();

                                // Commit the transaction
                                transaction.Commit();
                            }
                            else
                            {
                                reader.Close();
                                MessageBox.Show("Product not found in the products table.");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction in case of an error
                            transaction.Rollback();
                            MessageBox.Show("Error updating product quantity: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }
    else
    {
        MessageBox.Show("Please select a row to delete.");
    }



/*
            if (cartDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = cartDataGridView.SelectedRows[0];
                string barcode = selectedRow.Cells["Barcode"].Value.ToString(); // Assuming "Barcode" is the name of the column
                int quantity = Convert.ToInt32(selectedRow.Cells["QTY"].Value); // Assuming "QTY" is the name of the column

                // Query to retrieve the current quantity of the product based on the barcode
                string query = "SELECT QTY FROM products WHERE Barcode = @Barcode";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                cmd.Parameters.AddWithValue("@Barcode", barcode);

                try
                {

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
                        string tempQuery = "SELECT * FROM temproducts WHERE Barcodet = @Barcodet";
                        SqlCommand tempCmd = new SqlCommand(tempQuery, dbConnection.con);
                        tempCmd.Parameters.AddWithValue("@Barcodet", barcode);
                        SqlDataReader tempReader = tempCmd.ExecuteReader();

                        if (tempReader.Read())
                        {
                            // Product found in temproducts table
                            string productKey = tempReader["Product_Keyt"].ToString();
                            string productName = tempReader["Product_Descriptiont"].ToString();
                            string category = tempReader["Categoryt"].ToString();
                            DateTime stockInDate = Convert.ToDateTime(tempReader["Stock_In_Datet"]);
                            decimal price = Convert.ToDecimal(tempReader["Pricet"]);
                            decimal proCostAmount = Convert.ToDecimal(tempReader["Pro_CostAmountt"]);
                            decimal totalCostAmount = Convert.ToDecimal(tempReader["Total_CostAmountt"]);
                            string grn = tempReader["GRN_NO_"].ToString(); 
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

                            // Optionally, delete the product from temproducts table if no longer needed
                            string deleteTempQuery = "DELETE FROM temproducts WHERE Barcodet = @Barcodets";
                            SqlCommand deleteTempCmd = new SqlCommand(deleteTempQuery, dbConnection.con);
                            deleteTempCmd.Parameters.AddWithValue("@Barcodets", barcode);
                            deleteTempCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // Product not found in both tables
                            tempReader.Close();
                            MessageBox.Show("Error: Product not found in both products and temproducts tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Remove the selected row from the cart DataGridView
                    cartDataGridView.Rows.RemoveAt(selectedRow.Index);
                    MessageBox.Show("Item removed from cart and product quantity updated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing item from cart: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
*/


        }

        private void btn_removeall_Click(object sender, EventArgs e)
        {
            /*
            if (cartDataGridView.Rows.Count > 0)
            {
                try
                {
                    // Start a transaction to ensure data integrity
                    using (SqlTransaction transaction = dbConnection.con.BeginTransaction())
                    {
                        foreach (DataGridViewRow row in cartDataGridView.Rows)
                        {
                            if (row.Cells["Barcode"].Value != null)
                            {
                                string barcode = row.Cells["Barcode"].Value.ToString(); // Assuming "Barcode" is the name of the column
                                int quantity = Convert.ToInt32(row.Cells["QTY"].Value); // Assuming "QTY" is the name of the column

                                // Query to retrieve the current quantity of the product based on the barcode
                                string query = "SELECT QTY FROM products WHERE Barcode = @Barcode";
                                SqlCommand cmd = new SqlCommand(query, dbConnection.con, transaction);
                                cmd.Parameters.AddWithValue("@Barcode", barcode);

                                // Execute the query to get the current quantity
                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                {
                                    // Product found in products table
                                    int currentQty = Convert.ToInt32(result);
                                    int newQty = currentQty + quantity;

                                    // Retrieve the current unit cost
                                    string unitCostQuery = "SELECT Pro_CostAmount FROM products WHERE Barcode = @Barcode";
                                    SqlCommand unitCostCmd = new SqlCommand(unitCostQuery, dbConnection.con, transaction);
                                    unitCostCmd.Parameters.AddWithValue("@Barcode", barcode);
                                    object unitCostResult = unitCostCmd.ExecuteScalar();

                                    if (unitCostResult != null)
                                    {
                                        decimal unitCost = Convert.ToDecimal(unitCostResult);
                                        decimal newTotalCostAmount = unitCost * newQty;

                                        // Update the quantity and total cost amount in the products table
                                        string updateQuery = "UPDATE products SET QTY = @NewQty, Total_CostAmount = @NewTotalCostAmount WHERE Barcode = @Barcode";
                                        SqlCommand updateCmd = new SqlCommand(updateQuery, dbConnection.con, transaction);
                                        updateCmd.Parameters.AddWithValue("@NewQty", newQty);
                                        updateCmd.Parameters.AddWithValue("@NewTotalCostAmount", newTotalCostAmount);
                                        updateCmd.Parameters.AddWithValue("@Barcode", barcode);
                                        updateCmd.ExecuteNonQuery();
                                    }
                                }

                                else
                                {
                                    // Product not found in products table, check in temproducts table
                                    string tempQuery = "SELECT * FROM temproducts WHERE Barcodet = @Barcodetss";
                                    SqlCommand tempCmd = new SqlCommand(tempQuery, dbConnection.con, transaction);
                                    tempCmd.Parameters.AddWithValue("@Barcodetss", barcode);
                                    SqlDataReader tempReader = tempCmd.ExecuteReader();

                                    if (tempReader.Read())
                                    {
                                        // Product found in temproducts table
                                        string productKey = tempReader["Product_Keyt"].ToString();
                                        string productName = tempReader["Product_Descriptiont"].ToString();
                                        string category = tempReader["Categoryt"].ToString();
                                        DateTime stockInDate = Convert.ToDateTime(tempReader["Stock_In_Datet"]);
                                        decimal price = Convert.ToDecimal(tempReader["Pricet"]);
                                        decimal proCostAmount = Convert.ToDecimal(tempReader["Pro_CostAmountt"]);
                                        decimal totalCostAmount = Convert.ToDecimal(tempReader["Total_CostAmountt"]);
                                        string grn = tempReader["GRN_NO_"].ToString(); 
                                        // Close the reader before executing another command
                                        tempReader.Close();

                                        // Insert the product back into products table with the quantity from the cart
                                        string insertQuery = "INSERT INTO products (Barcode, Product_Key, Product_Description, Category, Stock_In_Date, QTY, Price, Pro_CostAmount, Total_CostAmount, GRN_NO) " +
                                                             "VALUES (@Barcode, @ProductKey, @ProductDescription, @Category, @StockInDate, @Qty, @Price, @Pro_CostAmount, @TotalCostAmount, @GRN_NO)";
                                        SqlCommand insertCmd = new SqlCommand(insertQuery, dbConnection.con, transaction);
                                        insertCmd.Parameters.AddWithValue("@Barcode", barcode);
                                        insertCmd.Parameters.AddWithValue("@ProductKey", productKey);
                                        insertCmd.Parameters.AddWithValue("@ProductDescription", productName);
                                        insertCmd.Parameters.AddWithValue("@Category", category);
                                        insertCmd.Parameters.AddWithValue("@StockInDate", stockInDate);
                                        insertCmd.Parameters.AddWithValue("@Qty", quantity);
                                        insertCmd.Parameters.AddWithValue("@Price", price);
                                        insertCmd.Parameters.AddWithValue("@Pro_CostAmount", proCostAmount);
                                        insertCmd.Parameters.AddWithValue("@TotalCostAmount", totalCostAmount);
                                        insertCmd.Parameters.AddWithValue("@GRN_NO", grn); 
                                        insertCmd.ExecuteNonQuery();

                                        // Optionally, delete the product from temproducts table if no longer needed
                                        string deleteTempQuery = "DELETE FROM temproducts WHERE Barcodet = @Barcodet";
                                        SqlCommand deleteTempCmd = new SqlCommand(deleteTempQuery, dbConnection.con, transaction);
                                        deleteTempCmd.Parameters.AddWithValue("@Barcodet", barcode);
                                        deleteTempCmd.ExecuteNonQuery();
                                    }

                                    else
                                    {
                                        // Product not found in both tables
                                        tempReader.Close();
                                        MessageBox.Show("Error: Product not found in both products and temproducts tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }

                        // Commit the transaction
                        transaction.Commit();
                        MessageBox.Show("All items removed from cart and product quantities updated.");

                        // Clear the cart DataGridView
                        cartDataGridView.Rows.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product quantities: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("The cart is already empty.");
            }*/

            if (cartDataGridView.Rows.Count > 0)
            {
                try
                {
                    Dbconnection dbConnection = new Dbconnection();
                    using (SqlConnection connection = dbConnection.GetConnections())
                    {
                        connection.Open();
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                foreach (DataGridViewRow row in cartDataGridView.Rows)
                                {
                                    if (row.Cells["QTY"].Value == null || row.Cells["barcode"].Value == null)
                                    {
                                        MessageBox.Show("Row contains null values. Please check the cart data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        continue;
                                    }

                                    // Get the quantity and product key from the current row
                                    int quantity = Convert.ToInt32(row.Cells["QTY"].Value); // Replace "QTY" with your actual column name
                                    string productKey = row.Cells["barcode"].Value.ToString(); // Replace "barcode" with your actual column name

                                    // Retrieve the current quantity and cost amount from the products table
                                    string selectQuery = "SELECT QTY, Pro_CostAmount FROM products WHERE Product_Key = @ProductKey";
                                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection, transaction);
                                    selectCommand.Parameters.AddWithValue("@ProductKey", productKey);

                                    SqlDataReader reader = selectCommand.ExecuteReader();

                                    if (reader.Read())
                                    {
                                        int currentQty = Convert.ToInt32(reader["QTY"]);
                                        decimal proCostAmount = Convert.ToDecimal(reader["Pro_CostAmount"]);
                                        reader.Close();

                                        // Calculate the new quantity and total cost amount
                                        int newQty = currentQty + quantity;
                                        decimal newTotalCostAmount = newQty * proCostAmount;

                                        // Update the products table
                                        string updateQuery = "UPDATE products SET QTY = @NewQty, Total_CostAmount = @NewTotalCostAmount WHERE Product_Key = @ProductKey";
                                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                                        updateCommand.Parameters.AddWithValue("@NewQty", newQty);
                                        updateCommand.Parameters.AddWithValue("@NewTotalCostAmount", newTotalCostAmount);
                                        updateCommand.Parameters.AddWithValue("@ProductKey", productKey);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        reader.Close();
                                        MessageBox.Show("Product not found in the products table for Product Key: " + productKey);
                                    }
                                }

                                // Commit the transaction
                                transaction.Commit();

                                // Clear all rows from the cartDataGridView
                                cartDataGridView.Rows.Clear();
                                MessageBox.Show("Cart cleared and product quantities updated successfully.");
                            }
                            catch (Exception ex)
                            {
                                // Rollback the transaction in case of an error
                                transaction.Rollback();
                                MessageBox.Show("Error updating product quantities: " + ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No items in the cart to clear.");
            }

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            /* 

               string currentDate = DateTime.ParseExact(txt_datecurr.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
               string billNumber = txt_billno.Text;

               // Assuming dbConnection.con is a valid SqlConnection object
               try
               {
                   foreach (DataGridViewRow row in cartDataGridView.Rows)
                   {
                       if (!row.IsNewRow)  // Skip the new row at the end of the DataGridView
                       {
                           string barcode = row.Cells["Barcode"].Value != null ? row.Cells["Barcode"].Value.ToString() : "";
                           string productName = row.Cells["Product_Description"].Value != null ? row.Cells["Product_Description"].Value.ToString() : "";
                           decimal unitPrice = row.Cells["Price"].Value != null ? Convert.ToDecimal(row.Cells["Price"].Value) : 0;
                           int quantity = row.Cells["QTY"].Value != null ? Convert.ToInt32(row.Cells["QTY"].Value) : 0;
                           decimal totalAmount = row.Cells["TotalAmount"].Value != null ? Convert.ToDecimal(row.Cells["TotalAmount"].Value) : 0;

                           // Insert the product into the cart table
                           string insertQuery = "INSERT INTO cart (Bill_NO, Barcode, Date, Product_Description, Price, QTY, TotalAmount) VALUES (@Bill_NO, @Barcode, @Date, @Product_Description, @Price, @QTY, @TotalAmount)";
                           SqlCommand insertCmd = new SqlCommand(insertQuery, dbConnection.con);

                           insertCmd.Parameters.AddWithValue("@Bill_NO", billNumber);
                           insertCmd.Parameters.AddWithValue("@Barcode", barcode);
                           insertCmd.Parameters.AddWithValue("@Date", currentDate);
                           insertCmd.Parameters.AddWithValue("@Product_Description", productName);
                           insertCmd.Parameters.AddWithValue("@Price", unitPrice);
                           insertCmd.Parameters.AddWithValue("@QTY", quantity);
                           insertCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                           // Execute the insert query
                           insertCmd.ExecuteNonQuery();

                           // Add item to the shopping cart list
                           shopingcart.Add(new ShoppingCartItem
                           {
                               ItemName = productName,
                               Qty = quantity,
                               Price = unitPrice
                           });
                       }

                   }
                   salseDB();
                   cartDataGridView.Rows.Clear();
                   SaveLastInvoiceNumber();
                   // Print the bill
                   printDialog1.Document = printDocument1;
                   if (printDialog1.ShowDialog() == DialogResult.OK)
                   {
                       printDocument1.Print();
                   }

                   txt_TotalQty.Text = "";
                   txt_billamount.Text = "";
                   txt_discount.Text = "";
                   txt_payamount.Text = "";
                   txt_netbill.Text = "";
                   txt_balance.Text = "";


               }
               catch (Exception ex)
               {
                   MessageBox.Show("Error adding cart items to the cart table: " + ex.Message);
               }*/

            string currentDate = DateTime.ParseExact(txt_datecurr.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string billNumber = txt_billno.Text;

            // Assuming dbConnection.con is a valid SqlConnection object
            try
            {
                foreach (DataGridViewRow row in cartDataGridView.Rows)
                {
                    if (!row.IsNewRow)  // Skip the new row at the end of the DataGridView
                    {
                        string barcode = row.Cells["Barcode"].Value != null ? row.Cells["Barcode"].Value.ToString() : "";
                        string productName = row.Cells["Product_Description"].Value != null ? row.Cells["Product_Description"].Value.ToString() : "";
                        decimal unitPrice = row.Cells["Price"].Value != null ? Convert.ToDecimal(row.Cells["Price"].Value) : 0;
                        int quantity = row.Cells["QTY"].Value != null ? Convert.ToInt32(row.Cells["QTY"].Value) : 0;
                        decimal totalAmount = row.Cells["TotalAmount"].Value != null ? Convert.ToDecimal(row.Cells["TotalAmount"].Value) : 0;

                        // Insert the product into the cart table
                        string insertCartQuery = "INSERT INTO cart (Bill_NO, Barcode, Date, Product_Description, Price, QTY, TotalAmount) VALUES (@Bill_NO, @Barcode, @Date, @Product_Description, @Price, @QTY, @TotalAmount)";
                        using (SqlCommand insertCartCmd = new SqlCommand(insertCartQuery, dbConnection.con))
                        {
                            insertCartCmd.Parameters.AddWithValue("@Bill_NO", billNumber);
                            insertCartCmd.Parameters.AddWithValue("@Barcode", barcode);
                            insertCartCmd.Parameters.AddWithValue("@Date", currentDate);
                            insertCartCmd.Parameters.AddWithValue("@Product_Description", productName);
                            insertCartCmd.Parameters.AddWithValue("@Price", unitPrice);
                            insertCartCmd.Parameters.AddWithValue("@QTY", quantity);
                            insertCartCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                            // Execute the insert query for the cart table
                            insertCartCmd.ExecuteNonQuery();
                        }

                        // Get additional product details from the products table
                        string selectProductQuery = "SELECT Product_Key, Category, Stock_In_Date, Pro_CostAmount, GRN_NO FROM products WHERE Barcode = @Barcode";
                        using (SqlCommand selectProductCmd = new SqlCommand(selectProductQuery, dbConnection.con))
                        {
                            selectProductCmd.Parameters.AddWithValue("@Barcode", barcode);

                            using (SqlDataReader reader = selectProductCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string productKey = reader["Product_Key"].ToString();
                                    string category = reader["Category"].ToString();
                                    decimal proCostAmount = Convert.ToDecimal(reader["Pro_CostAmount"]);
                                    string grnno = reader["GRN_NO"].ToString();
                                    string stockdate = reader["Stock_In_Date"].ToString();
                                    decimal totalcost = quantity * proCostAmount;

                                    reader.Close();  // Ensure the reader is closed before opening a new command

                                    // Insert the product into the temproducts table
                                    string insertTemproductsQuery = "INSERT INTO temproducts (Barcodet, Product_Keyt, Product_Descriptiont, Categoryt, Stock_In_Datet, QTYt, Pricet, Pro_CostAmountt, Total_CostAmountt, GRN_NO_, Cus_Bill_No, Sold_Date) VALUES (@Barcodet, @Product_Keyt, @Product_Descriptiont, @Categoryt, @Stock_In_Datet, @QTYt, @Pricet, @Pro_CostAmountt, @Total_CostAmountt, @GRN_No, @Cus_Bill_No, @Sold_Date)";
                                    using (SqlCommand insertTemproductsCmd = new SqlCommand(insertTemproductsQuery, dbConnection.con))
                                    {
                                        insertTemproductsCmd.Parameters.AddWithValue("@Barcodet", barcode);
                                        insertTemproductsCmd.Parameters.AddWithValue("@Product_Keyt", productKey);
                                        insertTemproductsCmd.Parameters.AddWithValue("@Product_Descriptiont", productName);
                                        insertTemproductsCmd.Parameters.AddWithValue("@Categoryt", category);
                                        insertTemproductsCmd.Parameters.AddWithValue("@Stock_In_Datet", stockdate);
                                        insertTemproductsCmd.Parameters.AddWithValue("@QTYt", quantity);
                                        insertTemproductsCmd.Parameters.AddWithValue("@Pricet", unitPrice);
                                        insertTemproductsCmd.Parameters.AddWithValue("@Pro_CostAmountt", proCostAmount);
                                        insertTemproductsCmd.Parameters.AddWithValue("@Total_CostAmountt", totalcost);
                                        insertTemproductsCmd.Parameters.AddWithValue("@GRN_No", grnno); // Adjust accordingly if you have this value
                                        insertTemproductsCmd.Parameters.AddWithValue("@Cus_Bill_No", billNumber); 
                                        insertTemproductsCmd.Parameters.AddWithValue("@Sold_Date", currentDate);

                                        // Execute the insert query for the temproducts table
                                        insertTemproductsCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        // Add item to the shopping cart list
                        shopingcart.Add(new ShoppingCartItem
                        {
                            ItemName = productName,
                            Qty = quantity,
                            Price = unitPrice
                        });
                    }
                }

                salseDB();
                cartDataGridView.Rows.Clear();
                SaveLastInvoiceNumber();

                string deleteZeroQtyProductsQuery = "DELETE FROM products WHERE QTY = 0";
                using (SqlCommand deleteZeroQtyProductsCmd = new SqlCommand(deleteZeroQtyProductsQuery, dbConnection.con))
                {
                    deleteZeroQtyProductsCmd.ExecuteNonQuery();
                }

                // Print the bill
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }

                txt_TotalQty.Text = "";
                txt_billamount.Text = "";
                txt_discount.Text = "";
                txt_payamount.Text = "";
                txt_netbill.Text = "";
                txt_balance.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding cart items to the cart and temproducts tables: " + ex.Message);
            }


        }
        private List<ShoppingCartItem> shopingcart = new List<ShoppingCartItem>();


        public void SaveLastInvoiceNumber()
        {

            try
            {
                String billno = txt_billno.Text;

                string query = "UPDATE billno SET val = @val WHERE exid = 1";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                cmd.Parameters.AddWithValue("@val", billno);

               // dbConnection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
               // dbConnection.Close();

                if (rowsAffected > 0)
                {
                   // MessageBox.Show(" successfully");
                    
                }
                else
                {
                    MessageBox.Show("No rows were updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating value: " + ex.Message);
            }

            DataLoadBillno();
        }

        

        public void DataLoadBillno()
        {
            try
            {
                string query = "SELECT val FROM billno WHERE exid = 1";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);

               // dbConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string val = reader["val"].ToString();
                    txt_billno.Text = val;
                }
                else
                {
                    MessageBox.Show("No data found for exid = 1");
                }

                reader.Close();
                // dbConnection.Close();
                // plus new invoice
                if (int.TryParse(txt_billno.Text, out int i))
                {
                    i++;
                    txt_billno.Text = i.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }

        }


        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchByBarcode();
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            netamountcal();
        }

        private void txt_discount_Click(object sender, EventArgs e)
        {
            txt_discount.Text = "";
        }

        private void txt_payamount_TextChanged(object sender, EventArgs e)
        {
            calbalance();
        }

        private void txt_payamount_Click(object sender, EventArgs e)
        {
            txt_payamount.Text = "";
        }

        public void netamountcal()
        {
            try
            {
                decimal billamount, discountamount;
                if (decimal.TryParse(txt_billamount.Text, out billamount))
                {
                    if (!string.IsNullOrWhiteSpace(txt_discount.Text))
                    {
                        decimal.TryParse(txt_discount.Text, out discountamount);
                    }
                    else
                    {
                        discountamount = 0;
                        
                    }

                    decimal netamount = billamount - discountamount;
                    txt_netbill.Text = netamount.ToString();
                }
                /*else
                {
                    MessageBox.Show("Please enter a valid numeric value for Bill Amount.");
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }



        }
        public void calbalance()
        {
            try
            {
                decimal paidamount, balance, netbill;
                if (decimal.TryParse(txt_netbill.Text, out netbill))
                {
                    if (decimal.TryParse(txt_payamount.Text, out paidamount))
                    {
                        balance = paidamount - netbill;
                        txt_balance.Text = balance.ToString();
                    }
                   
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating remaining amount: " + ex.Message);
            }


        }

        public void salseDB()
        {
            try
            {
                string bill_no = txt_billno.Text;
                DateTime date = DateTime.ParseExact(txt_datecurr.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string totqty = txt_TotalQty.Text;
                string tot_bil = txt_billamount.Text;
                string discountedbillAmount = txt_netbill.Text;
                string blnc = txt_balance.Text;

                double tot=Convert.ToDouble(txt_netbill.Text);
                double pid = Convert.ToDouble(txt_payamount.Text);
                /*     if (!double.TryParse(txt_netbill.Text, out double tot))
                     {
                         MessageBox.Show("Invalid value for net bill amount.");
                         return;
                     }

                     if (!double.TryParse(txt_payamount.Text, out double pid))
                     {
                         MessageBox.Show("Invalid value for pay amount.");
                         return;
                     }*/

                string discount = txt_discount.Text;
                string status = null;
                if (pid == 0.0)
                {
                    status = "UnPaid";
                    //setcreditcusData();
                }
                else if (tot > pid)
                {
                    status = "Partial";
                    // setcreditcusData();
                }
                else if (tot <= pid)
                {
                    status = "Paid";
                }

                    string query = "INSERT INTO sales (Bill_NO ,Date , Total_Qty, Total_Bill,Discount, Discounted_Bill_Amount, Status, Balance) VALUES (@Bill_NO ,@Date , @Total_Qty, @Total_Bill,@Discount, @Discounted_Bill_Amount, @Status, @Balance)";
                    SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                    cmd.Parameters.AddWithValue("@Bill_NO", bill_no);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Total_Qty", totqty);
                    cmd.Parameters.AddWithValue("@Total_Bill", tot_bil);
                    cmd.Parameters.AddWithValue("@Discount", discount);
                    cmd.Parameters.AddWithValue("@Discounted_Bill_Amount", discountedbillAmount);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Balance", blnc);

                    cmd.ExecuteNonQuery();
                MessageBox.Show(" successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            



        }

        private void txt_barcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Define fonts
            /*
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            Font regularFont = new Font("Arial", 8, FontStyle.Regular);

            // Calculate center position for the text
            string header = "**** T&S MOTORS ****";
            string address = "Colombo, Nugegoda";

            // Measure the size of the header text
            SizeF headerSize = e.Graphics.MeasureString(header, boldFont);
            SizeF addressSize = e.Graphics.MeasureString(address, regularFont);

            // Calculate positions
            float headerX = (e.PageBounds.Width - headerSize.Width) / 2;
            float addressX = (e.PageBounds.Width - addressSize.Width) / 2;

            // Draw header and address
            e.Graphics.DrawString(header, boldFont, Brushes.Black, new PointF(headerX, 60));
            e.Graphics.DrawString(address, regularFont, Brushes.Black, new PointF(addressX, 80));
            e.Graphics.DrawString("_____________________________________________", regularFont, Brushes.Black, new Point(18, 100));

            // Draw date and bill number
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), regularFont, Brushes.Black, new Point(18, 120));
            e.Graphics.DrawString("Bill No: " + txt_billno.Text.Trim(), regularFont, Brushes.Black, new Point(18, 140));

            e.Graphics.DrawString("___________________________________________", regularFont, Brushes.Black, new Point(18, 160));

            // Draw column headers
            e.Graphics.DrawString("Item Name", regularFont, Brushes.Black, new Point(18, 180));
            e.Graphics.DrawString("Unit Price", regularFont, Brushes.Black, new Point(170, 180));
            e.Graphics.DrawString("Quantity", regularFont, Brushes.Black, new Point(110, 180));
            e.Graphics.DrawString("Total", regularFont, Brushes.Black, new Point(230, 180));

            e.Graphics.DrawString("_____________________________________________", regularFont, Brushes.Black, new Point(18, 200));

            // Draw items
            int y = 218;
            foreach (var item in shopingcart)
            {
                e.Graphics.DrawString(item.ItemName, regularFont, Brushes.Black, new Point(18, y));
                e.Graphics.DrawString(item.Price.ToString("F2"), regularFont, Brushes.Black, new Point(180, y));
                e.Graphics.DrawString(item.Qty.ToString(), regularFont, Brushes.Black, new Point(140, y));
                e.Graphics.DrawString(item.Total.ToString("F2"), regularFont, Brushes.Black, new Point(240, y));
                y += 18;
            }

            // Draw total amount
            e.Graphics.DrawString("_____________________________________________", regularFont, Brushes.Black, new Point(25, y));
            e.Graphics.DrawString("Total Amount: " + txt_billamount.Text.Trim(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(120, y + 20));
            e.Graphics.DrawString("Discount: " + txt_discount.Text.Trim(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(120, y + 40));
            e.Graphics.DrawString("Net Bill Amount: " + txt_netbill.Text.Trim(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(120, y + 60));
          
            e.Graphics.DrawString("******** Thank You ********", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(160, y + 80));
            */
            /*
            // Define fonts
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            Font regularFont = new Font("Arial", 8, FontStyle.Regular);

            // Calculate center position for the text
            string header = "**** T&S MOTORS ****";
            string address = "Colombo, Nugegoda";

            // Measure the size of the header text
            SizeF headerSize = e.Graphics.MeasureString(header, boldFont);
            SizeF addressSize = e.Graphics.MeasureString(address, regularFont);

            // Calculate positions
            float headerX = (e.PageBounds.Width - headerSize.Width) / 2;
            float addressX = (e.PageBounds.Width - addressSize.Width) / 2;

            // Draw header and address
            e.Graphics.DrawString(header, boldFont, Brushes.Black, new PointF(headerX, 60));
            e.Graphics.DrawString(address, regularFont, Brushes.Black, new PointF(addressX, 80));
            e.Graphics.DrawString("_____________________________________________", regularFont, Brushes.Black, new Point(18, 100));

            // Draw date and bill number
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), regularFont, Brushes.Black, new Point(18, 120));
            e.Graphics.DrawString("Bill No: " + txt_billno.Text.Trim(), regularFont, Brushes.Black, new Point(18, 140));

            e.Graphics.DrawString("___________________________________________", regularFont, Brushes.Black, new Point(18, 160));

            // Draw column headers
            e.Graphics.DrawString("Item Name", regularFont, Brushes.Black, new Point(18, 180));
            e.Graphics.DrawString("Unit Price", regularFont, Brushes.Black, new Point(170, 180));
            e.Graphics.DrawString("Quantity", regularFont, Brushes.Black, new Point(110, 180));
            e.Graphics.DrawString("Total", regularFont, Brushes.Black, new Point(230, 180));

            e.Graphics.DrawString("_____________________________________________", regularFont, Brushes.Black, new Point(18, 200));

            // Draw items
            int y = 218;
            foreach (var item in shopingcart)
            {
                e.Graphics.DrawString(item.ItemName, regularFont, Brushes.Black, new Point(18, y));
                e.Graphics.DrawString(item.Price.ToString("F2"), regularFont, Brushes.Black, new Point(180, y));
                e.Graphics.DrawString(item.Qty.ToString(), regularFont, Brushes.Black, new Point(140, y));
                e.Graphics.DrawString(item.Total.ToString("F2"), regularFont, Brushes.Black, new Point(240, y));
                y += 18;
            }

            // Draw total amount
            e.Graphics.DrawString("_____________________________________________", regularFont, Brushes.Black, new Point(25, y));
            e.Graphics.DrawString("Total Amount: " + txt_billamount.Text.Trim(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(120, y + 20));
            e.Graphics.DrawString("Discount: " + txt_discount.Text.Trim(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(120, y + 40));
            e.Graphics.DrawString("Net Bill Amount: " + txt_netbill.Text.Trim(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(120, y + 60));

            // Calculate the size of the "Thank You" text and center it
            string thankYouText = "******** Thank You ********";
            SizeF thankYouSize = e.Graphics.MeasureString(thankYouText, new Font("Arial", 8, FontStyle.Bold));
            float thankYouX = (e.PageBounds.Width - thankYouSize.Width) / 2;

            // Draw the "Thank You" text
            e.Graphics.DrawString(thankYouText, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new PointF(thankYouX, y + 120));
            */
            
            // Define fonts
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            Font regularFont = new Font("Arial", 8, FontStyle.Regular);

            // Retrieve saved text from the database
            (string header, string address) = GetHeaderAndAddressText();

            // Calculate center position for the text
            // Measure the size of the header and address text
            SizeF headerSize = e.Graphics.MeasureString(header, boldFont);
            SizeF addressSize = e.Graphics.MeasureString(address, regularFont);

            // Calculate positions
            float headerX = (e.PageBounds.Width - headerSize.Width) / 2;
            float addressX = (e.PageBounds.Width - addressSize.Width) / 2;

            // Draw header and address
            e.Graphics.DrawString(header, boldFont, Brushes.Black, new PointF(headerX, 60));
            e.Graphics.DrawString(address, regularFont, Brushes.Black, new PointF(addressX, 80));
            e.Graphics.DrawString("_____________________________________________", regularFont, Brushes.Black, new Point(18, 100));

            // Draw date and bill number
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), regularFont, Brushes.Black, new Point(18, 120));
            e.Graphics.DrawString("Bill No: " + txt_billno.Text.Trim(), regularFont, Brushes.Black, new Point(18, 140));

            e.Graphics.DrawString("___________________________________________", regularFont, Brushes.Black, new Point(18, 160));

            // Draw column headers
            e.Graphics.DrawString("Item Name", regularFont, Brushes.Black, new Point(18, 180));
            e.Graphics.DrawString("Unit Price", regularFont, Brushes.Black, new Point(170, 180));
            e.Graphics.DrawString("Quantity", regularFont, Brushes.Black, new Point(110, 180));
            e.Graphics.DrawString("Total", regularFont, Brushes.Black, new Point(230, 180));

            e.Graphics.DrawString("_____________________________________________", regularFont, Brushes.Black, new Point(18, 200));

            // Draw items
            int y = 218;
            foreach (var item in shopingcart)
            {
                e.Graphics.DrawString(item.ItemName, regularFont, Brushes.Black, new Point(18, y));
                e.Graphics.DrawString(item.Price.ToString("F2"), regularFont, Brushes.Black, new Point(180, y));
                e.Graphics.DrawString(item.Qty.ToString(), regularFont, Brushes.Black, new Point(140, y));
                e.Graphics.DrawString(item.Total.ToString("F2"), regularFont, Brushes.Black, new Point(240, y));
                y += 18;
            }

            // Draw total amount
            e.Graphics.DrawString("_____________________________________________", regularFont, Brushes.Black, new Point(25, y));
            e.Graphics.DrawString("Total Amount: " + txt_billamount.Text.Trim(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(120, y + 20));
            e.Graphics.DrawString("Discount: " + txt_discount.Text.Trim(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(120, y + 40));
            e.Graphics.DrawString("Net Bill Amount: " + txt_netbill.Text.Trim(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(120, y + 60));

            // Calculate the size of the "Thank You" text and center it
            string thankYouText = "******** Thank You ********";
            SizeF thankYouSize = e.Graphics.MeasureString(thankYouText, new Font("Arial", 8, FontStyle.Bold));
            float thankYouX = (e.PageBounds.Width - thankYouSize.Width) / 2;

            // Draw the "Thank You" text
            e.Graphics.DrawString(thankYouText, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new PointF(thankYouX, y + 120));

        }

        public Image GetLogoImage()
        {
            Dbconnection dbConnection = new Dbconnection();
            byte[] logoBytes = null;

            string query = "SELECT  PhotoData FROM Photos WHERE Id = 6"; // Adjust the query as per your table structure

            using (SqlConnection conn = dbConnection.GetConnections())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    logoBytes = reader[" PhotoData"] as byte[];
                }

                reader.Close();
            }

            if (logoBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(logoBytes))
                {
                    return Image.FromStream(ms);
                }
            }

            return null;
        }


        public (string, string) GetHeaderAndAddressText()
        {
            Dbconnection dbConnection = new Dbconnection();
            string headerText = "";
            string addressText = "";

            string query = "SELECT Text, addresstext FROM SavedText WHERE Id = 1";

            using (SqlConnection conn = dbConnection.GetConnections())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    headerText = reader["Text"].ToString();
                    addressText = reader["addresstext"].ToString();
                }

                reader.Close();
            }

            return (headerText, addressText);
        }

        public void setQtyProduct()
        {
            string productKey = txt_barcode.Text;
            int currentQty = int.Parse(txt_availableqty.Text);
            int qty = int.Parse(txt_qty.Text);

            Dbconnection dbConnection = new Dbconnection();
            using (SqlConnection conn = dbConnection.GetConnections())
            {
                conn.Open();

                SqlCommand command = new SqlCommand($"SELECT QTY FROM products WHERE Product_Key = '{productKey}'", conn);
                int qtyFromDatabase = (int)command.ExecuteScalar();

                if (currentQty > qty)
                {
                    int newQty = qtyFromDatabase - qty;
                    command = new SqlCommand($"UPDATE products SET QTY = {newQty} WHERE Product_Key = '{productKey}'", conn);
                    command.ExecuteNonQuery();
                }
                else if (currentQty == qty)
                {
                    command = new SqlCommand($"DELETE FROM products WHERE Product_Key = '{productKey}'", conn);
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Error: Current quantity is less than the required quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
