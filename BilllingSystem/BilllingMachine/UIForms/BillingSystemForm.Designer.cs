namespace BilllingMachine.UIForms
{
    partial class BillingSystemForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tabCommon = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.grBoxUser = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grBoxInformation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIterations = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblProccess = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tabCountry = new System.Windows.Forms.TabPage();
            this.gridCountry = new System.Windows.Forms.DataGridView();
            this.tabRates = new System.Windows.Forms.TabPage();
            this.gridRates = new System.Windows.Forms.DataGridView();
            this.tabCalls = new System.Windows.Forms.TabPage();
            this.gridCalls = new System.Windows.Forms.DataGridView();
            this.btnViewResult = new System.Windows.Forms.Button();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.btnCalls = new System.Windows.Forms.Button();
            this.btnRates = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnCountry = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialogCalls = new System.Windows.Forms.OpenFileDialog();
            this.lblOutput = new System.Windows.Forms.Label();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.grBoxUser.SuspendLayout();
            this.grBoxInformation.SuspendLayout();
            this.tabCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountry)).BeginInit();
            this.tabRates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRates)).BeginInit();
            this.tabCalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabCommon);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lblOutput);
            this.splitContainer.Panel2.Controls.Add(this.btnViewResult);
            this.splitContainer.Panel2.Controls.Add(this.lblTotalRows);
            this.splitContainer.Panel2.Controls.Add(this.btnCalls);
            this.splitContainer.Panel2.Controls.Add(this.btnRates);
            this.splitContainer.Panel2.Controls.Add(this.btnRun);
            this.splitContainer.Panel2.Controls.Add(this.btnCountry);
            this.splitContainer.Panel2.Controls.Add(this.btnClose);
            this.splitContainer.Size = new System.Drawing.Size(700, 493);
            this.splitContainer.SplitterDistance = 454;
            this.splitContainer.TabIndex = 0;
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
            this.panelGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGeneral.Controls.Add(this.grBoxUser);
            this.panelGeneral.Controls.Add(this.grBoxInformation);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(3, 3);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(683, 416);
            this.panelGeneral.TabIndex = 0;
            // 
            // grBoxUser
            // 
            this.grBoxUser.Controls.Add(this.label5);
            this.grBoxUser.Controls.Add(this.label4);
            this.grBoxUser.Controls.Add(this.label3);
            this.grBoxUser.Controls.Add(this.label1);
            this.grBoxUser.Location = new System.Drawing.Point(8, 211);
            this.grBoxUser.Name = "grBoxUser";
            this.grBoxUser.Size = new System.Drawing.Size(665, 189);
            this.grBoxUser.TabIndex = 5;
            this.grBoxUser.TabStop = false;
            this.grBoxUser.Text = "Author Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "ADDRESS: Tallinn, Harjumaa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "CELL PHONE: +372 52 90129";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-MAIL: aleksei.mikhailov@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(184, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "ALEKSEI MIHHAILOV";
            // 
            // grBoxInformation
            // 
            this.grBoxInformation.Controls.Add(this.label2);
            this.grBoxInformation.Controls.Add(this.lblIterations);
            this.grBoxInformation.Controls.Add(this.lblStatus);
            this.grBoxInformation.Controls.Add(this.lblState);
            this.grBoxInformation.Controls.Add(this.lblProccess);
            this.grBoxInformation.Controls.Add(this.lblTime);
            this.grBoxInformation.Location = new System.Drawing.Point(8, 13);
            this.grBoxInformation.Name = "grBoxInformation";
            this.grBoxInformation.Size = new System.Drawing.Size(665, 177);
            this.grBoxInformation.TabIndex = 4;
            this.grBoxInformation.TabStop = false;
            this.grBoxInformation.Text = "System Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(211, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "BILLING SYSTEM";
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIterations.Location = new System.Drawing.Point(460, 91);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(107, 16);
            this.lblIterations.TabIndex = 5;
            this.lblIterations.Text = "ITERATIONS: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(20, 65);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(134, 17);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "COMPLETED: 0%";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(460, 120);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(161, 17);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "STATUS: Incomplete!";
            // 
            // lblProccess
            // 
            this.lblProccess.AutoSize = true;
            this.lblProccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProccess.Location = new System.Drawing.Point(20, 91);
            this.lblProccess.Name = "lblProccess";
            this.lblProccess.Size = new System.Drawing.Size(184, 17);
            this.lblProccess.TabIndex = 1;
            this.lblProccess.Text = "PROCCESSED CALLS: 0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(19, 120);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(256, 17);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "TOTAL PROCCESS TIME IS: 0 ms.";
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
            // btnViewResult
            // 
            this.btnViewResult.Location = new System.Drawing.Point(10, 4);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(83, 23);
            this.btnViewResult.TabIndex = 6;
            this.btnViewResult.Text = "ViewResult";
            this.btnViewResult.UseVisualStyleBackColor = true;
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.Location = new System.Drawing.Point(104, 9);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(91, 13);
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
            this.btnRun.Location = new System.Drawing.Point(534, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 22);
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
            this.btnClose.Size = new System.Drawing.Size(75, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialogCalls
            // 
            this.openFileDialogCalls.FileName = "openFileDialog1";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(104, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Visible = false;
            // 
            // BillingSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 493);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(706, 521);
            this.Name = "BillingSystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingSystem";
            this.Load += new System.EventHandler(this.BillingSystem_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            this.tabCommon.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.grBoxUser.ResumeLayout(false);
            this.grBoxUser.PerformLayout();
            this.grBoxInformation.ResumeLayout(false);
            this.grBoxInformation.PerformLayout();
            this.tabCountry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCountry)).EndInit();
            this.tabRates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRates)).EndInit();
            this.tabCalls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProccess;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox grBoxInformation;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grBoxUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnViewResult;
        private System.Windows.Forms.Label lblOutput;



    }
}

