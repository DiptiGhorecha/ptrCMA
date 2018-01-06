namespace PtrCma
{
    partial class FrmProposedExpenditure
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProposedExpenditure));
			this.picFrmClose = new System.Windows.Forms.PictureBox();
			this.pictitle = new System.Windows.Forms.PictureBox();
			this.txtTotal1 = new System.Windows.Forms.TextBox();
			this.txtBank = new System.Windows.Forms.TextBox();
			this.txtLoan = new System.Windows.Forms.TextBox();
			this.txtOwn = new System.Windows.Forms.TextBox();
			this.cmdExit = new System.Windows.Forms.Button();
			this.lblAmt1 = new System.Windows.Forms.Label();
			this.lblLC1 = new System.Windows.Forms.Label();
			this.lblPC1 = new System.Windows.Forms.Label();
			this.lblDraft1 = new System.Windows.Forms.Label();
			this.lblCash1 = new System.Windows.Forms.Label();
			this.lblAmt = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtOther = new System.Windows.Forms.TextBox();
			this.txtEquip = new System.Windows.Forms.TextBox();
			this.lblLC = new System.Windows.Forms.Label();
			this.lblPC = new System.Windows.Forms.Label();
			this.lblDraft = new System.Windows.Forms.Label();
			this.txtBuild = new System.Windows.Forms.TextBox();
			this.lblCash = new System.Windows.Forms.Label();
			this.lblMeans = new System.Windows.Forms.Label();
			this.lblCost = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
			this.SuspendLayout();
			// 
			// picFrmClose
			// 
			this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
			this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
			this.picFrmClose.Location = new System.Drawing.Point(661, 26);
			this.picFrmClose.Name = "picFrmClose";
			this.picFrmClose.Size = new System.Drawing.Size(32, 32);
			this.picFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFrmClose.TabIndex = 36;
			this.picFrmClose.TabStop = false;
			this.picFrmClose.Click += new System.EventHandler(this.picFrmClose_Click);
			// 
			// pictitle
			// 
			this.pictitle.BackColor = System.Drawing.Color.Transparent;
			this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
			this.pictitle.Location = new System.Drawing.Point(91, 28);
			this.pictitle.Name = "pictitle";
			this.pictitle.Size = new System.Drawing.Size(511, 30);
			this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictitle.TabIndex = 35;
			this.pictitle.TabStop = false;
			// 
			// txtTotal1
			// 
			this.txtTotal1.Enabled = false;
			this.txtTotal1.Location = new System.Drawing.Point(514, 245);
			this.txtTotal1.Name = "txtTotal1";
			this.txtTotal1.Size = new System.Drawing.Size(100, 20);
			this.txtTotal1.TabIndex = 117;
			// 
			// txtBank
			// 
			this.txtBank.Location = new System.Drawing.Point(514, 219);
			this.txtBank.Name = "txtBank";
			this.txtBank.Size = new System.Drawing.Size(100, 20);
			this.txtBank.TabIndex = 116;
			this.txtBank.TextChanged += new System.EventHandler(this.txtOwn_TextChanged);
			// 
			// txtLoan
			// 
			this.txtLoan.Location = new System.Drawing.Point(514, 193);
			this.txtLoan.Name = "txtLoan";
			this.txtLoan.Size = new System.Drawing.Size(100, 20);
			this.txtLoan.TabIndex = 115;
			this.txtLoan.TextChanged += new System.EventHandler(this.txtOwn_TextChanged);
			// 
			// txtOwn
			// 
			this.txtOwn.Location = new System.Drawing.Point(514, 167);
			this.txtOwn.Name = "txtOwn";
			this.txtOwn.Size = new System.Drawing.Size(100, 20);
			this.txtOwn.TabIndex = 114;
			this.txtOwn.TextChanged += new System.EventHandler(this.txtOwn_TextChanged);
			// 
			// cmdExit
			// 
			this.cmdExit.Location = new System.Drawing.Point(562, 319);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(40, 23);
			this.cmdExit.TabIndex = 113;
			this.cmdExit.Text = "Exit";
			this.cmdExit.UseVisualStyleBackColor = true;
			this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblAmt1
			// 
			this.lblAmt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAmt1.Location = new System.Drawing.Point(514, 128);
			this.lblAmt1.Name = "lblAmt1";
			this.lblAmt1.Size = new System.Drawing.Size(100, 20);
			this.lblAmt1.TabIndex = 110;
			this.lblAmt1.Text = "Amt";
			this.lblAmt1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblLC1
			// 
			this.lblLC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLC1.Location = new System.Drawing.Point(364, 245);
			this.lblLC1.Name = "lblLC1";
			this.lblLC1.Size = new System.Drawing.Size(73, 20);
			this.lblLC1.TabIndex = 108;
			this.lblLC1.Text = "Total";
			this.lblLC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPC1
			// 
			this.lblPC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPC1.Location = new System.Drawing.Point(364, 219);
			this.lblPC1.Name = "lblPC1";
			this.lblPC1.Size = new System.Drawing.Size(73, 20);
			this.lblPC1.TabIndex = 106;
			this.lblPC1.Text = "Bank Loans";
			this.lblPC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDraft1
			// 
			this.lblDraft1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDraft1.Location = new System.Drawing.Point(364, 193);
			this.lblDraft1.Name = "lblDraft1";
			this.lblDraft1.Size = new System.Drawing.Size(73, 20);
			this.lblDraft1.TabIndex = 105;
			this.lblDraft1.Text = "Other Loans";
			this.lblDraft1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCash1
			// 
			this.lblCash1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCash1.Location = new System.Drawing.Point(364, 167);
			this.lblCash1.Name = "lblCash1";
			this.lblCash1.Size = new System.Drawing.Size(73, 20);
			this.lblCash1.TabIndex = 104;
			this.lblCash1.Text = "Own Funds";
			this.lblCash1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAmt
			// 
			this.lblAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAmt.Location = new System.Drawing.Point(249, 128);
			this.lblAmt.Name = "lblAmt";
			this.lblAmt.Size = new System.Drawing.Size(100, 20);
			this.lblAmt.TabIndex = 101;
			this.lblAmt.Text = "Amt";
			this.lblAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(249, 245);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 86;
			// 
			// txtOther
			// 
			this.txtOther.Location = new System.Drawing.Point(249, 219);
			this.txtOther.Name = "txtOther";
			this.txtOther.Size = new System.Drawing.Size(100, 20);
			this.txtOther.TabIndex = 85;
			this.txtOther.TextChanged += new System.EventHandler(this.txtBuild_TextChanged);
			// 
			// txtEquip
			// 
			this.txtEquip.Location = new System.Drawing.Point(249, 193);
			this.txtEquip.Name = "txtEquip";
			this.txtEquip.Size = new System.Drawing.Size(100, 20);
			this.txtEquip.TabIndex = 84;
			this.txtEquip.TextChanged += new System.EventHandler(this.txtBuild_TextChanged);
			// 
			// lblLC
			// 
			this.lblLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLC.Location = new System.Drawing.Point(94, 244);
			this.lblLC.Name = "lblLC";
			this.lblLC.Size = new System.Drawing.Size(73, 20);
			this.lblLC.TabIndex = 82;
			this.lblLC.Text = "Total";
			this.lblLC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPC
			// 
			this.lblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPC.Location = new System.Drawing.Point(94, 218);
			this.lblPC.Name = "lblPC";
			this.lblPC.Size = new System.Drawing.Size(73, 20);
			this.lblPC.TabIndex = 80;
			this.lblPC.Text = "Other";
			this.lblPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDraft
			// 
			this.lblDraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDraft.Location = new System.Drawing.Point(94, 193);
			this.lblDraft.Name = "lblDraft";
			this.lblDraft.Size = new System.Drawing.Size(73, 20);
			this.lblDraft.TabIndex = 79;
			this.lblDraft.Text = "Equipments";
			this.lblDraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtBuild
			// 
			this.txtBuild.Location = new System.Drawing.Point(249, 167);
			this.txtBuild.Name = "txtBuild";
			this.txtBuild.Size = new System.Drawing.Size(100, 20);
			this.txtBuild.TabIndex = 78;
			this.txtBuild.TextChanged += new System.EventHandler(this.txtBuild_TextChanged);
			// 
			// lblCash
			// 
			this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCash.Location = new System.Drawing.Point(94, 166);
			this.lblCash.Name = "lblCash";
			this.lblCash.Size = new System.Drawing.Size(122, 20);
			this.lblCash.TabIndex = 77;
			this.lblCash.Text = "Land and Building";
			this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMeans
			// 
			this.lblMeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMeans.Location = new System.Drawing.Point(364, 128);
			this.lblMeans.Name = "lblMeans";
			this.lblMeans.Size = new System.Drawing.Size(73, 20);
			this.lblMeans.TabIndex = 120;
			this.lblMeans.Text = "Means";
			this.lblMeans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCost
			// 
			this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCost.Location = new System.Drawing.Point(94, 128);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new System.Drawing.Size(70, 20);
			this.lblCost.TabIndex = 121;
			this.lblCost.Text = "Cost";
			this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmProposedExpenditure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 366);
			this.Controls.Add(this.lblCost);
			this.Controls.Add(this.lblMeans);
			this.Controls.Add(this.txtTotal1);
			this.Controls.Add(this.txtBank);
			this.Controls.Add(this.txtLoan);
			this.Controls.Add(this.txtOwn);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.lblAmt1);
			this.Controls.Add(this.lblLC1);
			this.Controls.Add(this.lblPC1);
			this.Controls.Add(this.lblDraft1);
			this.Controls.Add(this.lblCash1);
			this.Controls.Add(this.lblAmt);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtOther);
			this.Controls.Add(this.txtEquip);
			this.Controls.Add(this.lblLC);
			this.Controls.Add(this.lblPC);
			this.Controls.Add(this.lblDraft);
			this.Controls.Add(this.txtBuild);
			this.Controls.Add(this.lblCash);
			this.Controls.Add(this.picFrmClose);
			this.Controls.Add(this.pictitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmProposedExpenditure";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "FrmProposedExpenditure";
			this.Activated += new System.EventHandler(this.FrmProposedExpenditure_Load);
			this.Load += new System.EventHandler(this.FrmProposedExpenditure_Load);
			((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtOwn;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblAmt1;
        private System.Windows.Forms.Label lblLC1;
        private System.Windows.Forms.Label lblPC1;
        private System.Windows.Forms.Label lblDraft1;
        private System.Windows.Forms.Label lblCash1;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.TextBox txtEquip;
        private System.Windows.Forms.Label lblLC;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblDraft;
        private System.Windows.Forms.TextBox txtBuild;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblMeans;
        private System.Windows.Forms.Label lblCost;
    }
}