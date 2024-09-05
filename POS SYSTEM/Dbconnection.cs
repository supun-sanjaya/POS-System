using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace POS_SYSTEM
{
    internal class Dbconnection
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public DataSet da = new DataSet();
        public SqlDataAdapter ada = new SqlDataAdapter();
        public SqlDataReader dr;

        public Dbconnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
            con.ConnectionString = @"Data Source=SANJAYA;Initial Catalog=POS_SYSTEM;Integrated Security=True";
            con.Open();
            cmd.Connection = con;
        }

        internal static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=SANJAYA;Initial Catalog=POS_SYSTEM;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
               // con.Open();
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            finally
            {
               // con.Close();
            }
            return dataTable;
        }
        public SqlConnection GetConnections()
        {
            string connectionString = "Data Source=SANJAYA;Initial Catalog=POS_SYSTEM;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

    }
}
