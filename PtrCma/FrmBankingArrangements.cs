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

        public FrmBankingArrangements()
        {
            InitializeComponent();
        }

        private void FrmBankingArrangements_Load(object sender, EventArgs e)
        {
            cmdDelete.Enabled = false;
            cmdAdd.Enabled = false;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            fillgrid();
            if (grdBanking.RowCount > 0)
            {
                grdBanking.CurrentCell = grdBanking.Rows[0].Cells[1];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
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
                txtBank.Text = row.Cells["CD_NAME"].Value.ToString();
                txtFacility.Text = row.Cells["CD_FACILITY"].Value.ToString();
                txtLimit.Text = row.Cells["CD_LIMIT"].Value.ToString();
                txtOutstanding.Text = row.Cells["CD_OUTST"].Value.ToString();
                txtSince.Text = row.Cells["CD_SINCE"].Value.ToString();
            }
        }

        private void fillgrid()
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            dataAdapter = new OleDbDataAdapter("select * from Cx_Cd102", con);
            dataAdapter.Fill(ds, "Cx_Cd102");
            grdBanking.DataMember = "Cx_Cd102";
            grdBanking.DataSource = ds;
            con.Close();

            //Show selected Column in Gridview
            for (int i = 0; i <= grdBanking.Columns.Count - 1; i++)
            {
                grdBanking.Columns[i].ReadOnly = true;
                grdBanking.Columns[i].Visible = false;
            }

            grdBanking.Columns[1].Visible = true;
            grdBanking.Columns[1].HeaderText = "Bank Name";
            grdBanking.Columns[1].Width = 270;
        }

        private void setControlSize()
        {
            foreach (Button btn in Controls.OfType<Button>())   //Set Size of Button
            {
                btn.Size = Global.smallbtn;
                cmdDelete.Size = Global.btnmedSize;
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

        private void cmdAdd_Click(object sender, EventArgs e)
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

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(connectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "delete from Cx_Cd101 where CD_NAME='" + txtBank.Text + "'";
            cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            fillgrid();
            MessageBox.Show(GlobalMsg.deleteMsg, "Perfect Tax Reporter - CMA 1.0");
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Clear();
                txt.Enabled = true;
            }
            LoadDatatoTextBox();


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

        private void grdBanking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmdAdd.Enabled = false;
            cmdDelete.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdBanking.Rows[e.RowIndex];
                //txtRef.Text = row.Cells["CD_REFNO"].Value.ToString();
                txtBank.Text = row.Cells["CD_NAME"].Value.ToString();
                txtFacility.Text = row.Cells["CD_FACILITY"].Value.ToString();
                txtLimit.Text = row.Cells["CD_LIMIT"].Value.ToString();
                txtOutstanding.Text = row.Cells["CD_OUTST"].Value.ToString();
                txtSince.Text = row.Cells["CD_SINCE"].Value.ToString();
            }
        }

        private void txtBank_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Clear();
                txt.Focus();
            }
            cmdDelete.Enabled = false;
            cmdAdd.Enabled = true;
        }
    }
}
