namespace PtrCma
{
    partial class FrmMainCma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainCma));
            this.cmdBnkStnd = new System.Windows.Forms.Button();
            this.cmdCMAProj = new System.Windows.Forms.Button();
            this.cmdBackup = new System.Windows.Forms.Button();
            this.cmdRestore = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblCMSCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdBnkStnd
            // 
            this.cmdBnkStnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdBnkStnd.BackgroundImage")));
            this.cmdBnkStnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBnkStnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdBnkStnd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdBnkStnd.Location = new System.Drawing.Point(37, 88);
            this.cmdBnkStnd.Name = "cmdBnkStnd";
            this.cmdBnkStnd.Size = new System.Drawing.Size(191, 71);
            this.cmdBnkStnd.TabIndex = 0;
            this.cmdBnkStnd.Text = "Bank Standard";
            this.cmdBnkStnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBnkStnd.UseVisualStyleBackColor = true;
            // 
            // cmdCMAProj
            // 
            this.cmdCMAProj.Location = new System.Drawing.Point(234, 116);
            this.cmdCMAProj.Name = "cmdCMAProj";
            this.cmdCMAProj.Size = new System.Drawing.Size(113, 31);
            this.cmdCMAProj.TabIndex = 1;
            this.cmdCMAProj.Text = "button2";
            this.cmdCMAProj.UseVisualStyleBackColor = true;
            this.cmdCMAProj.Click += new System.EventHandler(this.cmdCMAProj_Click);
            // 
            // cmdBackup
            // 
            this.cmdBackup.Location = new System.Drawing.Point(83, 174);
            this.cmdBackup.Name = "cmdBackup";
            this.cmdBackup.Size = new System.Drawing.Size(113, 31);
            this.cmdBackup.TabIndex = 2;
            this.cmdBackup.Text = "button3";
            this.cmdBackup.UseVisualStyleBackColor = true;
            // 
            // cmdRestore
            // 
            this.cmdRestore.Location = new System.Drawing.Point(244, 174);
            this.cmdRestore.Name = "cmdRestore";
            this.cmdRestore.Size = new System.Drawing.Size(113, 31);
            this.cmdRestore.TabIndex = 3;
            this.cmdRestore.Text = "button4";
            this.cmdRestore.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(395, 163);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(113, 31);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "button5";
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // lblCMSCaption
            // 
            this.lblCMSCaption.AutoSize = true;
            this.lblCMSCaption.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMSCaption.Location = new System.Drawing.Point(31, 9);
            this.lblCMSCaption.Name = "lblCMSCaption";
            this.lblCMSCaption.Size = new System.Drawing.Size(393, 78);
            this.lblCMSCaption.TabIndex = 5;
            this.lblCMSCaption.Text = "CMA DATA v1.0";
            // 
            // FrmMainCma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 262);
            this.Controls.Add(this.lblCMSCaption);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdRestore);
            this.Controls.Add(this.cmdBackup);
            this.Controls.Add(this.cmdCMAProj);
            this.Controls.Add(this.cmdBnkStnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainCma";
            this.Text = "FrmMainCma";
            this.Load += new System.EventHandler(this.FrmMainCma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBnkStnd;
        private System.Windows.Forms.Button cmdCMAProj;
        private System.Windows.Forms.Button cmdBackup;
        private System.Windows.Forms.Button cmdRestore;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblCMSCaption;
    }
}