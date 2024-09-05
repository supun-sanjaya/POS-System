using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS_SYSTEM
{
    public partial class Add_Users : Form
    {
        private Dbconnection dbConnection;
        private string queryusers = "SELECT * FROM addusers";

        public Add_Users()
        {
            InitializeComponent();
            dbConnection = new Dbconnection();
            LoadDataUsers();
        }
        private void LoadDataUsers()
        {
            DataTable dataTable = dbConnection.ExecuteQuery(queryusers);
            db_usersview.DataSource = dataTable;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            try
            {
               // dbConnection.Open();

                String nic = txt_nic.Text;
                string name = txt_name.Text;
                String address = txt_address.Text;
                string contact = txt_tp.Text;
                string position = com_position.SelectedItem.ToString();
                String username = txt_username.Text;
                string password = txt_password.Text;

                string query = "INSERT INTO addusers (NIC_Number,Name_,Address_,Contact,Position,Username,Password) VALUES (@NIC_Number,@Name_,@Address_,@Contact,@Position,@Username,@Password)";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                cmd.Parameters.AddWithValue("@NIC_Number", nic);
                cmd.Parameters.AddWithValue("@Name_", name);
                cmd.Parameters.AddWithValue("@Address_", address);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@Position", position);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User Inserted Successfully!");
                LoadDataUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting Data: " + ex.Message);
            }
            finally
            {
               // dbConnection.Close();
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string nic = txt_nic.Text;
                string name = txt_name.Text;
                string address = txt_address.Text;
                string contact = txt_tp.Text;
                string position = com_position.SelectedItem.ToString();
                String username = txt_username.Text;
                string password = txt_password.Text;

                string query = "UPDATE addusers SET Name_ = @Name_, Address_ = @Address_, Contact = @Contact, Position = @Position, Username = @Username, Password = @Password WHERE NIC_Number = @NIC_Number ";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                cmd.Parameters.AddWithValue("@NIC_Number", nic);
                cmd.Parameters.AddWithValue("@Name_", name);
                cmd.Parameters.AddWithValue("@Address_", address);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@Position", position);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                //dbConnection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                //dbConnection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User Updated Successfully!");
                    LoadDataUsers();
                    // Reload the data in the DataGridView if needed
                }
                else
                {
                    MessageBox.Show("User Not Found or Not Updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Data: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming your DataGridView is named dataGridView1 and the primary key column in your table is named ID
                int selectedRowIndex = db_usersview.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = db_usersview.Rows[selectedRowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["NIC_Number"].Value);

                string query = "DELETE FROM addusers WHERE NIC_Number = @NIC_Number";
                SqlCommand cmd = new SqlCommand(query, dbConnection.con);
                cmd.Parameters.AddWithValue("@NIC_Number", id);

                //dbConnection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                //dbConnection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User Deleted Successfully!");
                    LoadDataUsers();
                    // Reload the data in the DataGridView if needed
                }
                else
                {
                    MessageBox.Show("User Not Found or Not Deleted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Deleting Data: " + ex.Message);
            }
        }

        private void db_usersview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = db_usersview.Rows[e.RowIndex];
                txt_nic.Text = row.Cells["NIC_Number"].Value.ToString();
                txt_name.Text = row.Cells["Name_"].Value.ToString();
                txt_address.Text = row.Cells["Address_"].Value.ToString();
                txt_tp.Text = row.Cells["Contact"].Value.ToString();
                com_position.SelectedItem = row.Cells["Position"].Value.ToString();
                txt_username.Text = row.Cells["Username"].Value.ToString();
                txt_password.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void Add_Users_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in db_usersview.Columns)
            {
                column.HeaderCell.Style.Font = new Font(db_usersview.Font, FontStyle.Bold);
                
            }

        }

        private void com_position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
