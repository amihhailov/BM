using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace BilllingMachine.Common
{
    public static class Utils
    {
        public static string getTimeSpan(Stopwatch stopWatch)
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format
            (
                "{0:00}:{1:00}:{2:00}.{3:000}",
                ts.Hours,
                ts.Minutes,
                ts.Seconds,
                ts.Milliseconds
            );

            return elapsedTime;
        }

        public static bool checkAllDataLoaded(List<DataGridView> gridsList)
        {
            foreach (DataGridView gridName in gridsList)
            {
                if (gridName.RowCount == 0) 
                    return false;
            }

            return true;
        }

        public static string getTotalCallsRows(string fileName, DataGridView gridName)
        {
            if (fileName.Equals(Globals.EMPTY_STRING))
            {
                return string.Format
                (
                    "{0}: {1}", "Total Records", gridName.RowCount
                );
            }
            else
            {
                return string.Format
                (
                    "{0} '{1}': {2}", "Total Records in", fileName, gridName.RowCount
                );
            }
        }

        public static string getTotalRatesRows(DataGridView gridName)
        {
            return string.Format
            (
                "{0}: {1}", "Total Records", gridName.RowCount
            );
        }

        public static string getTotalCounrtyRows(DataGridView gridName)
        {
            return string.Format
            (
                "{0}: {1}", "Total Records", gridName.RowCount
            );
        }

        public static bool isFileExist(string fileName)
        {
            if (File.Exists(fileName))
            {
                return true;
            }

            return false;
        }

        public static bool isDirExist(string dirName)
        {
            // Create the new, empty data file.
            if (!Directory.Exists(dirName))
            {
                try
                {
                    Directory.CreateDirectory(dirName);
                    return true;
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                    return false;
                }

            }
            else
            {
                return true;
            }
        }
    }
}
