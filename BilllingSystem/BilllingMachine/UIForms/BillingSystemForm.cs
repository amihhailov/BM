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


        private ProgressBarForm m_fmProgress = null;


        public BillingSystemForm()
        {
            InitializeComponent();
            tabCommon.SelectedIndexChanged += new EventHandler(tabCommon_SelectedIndexchanged);
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
                    //prgBar.Visible = true;
                    break;
                case 1:
                    btnCountry.Visible = true;
                    btnRates.Visible = false;
                    btnCalls.Visible = false;
                    //prgBar.Visible = false;
                    lblTotalRows.Visible = true;
                    lblTotalRows.Text = this.getTotalCounrtyRows();
                    break;
                case 2:
                    btnCountry.Visible = false;
                    btnRates.Visible = true;
                    btnCalls.Visible = false;
                    //prgBar.Visible = false;
                    lblTotalRows.Visible = true;
                    lblTotalRows.Text = this.getTotalRatesRows();
                    break;
                case 3:
                    btnCountry.Visible = false;
                    btnRates.Visible = false;
                    //prgBar.Visible = false;
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

        //private void startProgressBar()
        //{
        //    btnCalls.Visible = false;
        //    btnCountry.Visible = false;
        //    btnRates.Visible = false;
        //    btnRun.Visible = false;
        //    //btnCancel.Visible = true;
        //    lblTotalRows.Visible = false;

        //    lblState.Text = "STATUS: In Progress...";
        //    lblState.Update();

        //    //btnCancel.Update();
        //    lblStatus.Update();
        //    lblProccess.Update();
        //    lblTime.Update();
            
        //    //prgBar.Maximum = ITERATIONS_NUM_VALUE;
        //    //prgBar.Minimum = 0;
        //    //prgBar.Increment(1);
        //    //prgBar.Step = 2;
        //    //prgBar.Value = 0;
        //    //prgBar.Visible = true;
        //}

        #region Synchronous BackgroundWorker Thread
        private void btnRun_Click(object sender, EventArgs e)
        {
            // Create a background thread

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                            (bw_RunWorkerCompleted);

            // Create a progress form on the UI thread

            m_fmProgress = new ProgressBarForm();

            // Kick off the Async thread

            bw.RunWorkerAsync();

            // Lock up the UI with this modal progress form.

            tabCommon.SelectedTab = tabGeneral;
            m_fmProgress.ShowDialog(this);
            m_fmProgress = null;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do some long running task...

            //int iCount = new Random().Next(20, 50);
            int iCount = 100;
            for (int i = 0; i < iCount; i++)
            {
                // The Work to be performed...

                Thread.Sleep(100);

                m_fmProgress.progressBar.Invoke((MethodInvoker)delegate()
                {
                    lblProccess.Text =
                    "Processing file " + i.ToString() +
                    " of " + iCount.ToString();
                    m_fmProgress.progressBar.Value =
                        //Convert.ToInt32(i * (100.0 / iCount));
                    i;
                });

                if (m_fmProgress.CanceledProccess)
                {
                    // Set the e.Cancel flag so that the WorkerCompleted event

                    // knows that the process was cancelled.

                    e.Cancel = true;
                    return;
                }
            }
        }

        private void bw_RunWorkerCompleted (object sender, RunWorkerCompletedEventArgs e)
        {
            if (m_fmProgress != null)
            {
                m_fmProgress.Hide();
                m_fmProgress = null;
            }

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                return;
            }

            // Check to see if the background process was cancelled.

            if (e.Cancelled)
            {
                MessageBox.Show("Processing cancelled.");
                return;
            }

            // Everything completed normally.

            MessageBox.Show("Processing is complete.");
        }
        #endregion

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //m_fmProgress.CanceledProccess = true;
        }
    }
}
