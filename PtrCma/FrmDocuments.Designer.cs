namespace PtrCma
{
    partial class FrmDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocuments));
            this.picFrmClose = new System.Windows.Forms.PictureBox();
            this.pictitle = new System.Windows.Forms.PictureBox();
            this.grdPurchase = new System.Windows.Forms.DataGridView();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // picFrmClose
            // 
            this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
            this.picFrmClose.Location = new System.Drawing.Point(685, 25);
            this.picFrmClose.Name = "picFrmClose";
            this.picFrmClose.Size = new System.Drawing.Size(32, 32);
            this.picFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrmClose.TabIndex = 39;
            this.picFrmClose.TabStop = false;
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(111, 25);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(511, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 38;
            this.pictitle.TabStop = false;
            // 
            // grdPurchase
            // 
            this.grdPurchase.AllowUserToAddRows = false;
            this.grdPurchase.AllowUserToDeleteRows = false;
            this.grdPurchase.AllowUserToResizeColumns = false;
            this.grdPurchase.AllowUserToResizeRows = false;
            this.grdPurchase.BackgroundColor = System.Drawing.Color.White;
            this.grdPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPurchase.Location = new System.Drawing.Point(20, 114);
            this.grdPurchase.Name = "grdPurchase";
            this.grdPurchase.RowHeadersVisible = false;
            this.grdPurchase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdPurchase.Size = new System.Drawing.Size(696, 275);
            this.grdPurchase.TabIndex = 40;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(473, 452);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(60, 30);
            this.cmdUpdate.TabIndex = 43;
            this.cmdUpdate.Text = "Save";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(417, 452);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(50, 30);
            this.cmdEdit.TabIndex = 42;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(361, 452);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(50, 30);
            this.cmdAdd.TabIndex = 41;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(661, 452);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(50, 30);
            this.cmdExit.TabIndex = 46;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(539, 452);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(60, 30);
            this.cmdDel.TabIndex = 44;
            this.cmdDel.Text = "Delete";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(605, 452);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(50, 30);
            this.cmdCancel.TabIndex = 45;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(20, 409);
            this.txtDoc.MaxLength = 80;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(696, 20);
            this.txtDoc.TabIndex = 47;
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(324, 80);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(108, 15);
            this.lblData.TabIndex = 49;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblData.Visible = false;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(20, 79);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 20);
            this.txtRef.TabIndex = 50;
            this.txtRef.Visible = false;
            // 
            // FrmDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 498);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.grdPurchase);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.pictitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDocuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDocuments";
            this.Load += new System.EventHandler(this.FrmDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.DataGridView grdPurchase;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtRef;
    }
}