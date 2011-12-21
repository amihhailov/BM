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

            Globals.DCountryRates = new Dictionary<string, CountryRates>();

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

            Console.WriteLine("<----- End of ProcessRates ----->");
        }

        public static void ProccessCalls()
        {
            int length = 0;
            string phone = Globals.EMPTY_STRING;

            Globals.DPhone = new Dictionary<string, List<Calls>>();   

            // Acquire keys and sort them.
            var keysList = Globals.DCountryRates.Keys.ToList();    

            foreach (Calls call in Globals.LCalls)
            {
                if (Globals.DPhone.ContainsKey(call.Phone))
                {
                    List<Calls> ListCalls = Globals.DPhone[call.Phone];
                    ListCalls.Add(call);
                    Globals.DPhone.Remove(call.Phone);
                    Globals.DPhone.Add(call.Phone, ListCalls);
                    continue;
                }

                // Loop through keys
                foreach (var key in keysList)
                {
                    if (call.Phone.Equals(key)) break;
                    if (call.Phone.StartsWith(key))
                    {
                        if (key.Length > length)
                        {
                            phone = key;
                            length = key.Length;
                        }
                    }
                }

                List<Calls> LCalls = new List<Calls>();
                LCalls.Add(call);
                Globals.DPhone.Add(call.Phone, LCalls);
                
                length = 0;
                phone = Globals.EMPTY_STRING;
            }

            Console.WriteLine("<----- End of ProccessCalls ----->");
        }
    }
}
