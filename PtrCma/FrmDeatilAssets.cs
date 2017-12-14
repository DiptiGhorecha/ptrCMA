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
    public partial class FrmDeatilAssets : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormAssets;
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        public FrmDeatilAssets()
        {
            InitializeComponent();
        }

        private void FrmDeatilAssets_Load(object sender, EventArgs e)
        {
            cmdDelete.Enabled = false;
            cmdAdd.Enabled = false;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = false;
                txtDes.Enabled = true;
            }
            fillgrid();
            
            if (grdAssests.RowCount > 0)
            {
                grdAssests.CurrentCell = grdAssests.Rows[0].Cells[1];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }
        }

        private void LoadDatatoTextBox()
        {
            if (grdAssests.RowCount > 0)    // No Crashing problem when there is no data in gridview
            {
                DataGridViewRow row = this.grdAssests.Rows[0];
                txtDes.Text = row.Cells["CD_DES"].Value.ToString();
                txtSupplier.Text = row.Cells["CD_SUP"].Value.ToString();
                txtCost.Text = row.Cells["CD_COST"].Value.ToString();
                txtCom.Text = row.Cells["CD_COM"].Value.ToString();
            }
        }

        private void fillgrid()
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            dataAdapter = new OleDbDataAdapter("select * from Cx_Cd110", con);
            dataAdapter.Fill(ds, "Cx_Cd110");
            grdAssests.DataMember = "Cx_Cd110";
            grdAssests.DataSource = ds;
            con.Close();

            //Show selected Column in Gridview
            for (int i = 0; i <= grdAssests.Columns.Count - 1; i++)
            {
                grdAssests.Columns[i].ReadOnly = true;
                grdAssests.Columns[i].Visible = false;
            }

            grdAssests.Columns[1].Visible = true;
            grdAssests.Columns[1].HeaderText = "Description";
            grdAssests.Columns[1].Width = 270;
        }

        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;

            grdAssests.RowsDefaultCellStyle.BackColor = Color.White;     // Row Color of Gridview

            // Column Header Color of Gridview
            grdAssests.ColumnHeadersHeight = 30;
            grdAssests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdAssests.EnableHeadersVisualStyles = false;
            grdAssests.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            grdAssests.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;

            setControlColor();
            setControlSize();
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
            grdAssests.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            grdAssests.DefaultCellStyle.SelectionForeColor = Color.Black;
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
            String sql = "insert into Cx_Cd110(CD_DES,CD_SUP,CD_COST,CD_COM) values('" + txtDes.Text + "','" + txtSupplier.Text + "','" + txtCost.Text + "','" + txtCom.Text + "')";
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
            String sql = "delete from Cx_Cd110 where CD_DES='" + txtDes.Text + "'";
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

        private void grdAssests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmdAdd.Enabled = false;
            cmdDelete.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdAssests.Rows[e.RowIndex];
                //txtRef.Text = row.Cells["CD_REFNO"].Value.ToString();
                txtDes.Text = row.Cells["CD_DES"].Value.ToString();
                txtSupplier.Text = row.Cells["CD_SUP"].Value.ToString();
                txtCost.Text = row.Cells["CD_COST"].Value.ToString();
                txtCom.Text = row.Cells["CD_COM"].Value.ToString();
            }
        }

        private void txtDes_Click(object sender, EventArgs e)
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

        private void cmdExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormAssets();
                this.Hide();
                fillgrid();
                LoadDatatoTextBox();
                cmdDelete.Enabled = false;
                cmdAdd.Enabled = false;
                foreach (TextBox txt in Controls.OfType<TextBox>())
                {
                    txt.Enabled = false;
                    txtDes.Enabled = true;
                }
            }
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormAssets();
                this.Hide();
                fillgrid();
                LoadDatatoTextBox();
                cmdDelete.Enabled = false;
                cmdAdd.Enabled = false;
                foreach (TextBox txt in Controls.OfType<TextBox>())
                {
                    txt.Enabled = false;
                    txtDes.Enabled = true;
                }
            }
        }

    }
}
