namespace PtrCma
{
    partial class FrmMajorBuyer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMajorBuyer));
			this.grdPurchase = new System.Windows.Forms.DataGridView();
			this.cmdExit = new System.Windows.Forms.Button();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.cmdAdd = new System.Windows.Forms.Button();
			this.txtDoc = new System.Windows.Forms.TextBox();
			this.picFrmClose = new System.Windows.Forms.PictureBox();
			this.pictitle = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.grdPurchase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
			this.SuspendLayout();
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
			this.grdPurchase.Location = new System.Drawing.Point(36, 72);
			this.grdPurchase.Name = "grdPurchase";
			this.grdPurchase.RowHeadersVisible = false;
			this.grdPurchase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grdPurchase.Size = new System.Drawing.Size(712, 300);
			this.grdPurchase.TabIndex = 0;
			this.grdPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPurchase_CellClick);
			// 
			// cmdExit
			// 
			this.cmdExit.Location = new System.Drawing.Point(701, 442);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(40, 23);
			this.cmdExit.TabIndex = 22;
			this.cmdExit.Text = "Exit";
			this.cmdExit.UseVisualStyleBackColor = true;
			this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// cmdDelete
			// 
			this.cmdDelete.Location = new System.Drawing.Point(621, 442);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(47, 23);
			this.cmdDelete.TabIndex = 21;
			this.cmdDelete.Text = "Delete";
			this.cmdDelete.UseVisualStyleBackColor = true;
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			// 
			// cmdAdd
			// 
			this.cmdAdd.Location = new System.Drawing.Point(549, 442);
			this.cmdAdd.Name = "cmdAdd";
			this.cmdAdd.Size = new System.Drawing.Size(39, 23);
			this.cmdAdd.TabIndex = 20;
			this.cmdAdd.Text = "Add";
			this.cmdAdd.UseVisualStyleBackColor = true;
			this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
			// 
			// txtDoc
			// 
			this.txtDoc.Location = new System.Drawing.Point(36, 395);
			this.txtDoc.Name = "txtDoc";
			this.txtDoc.Size = new System.Drawing.Size(712, 20);
			this.txtDoc.TabIndex = 25;
			this.txtDoc.Click += new System.EventHandler(this.txtDoc_Click);
			// 
			// picFrmClose
			// 
			this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
			this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
			this.picFrmClose.Location = new System.Drawing.Point(718, 16);
			this.picFrmClose.Name = "picFrmClose";
			this.picFrmClose.Size = new System.Drawing.Size(25, 30);
			this.picFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFrmClose.TabIndex = 27;
			this.picFrmClose.TabStop = false;
			this.picFrmClose.Click += new System.EventHandler(this.picFrmClose_Click);
			// 
			// pictitle
			// 
			this.pictitle.BackColor = System.Drawing.Color.Transparent;
			this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
			this.pictitle.Location = new System.Drawing.Point(126, 16);
			this.pictitle.Name = "pictitle";
			this.pictitle.Size = new System.Drawing.Size(511, 30);
			this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictitle.TabIndex = 26;
			this.pictitle.TabStop = false;
			// 
			// FrmMajorBuyer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 495);
			this.Controls.Add(this.picFrmClose);
			this.Controls.Add(this.pictitle);
			this.Controls.Add(this.txtDoc);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.cmdDelete);
			this.Controls.Add(this.cmdAdd);
			this.Controls.Add(this.grdPurchase);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmMajorBuyer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "FrmMajorBuyer";
			this.Load += new System.EventHandler(this.FrmMajorBuyer_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdPurchase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPurchase;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.PictureBox pictitle;
    }
}