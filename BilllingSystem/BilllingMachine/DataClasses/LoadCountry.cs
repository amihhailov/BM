using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace BilllingMachine.DataClasses
{
    public class LoadCountry : ILoadData
    {
        #region ILoadData Members

        public DataSet LoadData(string fileName)
        {
            const string LINE_FOLDING = "\r\n";
            const string DELIMETER_SYMBOL = ",";
            const string COUNTRY_GRID_NAME = "gridCountry";
            
            StreamReader sReader = null;
            DataSet dataset = new DataSet();

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
