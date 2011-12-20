using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace BilllingMachine.DataClasses
{
    public class LoadCalls : ILoadData
    {
        #region ILoadData Members

        public DataSet LoadData(string fileName)
        {
            const string LINE_FOLDING = "\r\n";
            const string DELIMETER_SYMBOL = ",";
            const string CALLS_GRID_NAME = "gridCalls";

            StreamReader sReader = null;
            DataSet dataset = new DataSet();

            try
            {
                sReader = new StreamReader(fileName);
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
