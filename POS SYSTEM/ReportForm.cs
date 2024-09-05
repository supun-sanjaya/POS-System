using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_StockReport_Click(object sender, EventArgs e)
        {
           if (panl_reportdashboard.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                panl_reportdashboard.Controls.Clear();
            }
            StockReport x = new StockReport();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            panl_reportdashboard.Controls.Add(x);

            
            // Display the form
            x.Show();
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panl_reportdashboard_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_salesReport_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btn_creditReport_Click(object sender, EventArgs e)
        {
            if (panl_reportdashboard.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                panl_reportdashboard.Controls.Clear();
            }
            CreditReport x = new CreditReport();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            panl_reportdashboard.Controls.Add(x);

            // Display the form
            x.Show();
            //ButtonHide();
        }

        private void btn_userlogdetails_Click(object sender, EventArgs e)
        {
            if (panl_reportdashboard.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                panl_reportdashboard.Controls.Clear();
            }
            UserLOGINDetails_Form x = new UserLOGINDetails_Form();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            panl_reportdashboard.Controls.Add(x);

            // Display the form
            x.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panl_reportdashboard.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                panl_reportdashboard.Controls.Clear();
            }
            SalesReportpre x = new SalesReportpre();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            panl_reportdashboard.Controls.Add(x);

            // Display the form
            x.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (panl_reportdashboard.Controls.Count > 0)
            {
                // Remove all controls from the dashboard panel
                panl_reportdashboard.Controls.Clear();
            }
            QtyRefillstock x = new QtyRefillstock();

            // Set the properties of the new form
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.WindowState = FormWindowState.Normal;

            // Add the form to the dashboard panel
            panl_reportdashboard.Controls.Add(x);

            // Display the form
            x.Show();
        }
    }
}
