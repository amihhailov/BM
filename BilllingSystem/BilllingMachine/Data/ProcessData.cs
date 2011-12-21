using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

using BilllingMachine.Models;

namespace BilllingMachine.Data
{
    public static class ProcessData
    {
        public static void ProcessRates()
        {
            foreach (Country country in Globals.LCountry)
            {
                if (Globals.DFixedRates.ContainsKey(country.Direction))
                {
                    CountryRates cr = new CountryRates
                    (
                        country.Code, 
                        country.FullDirection, 
                        country.Direction, 
                        Globals.DFixedRates[country.Direction].Price
                    );
                    Globals.DCountryRates.Add(cr.Code, cr);
                }
                else if (Globals.DMobileRates.ContainsKey(country.Direction))
                {
                    CountryRates cr = new CountryRates
                    (
                        country.Code, 
                        country.FullDirection, 
                        country.Direction, 
                        Globals.DMobileRates[country.Direction].Price
                    );
                    Globals.DCountryRates.Add(cr.Code, cr);
                }
            }

            Globals.LCountry.Clear();
            Globals.DFixedRates.Clear();
            Globals.DMobileRates.Clear();
        }

        private static void ProccessCalls()
        {
            int  pLength = 0;
            string phone = Globals.EMPTY_STRING;

            Dictionary<string, Calls> DPhone = new Dictionary<string,Calls>();

            // Acquire keys and sort them.
            var keysList = Globals.DCountryRates.Keys.ToList();

            foreach (Calls call in Globals.LCalls)
            {
                // Loop through keys
                foreach (var key in keysList)
                {
                    if (call.Phone.Equals(key))
                    {
                        //DPhone.Add(key, call);
                    }
                    else if (DPhone.ContainsKey(call.Phone))
                    {

                    }
                    else if (call.Phone.StartsWith(key))
                    {
                        //phone = 
                    }
                }
            }
        }
    }
}
