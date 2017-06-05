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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        //the methods are for formatting the password

        //this method accepts a string argument and returns the 
        //number of uppercase letters it contains 
        private int NumberUppercase(string str)
        {
            //the number of uppercase letters
            int upperCase = 0;

            //count the uppercase characters in str
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }
            //return the number of uppercase characters
            return upperCase;
        }

        //this method accepts a string argument and returns the 
        //number of lowercase letters it contains
        private int NumberLowerCase(string str)
        {
            //the number of lowercase letters
            int lowerCase = 0;

            //count the lowercase characters in str
            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }
            //return the number of lowercase characters
            return lowerCase;
        }

        //this method accepts a string argument and returns the 
        //number of numeric digits it contains
        private int NumberDigits(string str)
        {
            //the number of digits
            int digits = 0;

            //count the digits in str
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }
            //return the number of digits
            return digits;
        }

        //method that checks to make number is up to 10 digits and is a digit
        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10;
            bool valid = true;

            if (str.Length == VALID_LENGTH)
            {
                foreach (char ch in str)
                {
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        //method that formats the phone number
        private void PhoneFormat(ref string str)
        {
            str = str.Insert(0, "(");

            str = str.Insert(4, ")");

            str = str.Insert(8, "-");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //2 local variables for input files
                StreamWriter outputFile;
                StreamWriter outfile;

                //sets a boolean to hold when the value is valid
                bool isValid = true;

                //local variables
                string phone = phoneTextBox.Text.Trim();           //to hold the phone number
                const int MIN_LENGTH = 8;                   //to hold the length of the password
                
                string firstName = firstNameTextBox.Text.Trim();   //to hold the first name
                string lastName = lastNameTextBox.Text.Trim();     //to hold the lastName
                string username = usernameTextBox.Text.Trim();     //to hold the username
                string password = passwordTextBox.Text.Trim();     //to hold the password
                string city = cityTextBox.Text.Trim();             //to hold the city                                                
                string email = emailTextBox.Text.Trim();           //to hold the email    

                //set of if statements that makes sure that the compulsory 
                //text boxes is not empty. u can also use
                //firstName.length = 0, then isValid = false

                //this holds the firstName and an else to clear the error label
                if (firstName == "")
                {
                    isValid = false;
                    firstNameErrorMessage.Text = "FirstName is required";
                    firstNameTextBox.Focus();
                }
                else
                {
                    firstNameErrorMessage.Text = "";
                }

                //this holds the lastName and an else to clear the error label
                if (lastName == "")
                {
                    isValid = false;
                    lastNameErrorMessage.Text = "LastName is required";
                    lastNameTextBox.Focus();
                }
                else
                {
                    lastNameErrorMessage.Text = "";
                }

                //this holds the userName and an else to clear the error label
                if (username == "")
                {
                    isValid = false;
                    userNameErrorMessage.Text = "Username is required";
                    lastNameTextBox.Focus();
                }
                else
                {
                    userNameErrorMessage.Text = "";
                }

                //this holds the phone number and an else to clear the error label
                //making sure the the length of the number is up to 10, its a digit
                //then formats it.
                if(!IsValidNumber(phone))
                {
                    isValid = false;
                    phoneNumErrorMessage.Text = "Phone Number must be numbers and be up to 10 characters";
                    phoneTextBox.Text = "";
                    phoneTextBox.Focus();                                       
                }                
                else
                {
                    PhoneFormat(ref phone);
                    phoneTextBox.Text = phone;
                    phoneNumErrorMessage.Text = "";
                }

                //this makes sure the password has upperCase, lowerCase, the textbox 
                //is not empty and the charcter length is not more than 8
                if (password.Length >= MIN_LENGTH && NumberDigits(password) >= 1 &&
                    NumberLowerCase(password) >= 1 && NumberUppercase(password) >= 1)
                {
                    //isValid = true;
                    passwordErrorMessage.Text = "";
                }
                else
                {
                    isValid = false;
                    passwordErrorMessage.Text = "The password must have uppercase, lowercase, number and 8 charcters long";
                    passwordErrorMessage.Focus();
                }


                //this if statement saves the information into a file, if all the 
                //requirments are met
                if (isValid == true)
                {

                    //creating output object for names to store just 
                    //username and password
                    outputFile = File.AppendText("Names.txt");
                    outputFile.WriteLine(username + " " + password);

                    //closes the file
                    outputFile.Close();

                    //creating output object for information that stores 
                    //first and lastName, phone, email, phone, city, username and
                    //password
                    outfile = File.AppendText("information.txt");
                    outfile.WriteLine(username + " " + password + " " +
                        firstName + " " + lastName + " "
                        + " " + phone + " " +
                        city + " " + email);

                    //closes the file
                    outfile.Close();

                    //message to show that the name was registered in file
                    MessageBox.Show("Your registeration was successful");

                }

                //this makes sure the information is not saved unless the 
                //the all the requirements are met
                else
                {
                    isValid = false;
                }

            }
            catch (Exception ex)
            {
                //catches any exceptions
                MessageBox.Show(ex.Message);
            }

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            //goes back to the mainform
            Mainform main = new Mainform();
            main.ShowDialog();
            this.Close();
        }
    }
  }


