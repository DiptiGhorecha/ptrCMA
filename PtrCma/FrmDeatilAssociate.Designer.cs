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
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssociate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutst
            // 
            this.txtOutst.Location = new System.Drawing.Point(504, 274);
            this.txtOutst.MaxLength = 40;
            this.txtOutst.Name = "txtOutst";
            this.txtOutst.Size = new System.Drawing.Size(230, 20);
            this.txtOutst.TabIndex = 11;
            this.txtOutst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(504, 248);
            this.txtLimit.MaxLength = 40;
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(230, 20);
            this.txtLimit.TabIndex = 10;
            this.txtLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(504, 222);
            this.txtBank.MaxLength = 40;
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(230, 20);
            this.txtBank.TabIndex = 9;
            this.txtBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtProp
            // 
            this.txtProp.Location = new System.Drawing.Point(504, 198);
            this.txtProp.MaxLength = 80;
            this.txtProp.Name = "txtProp";
            this.txtProp.Size = new System.Drawing.Size(230, 20);
            this.txtProp.TabIndex = 8;
            this.txtProp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(504, 172);
            this.txtName.MaxLength = 80;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 7;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
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
            this.grdAssociate.Location = new System.Drawing.Point(17, 131);
            this.grdAssociate.Name = "grdAssociate";
            this.grdAssociate.RowHeadersVisible = false;
            this.grdAssociate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdAssociate.Size = new System.Drawing.Size(274, 200);
            this.grdAssociate.TabIndex = 22;
            this.grdAssociate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAssociate_CellClick);
            // 
            // picFrmClose
            // 
            this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
            this.picFrmClose.Location = new System.Drawing.Point(701, 22);
            this.picFrmClose.Name = "picFrmClose";
            this.picFrmClose.Size = new System.Drawing.Size(32, 32);
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
            this.pictitle.Location = new System.Drawing.Point(121, 22);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(511, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 36;
            this.pictitle.TabStop = false;
            this.pictitle.Click += new System.EventHandler(this.pictitle_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(496, 340);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(60, 30);
            this.cmdUpdate.TabIndex = 3;
            this.cmdUpdate.Text = "&Save";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(440, 340);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(50, 30);
            this.cmdEdit.TabIndex = 2;
            this.cmdEdit.Text = "&Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(384, 340);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(50, 30);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "&Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(684, 340);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(50, 30);
            this.cmdExit.TabIndex = 6;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.picFrmClose_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(562, 340);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(60, 30);
            this.cmdDel.TabIndex = 4;
            this.cmdDel.Text = "&Delete";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(628, 340);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(50, 30);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(461, 98);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(108, 12);
            this.lblData.TabIndex = 48;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblData.Visible = false;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(17, 90);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 20);
            this.txtRef.TabIndex = 49;
            this.txtRef.Visible = false;
            // 
            // FrmDeatilAssociate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 391);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.pictitle);
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
            this.Activated += new System.EventHandler(this.FrmDeatilAssociate_Load);
            this.Load += new System.EventHandler(this.FrmDeatilAssociate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAssociate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtRef;
    }
}