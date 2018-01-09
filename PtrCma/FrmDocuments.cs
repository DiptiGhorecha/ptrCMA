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
    public partial class FrmDocuments : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormDocuments;
        string isAddEdit = ""; //Variable to Store Current Action(Add,Edit)
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        public FrmDocuments()
        {
            InitializeComponent();
        }

        private void FrmDocuments_Load(object sender, EventArgs e)
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
            if (grdPurchase.RowCount > 0)
            {
                grdPurchase.CurrentCell = grdPurchase.Rows[0].Cells[0];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }
            cmdAdd.Focus();
        }


        private void filltempTable()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                string sqlTrunc = "DELETE FROM Cp_Cd115";
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "INSERT INTO Cp_Cd115 SELECT * FROM Cx_Cd115 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds1, "Cp_Cd115");
                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cp_Cd115");
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
            if (grdPurchase.RowCount > 0)    // No Crashing problem when there is no data in gridview
            {
                DataGridViewRow row = this.grdPurchase.Rows[0];
                txtDoc.Text = row.Cells["CTXT01"].Value.ToString();
            }
        }

        private void fillgrid()
        {
            try
            {
                con = new OleDbConnection(connectionString);
                DataSet ds = new DataSet();
                dataAdapter = new OleDbDataAdapter("select * from Cp_Cd115 WHERE CL_REFNO=" + Global.prtyCode, con);
                dataAdapter.Fill(ds, "Cp_Cd115");
                grdPurchase.DataMember = "Cp_Cd115";
                grdPurchase.DataSource = ds;
                con.Close();

                //Show selected Column in Gridview
                for (int i = 0; i <= grdPurchase.Columns.Count - 1; i++)
                {
                    grdPurchase.Columns[i].ReadOnly = true;
                    grdPurchase.Columns[i].Visible = false;
                }

                grdPurchase.Columns[0].Visible = true;
                grdPurchase.Columns[0].HeaderText = "Documents";
                grdPurchase.Columns[0].Width = 250;
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
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = true;
                txt.Clear();
            }
            txtDoc.Focus();
            grdPurchase.Enabled = false;
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
            if (grdPurchase.Rows.Count > 0)
            {
                DialogResult dialogResult1 = MessageBox.Show(GlobalMsg.deleteMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
                if (dialogResult1 == DialogResult.Yes)
                {
                    con = new OleDbConnection(connectionString);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    String sql = "delete from Cx_Cd115 WHERE CL_REFNO=" + Global.prtyCode;
                    cmd = new OleDbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //fillgrid();
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

        private void grdPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdPurchase.Rows[e.RowIndex];
                txtDoc.Text = row.Cells["CTXT01"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormDocuments();
                this.Hide();
            }
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormDocuments();
                this.Hide();
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (txtDoc.Text.Trim().Equals(""))
            {
                MessageBox.Show(GlobalMsg.nameMsg, "Perfect Tax Reporter - CMA 1.0");
                txtDoc.Focus();
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
                sql = "insert into Cp_Cd115(CTXT01,CL_REFNO) values ('" + txtDoc.Text + "'," + Global.prtyCode + ")";
            }
            else
            {
                sql = "update Cp_Cd115 set CTXT01='" + txtDoc.Text + "' WHERE CTX_REF=" + txtRef.Text + " AND CL_REFNO=" + Global.prtyCode;
            }
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = false;

            }
            grdPurchase.Enabled = true;
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
                grdPurchase.Enabled = true;
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
            txtDoc.Focus();
            grdPurchase.Enabled = false;
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
