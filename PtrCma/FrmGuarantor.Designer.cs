namespace PtrCma
{
    partial class FrmGuarantor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuarantor));
            this.pictitle = new System.Windows.Forms.PictureBox();
            this.picFrmClose = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.grdViewGuarantor = new System.Windows.Forms.DataGridView();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.lblPValue = new System.Windows.Forms.Label();
            this.txtNWorth = new System.Windows.Forms.TextBox();
            this.txtQual = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAcq = new System.Windows.Forms.Label();
            this.lblFValue = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewGuarantor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(109, 23);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(511, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 36;
            this.pictitle.TabStop = false;
            // 
            // picFrmClose
            // 
            this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
            this.picFrmClose.Location = new System.Drawing.Point(683, 23);
            this.picFrmClose.Name = "picFrmClose";
            this.picFrmClose.Size = new System.Drawing.Size(32, 32);
            this.picFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrmClose.TabIndex = 37;
            this.picFrmClose.TabStop = false;
            this.picFrmClose.Click += new System.EventHandler(this.picFrmClose_Click);
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(424, 88);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(108, 15);
            this.lblData.TabIndex = 54;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblData.Visible = false;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(19, 74);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 20);
            this.txtRef.TabIndex = 53;
            this.txtRef.Visible = false;
            // 
            // grdViewGuarantor
            // 
            this.grdViewGuarantor.AllowUserToAddRows = false;
            this.grdViewGuarantor.AllowUserToDeleteRows = false;
            this.grdViewGuarantor.AllowUserToResizeColumns = false;
            this.grdViewGuarantor.AllowUserToResizeRows = false;
            this.grdViewGuarantor.BackgroundColor = System.Drawing.Color.White;
            this.grdViewGuarantor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdViewGuarantor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdViewGuarantor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewGuarantor.Location = new System.Drawing.Point(19, 119);
            this.grdViewGuarantor.Name = "grdViewGuarantor";
            this.grdViewGuarantor.RowHeadersVisible = false;
            this.grdViewGuarantor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdViewGuarantor.Size = new System.Drawing.Size(240, 181);
            this.grdViewGuarantor.TabIndex = 52;
            this.grdViewGuarantor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewSecurities_CellClick);
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(488, 272);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(230, 20);
            this.txtBank.TabIndex = 74;
            // 
            // lblPValue
            // 
            this.lblPValue.Location = new System.Drawing.Point(275, 271);
            this.lblPValue.Name = "lblPValue";
            this.lblPValue.Size = new System.Drawing.Size(160, 14);
            this.lblPValue.TabIndex = 73;
            this.lblPValue.Text = "Banking With";
            // 
            // txtNWorth
            // 
            this.txtNWorth.Location = new System.Drawing.Point(488, 246);
            this.txtNWorth.Name = "txtNWorth";
            this.txtNWorth.Size = new System.Drawing.Size(230, 20);
            this.txtNWorth.TabIndex = 72;
            // 
            // txtQual
            // 
            this.txtQual.Location = new System.Drawing.Point(488, 220);
            this.txtQual.Name = "txtQual";
            this.txtQual.Size = new System.Drawing.Size(230, 20);
            this.txtQual.TabIndex = 71;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(488, 196);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(230, 20);
            this.txtAge.TabIndex = 70;
            // 
            // lblAcq
            // 
            this.lblAcq.Location = new System.Drawing.Point(275, 245);
            this.lblAcq.Name = "lblAcq";
            this.lblAcq.Size = new System.Drawing.Size(160, 14);
            this.lblAcq.TabIndex = 68;
            this.lblAcq.Text = "Net Worth";
            // 
            // lblFValue
            // 
            this.lblFValue.Location = new System.Drawing.Point(275, 222);
            this.lblFValue.Name = "lblFValue";
            this.lblFValue.Size = new System.Drawing.Size(198, 14);
            this.lblFValue.TabIndex = 67;
            this.lblFValue.Text = "Qualification";
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(275, 199);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(198, 23);
            this.lblAge.TabIndex = 66;
            this.lblAge.Text = "Age";
            // 
            // lblDes
            // 
            this.lblDes.Location = new System.Drawing.Point(275, 140);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(207, 31);
            this.lblDes.TabIndex = 65;
            this.lblDes.Text = "Name of Guarantor and Address";
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(479, 334);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(60, 30);
            this.cmdUpdate.TabIndex = 77;
            this.cmdUpdate.Text = "Save";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(423, 334);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(50, 30);
            this.cmdEdit.TabIndex = 76;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(367, 334);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(50, 30);
            this.cmdAdd.TabIndex = 75;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(667, 334);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(50, 30);
            this.cmdExit.TabIndex = 80;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(545, 334);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(60, 30);
            this.cmdDel.TabIndex = 78;
            this.cmdDel.Text = "Delete";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(611, 334);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(50, 30);
            this.cmdCancel.TabIndex = 79;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(488, 134);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(227, 56);
            this.txtDes.TabIndex = 81;
            this.txtDes.Text = "";
            // 
            // FrmGuarantor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 387);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.lblPValue);
            this.Controls.Add(this.txtNWorth);
            this.Controls.Add(this.txtQual);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAcq);
            this.Controls.Add(this.lblFValue);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.grdViewGuarantor);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.pictitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGuarantor";
            this.Text = "FrmGuarantor";
            this.Load += new System.EventHandler(this.FrmGuarantor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewGuarantor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.DataGridView grdViewGuarantor;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label lblPValue;
        private System.Windows.Forms.TextBox txtNWorth;
        private System.Windows.Forms.TextBox txtQual;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAcq;
        private System.Windows.Forms.Label lblFValue;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.RichTextBox txtDes;
    }
}