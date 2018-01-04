using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PtrCma
{
    public partial class FrmDeatilAssociate : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormAssociate;
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        string isAddEdit = ""; //Variable to Store Current Action(Add,Edit)
        public FrmDeatilAssociate()
        {
            InitializeComponent();
        }


        private void FrmDeatilAssociate_Load(object sender, EventArgs e)
        {
            cmdUpdate.Enabled = false;
            cmdCancel.Enabled = false;
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = false;
               
            }
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            fillgrid();
            //FrmDeatilAssociate frmAssociate = new FrmDeatilAssociate();
            //frmAssociate.MdiParent = this;
            //frmAssociate.StartPosition = FormStartPosition.CenterScreen;
            //frmAssociate.Show();

            if (grdAssociate.RowCount > 0)
            {
                grdAssociate.CurrentCell = grdAssociate.Rows[0].Cells[0];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }
        }

        private void filltempTable()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                string sqlTrunc = "DELETE FROM Cp_Cd103";
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "INSERT INTO Cp_Cd103 SELECT * FROM Cx_Cd103 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds1, "Cp_Cd103");
                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cp_Cd103");
                ds1.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }

        private void LoadDatatoTextBox()
        {
            if (grdAssociate.RowCount > 0)    // No Crashing problem when there is no data in gridview
            {
                DataGridViewRow row = this.grdAssociate.Rows[0];
                txtRef.Text = row.Cells["CTX_REF"].Value.ToString();
                txtName.Text = row.Cells["CTXT01"].Value.ToString();
                txtProp.Text = row.Cells["CTXT02"].Value.ToString();
                txtBank.Text = row.Cells["CTXT03"].Value.ToString();
                txtLimit.Text = row.Cells["CTXT04"].Value.ToString();
                txtOutst.Text = row.Cells["CTXT05"].Value.ToString();
            }
        }

        private void fillgrid()
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            dataAdapter = new OleDbDataAdapter("select * from Cp_Cd103", con);
            dataAdapter.Fill(ds, "Cp_Cd103");
            grdAssociate.DataMember = "Cp_Cd103";
            grdAssociate.DataSource = ds;
            con.Close();

            //Show selected Column in Gridview
            for (int i = 0; i <= grdAssociate.Columns.Count - 1; i++)
            {
                grdAssociate.Columns[i].ReadOnly = true;
                grdAssociate.Columns[i].Visible = false;
            }

            grdAssociate.Columns[0].Visible = true;
            grdAssociate.Columns[0].HeaderText = "Associate Name";
            grdAssociate.Columns[0].Width = 260;
        }

        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;

            grdAssociate.RowsDefaultCellStyle.BackColor = Color.White;     // Row Color of Gridview

            // Column Header Color of Gridview
            grdAssociate.ColumnHeadersHeight = 30;
            grdAssociate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdAssociate.EnableHeadersVisualStyles = false;
            grdAssociate.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            grdAssociate.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;

            setControlColor();
            setControlSize();
        }

        private void setControlSize()
        {
            foreach (Button btn in Controls.OfType<Button>())   //Set Size of Button
            {
                btn.Size = Global.smallbtn;
            }

            foreach (Label lbl in Controls.OfType<Label>()) //Set Size of Label
            {
                lbl.Font = Global.lblSize;
                lbl.Size = Global.lblmedSize;
                lbl.AutoSize = false;
            }
            //pictitle.Size = Global.titlelbl;

            foreach (TextBox txt in Controls.OfType<TextBox>())  //Set Size of TextBox
            {
                txt.Font = Global.txtSize;
                txt.Size = Global.txtmedSize;
                txt.AutoSize = false;
            }
        }

        private void setControlColor()
        {
            foreach (Label lbl in Controls.OfType<Label>())     //Set Label Color
            {
                lbl.BackColor = Global.lblbackdetail;
                lbl.ForeColor = Global.lblforedetail;
            }

            foreach (Button btn in Controls.OfType<Button>())       // Set Button Color
            {
                btn.ForeColor = Global.btnfore;
                btn.BackgroundImage = Global.cmdImg;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }

            //  Set the Gridview Color
            grdAssociate.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            grdAssociate.DefaultCellStyle.SelectionForeColor = Color.Black;
        }


        private void cmdAdd1_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = true;
            }
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = connectionString;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "insert into Cx_Cd103(CD_UNIT,CD_PROP,CD_BANK,CD_LIMIT,CD_OUTST)values('" + txtName.Text + "','" + txtProp.Text + "','" + txtBank.Text + "','" + txtLimit.Text + "','" + txtOutst.Text + "')";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            fillgrid();
            MessageBox.Show(GlobalMsg.insertMsg, "Perfect Tax Reporter - CMA 1.0");
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Clear();
            }

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {

            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = true;
                txt.Clear();
            }
            txtName.Focus();
            grdAssociate.Enabled = false;
            cmdAdd.Enabled = false;
            cmdEdit.Enabled = false;
            cmdDel.Enabled = false;
            cmdExit.Enabled = false;
            cmdUpdate.Enabled = true;
            cmdCancel.Enabled = true;
            isAddEdit = "A";
            lblData.Visible = true;
            lblData.Text = "ADD";
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show(GlobalMsg.deleteMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult1 == DialogResult.Yes)
            {
                con = new OleDbConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                String sql = "delete from Cp_Cd103 where CTX_REF=" + txtRef.Text;
                cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                fillgrid();
                MessageBox.Show(GlobalMsg.deleteMsg, "Perfect Tax Reporter - CMA 1.0");
            }
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormAssociate();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormAssociate();
                this.Hide();
                }
        }

        private void grdAssociate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdAssociate.Rows[e.RowIndex];
                txtRef.Text = row.Cells["CTX_REF"].Value.ToString();
                txtName.Text = row.Cells["CTXT01"].Value.ToString();
                txtProp.Text = row.Cells["CTXT02"].Value.ToString();
                txtBank.Text = row.Cells["CTXT03"].Value.ToString();
                txtLimit.Text = row.Cells["CTXT04"].Value.ToString();
                txtOutst.Text = row.Cells["CTXT05"].Value.ToString();
            }

        }


        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show(GlobalMsg.nameMsg, "Perfect Tax Reporter - CMA 1.0");
                txtName.Focus();
                return; // return because we don't want to run normal code of buton click

            }
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = connectionString;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "";
            if (isAddEdit == "A")
            {
                sql = "insert into Cp_Cd103(CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CL_REFNO) values ('" + txtName.Text + "','" + txtProp.Text + "','" + txtBank.Text + "','" + txtLimit.Text + "','" + txtOutst.Text + "'," + Global.prtyCode + ")";
            }
            else
            {
                sql = "update Cp_Cd103 set CTXT01='" + txtName.Text + "',CTXT02='" + txtProp.Text + "',CTXT03='" + txtBank.Text + "',CTXT04='" + txtLimit.Text + "',CTXT05='" + txtOutst.Text + "' WHERE CTX_REF=" + txtRef.Text + " AND CL_REFNO=" + Global.prtyCode;
            }
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = false;

            }
            grdAssociate.Enabled = true;
            cmdAdd.Enabled = true;
            cmdEdit.Enabled = true;
            cmdDel.Enabled = true;
            cmdExit.Enabled = true;
            cmdUpdate.Enabled = false;
            cmdCancel.Enabled = false;
            lblData.Text = "";
            lblData.Visible = false;
            fillgrid();
            LoadDatatoTextBox();
            MessageBox.Show(GlobalMsg.insertMsg, "Perfect Tax Reporter - CMA 1.0");
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.cancelMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                foreach (TextBox txt in Controls.OfType<TextBox>())
                {
                    txt.Enabled = false;

                }
                grdAssociate.Enabled = true;
                cmdAdd.Enabled = true;
                cmdEdit.Enabled = true;
                cmdDel.Enabled = true;
                cmdExit.Enabled = true;
                cmdUpdate.Enabled = false;
                cmdCancel.Enabled = false;
                lblData.Text = "";
                lblData.Visible = false;
                fillgrid();
                LoadDatatoTextBox();
            }
            else
            {

            }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = true;
            }
            txtName.Focus();
            grdAssociate.Enabled = false;
            cmdAdd.Enabled = false;
            cmdEdit.Enabled = false;
            cmdDel.Enabled = false;
            cmdExit.Enabled = false;
            cmdUpdate.Enabled = true;
            cmdCancel.Enabled = true;
            isAddEdit = "E";
            lblData.Visible = true;
            lblData.Text = "EDIT";
        }


        private void pictitle_Click(object sender, EventArgs e)
        {

        }
    }
}
