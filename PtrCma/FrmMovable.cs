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
    public partial class FrmMovable : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormMovable;
        string isAddEdit = ""; //Variable to Store Current Action(Add,Edit)
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        public FrmMovable()
        {
            InitializeComponent();
        }

        private void FrmMovable_Load(object sender, EventArgs e)
        {
            cmdUpdate.Enabled = false;
            cmdCancel.Enabled = false;
            // cmdCancel.Enabled = false;
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = false;
                // txtName.Enabled = true;
            }
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            filltempTable();
            fillgrid();
            //FrmDetailDirector frmDirector = new FrmDetailDirector();
            //frmDirector.MdiParent = this;
            //frmDirector.StartPosition = FormStartPosition.CenterParent;
            //frmDirector.Show();

            if (grdViewSecurities.RowCount > 0)
            {
                grdViewSecurities.CurrentCell = grdViewSecurities.Rows[0].Cells[0];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }
            cmdAdd.Focus();
        }

        private void filltempTable()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                string sqlTrunc = "DELETE FROM Cp_Cd113";
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "INSERT INTO Cp_Cd113 SELECT * FROM Cx_Cd113 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds1, "Cp_Cd113");
                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cp_Cd113");
                ds1.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }

        private void fillgrid()
        {
            try
            {
                con = new OleDbConnection(connectionString);
                DataSet ds = new DataSet();
                dataAdapter = new OleDbDataAdapter("select * from Cp_Cd113 WHERE CL_REFNO=" + Global.prtyCode, con);
                dataAdapter.Fill(ds, "Cp_Cd113");
                grdViewSecurities.DataMember = "Cp_Cd113";
                grdViewSecurities.DataSource = ds;
                con.Close();

                //Show selected Column in Gridview
                for (int i = 0; i <= grdViewSecurities.Columns.Count - 1; i++)
                {
                    grdViewSecurities.Columns[i].ReadOnly = true;
                    grdViewSecurities.Columns[i].Visible = false;
                }

                grdViewSecurities.Columns[0].Visible = true;
                grdViewSecurities.Columns[0].HeaderText = "Description";
                grdViewSecurities.Columns[0].Width = 250;
            }
            catch (Exception e)
            {
                //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }

        private void LoadDatatoTextBox()
        {
            if (grdViewSecurities.RowCount > 0)    // No Crashing problem when there is no data in gridview
            {
                DataGridViewRow row = this.grdViewSecurities.Rows[0];
                txtRef.Text = row.Cells["CTX_REF"].Value.ToString();
                txtDes.Text = row.Cells["CTXT01"].Value.ToString();
                txtOwner.Text = row.Cells["CTXT02"].Value.ToString();
                txtFValue.Text = row.Cells["CTXT03"].Value.ToString();
                txtAcq.Text = row.Cells["CTXT04"].Value.ToString();
                txtPValue.Text = row.Cells["CTXT05"].Value.ToString();
            }
        }
        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;
            grdViewSecurities.RowsDefaultCellStyle.BackColor = Color.White;     // Row Color of Gridview

            // Column Header Color of Gridview
            grdViewSecurities.ColumnHeadersHeight = 30;
            grdViewSecurities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdViewSecurities.EnableHeadersVisualStyles = false;
            grdViewSecurities.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            grdViewSecurities.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;
            setControlColor();
            setControlSize();
        }

        private void setControlSize()
        {
            foreach (Button btn in Controls.OfType<Button>())   //Set Size of Button
            {
                btn.Size = Global.smallbtn;
                cmdDel.Size = Global.btnmedSize;
                cmdUpdate.Size = Global.btnmedSize;
            }

            foreach (Label lbl in Controls.OfType<Label>()) //Set Size of Label
            {
                lbl.Font = Global.lblSize;
                lbl.Size = Global.lblmedSize;
                lbl.AutoSize = false;
            }
            pictitle.Size = Global.titlelbl;

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
            grdViewSecurities.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            grdViewSecurities.DefaultCellStyle.SelectionForeColor = Color.Black;
        }


        private void cmdAdd_Click(object sender, EventArgs e)
        {

            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = true;
                txt.Clear();
            }
            txtDes.Focus();
            grdViewSecurities.Enabled = false;
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
            if (grdViewSecurities.Rows.Count > 0)
            {
                DialogResult dialogResult1 = MessageBox.Show(GlobalMsg.deleteMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
                if (dialogResult1 == DialogResult.Yes)
                {
                    con = new OleDbConnection(connectionString);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    String sql = "delete from Cp_Cd113 where CTX_REF=" + txtRef.Text;
                    cmd = new OleDbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(GlobalMsg.deleteMsg, "Perfect Tax Reporter - CMA 1.0");
                    foreach (TextBox txt in Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                    fillgrid();
                    LoadDatatoTextBox();
                }
            }
        }

        private void grdViewSecurities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // cmdCancel.Enabled = false;
            //  cmdDel.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdViewSecurities.Rows[e.RowIndex];
                txtRef.Text = row.Cells["CTX_REF"].Value.ToString();
                txtDes.Text = row.Cells["CTXT01"].Value.ToString();
                txtOwner.Text = row.Cells["CTXT02"].Value.ToString();
                txtFValue.Text = row.Cells["CTXT03"].Value.ToString();
                txtAcq.Text = row.Cells["CTXT04"].Value.ToString();
                txtPValue.Text = row.Cells["CTXT05"].Value.ToString();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormMovable();
                this.Hide();
            }
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormMovable();
                this.Hide();
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (txtDes.Text.Trim().Equals(""))
            {
                MessageBox.Show(GlobalMsg.nameMsg, "Perfect Tax Reporter - CMA 1.0");
                txtDes.Focus();
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
                sql = "insert into Cp_Cd113(CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CL_REFNO) values ('" + txtDes.Text + "','" + txtOwner.Text + "','" + txtFValue.Text + "','" + txtAcq.Text + "','" + txtPValue.Text + "'," + Global.prtyCode + ")";
            }
            else
            {
                sql = "update Cp_Cd113 set CTXT01='" + txtDes.Text + "',CTXT02='" + txtOwner.Text + "',CTXT03='" + txtFValue.Text + "',CTXT04='" + txtAcq.Text + "',CTXT05='" + txtPValue.Text + "' WHERE CTX_REF=" + txtRef.Text + " AND CL_REFNO=" + Global.prtyCode;
            }
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = false;

            }
            grdViewSecurities.Enabled = true;
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
            //  foreach (TextBox txt in Controls.OfType<TextBox>())
            //   {
            ////       txt.Clear();
            //   }

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
                grdViewSecurities.Enabled = true;
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
            txtDes.Focus();
            grdViewSecurities.Enabled = false;
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


    }
}
