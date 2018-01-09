namespace PtrCma
{
    partial class FrmMovable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovable));
            this.pictitle = new System.Windows.Forms.PictureBox();
            this.picFrmClose = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.grdViewSecurities = new System.Windows.Forms.DataGridView();
            this.txtAcq = new System.Windows.Forms.TextBox();
            this.txtFValue = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblAcq = new System.Windows.Forms.Label();
            this.lblFValue = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtPValue = new System.Windows.Forms.TextBox();
            this.lblPValue = new System.Windows.Forms.Label();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSecurities)).BeginInit();
            this.SuspendLayout();
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(118, 43);
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
            this.picFrmClose.Location = new System.Drawing.Point(682, 43);
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
            this.lblData.Location = new System.Drawing.Point(417, 84);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(108, 15);
            this.lblData.TabIndex = 54;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblData.Visible = false;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(12, 70);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 20);
            this.txtRef.TabIndex = 53;
            this.txtRef.Visible = false;
            // 
            // grdViewSecurities
            // 
            this.grdViewSecurities.AllowUserToAddRows = false;
            this.grdViewSecurities.AllowUserToDeleteRows = false;
            this.grdViewSecurities.AllowUserToResizeColumns = false;
            this.grdViewSecurities.AllowUserToResizeRows = false;
            this.grdViewSecurities.BackgroundColor = System.Drawing.Color.White;
            this.grdViewSecurities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdViewSecurities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdViewSecurities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewSecurities.Location = new System.Drawing.Point(12, 115);
            this.grdViewSecurities.Name = "grdViewSecurities";
            this.grdViewSecurities.RowHeadersVisible = false;
            this.grdViewSecurities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdViewSecurities.Size = new System.Drawing.Size(240, 181);
            this.grdViewSecurities.TabIndex = 52;
            // 
            // txtAcq
            // 
            this.txtAcq.Location = new System.Drawing.Point(484, 222);
            this.txtAcq.MaxLength = 20;
            this.txtAcq.Name = "txtAcq";
            this.txtAcq.Size = new System.Drawing.Size(230, 20);
            this.txtAcq.TabIndex = 10;
            this.txtAcq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtFValue
            // 
            this.txtFValue.Location = new System.Drawing.Point(484, 196);
            this.txtFValue.MaxLength = 20;
            this.txtFValue.Name = "txtFValue";
            this.txtFValue.Size = new System.Drawing.Size(230, 20);
            this.txtFValue.TabIndex = 9;
            this.txtFValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(484, 172);
            this.txtOwner.MaxLength = 80;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(230, 20);
            this.txtOwner.TabIndex = 8;
            this.txtOwner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(484, 148);
            this.txtDes.MaxLength = 80;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(230, 20);
            this.txtDes.TabIndex = 7;
            this.txtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // lblAcq
            // 
            this.lblAcq.Location = new System.Drawing.Point(271, 221);
            this.lblAcq.Name = "lblAcq";
            this.lblAcq.Size = new System.Drawing.Size(160, 14);
            this.lblAcq.TabIndex = 58;
            this.lblAcq.Text = "When Acquired";
            // 
            // lblFValue
            // 
            this.lblFValue.Location = new System.Drawing.Point(271, 198);
            this.lblFValue.Name = "lblFValue";
            this.lblFValue.Size = new System.Drawing.Size(160, 14);
            this.lblFValue.TabIndex = 57;
            this.lblFValue.Text = "Face Value";
            // 
            // lblOwner
            // 
            this.lblOwner.Location = new System.Drawing.Point(271, 175);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(160, 15);
            this.lblOwner.TabIndex = 56;
            this.lblOwner.Text = "Name of Owner";
            // 
            // lblDes
            // 
            this.lblDes.Location = new System.Drawing.Point(271, 152);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(160, 16);
            this.lblDes.TabIndex = 55;
            this.lblDes.Text = "Description ";
            // 
            // txtPValue
            // 
            this.txtPValue.Location = new System.Drawing.Point(484, 248);
            this.txtPValue.MaxLength = 20;
            this.txtPValue.Name = "txtPValue";
            this.txtPValue.Size = new System.Drawing.Size(230, 20);
            this.txtPValue.TabIndex = 11;
            this.txtPValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // lblPValue
            // 
            this.lblPValue.Location = new System.Drawing.Point(271, 247);
            this.lblPValue.Name = "lblPValue";
            this.lblPValue.Size = new System.Drawing.Size(160, 14);
            this.lblPValue.TabIndex = 63;
            this.lblPValue.Text = "Present Value";
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(476, 323);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(60, 30);
            this.cmdUpdate.TabIndex = 3;
            this.cmdUpdate.Text = "&Save";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(420, 323);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(50, 30);
            this.cmdEdit.TabIndex = 2;
            this.cmdEdit.Text = "&Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(364, 323);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(50, 30);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "&Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(664, 323);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(50, 30);
            this.cmdExit.TabIndex = 6;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(542, 323);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(60, 30);
            this.cmdDel.TabIndex = 4;
            this.cmdDel.Text = "&Delete";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(608, 323);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(50, 30);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // FrmMovable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 383);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtPValue);
            this.Controls.Add(this.lblPValue);
            this.Controls.Add(this.txtAcq);
            this.Controls.Add(this.txtFValue);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lblAcq);
            this.Controls.Add(this.lblFValue);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.grdViewSecurities);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.pictitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMovable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMovable";
            this.Activated += new System.EventHandler(this.FrmMovable_Load);
            this.Load += new System.EventHandler(this.FrmMovable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSecurities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.DataGridView grdViewSecurities;
        private System.Windows.Forms.TextBox txtAcq;
        private System.Windows.Forms.TextBox txtFValue;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lblAcq;
        private System.Windows.Forms.Label lblFValue;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.TextBox txtPValue;
        private System.Windows.Forms.Label lblPValue;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdCancel;
    }
}