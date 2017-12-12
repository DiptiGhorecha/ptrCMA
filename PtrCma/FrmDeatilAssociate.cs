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
        public FrmDeatilAssociate()
        {
            InitializeComponent();
        }


        private void FrmDeatilAssociate_Load(object sender, EventArgs e)
        {
            cmdDelete.Enabled = false;
            cmdAdd.Enabled = false;
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = false;
                txtName.Enabled = true;
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
                grdAssociate.CurrentCell = grdAssociate.Rows[0].Cells[1];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }
        }

        private void LoadDatatoTextBox()
        {
            if (grdAssociate.RowCount > 0)    // No Crashing problem when there is no data in gridview
            {
                DataGridViewRow row = this.grdAssociate.Rows[0];
                txtName.Text = row.Cells["CD_UNIT"].Value.ToString();
                txtProp.Text = row.Cells["CD_PROP"].Value.ToString();
                txtBank.Text = row.Cells["CD_BANK"].Value.ToString();
                txtLimit.Text = row.Cells["CD_LIMIT"].Value.ToString();
                txtOutst.Text = row.Cells["CD_OUTST"].Value.ToString();
            }
        }

        private void fillgrid()
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            dataAdapter = new OleDbDataAdapter("select * from Cx_Cd103", con);
            dataAdapter.Fill(ds, "Cx_Cd103");
            grdAssociate.DataMember = "Cx_Cd103";
            grdAssociate.DataSource = ds;
            con.Close();

            //Show selected Column in Gridview
            for (int i = 0; i <= grdAssociate.Columns.Count - 1; i++)
            {
                grdAssociate.Columns[i].ReadOnly = true;
                grdAssociate.Columns[i].Visible = false;
            }

            grdAssociate.Columns[1].Visible = true;
            grdAssociate.Columns[1].HeaderText = "Associate Name";
            grdAssociate.Columns[1].Width = 260;
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


        private void cmdAdd_Click(object sender, EventArgs e)
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

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(connectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "delete from Cx_Cd103 where CD_UNIT='" + txtName.Text + "'";
            cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            fillgrid();
            MessageBox.Show(GlobalMsg.deleteMsg, "Perfect Tax Reporter - CMA 1.0");
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Clear();
                txt.Enabled = true;
                // txtName.Focus();
            }
            LoadDatatoTextBox();
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormAssociate();
                this.Hide();
                fillgrid();
                LoadDatatoTextBox();
                cmdDelete.Enabled = false;
                cmdAdd.Enabled = false;
                foreach (TextBox txt in Controls.OfType<TextBox>())
                {
                    txt.Enabled = false;
                    txtName.Enabled = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormAssociate();
                this.Hide();
                fillgrid();
                LoadDatatoTextBox();
                cmdDelete.Enabled = false;
                cmdAdd.Enabled = false;
                foreach (TextBox txt in Controls.OfType<TextBox>())
                {
                    txt.Enabled = false;
                    txtName.Enabled = true;
                }
            }
        }

        private void grdAssociate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmdAdd.Enabled = false;
            cmdDelete.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdAssociate.Rows[e.RowIndex];
                //txtRef.Text = row.Cells["CD_REFNO"].Value.ToString();
                txtName.Text = row.Cells["CD_UNIT"].Value.ToString();
                txtProp.Text = row.Cells["CD_PROP"].Value.ToString();
                txtBank.Text = row.Cells["CD_BANK"].Value.ToString();
                txtLimit.Text = row.Cells["CD_LIMIT"].Value.ToString();
                txtOutst.Text = row.Cells["CD_OUTST"].Value.ToString();
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Clear();
                txt.Focus();
                txt.Enabled = true;
            }
            cmdDelete.Enabled = false;
            cmdAdd.Enabled = true;
        }

        private void pictitle_Click(object sender, EventArgs e)
        {

        }
    }
}
