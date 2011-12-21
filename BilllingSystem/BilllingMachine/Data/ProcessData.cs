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
        }
    }
}
