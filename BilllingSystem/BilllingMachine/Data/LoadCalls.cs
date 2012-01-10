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
    public class LoadCalls : ILoadData
    {
        #region ILoadData Members

        public DataSet LoadData(string fileName)
        {
            const int GRID_COLUMN_NUM = 2;
            const string DELIMETER_SYMBOL = ",";
            const string CALLS_GRID_NAME = "gridCalls";

            StreamReader sReader = null;
            DataSet dataset = new DataSet();
            Globals.LCalls = new List<Calls>();

            try
            {
                sReader = new StreamReader(fileName);
                dataset.Tables.Add(CALLS_GRID_NAME);
                // The phone number
                dataset.Tables[CALLS_GRID_NAME].Columns.Add("Phone Number");
                // The call duration in seconds
                dataset.Tables[CALLS_GRID_NAME].Columns.Add("Call Duration (seconds)");

                string allData = sReader.ReadToEnd();
                string[] rows = allData.Split(Globals.LINE_FOLDING.ToCharArray());

                foreach (string row in rows)
                {
                    if (row.Length == 0) continue;
                    string[] columns = row.Split(DELIMETER_SYMBOL.ToCharArray());
                    if (columns.Length != GRID_COLUMN_NUM) 
                        throw new DataException("Invalid " + fileName + " file format.");

                    dataset.Tables[CALLS_GRID_NAME].Rows.Add(columns);

                    string phone = columns[0].ToString().Trim();
                    string duration = columns[1].ToString().Trim();

                    Calls call = new Calls(phone, duration);
                    Globals.LCalls.Add(call);
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
