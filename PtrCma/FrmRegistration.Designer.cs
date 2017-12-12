namespace PtrCma
{
    partial class FrmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistration));
            this.lblPan = new System.Windows.Forms.Label();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblExcise = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtExcise = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.picFrmClose = new System.Windows.Forms.PictureBox();
            this.pictitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPan
            // 
            this.lblPan.Location = new System.Drawing.Point(171, 106);
            this.lblPan.Name = "lblPan";
            this.lblPan.Size = new System.Drawing.Size(140, 23);
            this.lblPan.TabIndex = 1;
            this.lblPan.Text = "PAN";
            // 
            // txtPan
            // 
            this.txtPan.Location = new System.Drawing.Point(347, 106);
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(117, 20);
            this.txtPan.TabIndex = 2;
            // 
            // lblSales
            // 
            this.lblSales.Location = new System.Drawing.Point(171, 131);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(140, 23);
            this.lblSales.TabIndex = 3;
            this.lblSales.Text = "Sales Tax";
            // 
            // lblService
            // 
            this.lblService.Location = new System.Drawing.Point(171, 157);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(140, 23);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service Tax";
            // 
            // lblExcise
            // 
            this.lblExcise.Location = new System.Drawing.Point(171, 182);
            this.lblExcise.Name = "lblExcise";
            this.lblExcise.Size = new System.Drawing.Size(140, 23);
            this.lblExcise.TabIndex = 5;
            this.lblExcise.Text = "Excise";
            // 
            // lblOther
            // 
            this.lblOther.Location = new System.Drawing.Point(171, 207);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(140, 23);
            this.lblOther.TabIndex = 6;
            this.lblOther.Text = "Other";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(347, 131);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(117, 20);
            this.txtSales.TabIndex = 7;
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(347, 157);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(117, 20);
            this.txtService.TabIndex = 8;
            // 
            // txtExcise
            // 
            this.txtExcise.Location = new System.Drawing.Point(347, 182);
            this.txtExcise.Name = "txtExcise";
            this.txtExcise.Size = new System.Drawing.Size(117, 20);
            this.txtExcise.TabIndex = 9;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(347, 207);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(117, 20);
            this.txtOther.TabIndex = 10;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(520, 257);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(49, 23);
            this.cmdExit.TabIndex = 11;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picFrmClose
            // 
            this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
            this.picFrmClose.Location = new System.Drawing.Point(697, 21);
            this.picFrmClose.Name = "picFrmClose";
            this.picFrmClose.Size = new System.Drawing.Size(25, 30);
            this.picFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrmClose.TabIndex = 39;
            this.picFrmClose.TabStop = false;
            this.picFrmClose.Click += new System.EventHandler(this.picFrmClose_Click);
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(104, 21);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(511, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 38;
            this.pictitle.TabStop = false;
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 302);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.pictitle);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtExcise);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblExcise);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.txtPan);
            this.Controls.Add(this.lblPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPan;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblExcise;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtExcise;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.PictureBox pictitle;
    }
}