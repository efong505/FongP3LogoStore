using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO:  Good job.  score 96/100

namespace FongP3LogoStore
{
    class LogoOrderItem
    {

        // CONSTRUCTORS

        // default constructor
        public LogoOrderItem(): this ( -1,"mug" ,0 ,0 ,false ){} 

        public LogoOrderItem(string text, bool hasLogo): this()
        {
            HasLogo = hasLogo;
            
            Text = text;
        }
            
        public LogoOrderItem(int itemID, string itemType,int numColors,int numItems,bool hasLogo)
        {
            ItemID = itemID;
            ItemType = itemType;
            NumColors = numColors;
            NumItems = numItems;
            HasLogo = hasLogo;
           
        }
        // backing fields
        private bool _hasLogo;
        private bool _hasText;
        private string _itemType;
        private int _numColors;
        private int _numItems;
        private string _text;

        // variable
        //private bool text = false;
        //private bool color = false;

        // properties
        public bool HasLogo
        {
            get
            { return _hasLogo; }
            set{ _hasLogo = value; Calc(); }
        } 
        public bool HasText
        {
            get
            { return _hasText; }
            set{ _hasText = value; Calc(); }
        }
        public string ItemType
        {
            get { return _itemType; }
            set{ _itemType = value; Calc(); }
        }

        public int NumColors
        {
            get{ return _numColors; }
            set{ _numColors = value; Calc(); }
        }

        public int NumItems
        {
            get { return _numItems; }
            set{ _numItems = value; Calc(); }
        }
        public string Text
        {
            get{ return _text; }
            set{ _text = value; Calc(); }
        }
        //auto-properties
     //TODO:  This one is readonly, make it a private set  -2 
        public decimal Price { get; set; }
        public int ItemID { get; set; }
        public int OrderNum { get; set; }

        // auto-property (readonly) for Price

       //TODO:  I see this works, but better to declare them as constants
        public decimal Pen { get; } = 1;
        public decimal Mug { get; } = 3.50M;
        public decimal USB { get; } = 4;
        public decimal GraphicLogo { get; } = .10M;
        public decimal Color{ get; } = .03M;
        public decimal TextAdded{ get; } = .05M;



        private void Calc()
        {
            // start with base price
           
            if(ItemType == "Pen")
            {
                Price = Pen;
            }
            else if(ItemType == "Mug")
            {
                Price = Mug;
            }
            else
            {
                Price = USB;
            }

            // check with hasLogo to see if we add more something with the colors
            if (HasLogo)
            {

         //TODO:  Forgot to add the 0.10 for Graphic Logo  -2
                Price += Color * NumColors;
                
            }

            // Add price for the text
            if(HasText)
            {
                Price += TextAdded;
               
            }
            
            Price *= NumItems;
        }
        // String of Order Summary
        public string GetOrderSummary()
        {
            string summary;
            // should be fairly long so that you report the items ordered
            // and the total cost.
            // All features selected

            // returns if has text and logo
            if (HasText && HasLogo)
            {
                summary = 
                "Order num: " + OrderNum + "\r\nNumber of Items: " + NumItems +
                "\r\nItem Type: " + ItemType + "\r\n  with " + NumColors + " Colors." +
                "\r\nText: " + Text + "\r\nPrice: " + Price;

            }
            // returns if has logo but no text
            else if (HasLogo)
            {
                summary = 
                "Order num: " + OrderNum + "\r\nNumber of Items: " + NumItems +
                "\r\nItem Type: " + ItemType + 
                "\r\nNumber of Colors: " + NumColors + "\r\nPrice: " + Price;
            }

            // returns if has text but no logo
            else if (HasText)
            {
                summary = "Order num: " + OrderNum + "\r\nNumber of Items: " + NumItems +
                "\r\nItem Type: " + ItemType +
                "\r\nText: " + Text + "\r\nPrice: " + Price;
            }

            // returns if item is selected only - no text or logo
            else
            {
                summary = "Order num: " + OrderNum + "\r\nNumber of Items: " + NumItems +
                "\r\nItem Type: " + ItemType + "\r\nPrice: " + Price;
            }

            return summary;
        }

    }
}
