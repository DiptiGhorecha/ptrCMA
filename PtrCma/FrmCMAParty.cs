using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using MessageBoxExample;
using System.Threading;
using System.Text.RegularExpressions;

namespace PtrCma
{

    public partial class FrmCMAParty : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToOpenChildFormCma;
      
        string isAddEdit = ""; //Variable to Store Current Action(Add,Edit)
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " +Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        OleDbTransaction transaction;
        int rowNum;  // Variable to Store Current Row Number


        public FrmCMAParty()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void FrmCMAParty_Load(object sender, EventArgs e)
        {
            
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            this.KeyPreview = true; //To handle enter key
           
            Settings();         //set size and color of controls
            controlvisible();   // Visible Button and Textbox
            controlenable();    //Enable Button and Textbox
            clearTextbox();     //Clear the Textbox
                          
            richAreaNotes.Enabled = false;
            fillgird();         //Show Data in Gridview at Runtime

            if (grdViewParty.RowCount>0)
            {
                grdViewParty.CurrentCell = grdViewParty.Rows[0].Cells[1];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }
            else
            {
                cmdDelete.Visible = false;
                cmdEdit.Visible = false;
            }
        }


        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;      // Show BackGround Image
            setControlcolor(); //Label and Textbox BackColor/Forecolor
            setControlsize(); //Label and TextBox Resize
                        
  
            grdViewParty.Size = Global.grdPartySize;
            this.Width = grdViewParty.Width + richAreaNotes.Width + 155;

            grdViewParty.RowsDefaultCellStyle.BackColor = Color.White;     // Row Color of Gridview
         
            // Column Header Color of Gridview
            grdViewParty.ColumnHeadersHeight = 30;
            grdViewParty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdViewParty.EnableHeadersVisualStyles = false;
            grdViewParty.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            grdViewParty.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;

            richAreaNotes.AppendText(Environment.NewLine);   // After Pressing Enter Inserting a New Line                                             
        }


        private void controlvisible()       // Visible Control
        {
            cmdAdd.Visible = true;
            cmdEdit.Visible = true;
            cmdDelete.Visible = true;
            cmdSelect.Visible = true;
            cmdExit.Visible = true;
            cmdSave.Visible = false;
            cmdCancel.Visible = false;
            cmdReset.Visible = true;
        }


        private void controlenable()        // Enable Control
        {
            cmdAdd.Enabled = true;
            cmdEdit.Enabled = true;
            cmdDelete.Enabled = true;
            cmdSelect.Enabled = true;
            cmdExit.Enabled = true;
            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;
            cmdReset.Enabled = true;
            grdViewParty.Enabled = true;
            txtFind.Enabled = true;
        }


        private void clearTextbox()     //Clear the TextBox
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())  
            {
                txt.Clear();
                richAreaNotes.Clear();
            }
        }


        private void enableTextbox()     // Enable The TextBox
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())  
            {
                txt.Enabled = true;
                richAreaNotes.Enabled = true;
            }
        }


        private void fillgird()    //For Fill DataGridView
        {
            //Displaying data in Gridview
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = new OleDbDataAdapter("Select * from Cd_MsCln", con);
            da.Fill(ds, "Cd_MsCln");
            grdViewParty.DataMember = "Cd_MsCln";
            grdViewParty.DataSource = ds;
            con.Close();
            grdViewParty.Refresh();

            //Show selected Column in Gridview
            for (int i = 0; i <= grdViewParty.Columns.Count - 1; i++)      
            {
                grdViewParty.Columns[i].ReadOnly = true;
                grdViewParty.Columns[i].Visible = false;
            }

            grdViewParty.Columns[1].Visible = true;
            grdViewParty.Columns[1].HeaderText = "Party Code";
            grdViewParty.Columns[1].Width = 100;

            grdViewParty.Columns[4].Visible = true;
            grdViewParty.Columns[4].HeaderText = "Party Name";
            grdViewParty.Columns[4].Width = 195;

        }


        private void LoadDatatoTextBox()
        {
                //Set The Length of Input Character
                txtCodeno.MaxLength = 10;
                txtActivity.MaxLength = 30;
                txtBranch.MaxLength = 20;
                txtName.MaxLength = 40;
                txtAdd1.MaxLength = 30;
                txtAdd2.MaxLength = 30;
                txtAdd3.MaxLength = 30;
                txtCity.MaxLength = 30;
                txtState.MaxLength = 30;
                txtPhone.MaxLength = 15;
                txtMobile.MaxLength = 10;
                txtFax.MaxLength = 20;
                txtEmail1.MaxLength = 30;
                txtEmail2.MaxLength = 30;
                txtPrepBy1.MaxLength = 20;
                txtPrepBy2.MaxLength = 20;
                richAreaNotes.MaxLength = 500;


            if (grdViewParty.RowCount>0)    // No Crashing problem when there is no data in gridview
            {
            DataGridViewRow row = this.grdViewParty.Rows[0];
            txtRefParty.Text = row.Cells["CL_REFNO"].Value.ToString();
                txtYr.Text = row.Cells["CL_YEARS"].Value.ToString();
                txtRs.Text = row.Cells["CL_RSIN"].Value.ToString();
                txtCodeno.Text = row.Cells["CL_CODENO"].Value.ToString();
            txtActivity.Text = row.Cells["CL_ACT"].Value.ToString();
            txtBranch.Text = row.Cells["CL_BRANCH"].Value.ToString();
            txtName.Text = row.Cells["CL_NAME"].Value.ToString();
            txtAdd1.Text = row.Cells["CL_ADD1"].Value.ToString();
            txtAdd2.Text = row.Cells["CL_ADD2"].Value.ToString();
            txtAdd3.Text = row.Cells["CL_ADD3"].Value.ToString();
            txtCity.Text = row.Cells["CL_CITY"].Value.ToString();
            txtState.Text = row.Cells["CL_STATE"].Value.ToString();
            txtPhone.Text = row.Cells["CL_FPH"].Value.ToString();
            txtMobile.Text = row.Cells["CL_MOB"].Value.ToString();
            txtFax.Text = row.Cells["CL_FAX"].Value.ToString();
            txtEmail1.Text = row.Cells["CL_EMAIL1"].Value.ToString();
            txtEmail2.Text = row.Cells["CL_EMAIL2"].Value.ToString();
            txtPrepBy1.Text = row.Cells["CL_PREP1"].Value.ToString();
            txtPrepBy2.Text = row.Cells["CL_PREP2"].Value.ToString();
            richAreaNotes.Text = row.Cells["CL_NOTES"].Value.ToString();
            Regex.Replace(richAreaNotes.Text, "[^0-9A-Za-z ,]", ",");  //Support Special Character in Richtextbox
            }
            else
            {
                // No visible when no record found in gridview
                cmdDelete.Visible = false;
                cmdEdit.Visible = false;
            }

        }

        private void LoadCurrentDatatoTextBox(int rowNum)
        {
            //Current Selected Value Show in Textbox
            DataGridViewRow row = this.grdViewParty.Rows[rowNum];
            txtRefParty.Text= row.Cells["CL_REFNO"].Value.ToString();
            txtYr.Text = row.Cells["CL_YEARS"].Value.ToString();
            txtRs.Text = row.Cells["CL_RSIN"].Value.ToString();
            txtCodeno.Text = row.Cells["CL_CODENO"].Value.ToString();
            txtActivity.Text = row.Cells["CL_ACT"].Value.ToString();
            txtBranch.Text = row.Cells["CL_BRANCH"].Value.ToString();
            txtName.Text = row.Cells["CL_NAME"].Value.ToString();
            txtAdd1.Text = row.Cells["CL_ADD1"].Value.ToString();
            txtAdd2.Text = row.Cells["CL_ADD2"].Value.ToString();
            txtAdd3.Text = row.Cells["CL_ADD3"].Value.ToString();
            txtCity.Text = row.Cells["CL_CITY"].Value.ToString();
            txtState.Text = row.Cells["CL_STATE"].Value.ToString();
            txtPhone.Text = row.Cells["CL_FPH"].Value.ToString();
            txtMobile.Text = row.Cells["CL_MOB"].Value.ToString();
            txtFax.Text = row.Cells["CL_FAX"].Value.ToString();
            txtEmail1.Text = row.Cells["CL_EMAIL1"].Value.ToString();
            txtEmail2.Text = row.Cells["CL_EMAIL2"].Value.ToString();
            txtPrepBy1.Text = row.Cells["CL_PREP1"].Value.ToString();
            txtPrepBy2.Text = row.Cells["CL_PREP2"].Value.ToString();
            richAreaNotes.Text = row.Cells["CL_NOTES"].Value.ToString();
        }
        

        private void setControlcolor()      //Set Color in Control
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = false;
                txtFind.Enabled = true;
                txt.BackColor = Global.txtColorPartyMst;
                // txt.SelectionStart. = Color.Gainsboro;
    
            }

            foreach (Label lbl in Controls.OfType<Label>()) //Set the Label Color
            {
                lbl.BackColor = Global.lblColorPartyMst;
                lbl.ForeColor = Global.lblForeColorPartyMst;
                lbl.Font = Global.lblPartyfont;
            }

            lblparty.BackColor = Global.lblparty;
            lblparty.ForeColor = Global.lbltitle;
            lblparty.Font = Global.lblPartyTitlefont;
            lblparty.Image = Global.partyLblBackImg;
            lblparty.ImageAlign= ContentAlignment.MiddleCenter;
            Bitmap bm = Global.partyLblBackImg;
            pictureBox1.Image = bm;

            foreach (Button btn in Controls.OfType<Button>())  // Set the  Button Color
            {
                btn.ForeColor = Global.btnfore;
                btn.BackgroundImage = Global.cmdImg;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }

            //  Set the Gridview Color
            grdViewParty.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            grdViewParty.DefaultCellStyle.SelectionForeColor = Color.Black;

        }
    
        private void setControlsize()           //Set Size of Control
        {
            foreach (Label lbl in Controls.OfType<Label>()) //Set Size of Label
            {
                lbl.Font = Global.lblSize;
                lbl.Size = Global.medsizelbl;
                lbl.AutoSize = false;
            }
            lblfind.Size = Global.smallsizelbl;
            lblparty.Size = Global.largesizelbl;

            foreach (TextBox txt in Controls.OfType<TextBox>())  //Set Size of TextBox
            {
                txt.Size = Global.txtCommonSize;
                txt.Font = Global.txtSize;

            }
            txtFind.Size = Global.txtFindSize;
            txtCodeno.Size = Global.txtCodenoSize;
            txtBranch.Size = Global.txtBranchSize;
            richAreaNotes.Size = Global.txtNotesSize;

            foreach (Button btn in Controls.OfType<Button>())   //Set Size of Button
            {
                btn.Size = Global.btnSmallSize;
            }
            cmdReset.Size = Global.smallBtn;
            cmdCancel.Size = Global.btnmedSize;
            cmdDelete.Size = Global.btnmedSize;
            cmdSelect.Size = Global.btnLargeSize;
        }

        private void cmdAdd_Click(object sender, EventArgs e)       //Perform Add Button
        { 
            cmdSave.Visible = true;
            cmdCancel.Visible = true;
            grdViewParty.Enabled = false;
            cmdReset.Enabled = false;
            txtFind.Enabled = false;
            clearTextbox();
            enableTextbox();
            cmdAdd.Visible = false;
            cmdEdit.Visible = false;
            cmdDelete.Visible = false;
            cmdSelect.Visible = false;
            cmdExit.Visible = false;
            txtCodeno.Focus();
            isAddEdit = "A";
            lblData.Visible = true;
            lblData.Text = "ADD";
        }
        
        private void btnInsert()            //Perform Insert/Update After Clicking on Button
        {
            
            try
            {
                //  Perform Inserting after Click on Add Button
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = connectionString;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
               
                if (isAddEdit == "A")  //Add button click
                {
                txtCodeno.Focus();
                    
                    String sql = "insert into Cd_MsCln(CL_CODENO,CL_ACT,CL_BRANCH,CL_NAME,CL_ADD1,CL_ADD2,CL_ADD3,CL_CITY,CL_STATE,CL_FPH,CL_MOB,CL_FAX,CL_EMAIL1,CL_EMAIL2,CL_NOTES,CL_PREP1,CL_PREP2)"+" values ('" + this.txtCodeno.Text.Replace("'", "''") + "','" + this.txtActivity.Text.Replace("'", "''") + "','" + this.txtBranch.Text.Replace("'", "''") + "','" + this.txtName.Text.Replace("'", "''") + "','" + this.txtAdd1.Text.Replace("'", "''") + "','" + this.txtAdd2.Text.Replace("'", "''") + "','" + this.txtAdd3.Text.Replace("'", "''") + "','" + this.txtCity.Text.Replace("'", "''") + "','" + this.txtState.Text.Replace("'", "''") + "','" + this.txtPhone.Text.Replace("'", "''") + "','" + this.txtMobile.Text.Replace("'", "''") + "','" + this.txtFax.Text.Replace("'", "''") + "','" + this.txtEmail1.Text.Replace("'", "''") + "','" + this.txtEmail2.Text.Replace("'", "''") + "','" + this.richAreaNotes.Text.Replace("'", "''") + "','" + this.txtPrepBy1.Text.Replace("'", "''") + "','" + this.txtPrepBy2.Text.Replace("'", "''") + "') ";
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    con.Close();
                    fillgird();
                    LoadDatatoTextBox();
                    MessageBox.Show(GlobalMsg.insertMsg, "Perfect Tax Reporter - CMA 1.0");
                    lblData.Visible = false;
                }

            else

            {  
             // Perform Updating After Click on Edit Button

                txtBranch.Focus();
                    //rowNum = grdViewParty.CurrentRow.Index; 
                    DialogResult dialogResult1 = MessageBox.Show(GlobalMsg.updateMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
                if (dialogResult1 == DialogResult.Yes)
                {
                      
                        //LoadDatatoTextBox();

                        rowNum = grdViewParty.CurrentRow.Index;
                        
                         String sql1 = "Update Cd_MsCln set [CL_ACT]='" + this.txtActivity.Text.Replace("'", "''") + "' , [CL_BRANCH] ='" + this.txtBranch.Text.Replace("'", "''") + "', [CL_NAME] ='" + this.txtName.Text.Replace("'", "''") + "',[CL_ADD1]='" + this.txtAdd1.Text.Replace("'", "''") + "', [CL_ADD2]='" + this.txtAdd2.Text.Replace("'", "''") + "', [CL_ADD3]='" + this.txtAdd3.Text.Replace("'", "''") + "', [CL_CITY]='" + this.txtCity.Text.Replace("'", "''") + "', [CL_STATE]='" + this.txtState.Text.Replace("'", "''") + "', [CL_FPH]='" + this.txtPhone.Text.Replace("'", "''") + "', [CL_MOB]='" + this.txtMobile.Text.Replace("'", "''") + "', [CL_FAX]='" + this.txtFax.Text.Replace("'", "''") + "', [CL_EMAIL1]='" + this.txtEmail1.Text.Replace("'", "''") + "', [CL_EMAIL2]='" + this.txtEmail2.Text.Replace("'", "''") + "', [CL_NOTES]='" + this.richAreaNotes.Text.Replace("'", "''") + "', [CL_PREP1]='" + this.txtPrepBy1.Text.Replace("'", "''") + "', [CL_PREP2]='" + this.txtPrepBy2.Text.Replace("'", "''") + "'  WHERE CL_CODENO= '" + this.txtCodeno.Text.Replace("'", "''") + "' ";
                        OleDbCommand cmd1 = new OleDbCommand(sql1, con);
                        cmd1.Transaction = transaction;
                        cmd1.ExecuteNonQuery();
                        transaction.Commit();
                        con.Close();
                       
                        fillgird();  //After updating data display it in Gridview
                        grdViewParty.CurrentCell = grdViewParty.Rows[rowNum].Cells[1];  // Show Current Selected Data
                        txtBranch.Focus();
                        
                        lblData.Visible = false;
                        MessageBox.Show(GlobalMsg.updateMsg, "Perfect Tax Reporter - CMA 1.0");
                        txtCodeno.Enabled = false;
                        controlvisible();
                        cmdSave.Visible = false;
                        cmdCancel.Visible = false;
                        cmdEdit.Enabled = true;
                        cmdDelete.Enabled = true;
                        cmdReset.Enabled = true;
                        txtFind.Enabled = true;
                    }
                else
                {
                        
                        enableTextbox();
                        txtCodeno.Enabled = false;
                        txtFind.Enabled = false;
                        cmdReset.Enabled = false;
                        grdViewParty.Enabled = false;
                        cmdAdd.Visible = false;
                        cmdEdit.Visible = false;
                        cmdDelete.Visible = false;
                        cmdSelect.Visible = false;
                        cmdExit.Visible = false;

                        cmdSave.Visible = true;
                        cmdCancel.Visible = true;
                        rowNum = grdViewParty.CurrentRow.Index;

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Perfect Tax Reporter - CMA 1.0");
     
                try
                {
                    transaction.Rollback();
                }catch
                { }
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Refresh();
            txtFind.Enabled = false;
            grdViewParty.Enabled = true;

            //Validations 
            
            if (txtCodeno.Text.Trim() == string.Empty)              // Code No  
            {

                MessageBox.Show(GlobalMsg.codeMsg, "Perfect Tax Reporter - CMA 1.0");
                 txtCodeno.Focus();
                 return; // return because we don't want to run normal code of buton click
            }
       
            if (txtName.Text.Trim() == string.Empty)              // Name
            {
                MessageBox.Show(GlobalMsg.nameMsg,"Perfect Tax Reporter - CMA 1.0");
                //MyMessageBox.ShowBox("Name Field cannnot be blank", "Perfect Tax Reporter - CMA 1.0");
                txtName.Focus();
                return; // return because we don't want to run normal code of buton click
            }

            if (isAddEdit == "A")  // For Duplicate Code
            {
                for (int nCounter = 0; nCounter <= grdViewParty.RowCount - 1; nCounter++)
                {
                    if (txtCodeno.Text == grdViewParty[1, nCounter].Value.ToString())
                    {
                        MessageBox.Show(GlobalMsg.duplicateMsg, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodeno.Focus();
                        return;
                    }

                }

            }
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = false;
                richAreaNotes.Enabled=false;
            }
            controlvisible();
            cmdSave.Visible = false;
            cmdCancel.Visible = false;

            controlenable();
            txtFind.Focus();
            btnInsert();  //insert-update data in database

        }


        private void cmdCancel_Click(object sender, EventArgs e)
        {
            txtFind.Enabled = true;
            cmdReset.Enabled = true;
            
            grdViewParty.Enabled = true;
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = false;
                richAreaNotes.Enabled = false;
            }

            DialogResult dialogResult = MessageBox.Show(GlobalMsg.cancelMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                controlvisible();
                cmdSave.Visible = false;
                cmdCancel.Visible = false;
                cmdEdit.Enabled = true;
                cmdDelete.Enabled = true;
                cmdReset.Enabled = true;
                txtFind.Enabled = true;
                LoadDatatoTextBox();
                txtFind.Focus();
                txtFind.Clear();
                fillgird();
                //rowNum = grdViewParty.CurrentRow.Index;

                //clearTextbox();
            }

            else
            {

                enableTextbox();
                txtCodeno.Enabled = false;
                txtFind.Enabled = false;
                cmdReset.Enabled = false;
                grdViewParty.Enabled = false;
                cmdAdd.Visible = false;
                cmdEdit.Visible = false;
                cmdDelete.Visible = false;
                cmdSelect.Visible = false;
                cmdExit.Visible = false;

                cmdSave.Visible = true;
                cmdCancel.Visible = true;
                //rowNum = grdViewParty.CurrentRow.Index;

            }


            lblData.Visible = false;
        }

        private void cmdEdit_Click(object sender, EventArgs e)  //Perform Update 
        {
            Refresh();
            grdViewParty.Enabled = false;
            isAddEdit = "B";
            txtBranch.Focus();
        
            enableTextbox();
            
            txtCodeno.Enabled = false;

            //txtFind.Enabled = true;
            //txtCodeno.Focus();
            cmdSave.Visible = true;
            cmdCancel.Visible = true;
            cmdAdd.Visible = false;
            cmdEdit.Visible = false;
            cmdDelete.Visible = false;
            cmdSelect.Visible = false;
            cmdExit.Visible = false;
            cmdReset.Enabled = false;
            txtFind.Enabled = false;
           
            lblData.Visible = true;
            lblData.Text = "EDIT";

        }



        private void cmdDelete_Click(object sender, EventArgs e)    //Perform Delete
        {
            try
            {
                DialogResult dialogResult1 = MessageBox.Show(GlobalMsg.deleteMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
                if (dialogResult1 == DialogResult.Yes)
                {
                    grdViewParty.Enabled = true;
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = connectionString;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    OleDbDataAdapter myadapter = new OleDbDataAdapter();
                    DataSet ds = new DataSet();
                    myadapter.SelectCommand = new OleDbCommand("Select * from Cp_CdFm1 where CM_CLREFNO = " + txtRefParty.Text,con);
                   myadapter.Fill(ds, "Cp_cdFm1");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show(GlobalMsg.deleteDataMsg, "Perfect Tax Reporter - CMA 1.0");
                        return;
                    }
                    else
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                        String sql = "delete from Cd_MsCln where CL_CODENO='" + this.txtCodeno.Text.Replace("'", "''") + "' ";
                        cmd = new OleDbCommand(sql, con);
                        cmd.Transaction = transaction;
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                       // con.Close();
                        fillgird();  //After inserting data display data in Gridview
                        MessageBox.Show(GlobalMsg.deleteMsg, "Perfect Tax Reporter - CMA 1.0");
                        cmdDelete.Enabled = true;
                        cmdEdit.Enabled = true;
                        grdViewParty.Enabled = true;

                        clearTextbox();
                        LoadDatatoTextBox();
                    }
                }
                else
                {
                    grdViewParty.Enabled = true;
                    //rowNum = grdViewParty.CurrentRow.Index;
                }
                cmdReset.Enabled = true;
                txtFind.Enabled = true;
                txtFind.Focus();
            }catch(Exception ex) {
                MessageBox.Show("Exception: Data Insertion in Party table in database" + ex.Message, "Perfect Tax Reporter - CMA 1.0");
                try
                {
                    transaction.Rollback();
                }catch{ }

            }
            
        }

        private void cmdSelect_Click(object sender, EventArgs e)   //Go to the Next Form
        {
            if (grdViewParty.RowCount > 0)
            {
                grdViewParty.CurrentCell = grdViewParty.Rows[0].Cells[1];  //Set 1st row as current row by default
                Global.prtyCode = txtRefParty.Text;  //grdViewParty.Rows[0].Cells[0].Value.ToString;  // txtCodeno.Text;
                Global.prtyName = txtName.Text;
                Global.curYr = txtYr.Text;
                Global.inrS = txtRs.Text;
                
                if (NotifyMainFormToOpenChildFormCma != null)
                {
                    this.Hide();
                  //  NotifyMainFormToCloseChildFormParty();
                    NotifyMainFormToOpenChildFormCma();
                }
                
            }
            else
            {
                this.Hide();
                NotifyMainFormToCloseChildFormParty();
                MessageBox.Show(GlobalMsg.selectMsg, "Perfect Tax Reporter - CMA 1.0");
            }
            
        }

        private void cmdExit_Click(object sender, EventArgs e)      // Close the Current Form
        {
            
          
           // LoadDatatoTextBox();
            grdViewParty.Enabled = true;
            //rowNum = grdViewParty.CurrentRow.Index;
          
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormParty();
                this.Hide();
                fillgird();
                LoadDatatoTextBox();
                txtFind.Clear();
                txtFind.Focus();
            }
            else
            {
                grdViewParty.Enabled = true;
                //clearTextbox();
                //LoadDatatoTextBox();
                //rowNum = grdViewParty.CurrentRow.Index;
            }
            
        }

        private void grdViewParty_CellClick(object sender, DataGridViewCellEventArgs e)  //Show Data in TextBox After Click on Gridview
        {
            
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = false;

            }
            txtFind.Enabled = true;
            cmdReset.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdViewParty.Rows[e.RowIndex];
                txtRefParty.Text = row.Cells["CL_REFNO"].Value.ToString();
                txtYr.Text = row.Cells["CL_YEARS"].Value.ToString();
                txtRs.Text = row.Cells["CL_RSIN"].Value.ToString();
                txtCodeno.Text = row.Cells["CL_CODENO"].Value.ToString();
                txtActivity.Text = row.Cells["CL_ACT"].Value.ToString();
                txtBranch.Text = row.Cells["CL_BRANCH"].Value.ToString();
                txtName.Text = row.Cells["CL_NAME"].Value.ToString();
                txtAdd1.Text = row.Cells["CL_ADD1"].Value.ToString();
                txtAdd2.Text = row.Cells["CL_ADD2"].Value.ToString();
                txtAdd3.Text = row.Cells["CL_ADD3"].Value.ToString();
                txtCity.Text = row.Cells["CL_CITY"].Value.ToString();
                txtState.Text = row.Cells["CL_STATE"].Value.ToString();
                txtPhone.Text = row.Cells["CL_FPH"].Value.ToString();
                txtMobile.Text = row.Cells["CL_MOB"].Value.ToString();
                txtFax.Text = row.Cells["CL_FAX"].Value.ToString();
                txtEmail1.Text = row.Cells["CL_EMAIL1"].Value.ToString();
                txtEmail2.Text = row.Cells["CL_EMAIL2"].Value.ToString();
                txtPrepBy1.Text = row.Cells["CL_PREP1"].Value.ToString();
                txtPrepBy2.Text = row.Cells["CL_PREP2"].Value.ToString();
                richAreaNotes.Text = row.Cells["CL_NOTES"].Value.ToString();

            }
        }



        private void cmdReset_Click(object sender, EventArgs e)     // Clear the TextBox
        {
            clearTextbox();
            txtFind.Clear();
            fillgird();
            txtFind.Enabled = true;
            LoadDatatoTextBox();
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)       // Find the Name Character
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            con.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * from Cd_MsCln where CL_NAME like '%" + txtFind.Text.Replace("'", "''") + "%'", con);
            dataAdapter.Fill(ds, "Cd_MsCln");
            grdViewParty.DataMember = "Cd_MsCln";
            grdViewParty.DataSource = ds;
           // grdViewParty.Focus();
            con.Close();
            LoadDatatoTextBox();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)     // Cursor go to the Next TextBox After Pressing Enter
        {
            Control ctrl;
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                //    if (e.KeyCode == Keys.Enter)
                    {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, false, false, false);
                }
                else
                    return;

            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.SelectNextControl(ctrl, false, false, false, false);
                }
                else
                    return;
            }

        }

        private void grdViewParty_DoubleClick(object sender, EventArgs e) 
        {
            isAddEdit = "B";
            txtCodeno.Focus();
 
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = false;
            }
            txtFind.Enabled = true;
            cmdReset.Enabled = true;
        }

        private void pictFrmClose_Click(object sender, EventArgs e) // Close Button
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormParty();
                this.Hide();
                fillgird();
                LoadDatatoTextBox();
                txtFind.Clear();
                txtFind.Focus();
            }
        }

        private void cmdReset_EnabledChanged(object sender, EventArgs e)
        {
            cmdReset.ForeColor = cmdReset.Enabled ? Color.White : Color.White;
        }

        private void grdViewParty_KeyDown(object sender, KeyEventArgs e)
        {

           if (grdViewParty.CurrentRow.Index < grdViewParty.RowCount - 1)
           //     if (grdViewParty.RowCount > 0)
                {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    if (grdViewParty.RowCount > 0)    // No Crashing problem when there is no data in gridview
                    {
                        int i = grdViewParty.CurrentRow.Index + 1;
                        DataGridViewRow row = this.grdViewParty.Rows[i];
                        txtRefParty.Text = row.Cells["CL_REFNO"].Value.ToString();
                        txtYr.Text = row.Cells["CL_YEARS"].Value.ToString();
                        txtRs.Text = row.Cells["CL_RSIN"].Value.ToString();
                        txtCodeno.Text = row.Cells["CL_CODENO"].Value.ToString();
                        txtActivity.Text = row.Cells["CL_ACT"].Value.ToString();
                        txtBranch.Text = row.Cells["CL_BRANCH"].Value.ToString();
                        txtName.Text = row.Cells["CL_NAME"].Value.ToString();
                        txtAdd1.Text = row.Cells["CL_ADD1"].Value.ToString();
                        txtAdd2.Text = row.Cells["CL_ADD2"].Value.ToString();
                        txtAdd3.Text = row.Cells["CL_ADD3"].Value.ToString();
                        txtCity.Text = row.Cells["CL_CITY"].Value.ToString();
                        txtState.Text = row.Cells["CL_STATE"].Value.ToString();
                        txtPhone.Text = row.Cells["CL_FPH"].Value.ToString();
                        txtMobile.Text = row.Cells["CL_MOB"].Value.ToString();
                        txtFax.Text = row.Cells["CL_FAX"].Value.ToString();
                        txtEmail1.Text = row.Cells["CL_EMAIL1"].Value.ToString();
                        txtEmail2.Text = row.Cells["CL_EMAIL2"].Value.ToString();
                        txtPrepBy1.Text = row.Cells["CL_PREP1"].Value.ToString();
                        txtPrepBy2.Text = row.Cells["CL_PREP2"].Value.ToString();
                        richAreaNotes.Text = row.Cells["CL_NOTES"].Value.ToString();
                    }
                }
            }
        }

        private void grdViewParty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
