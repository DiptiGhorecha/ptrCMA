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
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblPan = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.grdViewDirectors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDirectors)).BeginInit();
            this.SuspendLayout();
            // 
            // picFrmClose
            // 
            this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
            this.picFrmClose.Location = new System.Drawing.Point(648, 46);
            this.picFrmClose.Name = "picFrmClose";
            this.picFrmClose.Size = new System.Drawing.Size(25, 30);
            this.picFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrmClose.TabIndex = 36;
            this.picFrmClose.TabStop = false;
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(63, 46);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(511, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 35;
            this.pictitle.TabStop = false;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(655, 326);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(40, 22);
            this.cmdExit.TabIndex = 34;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(576, 326);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(47, 22);
            this.cmdDelete.TabIndex = 33;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(505, 326);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(39, 22);
            this.cmdAdd.TabIndex = 32;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(472, 219);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(241, 20);
            this.txtAdd.TabIndex = 29;
            // 
            // txtPan
            // 
            this.txtPan.Location = new System.Drawing.Point(472, 196);
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(241, 20);
            this.txtPan.TabIndex = 28;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(472, 173);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(241, 20);
            this.txtOwner.TabIndex = 27;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(472, 150);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(241, 20);
            this.txtDes.TabIndex = 26;
            // 
            // lblAdd
            // 
            this.lblAdd.Location = new System.Drawing.Point(292, 220);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(160, 14);
            this.lblAdd.TabIndex = 23;
            this.lblAdd.Text = "Residential Address ";
            // 
            // lblPan
            // 
            this.lblPan.Location = new System.Drawing.Point(292, 197);
            this.lblPan.Name = "lblPan";
            this.lblPan.Size = new System.Drawing.Size(160, 14);
            this.lblPan.TabIndex = 22;
            this.lblPan.Text = "PAN";
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
            // grdViewDirectors
            // 
            this.grdViewDirectors.AllowUserToAddRows = false;
            this.grdViewDirectors.AllowUserToDeleteRows = false;
            this.grdViewDirectors.AllowUserToResizeColumns = false;
            this.grdViewDirectors.AllowUserToResizeRows = false;
            this.grdViewDirectors.BackgroundColor = System.Drawing.Color.White;
            this.grdViewDirectors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdViewDirectors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdViewDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewDirectors.Location = new System.Drawing.Point(21, 127);
            this.grdViewDirectors.Name = "grdViewDirectors";
            this.grdViewDirectors.RowHeadersVisible = false;
            this.grdViewDirectors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdViewDirectors.Size = new System.Drawing.Size(240, 181);
            this.grdViewDirectors.TabIndex = 19;
            // 
            // FrmImmovableSecurities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 407);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.pictitle);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtPan);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblPan);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.grdViewDirectors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImmovableSecurities";
            this.Text = "FrmImmovableSecurities";
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDirectors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblPan;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.DataGridView grdViewDirectors;
    }
}