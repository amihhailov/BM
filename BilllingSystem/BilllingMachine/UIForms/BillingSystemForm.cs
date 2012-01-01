using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BilllingMachine.Data;
using BilllingMachine.Models;
using System.Threading;

namespace BilllingMachine.UIForms
{
    public partial class BillingSystemForm : Form
    {
        const int ITERATIONS_NUM_VALUE = 100;

        const string ROOT_PROJECT_DIR = (@"..\\..\\Resources\\");
        const string COUNTRY_FILE_NAME = (@"..\\..\\Resources\\country.txt");
        const string RATES_FILE_NAME = (@"..\\..\\Resources\\rates.csv");

        private List<DataGridView> gridsList = new List<DataGridView>();

        Factory[] Factories = new Factory[3];

        private string callsFileName = Globals.EMPTY_STRING;
        private string callsFilesPath = Globals.EMPTY_STRING;

        private BackgroundWorker bw = new BackgroundWorker();

        public BillingSystemForm()
        {
            InitializeComponent();
            tabCommon.SelectedIndexChanged += new EventHandler(tabCommon_SelectedIndexchanged);

            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void tabCommon_SelectedIndexchanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    btnCountry.Visible = false;
                    btnRates.Visible = false;
                    btnCalls.Visible = false;
                    lblTotalRows.Visible = false;
                    prgBar.Visible = true;
                    break;
                case 1:
                    btnCountry.Visible = true;
                    btnRates.Visible = false;
                    btnCalls.Visible = false;
                    prgBar.Visible = false;
                    lblTotalRows.Visible = true;
                    lblTotalRows.Text = this.getTotalCounrtyRows();
                    break;
                case 2:
                    btnCountry.Visible = false;
                    btnRates.Visible = true;
                    btnCalls.Visible = false;
                    prgBar.Visible = false;
                    lblTotalRows.Visible = true;
                    lblTotalRows.Text = this.getTotalRatesRows();
                    break;
                case 3:
                    btnCountry.Visible = false;
                    btnRates.Visible = false;
                    prgBar.Visible = false;
                    btnCalls.Visible = true;
                    lblTotalRows.Visible = true;
                    lblTotalRows.Text = this.getTotalCallsRows(callsFileName);
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            this.gridCountry.DataSource = Factories[0].GetDataSource().LoadData(COUNTRY_FILE_NAME).Tables[0].DefaultView;
            this.lblTotalRows.Text = this.getTotalCounrtyRows();
        }

        private void btnCalls_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Open Calls TXT File";
            fDialog.Filter = "TXT Files|calls*.txt";
            fDialog.InitialDirectory = (callsFilesPath.Equals(Globals.EMPTY_STRING)) ? ROOT_PROJECT_DIR : callsFilesPath;
            // fDialog.InitialDirectory = @"C:\";
            fDialog.AddExtension = true;
            fDialog.CheckFileExists = true;
            fDialog.CheckPathExists = true;
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                callsFilesPath = fDialog.FileName.ToString();
                callsFileName = fDialog.SafeFileName;
                this.gridCalls.DataSource = Factories[2].GetDataSource().LoadData(callsFilesPath).Tables[0].DefaultView;
                this.lblTotalRows.Text = this.getTotalCallsRows(callsFileName);
                this.btnRun.Enabled = true;
            }
        }

        private void btnRates_Click(object sender, EventArgs e)
        {
            this.gridRates.DataSource = Factories[1].GetDataSource().LoadData(RATES_FILE_NAME).Tables[0].DefaultView;
            this.lblTotalRows.Text = this.getTotalRatesRows();
        }

        private void startProgressBar()
        {
            btnCalls.Visible = false;
            btnCountry.Visible = false;
            btnRates.Visible = false;
            btnRun.Visible = false;
            btnCancel.Visible = true;
            lblTotalRows.Visible = false;

            lblState.Text = "STATUS: In Progress...";
            lblState.Update();

            btnCancel.Update();
            lblStatus.Update();
            lblProccess.Update();
            lblTime.Update();
            
            //prgBar.Maximum = ITERATIONS_NUM_VALUE;
            //prgBar.Minimum = 0;
            //prgBar.Increment(1);
            //prgBar.Value = 0;
            prgBar.Visible = true;
        }

        private bool checkAllDataLoaded()
        {
            foreach (DataGridView gridName in gridsList)
            {
                if (gridName.RowCount == 0) 
                    return false;
            }

            return true;
        }

        private string getTotalCounrtyRows()
        {
            return string.Format("{0}: {1}", "Total Records", this.gridCountry.RowCount);
        }

        private string getTotalRatesRows()
        {
            return string.Format("{0}: {1}", "Total Records", this.gridRates.RowCount);
        }

        private string getTotalCallsRows(string fileName)
        {
            if (fileName.Equals(Globals.EMPTY_STRING))
            {
                return string.Format("{0}: {1}", "Total Records", this.gridCalls.RowCount);
            }
            else
            {
                return string.Format("{0} '{1}': {2}", "Total Records in", fileName, this.gridCalls.RowCount);
            }
        }

        private void BillingSystem_Load(object sender, EventArgs e)
        {
            Factories[0] = new FactoryCountry();
            Factories[1] = new FactoryRates();
            Factories[2] = new FactoryCalls();

            gridsList.Add(this.gridCountry);
            gridsList.Add(this.gridRates);
            gridsList.Add(this.gridCalls);

            //bgrWorker.RunWorkerAsync();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; (i <= 100); i++)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    Thread.Sleep(100);
                    worker.ReportProgress(Convert.ToInt32(i));
                    //this.prgBar.Value = i;
                }
            }

            if (worker.CancellationPending)
            {
                Thread.Sleep(1200);
                e.Cancel = true;
                return;
            }
            worker.ReportProgress(100);

            //this.tabCommon.SelectedTab = this.tabGeneral;
            //// Seach rates for directions
            //ProcessData.ProcessRates();
            //// Proccess calls' list (here 100 iterations for one selected 'call.txt' file
            //this.startProgressBar();
            //for (int i = 1; i <= ITERATIONS_NUM_VALUE; i++)
            //{
            //    this.prgBar.Value = i;
            //    calls_num = calls_num + ProcessData.ProccessCalls();
            //    this.lblStatus.Text = "COMPLETED: " + i * prgoreesPersentage + "%";
            //    this.lblStatus.Update();
            //    this.lblProccess.Text = "PROCCESSED CALLS: " + calls_num.ToString();
            //    this.lblProccess.Update();
            //}
            //btnCancel.Visible = false;
            //btnCancel.Update();
            //btnRun.Visible = true;
            //btnRun.Update();
            //lblState.Text = "STATUS: Completed!";
            //lblState.Update();
            //MessageBox.Show("Calculation completed!");
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //worker.Text = "Start Long Running Asynchronous Process";
            //worker.Enabled = true;

            if ((e.Cancelled == true))
            {
                //this.prgBar.Text = "Canceled!";
                lblStatus.Text = "STATUS: Cancelled...";
                btnCancel.Visible = false;
                btnRun.Visible = true;
            }

            else if (!(e.Error == null))
            {
                //this.prgBar.Text = ("Error: " + e.Error.Message);
                MessageBox.Show(e.Error.Message);
                return;
            }
            else
            {
                //this.prgBar.Text = "Done!";
                this.lblStatus.Text = "STATUS: Completed...";
                this.btnCancel.Visible = false;
                this.btnRun.Visible = true;
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this.prgBar.Text = (e.ProgressPercentage.ToString() + "%");
            this.prgBar.Value = e.ProgressPercentage;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bw.WorkerSupportsCancellation == true)
            {
                bw.CancelAsync();
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy)
            {
                btnRun.Enabled = false;
                lblStatus.Text = "Canceling...";
                bw.CancelAsync();
            }
            else
            {
                this.tabCommon.SelectedTab = this.tabGeneral;
                //this.startProgressBar();
                btnRun.Text = "Cancel";
                lblStatus.Text = "Running...";
                bw.RunWorkerAsync();
            }
        }


    }
}
