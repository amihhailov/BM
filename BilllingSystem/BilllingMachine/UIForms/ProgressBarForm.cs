using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilllingMachine.UIForms
{
    public partial class ProgressBarForm : Form
    {
        public bool CanceledProccess = false;

        public ProgressBarForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CanceledProccess = true;
        }

    }
}
