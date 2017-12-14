namespace PtrCma
{
    partial class FrmDeatilAssets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeatilAssets));
            this.grdAssests = new System.Windows.Forms.DataGridView();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.picFrmClose = new System.Windows.Forms.PictureBox();
            this.pictitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAssests
            // 
            this.grdAssests.AllowUserToAddRows = false;
            this.grdAssests.AllowUserToDeleteRows = false;
            this.grdAssests.AllowUserToResizeColumns = false;
            this.grdAssests.AllowUserToResizeRows = false;
            this.grdAssests.BackgroundColor = System.Drawing.Color.White;
            this.grdAssests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAssests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdAssests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssests.Location = new System.Drawing.Point(32, 102);
            this.grdAssests.Name = "grdAssests";
            this.grdAssests.RowHeadersVisible = false;
            this.grdAssests.Size = new System.Drawing.Size(275, 168);
            this.grdAssests.TabIndex = 0;
            this.grdAssests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAssests_CellClick);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(334, 140);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(60, 13);
            this.lblDes.TabIndex = 1;
            this.lblDes.Text = "Description";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(334, 166);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(87, 13);
            this.lblSupplier.TabIndex = 2;
            this.lblSupplier.Text = "Detail of Supplier";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(336, 192);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Cost";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(334, 218);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(148, 13);
            this.lblCom.TabIndex = 4;
            this.lblCom.Text = "Time Schedule for Completion";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(510, 140);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(100, 20);
            this.txtDes.TabIndex = 5;
            this.txtDes.Click += new System.EventHandler(this.txtDes_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(510, 166);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(100, 20);
            this.txtSupplier.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(510, 192);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 7;
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(510, 218);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(100, 20);
            this.txtCom.TabIndex = 8;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(551, 282);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(45, 23);
            this.cmdAdd.TabIndex = 9;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(617, 282);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(45, 23);
            this.cmdDelete.TabIndex = 10;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(689, 282);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(45, 23);
            this.cmdExit.TabIndex = 11;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // picFrmClose
            // 
            this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
            this.picFrmClose.Location = new System.Drawing.Point(714, 19);
            this.picFrmClose.Name = "picFrmClose";
            this.picFrmClose.Size = new System.Drawing.Size(25, 30);
            this.picFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrmClose.TabIndex = 20;
            this.picFrmClose.TabStop = false;
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(116, 19);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(511, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 19;
            this.pictitle.TabStop = false;
            // 
            // FrmDeatilAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 329);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.pictitle);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.grdAssests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeatilAssets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmDeatilAssets";
            this.Load += new System.EventHandler(this.FrmDeatilAssets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAssests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAssests;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.PictureBox pictitle;
    }
}