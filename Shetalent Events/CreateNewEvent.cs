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
using System.Globalization;
using System.Configuration;

namespace Shetalent_Events
{
    public partial class CreateNewEvent : Form
    {
        //keep this app.conf connection string
        //"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShetalentEventData.mdf;Integrated Security=True"
        //<add name="SheEvt" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ejiof\Documents\My Projects\Shetalent Events\Shetalent Events\ShetalentEventData 1.mdf;Integrated Security=True;Connect Timeout=30" />

        //select top 1 * from BookedEventTable order by DateTimeBooked desc

        EventClass eventClass = new EventClass();

        EventPage eventPage = new EventPage();

        EventReportForm evtrpt = new EventReportForm();

        string conStr = ConfigurationManager.ConnectionStrings["SheEvt"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        string lot;

        public CreateNewEvent()
        {
            InitializeComponent();
            
        }

        private string EventNumber(string eventType)
        {
            //method that formats the lot number
            string eventNumber;
            eventNumber = eventType.Substring(0, 2) + lot;
            return eventNumber;
        }

        private void GetEventInfo(EventClass info)
        {
            //if else statement to select the event type
            //from the radio button
            if (weddingRadioButton.Checked)
            {
                info.EventType = "Wedding";
            }
            else if (birthdayRadioButton.Checked)
            {
                info.EventType = "Birthday";
            }
            else if (bridalShowerRadioButton.Checked)
            {
                info.EventType = "Bridal Shower";
            }
            else if (babyShowerRadioButton.Checked)
            {
                info.EventType = "BabyShower";
            }
            else if (anniversaryRadioButton.Checked)
            {
                info.EventType = "Anniversary";
            }
            else
            {
                MessageBox.Show("An Event must be checked");                
            }


        }

        private void Reset()
        {
            //removes the text in the controls
            eventTypeLabel.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            numberOfGuestTextBox.Text = "";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.Text = "";
            zipTextBox.Text = "";
            salesAmountTextBox.Text = "";
            LotNumberLabel.Text = "";
            costOutputLabel.Text = "";
            noneRadioButton.Checked = true;

            //changes the text on the button back
            confirmEventButton.Text = "Confirm Event";
        }

        private void confirmEventButton_Click(object sender, EventArgs e)
        {
            //ReportForm report = new ReportForm();

            //assigning variables for the text boxes and others
            int guestNum;
            decimal salesAmt;
            string FName = firstNameTextBox.Text.Trim();
            string LName = lastNameTextBox.Text.Trim();
            string Str = streetTextBox.Text.Trim();
            string City = cityTextBox.Text.Trim();
            string State = stateComboBox.Text.Trim();
            int Zip;
            string date = dateTimePicker.Value.ToString();
            bool isValid = true;            //variable that checks for inputs in text boxes 

            if (int.TryParse(numberOfGuestTextBox.Text.Trim(), out guestNum))
            {
                //getting the guest number and setting a condition for the number of guests
                if (guestNum > 100 || guestNum < 20)
                {
                    isValid = false;
                    Guestlabel.Text = "Sorry we can only accomodate 20 to 100 guests";
                    numberOfGuestTextBox.Text = "";
                    numberOfGuestTextBox.Focus();
                }
                else
                {
                    //if the guest number is within range, assign the number to the guest class
                    eventClass.Guest = guestNum;
                    Guestlabel.Text = "";
                }
            }
            else
            {
                Guestlabel.Text = "How many guests is needed?";
            }

            if (decimal.TryParse(salesAmountTextBox.Text.Trim(), out salesAmt))
            {
                //getting amount of items sold
                eventClass.Sales = salesAmt;
            }

            //getting all the values from the controls. to make sure that the 
            //not null informations are provided
            if (FName == "")
            {
                isValid = false;
                fnlabel.Text = "first name is needed";
            }
            else
            {
                eventClass.FirstName = FName;
                fnlabel.Text = "";
            }
            
            if (LName == string.Empty)
            {
                isValid = false;
                LNlabel.Text = "last Name is required";
            }
            else
            {
                eventClass.LastName = LName;
                LNlabel.Text = "";
            }

           
            if (Str == string.Empty)
            {
                isValid = false;
                STlabel.Text = "Street Name is required";
            }
            else
            {
                STlabel.Text = "";
                eventClass.Street = Str;
            }

            
            if (City == string.Empty)
            {
                isValid = false;
                Citylabel.Text = "City Name is required";
            }
            else
            {
                eventClass.City = City;
                Citylabel.Text = "";
            }

            
            if (State == string.Empty)
            {
                isValid = false;
                stateLabel.Text = "The State Name is required";
            }
            else
            {
                stateLabel.Text = "";
                eventClass.State = State;
            }

            
            if (int.TryParse(zipTextBox.Text.Trim(), out Zip))
            {
                eventClass.Zip = Zip;
                ziplabel.Text = "";
            }
            else
            {
                isValid = false;
                ziplabel.Text = "Zip code is required";
            }

            
            if (dateTimePicker.Value == null)
            {
                isValid = false;
                dtlabel.Text = "An event date needs to be selected";
            }
            else
            {
                eventClass.EventDate = dateTimePicker.Value;
                dtlabel.Text = "";
            }

            //

            if (noneRadioButton.Checked)
            {
                MessageBox.Show("An Event must be checked");
            }
            else
            {
                //this happens when all the informations are provided
                if (isValid == true)
                {
                    if (confirmEventButton.Text == "Confirm Event")
                    {
                        //calling the methods that gets information from the event class
                        GetEventInfo(eventClass);

                        //getting the type of event to be used as a parameter to 
                        //be passed to the eventNumber method for the lot number
                        string eventTypes = eventClass.EventType; 
                                               
                        eventTypeLabel.Text = eventClass.EventType;
                        LotNumberLabel.Text = EventNumber(eventTypes);
                        salesAmountTextBox.Text = eventClass.Sales.ToString("c");
                        numberOfGuestTextBox.Text = eventClass.Guest.ToString();
                        costOutputLabel.Text = eventClass.GetTotal.ToString("c");

                        //changes the text in the button
                        confirmEventButton.Text = "Book Event";
                    }
                    else
                    {
                        string conStr = ConfigurationManager.ConnectionStrings["SheEvt"].ConnectionString;

                        using (SqlConnection con = new SqlConnection(conStr))
                        {
                            try
                            {
                                if (con.State == ConnectionState.Closed)
                                    //opens the connection                
                                    con.Open();

                                //executing the query in the sql command class using
                                //the stored procedure, setting the connection to it
                                SqlCommand cmd = new SqlCommand("EventInsertUpdate", con);

                                cmd.CommandType = CommandType.StoredProcedure;

                                //adding values from the text box to the command parameters
                                cmd.Parameters.AddWithValue("@mode", "add");
                                cmd.Parameters.AddWithValue("@LotNumber", LotNumberLabel.Text);
                                cmd.Parameters.AddWithValue("@EventType", eventTypeLabel.Text);
                                cmd.Parameters.AddWithValue("@FirstName", eventClass.FirstName);
                                cmd.Parameters.AddWithValue("@LastName", eventClass.LastName);
                                cmd.Parameters.AddWithValue("@DateTimeOfEvent", eventClass.EventDate);
                                cmd.Parameters.AddWithValue("@NumberOfGuests", eventClass.Guest.ToString());
                                cmd.Parameters.AddWithValue("@Street", eventClass.Street);
                                cmd.Parameters.AddWithValue("@City", eventClass.City);
                                cmd.Parameters.AddWithValue("@State", eventClass.State);
                                cmd.Parameters.AddWithValue("@Zip", eventClass.Zip.ToString());
                                cmd.Parameters.AddWithValue("@Sales_Amount", salesAmountTextBox.Text.ToString());
                                cmd.Parameters.AddWithValue("@DateTimeBooked", eventClass.BookedDate);
                                cmd.Parameters.AddWithValue("@AmountOwed", eventClass.GetTotal.ToString("c"));

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("The event is booked");

                                evtrpt.ShowDialog();
                                this.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }

                else
                {
                    isValid = false;
                }
                
            }
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            eventPage.ShowDialog();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //removes the text in the controls
            eventTypeLabel.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            numberOfGuestTextBox.Text = "";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.Text = "";
            zipTextBox.Text = "";
            salesAmountTextBox.Text = "";
            LotNumberLabel.Text = "";
            costOutputLabel.Text = "";
            noneRadioButton.Checked = true;
        }

        private void CreateNewEvent_Load(object sender, EventArgs e)
        {
            //the last inserted row in the lot number column in the 
            //database is retrieved on the page load        
            con = new SqlConnection(conStr);
            cmd = new SqlCommand("select top 1 LotNumber from BookedEventTable order by DateTimeBooked desc", con);
            con.Open();
            dr = cmd.ExecuteReader();
           
            if (dr.Read())
            {
                //the first two sub strings are removed because they are strings
                //and then the rest is incremented in each event booked
                string lastBookedLotNumber = dr.GetValue(0).ToString();
                int lastLotNumber = int.Parse(lastBookedLotNumber.Substring(2));
                lastLotNumber++;
                lot = lastLotNumber.ToString();
                
            }
            else
            {
                //if there is record in the row. 1000 is retrieved
                lot = 1000.ToString();
            }
            con.Close();

        }

        private void PrintPreview()
        {
            //calling the print document formatted for the print preview 
            EvtPrintPreviewDialog.Document = EPrintDocument;
            
            EvtPrintPreviewDialog.ShowDialog();
        }

        private void Print()
        {
            //to print the document
            evtPrintDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //print preview design format on the booked event
            e.Graphics.DrawString("Event Number:  " + LotNumberLabel.Text,
               new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 180));
            e.Graphics.DrawString("Date Booked:   " + DateTime.Now,
               new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 210));

            e.Graphics.DrawString
                ("---------------------------------------------------------------------------------------------------",
               new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 240));
            e.Graphics.DrawString("Client Name:   " + firstNameTextBox.Text.Trim() + " " + lastNameTextBox.Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));
            e.Graphics.DrawString("Date of event:   " + dateTimePicker.Value,
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString("Number of Guests:   " + numberOfGuestTextBox.Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 330));
            e.Graphics.DrawString("Venue:   " + streetTextBox.Text.Trim() +  " " + cityTextBox.Text.Trim() + "," 
                + stateComboBox.Text.Trim() + zipTextBox.Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 360));
            e.Graphics.DrawString("Sold Item:   " + salesAmountTextBox.Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 400));

            e.Graphics.DrawString
               ("---------------------------------------------------------------------------------------------------",
              new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 570));
            e.Graphics.DrawString("Total Amount Due:   " + costOutputLabel.Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 600));
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            evtrpt.ShowDialog();
        }

        private void makeSalesButton_Click(object sender, EventArgs e)
        {
            SalesForm form = new SalesForm();
            form.ShowDialog();
        }
    }
  }

