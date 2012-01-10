using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BilllingMachine.Common;

namespace BilllingMachine.Models
{
    public class CallsRates : Calls
    {
        // Default constructor
        public CallsRates() { }

        public CallsRates(string phone, string code, string fullDirection, 
                string direction, string price, string duration, bool mobile) 
        {
            this.Phone = phone;
            this.Code = code;
            this.FullDirection = fullDirection;
            this.Direction = direction;
            this.Duration = duration;
            this.RoundDuration = this.roundDuration(duration, mobile);
            this.Price = price;
            this.Mobile = mobile;
            this.Cost = this.getCallCost(this.RoundDuration, price);
        }

        // Properties
        public int RoundDuration { get; set; }
        public string Cost { get; set; }

        public int roundDuration(string duration, bool mobile)
        {
            // Convert price to float in seconds
            float fDuration = float.Parse(duration);
            if (fDuration <= 60) return 60;
            if (mobile)
            {
                // Round using rule "60/30"
                int roundedUp = (int)Math.Ceiling(fDuration / 30);
                return (roundedUp * 30);
            }
            else
            {
                // Round using rule "60/10"
                int roundedUp = (int)Math.Ceiling(fDuration / 10);
                return (roundedUp * 10);
            }
        }

        public string getCallCost(int rDuration, string price)
        {
            float fPrice = float.Parse(price);
            return Math.Round(((rDuration * fPrice) / 60), 3).ToString("n3");
        }
    }
}
