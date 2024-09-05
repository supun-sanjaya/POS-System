using Microsoft.Reporting.WinForms;
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

namespace POS_SYSTEM
{
    public partial class UserLOGINDetails_Form : Form
    {
        public UserLOGINDetails_Form()
        {
            InitializeComponent();
        }

        private void UserLOGINDetails_Form_Load(object sender, EventArgs e)
        {
            loadreportviewer();
        }
        public void loadreportviewer()
        {
            try
            {
                Dbconnection dbConnection = new Dbconnection();
                SqlConnection con = dbConnection.GetConnections();

                SqlDataAdapter da = new SqlDataAdapter("select * from login_logs", con);
                DataSet1 ds = new DataSet1();
                da.Fill(ds, "login_logs");

                if (ds.Tables["login_logs"].Rows.Count > 0)
                {
                    ReportDataSource datasource = new ReportDataSource("DataSetuserLOGINS", ds.Tables["login_logs"]);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void btn_filterDate_Click(object sender, EventArgs e)
        {
            try
            {
                Dbconnection dbConnection = new Dbconnection();
                SqlConnection con = dbConnection.GetConnections();

                SqlDataAdapter da = new SqlDataAdapter("select * from login_logs where username='" + txt_search.Text + "' ", con);
                DataSet1 ds = new DataSet1();
                da.Fill(ds, "login_logs");

                if (ds.Tables["login_logs"].Rows.Count > 0)
                {
                    ReportDataSource datasource = new ReportDataSource("DataSetuserLOGINS", ds.Tables["login_logs"]);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);
                    this.reportViewer1.RefreshReport();              
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btn_Datesearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dateTimePickerst.Value.Date;
                Dbconnection dbConnection = new Dbconnection();
                SqlConnection conn = dbConnection.GetConnections();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM login_logs WHERE login_date = @StartDate", conn);

                // Add parameters
                da.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);

                DataSet1 ds = new DataSet1();
                da.Fill(ds, "login_logs");

                if (ds.Tables["login_logs"].Rows.Count == 0)
                {
                    MessageBox.Show("No records found for the selected date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ReportDataSource datasource = new ReportDataSource("DataSetuserLOGINS", ds.Tables["login_logs"]);

                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(datasource);
                    this.reportViewer1.RefreshReport();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadreportviewer();
        }
    }
}
