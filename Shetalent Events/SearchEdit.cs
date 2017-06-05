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
    public partial class SearchEdit : Form
    {   
        //declaring the connection string in the app.config using the config mgr     
        string conStr = ConfigurationManager.ConnectionStrings["SheEvt"].ConnectionString;

        //List<DGVClass> DGV = new List<DGVClass>();
        //gridViewPrintReportFrom gvrpt = new gridViewPrintReportFrom(); 

       
        public SearchEdit()
        {
            InitializeComponent();
        }

        
        private void Reset()
        {
            evenTypeComboBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dateTimeTextBox.Text = "";
            numberOfGuestTextBox.Text = "";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.Text = "";
            zipTextBox.Text = "";
            salesAmountTextBox.Text = "";
            bookedTimeLabel.Text = "";
            lotNumberLabel.Text = "";
            totalAmtLabel.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
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

        private void displayAllButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from BookedEventTable", con);
                    //reads the data from the database with the command query
                    SqlDataReader rdr = cmd.ExecuteReader();


                    ////binding the grid view
                    //BindingSource source = new BindingSource();
                    //source.DataSource = rdr;

                    //eventDataGridView.DataSource = source;


                    ////this is a code for populating the data on the grid view using the class
                    BindingList<DGVClass> allBookedEvents = new BindingList<DGVClass>();

                    while (rdr.Read())
                    {
                        DGVClass bookedEvent = new DGVClass();
                        bookedEvent.LotNumber = (string)rdr["LotNumber"];
                        bookedEvent.FirstName = (string)rdr["FirstName"];
                        bookedEvent.LastName = (string)rdr["LastName"];
                        bookedEvent.EventType = (string)rdr["EventType"];
                        bookedEvent.DateTimeOfEvent = Convert.ToDateTime(rdr["DateTimeOfEvent"]);
                        bookedEvent.NumberOfGuest = (int)rdr["NumberOfGuest"];
                        bookedEvent.Street = (string)rdr["Street"];
                        bookedEvent.City = (string)rdr["City"];
                        bookedEvent.State = (string)rdr["States"];
                        bookedEvent.Zip = int.Parse((string)rdr["Zip"]);
                        bookedEvent.SalesAmount = (decimal)rdr["SalesAmount"];
                        bookedEvent.DateTimeBooked = Convert.ToDateTime(rdr["DateTimeBooked"]);
                        bookedEvent.AmountOwed = (decimal)rdr["AmountOwed"];
                        allBookedEvents.Add(bookedEvent);
                    }

                    //binding the grid view
                    eventDataGridView.DataSource = allBookedEvents;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }               
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("EventInsertUpdate", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@mode", "edit");
                    cmd.Parameters.AddWithValue("@LotNumber", lotNumberLabel.Text);
                    cmd.Parameters.AddWithValue("@EventType", eventTypeComboBox.Text);
                    cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateTimeOfEvent", dateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@NumberOfGuests", numberOfGuestTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Street", streetTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@City", cityTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@State", stateComboBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Zip", zipTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sales_Amount", salesAmountTextBox.Text);
                    cmd.Parameters.AddWithValue("@DateTimeBooked", DateTime.Now);
                    cmd.Parameters.AddWithValue("@AmountOwed", totalAmtLabel.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }             
         }
    

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete?", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand cmd = new SqlCommand("DeleteEvent", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@lotNumber", lotNumberLabel.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully");
                        //calls the reset method to empty the text boxes
                        Reset();
                    }                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }                
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EventPage evt = new EventPage();
            evt.ShowDialog();
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //if any row is double clicked, displays the information on the row
            //of that data grid view on the assigned text boxes
            if (eventDataGridView.CurrentRow.Index != -1)
            {
                //displays the data double clicked on the grid view on the controls
                lotNumberLabel.Text = eventDataGridView.CurrentRow.Cells[0].Value.ToString();
                firstNameTextBox.Text = eventDataGridView.CurrentRow.Cells[1].Value.ToString();
                lastNameTextBox.Text = eventDataGridView.CurrentRow.Cells[2].Value.ToString();
                evenTypeComboBox.Text = eventDataGridView.CurrentRow.Cells[3].Value.ToString();
                dateTimeTextBox.Text = eventDataGridView.CurrentRow.Cells[4].Value.ToString();
                numberOfGuestTextBox.Text = eventDataGridView.CurrentRow.Cells[5].Value.ToString();
                streetTextBox.Text = eventDataGridView.CurrentRow.Cells[6].Value.ToString();
                cityTextBox.Text = eventDataGridView.CurrentRow.Cells[7].Value.ToString();
                stateComboBox.Text = eventDataGridView.CurrentRow.Cells[8].Value.ToString();
                zipTextBox.Text = eventDataGridView.CurrentRow.Cells[9].Value.ToString();
                salesAmountTextBox.Text = eventDataGridView.CurrentRow.Cells[10].Value.ToString();
                bookedTimeLabel.Text = eventDataGridView.CurrentRow.Cells[11].Value.ToString();
                //totalAmtLabel.Text = eventDataGridView.CurrentRow.Cells[12].Value.ToString();
            }
        }

        
        private void eventDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hti = eventDataGridView.HitTest(e.X, e.Y);
                eventDataGridView.Rows[hti.RowIndex].Selected = true;
                OptionsContextMenuStrip.Show(eventDataGridView, e.X, e.Y);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    if (eventDataGridView.CurrentRow.Index != -1)
                    {
                        if (MessageBox.Show("Are you sure you want to delete?", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (con.State == ConnectionState.Closed)
                                con.Open();
                            SqlCommand cmd = new SqlCommand("DeleteEvent", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@lotNumber", lotNumberLabel.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted Successfully");
                            //calls the reset method to empty the text boxes
                            Reset();
                        }
                    }                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Assign()
        {
            //DGVClass dgv = new DGVClass();

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
            ////dgv.agent = ;
        }

        private void eventDataGridView_Click(object sender, EventArgs e)
        {
            if (eventDataGridView.CurrentRow.Index != -1)
            {
                msgLabel.Text = "double click on the row to make changes";                
            }
        }
        

        private void printButton_Click(object sender, EventArgs e)
        {

            //gridViewPrintReportFrom form = new gridViewPrintReportFrom();

            //form.ShowDialog();
            try
            {
                List<DGVClass> list = dGVClassBindingSource.DataSource as List<DGVClass>;

                using (gridViewPrintReportFrom form = new gridViewPrintReportFrom(list))
                {
                    form.ShowDialog();
                }

                //if (list != null)
                //{
                //    using (gridViewPrintReportFrom form = new gridViewPrintReportFrom(list))
                //    {
                //        form.ShowDialog();
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //printDocument.Print();
        }

        private List<DataColumnCollection> data = new List<DataColumnCollection>();

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.calender;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);

            e.Graphics.DrawString("Event Number:  " + lotNumberLabel.Text,
               new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 180));
            e.Graphics.DrawString("Date Booked:   " + bookedTimeLabel.Text,
               new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 210));

            e.Graphics.DrawString
                ("---------------------------------------------------------------------------------------------------",
               new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 240));
            e.Graphics.DrawString("Client Name:   " + firstNameTextBox.Text.Trim() + " " + lastNameTextBox.Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));
            e.Graphics.DrawString("Date of event:   " + dateTimeTextBox.Text,
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString("Number of Guests:   " + numberOfGuestTextBox.Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 330));
            e.Graphics.DrawString("Venue:   " + streetTextBox.Text.Trim() + " " + cityTextBox.Text.Trim() + ","
                + stateComboBox.Text.Trim() + zipTextBox.Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 360));
            e.Graphics.DrawString("Sold Item:   " + salesAmountTextBox.Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 400));

            e.Graphics.DrawString
               ("---------------------------------------------------------------------------------------------------",
              new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 570));
            e.Graphics.DrawString("Total Amount Due:   " + totalAmtLabel.Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 600));
        }

        private void printPreviewButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
    }

        
    }

