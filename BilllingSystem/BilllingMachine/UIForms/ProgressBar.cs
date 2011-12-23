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
        public ProgressBarForm()
        {
            InitializeComponent();
            //prgBar.Enabled = true;
            //prgBar.Value = 100;
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {
            //prgBar.Value = 1;
            
            Console.WriteLine("<============ ProgressBar ===========>");
        }
    }
}
