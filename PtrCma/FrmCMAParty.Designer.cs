namespace PtrCma
{
    partial class FrmCMAParty
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
            this.lblfind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cmdReset = new System.Windows.Forms.Button();
            this.grdViewParty = new System.Windows.Forms.DataGridView();
            this.lblCodeno = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.lblAdd3 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.lblPrepBy1 = new System.Windows.Forms.Label();
            this.lblPrepBy2 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.txtCodeno = new System.Windows.Forms.TextBox();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtAdd3 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtPrepBy1 = new System.Windows.Forms.TextBox();
            this.txtPrepBy2 = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtareanotes = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictFrmClose = new System.Windows.Forms.PictureBox();
            this.lblparty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFrmClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfind
            // 
            this.lblfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfind.ForeColor = System.Drawing.Color.Black;
            this.lblfind.Location = new System.Drawing.Point(51, 102);
            this.lblfind.Name = "lblfind";
            this.lblfind.Size = new System.Drawing.Size(37, 21);
            this.lblfind.TabIndex = 0;
            this.lblfind.Text = "Find";
            // 
            // txtFind
            // 
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(98, 102);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(163, 19);
            this.txtFind.TabIndex = 1;
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
            // 
            // cmdReset
            // 
            this.cmdReset.BackColor = System.Drawing.SystemColors.Control;
            this.cmdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReset.ForeColor = System.Drawing.Color.Black;
            this.cmdReset.Location = new System.Drawing.Point(299, 102);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(56, 23);
            this.cmdReset.TabIndex = 2;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = false;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // grdViewParty
            // 
            this.grdViewParty.AllowUserToAddRows = false;
            this.grdViewParty.AllowUserToDeleteRows = false;
            this.grdViewParty.AllowUserToResizeColumns = false;
            this.grdViewParty.AllowUserToResizeRows = false;
            this.grdViewParty.BackgroundColor = System.Drawing.Color.White;
            this.grdViewParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewParty.Location = new System.Drawing.Point(51, 131);
            this.grdViewParty.Name = "grdViewParty";
            this.grdViewParty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdViewParty.Size = new System.Drawing.Size(301, 450);
            this.grdViewParty.TabIndex = 3;
            this.grdViewParty.TabStop = false;
            this.grdViewParty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewParty_CellClick);
            this.grdViewParty.DoubleClick += new System.EventHandler(this.grdViewParty_DoubleClick);
            // 
            // lblCodeno
            // 
            this.lblCodeno.ForeColor = System.Drawing.Color.Black;
            this.lblCodeno.Location = new System.Drawing.Point(396, 99);
            this.lblCodeno.Name = "lblCodeno";
            this.lblCodeno.Size = new System.Drawing.Size(52, 20);
            this.lblCodeno.TabIndex = 4;
            this.lblCodeno.Text = "CodeNo";
            // 
            // lblActivity
            // 
            this.lblActivity.ForeColor = System.Drawing.Color.Black;
            this.lblActivity.Location = new System.Drawing.Point(396, 122);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(46, 20);
            this.lblActivity.TabIndex = 5;
            this.lblActivity.Text = "Activity";
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(396, 146);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblAdd1
            // 
            this.lblAdd1.Location = new System.Drawing.Point(396, 170);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(46, 20);
            this.lblAdd1.TabIndex = 7;
            this.lblAdd1.Text = "Add1";
            // 
            // lblAdd2
            // 
            this.lblAdd2.Location = new System.Drawing.Point(396, 196);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(46, 17);
            this.lblAdd2.TabIndex = 8;
            this.lblAdd2.Text = "Add2";
            // 
            // lblAdd3
            // 
            this.lblAdd3.Location = new System.Drawing.Point(396, 218);
            this.lblAdd3.Name = "lblAdd3";
            this.lblAdd3.Size = new System.Drawing.Size(46, 20);
            this.lblAdd3.TabIndex = 9;
            this.lblAdd3.Text = "Add3";
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(396, 242);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 20);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(396, 266);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 20);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "State";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(396, 290);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 20);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone";
            // 
            // lblMobile
            // 
            this.lblMobile.Location = new System.Drawing.Point(396, 314);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(46, 20);
            this.lblMobile.TabIndex = 13;
            this.lblMobile.Text = "Mob";
            // 
            // lblFax
            // 
            this.lblFax.Location = new System.Drawing.Point(396, 338);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(46, 20);
            this.lblFax.TabIndex = 14;
            this.lblFax.Text = "Fax";
            // 
            // lblEmail1
            // 
            this.lblEmail1.Location = new System.Drawing.Point(396, 362);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(46, 20);
            this.lblEmail1.TabIndex = 15;
            this.lblEmail1.Text = "Email1";
            // 
            // lblEmail2
            // 
            this.lblEmail2.Location = new System.Drawing.Point(396, 386);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(46, 20);
            this.lblEmail2.TabIndex = 16;
            this.lblEmail2.Text = "Email2";
            // 
            // lblPrepBy1
            // 
            this.lblPrepBy1.Location = new System.Drawing.Point(396, 412);
            this.lblPrepBy1.Name = "lblPrepBy1";
            this.lblPrepBy1.Size = new System.Drawing.Size(63, 16);
            this.lblPrepBy1.TabIndex = 17;
            this.lblPrepBy1.Text = "Prep By 1";
            // 
            // lblPrepBy2
            // 
            this.lblPrepBy2.Location = new System.Drawing.Point(396, 436);
            this.lblPrepBy2.Name = "lblPrepBy2";
            this.lblPrepBy2.Size = new System.Drawing.Size(63, 16);
            this.lblPrepBy2.TabIndex = 18;
            this.lblPrepBy2.Text = "Prep By 2";
            // 
            // lblNotes
            // 
            this.lblNotes.Location = new System.Drawing.Point(396, 460);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(52, 23);
            this.lblNotes.TabIndex = 19;
            this.lblNotes.Text = "Notes";
            // 
            // lblBranch
            // 
            this.lblBranch.ForeColor = System.Drawing.Color.Black;
            this.lblBranch.Location = new System.Drawing.Point(615, 99);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(56, 20);
            this.lblBranch.TabIndex = 20;
            this.lblBranch.Text = "Branch";
            // 
            // txtCodeno
            // 
            this.txtCodeno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeno.Location = new System.Drawing.Point(488, 99);
            this.txtCodeno.Name = "txtCodeno";
            this.txtCodeno.Size = new System.Drawing.Size(113, 19);
            this.txtCodeno.TabIndex = 8;
            this.txtCodeno.Tag = "";
            this.txtCodeno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtActivity
            // 
            this.txtActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivity.Location = new System.Drawing.Point(488, 123);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(338, 19);
            this.txtActivity.TabIndex = 10;
            this.txtActivity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(488, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(338, 19);
            this.txtName.TabIndex = 11;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtAdd1
            // 
            this.txtAdd1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd1.Location = new System.Drawing.Point(488, 171);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(338, 19);
            this.txtAdd1.TabIndex = 12;
            this.txtAdd1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtAdd2
            // 
            this.txtAdd2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd2.Location = new System.Drawing.Point(488, 195);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(338, 19);
            this.txtAdd2.TabIndex = 13;
            this.txtAdd2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtAdd3
            // 
            this.txtAdd3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd3.Location = new System.Drawing.Point(488, 219);
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.Size = new System.Drawing.Size(338, 19);
            this.txtAdd3.TabIndex = 14;
            this.txtAdd3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(488, 243);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(190, 19);
            this.txtCity.TabIndex = 15;
            this.txtCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(488, 267);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(190, 19);
            this.txtState.TabIndex = 16;
            this.txtState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(488, 291);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(338, 19);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtMobile
            // 
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(488, 315);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(338, 19);
            this.txtMobile.TabIndex = 18;
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(488, 339);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(338, 19);
            this.txtFax.TabIndex = 19;
            this.txtFax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtEmail1
            // 
            this.txtEmail1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail1.Location = new System.Drawing.Point(488, 363);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(338, 19);
            this.txtEmail1.TabIndex = 20;
            this.txtEmail1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtEmail2
            // 
            this.txtEmail2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail2.Location = new System.Drawing.Point(488, 387);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(338, 19);
            this.txtEmail2.TabIndex = 21;
            this.txtEmail2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtPrepBy1
            // 
            this.txtPrepBy1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrepBy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrepBy1.Location = new System.Drawing.Point(488, 411);
            this.txtPrepBy1.Name = "txtPrepBy1";
            this.txtPrepBy1.Size = new System.Drawing.Size(338, 19);
            this.txtPrepBy1.TabIndex = 22;
            this.txtPrepBy1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtPrepBy2
            // 
            this.txtPrepBy2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrepBy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrepBy2.Location = new System.Drawing.Point(488, 435);
            this.txtPrepBy2.Name = "txtPrepBy2";
            this.txtPrepBy2.Size = new System.Drawing.Size(338, 19);
            this.txtPrepBy2.TabIndex = 23;
            this.txtPrepBy2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdd.Location = new System.Drawing.Point(396, 558);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(46, 23);
            this.cmdAdd.TabIndex = 3;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(448, 558);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(46, 23);
            this.cmdEdit.TabIndex = 4;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(502, 558);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(61, 23);
            this.cmdDelete.TabIndex = 5;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdSelect
            // 
            this.cmdSelect.Location = new System.Drawing.Point(593, 558);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(166, 23);
            this.cmdSelect.TabIndex = 6;
            this.cmdSelect.Text = "Select Party And Continue";
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(765, 558);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(42, 23);
            this.cmdExit.TabIndex = 7;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtBranch
            // 
            this.txtBranch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBranch.Location = new System.Drawing.Point(706, 99);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(120, 19);
            this.txtBranch.TabIndex = 9;
            this.txtBranch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // txtareanotes
            // 
            this.txtareanotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtareanotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtareanotes.Location = new System.Drawing.Point(396, 486);
            this.txtareanotes.Multiline = true;
            this.txtareanotes.Name = "txtareanotes";
            this.txtareanotes.Size = new System.Drawing.Size(436, 52);
            this.txtareanotes.TabIndex = 24;
            this.txtareanotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(546, 558);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(51, 23);
            this.cmdSave.TabIndex = 25;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Visible = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(603, 558);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(68, 23);
            this.cmdCancel.TabIndex = 26;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Visible = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PtrCma.Properties.Resources.partybg;
            this.pictureBox1.Location = new System.Drawing.Point(194, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictFrmClose
            // 
            this.pictFrmClose.BackgroundImage = global::PtrCma.Properties.Resources.closeBtnBg;
            this.pictFrmClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictFrmClose.Image = global::PtrCma.Properties.Resources.close;
            this.pictFrmClose.Location = new System.Drawing.Point(804, 12);
            this.pictFrmClose.Name = "pictFrmClose";
            this.pictFrmClose.Size = new System.Drawing.Size(49, 47);
            this.pictFrmClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictFrmClose.TabIndex = 44;
            this.pictFrmClose.TabStop = false;
            this.pictFrmClose.Click += new System.EventHandler(this.pictFrmClose_Click);
            // 
            // lblparty
            // 
            this.lblparty.BackColor = System.Drawing.Color.Transparent;
            this.lblparty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblparty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparty.Image = global::PtrCma.Properties.Resources.partybg;
            this.lblparty.Location = new System.Drawing.Point(196, 21);
            this.lblparty.Name = "lblparty";
            this.lblparty.Size = new System.Drawing.Size(509, 26);
            this.lblparty.TabIndex = 43;
            this.lblparty.Text = "Party Master";
            this.lblparty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblparty.Visible = false;
            // 
            // FrmCMAParty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictFrmClose);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lblparty);
            this.Controls.Add(this.txtareanotes);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtPrepBy2);
            this.Controls.Add(this.txtPrepBy1);
            this.Controls.Add(this.txtEmail2);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdd3);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.txtAdd1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.txtCodeno);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblPrepBy2);
            this.Controls.Add(this.lblPrepBy1);
            this.Controls.Add(this.lblEmail2);
            this.Controls.Add(this.lblEmail1);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAdd3);
            this.Controls.Add(this.lblAdd2);
            this.Controls.Add(this.lblAdd1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblCodeno);
            this.Controls.Add(this.grdViewParty);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblfind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCMAParty";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmCMAParty";
            this.TransparencyKey = System.Drawing.Color.PaleTurquoise;
            this.Load += new System.EventHandler(this.FrmCMAParty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFrmClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.DataGridView grdViewParty;
        private System.Windows.Forms.Label lblCodeno;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.Label lblAdd3;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.Label lblPrepBy1;
        private System.Windows.Forms.Label lblPrepBy2;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.TextBox txtCodeno;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtAdd3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtPrepBy1;
        private System.Windows.Forms.TextBox txtPrepBy2;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSelect;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtareanotes;
        private System.Windows.Forms.Label lblparty;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.PictureBox pictFrmClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}