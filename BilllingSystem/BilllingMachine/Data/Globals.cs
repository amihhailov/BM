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

        public static List<Country> LCountry = new List<Country>();
        public static List<Calls> LCalls = new List<Calls>();

        public static Dictionary<string, CountryRates> DCountryRates = new Dictionary<string, CountryRates>();
        public static Dictionary<string, MobileRates> DMobileRates = new Dictionary<string, MobileRates>();
        public static Dictionary<string, FixedRates> DFixedRates = new Dictionary<string, FixedRates>();
    }
}
