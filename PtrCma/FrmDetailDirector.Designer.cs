namespace PtrCma
{
    partial class FrmDetailDirector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetailDirector));
            this.grdViewDirectors = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPan = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.pictitle = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDirectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewDirectors
            // 
            this.grdViewDirectors.BackgroundColor = System.Drawing.Color.White;
            this.grdViewDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewDirectors.Location = new System.Drawing.Point(26, 113);
            this.grdViewDirectors.Name = "grdViewDirectors";
            this.grdViewDirectors.Size = new System.Drawing.Size(240, 189);
            this.grdViewDirectors.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(297, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name and Qualifications";
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(297, 160);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(160, 16);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblPan
            // 
            this.lblPan.Location = new System.Drawing.Point(297, 183);
            this.lblPan.Name = "lblPan";
            this.lblPan.Size = new System.Drawing.Size(160, 15);
            this.lblPan.TabIndex = 3;
            this.lblPan.Text = "PAN";
            // 
            // lblAdd
            // 
            this.lblAdd.Location = new System.Drawing.Point(297, 206);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(160, 15);
            this.lblAdd.TabIndex = 4;
            this.lblAdd.Text = "Residential Address ";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(297, 228);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(160, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone No";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // lblNet
            // 
            this.lblNet.Location = new System.Drawing.Point(297, 252);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(160, 15);
            this.lblNet.TabIndex = 6;
            this.lblNet.Text = "Net Worth";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(477, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(477, 159);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(241, 20);
            this.txtAge.TabIndex = 9;
            // 
            // txtPan
            // 
            this.txtPan.Location = new System.Drawing.Point(477, 183);
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(241, 20);
            this.txtPan.TabIndex = 10;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(477, 206);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(241, 20);
            this.txtAdd.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(477, 228);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(241, 20);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(477, 252);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(241, 20);
            this.txtNet.TabIndex = 13;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(510, 312);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(39, 23);
            this.cmdAdd.TabIndex = 14;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(581, 312);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(47, 23);
            this.cmdDelete.TabIndex = 15;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(660, 312);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(40, 23);
            this.cmdExit.TabIndex = 16;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictitle
            // 
            this.pictitle.BackColor = System.Drawing.Color.Transparent;
            this.pictitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(99, 20);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(511, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 17;
            this.pictitle.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::PtrCma.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(684, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // FrmDetailDirector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 367);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictitle);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtPan);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblPan);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grdViewDirectors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetailDirector";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmDetailDirector";
            this.Load += new System.EventHandler(this.FrmDetailDirector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDirectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewDirectors;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPan;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNet;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}