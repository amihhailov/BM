using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

using BilllingMachine.Models;

namespace BilllingMachine.Data
{
    public class LoadRates : ILoadData
    {

        #region ILoadData Members

        public DataSet LoadData(string fileName)
        {
            const int GRID_COLUMN_NUM = 3;
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
                string[] rows = allData.Split(Globals.LINE_FOLDING.ToCharArray());

                foreach (string row in rows)
                {
                    if (row.Length == 0) continue;
                    string[] columns = row.Split(DELIMETER_SYMBOL.ToCharArray());
                    if (columns.Length != GRID_COLUMN_NUM) 
                        throw new DataException("Invalid 'rates.csv' file format.");

                    dataset.Tables[RATES_GRID_NAME].Rows.Add(columns);

                    string direction = columns[0].ToString().Trim();
                    string fPrice = columns[1].ToString().Trim();
                    string mPrice = columns[2].ToString().Trim();

                    FixedRates fRates = new FixedRates(direction, fPrice);
                    Globals.DFixedRates.Add(fRates.Direction, fRates);

                    MobileRates mRates = new MobileRates(string.Format("{0} {1}", direction, Globals.MOBILE_VALUE), mPrice);
                    Globals.DMobileRates.Add(mRates.Direction, mRates);
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
