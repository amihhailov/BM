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

            //using (FileStream fs = new FileStream(Globals.OUTPUT_FILE_NAME, FileMode.CreateNew))
            //{
            //    // Create the writer for data.
            //    using (TextWriter tw = new StreamWriter(fs))
            //    {
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
                            
                            //tw.WriteLine
                            //(
                            //    string.Format
                            //    (
                            //        "{0,-14} {1,-8} {2,-30} {3,-22} {4,-4} {5,-7} {6,-6} {7}",
                            //        call.Phone, 
                            //        DPhone[call.Phone].Code,
                            //        DPhone[call.Phone].FullDirection,
                            //        DPhone[call.Phone].Direction,
                            //        call.Duration,
                            //        call.Duration,
                            //        DPhone[call.Phone].Price,
                            //        DPhone[call.Phone].Direction
                            //    )
                            //);
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
                        //tw.WriteLine
                        //(
                        //    string.Format
                        //    (
                        //        "{0,-14} {1,-8} {2,-30} {3,-22} {4,-4} {5,-7} {6,-6} {7}",
                        //        call.Phone,
                        //        DPhone[call.Phone].Code,
                        //        DPhone[call.Phone].FullDirection,
                        //        DPhone[call.Phone].Direction,
                        //        call.Duration,
                        //        call.Duration,
                        //        DPhone[call.Phone].Price,
                        //        DPhone[call.Phone].Direction
                        //    )
                        //);


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
                //    }
                //    // close the stream
                //    tw.Close();
                //}
            }

            return callsNum;
        }
    }
}
