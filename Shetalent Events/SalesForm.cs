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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        string display = " In Stock";
        int redInstock = 25;
        int pearlInStock = 34;
        int indianInStock = 42;
        int vDiamondInStock = 51;
        int bridalBeadInStock = 35;

        int value;
        int newValue;
        double cumTotal = 0;

        double total = 0;

        string cartDisplay;

        private void SalesForm_Load(object sender, EventArgs e)
        {
            enterButton.Visible = false;
            adminPassPanel.Visible = false;

            //try
            //{
            //    StreamReader infile;
            //    infile = File.OpenText("Stocks");
            //}
            //catch(Exception en)
            //{
            //    MessageBox.Show(en.Message);
            //}

            redAdoLabel.Text = redInstock.ToString() + display;           
            pearlLabel.Text = pearlInStock.ToString() + display;
            indianLookLabel.Text = indianInStock.ToString() + display;
            BridalLabel.Text = bridalBeadInStock.ToString() + display;
            vDiamondLabel.Text = vDiamondInStock.ToString() + display;
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
           
            cumTotal += total;
            cartListBox.Items.Add(cartDisplay);
            totalLabel.Text = cumTotal.ToString();
        }

        private void redAdorableNumUpDwn_ValueChanged(object sender, EventArgs e)
        {
            value = (int)redAdorableNumUpDwn.Value;
            newValue = redInstock - value;
            redInstock = (int)newValue;

            total = 125.34 * value;
            cartDisplay = redAdorableNumUpDwn.Value.ToString() + " of Red Adorable for " + total.ToString();
        }

        private void bridalBeadnumUpDwn_ValueChanged(object sender, EventArgs e)
        {
            value = (int)bridalBeadnumUpDwn.Value;
            newValue = bridalBeadInStock - value;
            bridalBeadInStock = (int)newValue;

            total = 125.34 * value;
            cartDisplay = bridalBeadnumUpDwn.Value.ToString() + " of Bridal Bead for " + total.ToString();
        }

        private void indianLooknumUpDwn_ValueChanged(object sender, EventArgs e)
        {
            value = (int)indianLooknumUpDwn.Value;
            newValue = indianInStock - value;
            indianInStock = (int)newValue;

            total = 125.34 * value;
            cartDisplay = indianLooknumUpDwn.Value.ToString() + " of Indain Bead for " + total.ToString();
        }

        private void PearlNumUpDwn_ValueChanged(object sender, EventArgs e)
        {
            value = (int)PearlNumUpDwn.Value;
            newValue = pearlInStock - value;
            pearlInStock = (int)newValue;

            total = 75.14 * value;
            cartDisplay = PearlNumUpDwn.Value.ToString() + " of Pearl for " + total.ToString();
        }

        private void vDiamondNumUpDwn_ValueChanged(object sender, EventArgs e)
        {
            value = (int)vDiamondNumUpDwn.Value;
            newValue = vDiamondInStock - value;
            vDiamondInStock = (int)newValue;

            total = 125.34 * value;
            cartDisplay = vDiamondNumUpDwn.Value.ToString() + " of VDiamond for " + total.ToString();
        }

        private void addInStockButton_Click(object sender, EventArgs e)
        {
            enterButton.Visible = true;
            adminPassPanel.Visible = true;

        }

        private void enterStockButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outfile;

                outfile = File.AppendText("Stocks");

                int red;
                if (int.TryParse(redAdorableTextBox.Text, out red))
                {
                    redInstock = red;
                }
                else
                {
                    MessageBox.Show("Stock input must be a whole number");
                }

                int indian;
                if (int.TryParse(indianLookTextBox.Text, out indian))
                {
                    indianInStock = indian;
                }
                else
                {
                    MessageBox.Show("Stock input must be a whole number");
                }

                int bridal;
                if (int.TryParse(bridalBeadTextBox.Text, out bridal))
                {
                    bridalBeadInStock = bridal;
                }
                else
                {
                    MessageBox.Show("Stock input must be a whole number");
                }

                int pearl;
                if (int.TryParse(pearlTextBox.Text, out pearl))
                {
                    pearlInStock = pearl;
                }
                else
                {
                    MessageBox.Show("Stock input must be a whole number");
                }

                int vDiamond;
                if (int.TryParse(VDiamondTextBox.Text, out vDiamond))
                {
                    vDiamondInStock = vDiamond;
                }
                else
                {
                    MessageBox.Show("Stock input must be a whole number");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            if (adminPasswordTextBox.Text == "1234")
            {
                stockPanel.Enabled = true;
                adminPassPanel.Visible = false;
                enterButton.Visible = false;
                MessageBox.Show("Scroll to the extreme right of the section to enter stock");
            }
            else
            {
                MessageBox.Show("invalid password, your not allowed to enter stocks");
            }
        }

        private void addToEventSaleButton_Click(object sender, EventArgs e)
        {
            if(cartListBox.Items.Count == 0)
            {
                MessageBox.Show("You need to add to cart before checking out to event");
            }
            else
            {
                EventClass evtclass = new EventClass();

                decimal total;

                if (decimal.TryParse(totalLabel.Text, out total))
                {
                    evtclass.Sales = total;
                }
                CreateNewEvent create = new CreateNewEvent();

                create.salesAmountTextBox.Text = evtclass.Sales.ToString();

                create.ShowDialog();
            }                                    
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            cartListBox.Items.Clear();
            totalLabel.Text = "";
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Total amount due is " + total);
        }
    }
}
