using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.Models
{
    public class Rates
    {
        // Default constructor
        public Rates() { }

        //public Rates(string direction, string mPrice, string fPrice) 
        //{
        //    this.Direction = direction;
        //    this.MobilePrice = mPrice;
        //    this.FixedPrice = fPrice;
        //}

        // Properties
        public string Direction { get; set; }
        //public string MobilePrice { get; set; }
        //public string FixedPrice { get; set; }
    }
}
