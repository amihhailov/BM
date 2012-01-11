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
    public class LoadCountry : ILoadData
    {
        #region ILoadData Members

        public DataSet LoadData(string fileName)
        {
            const int GRID_COLUMN_NUM = 3;
            const string DELIMETER_SYMBOL = ",";
            const string COUNTRY_GRID_NAME = "gridCountry";
            const string PERSONAL_VALUE = "Personal";
            const string PREMIUM_VALUE = "Premium";

            StreamReader sReader = null;
            DataSet dataset = new DataSet();
            Globals.LCountry = new List<Country>();

            try
            {
                sReader = new StreamReader(fileName);
                dataset.Tables.Add(COUNTRY_GRID_NAME);
                // The phone code 
                dataset.Tables[COUNTRY_GRID_NAME].Columns.Add("Code");
                // The full name of the direction
                dataset.Tables[COUNTRY_GRID_NAME].Columns.Add("Full Direction");
                // The direction name
                dataset.Tables[COUNTRY_GRID_NAME].Columns.Add("Direction");

                string allData = sReader.ReadToEnd();
                string[] rows = allData.Split(Globals.LINE_FOLDING.ToCharArray());

                foreach (string row in rows)
                {
                    if (row.Length == 0) continue;
                    string[] columns = row.Split(DELIMETER_SYMBOL.ToCharArray());
                    if (columns.Length != GRID_COLUMN_NUM)
                        throw new DataException("Invalid 'country.txt' file format.");

                    dataset.Tables[COUNTRY_GRID_NAME].Rows.Add(columns);

                    string code = columns[0].ToString().Trim();
                    string fullDirection = columns[1].ToString().Trim();
                    string direction = columns[2].ToString().Trim();

                    if ((fullDirection.Contains(PERSONAL_VALUE)) || (fullDirection.Contains(PREMIUM_VALUE))) continue;
                    Country country = new Country(code, fullDirection, direction);
                    Globals.LCountry.Add(country);
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
            finally
            {
                sReader.Close();
                sReader.Dispose();
            }

            return dataset;
        }

        #endregion
    }
}
