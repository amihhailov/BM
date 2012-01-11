using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BilllingMachine.Models;

namespace BilllingMachine.Common
{
    public static class Globals
    {
        // Iteration numbers
        public const int ITERATIONS_NUM_VALUE = 100;

        // Input directories and file (absolute paths)
        // NB! For Windows Service project only 
        public const string COUNTRY_ABSOLUTE_FILE_NAME = (@"C:\Projects\CSC\BilllingSystem\BilllingMachine\Resources\country.txt");
        public const string RATES_ABSOLUTE_FILE_NAME = (@"C:\Projects\CSC\BilllingSystem\BilllingMachine\Resources\rates.csv");
        public const string CALLS_ABSOLUTE_DIR_NAME = (@"C:\Projects\CSC\BilllingSystem\BilllingMachine\Resources\");

        // Output file (absolute path)
        // NB! For Windows Service project only
        public const string OUTPUT_FILE_NAME_PREFIX = "output";
        public const string OUTPUT_ABSOLUTE_DIR_NAME = (@"C:\Projects\CSC\BilllingSystem\BilllingMachine\Resources\");

        // Input directories and files (relative paths)
        // NB! For GUI project only
        public const string ROOT_PROJECT_DIR = (@"..\\..\\Resources\\");
        public const string COUNTRY_FILE_NAME = (@"..\\..\\Resources\\country.txt");
        public const string RATES_FILE_NAME = (@"..\\..\\Resources\\rates.csv");

        // Output file (relative paths)
        // NB! For GUI project only
        public const string OUTPUT_FILE_NAME = (@"..\\..\\Resources\\output");
        public const string OUTPUT_RESOURCE_DIR = "\\Resources\\output";

        // Special charters
        public const string EMPTY_STRING = "";
        public const string WHITE_SPACE = " ";
        public const string SEMICOLON_SIGN = ";";
        public const string LINE_FOLDING = "\r\n";
        public const string MOBILE_VALUE = "Mobile";

        // Lists 
        public static List<Country> LCountry;
        public static List<Calls> LCalls;
        public static List<CallsRates> LCallsRates;
        // NB! For Windows Service project only
        public static List<string> LCallsFiles = new List<string>() { "calls1.txt", "calls2.txt", "calls3.txt" };

        // Dictionaries
        public static Dictionary<string, CountryRates> DCountryRates;
        public static Dictionary<string, MobileRates> DMobileRates;
        public static Dictionary<string, FixedRates> DFixedRates;
    }
}
