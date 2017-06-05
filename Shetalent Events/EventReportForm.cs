using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Configuration;


namespace Shetalent_Events
{
    public partial class EventReportForm : Form
    {
        ReportDocument rptdoc = new ReportDocument();

        public EventReportForm()
        {
            InitializeComponent();
        }

        private void EventReportForm_Load(object sender, EventArgs e)
        {
            rptdoc.Load(@"C:\Users\ejiof\Documents\My Projects\Shetalent Events\Shetalent Events\EventCrystalReport.rpt");

            string conStr = ConfigurationManager.ConnectionStrings["SheEvt"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter("EventReport", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new System.Data.DataSet();
                sda.Fill(ds, "EventData");
                rptdoc.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rptdoc;
            }
        }
    }
}
