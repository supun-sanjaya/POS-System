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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_SYSTEM
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = txt_username1.Text;
            string password = txt_password1.Text;
            string userType = com_position.SelectedItem?.ToString(); // Use ?.ToString() to handle null selection

            // Check if user has selected a position from the combobox
            if (string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Please select your position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if username and password are not empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Database connection string
            Dbconnection dbConnection = new Dbconnection();
            using (SqlConnection connection = dbConnection.GetConnections())
            {
                connection.Open();

                // Query to select user from database based on username
                string query = $"SELECT * FROM addusers WHERE Username = '{username}' AND Password = '{password}' AND Position = '{userType}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string dbPassword = reader["Password"].ToString();
                        string dbUsername = reader["Username"].ToString();

                        // Check if the password matches
                        if (password == dbPassword)
                        {
                            Main_Form mainPage = new Main_Form();
                            mainPage.Show();
                            SaveLoginDetails();

                           
                            if (com_position.SelectedIndex == 0)
                            {
                                mainPage.btn_report.Visible = false;
                                mainPage.btn_adduser.Visible = false;
                                mainPage.btn_setting.Visible = false;
                               
                            }

                            this.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
            }


        }

        

        public void SaveLoginDetails()
        {
            Dbconnection dbConnection = new Dbconnection();
            SqlConnection connection = dbConnection.GetConnections();
            try
            {
                connection.Open();

                string username = txt_username1.Text; // You should replace this with the actual username
                DateTime loginDateTime = DateTime.Now;
                string loginDate = loginDateTime.ToString("yyyy-MM-dd");
                string loginTime = loginDateTime.ToString("HH:mm:ss");

                string query = "INSERT INTO login_logs (username, login_date, login_time) VALUES (@username, @login_date, @login_time)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@login_date", loginDate);
                cmd.Parameters.AddWithValue("@login_time", loginTime);

                cmd.ExecuteNonQuery();

                //Console.WriteLine("Login information saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void com_position_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
