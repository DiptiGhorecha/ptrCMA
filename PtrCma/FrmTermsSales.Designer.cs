namespace PtrCma
{
    partial class FrmTermsSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTermsSales));
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtCreditD = new System.Windows.Forms.TextBox();
            this.txtCreditE = new System.Windows.Forms.TextBox();
            this.lblDomestic = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtPeriodD = new System.Windows.Forms.TextBox();
            this.txtPeriodE = new System.Windows.Forms.TextBox();
            this.txtAverageD = new System.Windows.Forms.TextBox();
            this.txtAverageE = new System.Windows.Forms.TextBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCredit
            // 
            this.lblCredit.Location = new System.Drawing.Point(165, 148);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(143, 20);
            this.lblCredit.TabIndex = 0;
            this.lblCredit.Text = "Credit Sales to Total Sales";
            // 
            // txtCreditD
            // 
            this.txtCreditD.Location = new System.Drawing.Point(323, 148);
            this.txtCreditD.Name = "txtCreditD";
            this.txtCreditD.Size = new System.Drawing.Size(100, 20);
            this.txtCreditD.TabIndex = 1;
            // 
            // txtCreditE
            // 
            this.txtCreditE.Location = new System.Drawing.Point(438, 148);
            this.txtCreditE.Name = "txtCreditE";
            this.txtCreditE.Size = new System.Drawing.Size(100, 20);
            this.txtCreditE.TabIndex = 2;
            // 
            // lblDomestic
            // 
            this.lblDomestic.Location = new System.Drawing.Point(323, 109);
            this.lblDomestic.Name = "lblDomestic";
            this.lblDomestic.Size = new System.Drawing.Size(100, 20);
            this.lblDomestic.TabIndex = 3;
            this.lblDomestic.Text = "Domestic";
            this.lblDomestic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExport
            // 
            this.lblExport.Location = new System.Drawing.Point(438, 109);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(100, 20);
            this.lblExport.TabIndex = 4;
            this.lblExport.Text = "Export";
            this.lblExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeriod
            // 
            this.lblPeriod.Location = new System.Drawing.Point(165, 174);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(143, 20);
            this.lblPeriod.TabIndex = 5;
            this.lblPeriod.Text = "Period of Credit Given";
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(165, 200);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(143, 20);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "Average Receivable Level";
            // 
            // txtPeriodD
            // 
            this.txtPeriodD.Location = new System.Drawing.Point(323, 174);
            this.txtPeriodD.Name = "txtPeriodD";
            this.txtPeriodD.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodD.TabIndex = 7;
            // 
            // txtPeriodE
            // 
            this.txtPeriodE.Location = new System.Drawing.Point(438, 174);
            this.txtPeriodE.Name = "txtPeriodE";
            this.txtPeriodE.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodE.TabIndex = 8;
            // 
            // txtAverageD
            // 
            this.txtAverageD.Location = new System.Drawing.Point(323, 200);
            this.txtAverageD.Name = "txtAverageD";
            this.txtAverageD.Size = new System.Drawing.Size(100, 20);
            this.txtAverageD.TabIndex = 9;
            // 
            // txtAverageE
            // 
            this.txtAverageE.Location = new System.Drawing.Point(438, 200);
            this.txtAverageE.Name = "txtAverageE";
            this.txtAverageE.Size = new System.Drawing.Size(100, 20);
            this.txtAverageE.TabIndex = 10;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(493, 249);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(40, 23);
            this.cmdExit.TabIndex = 23;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PtrCma.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(703, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(86, 23);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(532, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 79;
            this.pictitle.TabStop = false;
            // 
            // FrmTermsSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 300);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictitle);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.txtAverageE);
            this.Controls.Add(this.txtAverageD);
            this.Controls.Add(this.txtPeriodE);
            this.Controls.Add(this.txtPeriodD);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.lblDomestic);
            this.Controls.Add(this.txtCreditE);
            this.Controls.Add(this.txtCreditD);
            this.Controls.Add(this.lblCredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTermsSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmTermsSales";
            this.Load += new System.EventHandler(this.FrmTermsSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.TextBox txtCreditD;
        private System.Windows.Forms.TextBox txtCreditE;
        private System.Windows.Forms.Label lblDomestic;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtPeriodD;
        private System.Windows.Forms.TextBox txtPeriodE;
        private System.Windows.Forms.TextBox txtAverageD;
        private System.Windows.Forms.TextBox txtAverageE;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictitle;
    }
}