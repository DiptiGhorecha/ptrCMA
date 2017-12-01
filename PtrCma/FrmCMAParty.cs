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

namespace PtrCma
{

    public partial class FrmCMAParty : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToOpenChildFormCma;
        string isAddEdit = ""; //Variable to Store Current Action(Add,Edit)
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " +Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        //Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\PtrCma.accdb"); 
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        OleDbTransaction transaction;
        int rowNum;  // Variable to Store Current Row Number


        public FrmCMAParty()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
           // this.BackColor = Color.PaleTurquoise;
           // this.TransparencyKey = Color.PaleTurquoise; // I had to add this to get it to work.
        }

        private void FrmCMAParty_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            this.KeyPreview = true; //To handle enter key
           
            Settings();  //set size and color of controls
            controlvisible();   // Visible Button and Textbox
            controlenable();    //Enable Button and Textbox
            clearTextbox();     //Clear the Textbox
            enableTextbox();    //Enable Textbox
            fillgird();         //Show Data in Gridview at Runtime
            if (grdViewParty.RowCount>0) {
                grdViewParty.CurrentCell = grdViewParty.Rows[0].Cells[1];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }else
            {
                cmdDelete.Visible = false;
                cmdEdit.Visible = false;
            }


        }


        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;
            setControlcolor(); //Label and Textbox BackColor/Forecolor
            setControlsize(); //Label and TextBox Resize
                              // this.BackColor = Global.backColorPartyMst;   //Set Background Color of the form
  
            grdViewParty.Size = Global.grdPartySize;
            this.Width = grdViewParty.Width + txtareanotes.Width + 155;
            grdViewParty.RowsDefaultCellStyle.BackColor = Color.LightGray;
            grdViewParty.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;
           
            grdViewParty.ColumnHeadersHeight = 30;
            grdViewParty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdViewParty.EnableHeadersVisualStyles = false;

            //this.picFrmClose. = 5;
        }


        private void controlvisible()
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


        private void controlenable()
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


        private void clearTextbox()
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Clear();
            }
        }


        private void enableTextbox()
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = true;
            }
        }


        private void fillgird()   //For Fill DataGridView
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
            grdViewParty.Columns[4].Width = 198;

        }


        private void LoadDatatoTextBox()
        {
            if (grdViewParty.RowCount>0) {
            DataGridViewRow row = this.grdViewParty.Rows[0];
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
            txtareanotes.Text = row.Cells["CL_NOTES"].Value.ToString();
            }else
            {
                cmdDelete.Visible = false;
                cmdEdit.Visible = false;
            }

        }

        private void LoadCurrentDatatoTextBox(int rowNum)
        {
            DataGridViewRow row = this.grdViewParty.Rows[rowNum];
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
            txtareanotes.Text = row.Cells["CL_NOTES"].Value.ToString();
        }
        

        private void setControlcolor()      //Set Color in Control
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = false;
                txtFind.Enabled = true;
                txt.BackColor = Global.txtColorPartyMst;
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
            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.ForeColor = Global.btnfore;
                btn.BackgroundImage = Global.cmdImg;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
           
            
        }

        //public enum RoundedCorners
        //{
        //    None = 0x00,
        //    TopLeft = 0x02,
        //    TopRight = 0x04,
        //    BottomLeft = 0x08,
        //    BottomRight = 0x10,
        //    All = 0x1F
        //}
        //public static void DrawRoundedRectangle(this Graphics g, Color color, Rectangle rec, int radius,
        //                                   RoundedCorners corners)
        //{
        //    using (var b = new SolidBrush(color))
        //    {
        //        int x = rec.X;
        //        int y = rec.Y;
        //        int diameter = radius * 2;
        //        var horiz = new Rectangle(x, y + radius, rec.Width, rec.Height - diameter);
        //        var vert = new Rectangle(x + radius, y, rec.Width - diameter, rec.Height);

        //        g.FillRectangle(b, horiz);
        //        g.FillRectangle(b, vert);

        //        if ((corners & RoundedCorners.TopLeft) == RoundedCorners.TopLeft)
        //            g.FillEllipse(b, x, y, diameter, diameter);
        //        else
        //            g.FillRectangle(b, x, y, diameter, diameter);

        //        if ((corners & RoundedCorners.TopRight) == RoundedCorners.TopRight)
        //            g.FillEllipse(b, x + rec.Width - (diameter + 1), y, diameter, diameter);
        //        else
        //            g.FillRectangle(b, x + rec.Width - (diameter + 1), y, diameter, diameter);

        //        if ((corners & RoundedCorners.BottomLeft) == RoundedCorners.BottomLeft)
        //            g.FillEllipse(b, x, y + rec.Height - (diameter + 1), diameter, diameter);
        //        else
        //            g.FillRectangle(b, x, y + rec.Height - (diameter + 1), diameter, diameter);

        //        if ((corners & RoundedCorners.BottomRight) == RoundedCorners.BottomRight)
        //            g.FillEllipse(b, x + rec.Width - (diameter + 1), y + rec.Height - (diameter + 1), diameter, diameter);
        //        else
        //            g.FillRectangle(b, x + rec.Width - (diameter + 1), y + rec.Height - (diameter + 1), diameter,
        //                            diameter);
        //    }
        //}


        private void setControlsize()           //Set Size of Control
        {
            foreach (Label lbl in Controls.OfType<Label>())
            {
                lbl.Size = Global.medsizelbl;
                lbl.AutoSize = false;
            }
            lblfind.Size = Global.smallsizelbl;
            lblparty.Size = Global.largesizelbl;

            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Size = Global.txtCommonSize;
            }
            txtFind.Size = Global.txtFindSize;
            txtCodeno.Size = Global.txtCodenoSize;
            txtBranch.Size = Global.txtBranchSize;
            txtareanotes.Size = Global.txtNotesSize;

            //button size
            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.Size = Global.btnSmallSize;
            }
            cmdReset.Size = Global.smallBtn;
            cmdCancel.Size = Global.btnmedSize;
            cmdDelete.Size = Global.btnmedSize;
            cmdSelect.Size = Global.btnLargeSize;

        }

        private void cmdAdd_Click(object sender, EventArgs e)       
        {

            //fillgird();
            cmdSave.Visible = true;
            cmdCancel.Visible = true;
            grdViewParty.Enabled = false;
            cmdReset.Enabled = false;
            clearTextbox();
            enableTextbox();
            txtFind.Enabled = false;
            cmdAdd.Visible = false;
            cmdEdit.Visible = false;
            cmdDelete.Visible = false;
            cmdSelect.Visible = false;
            cmdExit.Visible = false;
            txtCodeno.Focus();
            isAddEdit = "A";
        }
        
        private void btnInsert()            //Perform Insert/Update After Clicking
        {
            try
            {
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
                String sql = "insert into Cd_MsCln(CL_CODENO,CL_ACT,CL_BRANCH,CL_NAME,CL_ADD1,CL_ADD2,CL_ADD3,CL_CITY,CL_STATE,CL_FPH,CL_MOB,CL_FAX,CL_EMAIL1,CL_EMAIL2,CL_NOTES,CL_PREP1,CL_PREP2) values ('" + this.txtCodeno.Text + "','" + this.txtActivity.Text + "','" + this.txtBranch.Text + "','" + this.txtName.Text + "','" + this.txtAdd1.Text + "','" + this.txtAdd2.Text + "','" + this.txtAdd3.Text + "','" + this.txtCity.Text + "','" + this.txtState.Text + "','" + this.txtPhone.Text + "','" + this.txtMobile.Text + "','" + this.txtFax.Text + "','" + this.txtEmail1.Text + "','" + this.txtEmail2.Text + "','" + this.txtareanotes.Text + "','" + this.txtPrepBy1.Text + "','" + this.txtPrepBy2.Text + "') ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
                fillgird();           
                MessageBox.Show("Data Inserted Successfully", "Perfect Tax Reporter - CMA 1.0");
            }

            else

            {  //edit button click
              
                rowNum = grdViewParty.CurrentRow.Index;
            
                txtBranch.Focus();

                //Dialog Box for yes or no
                DialogResult dialogResult1 = MessageBox.Show("Do You want to Update this Record?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
                if (dialogResult1 == DialogResult.Yes)
                {
                        String sql1 = "Update Cd_MsCln set [CL_ACT]='" + this.txtActivity.Text + "' , [CL_BRANCH] ='" + this.txtBranch.Text + "', [CL_NAME] ='" + this.txtName.Text + "',[CL_ADD1]='" + this.txtAdd1.Text + "', [CL_ADD2]='" + this.txtAdd2.Text + "', [CL_ADD3]='" + this.txtAdd3.Text + "', [CL_CITY]='" + this.txtCity.Text + "', [CL_STATE]='" + this.txtState.Text + "', [CL_FPH]='" + this.txtPhone.Text + "', [CL_MOB]='" + this.txtMobile.Text + "', [CL_FAX]='" + this.txtFax.Text + "', [CL_EMAIL1]='" + this.txtEmail1.Text + "', [CL_EMAIL2]='" + this.txtEmail2.Text + "', [CL_NOTES]='" + this.txtareanotes.Text + "', [CL_PREP1]='" + this.txtPrepBy1.Text + "', [CL_PREP2]='" + this.txtPrepBy2.Text + "'  WHERE CL_CODENO= '" + this.txtCodeno.Text + "' ";
                        OleDbCommand cmd1 = new OleDbCommand(sql1, con);
                        cmd1.Transaction = transaction;
                        cmd1.ExecuteNonQuery();
                        transaction.Commit();
                        con.Close();
                        fillgird();  //After updating data display it in Gridview
                    grdViewParty.CurrentCell = grdViewParty.Rows[rowNum].Cells[1];

                    MessageBox.Show("Record Updated Successfully", "Perfect Tax Reporter - CMA 1.0");

                    txtCodeno.Focus();
                    cmdEdit.Enabled = false;
                    cmdDelete.Enabled = false;

                    cmdAdd.Visible = true;
                    cmdEdit.Visible = true;
                    cmdDelete.Visible = true;
                    cmdSelect.Visible = true;
                    cmdExit.Visible = true;
                    cmdSave.Visible = false;
                    cmdCancel.Visible = false;
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
            txtFind.Enabled = false;
            grdViewParty.Enabled = true;
            //Validations 
            if (txtCodeno.Text.Trim() == string.Empty)              //Code No  
            {
                MessageBox.Show("Code Number Field cannnot be blank","Perfect Tax Reporter - CMA 1.0");
               // MyMessageBox.ShowBox("Code Number Field cannnot be blank");
                txtCodeno.Focus();
                return; // return because we don't want to run normal code of buton click
            }


            if (txtName.Text.Trim() == string.Empty)              //Name
            {
                MessageBox.Show("Name Field cannnot be blank","Perfect Tax Reporter - CMA 1.0");
                //MyMessageBox.ShowBox("Name Field cannnot be blank", "Perfect Tax Reporter - CMA 1.0");
                txtName.Focus();
                return; // return because we don't want to run normal code of buton click
            }

            if (isAddEdit == "A")  //Add button click
            {
                for (int nCounter = 0; nCounter <= grdViewParty.RowCount - 1; nCounter++)
                {
                    if (txtCodeno.Text == grdViewParty[1, nCounter].Value.ToString())
                    {
                        MessageBox.Show("Duplicate code is not allowed.", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodeno.Focus();
                        return;
                    }

                }

            }
            btnInsert();  //insert-update data in database


            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = false;
            }
            controlvisible();
            cmdSave.Visible = false;
            cmdCancel.Visible = false;

            controlenable();
            txtFind.Focus();

        }


        private void cmdCancel_Click(object sender, EventArgs e)
        {
            txtFind.Enabled = true;
            cmdReset.Enabled = true;

            grdViewParty.Enabled = true;
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = false;
            }

            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Cancel?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                controlvisible();
                cmdSave.Visible = false;
                cmdCancel.Visible = false;
                cmdEdit.Enabled = true;
                cmdDelete.Enabled = true;
                cmdReset.Enabled = true;
                txtFind.Enabled = true;

                clearTextbox(); 
            }

            else
            {
                enableTextbox();
            }

            LoadDatatoTextBox();

        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
           
            grdViewParty.Enabled = false;
            isAddEdit = "B";
            txtBranch.Focus();
        
            enableTextbox();
            txtCodeno.Enabled = false;

            txtFind.Enabled = true;
            txtCodeno.Focus();
            cmdSave.Visible = true;
            cmdCancel.Visible = true;
            cmdAdd.Visible = false;
            cmdEdit.Visible = false;
            cmdDelete.Visible = false;
            cmdSelect.Visible = false;
            cmdExit.Visible = false;
            cmdReset.Enabled = false;
            txtFind.Enabled = false;
            

        }



        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult1 = MessageBox.Show("Are you sure want to delete this Record ?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
                if (dialogResult1 == DialogResult.Yes)
                {
                    grdViewParty.Enabled = false;
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = connectionString;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);

                    String sql = "delete from Cd_MsCln where CL_CODENO='" + this.txtCodeno.Text + "' ";
                    cmd = new OleDbCommand(sql, con);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    con.Close();
                    fillgird();  //After inserting data display data in Gridview
                    MessageBox.Show("Record Successfully Deleted ", "Perfect Tax Reporter - CMA 1.0");

                    cmdDelete.Enabled = true;
                    cmdEdit.Enabled = true;
                    grdViewParty.Enabled = true;

                    clearTextbox();

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
            LoadDatatoTextBox();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            if (NotifyMainFormToOpenChildFormCma != null)
            {
                NotifyMainFormToOpenChildFormCma();
            }

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormParty();
                this.Hide();
               // FrmMainCma frmCma = new FrmMainCma();
                //frmCma.Activate();
            }
           

        }

        private void grdViewParty_CellClick(object sender, DataGridViewCellEventArgs e)
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
                txtareanotes.Text = row.Cells["CL_NOTES"].Value.ToString();

            }
        }



        private void cmdReset_Click(object sender, EventArgs e)
        {
            clearTextbox();
            txtFind.Clear();
            fillgird();
            txtFind.Enabled = true;
            LoadDatatoTextBox();
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();


            con.Open();

            dataAdapter = new OleDbDataAdapter("SELECT * from Cd_MsCln where CL_NAME like '%" + txtFind.Text + "%'", con);

            dataAdapter.Fill(ds, "Cd_MsCln");
            grdViewParty.DataMember = "Cd_MsCln";
            grdViewParty.DataSource = ds;
            con.Close();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            Control ctrl;
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
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

        private void pictFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormParty();
                this.Hide();
              
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdReset_EnabledChanged(object sender, EventArgs e)
        {
            cmdReset.ForeColor = cmdReset.Enabled ? Color.White : Color.White;
        }

    }
}
