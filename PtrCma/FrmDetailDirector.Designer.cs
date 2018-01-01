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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdDel = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.pictitle = new System.Windows.Forms.PictureBox();
            this.picFrmClose = new System.Windows.Forms.PictureBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDirectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).BeginInit();
            this.SuspendLayout();
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
            this.grdViewDirectors.Location = new System.Drawing.Point(26, 113);
            this.grdViewDirectors.Name = "grdViewDirectors";
            this.grdViewDirectors.RowHeadersVisible = false;
            this.grdViewDirectors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdViewDirectors.Size = new System.Drawing.Size(240, 182);
            this.grdViewDirectors.TabIndex = 0;
            this.grdViewDirectors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewDirectors_CellClick);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(297, 137);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(477, 136);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 8;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
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
            this.txtPan.Location = new System.Drawing.Point(477, 182);
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(241, 20);
            this.txtPan.TabIndex = 10;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(477, 205);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(241, 20);
            this.txtAdd.TabIndex = 11;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(612, 312);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(50, 30);
            this.cmdCancel.TabIndex = 14;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdDel
            // 
            this.cmdDel.Location = new System.Drawing.Point(546, 312);
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Size = new System.Drawing.Size(60, 30);
            this.cmdDel.TabIndex = 15;
            this.cmdDel.Text = "Delete";
            this.cmdDel.UseVisualStyleBackColor = true;
            this.cmdDel.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(668, 312);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(50, 30);
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
            this.pictitle.Location = new System.Drawing.Point(118, 20);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(511, 30);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 17;
            this.pictitle.TabStop = false;
            // 
            // picFrmClose
            // 
            this.picFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.picFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrmClose.Image = global::PtrCma.Properties.Resources.close;
            this.picFrmClose.Location = new System.Drawing.Point(684, 20);
            this.picFrmClose.Name = "picFrmClose";
            this.picFrmClose.Size = new System.Drawing.Size(34, 34);
            this.picFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrmClose.TabIndex = 18;
            this.picFrmClose.TabStop = false;
            this.picFrmClose.Click += new System.EventHandler(this.picFrmClose_Click);
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(26, 65);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 20);
            this.txtRef.TabIndex = 19;
            this.txtRef.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(297, 228);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(160, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone No";
            // 
            // lblNet
            // 
            this.lblNet.Location = new System.Drawing.Point(297, 251);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(160, 15);
            this.lblNet.TabIndex = 6;
            this.lblNet.Text = "Net Worth";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(477, 228);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(241, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(477, 251);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(241, 20);
            this.txtNet.TabIndex = 13;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(368, 312);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(50, 30);
            this.cmdAdd.TabIndex = 20;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(424, 312);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(50, 30);
            this.cmdEdit.TabIndex = 21;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(480, 312);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(60, 30);
            this.cmdUpdate.TabIndex = 22;
            this.cmdUpdate.Text = "Save";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(441, 87);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(108, 12);
            this.lblData.TabIndex = 47;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblData.Visible = false;
            // 
            // FrmDetailDirector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 358);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.picFrmClose);
            this.Controls.Add(this.pictitle);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDel);
            this.Controls.Add(this.cmdCancel);
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
            ((System.ComponentModel.ISupportInitialize)(this.picFrmClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewDirectors;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPan;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdDel;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.PictureBox picFrmClose;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNet;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Label lblData;
    }
}