using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

using BilllingMachine.UIForms;

namespace BilllingMachine.DataClasses
{
    public static class ProcessData
    {
        const string LINE_FOLDING = "\r\n";


        /// <summary>
        /// Reads countries data from the file and imports some additional data from rates to
        /// achieve higher performance.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="table"></param>
        /// <param name="rates"></param>
        /// <returns></returns>
        public static DataSet LoadCountry()
        {
            const string DELIMETER_SYMBOL = ",";
            const string COUNTRY_GRID_NAME = "gridCountry";
            const string COUNTRY_FILE_NAME = ("..\\..\\DataSources\\country.txt");

            DataSet dataset = new DataSet();

            try
            {
                StreamReader sReader = new StreamReader(COUNTRY_FILE_NAME);
                dataset.Tables.Add(COUNTRY_GRID_NAME);
                // The phone code 
                dataset.Tables[COUNTRY_GRID_NAME].Columns.Add("Code");
                // The full name of the direction
                dataset.Tables[COUNTRY_GRID_NAME].Columns.Add("Full Direction");
                // The direction name
                dataset.Tables[COUNTRY_GRID_NAME].Columns.Add("Direction");

                string allData = sReader.ReadToEnd();
                string[] rows = allData.Split(LINE_FOLDING.ToCharArray());

                foreach (string row in rows)
                {
                    if (row.Length == 0) continue;
                    string[] columns = row.Split(DELIMETER_SYMBOL.ToCharArray());
                    if (columns.Length != 3) throw new DataException("Invalid 'country.txt' file format.");
                    dataset.Tables[COUNTRY_GRID_NAME].Rows.Add(columns);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
            
            return dataset;
        }

        /// <summary>
        /// Reads countries data from the file and imports some additional data from rates to
        /// achieve higher performance.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="table"></param>
        /// <param name="rates"></param>
        /// <returns></returns>
        public static DataSet LoadRates()
        {
            const string DELIMETER_SYMBOL = ";";
            const string RATES_GRID_NAME = "gridRates";
            const string RATES_FILE_NAME = ("..\\..\\DataSources\\rates.csv");

            DataSet dataset = new DataSet();

            try
            {
                StreamReader sReader = new StreamReader(RATES_FILE_NAME);
                dataset.Tables.Add(RATES_GRID_NAME);
                // The direction name 
                dataset.Tables[RATES_GRID_NAME].Columns.Add("Direction");
                // The price per minute for mobile networks
                dataset.Tables[RATES_GRID_NAME].Columns.Add("Price per minute / Mobile");
                // The price per minute for fixed networks
                dataset.Tables[RATES_GRID_NAME].Columns.Add("Price per minute / Fixed");

                string allData = sReader.ReadToEnd();
                string[] rows = allData.Split(LINE_FOLDING.ToCharArray());

                foreach (string row in rows)
                {
                    if (row.Length == 0) continue;
                    string[] columns = row.Split(DELIMETER_SYMBOL.ToCharArray());
                    if (columns.Length != 3) throw new DataException("Invalid 'rates.csv' file format.");
                    dataset.Tables[RATES_GRID_NAME].Rows.Add(columns);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
            
            return dataset;
        }

        /// <summary>
        /// Reads countries data from the file and imports some additional data from rates to
        /// achieve higher performance.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="table"></param>
        /// <param name="rates"></param>
        /// <returns></returns>
        public static DataSet LoadCalls(string fileName)
        {
            const string DELIMETER_SYMBOL = ",";
            const string CALLS_GRID_NAME = "gridCalls";

            DataSet dataset = new DataSet();

            try
            {
                StreamReader sReader = new StreamReader(fileName);
                dataset.Tables.Add(CALLS_GRID_NAME);
                // The phone number
                dataset.Tables[CALLS_GRID_NAME].Columns.Add("Phone Number");
                // Call duration in seconds
                dataset.Tables[CALLS_GRID_NAME].Columns.Add("Call Duration (sec.)");

                string allData = sReader.ReadToEnd();
                string[] rows = allData.Split(LINE_FOLDING.ToCharArray());

                foreach (string row in rows)
                {
                    if (row.Length == 0) continue;
                    string[] columns = row.Split(DELIMETER_SYMBOL.ToCharArray());
                    if (columns.Length != 2) throw new DataException("Invalid " + fileName + " file format.");
                    dataset.Tables[CALLS_GRID_NAME].Rows.Add(columns);
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

            return dataset;
        }
    }
}
