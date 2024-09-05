using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POS_SYSTEM
{
    public partial class Settings_Form : Form
    {
        public Settings_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Settings_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {/*
            Dashboard_Form x = new Dashboard_Form();
            string newText = textBox1.Text;

            Dbconnection dbConnection = new Dbconnection();
            // Set the label's text
            x.label1.Text = newText;

            // Save the text to the database
            using (SqlConnection conn = dbConnection.GetConnections())
            {
                conn.Open();
                string query = "INSERT INTO SavedText (Text) VALUES (@text)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@text", newText);
                command.ExecuteNonQuery();
                MessageBox.Show("Data added successfully");
            }*/

            Dashboard_Form x = new Dashboard_Form();
            string newText = textBox1.Text;
            string newAddressText = txt_address.Text; // Assuming you have another TextBox for the address text

            Dbconnection dbConnection = new Dbconnection();
            // Set the label's text
            x.label1.Text = newText;

            // Update the text and addresstext in the database
            using (SqlConnection conn = dbConnection.GetConnections())
            {
                conn.Open();
                string query = "UPDATE SavedText SET Text = @text, addresstext = @addresstext WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@text", newText);
                command.Parameters.AddWithValue("@addresstext", newAddressText);
                command.Parameters.AddWithValue("@id", 1); // Assuming you want to update the row with Id = 1
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data updated successfully");
                }
                else
                {
                    MessageBox.Show("No data found with the specified Id");
                }
            }



        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open file dialog to select a photo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string photoPath = openFileDialog.FileName;

                // Read the photo file into a byte array
                byte[] photoBytes = File.ReadAllBytes(photoPath);
                Dbconnection dbConnection = new Dbconnection();
                // Delete all existing photos
                using (SqlConnection conn = dbConnection.GetConnections())
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Photos";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn);
                    deleteCommand.ExecuteNonQuery();
                }

                // Save the byte array of the new photo to the database
                using (SqlConnection conn = dbConnection.GetConnections())
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Photos (PhotoData) VALUES (@photo)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
                    insertCommand.Parameters.AddWithValue("@photo", photoBytes);
                    insertCommand.ExecuteNonQuery();
                }

                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DateTime d = DateTime.Now;
            string dd = d.Day + "_" + d.Month;
            string severname = txt_server.Text;
            string dbName = "POS_SYSTEM";

            // Connection string
            string aaa = @"Data Source=" + severname + ";Initial Catalog=" + dbName + ";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(aaa))
            {
                try
                {
                    con.Open();

                    // Backup directory
                    string backupDir = @"D:\DBbackup\";
                    // Create the directory if it doesn't exist
                    if (!Directory.Exists(backupDir))
                    {
                        Directory.CreateDirectory(backupDir);
                    }

                    // Backup file path
                    string backupPath = backupDir + dbName + "_" + dd + ".Bak";

                    // Backup command
                    string backupCommand = "BACKUP DATABASE [" + dbName + "] TO DISK = '" + backupPath + "' " +
                                           "WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups', NAME = 'Full Backup of " + dbName + "';";

                    SqlCommand cmd = new SqlCommand(backupCommand, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Backup Successfully");

                    // Check if the file exists
                    if (File.Exists(backupPath))
                    {
                        MessageBox.Show("Backup file created successfully at " + backupPath);
                    }
                    else
                    {
                        MessageBox.Show("Backup command executed but file not found at " + backupPath);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    con.Close();
                }
            }


        }

        private void btn_selectparth_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\DBbackup\",
                Title = "Select Backup File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "Bak",
                Filter = "Backup files (*.Bak)|*.Bak",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_parth.Text = openFileDialog1.FileName;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            string severname = txt_server.Text;
            string dbName = "POS_SYSTEM";
            string backupPath = txt_parth.Text; // Use the selected file path

            string aaa = @"Data Source=" + severname + ";Integrated Security=True";

            using (SqlConnection con = new SqlConnection(aaa))
            {
                try
                {
                    con.Open();

                    // Restore command
                    string restoreCommand = "USE master; RESTORE DATABASE [" + dbName + "] FROM DISK = '" + backupPath + "' WITH REPLACE;";
                    SqlCommand cmd = new SqlCommand(restoreCommand, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Restore Successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_serverre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_server_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_server_Click(object sender, EventArgs e)
        {
            txt_server.Text = "";
        }

        private void txt_serverre_Click(object sender, EventArgs e)
        {
            txt_serverre.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void txt_address_Click(object sender, EventArgs e)
        {
            txt_address.Text = "";
        }
    }
}
