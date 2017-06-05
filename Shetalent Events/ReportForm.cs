using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Shetalent_Events
{
    public partial class ReportForm : Form
    {
        CreateNewEvent create = new CreateNewEvent();

        EventClass evt = new EventClass();

        //EventBookedCrystalReport1 cryrpt = new EventBookedCrystalReport1();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["SheEvt"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select top 1 * from BookedEventTable order by DateTimeBooked desc", con);
                DataSet dst = new DataSet();
                //EventDataSet dst = new EventDataSet();
                sda.Fill(dst, "BookedEventTable");
                //cryrpt.Load(@"C: \Users\ejiof\Documents\My Projects\Shetalent Events\Shetalent Events\EventDataSet.xsd");
                //cryrpt.SetDataSource(dst);
                //crystalReportViewer1.ReportSource = cryrpt;
                //crystalReportViewer1.Refresh();
            }
            //    eventBookedCrystalReport11.SetParameterValue("pFirstName", evt.FirstName);
            //eventBookedCrystalReport11.SetParameterValue("pLastName", evt.LastName);
            //eventBookedCrystalReport11.SetParameterValue("pEventType", evt.EventType);
            //eventBookedCrystalReport11.SetParameterValue("pLotNumber", evt.EventNumber);
            //eventBookedCrystalReport11.SetParameterValue("pDateOfEvent", evt.EventDate);
            //eventBookedCrystalReport11.SetParameterValue("pState", evt.State);
            //eventBookedCrystalReport11.SetParameterValue("pStreet", evt.Street);
            //eventBookedCrystalReport11.SetParameterValue("pCity", evt.City);
            //eventBookedCrystalReport11.SetParameterValue("pZip", evt.Zip);
            //eventBookedCrystalReport11.SetParameterValue("pTotal", evt.GetTotal);
            //eventBookedCrystalReport11.SetParameterValue("pDateBooked", evt.BookedDate);
            //eventBookedCrystalReport11.SetParameterValue("pNoOfGuest", evt.Guest);
        }
    }
}
