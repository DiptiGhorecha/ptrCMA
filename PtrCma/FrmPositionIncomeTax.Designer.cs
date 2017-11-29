namespace PtrCma
{
    partial class FrmPositionIncomeTax
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
            this.lblIncome = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
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
            this.lblTitle.Location = new System.Drawing.Point(28, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(702, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Position Regarding Statutory assessment under Income - tax/Sales - tax";
            // 
            // lblIncome
            // 
            this.lblIncome.Location = new System.Drawing.Point(214, 112);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(155, 20);
            this.lblIncome.TabIndex = 1;
            this.lblIncome.Text = "Income Tax";
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(375, 112);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(100, 20);
            this.txtIncome.TabIndex = 2;
            // 
            // lblSales
            // 
            this.lblSales.Location = new System.Drawing.Point(214, 142);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(155, 20);
            this.lblSales.TabIndex = 3;
            this.lblSales.Text = "Sales Tax";
            // 
            // lblService
            // 
            this.lblService.Location = new System.Drawing.Point(214, 175);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(155, 20);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service Tax";
            // 
            // lblExcise
            // 
            this.lblExcise.Location = new System.Drawing.Point(214, 206);
            this.lblExcise.Name = "lblExcise";
            this.lblExcise.Size = new System.Drawing.Size(155, 20);
            this.lblExcise.TabIndex = 5;
            this.lblExcise.Text = "Excise";
            // 
            // lblOther
            // 
            this.lblOther.Location = new System.Drawing.Point(214, 236);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(155, 20);
            this.lblOther.TabIndex = 6;
            this.lblOther.Text = "Other";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(375, 139);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 20);
            this.txtSales.TabIndex = 7;
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(375, 172);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(100, 20);
            this.txtService.TabIndex = 8;
            // 
            // txtExcise
            // 
            this.txtExcise.Location = new System.Drawing.Point(375, 203);
            this.txtExcise.Name = "txtExcise";
            this.txtExcise.Size = new System.Drawing.Size(100, 20);
            this.txtExcise.TabIndex = 9;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(375, 233);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(100, 20);
            this.txtOther.TabIndex = 10;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(435, 274);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(40, 23);
            this.cmdExit.TabIndex = 20;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(731, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 25);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmPositionIncomeTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
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
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPositionIncomeTax";
            this.Text = "FrmPositionIncomeTax";
            this.Load += new System.EventHandler(this.FrmPositionIncomeTax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.TextBox txtIncome;
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