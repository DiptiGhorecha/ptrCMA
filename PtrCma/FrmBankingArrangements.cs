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
    public partial class FrmBankingArrangements : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormBanking;
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        string isAddEdit = ""; //Variable to Store Current Action(Add,Edit)
        public FrmBankingArrangements()
        {
            InitializeComponent();
        }

        private void FrmBankingArrangements_Load(object sender, EventArgs e)
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

            if (grdBanking.RowCount > 0)
            {
                grdBanking.CurrentCell = grdBanking.Rows[0].Cells[0];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }
        }


        private void filltempTable()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                string sqlTrunc = "DELETE FROM Cp_Cd102";
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "INSERT INTO Cp_Cd102 SELECT * FROM Cx_Cd102 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds1, "Cp_Cd102");
                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cp_Cd102");
                ds1.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }


        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;

            grdBanking.RowsDefaultCellStyle.BackColor = Color.White;     // Row Color of Gridview

            // Column Header Color of Gridview
            grdBanking.ColumnHeadersHeight = 30;
            grdBanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdBanking.EnableHeadersVisualStyles = false;
            grdBanking.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            grdBanking.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;
            
            setControlColor();
            setControlSize();

           
        }

        private void LoadDatatoTextBox()
        {
            if (grdBanking.RowCount > 0)    // No Crashing problem when there is no data in gridview
            {
                DataGridViewRow row = this.grdBanking.Rows[0];
                txtRef.Text = row.Cells["CTX_REF"].Value.ToString();
                txtBank.Text = row.Cells["CTXT01"].Value.ToString();
                txtFacility.Text = row.Cells["CTXT02"].Value.ToString();
                txtLimit.Text = row.Cells["CTXT03"].Value.ToString();
                txtOutstanding.Text = row.Cells["CTXT04"].Value.ToString();
                txtSince.Text = row.Cells["CTXT05"].Value.ToString();
            }
        }

        private void fillgrid()
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            dataAdapter = new OleDbDataAdapter("select * from Cp_Cd102 WHERE CL_REFNO=" + Global.prtyCode, con);
            dataAdapter.Fill(ds, "Cp_Cd102");
            grdBanking.DataMember = "Cp_Cd102";
            grdBanking.DataSource = ds;
            con.Close();

            //Show selected Column in Gridview
            for (int i = 0; i <= grdBanking.Columns.Count - 1; i++)
            {
                grdBanking.Columns[i].ReadOnly = true;
                grdBanking.Columns[i].Visible = false;
            }

            grdBanking.Columns[0].Visible = true;
            grdBanking.Columns[0].HeaderText = "Bank Name";
            grdBanking.Columns[0].Width = 270;
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
            grdBanking.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            grdBanking.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

      

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormBanking();
                this.Hide();
            }
        }

        private void cmdAdd1_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = true;
            }
            con = new OleDbConnection(connectionString);
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "insert into Cx_Cd102(CD_NAME,CD_FACILITY,CD_LIMIT,CD_OUTST,CD_SINCE) VALUES ('"+ txtBank.Text +"','"+ txtFacility.Text +"','"+ txtLimit.Text +"','"+ txtOutstanding.Text +"','"+ txtSince.Text +"')";
            OleDbCommand cmd = new OleDbCommand(sql,con);
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
            txtBank.Focus();
            grdBanking.Enabled = false;
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
            con = new OleDbConnection(connectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "delete from Cp_Cd102 where CTX_REF=" + txtRef.Text;
            cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            fillgrid();
            MessageBox.Show(GlobalMsg.deleteMsg, "Perfect Tax Reporter - CMA 1.0");
         }

       

        private void grdBanking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdBanking.Rows[e.RowIndex];
                txtRef.Text = row.Cells["CTX_REF"].Value.ToString();
                txtBank.Text = row.Cells["CTXT01"].Value.ToString();
                txtFacility.Text = row.Cells["CTXT02"].Value.ToString();
                txtLimit.Text = row.Cells["CTXT03"].Value.ToString();
                txtOutstanding.Text = row.Cells["CTXT04"].Value.ToString();
                txtSince.Text = row.Cells["CTXT05"].Value.ToString();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormBanking();
                this.Hide();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormBanking();
                this.Hide();
            }
        }


        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (txtBank.Text.Trim().Equals(""))
            {
                MessageBox.Show(GlobalMsg.bnkNameMsg, "Perfect Tax Reporter - CMA 1.0");
                txtBank.Focus();
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
                sql = "insert into Cp_Cd102(CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CL_REFNO) values ('" + txtBank.Text + "','" + txtFacility.Text + "','" + txtLimit.Text + "','" + txtOutstanding.Text + "','" + txtSince.Text + "'," + Global.prtyCode + ")";
            }
            else
            {
                sql = "update Cp_Cd102 set CTXT01='" + txtBank.Text + "',CTXT02='" + txtFacility.Text + "',CTXT03='" + txtLimit.Text + "',CTXT04='" + txtOutstanding.Text + "',CTXT05='" + txtSince.Text + "' WHERE CTX_REF=" + txtRef.Text + " AND CL_REFNO=" + Global.prtyCode;
            }
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = false;

            }
            grdBanking.Enabled = true;
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
                grdBanking.Enabled = true;
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
            txtBank.Focus();
            grdBanking.Enabled = false;
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
