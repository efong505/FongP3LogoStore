using System;
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
            bool hasLogo;
            if (logoCheckBox.Checked) { hasLogo = true; }
            else { hasLogo = false; }

            //string text;
            //bool hasText;
           
            LogoOrderItem order = new LogoOrderItem(textToEngravetextBox.Text, hasLogo);

            // find out item type selection selection

            if (!String.IsNullOrWhiteSpace(textToEngravetextBox.Text)) { order.HasText = true;  }
            else { order.HasText = false;  }
            string itemSelection;
            if (usbRadioButton.Checked) itemSelection = usbRadioButton.Text;
            else if (mugRadioButton.Checked) itemSelection = mugRadioButton.Text;
            else itemSelection = PenRadioButton.Text;
            
            if (int.TryParse(numOfItemsTxtBx.Text, out int numOfItems))
            {
                order.NumItems = numOfItems;
            }
            else
            {
                orderSummary.Text = "Incorrect data type";
            }
            //order.NumItems = int.Parse(numOfItemsTxtBx.Text);
            order.ItemType = itemSelection;
            if (int.TryParse(numOfColorsTxtBox.Text, out int numOfColors))
            {
                order.NumColors = numOfColors;
            }
            else
            {
                orderSummary.Text = "Incorrect data type";
            }
           // order.NumColors = int.Parse(numOfColorsTxtBox.Text);
            order.HasLogo = hasLogo;
            if (int.TryParse(orderNumtxtBox.Text, out int orderNumber))
            {
                order.OrderNum = orderNumber;
            }
            else
            {
                orderSummary.Text = "Incorrect data type for order number. \r\nPlease try again.";
            }
            //order.OrderNum = Int32.Parse(orderNumtxtBox.Text);

            //orderNum = Int32.Parse(orderNumtxtBox.Text);
            orderSummary.Text = order.GetOrderSummary();
          
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            orderNumtxtBox.Text = "";
            numOfItemsTxtBx.Text = "";
            textToEngravetextBox.Text = "";
            logoCheckBox.Checked = false;
            numOfColorsTxtBox.Text = "";
            orderSummary.Text = "";

        }

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
