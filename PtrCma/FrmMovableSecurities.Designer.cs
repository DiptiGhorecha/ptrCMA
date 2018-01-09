namespace PtrCma
{
    partial class FrmImmovableSecurities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImmovableSecurities));
            this.picFrmClose = new System.Windows.Forms.PictureBox();
            this.pictitle = new System.Windows.Forms.PictureBox();
            this.txtValuation = new System.Windows.Forms.TextBox();
            this.txtProperty = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblValuation = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.grdViewSecurities = new System.Windows.Forms.DataGridView();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSecurities)).BeginInit();
            this.SuspendLayout();
            // 
            // picFrmClose
            // 
            this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
            this.picFrmClose.Location = new System.Drawing.Point(674, 46);
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
            this.pictitle.Location = new System.Drawing.Point(101, 46);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(511, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 35;
            this.pictitle.TabStop = false;
            // 
            // txtValuation
            // 
            this.txtValuation.Location = new System.Drawing.Point(473, 220);
            this.txtValuation.MaxLength = 20;
            this.txtValuation.Name = "txtValuation";
            this.txtValuation.Size = new System.Drawing.Size(230, 20);
            this.txtValuation.TabIndex = 10;
            // 
            // txtProperty
            // 
            this.txtProperty.Location = new System.Drawing.Point(473, 197);
            this.txtProperty.MaxLength = 20;
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.Size = new System.Drawing.Size(230, 20);
            this.txtProperty.TabIndex = 9;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(473, 174);
            this.txtOwner.MaxLength = 80;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(230, 20);
            this.txtOwner.TabIndex = 8;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(473, 151);
            this.txtDes.MaxLength = 80;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(230, 20);
            this.txtDes.TabIndex = 7;
            // 
            // lblValuation
            // 
            this.lblValuation.Location = new System.Drawing.Point(292, 220);
            this.lblValuation.Name = "lblValuation";
            this.lblValuation.Size = new System.Drawing.Size(160, 14);
            this.lblValuation.TabIndex = 23;
            this.lblValuation.Text = "Basis of Valuation";
            // 
            // lblProperty
            // 
            this.lblProperty.Location = new System.Drawing.Point(292, 197);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(160, 14);
            this.lblProperty.TabIndex = 22;
            this.lblProperty.Text = "Value of Property";
            // 
            // lblOwner
            // 
            this.lblOwner.Location = new System.Drawing.Point(292, 174);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(160, 15);
            this.lblOwner.TabIndex = 21;
            this.lblOwner.Text = "Name of Owner";
            // 
            // lblDes
            // 
            this.lblDes.Location = new System.Drawing.Point(292, 151);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(160, 16);
            this.lblDes.TabIndex = 20;
            this.lblDes.Text = "Description of Property";
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
            this.grdViewSecurities.Location = new System.Drawing.Point(21, 127);
            this.grdViewSecurities.Name = "grdViewSecurities";
            this.grdViewSecurities.RowHeadersVisible = false;
            this.grdViewSecurities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdViewSecurities.Size = new System.Drawing.Size(240, 181);
            this.grdViewSecurities.TabIndex = 19;
            this.grdViewSecurities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewSecurities_CellClick);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(465, 317);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(60, 30);
            this.cmdUpdate.TabIndex = 3;
            this.cmdUpdate.Text = "Save";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(409, 317);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(50, 30);
            this.cmdEdit.TabIndex = 2;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(353, 317);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(50, 30);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(653, 317);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(50, 30);
            this.cmdExit.TabIndex = 6;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(531, 317);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(60, 30);
            this.cmdDel.TabIndex = 4;
            this.cmdDel.Text = "Delete";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(597, 317);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(50, 30);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(21, 82);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 20);
            this.txtRef.TabIndex = 50;
            this.txtRef.Visible = false;
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(426, 96);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(108, 15);
            this.lblData.TabIndex = 51;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblData.Visible = false;
            // 
            // FrmImmovableSecurities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 407);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.pictitle);
            this.Controls.Add(this.txtValuation);
            this.Controls.Add(this.txtProperty);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lblValuation);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.grdViewSecurities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImmovableSecurities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMovableSecurities";
            this.Activated += new System.EventHandler(this.FrmImmovableSecurities_Load);
            this.Load += new System.EventHandler(this.FrmImmovableSecurities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSecurities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.TextBox txtValuation;
        private System.Windows.Forms.TextBox txtProperty;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lblValuation;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.DataGridView grdViewSecurities;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblData;
    }
}