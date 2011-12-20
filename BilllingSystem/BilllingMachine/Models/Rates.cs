using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.Models
{
    public class Rates : Country
    {
        // Default constructor
        public Rates() { }

        // Properties
        //public string Direction { get; set; }
        public string MobilePrice { get; set; }
        public string FixedPrice { get; set; }
    }
}
