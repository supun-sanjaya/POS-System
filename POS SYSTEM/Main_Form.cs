using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace POS_SYSTEM
{
    public partial class Main_Form : Form
    {
        
        public Main_Form()
        {
            InitializeComponent();
            /*_username = username; // Store the username in a private field
            lblUsername.Text = (string)_username;*/
        }

        public Main_Form(string dbUsername)
        {
            this.dbUsername = dbUsername;
            //DisplayLoggedInUser();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            if (dashboardPanel.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                dashboardPanel.Controls.Clear();
            }

            // Create a new instance of the form
            Dashboard_Form x = new Dashboard_Form();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            dashboardPanel.Controls.Add(x);

            // Display the form
            x.Show();
            DisplayLoggedInUser();
            //sidebarTransition.Start();
           
        }
        bool sidebarEpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarEpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 57)
                {
                    sidebarEpand = false;
                    sidebarTransition.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 196)
                {
                    sidebarEpand = true;
                    sidebarTransition.Stop();
                }
            }

          


        }

        private void btn_expnd_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
            DisplayLoggedInUser();
        }
        

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            btn_addproduct.BackColor = Color.FromArgb(40, 79, 79);
            btn_cashier.BackColor = Color.FromArgb(23, 24, 29);
            btn_dashboard.BackColor = Color.FromArgb(23, 24, 29);
            btn_setting.BackColor = Color.FromArgb(23, 24, 29);
            btn_Stock.BackColor = Color.FromArgb(23, 24, 29);
            btn_adduser.BackColor = Color.FromArgb(23, 24, 29);
            btn_report.BackColor = Color.FromArgb(23, 24, 29);
            btn_logout.BackColor = Color.FromArgb(23, 24, 29);
            btn_returnitem.BackColor = Color.FromArgb(23, 24, 29);

            if (dashboardPanel.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                dashboardPanel.Controls.Clear();
            }

            // Create a new instance of the form
            addproduct x = new addproduct();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            dashboardPanel.Controls.Add(x);

            // Display the form
            x.Show();

            //sidebarTransition.Start();
            if (sidebar.Width == 196)
            {
                sidebarTransition.Start();
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {
            btn_addproduct.BackColor = Color.FromArgb(23, 24, 29);
            btn_cashier.BackColor = Color.FromArgb(40, 79, 79);
            btn_dashboard.BackColor = Color.FromArgb(23, 24, 29);
            btn_setting.BackColor = Color.FromArgb(23, 24, 29);
            btn_Stock.BackColor = Color.FromArgb(23, 24, 29);
            btn_adduser.BackColor = Color.FromArgb(23, 24, 29);
            btn_report.BackColor = Color.FromArgb(23, 24, 29);
            btn_logout.BackColor = Color.FromArgb(23, 24, 29);
            btn_returnitem.BackColor = Color.FromArgb(23, 24, 29);

            if (dashboardPanel.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                dashboardPanel.Controls.Clear();
            }

            // Create a new instance of the form
            CashierForm x = new CashierForm();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            dashboardPanel.Controls.Add(x);

            // Display the form
            x.Show();

            // sidebarTransition.Start();

            if (sidebar.Width == 196)
            {
                sidebarTransition.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_addproduct.BackColor = Color.FromArgb(23, 24, 29);
            btn_cashier.BackColor = Color.FromArgb(23, 24, 29);
            btn_dashboard.BackColor = Color.FromArgb(23, 24, 29);
            btn_setting.BackColor = Color.FromArgb(40, 79, 79);
            btn_Stock.BackColor = Color.FromArgb(23, 24, 29);
            btn_adduser.BackColor = Color.FromArgb(23, 24, 29);
            btn_report.BackColor = Color.FromArgb(23, 24, 29);
            btn_logout.BackColor = Color.FromArgb(23, 24, 29);
            btn_returnitem.BackColor = Color.FromArgb(23, 24, 29);

            if (dashboardPanel.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                dashboardPanel.Controls.Clear();
            }

            // Create a new instance of the form
            Settings_Form x = new Settings_Form();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            dashboardPanel.Controls.Add(x);

            // Display the form
            x.Show();
            // sidebarTransition.Start();
            if (sidebar.Width == 196)
            {
                sidebarTransition.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_addproduct.BackColor = Color.FromArgb(23, 24, 29);
            btn_cashier.BackColor = Color.FromArgb(23, 24, 29);
            btn_dashboard.BackColor = Color.FromArgb(23, 24, 29);
            btn_setting.BackColor = Color.FromArgb(23, 24, 29);
            btn_Stock.BackColor = Color.FromArgb(23, 24, 29);
            btn_adduser.BackColor = Color.FromArgb(23, 24, 29);
            btn_report.BackColor = Color.FromArgb(23, 24, 29);
            btn_logout.BackColor = Color.FromArgb(40, 79, 79);

            LOGIN loginform = new LOGIN();
            loginform.Show();
            UpdateLogoutDetails();
            this.Hide();
        }
        public void UpdateLogoutDetails()
        {
            Dbconnection dbConnection = new Dbconnection();
            SqlConnection connection = dbConnection.GetConnections();
            try
            {
                connection.Open();

                string username = lblUsername.Text; // You should replace this with the actual username
                DateTime loginDateTime = DateTime.Now;
                string logoutDate = loginDateTime.ToString("yyyy-MM-dd");
                string logoutTimeString = loginDateTime.ToString("HH:mm:ss");

                string query = "UPDATE login_logs SET logout_date = @logout_date, logout_time = @logout_time WHERE username = @username AND logout_date IS NULL";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@logout_date", logoutDate);
                cmd.Parameters.AddWithValue("@logout_time", logoutTimeString);
                cmd.Parameters.AddWithValue("@username", username);

                cmd.ExecuteNonQuery();

                //Console.WriteLine("Logout information saved successfully.");
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

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            btn_addproduct.BackColor = Color.FromArgb(23, 24, 29);
            btn_cashier.BackColor = Color.FromArgb(23, 24, 29);
            btn_dashboard.BackColor = Color.FromArgb(40, 79, 79);
            btn_setting.BackColor = Color.FromArgb(23, 24, 29);
            btn_Stock.BackColor = Color.FromArgb(23, 24, 29);
            btn_adduser.BackColor = Color.FromArgb(23, 24, 29);
            btn_report.BackColor = Color.FromArgb(23, 24, 29);
            btn_logout.BackColor = Color.FromArgb(23, 24, 29);
            btn_returnitem.BackColor = Color.FromArgb(23, 24, 29);
            //sidebarTransition.Start();
           
            if (dashboardPanel.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                dashboardPanel.Controls.Clear();
            }

            // Create a new instance of the form
            Dashboard_Form x = new Dashboard_Form();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            dashboardPanel.Controls.Add(x);

            // Display the form
            x.Show();

            if(sidebar.Width==196)
            {
                sidebarTransition.Start();
            }
            
            

        }
        public void clickbuttonExpandSidebar()
        {
            

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateLogoutDetails();
            this.Close();            
        }

        bool isMaximized = false;
        int originalWidth = 1118;
        int originalHeight = 620;

        int sidebarOriginalHeight = 620;
        int sidebarMaximizedHeight;
        private object _username;
        private object username;
        private string dbUsername;

        private void button2_Click_1(object sender, EventArgs e)
        {
            

        }
       
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
         
        }
        

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
              
        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void sidebarbuttontimer_Tick(object sender, EventArgs e)
        {
            
                
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn_addproduct.BackColor = Color.FromArgb(23, 24, 29);
            btn_cashier.BackColor = Color.FromArgb(23, 24, 29);
            btn_dashboard.BackColor = Color.FromArgb(23, 24, 29);
            btn_setting.BackColor = Color.FromArgb(23, 24, 29);
            btn_Stock.BackColor = Color.FromArgb(40, 79, 79);
            btn_adduser.BackColor = Color.FromArgb(23, 24, 29);
            btn_report.BackColor = Color.FromArgb(23, 24, 29);
            btn_logout.BackColor = Color.FromArgb(23, 24, 29);
            btn_returnitem.BackColor = Color.FromArgb(23, 24, 29);

            //sidebarTransition.Start();

            if (dashboardPanel.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                dashboardPanel.Controls.Clear();
            }
            
            // Create a new instance of the form
            StockForm x = new StockForm();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            dashboardPanel.Controls.Add(x);

            // Display the form
            x.Show();

            if (sidebar.Width == 196)
            {
                sidebarTransition.Start();
            }
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            btn_addproduct.BackColor = Color.FromArgb(23, 24, 29);
            btn_cashier.BackColor = Color.FromArgb(23, 24, 29);
            btn_dashboard.BackColor = Color.FromArgb(23, 24, 29);
            btn_setting.BackColor = Color.FromArgb(23, 24, 29);
            btn_Stock.BackColor = Color.FromArgb(23, 24, 29);
            btn_adduser.BackColor = Color.FromArgb(40, 79, 79);
            btn_report.BackColor = Color.FromArgb(23, 24, 29);
            btn_logout.BackColor = Color.FromArgb(23, 24, 29);
            btn_returnitem.BackColor = Color.FromArgb(23, 24, 29);

            if (dashboardPanel.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                dashboardPanel.Controls.Clear();
            }

            // Create a new instance of the form
            Add_Users x = new Add_Users();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            dashboardPanel.Controls.Add(x);

            // Display the form
            x.Show();
            // sidebarTransition.Start();
            if (sidebar.Width == 196)
            {
                sidebarTransition.Start();
            }

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            btn_addproduct.BackColor = Color.FromArgb(23, 24, 29);
            btn_cashier.BackColor = Color.FromArgb(23, 24, 29);
            btn_dashboard.BackColor = Color.FromArgb(23, 24, 29);
            btn_setting.BackColor = Color.FromArgb(23, 24, 29);
            btn_Stock.BackColor = Color.FromArgb(23, 24, 29);
            btn_adduser.BackColor = Color.FromArgb(23, 24, 29);
            btn_report.BackColor = Color.FromArgb(40, 79, 79);
            btn_logout.BackColor = Color.FromArgb(23, 24, 29);
            btn_returnitem.BackColor = Color.FromArgb(23, 24, 29);

            if (dashboardPanel.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                dashboardPanel.Controls.Clear();
            }

            ReportForm x = new ReportForm();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            dashboardPanel.Controls.Add(x);

            // Display the form
            x.Show();

            // sidebarTransition.Start();

            if (sidebar.Width == 196)
            {
                sidebarTransition.Start();
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }
        public void DisplayLoggedInUser()
        {
            try
            {
                Dbconnection dbConnection = new Dbconnection();
                using (SqlConnection connection = dbConnection.GetConnections())
                {
                    string query = "SELECT TOP 1 username FROM login_logs WHERE logout_time IS NULL ORDER BY login_date DESC, login_time DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string username = reader["username"].ToString();
                            lblUsername.Text = username;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the logged-in user: " + ex.Message);
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
            DisplayLoggedInUser();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            btn_addproduct.BackColor = Color.FromArgb(23, 24, 29);
            btn_cashier.BackColor = Color.FromArgb(23, 24, 29);
            btn_dashboard.BackColor = Color.FromArgb(23, 24, 29);
            btn_setting.BackColor = Color.FromArgb(23, 24, 29);
            btn_Stock.BackColor = Color.FromArgb(23, 24, 29);
            btn_adduser.BackColor = Color.FromArgb(23, 24, 29);
            btn_report.BackColor = Color.FromArgb(23, 24, 29);
            btn_logout.BackColor = Color.FromArgb(23, 24, 29);
            btn_returnitem.BackColor = Color.FromArgb(40, 79, 79);

            if (dashboardPanel.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                dashboardPanel.Controls.Clear();
            }

            // Create a new instance of the form
            ReturnItem x = new ReturnItem();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            dashboardPanel.Controls.Add(x);

            // Display the form
            x.Show();
            //sidebarTransition.Start();
            if (sidebar.Width == 196)
            {
                sidebarTransition.Start();
            }

            string usernamelb = lblUsername.Text;
              Dbconnection dbConnection = new Dbconnection();
              SqlConnection conn = dbConnection.GetConnections();

              
               string query = "SELECT * FROM addusers WHERE Username = @username";

              SqlCommand cmd = new SqlCommand(query, dbConnection.con);
              cmd.Parameters.AddWithValue("@username", usernamelb);

              SqlDataReader reader = cmd.ExecuteReader();
              if (reader.Read())
              {
                  string position = reader["Position"].ToString();
                  if (position == "Admin")
                  {
                     x.btn_updatere.Visible = true;
                  }
                  else
                  {
                     x.btn_updatere.Visible = false;
                  }
              }
              reader.Close();

            



        }
    }
}
