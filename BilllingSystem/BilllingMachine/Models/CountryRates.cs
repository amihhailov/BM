using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.Models
{
    public class CountryRates : Country
    {
        // Default constructor
        public CountryRates() { }

        public CountryRates(string code, string fullDirection, string direction, string price) 
        {
            this.Code = code;
            this.FullDirection = fullDirection;
            this.Direction = direction;
            this.Price = price;
        }

        // Properties
        public string Price { get; set; }
    }
}
