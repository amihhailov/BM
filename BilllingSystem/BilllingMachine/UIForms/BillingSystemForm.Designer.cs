namespace BilllingMachine.UIForms
{
    partial class BillingSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabCommon = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.tabCountry = new System.Windows.Forms.TabPage();
            this.gridCountry = new System.Windows.Forms.DataGridView();
            this.tabRates = new System.Windows.Forms.TabPage();
            this.gridRates = new System.Windows.Forms.DataGridView();
            this.tabCalls = new System.Windows.Forms.TabPage();
            this.gridCalls = new System.Windows.Forms.DataGridView();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.btnCalls = new System.Windows.Forms.Button();
            this.btnRates = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnCountry = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialogCalls = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountry)).BeginInit();
            this.tabRates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRates)).BeginInit();
            this.tabCalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabCommon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalRows);
            this.splitContainer1.Panel2.Controls.Add(this.btnCalls);
            this.splitContainer1.Panel2.Controls.Add(this.btnRates);
            this.splitContainer1.Panel2.Controls.Add(this.btnRun);
            this.splitContainer1.Panel2.Controls.Add(this.btnCountry);
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Size = new System.Drawing.Size(700, 493);
            this.splitContainer1.SplitterDistance = 454;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabCommon
            // 
            this.tabCommon.Controls.Add(this.tabGeneral);
            this.tabCommon.Controls.Add(this.tabCountry);
            this.tabCommon.Controls.Add(this.tabRates);
            this.tabCommon.Controls.Add(this.tabCalls);
            this.tabCommon.Location = new System.Drawing.Point(3, 3);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.SelectedIndex = 0;
            this.tabCommon.ShowToolTips = true;
            this.tabCommon.Size = new System.Drawing.Size(697, 448);
            this.tabCommon.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.panelGeneral);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(689, 422);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(3, 3);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(683, 416);
            this.panelGeneral.TabIndex = 0;
            // 
            // tabCountry
            // 
            this.tabCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCountry.Controls.Add(this.gridCountry);
            this.tabCountry.Location = new System.Drawing.Point(4, 22);
            this.tabCountry.Name = "tabCountry";
            this.tabCountry.Padding = new System.Windows.Forms.Padding(3);
            this.tabCountry.Size = new System.Drawing.Size(689, 422);
            this.tabCountry.TabIndex = 1;
            this.tabCountry.Text = "Country";
            this.tabCountry.UseVisualStyleBackColor = true;
            // 
            // gridCountry
            // 
            this.gridCountry.AllowUserToAddRows = false;
            this.gridCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCountry.Location = new System.Drawing.Point(3, 3);
            this.gridCountry.MultiSelect = false;
            this.gridCountry.Name = "gridCountry";
            this.gridCountry.ReadOnly = true;
            this.gridCountry.RowTemplate.ReadOnly = true;
            this.gridCountry.Size = new System.Drawing.Size(679, 412);
            this.gridCountry.TabIndex = 0;
            // 
            // tabRates
            // 
            this.tabRates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabRates.Controls.Add(this.gridRates);
            this.tabRates.Location = new System.Drawing.Point(4, 22);
            this.tabRates.Name = "tabRates";
            this.tabRates.Padding = new System.Windows.Forms.Padding(3);
            this.tabRates.Size = new System.Drawing.Size(689, 422);
            this.tabRates.TabIndex = 2;
            this.tabRates.Text = "Rates";
            this.tabRates.UseVisualStyleBackColor = true;
            // 
            // gridRates
            // 
            this.gridRates.AllowUserToAddRows = false;
            this.gridRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRates.Location = new System.Drawing.Point(3, 3);
            this.gridRates.MultiSelect = false;
            this.gridRates.Name = "gridRates";
            this.gridRates.ReadOnly = true;
            this.gridRates.RowTemplate.ReadOnly = true;
            this.gridRates.Size = new System.Drawing.Size(679, 412);
            this.gridRates.TabIndex = 1;
            // 
            // tabCalls
            // 
            this.tabCalls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCalls.Controls.Add(this.gridCalls);
            this.tabCalls.Location = new System.Drawing.Point(4, 22);
            this.tabCalls.Name = "tabCalls";
            this.tabCalls.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalls.Size = new System.Drawing.Size(689, 422);
            this.tabCalls.TabIndex = 3;
            this.tabCalls.Text = "Calls";
            this.tabCalls.UseVisualStyleBackColor = true;
            // 
            // gridCalls
            // 
            this.gridCalls.AllowUserToAddRows = false;
            this.gridCalls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCalls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCalls.Location = new System.Drawing.Point(3, 3);
            this.gridCalls.MultiSelect = false;
            this.gridCalls.Name = "gridCalls";
            this.gridCalls.ReadOnly = true;
            this.gridCalls.RowTemplate.ReadOnly = true;
            this.gridCalls.Size = new System.Drawing.Size(679, 412);
            this.gridCalls.TabIndex = 0;
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Location = new System.Drawing.Point(104, 9);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(77, 13);
            this.lblTotalRows.TabIndex = 5;
            this.lblTotalRows.Text = "Total Records:";
            this.lblTotalRows.Visible = false;
            // 
            // btnCalls
            // 
            this.btnCalls.Location = new System.Drawing.Point(9, 4);
            this.btnCalls.Name = "btnCalls";
            this.btnCalls.Size = new System.Drawing.Size(85, 23);
            this.btnCalls.TabIndex = 4;
            this.btnCalls.Text = "Load Calls";
            this.btnCalls.UseVisualStyleBackColor = true;
            this.btnCalls.Visible = false;
            this.btnCalls.Click += new System.EventHandler(this.btnCalls_Click);
            // 
            // btnRates
            // 
            this.btnRates.Location = new System.Drawing.Point(8, 4);
            this.btnRates.Name = "btnRates";
            this.btnRates.Size = new System.Drawing.Size(85, 23);
            this.btnRates.TabIndex = 3;
            this.btnRates.Text = "Load Rates";
            this.btnRates.UseVisualStyleBackColor = true;
            this.btnRates.Visible = false;
            this.btnRates.Click += new System.EventHandler(this.btnRates_Click);
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(534, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnCountry
            // 
            this.btnCountry.Location = new System.Drawing.Point(7, 4);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(85, 23);
            this.btnCountry.TabIndex = 1;
            this.btnCountry.Text = "Load Country";
            this.btnCountry.UseVisualStyleBackColor = true;
            this.btnCountry.Visible = false;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(619, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialogCalls
            // 
            this.openFileDialogCalls.FileName = "openFileDialog1";
            // 
            // BillingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 493);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BillingSystem";
            this.Text = "BillingSystem";
            this.Load += new System.EventHandler(this.BillingSystem_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tabCommon.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabCountry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCountry)).EndInit();
            this.tabRates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRates)).EndInit();
            this.tabCalls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabCommon;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabCountry;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabRates;
        private System.Windows.Forms.TabPage tabCalls;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.DataGridView gridCountry;
        private System.Windows.Forms.DataGridView gridRates;
        private System.Windows.Forms.DataGridView gridCalls;
        private System.Windows.Forms.Button btnRates;
        private System.Windows.Forms.Button btnCalls;
        private System.Windows.Forms.OpenFileDialog openFileDialogCalls;
        private System.Windows.Forms.Label lblTotalRows;



    }
}

