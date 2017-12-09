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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankingArrangements));
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
            this.pictitle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBanking
            // 
            this.grdBanking.AllowUserToAddRows = false;
            this.grdBanking.AllowUserToDeleteRows = false;
            this.grdBanking.AllowUserToResizeColumns = false;
            this.grdBanking.AllowUserToResizeRows = false;
            this.grdBanking.BackgroundColor = System.Drawing.Color.White;
            this.grdBanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdBanking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdBanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBanking.Location = new System.Drawing.Point(33, 118);
            this.grdBanking.Name = "grdBanking";
            this.grdBanking.RowHeadersVisible = false;
            this.grdBanking.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdBanking.Size = new System.Drawing.Size(258, 200);
            this.grdBanking.TabIndex = 1;
            this.grdBanking.TabStop = false;
            // 
            // lblBank
            // 
            this.lblBank.Location = new System.Drawing.Point(321, 155);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(117, 17);
            this.lblBank.TabIndex = 2;
            this.lblBank.Text = "Name of Bank/Branch";
            // 
            // lblFacility
            // 
            this.lblFacility.Location = new System.Drawing.Point(321, 180);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(117, 17);
            this.lblFacility.TabIndex = 3;
            this.lblFacility.Text = "Facility";
            // 
            // lblLimit
            // 
            this.lblLimit.Location = new System.Drawing.Point(321, 205);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(117, 17);
            this.lblLimit.TabIndex = 4;
            this.lblLimit.Text = "Limit";
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.Location = new System.Drawing.Point(321, 230);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(117, 17);
            this.lblOutstanding.TabIndex = 5;
            this.lblOutstanding.Text = "Outstanding";
            // 
            // lblSince
            // 
            this.lblSince.Location = new System.Drawing.Point(321, 255);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(117, 17);
            this.lblSince.TabIndex = 6;
            this.lblSince.Text = "Banking Since";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(503, 155);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(220, 20);
            this.txtBank.TabIndex = 7;
            // 
            // txtFacility
            // 
            this.txtFacility.Location = new System.Drawing.Point(503, 180);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.Size = new System.Drawing.Size(220, 20);
            this.txtFacility.TabIndex = 8;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(503, 205);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(220, 20);
            this.txtLimit.TabIndex = 9;
            // 
            // txtOutstanding
            // 
            this.txtOutstanding.Location = new System.Drawing.Point(503, 230);
            this.txtOutstanding.Name = "txtOutstanding";
            this.txtOutstanding.Size = new System.Drawing.Size(220, 20);
            this.txtOutstanding.TabIndex = 10;
            // 
            // txtSince
            // 
            this.txtSince.Location = new System.Drawing.Point(503, 255);
            this.txtSince.Name = "txtSince";
            this.txtSince.Size = new System.Drawing.Size(220, 20);
            this.txtSince.TabIndex = 11;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(686, 332);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(40, 23);
            this.cmdExit.TabIndex = 19;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(604, 332);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(47, 23);
            this.cmdDelete.TabIndex = 18;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(533, 332);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(39, 23);
            this.cmdAdd.TabIndex = 17;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(117, 20);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(532, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 20;
            this.pictitle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PtrCma.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(713, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBankingArrangements
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictitle);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBankingArrangements";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmBankingArrangements";
            this.Load += new System.EventHandler(this.FrmBankingArrangements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}