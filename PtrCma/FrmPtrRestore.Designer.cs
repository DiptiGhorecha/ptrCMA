﻿namespace PtrCma
{
    partial class FrmPtrRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPtrRestore));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictitle = new System.Windows.Forms.PictureBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdBackup = new System.Windows.Forms.Button();
            this.lblDrive = new System.Windows.Forms.Label();
            this.comboDrive = new System.Windows.Forms.ComboBox();
            this.radioCD = new System.Windows.Forms.RadioButton();
            this.radioHD = new System.Windows.Forms.RadioButton();
            this.grdRestore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PtrCma.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(612, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(53, 25);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(532, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 89;
            this.pictitle.TabStop = false;
            // 
            // lblSelect
            // 
            this.lblSelect.Location = new System.Drawing.Point(325, 81);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(103, 23);
            this.lblSelect.TabIndex = 88;
            this.lblSelect.Text = "Select ";
            this.lblSelect.Visible = false;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(450, 201);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(78, 23);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdBackup
            // 
            this.cmdBackup.Location = new System.Drawing.Point(328, 201);
            this.cmdBackup.Name = "cmdBackup";
            this.cmdBackup.Size = new System.Drawing.Size(98, 23);
            this.cmdBackup.TabIndex = 1;
            this.cmdBackup.Text = "Start &Restore";
            this.cmdBackup.UseVisualStyleBackColor = true;
            this.cmdBackup.Click += new System.EventHandler(this.cmdRestore_Click);
            // 
            // lblDrive
            // 
            this.lblDrive.Location = new System.Drawing.Point(325, 132);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(112, 21);
            this.lblDrive.TabIndex = 85;
            this.lblDrive.Text = "Select Drive :";
            // 
            // comboDrive
            // 
            this.comboDrive.FormattingEnabled = true;
            this.comboDrive.Location = new System.Drawing.Point(431, 132);
            this.comboDrive.Name = "comboDrive";
            this.comboDrive.Size = new System.Drawing.Size(133, 21);
            this.comboDrive.TabIndex = 0;
            this.comboDrive.SelectedIndexChanged += new System.EventHandler(this.comboDrive_SelectedIndexChanged);
            this.comboDrive.Click += new System.EventHandler(this.comboDrive_Click);
            // 
            // radioCD
            // 
            this.radioCD.AutoSize = true;
            this.radioCD.BackColor = System.Drawing.Color.Transparent;
            this.radioCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCD.Location = new System.Drawing.Point(494, 79);
            this.radioCD.Name = "radioCD";
            this.radioCD.Size = new System.Drawing.Size(67, 17);
            this.radioCD.TabIndex = 83;
            this.radioCD.TabStop = true;
            this.radioCD.Text = "CD-RW";
            this.radioCD.UseVisualStyleBackColor = false;
            this.radioCD.Visible = false;
            this.radioCD.CheckedChanged += new System.EventHandler(this.radioCD_CheckedChanged);
            // 
            // radioHD
            // 
            this.radioHD.AutoSize = true;
            this.radioHD.BackColor = System.Drawing.Color.Transparent;
            this.radioHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHD.Location = new System.Drawing.Point(431, 79);
            this.radioHD.Name = "radioHD";
            this.radioHD.Size = new System.Drawing.Size(52, 17);
            this.radioHD.TabIndex = 82;
            this.radioHD.TabStop = true;
            this.radioHD.Text = "HDD";
            this.radioHD.UseVisualStyleBackColor = false;
            this.radioHD.Visible = false;
            this.radioHD.CheckedChanged += new System.EventHandler(this.radioHD_CheckedChanged);
            // 
            // grdRestore
            // 
            this.grdRestore.AllowUserToAddRows = false;
            this.grdRestore.AllowUserToDeleteRows = false;
            this.grdRestore.AllowUserToResizeColumns = false;
            this.grdRestore.AllowUserToResizeRows = false;
            this.grdRestore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRestore.Location = new System.Drawing.Point(53, 98);
            this.grdRestore.Name = "grdRestore";
            this.grdRestore.RowHeadersVisible = false;
            this.grdRestore.ShowEditingIcon = false;
            this.grdRestore.Size = new System.Drawing.Size(205, 162);
            this.grdRestore.TabIndex = 81;
            this.grdRestore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRestore_CellClick);
            // 
            // FrmPtrRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 299);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictitle);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdBackup);
            this.Controls.Add(this.lblDrive);
            this.Controls.Add(this.comboDrive);
            this.Controls.Add(this.radioCD);
            this.Controls.Add(this.radioHD);
            this.Controls.Add(this.grdRestore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPtrRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmPtrRestore";
            this.Activated += new System.EventHandler(this.FrmPtrRestore_Load);
            this.Load += new System.EventHandler(this.FrmPtrRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRestore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdBackup;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.ComboBox comboDrive;
        private System.Windows.Forms.RadioButton radioCD;
        private System.Windows.Forms.RadioButton radioHD;
        private System.Windows.Forms.DataGridView grdRestore;
    }
}