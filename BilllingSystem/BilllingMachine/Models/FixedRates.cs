using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.Models
{
    public class FixedRates : Rates
    {
        // Default constructor
        public FixedRates() { }

        public FixedRates(string direction, string price)
        {
            this.Direction = direction;
            this.Price = price;
        }

        // Properties
        public string Price { get; set; }
    }
}
