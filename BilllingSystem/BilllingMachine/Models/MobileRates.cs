using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.Models
{
    public class MobileRates : Rates
    {
        public MobileRates() { }

        public MobileRates(string direction, string price)
        {
            this.Direction = direction;
            this.Price = price;
        }

        public string Price { get; set; }

        public string roundPrice(string price)
        {
            float fPrice = float.Parse(price) * 60;
            //if ()
            return "";
        }
    }
}
