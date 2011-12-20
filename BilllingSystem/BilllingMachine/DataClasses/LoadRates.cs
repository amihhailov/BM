using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace BilllingMachine.DataClasses
{
    public class LoadRates : ILoadData
    {

        #region ILoadData Members

        public DataSet LoadData(string fileName)
        {
            const string LINE_FOLDING = "\r\n";
            const string DELIMETER_SYMBOL = ";";
            const string RATES_GRID_NAME = "gridRates";

            StreamReader sReader = null;
            DataSet dataset = new DataSet();

            try
            {
                sReader = new StreamReader(fileName);
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
