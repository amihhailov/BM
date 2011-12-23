using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BilllingMachine.Models;

namespace BilllingMachine.Data
{
    public static class Globals
    {
        public const string EMPTY_STRING = "";
        public const string WHITE_SPACE = " ";
        public const string LINE_FOLDING = "\r\n";
        public const string MOBILE_VALUE = "Mobile";

        public static List<Country> LCountry;
        public static List<Calls> LCalls;

        public static Dictionary<string, CountryRates> DCountryRates;
        public static Dictionary<string, MobileRates> DMobileRates;
        public static Dictionary<string, FixedRates> DFixedRates;
        public static Dictionary<string, List<Calls>> DPhone;
    }
}
