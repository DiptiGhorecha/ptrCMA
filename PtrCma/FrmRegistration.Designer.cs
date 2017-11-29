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
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(731, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Detail of Registration Under Sales Tax/Vat";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPan
            // 
            this.lblPan.Location = new System.Drawing.Point(234, 109);
            this.lblPan.Name = "lblPan";
            this.lblPan.Size = new System.Drawing.Size(140, 23);
            this.lblPan.TabIndex = 1;
            this.lblPan.Text = "PAN";
            // 
            // txtPan
            // 
            this.txtPan.Location = new System.Drawing.Point(392, 106);
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(117, 20);
            this.txtPan.TabIndex = 2;
            // 
            // lblSales
            // 
            this.lblSales.Location = new System.Drawing.Point(234, 145);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(140, 23);
            this.lblSales.TabIndex = 3;
            this.lblSales.Text = "Sales Tax";
            // 
            // lblService
            // 
            this.lblService.Location = new System.Drawing.Point(234, 183);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(140, 23);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service Tax";
            // 
            // lblExcise
            // 
            this.lblExcise.Location = new System.Drawing.Point(234, 226);
            this.lblExcise.Name = "lblExcise";
            this.lblExcise.Size = new System.Drawing.Size(140, 23);
            this.lblExcise.TabIndex = 5;
            this.lblExcise.Text = "Excise";
            // 
            // lblOther
            // 
            this.lblOther.Location = new System.Drawing.Point(234, 261);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(140, 23);
            this.lblOther.TabIndex = 6;
            this.lblOther.Text = "Other";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(392, 142);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(117, 20);
            this.txtSales.TabIndex = 7;
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(392, 180);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(117, 20);
            this.txtService.TabIndex = 8;
            // 
            // txtExcise
            // 
            this.txtExcise.Location = new System.Drawing.Point(392, 223);
            this.txtExcise.Name = "txtExcise";
            this.txtExcise.Size = new System.Drawing.Size(117, 20);
            this.txtExcise.TabIndex = 9;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(392, 258);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(117, 20);
            this.txtOther.TabIndex = 10;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(459, 307);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(49, 23);
            this.cmdExit.TabIndex = 11;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(757, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 25);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 355);
            this.Controls.Add(this.btnClose);
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
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.Button btnClose;
    }
}