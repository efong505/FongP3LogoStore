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
            bool hasLogo = false;
            if (logoCheckBox.Checked) { hasLogo = true; }
            else { hasLogo = false; }

            LogoOrderItem order = new LogoOrderItem(textToEngravetextBox.Text, hasLogo);

            // find out item type selection selection
            string itemSelection;
            if (usbRadioButton.Checked) itemSelection = usbRadioButton.Text;
            else if (mugRadioButton.Checked) itemSelection = mugRadioButton.Text;
            else itemSelection = PenRadioButton.Text;

            order.NumItems = Int32.Parse(numOfItemsTxtBx.Text);
            order.ItemType = itemSelection;
            order.NumColors = Int32.Parse(numOfColorsTxtBox.Text);
            order.HasLogo = hasLogo;
            order.OrderNum = Int32.Parse(orderNumtxtBox.Text);
            orderNum = Int32.Parse(orderNumtxtBox.Text);
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
    }
}
