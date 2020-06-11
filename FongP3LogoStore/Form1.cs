﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FongP3LogoStore
{
    public partial class Form1 : Form
    {
        public int orderNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // check if logo selected
            bool hasLogo;
            if (logoCheckBox.Checked) { hasLogo = true; }
            else { hasLogo = false; }

            // Create and Instantiate LogoOrderItem Object
            LogoOrderItem order = new LogoOrderItem(textToEngravetextBox.Text, hasLogo);

            // Set HasLogo bool
            order.HasLogo = hasLogo;

            // Check if text is in text to engrave text box
            if (!String.IsNullOrWhiteSpace(textToEngravetextBox.Text)) { order.HasText = true; }
            else { order.HasText = false; }

            // find out item type selection selection
            // Check which radio button is selected
            string itemSelection;
            if (usbRadioButton.Checked) itemSelection = usbRadioButton.Text;
            else if (mugRadioButton.Checked) itemSelection = mugRadioButton.Text;
            else itemSelection = PenRadioButton.Text;
            // Set item selection into ItemType property
            order.ItemType = itemSelection; 

            // Check order number
            string orderNum = orderNumtxtBox.Text;
            bool success = Int32.TryParse(orderNum, out int orderNumber);
            if (success)
            {
                
                order.OrderNum = orderNumber;
                
            }
            else
            {
                //MessageBox.Show(orderNum + " is not a valid number");
                orderSummary.Text = "Incorrect data type for order number. \r\nPlease try again.";
            }
            
            // Check number of items
            string numOfItems = numOfItemsTxtBx.Text;
            success = Int32.TryParse(numOfItems, out int numberOfItems);
            if (success)
            {
                order.NumItems = numberOfItems;
                
            }
            else
            {
                orderSummary.Text = "Incorrect data type";
            }
            // Display Order Summary to order summary text box
            orderSummary.Text = order.GetOrderSummary();
            // Check Number of Colors
            string numOfColors = numOfColorsTxtBox.Text;
            success = Int32.TryParse(numOfColors, out int numberOfColors);
            if (success)
            {
                order.NumColors = numberOfColors;
                
            }
            else
            {
                orderSummary.Text = "Incorrect data type";
            }

            // Display Order Summary to order summary text box
            orderSummary.Text = order.GetOrderSummary();
            //// Display Order Summary to order summary text box
            //orderSummary.Text = order.GetOrderSummary();
        }

        // clear all fields from form
        private void clearButton_Click(object sender, EventArgs e)
        {
            orderNumtxtBox.Text = "";
            numOfItemsTxtBx.Text = "";
            textToEngravetextBox.Text = "";
            logoCheckBox.Checked = false;
            numOfColorsTxtBox.Text = "";
            orderSummary.Text = "";

        }

        // Controls the hide and show of number of colors
        private void logoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(logoCheckBox.Checked)
            {
                numOfColorsLbl.Visible = true;
                numOfColorsTxtBox.Visible = true;
            }
            else
            {
                numOfColorsLbl.Visible = false;
                numOfColorsTxtBox.Visible = false;
            }
        }
    }
}
