using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.Models
{
    public class Calls : CountryRates
    {
        // Default constructor
        public Calls() { }

        public Calls(string phone, string duration) 
        {
            this.Phone = phone;
            this.Duration = duration;
        }

        // Properties
        public string Phone { get; set; }
        public string Duration { get; set; }
    }
}
