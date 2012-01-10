using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

using BilllingMachine.Common;
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
                        Globals.DFixedRates[country.Direction].Price,
                        false
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
                        Globals.DMobileRates[country.Direction].Price,
                        true
                    );
                    Globals.DCountryRates.Add(cr.Code, cr);
                }
            }
        }

        public static long ProccessCalls()
        {
            long callsNum = 0;
            string phone = Globals.EMPTY_STRING;

            Dictionary<string, CountryRates> DPhone = new Dictionary<string, CountryRates>();
            Globals.LCallsRates = new List<CallsRates>();
            CallsRates cr = null;

            // Acquire keys, sort and reverse them.
            var keysList = Globals.DCountryRates.Keys.ToList();
            keysList.Sort(); keysList.Reverse();

            foreach (Calls call in Globals.LCalls)
            {
                callsNum++;
                if (DPhone.ContainsKey(call.Phone))
                {
                    cr = new CallsRates
                    (
                        call.Phone, 
                        DPhone[call.Phone].Code, 
                        DPhone[call.Phone].FullDirection,
                        DPhone[call.Phone].Direction,
                        DPhone[call.Phone].Price,
                        call.Duration,
                        DPhone[call.Phone].Mobile
                    );
                    Globals.LCallsRates.Add(cr);
                    continue;
                }

                // Loop through keys
                foreach (var key in keysList)
                {
                    if ((call.Phone.Equals(key)) || (call.Phone.StartsWith(key)))
                    {
                        phone = key;
                        break;
                    }
                }

                DPhone.Add(call.Phone, Globals.DCountryRates[phone]);

                cr = new CallsRates
                (
                    call.Phone,
                    DPhone[call.Phone].Code,
                    DPhone[call.Phone].FullDirection,
                    DPhone[call.Phone].Direction,
                    DPhone[call.Phone].Price,
                    call.Duration,
                    DPhone[call.Phone].Mobile
                );
                Globals.LCallsRates.Add(cr);

                phone = Globals.EMPTY_STRING;
            }

            return callsNum;
        }

        public static void ProcessResults(string fileName, string elapsedTime)
        {
            // Create the new, empty data file.
            if (File.Exists(fileName))
            {
                try
                {
                    // Try to delete the file.
                    File.Delete(fileName);
                }
                catch (IOException e)
                {
                    // Couldn't delete the specify file.
                    Console.WriteLine(e);
                    return;
                }
            }

            using (FileStream fs = new FileStream(Globals.OUTPUT_FILE_NAME, FileMode.CreateNew))
            {
                // Create the writer for data.
                using (TextWriter tw = new StreamWriter(fs))
                {
                    foreach (CallsRates cr in Globals.LCallsRates)
                    {
                        //tw.WriteLine
                        //(
                        //    string.Format
                        //    (
                        //        "{0,-14} {1,-8} {2,-30} {3,-22} {4,-4} {5,-7} {6,-6} {7}",
                        //        cr.Phone,
                        //        cr.Code,
                        //        cr.FullDirection,
                        //        cr.Direction,
                        //        cr.Duration,
                        //        cr.RoundDuration,
                        //        cr.Cost,
                        //        cr.Direction
                        //    )
                        //);

                        tw.WriteLine
                        (
                            cr.Phone + Globals.SEMICOLON_SIGN
                            + cr.FullDirection + Globals.SEMICOLON_SIGN
                            + cr.Direction + Globals.SEMICOLON_SIGN
                            + cr.Duration + Globals.SEMICOLON_SIGN
                            + cr.RoundDuration + Globals.SEMICOLON_SIGN
                            + cr.Direction + Globals.SEMICOLON_SIGN
                            + cr.Price + Globals.SEMICOLON_SIGN
                            + cr.Cost + Globals.SEMICOLON_SIGN
                        );
                    }
                    tw.WriteLine("{0}Elapsed Time is: {1} ms.", Environment.NewLine, elapsedTime);

                    // close the stream
                    tw.Close();
                }
            }
        }
    }
}
