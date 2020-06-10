using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private bool text = false;
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
        public decimal Price { get; set; }
        public int ItemID { get; set; }
        public int OrderNum { get; set; }

        // auto-property (readonly) for Price

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
                Price += Color * NumColors;
                
            }

            // Add price for the text
            if(HasText)
            {
                Price += TextAdded;
               
            }
            
            Price *= NumItems;
        }
        public string GetOrderSummary()
        {
            string summary;
            // should be fairly long so that you report the items ordered
            // and the total cost.
            // All features selected

            if (HasText && HasLogo)
            {
                summary = "Order num " + OrderNum + ": " + NumItems +
                    " " + ItemType + " with " + NumColors + " color logo with the following" +
                    " text: " + Text + " Price: " + Price;

            }

            else if (HasLogo)
            {
                summary = "Order num " + OrderNum + ": " + NumItems +
                " " + ItemType + " with " + NumColors + " color logo with the following"
                + " Price: " + Price;
            }
            else if (HasText)
            {
                summary = "Order num " + OrderNum + ": " + NumItems +
                " " + ItemType +
                " text: " + Text + " Price: " + Price;
            }
            else
            {
                summary = "Order num " + OrderNum + ": " + NumItems +
                " " + ItemType +
                 " Price: " + Price;
            }

            return summary;
        }

    }
}
