namespace PtrCma
{
    partial class FrmCMA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lstViewTopic = new System.Windows.Forms.ListView();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridViewCMA = new System.Windows.Forms.DataGridView();
            this.panelCmdBtns = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdExport = new System.Windows.Forms.Button();
            this.cmdFormula = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdPrntGrph = new System.Windows.Forms.Button();
            this.cmdResetDeta = new System.Windows.Forms.Button();
            this.cmdChngDesc = new System.Windows.Forms.Button();
            this.cmdDelRow = new System.Windows.Forms.Button();
            this.btnInsRow = new System.Windows.Forms.Button();
            this.cmdRsIn = new System.Windows.Forms.Button();
            this.cmdCopyYr = new System.Windows.Forms.Button();
            this.cmdCurYr = new System.Windows.Forms.Button();
            this.cmdChngPrty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCMA)).BeginInit();
            this.panelCmdBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstViewTopic
            // 
            this.lstViewTopic.Location = new System.Drawing.Point(0, 31);
            this.lstViewTopic.Name = "lstViewTopic";
            this.lstViewTopic.Size = new System.Drawing.Size(265, 87);
            this.lstViewTopic.TabIndex = 0;
            this.lstViewTopic.UseCompatibleStateImageBehavior = false;
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(718, 0);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(328, 118);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // gridViewCMA
            // 
            this.gridViewCMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCMA.Location = new System.Drawing.Point(0, 302);
            this.gridViewCMA.Name = "gridViewCMA";
            this.gridViewCMA.RowHeadersVisible = false;
            this.gridViewCMA.ShowEditingIcon = false;
            this.gridViewCMA.Size = new System.Drawing.Size(865, 103);
            this.gridViewCMA.TabIndex = 24;
            this.gridViewCMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gridViewCMA.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridViewCMA_CellFormatting);
            // 
            // panelCmdBtns
            // 
            this.panelCmdBtns.Controls.Add(this.textBox2);
            this.panelCmdBtns.Controls.Add(this.comboBox3);
            this.panelCmdBtns.Controls.Add(this.textBox1);
            this.panelCmdBtns.Controls.Add(this.comboBox2);
            this.panelCmdBtns.Controls.Add(this.comboBox1);
            this.panelCmdBtns.Controls.Add(this.cmdPrint);
            this.panelCmdBtns.Controls.Add(this.cmdExport);
            this.panelCmdBtns.Controls.Add(this.cmdFormula);
            this.panelCmdBtns.Controls.Add(this.cmdRefresh);
            this.panelCmdBtns.Controls.Add(this.cmdCancel);
            this.panelCmdBtns.Controls.Add(this.cmdSave);
            this.panelCmdBtns.Controls.Add(this.cmdEdit);
            this.panelCmdBtns.Controls.Add(this.cmdPrntGrph);
            this.panelCmdBtns.Controls.Add(this.cmdResetDeta);
            this.panelCmdBtns.Controls.Add(this.cmdChngDesc);
            this.panelCmdBtns.Controls.Add(this.cmdDelRow);
            this.panelCmdBtns.Controls.Add(this.btnInsRow);
            this.panelCmdBtns.Controls.Add(this.cmdRsIn);
            this.panelCmdBtns.Controls.Add(this.cmdCopyYr);
            this.panelCmdBtns.Controls.Add(this.cmdCurYr);
            this.panelCmdBtns.Controls.Add(this.cmdChngPrty);
            this.panelCmdBtns.Location = new System.Drawing.Point(271, 31);
            this.panelCmdBtns.Name = "panelCmdBtns";
            this.panelCmdBtns.Size = new System.Drawing.Size(449, 120);
            this.panelCmdBtns.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 44;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(384, 32);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(55, 21);
            this.comboBox3.TabIndex = 43;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 42;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(197, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(58, 21);
            this.comboBox2.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(384, 82);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(58, 35);
            this.cmdPrint.TabIndex = 39;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // cmdExport
            // 
            this.cmdExport.Location = new System.Drawing.Point(321, 82);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(58, 35);
            this.cmdExport.TabIndex = 38;
            this.cmdExport.Text = "Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            // 
            // cmdFormula
            // 
            this.cmdFormula.Location = new System.Drawing.Point(258, 82);
            this.cmdFormula.Name = "cmdFormula";
            this.cmdFormula.Size = new System.Drawing.Size(58, 35);
            this.cmdFormula.TabIndex = 37;
            this.cmdFormula.Text = "Formula";
            this.cmdFormula.UseVisualStyleBackColor = true;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(195, 82);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(58, 35);
            this.cmdRefresh.TabIndex = 36;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(132, 82);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(58, 35);
            this.cmdCancel.TabIndex = 35;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(69, 82);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(58, 35);
            this.cmdSave.TabIndex = 34;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(6, 82);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(58, 35);
            this.cmdEdit.TabIndex = 33;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            // 
            // cmdPrntGrph
            // 
            this.cmdPrntGrph.Location = new System.Drawing.Point(362, 56);
            this.cmdPrntGrph.Name = "cmdPrntGrph";
            this.cmdPrntGrph.Size = new System.Drawing.Size(81, 23);
            this.cmdPrntGrph.TabIndex = 32;
            this.cmdPrntGrph.Text = "Print Graph";
            this.cmdPrntGrph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPrntGrph.UseVisualStyleBackColor = true;
            // 
            // cmdResetDeta
            // 
            this.cmdResetDeta.Location = new System.Drawing.Point(273, 56);
            this.cmdResetDeta.Name = "cmdResetDeta";
            this.cmdResetDeta.Size = new System.Drawing.Size(86, 23);
            this.cmdResetDeta.TabIndex = 31;
            this.cmdResetDeta.Text = "Reset Data";
            this.cmdResetDeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdResetDeta.UseVisualStyleBackColor = true;
            // 
            // cmdChngDesc
            // 
            this.cmdChngDesc.Location = new System.Drawing.Point(184, 56);
            this.cmdChngDesc.Name = "cmdChngDesc";
            this.cmdChngDesc.Size = new System.Drawing.Size(86, 23);
            this.cmdChngDesc.TabIndex = 30;
            this.cmdChngDesc.Text = "Change Desc.";
            this.cmdChngDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdChngDesc.UseVisualStyleBackColor = true;
            // 
            // cmdDelRow
            // 
            this.cmdDelRow.Location = new System.Drawing.Point(95, 56);
            this.cmdDelRow.Name = "cmdDelRow";
            this.cmdDelRow.Size = new System.Drawing.Size(86, 23);
            this.cmdDelRow.TabIndex = 29;
            this.cmdDelRow.Text = "Delete Row";
            this.cmdDelRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDelRow.UseVisualStyleBackColor = true;
            // 
            // btnInsRow
            // 
            this.btnInsRow.Location = new System.Drawing.Point(6, 56);
            this.btnInsRow.Name = "btnInsRow";
            this.btnInsRow.Size = new System.Drawing.Size(86, 23);
            this.btnInsRow.TabIndex = 28;
            this.btnInsRow.Text = "Insert Row";
            this.btnInsRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsRow.UseVisualStyleBackColor = true;
            // 
            // cmdRsIn
            // 
            this.cmdRsIn.Location = new System.Drawing.Point(334, 30);
            this.cmdRsIn.Name = "cmdRsIn";
            this.cmdRsIn.Size = new System.Drawing.Size(45, 23);
            this.cmdRsIn.TabIndex = 27;
            this.cmdRsIn.Text = "Rs In";
            this.cmdRsIn.UseVisualStyleBackColor = true;
            // 
            // cmdCopyYr
            // 
            this.cmdCopyYr.Location = new System.Drawing.Point(261, 30);
            this.cmdCopyYr.Name = "cmdCopyYr";
            this.cmdCopyYr.Size = new System.Drawing.Size(67, 23);
            this.cmdCopyYr.TabIndex = 26;
            this.cmdCopyYr.Text = "Copy Year";
            this.cmdCopyYr.UseVisualStyleBackColor = true;
            // 
            // cmdCurYr
            // 
            this.cmdCurYr.Location = new System.Drawing.Point(6, 30);
            this.cmdCurYr.Name = "cmdCurYr";
            this.cmdCurYr.Size = new System.Drawing.Size(67, 23);
            this.cmdCurYr.TabIndex = 25;
            this.cmdCurYr.Text = "Cur Year";
            this.cmdCurYr.UseVisualStyleBackColor = true;
            // 
            // cmdChngPrty
            // 
            this.cmdChngPrty.Location = new System.Drawing.Point(6, 3);
            this.cmdChngPrty.Name = "cmdChngPrty";
            this.cmdChngPrty.Size = new System.Drawing.Size(81, 23);
            this.cmdChngPrty.TabIndex = 24;
            this.cmdChngPrty.Text = "Change Party";
            this.cmdChngPrty.UseVisualStyleBackColor = true;
            // 
            // FrmCMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 417);
            this.ControlBox = false;
            this.Controls.Add(this.panelCmdBtns);
            this.Controls.Add(this.gridViewCMA);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.lstViewTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmCMA";
            this.Load += new System.EventHandler(this.FrmCMA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCMA)).EndInit();
            this.panelCmdBtns.ResumeLayout(false);
            this.panelCmdBtns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewTopic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridView gridViewCMA;
        private System.Windows.Forms.Panel panelCmdBtns;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Button cmdExport;
        private System.Windows.Forms.Button cmdFormula;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdPrntGrph;
        private System.Windows.Forms.Button cmdResetDeta;
        private System.Windows.Forms.Button cmdChngDesc;
        private System.Windows.Forms.Button cmdDelRow;
        private System.Windows.Forms.Button btnInsRow;
        private System.Windows.Forms.Button cmdRsIn;
        private System.Windows.Forms.Button cmdCopyYr;
        private System.Windows.Forms.Button cmdCurYr;
        private System.Windows.Forms.Button cmdChngPrty;
    }
}