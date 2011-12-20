using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.Models
{
    public class Country
    {
        // Default constructor
        public Country() { }

        public Country(string code, string fullDirection, string direction) 
        {
            this.Code = code;
            this.FullDirection = fullDirection;
            this.Direction = direction;
        }

        // Properties
        public string Code { get; set; }
        public string Direction { get; set; }
        public string FullDirection { get; set; }
    }
}
