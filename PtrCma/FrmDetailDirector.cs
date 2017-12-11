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
    public partial class FrmDetailDirector : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormDirector;
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;

        public FrmDetailDirector()
        {
            InitializeComponent();
        }

        private void FrmDetailDirector_Load(object sender, EventArgs e)
        {
            cmdDelete.Enabled = false;
            cmdAdd.Enabled = false;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            fillgrid();
            //FrmDetailDirector frmDirector = new FrmDetailDirector();
            //frmDirector.MdiParent = this;
            //frmDirector.StartPosition = FormStartPosition.CenterParent;
            //frmDirector.Show();

            if (grdViewDirectors.RowCount > 0)
            {
                grdViewDirectors.CurrentCell = grdViewDirectors.Rows[0].Cells[1];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }
            
        }

     

        private void fillgrid()
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            dataAdapter = new OleDbDataAdapter("select * from Cx_Cd101",con);
            dataAdapter.Fill(ds, "Cx_Cd101");
            grdViewDirectors.DataMember = "Cx_Cd101";
            grdViewDirectors.DataSource = ds;
            con.Close();

            //Show selected Column in Gridview
            for (int i = 0; i <= grdViewDirectors.Columns.Count - 1; i++)
            {
                grdViewDirectors.Columns[i].ReadOnly = true;
                grdViewDirectors.Columns[i].Visible = false;
            }

            grdViewDirectors.Columns[1].Visible = true;
            grdViewDirectors.Columns[1].HeaderText = "Director Name";
            grdViewDirectors.Columns[1].Width = 250;

        }

        private void LoadDatatoTextBox()
        {
            if (grdViewDirectors.RowCount > 0)    // No Crashing problem when there is no data in gridview
            {
                DataGridViewRow row = this.grdViewDirectors.Rows[0];
                txtName.Text = row.Cells["CD_NAME"].Value.ToString();
                txtAge.Text = row.Cells["CD_AGE"].Value.ToString();
                txtPan.Text = row.Cells["CD_PAN"].Value.ToString();
                txtAdd.Text = row.Cells["CD_ADD"].Value.ToString();
                txtPhone.Text = row.Cells["CD_PHONE"].Value.ToString();
                txtNet.Text = row.Cells["CD_NET"].Value.ToString();
            }
        }
        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;
            grdViewDirectors.RowsDefaultCellStyle.BackColor = Color.White;     // Row Color of Gridview

            // Column Header Color of Gridview
            grdViewDirectors.ColumnHeadersHeight = 30;
            grdViewDirectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdViewDirectors.EnableHeadersVisualStyles = false;
            grdViewDirectors.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            grdViewDirectors.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;
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
            grdViewDirectors.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            grdViewDirectors.DefaultCellStyle.SelectionForeColor = Color.Black;
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
            String sql = "insert into Cx_Cd101(CD_NAME,CD_AGE,CD_PAN,CD_ADD,CD_PHONE,CD_NET)values('" + txtName.Text + "','" + txtAge.Text + "','" + txtPan.Text + "','" + txtAdd.Text + "','" + txtPhone.Text + "','" + txtNet.Text + "')";
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
            String sql = "delete from Cx_Cd101 where CD_NAME='"+ txtName.Text +"'";
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

        private void grdViewDirectors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmdAdd.Enabled = false;
            cmdDelete.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdViewDirectors.Rows[e.RowIndex];
                //txtRef.Text = row.Cells["CD_REFNO"].Value.ToString();
                txtName.Text = row.Cells["CD_NAME"].Value.ToString();
                txtAge.Text = row.Cells["CD_AGE"].Value.ToString();
                txtPan.Text = row.Cells["CD_PAN"].Value.ToString();
                txtAdd.Text = row.Cells["CD_ADD"].Value.ToString();
                txtPhone.Text = row.Cells["CD_PHONE"].Value.ToString();
                txtNet.Text = row.Cells["CD_NET"].Value.ToString();
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Clear();
                txt.Focus();
            }
            cmdDelete.Enabled = false;
            cmdAdd.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormDirector();
                this.Hide();
            }
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormDirector();
                this.Hide();
            }
        }
    }
}
