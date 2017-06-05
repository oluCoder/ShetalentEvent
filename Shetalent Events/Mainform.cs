using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Shetalent_Events
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void setUsernameButton_Click(object sender, EventArgs e)
        {
            //sends the user to sign up page
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Close();
        }

        //method that read the names into a list
        private void ReadNames(List<string> NameList)
        {
            try
            {
                //input file object created to open the names file
                StreamReader infile = File.OpenText("Names.txt");

                //reads the names into the list
                while (!infile.EndOfStream)
                {
                    NameList.Add(infile.ReadLine());
                }

                //closes the file
                infile.Close();

            }
            catch (Exception ex)
            {
                //catches any exception that can be caught in the file
                MessageBox.Show(ex.Message);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //declares the variable to hold the username and password
            //from the text box
            string user = usernameLoginTextBox.Text;
            string pass = passwordLoginTextBox.Text;

            //creating a variable to join the username and password input 
            //together
            string login = user + " " + pass;

            //creates a list to hold the names
            List<string> NameLists = new List<string>();

            //calling the readName method and passing the list created to it
            //which reads the names from the file into the list
            ReadNames(NameLists);

            //searches for the username and password in the list
            int position = NameLists.IndexOf(login);

            //checks if its found
            if (position != -1)
            {
                //if the username and password is found, then the 
                //event page will be open and this page will be closed
                EventPage Event = new EventPage();

                Event.ShowDialog();
                this.Close();
            }
            else
            {
                //if the username and password is not found 
                //this message displays
                MessageBox.Show("Invalid username or password");
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            //creates variables to hold username and password log in information
            string user = usernameLoginTextBox.Text;
            string pass = passwordLoginTextBox.Text;

            //conditional statements to grant access to admin button for a particular
            //username and password 

            //username to use to go to the event page          
            if (user == "oluchi")
            {
                //password to use to go to the event page
                if (pass == "1234")
                {
                    //if the username and password where typed correctly
                    //the event page will be open
                    //creates instance of the event page class
                    EventPage myEventPage = new EventPage();

                    //displays the event page
                    myEventPage.ShowDialog();
                    this.Close();
                }
                else
                {
                    //displays if the password for the admin 
                    //button is wrong, clears the text box and send the focus 
                    //back to it
                    MessageBox.Show("The password is incorrect");
                    passwordLoginTextBox.Text = "";
                    passwordLoginTextBox.Focus();
                }
            }
            else
            {
                //displays if the username for the admin 
                //button is wrong, clears the text box and send the focus 
                //back to it
                MessageBox.Show("The username is incorrect");
                usernameLoginTextBox.Text = "";
                usernameLoginTextBox.Focus();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //clears the username and password text box and sends the focus back to
            //username text box
            usernameLoginTextBox.Text = "";
            passwordLoginTextBox.Text = "";
            usernameLoginTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


