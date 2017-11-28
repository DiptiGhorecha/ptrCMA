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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblExcise = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(375, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(375, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(375, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(375, 233);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(435, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblExcise);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblExcise;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClose;
    }
}