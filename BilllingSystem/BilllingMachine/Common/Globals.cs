using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BilllingMachine.Models;

namespace BilllingMachine.Common
{
    public static class Globals
    {
        // Input directories and files 
        public const string ROOT_PROJECT_DIR = (@"..\\..\\Resources\\");
        public const string COUNTRY_FILE_NAME = (@"..\\..\\Resources\\country.txt");
        public const string RATES_FILE_NAME = (@"..\\..\\Resources\\rates.csv");
        
        // Output file
        public const string OUTUPUT_FILE_NAME = (@"..\\..\\Resources\\output.txt");

        public const string EMPTY_STRING = "";
        public const string WHITE_SPACE = " ";
        public const string LINE_FOLDING = "\r\n";
        public const string MOBILE_VALUE = "Mobile";

        public static List<Country> LCountry;
        public static List<Calls> LCalls;
        //public static List<string, CountryRates> LPhone;

        public static Dictionary<string, CountryRates> DCountryRates;
        public static Dictionary<string, MobileRates> DMobileRates;
        public static Dictionary<string, FixedRates> DFixedRates;
        // public static Dictionary<string, List<Calls>> DPhone;
        // public static Dictionary<string, CountryRates> DPhone;
    }
}
