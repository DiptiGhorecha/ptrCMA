namespace PtrCma
{
    partial class FrmBankingArrangements
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
            this.grdBanking = new System.Windows.Forms.DataGridView();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblFacility = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.lblSince = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtFacility = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.txtOutstanding = new System.Windows.Forms.TextBox();
            this.txtSince = new System.Windows.Forms.TextBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBanking)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(34, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(670, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Detail of existing Banking arrangements";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdBanking
            // 
            this.grdBanking.BackgroundColor = System.Drawing.Color.White;
            this.grdBanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBanking.Location = new System.Drawing.Point(22, 121);
            this.grdBanking.Name = "grdBanking";
            this.grdBanking.Size = new System.Drawing.Size(258, 200);
            this.grdBanking.TabIndex = 1;
            // 
            // lblBank
            // 
            this.lblBank.Location = new System.Drawing.Point(311, 127);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(117, 17);
            this.lblBank.TabIndex = 2;
            this.lblBank.Text = "Name of Bank/Branch";
            // 
            // lblFacility
            // 
            this.lblFacility.Location = new System.Drawing.Point(311, 156);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(117, 17);
            this.lblFacility.TabIndex = 3;
            this.lblFacility.Text = "Facility";
            // 
            // lblLimit
            // 
            this.lblLimit.Location = new System.Drawing.Point(311, 186);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(117, 17);
            this.lblLimit.TabIndex = 4;
            this.lblLimit.Text = "Limit";
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.Location = new System.Drawing.Point(311, 215);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(117, 17);
            this.lblOutstanding.TabIndex = 5;
            this.lblOutstanding.Text = "Outstanding";
            // 
            // lblSince
            // 
            this.lblSince.Location = new System.Drawing.Point(311, 243);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(117, 17);
            this.lblSince.TabIndex = 6;
            this.lblSince.Text = "Banking Since";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(434, 124);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(301, 20);
            this.txtBank.TabIndex = 7;
            // 
            // txtFacility
            // 
            this.txtFacility.Location = new System.Drawing.Point(434, 153);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.Size = new System.Drawing.Size(301, 20);
            this.txtFacility.TabIndex = 8;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(434, 183);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(301, 20);
            this.txtLimit.TabIndex = 9;
            // 
            // txtOutstanding
            // 
            this.txtOutstanding.Location = new System.Drawing.Point(434, 212);
            this.txtOutstanding.Name = "txtOutstanding";
            this.txtOutstanding.Size = new System.Drawing.Size(301, 20);
            this.txtOutstanding.TabIndex = 10;
            // 
            // txtSince
            // 
            this.txtSince.Location = new System.Drawing.Point(434, 240);
            this.txtSince.Name = "txtSince";
            this.txtSince.Size = new System.Drawing.Size(301, 20);
            this.txtSince.TabIndex = 11;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(695, 298);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(40, 23);
            this.cmdExit.TabIndex = 19;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(613, 298);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(47, 23);
            this.cmdDelete.TabIndex = 18;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(542, 298);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(39, 23);
            this.cmdAdd.TabIndex = 17;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(703, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 25);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmBankingArrangements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtSince);
            this.Controls.Add(this.txtOutstanding);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtFacility);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.lblSince);
            this.Controls.Add(this.lblOutstanding);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblFacility);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.grdBanking);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankingArrangements";
            this.Text = "FrmBankingArrangements";
            this.Load += new System.EventHandler(this.FrmBankingArrangements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdBanking;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblOutstanding;
        private System.Windows.Forms.Label lblSince;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtFacility;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.TextBox txtOutstanding;
        private System.Windows.Forms.TextBox txtSince;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button btnClose;
    }
}