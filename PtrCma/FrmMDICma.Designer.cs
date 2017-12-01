namespace PtrCma
{
    partial class FrmMDICma
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.pictCloseBtn = new System.Windows.Forms.PictureBox();
            this.pictMinBtn = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Location = new System.Drawing.Point(69, 8);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(410, 50);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = " ";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictLogo
            // 
            this.pictLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictLogo.BackgroundImage = global::PtrCma.Properties.Resources.lblBack;
            this.pictLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictLogo.Image = global::PtrCma.Properties.Resources.ptr_logo;
            this.pictLogo.InitialImage = null;
            this.pictLogo.Location = new System.Drawing.Point(5, 4);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(60, 60);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictLogo.TabIndex = 5;
            this.pictLogo.TabStop = false;
            // 
            // pictCloseBtn
            // 
            this.pictCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.pictCloseBtn.BackgroundImage = global::PtrCma.Properties.Resources.lblBack;
            this.pictCloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictCloseBtn.Image = global::PtrCma.Properties.Resources.close;
            this.pictCloseBtn.InitialImage = global::PtrCma.Properties.Resources.mini1;
            this.pictCloseBtn.Location = new System.Drawing.Point(224, 98);
            this.pictCloseBtn.Name = "pictCloseBtn";
            this.pictCloseBtn.Size = new System.Drawing.Size(60, 60);
            this.pictCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictCloseBtn.TabIndex = 3;
            this.pictCloseBtn.TabStop = false;
            this.pictCloseBtn.Click += new System.EventHandler(this.pictCloseBtn_Click);
            // 
            // pictMinBtn
            // 
            this.pictMinBtn.BackColor = System.Drawing.Color.Transparent;
            this.pictMinBtn.BackgroundImage = global::PtrCma.Properties.Resources.lblBack;
            this.pictMinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictMinBtn.Image = global::PtrCma.Properties.Resources.mini;
            this.pictMinBtn.InitialImage = global::PtrCma.Properties.Resources.mini1;
            this.pictMinBtn.Location = new System.Drawing.Point(49, 116);
            this.pictMinBtn.Name = "pictMinBtn";
            this.pictMinBtn.Size = new System.Drawing.Size(60, 60);
            this.pictMinBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictMinBtn.TabIndex = 2;
            this.pictMinBtn.TabStop = false;
            this.pictMinBtn.Click += new System.EventHandler(this.pictMinBtn_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.ActiveLinkColor = System.Drawing.Color.White;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.LinkArea = new System.Windows.Forms.LinkArea(16, 36);
            this.lblCopyright.LinkColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(5, 225);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(835, 22);
            this.lblCopyright.TabIndex = 8;
            this.lblCopyright.TabStop = true;
            this.lblCopyright.Text = "Copyright 2017, Perfect Tax Reporter";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopyright.UseCompatibleTextRendering = true;
            this.lblCopyright.VisitedLinkColor = System.Drawing.Color.White;
            this.lblCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCopyright_LinkClicked);
            // 
            // FrmMDICma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(905, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pictLogo);
            this.Controls.Add(this.pictCloseBtn);
            this.Controls.Add(this.pictMinBtn);
            this.Controls.Add(this.lblCompanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmMDICma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMDICma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.PictureBox pictMinBtn;
        private System.Windows.Forms.PictureBox pictCloseBtn;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.LinkLabel lblCopyright;
    }
}

