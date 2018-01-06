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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCMA));
            this.lstViewTopic = new System.Windows.Forms.ListView();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridViewCMA = new System.Windows.Forms.DataGridView();
            this.panelCmdBtns = new System.Windows.Forms.Panel();
            this.txtCurYear = new System.Windows.Forms.TextBox();
            this.comboBoxRsIn = new System.Windows.Forms.ComboBox();
            this.txtPrtyName = new System.Windows.Forms.TextBox();
            this.comboBoxCopyYear = new System.Windows.Forms.ComboBox();
            this.comboBxYear = new System.Windows.Forms.ComboBox();
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
            this.cmdInsRow = new System.Windows.Forms.Button();
            this.cmdRsIn = new System.Windows.Forms.Button();
            this.cmdCopyYr = new System.Windows.Forms.Button();
            this.cmdCurYr = new System.Windows.Forms.Button();
            this.cmdChngPrty = new System.Windows.Forms.Button();
            this.lblPic = new System.Windows.Forms.PictureBox();
            this.picFrmClose = new System.Windows.Forms.PictureBox();
            this.grdViewCMAOther = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCMA)).BeginInit();
            this.panelCmdBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewCMAOther)).BeginInit();
            this.SuspendLayout();
            // 
            // lstViewTopic
            // 
            this.lstViewTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstViewTopic.HideSelection = false;
            this.lstViewTopic.Location = new System.Drawing.Point(0, 47);
            this.lstViewTopic.MultiSelect = false;
            this.lstViewTopic.Name = "lstViewTopic";
            this.lstViewTopic.OwnerDraw = true;
            this.lstViewTopic.Size = new System.Drawing.Size(265, 87);
            this.lstViewTopic.TabIndex = 0;
            this.lstViewTopic.UseCompatibleStateImageBehavior = false;
            this.lstViewTopic.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lstViewTopic_DrawColumnHeader);
            this.lstViewTopic.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lstViewTopic_DrawItem);
            this.lstViewTopic.Click += new System.EventHandler(this.lstViewTopic_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(718, 47);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(328, 118);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // gridViewCMA
            // 
            this.gridViewCMA.AllowUserToAddRows = false;
            this.gridViewCMA.AllowUserToDeleteRows = false;
            this.gridViewCMA.AllowUserToResizeRows = false;
            this.gridViewCMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCMA.Location = new System.Drawing.Point(0, 302);
            this.gridViewCMA.Name = "gridViewCMA";
            this.gridViewCMA.RowHeadersVisible = false;
            this.gridViewCMA.ShowEditingIcon = false;
            this.gridViewCMA.Size = new System.Drawing.Size(865, 103);
            this.gridViewCMA.TabIndex = 24;
            this.gridViewCMA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCMA_CellClick);
            this.gridViewCMA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCMA_CellDoubleClick);
            this.gridViewCMA.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridViewCMA_CellFormatting);
            // 
            // panelCmdBtns
            // 
            this.panelCmdBtns.BackColor = System.Drawing.Color.Transparent;
            this.panelCmdBtns.Controls.Add(this.txtCurYear);
            this.panelCmdBtns.Controls.Add(this.comboBoxRsIn);
            this.panelCmdBtns.Controls.Add(this.txtPrtyName);
            this.panelCmdBtns.Controls.Add(this.comboBoxCopyYear);
            this.panelCmdBtns.Controls.Add(this.comboBxYear);
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
            this.panelCmdBtns.Controls.Add(this.cmdInsRow);
            this.panelCmdBtns.Controls.Add(this.cmdRsIn);
            this.panelCmdBtns.Controls.Add(this.cmdCopyYr);
            this.panelCmdBtns.Controls.Add(this.cmdCurYr);
            this.panelCmdBtns.Controls.Add(this.cmdChngPrty);
            this.panelCmdBtns.Location = new System.Drawing.Point(271, 47);
            this.panelCmdBtns.Name = "panelCmdBtns";
            this.panelCmdBtns.Size = new System.Drawing.Size(449, 149);
            this.panelCmdBtns.TabIndex = 26;
            // 
            // txtCurYear
            // 
            this.txtCurYear.Location = new System.Drawing.Point(79, 38);
            this.txtCurYear.Name = "txtCurYear";
            this.txtCurYear.Size = new System.Drawing.Size(48, 20);
            this.txtCurYear.TabIndex = 44;
            // 
            // comboBoxRsIn
            // 
            this.comboBoxRsIn.FormattingEnabled = true;
            this.comboBoxRsIn.Items.AddRange(new object[] {
            "Rs",
            "Thousands",
            "Lakhs",
            "Crores"});
            this.comboBoxRsIn.Location = new System.Drawing.Point(374, 39);
            this.comboBoxRsIn.Name = "comboBoxRsIn";
            this.comboBoxRsIn.Size = new System.Drawing.Size(65, 21);
            this.comboBoxRsIn.TabIndex = 43;
            // 
            // txtPrtyName
            // 
            this.txtPrtyName.Location = new System.Drawing.Point(95, 9);
            this.txtPrtyName.Name = "txtPrtyName";
            this.txtPrtyName.Size = new System.Drawing.Size(348, 20);
            this.txtPrtyName.TabIndex = 42;
            // 
            // comboBoxCopyYear
            // 
            this.comboBoxCopyYear.FormattingEnabled = true;
            this.comboBoxCopyYear.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxCopyYear.Location = new System.Drawing.Point(191, 38);
            this.comboBoxCopyYear.Name = "comboBoxCopyYear";
            this.comboBoxCopyYear.Size = new System.Drawing.Size(48, 21);
            this.comboBoxCopyYear.TabIndex = 41;
            // 
            // comboBxYear
            // 
            this.comboBxYear.FormattingEnabled = true;
            this.comboBxYear.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBxYear.Location = new System.Drawing.Point(133, 37);
            this.comboBxYear.Name = "comboBxYear";
            this.comboBxYear.Size = new System.Drawing.Size(48, 21);
            this.comboBxYear.TabIndex = 40;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(384, 107);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(58, 35);
            this.cmdPrint.TabIndex = 39;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // cmdExport
            // 
            this.cmdExport.Location = new System.Drawing.Point(321, 107);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(58, 35);
            this.cmdExport.TabIndex = 38;
            this.cmdExport.Text = "Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            // 
            // cmdFormula
            // 
            this.cmdFormula.Location = new System.Drawing.Point(258, 107);
            this.cmdFormula.Name = "cmdFormula";
            this.cmdFormula.Size = new System.Drawing.Size(58, 35);
            this.cmdFormula.TabIndex = 37;
            this.cmdFormula.Text = "Formula";
            this.cmdFormula.UseVisualStyleBackColor = true;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(195, 107);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(58, 35);
            this.cmdRefresh.TabIndex = 36;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(132, 107);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(58, 35);
            this.cmdCancel.TabIndex = 35;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(69, 107);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(58, 35);
            this.cmdSave.TabIndex = 34;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.cmdEdit.ForeColor = System.Drawing.Color.White;
            this.cmdEdit.Location = new System.Drawing.Point(6, 107);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(58, 35);
            this.cmdEdit.TabIndex = 33;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = false;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdPrntGrph
            // 
            this.cmdPrntGrph.Location = new System.Drawing.Point(360, 68);
            this.cmdPrntGrph.Name = "cmdPrntGrph";
            this.cmdPrntGrph.Size = new System.Drawing.Size(81, 32);
            this.cmdPrntGrph.TabIndex = 32;
            this.cmdPrntGrph.Text = "Print Graph";
            this.cmdPrntGrph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPrntGrph.UseVisualStyleBackColor = true;
            // 
            // cmdResetDeta
            // 
            this.cmdResetDeta.Location = new System.Drawing.Point(281, 68);
            this.cmdResetDeta.Name = "cmdResetDeta";
            this.cmdResetDeta.Size = new System.Drawing.Size(76, 32);
            this.cmdResetDeta.TabIndex = 31;
            this.cmdResetDeta.Text = "Reset Data";
            this.cmdResetDeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdResetDeta.UseVisualStyleBackColor = true;
            // 
            // cmdChngDesc
            // 
            this.cmdChngDesc.Location = new System.Drawing.Point(161, 68);
            this.cmdChngDesc.Name = "cmdChngDesc";
            this.cmdChngDesc.Size = new System.Drawing.Size(117, 32);
            this.cmdChngDesc.TabIndex = 30;
            this.cmdChngDesc.Text = "Change Description";
            this.cmdChngDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdChngDesc.UseVisualStyleBackColor = true;
            // 
            // cmdDelRow
            // 
            this.cmdDelRow.Location = new System.Drawing.Point(78, 68);
            this.cmdDelRow.Name = "cmdDelRow";
            this.cmdDelRow.Size = new System.Drawing.Size(80, 32);
            this.cmdDelRow.TabIndex = 29;
            this.cmdDelRow.Text = "Delete Row";
            this.cmdDelRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDelRow.UseVisualStyleBackColor = true;
            // 
            // cmdInsRow
            // 
            this.cmdInsRow.Location = new System.Drawing.Point(6, 68);
            this.cmdInsRow.Name = "cmdInsRow";
            this.cmdInsRow.Size = new System.Drawing.Size(69, 32);
            this.cmdInsRow.TabIndex = 28;
            this.cmdInsRow.Text = "Insert Row";
            this.cmdInsRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdInsRow.UseVisualStyleBackColor = true;
            // 
            // cmdRsIn
            // 
            this.cmdRsIn.Location = new System.Drawing.Point(323, 37);
            this.cmdRsIn.Name = "cmdRsIn";
            this.cmdRsIn.Size = new System.Drawing.Size(45, 23);
            this.cmdRsIn.TabIndex = 27;
            this.cmdRsIn.Text = "Rs In";
            this.cmdRsIn.UseVisualStyleBackColor = true;
            // 
            // cmdCopyYr
            // 
            this.cmdCopyYr.Location = new System.Drawing.Point(249, 37);
            this.cmdCopyYr.Name = "cmdCopyYr";
            this.cmdCopyYr.Size = new System.Drawing.Size(67, 23);
            this.cmdCopyYr.TabIndex = 26;
            this.cmdCopyYr.Text = "Copy Year";
            this.cmdCopyYr.UseVisualStyleBackColor = true;
            // 
            // cmdCurYr
            // 
            this.cmdCurYr.Location = new System.Drawing.Point(6, 37);
            this.cmdCurYr.Name = "cmdCurYr";
            this.cmdCurYr.Size = new System.Drawing.Size(67, 23);
            this.cmdCurYr.TabIndex = 25;
            this.cmdCurYr.Text = "Cur Year";
            this.cmdCurYr.UseVisualStyleBackColor = true;
            this.cmdCurYr.Click += new System.EventHandler(this.cmdCurYr_Click);
            // 
            // cmdChngPrty
            // 
            this.cmdChngPrty.Location = new System.Drawing.Point(6, 6);
            this.cmdChngPrty.Name = "cmdChngPrty";
            this.cmdChngPrty.Size = new System.Drawing.Size(81, 23);
            this.cmdChngPrty.TabIndex = 24;
            this.cmdChngPrty.Text = "Change Party";
            this.cmdChngPrty.UseVisualStyleBackColor = true;
            this.cmdChngPrty.Click += new System.EventHandler(this.cmdChngPrty_Click);
            // 
            // lblPic
            // 
            this.lblPic.BackColor = System.Drawing.Color.Transparent;
            this.lblPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblPic.Image = ((System.Drawing.Image)(resources.GetObject("lblPic.Image")));
            this.lblPic.Location = new System.Drawing.Point(0, 5);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(733, 30);
            this.lblPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblPic.TabIndex = 45;
            this.lblPic.TabStop = false;
            // 
            // picFrmClose
            // 
            this.picFrmClose.BackColor = System.Drawing.SystemColors.Control;
            this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrmClose.Image = ((System.Drawing.Image)(resources.GetObject("picFrmClose.Image")));
            this.picFrmClose.Location = new System.Drawing.Point(690, 9);
            this.picFrmClose.Name = "picFrmClose";
            this.picFrmClose.Size = new System.Drawing.Size(28, 26);
            this.picFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrmClose.TabIndex = 46;
            this.picFrmClose.TabStop = false;
            this.picFrmClose.Click += new System.EventHandler(this.picFrmClose_Click);
            // 
            // grdViewCMAOther
            // 
            this.grdViewCMAOther.AllowUserToAddRows = false;
            this.grdViewCMAOther.AllowUserToDeleteRows = false;
            this.grdViewCMAOther.AllowUserToResizeRows = false;
            this.grdViewCMAOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewCMAOther.Location = new System.Drawing.Point(46, 302);
            this.grdViewCMAOther.Name = "grdViewCMAOther";
            this.grdViewCMAOther.RowHeadersVisible = false;
            this.grdViewCMAOther.ShowEditingIcon = false;
            this.grdViewCMAOther.Size = new System.Drawing.Size(865, 103);
            this.grdViewCMAOther.TabIndex = 47;
            this.grdViewCMAOther.Visible = false;
            // 
            // FrmCMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 417);
            this.ControlBox = false;
            this.Controls.Add(this.grdViewCMAOther);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.lblPic);
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
            this.Activated += new System.EventHandler(this.FrmCMA_Load);
            this.Load += new System.EventHandler(this.FrmCMA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCMA)).EndInit();
            this.panelCmdBtns.ResumeLayout(false);
            this.panelCmdBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewCMAOther)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewTopic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridView gridViewCMA;
        private System.Windows.Forms.Panel panelCmdBtns;
        private System.Windows.Forms.TextBox txtCurYear;
        private System.Windows.Forms.ComboBox comboBoxRsIn;
        private System.Windows.Forms.TextBox txtPrtyName;
        private System.Windows.Forms.ComboBox comboBoxCopyYear;
        private System.Windows.Forms.ComboBox comboBxYear;
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
        private System.Windows.Forms.Button cmdInsRow;
        private System.Windows.Forms.Button cmdRsIn;
        private System.Windows.Forms.Button cmdCopyYr;
        private System.Windows.Forms.Button cmdCurYr;
        private System.Windows.Forms.Button cmdChngPrty;
        private System.Windows.Forms.PictureBox lblPic;
        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.DataGridView grdViewCMAOther;
    }
}