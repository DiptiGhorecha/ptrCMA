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



namespace PtrCma
{

    public partial class FrmCMAParty : Form
    {
        string gp = "";
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\PtrCma.accdb;";
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        int rowNum;
        public FrmCMAParty()
        {

            InitializeComponent();


        }

        private void LoadDatatoTextBox()
        {
            // int i = grdViewParty.CurrentRow.Index;

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

        }

        private void LoadCurrentDatatoTextBox(int rowNum)
        {
            // int i = grdViewParty.CurrentRow.Index;

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
            grdViewParty.Columns[0].Visible = false;

            grdViewParty.Columns[1].Visible = true;
            grdViewParty.Columns[1].HeaderText = "Party Code";
            grdViewParty.Columns[1].Width = 100;

            grdViewParty.Columns[2].Visible = false;
            grdViewParty.Columns[3].Visible = false;

            grdViewParty.Columns[4].Visible = true;
            grdViewParty.Columns[4].HeaderText = "Party Name";
            grdViewParty.Columns[4].Width = 150;

            grdViewParty.Columns[5].Visible = false;
            grdViewParty.Columns[6].Visible = false;
            grdViewParty.Columns[7].Visible = false;
            grdViewParty.Columns[8].Visible = false;
            grdViewParty.Columns[9].Visible = false;
            grdViewParty.Columns[10].Visible = false;
            grdViewParty.Columns[11].Visible = false;
            grdViewParty.Columns[12].Visible = false;
            grdViewParty.Columns[13].Visible = false;
            grdViewParty.Columns[14].Visible = false;
            grdViewParty.Columns[15].Visible = false;
            grdViewParty.Columns[16].Visible = false;
            grdViewParty.Columns[17].Visible = false;

        }

       
        private void FrmCMAParty_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            this.BackColor = Global.backColorPartyMst;   //Set the Background Color
            this.Width = grdViewParty.Width + txtareanotes.Width + 190;

            fillgird();
            grdViewParty.CurrentCell = grdViewParty.Rows[0].Cells[1];

            controlsize();  //Button and TextBox Resize
            navigatecolor();  //Label and Textbox BackColor/Forecolor
            LoadDatatoTextBox();  //Data show in Textbox from Gridview
            controlvisible();   //Visible Button and Textbox
            
            controlenable();    //Enable Button and Textbox
            

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


       
        private void navigatecolor()
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = false;
                txtFind.Enabled = true;
            }

            foreach (Label lbl in Controls.OfType<Label>()) //Set the Label Color
            {
                lbl.BackColor = Global.lblColorPartyMst;
                lbl.ForeColor = Global.lblForeColorPartyMst;
            }

            foreach (TextBox txt in Controls.OfType<TextBox>())   //Set the TextBox Color
            {
                txt.BackColor = Global.txtColorPartyMst;
            }

            lblparty.BackColor = Global.lblparty;
            lblparty.ForeColor = Global.lbltitle;
        }

        private void controlsize()
        {
            foreach (Label lbl in Controls.OfType<Label>())
            {
                lbl.Size = new System.Drawing.Size(65, 20);
                lbl.AutoSize = false;
            }
            lblfind.Size = new System.Drawing.Size(40, 20);
            lblparty.Size = new System.Drawing.Size(720, 30);

            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Size = new System.Drawing.Size(320, 20);
            }
            txtFind.Size = new System.Drawing.Size(200, 20);
            txtCodeno.Size = new System.Drawing.Size(100, 20);
            txtBranch.Size = new System.Drawing.Size(100, 20);
            txtareanotes.Size = new System.Drawing.Size(390, 70);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {

            cmdSave.Visible = true;
            cmdCancel.Visible = true;
            grdViewParty.Enabled = false;
            txtFind.Enabled = false;
            cmdReset.Enabled = false;

            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = true;
                txt.Clear();
            }
            
            txtCodeno.Focus();
            cmdAdd.Visible = false;
            cmdEdit.Visible = false;
            cmdDelete.Visible = false;
            cmdSelect.Visible = false;
            cmdExit.Visible = false;
            
            gp = "A";
            
        }
        
        private void btninsert()
        {
            if (gp == "A")
            {
                txtCodeno.Focus();
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = connectionString;
                con.Open();

                String sql = "insert into Cd_MsCln(CL_CODENO,CL_ACT,CL_BRANCH,CL_NAME,CL_ADD1,CL_ADD2,CL_ADD3,CL_CITY,CL_STATE,CL_FPH,CL_MOB,CL_FAX,CL_EMAIL1,CL_EMAIL2,CL_NOTES,CL_PREP1,CL_PREP2) values ('" + this.txtCodeno.Text + "','" + this.txtActivity.Text + "','" + this.txtBranch.Text + "','" + this.txtName.Text + "','" + this.txtAdd1.Text + "','" + this.txtAdd2.Text + "','" + this.txtAdd3.Text + "','" + this.txtCity.Text + "','" + this.txtState.Text + "','" + this.txtPhone.Text + "','" + this.txtMobile.Text + "','" + this.txtFax.Text + "','" + this.txtEmail1.Text + "','" + this.txtEmail2.Text + "','" + this.txtareanotes.Text + "','" + this.txtPrepBy1.Text + "','" + this.txtPrepBy2.Text + "') ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                fillgird();
                rowNum = grdViewParty.RowCount;
                grdViewParty.CurrentCell = grdViewParty.Rows[rowNum - 1].Cells[1];
                MessageBox.Show("Data Inserted Successfully");
            }

            else

            {
              
                rowNum = grdViewParty.CurrentRow.Index;
              
                txtCodeno.Focus();
                con.ConnectionString = connectionString;
                con.Open();

                String sql1 = "Update Cd_MsCln set [CL_ACT]='" + this.txtActivity.Text + "' , [CL_BRANCH] ='" + this.txtBranch.Text + "', [CL_NAME] ='" + this.txtName.Text + "',[CL_ADD1]='" + this.txtAdd1.Text + "', [CL_ADD2]='" + this.txtAdd2.Text + "', [CL_ADD3]='" + this.txtAdd3.Text + "', [CL_CITY]='" + this.txtCity.Text + "', [CL_STATE]='" + this.txtState.Text + "', [CL_FPH]='" + this.txtPhone.Text + "', [CL_MOB]='" + this.txtMobile.Text + "', [CL_FAX]='" + this.txtFax.Text + "', [CL_EMAIL1]='" + this.txtEmail1.Text + "', [CL_EMAIL2]='" + this.txtEmail2.Text + "', [CL_NOTES]='" + this.txtareanotes.Text + "', [CL_PREP1]='" + this.txtPrepBy1.Text + "', [CL_PREP2]='" + this.txtPrepBy2.Text + "'  WHERE CL_CODENO= '" + this.txtCodeno.Text + "' ";
                OleDbCommand cmd1 = new OleDbCommand(sql1, con);
                cmd1.ExecuteNonQuery();
                con.Close();

                //Dialog Box for yes or no
                DialogResult dialogResult1 = MessageBox.Show("Do You want to Update this Record?", "", MessageBoxButtons.YesNo);       //Cancel Button
                if (dialogResult1 == DialogResult.Yes)
                {
                    fillgird();  //After inserting data display data in Gridview
                    grdViewParty.CurrentCell = grdViewParty.Rows[rowNum].Cells[1];

                    MessageBox.Show("Record Updated Successfully");

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


                    //foreach (TextBox t2 in Controls.OfType<TextBox>())   //Disable Textbox
                    //{
                    //    t2.Clear();

                    //}

                }

            }


        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            grdViewParty.Enabled = true;
            //Validations 
            if (txtCodeno.Text.Trim() == string.Empty)              //Code No  
            {
                MessageBox.Show("Code Number Field cannnot be blank");
                txtCodeno.Focus();
                return; // return because we don't want to run normal code of buton click
            }


            if (txtName.Text.Trim() == string.Empty)              //Name
            {
                MessageBox.Show("Name Field cannnot be blank");
                txtName.Focus();
                return; // return because we don't want to run normal code of buton click
            }

            btninsert();


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

            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Cancel?", "", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                cmdAdd.Visible = true;
                cmdEdit.Visible = true;
                cmdDelete.Visible = true;
                cmdSelect.Visible = true;
                cmdExit.Visible = true;
                cmdSave.Visible = false;
                cmdCancel.Visible = false;
                cmdEdit.Enabled = true;
                cmdDelete.Enabled = true;
                cmdReset.Enabled = true;
                txtFind.Enabled = true;

                foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
                {
                    txt.Clear();
                }
            }
            else
            {
                foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
                {
                    txt.Enabled = true;
                }
            }
            LoadDatatoTextBox();

        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            grdViewParty.Enabled = false;
           gp = "B";
                txtCodeno.Focus();
            
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {

                txt.Enabled = true;


            }

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
            grdViewParty.Enabled = false;
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = connectionString;
            con.Open();

            String sql = "delete from Cd_MsCln where CL_CODENO='" + this.txtCodeno.Text + "' ";
            cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            DialogResult dialogResult1 = MessageBox.Show("Are you sure want to delete this Record ?", "", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult1 == DialogResult.Yes)
            {
                fillgird();  //After inserting data display data in Gridview
                MessageBox.Show("Record Successfully Deleted ");

                cmdDelete.Enabled = true;
                cmdEdit.Enabled = true;
                grdViewParty.Enabled = true;

                foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
                {
                    txt.Clear();

                }

            }
            cmdReset.Enabled = true;
            txtFind.Enabled = true;
            txtFind.Focus();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {


        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                FrmMDICma c = new FrmMDICma();
                c.Show();
            }

        }

        private void grdViewParty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cmdEdit.Enabled = true;
            //cmdDelete.Enabled = true;
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Enabled = false;
                txtFind.Enabled = true;
            }

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
            txtFind.Clear();
            fillgird();
            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {
                txt.Clear();
                txtFind.Enabled = true;

            }
            //cmdEdit.Enabled = false;
            //cmdDelete.Enabled = false;
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();


            con.Open();

            da = new OleDbDataAdapter("SELECT * from Cd_MsCln where CL_NAME like '" + txtFind.Text + "%'", con);

            da.Fill(ds, "Cd_MsCln");
            //grdViewParty.DataSource = ds.Tables("Cd_MsCln");
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
            gp = "B";
                txtCodeno.Focus();
           



            foreach (TextBox txt in Controls.OfType<TextBox>())   //Disable Textbox
            {

                txt.Enabled = false;


            }

            txtFind.Enabled = true;
            
        }
    }
}
