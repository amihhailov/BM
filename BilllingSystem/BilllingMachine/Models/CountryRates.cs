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

        public CountryRates(string code, string fullDirection, string direction, string price, bool mobile) 
        {
            this.Code = code;
            this.FullDirection = fullDirection;
            this.Direction = direction;
            this.Price = price;
            this.Mobile = mobile;
        }

        // Properties
        public string Price { get; set; }
        public bool Mobile { get; set; }
    }
}
