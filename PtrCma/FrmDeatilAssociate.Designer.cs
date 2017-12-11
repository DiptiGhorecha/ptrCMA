namespace PtrCma
{
    partial class FrmDeatilAssociate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeatilAssociate));
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtOutst = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtProp = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOutst = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblProp = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.grdAssociate = new System.Windows.Forms.DataGridView();
            this.picFrmClose = new System.Windows.Forms.PictureBox();
            this.pictitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssociate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(675, 347);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(40, 23);
            this.cmdExit.TabIndex = 35;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(595, 347);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(47, 23);
            this.cmdDelete.TabIndex = 34;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(523, 347);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(39, 23);
            this.cmdAdd.TabIndex = 33;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtOutst
            // 
            this.txtOutst.Location = new System.Drawing.Point(495, 271);
            this.txtOutst.Name = "txtOutst";
            this.txtOutst.Size = new System.Drawing.Size(253, 20);
            this.txtOutst.TabIndex = 32;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(495, 246);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(253, 20);
            this.txtLimit.TabIndex = 31;
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(495, 222);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(253, 20);
            this.txtBank.TabIndex = 30;
            // 
            // txtProp
            // 
            this.txtProp.Location = new System.Drawing.Point(495, 197);
            this.txtProp.Name = "txtProp";
            this.txtProp.Size = new System.Drawing.Size(253, 20);
            this.txtProp.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(495, 172);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 20);
            this.txtName.TabIndex = 28;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // lblOutst
            // 
            this.lblOutst.Location = new System.Drawing.Point(317, 271);
            this.lblOutst.Name = "lblOutst";
            this.lblOutst.Size = new System.Drawing.Size(117, 17);
            this.lblOutst.TabIndex = 27;
            this.lblOutst.Text = "Outstanding";
            // 
            // lblLimit
            // 
            this.lblLimit.Location = new System.Drawing.Point(317, 246);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(117, 17);
            this.lblLimit.TabIndex = 26;
            this.lblLimit.Text = "Limit";
            // 
            // lblBank
            // 
            this.lblBank.Location = new System.Drawing.Point(317, 222);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(117, 17);
            this.lblBank.TabIndex = 25;
            this.lblBank.Text = "Banking With";
            // 
            // lblProp
            // 
            this.lblProp.Location = new System.Drawing.Point(317, 197);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(117, 17);
            this.lblProp.TabIndex = 24;
            this.lblProp.Text = "Name(s) of Prop";
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(317, 172);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(117, 17);
            this.lblUnit.TabIndex = 23;
            this.lblUnit.Text = "Name of Unit";
            // 
            // grdAssociate
            // 
            this.grdAssociate.AllowUserToAddRows = false;
            this.grdAssociate.AllowUserToDeleteRows = false;
            this.grdAssociate.AllowUserToResizeColumns = false;
            this.grdAssociate.AllowUserToResizeRows = false;
            this.grdAssociate.BackgroundColor = System.Drawing.Color.White;
            this.grdAssociate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAssociate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdAssociate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssociate.Location = new System.Drawing.Point(28, 131);
            this.grdAssociate.Name = "grdAssociate";
            this.grdAssociate.RowHeadersVisible = false;
            this.grdAssociate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdAssociate.Size = new System.Drawing.Size(258, 200);
            this.grdAssociate.TabIndex = 22;
            this.grdAssociate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAssociate_CellClick);
            // 
            // picFrmClose
            // 
            this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
            this.picFrmClose.Location = new System.Drawing.Point(712, 22);
            this.picFrmClose.Name = "picFrmClose";
            this.picFrmClose.Size = new System.Drawing.Size(25, 30);
            this.picFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrmClose.TabIndex = 37;
            this.picFrmClose.TabStop = false;
            this.picFrmClose.Click += new System.EventHandler(this.picFrmClose_Click);
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(108, 22);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(511, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 36;
            this.pictitle.TabStop = false;
            this.pictitle.Click += new System.EventHandler(this.pictitle_Click);
            // 
            // FrmDeatilAssociate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 391);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.pictitle);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtOutst);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtProp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOutst);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.grdAssociate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDeatilAssociate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmDeatilAssociate";
            this.Load += new System.EventHandler(this.FrmDeatilAssociate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAssociate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtOutst;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtProp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOutst;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DataGridView grdAssociate;
        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.PictureBox pictitle;
    }
}