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
    public partial class FrmMajorBuyer : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormBuyer;
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        public FrmMajorBuyer()
        {
            InitializeComponent();
        }


        private void FrmMajorBuyer_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            fillgrid();
            //FrmMajorBuyer frmBuyer = new FrmMajorBuyer();
            //frmBuyer.MdiParent = this;
            //frmBuyer.StartPosition = FormStartPosition.CenterScreen;
            //frmBuyer.Show();
            if (grdPurchase.RowCount > 0)
            {
                grdPurchase.CurrentCell = grdPurchase.Rows[0].Cells[1];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }
        }

        private void LoadDatatoTextBox()
        {
            if (grdPurchase.RowCount > 0)    // No Crashing problem when there is no data in gridview
            {
                DataGridViewRow row = this.grdPurchase.Rows[0];
                txtDoc.Text = row.Cells["CD_DOC"].Value.ToString();
            }
        }

        private void fillgrid()
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            dataAdapter = new OleDbDataAdapter("select * from Cx_Cd106", con);
            dataAdapter.Fill(ds, "Cx_Cd106");
            grdPurchase.DataMember = "Cx_Cd106";
            grdPurchase.DataSource = ds;
            con.Close();

            //Show selected Column in Gridview
            for (int i = 0; i <= grdPurchase.Columns.Count - 1; i++)
            {
                grdPurchase.Columns[i].ReadOnly = true;
                grdPurchase.Columns[i].Visible = false;
            }

            grdPurchase.Columns[1].Visible = true;
            grdPurchase.Columns[1].HeaderText = "Document Detail";
            grdPurchase.Columns[1].Width = 710;
        }

        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;
            grdPurchase.RowsDefaultCellStyle.BackColor = Color.White;     // Row Color of Gridview

            // Column Header Color of Gridview
            //  grdViewDirectors.ColumnHeadersHeight = 30;
            grdPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdPurchase.EnableHeadersVisualStyles = false;
            grdPurchase.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            grdPurchase.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;
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

            //foreach (TextBox txt in Controls.OfType<TextBox>())  //Set Size of TextBox
            //{
            //    txt.Font = Global.txtSize;
            //    txt.Size = Global.txtmedSize;
            //    txt.AutoSize = false;
            //}
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
            String sql = "insert into Cx_Cd106(CD_DOC)values('" + txtDoc.Text + "')";
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
            String sql = "delete from Cx_Cd106 where CD_DOC='" + txtDoc.Text + "'";
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

        private void grdPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmdAdd.Enabled = false;
            cmdDelete.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdPurchase.Rows[e.RowIndex];
                //txtRef.Text = row.Cells["CD_REFNO"].Value.ToString();
                txtDoc.Text = row.Cells["CD_DOC"].Value.ToString();
            }
        }

        private void txtDoc_Click(object sender, EventArgs e)
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
                NotifyMainFormToCloseChildFormBuyer();
                this.Hide();
            }
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormBuyer();
                this.Hide();
            }
        }
    }
}
