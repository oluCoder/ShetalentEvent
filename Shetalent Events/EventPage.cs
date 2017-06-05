using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Shetalent_Events
{
    public partial class EventPage : Form
    {
        //connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ejiof\Desktop\Shetalent Events\Shetalent Events\ShetalentEventData.mdf;Integrated Security=True"
           // providerName="System.Data.SqlClient" />
        EventClass eventClass = new EventClass();

        string conStr = ConfigurationManager.ConnectionStrings["SheEvt"].ConnectionString;

        private List<DGVClass> DGV = new List<DGVClass>();

        DGVClass dgv = new DGVClass();

        public EventPage()
        {
            InitializeComponent();
        }

        public void Assign()
        {
           
            //dgv.lot = eventDataGridView.CurrentRow.Cells[0].Value.ToString();
            //dgv.FN = eventDataGridView.CurrentRow.Cells[1].Value.ToString();
            //dgv.LN = eventDataGridView.CurrentRow.Cells[2].Value.ToString();
            //dgv.evType = eventDataGridView.CurrentRow.Cells[3].Value.ToString();
            //dgv.dOfEvt = eventDataGridView.CurrentRow.Cells[4].Value.ToString();
            //dgv.Nofguest = (int)eventDataGridView.CurrentRow.Cells[5].Value;
            //dgv.Str = eventDataGridView.CurrentRow.Cells[6].Value.ToString();
            //dgv.City = eventDataGridView.CurrentRow.Cells[7].Value.ToString();
            //dgv.state = eventDataGridView.CurrentRow.Cells[8].Value.ToString();
            //dgv.Zip = eventDataGridView.CurrentRow.Cells[9].Value.ToString();
            //dgv.salesAmt = (decimal)eventDataGridView.CurrentRow.Cells[10].Value;
            //dgv.DtBooked = eventDataGridView.CurrentRow.Cells[11].Value.ToString();
            //dgv.amtOwed = (decimal)eventDataGridView.CurrentRow.Cells[12].Value;
            //dgv.agent = ;
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            CreateNewEvent createNew = new CreateNewEvent();
            createNew.ShowDialog();
            
        }

        private void editEventButton_Click(object sender, EventArgs e)
        {
            SearchEdit edit = new SearchEdit();
            edit.ShowDialog();
            this.Close();
        }

        private void upcomingEventButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM BookedEventTable WHERE DateTimeOfEvent > GETDATE()", con);
                    //reads the data from the database with the command query
                    SqlDataReader rdr = cmd.ExecuteReader();
                    //binding the grid view
                    BindingSource source = new BindingSource();
                    source.DataSource = rdr;

                    eventDataGridView.DataSource = source;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }                
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //using (ShetalentEventData_1Entities db = new ShetalentEventData_1Entities())
            //{
            //    gridViewResultBindingSource.DataSource = db.EventSearch().ToList();
            //}
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    //using data adapter to retrieve info from database instead of sql 
                    //command statement. its a better practice, cos it provides us with
                    //disconnected data access model
                    SqlDataAdapter sqlDa = new SqlDataAdapter("EventSearch", con);

                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue("@eventType", eventTypeComboBox.Text);

                    //creating an instance of a dataTable, its directly mapped to the database
                    //to hold the rows and columns and stored in a block of memory
                    DataTable dTable = new DataTable();

                    //fills all the info in the data adapter to the data table
                    sqlDa.Fill(dTable);
                    //assigning the info in the data table to the dataGridview
                    eventDataGridView.DataSource = dTable;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }               
        }

        private void displayAllEventButton_Click(object sender, EventArgs e)
        {
            //using (ShetalentEventData_1Entities db = new ShetalentEventData_1Entities())
            //{
            //    gridViewResultBindingSource.DataSource = db.GridView().ToList();
            //}
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {

                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    //string query = "Select * from BookedEventTable"
                    SqlCommand cmd = new SqlCommand("Select * from BookedEventTable", con);

                    //Assign();
                    //DGV.Add(dgv);
                    //eventDataGridView.DataSource = dgv;

                    //reads the data from the database with the command query
                    SqlDataReader rdr = cmd.ExecuteReader();
                    //binding the grid view
                    BindingSource source = new BindingSource();
                    source.DataSource = rdr;

                    eventDataGridView.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void eventDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (eventDataGridView.CurrentRow.Index != -1)
            {
                infoLabel.Text = "Click the edit button to search, edit and delete event booked";
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Mainform main = new Mainform();
            main.ShowDialog();
            this.Close();
        }

        private void EventPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //List<GridView_Result> list = gridViewResultBindingSource.DataSource as List<GridView_Result>;

            //if (list != null)
            //{
            //    using (gridViewPrintReportFrom form = new gridViewPrintReportFrom(list))
            //    {
            //        form.ShowDialog();
            //    }
            //}
        }

        SalesForm sales = new SalesForm();

        private void wearsButton_Click(object sender, EventArgs e)
        {
            sales.ShowDialog();
        }

        private void jewelryButton_Click(object sender, EventArgs e)
        {
            sales.ShowDialog();
        }

        private void bakeryButton_Click(object sender, EventArgs e)
        {
            sales.ShowDialog();
        }
    }
}
