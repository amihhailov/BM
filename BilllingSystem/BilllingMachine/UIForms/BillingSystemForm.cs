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

namespace BilllingMachine.UIForms
{
    public partial class BillingSystemForm : Form
    {
        const int ITERATIONS_NUM_VALUE = 20;

        const string ROOT_PROJECT_DIR = (@"..\\..\\Resources\\");
        const string COUNTRY_FILE_NAME = (@"..\\..\\Resources\\country.txt");
        const string RATES_FILE_NAME = (@"..\\..\\Resources\\rates.csv");

        private List<DataGridView> gridsList = new List<DataGridView>();

        Factory[] Factories = new Factory[3];

        private string callsFileName = Globals.EMPTY_STRING;
        private string callsFilesPath = Globals.EMPTY_STRING;

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
                    break;
                case 1:
                    btnCountry.Visible = true;
                    btnRates.Visible = false;
                    btnCalls.Visible = false;
                    lblTotalRows.Visible = true;
                    lblTotalRows.Text = this.getTotalCounrtyRows();
                    break;
                case 2:
                    btnCountry.Visible = false;
                    btnRates.Visible = true;
                    btnCalls.Visible = false;
                    lblTotalRows.Visible = true;
                    lblTotalRows.Text = this.getTotalRatesRows();
                    break;
                case 3:
                    btnCountry.Visible = false;
                    btnRates.Visible = false;
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

        private void btnRun_Click(object sender, EventArgs e)
        {
            ProgressBarForm pForm = new ProgressBarForm();
            //ProgressBar pBar = new ProgressBar();
            //pForm.Load();
            pForm.Show();

   
            //pBar.Value = 1;

            if (checkAllDataLoaded())
            {
                // Seach rates for directions
                ProcessData.ProcessRates();
                // Proccess calls' list (here 100 iterations for one selected 'call.txt' file
                for (int i = 0; i < ITERATIONS_NUM_VALUE; i++)
                {
                    ProcessData.ProccessCalls();
                }
                pForm.Close();
                this.tabCommon.SelectedTab = this.tabGeneral;
            }
            else
            {
                MessageBox.Show("Check that all data in tabs were successfully loaded!");
            }
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

            //ProgressBarForm pForm = new ProgressBarForm();


            //BillingSystemForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            //BillingSystemForm.MaximizeBox = false;
            //BillingSystemForm.MinimizeBox = false;
            //BillingSystemForm.StartPosition = FormStartPosition.CenterScreen;
            //BillingSystemForm.ShowDialog();
        }
    }
}
