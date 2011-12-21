using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.Models
{
    public class FixedRates : Rates
    {
        public FixedRates() { }

        public FixedRates(string direction, string price)
        {
            this.Direction = direction;
            this.Price = price;
        }

        public string Price { get; set; }

        public string roundPrice(string price)
        {
            // Convert price to float in seconds
            float fPrice = float.Parse(price);
            // Round using rule "60/10"
            int roundedUp = (int)Math.Ceiling(fPrice);
            return (roundedUp * 10).ToString();
        }
    }
}
