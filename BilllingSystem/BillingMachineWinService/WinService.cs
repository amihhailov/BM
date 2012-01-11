using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;

using BilllingMachine.Data;
using BilllingMachine.Common;

namespace BillingMachineWinService
{
    public partial class WinService : ServiceBase
    {
        Factory[] Factories = new Factory[3];

        private Stopwatch stopWatch = null;

        public WinService()
        {
            InitializeComponent();

            Factories[0] = new FactoryCountry();
            Factories[1] = new FactoryRates();
            Factories[2] = new FactoryCalls();
        }

        protected override void OnStart(string[] args)
        {
            if (!Utils.isFileExist(Globals.COUNTRY_ABSOLUTE_FILE_NAME))
            {
                return;
            }
            if (!Utils.isFileExist(Globals.RATES_ABSOLUTE_FILE_NAME))
            {
                return;
            }

            Factories[0].GetDataSource().LoadData(Globals.COUNTRY_ABSOLUTE_FILE_NAME);
            Factories[1].GetDataSource().LoadData(Globals.RATES_ABSOLUTE_FILE_NAME);

            foreach (string f in Globals.LCallsFiles)
            {
                if (!Utils.isFileExist(Globals.CALLS_ABSOLUTE_DIR_NAME + f)) break;
                Factories[2].GetDataSource().LoadData(Globals.CALLS_ABSOLUTE_DIR_NAME + f);

                // Seach rates for directions
                ProcessData.ProcessRates();

                stopWatch = new Stopwatch();
                // Start Time
                stopWatch.Start();

                // Proccess calls' list (here 100 iterations by default for one selected 'call*.txt' file)
                for (int i = 1; i <= Globals.ITERATIONS_NUM_VALUE; i++)
                {
                    ProcessData.ProccessCalls();
                }
                // End Time
                stopWatch.Stop();

                // Print results to the 'output.txt' file by default

                if (!Utils.isDirExist(Globals.OUTPUT_ABSOLUTE_DIR_NAME)) break;
                ProcessData.ProcessResults
                (
                    Globals.OUTPUT_ABSOLUTE_DIR_NAME + Globals.OUTPUT_FILE_NAME_PREFIX + "-" + f, 
                    Utils.getTimeSpan(stopWatch)
                );
            }
        }

        protected override void OnStop() {}
    }
}
