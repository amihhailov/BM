using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BilllingMachine.DataClasses;

namespace BilllingMachine.UIForms
{
    public partial class BillingSystem : Form
    {
        public List<DataGridView> gridsList = new List<DataGridView>();

        public BillingSystem()
        {
            InitializeComponent();
            tabCommon.SelectedIndexChanged += new EventHandler(tabCommon_SelectedIndexchanged);
            gridsList.Add(this.gridCountry);
            gridsList.Add(this.gridRates);
            gridsList.Add(this.gridCalls);
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
                    lblTotalRows.Text = this.getTotalCallsRows();
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            this.gridCountry.DataSource = BusinessLogic.LoadCountry().Tables[0].DefaultView;
            this.lblTotalRows.Text = this.getTotalCounrtyRows();
        }

        private void btnCalls_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Open Calls TXT File";
            fDialog.Filter = "TXT Files|calls*.txt";
            fDialog.InitialDirectory = @"C:\";
            fDialog.AddExtension = true;
            fDialog.CheckFileExists = true;
            fDialog.CheckPathExists = true;
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                this.gridCalls.DataSource = BusinessLogic.LoadCalls(fDialog.FileName.ToString()).Tables[0].DefaultView;
                this.lblTotalRows.Text = this.getTotalCallsRows();
                this.btnRun.Enabled = true;
            }
        }

        private void btnRates_Click(object sender, EventArgs e)
        {
            this.gridRates.DataSource = BusinessLogic.LoadRates().Tables[0].DefaultView;
            this.lblTotalRows.Text = this.getTotalRatesRows();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (checkAllDataLoaded())
            {
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

        private string getTotalCallsRows()
        {
            return string.Format("{0}: {1}", "Total Records", this.gridCalls.RowCount);
        }
    }
}
