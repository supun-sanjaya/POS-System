using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;



namespace POS_SYSTEM
{
    public partial class Dashboard_Form : Form
    {
        private List<string> items = new List<string>();
        private int currentIndex = 0;

        private Timer refreshTimer;
        private Timer displayTimer;

        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void SavePhotoPath(string photoPath)
        {
            Properties.Settings.Default.PhotoPath = photoPath;
            Properties.Settings.Default.Save();
        }
       

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {           
            loadImage();
            loadText();

            /*  timer1.Interval = 5000; // Check every 5 seconds
              timer1.Tick += timer1_Tick;
              timer1.Start();*/

            /* refreshTimer = new Timer();
             refreshTimer.Interval =  1000; // 5 minutes in milliseconds
             refreshTimer.Tick += timer1_Tick;
             refreshTimer.Start();*/

            displayTimer = new Timer();
            displayTimer.Interval = 5 * 1000; // 5 seconds in milliseconds
            displayTimer.Tick += DisplayTimer_Tick;
            displayTimer.Start();

        }
        public void loadText()
        {
            Dbconnection dbConnection = new Dbconnection();
            using (SqlConnection conn = dbConnection.GetConnections())
            {
                conn.Open();
                string query = "SELECT TOP 1 Text FROM SavedText ORDER BY Id DESC";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    label1.Text = reader["Text"].ToString();
                }
            }

        }

        public void loadImage()
        {
            // Load photos from the database
            Dbconnection dbConnection = new Dbconnection();
            using (SqlConnection conn = dbConnection.GetConnections())
            {
                conn.Open();
                string query = "SELECT PhotoData FROM Photos";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    byte[] photoBytes = (byte[])reader["PhotoData"];

                    // Convert byte array back to Image
                    using (MemoryStream ms = new MemoryStream(photoBytes))
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(ms);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;

                        panel1.Controls.Add(pictureBox);
                    }
                }
            }

        }


        private void Dashboard_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePhotoPath(Properties.Settings.Default.PhotoPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
        private void DisplayPhotoInPanel(string photoPath)
        {
            Dbconnection dbConnection = new Dbconnection();
            using (SqlConnection conn = dbConnection.GetConnections())
            {
                conn.Open();
                string query = "SELECT PhotoData FROM Photos";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    byte[] photoBytes = (byte[])reader["PhotoData"];

                    // Convert byte array back to Image
                    using (MemoryStream ms = new MemoryStream(photoBytes))
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(ms);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;

                        panel1.Controls.Add(pictureBox);
                    }
                }
            }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshLabel()
        {
            // Clear the previous items
            label3.Text = "";
            items.Clear();

            try
            {
                Dbconnection dbConnection = new Dbconnection();
                SqlConnection conn = dbConnection.GetConnections();
                SqlCommand cmd = new SqlCommand("SELECT Product_Description, QTY FROM products WHERE QTY <=8", conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Read the items into the list
                while (reader.Read())
                {
                    items.Add($"Item: {reader["Product_Description"]}, QTY: {reader["QTY"]}");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Display the next four items or less if there are fewer remaining
            int itemsToShow = Math.Min(17, items.Count - currentIndex);
            for (int i = 0; i < itemsToShow; i++)
            {
                label3.Text += items[currentIndex] + Environment.NewLine;
                currentIndex++;
            }

            // Reset the index if all items have been displayed
            if (currentIndex >= items.Count)
            {
                currentIndex = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {           
            
            RefreshLabel();
           
        }
        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            // Stop the display timer
            displayTimer.Stop();

            // Display the details initially
            RefreshLabel();

            // Initialize the refresh timer
            refreshTimer = new Timer();
            refreshTimer.Interval = 2 * 60 * 1000; // 2 minutes in milliseconds
            refreshTimer.Tick += timer1_Tick;
            refreshTimer.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
