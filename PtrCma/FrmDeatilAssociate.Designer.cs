namespace PtrCma
{
    partial class FrmDeatilAssociate
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtOutst = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtProp = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOutst = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblProp = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.FrmAssociate = new System.Windows.Forms.DataGridView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FrmAssociate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(690, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 23);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(608, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 23);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(537, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtOutst
            // 
            this.txtOutst.Location = new System.Drawing.Point(429, 250);
            this.txtOutst.Name = "txtOutst";
            this.txtOutst.Size = new System.Drawing.Size(301, 20);
            this.txtOutst.TabIndex = 32;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(429, 222);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(301, 20);
            this.txtLimit.TabIndex = 31;
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(429, 193);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(301, 20);
            this.txtBank.TabIndex = 30;
            // 
            // txtProp
            // 
            this.txtProp.Location = new System.Drawing.Point(429, 163);
            this.txtProp.Name = "txtProp";
            this.txtProp.Size = new System.Drawing.Size(301, 20);
            this.txtProp.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(429, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 20);
            this.txtName.TabIndex = 28;
            // 
            // lblOutst
            // 
            this.lblOutst.Location = new System.Drawing.Point(306, 253);
            this.lblOutst.Name = "lblOutst";
            this.lblOutst.Size = new System.Drawing.Size(117, 17);
            this.lblOutst.TabIndex = 27;
            this.lblOutst.Text = "Outstanding";
            // 
            // lblLimit
            // 
            this.lblLimit.Location = new System.Drawing.Point(306, 225);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(117, 17);
            this.lblLimit.TabIndex = 26;
            this.lblLimit.Text = "Limit";
            // 
            // lblBank
            // 
            this.lblBank.Location = new System.Drawing.Point(306, 196);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(117, 17);
            this.lblBank.TabIndex = 25;
            this.lblBank.Text = "Banking With";
            // 
            // lblProp
            // 
            this.lblProp.Location = new System.Drawing.Point(306, 166);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(117, 17);
            this.lblProp.TabIndex = 24;
            this.lblProp.Text = "Name(s) of Prop";
            // 
            // lblUnit
            // 
            this.lblUnit.Location = new System.Drawing.Point(306, 137);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(117, 17);
            this.lblUnit.TabIndex = 23;
            this.lblUnit.Text = "Name of Unit";
            // 
            // FrmAssociate
            // 
            this.FrmAssociate.BackgroundColor = System.Drawing.Color.White;
            this.FrmAssociate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FrmAssociate.Location = new System.Drawing.Point(17, 131);
            this.FrmAssociate.Name = "FrmAssociate";
            this.FrmAssociate.Size = new System.Drawing.Size(258, 200);
            this.FrmAssociate.TabIndex = 22;
            // 
            // lbltitle
            // 
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(29, 33);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(670, 23);
            this.lbltitle.TabIndex = 21;
            this.lbltitle.Text = "Detail of Associate/Sister/Identical Firms";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(698, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 25);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmDeatilAssociate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 415);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOutst);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtProp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOutst);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.FrmAssociate);
            this.Controls.Add(this.lbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDeatilAssociate";
            this.Text = "FrmDeatilAssociate";
            this.Load += new System.EventHandler(this.FrmDeatilAssociate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FrmAssociate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtOutst;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtProp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOutst;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DataGridView FrmAssociate;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnClose;
    }
}