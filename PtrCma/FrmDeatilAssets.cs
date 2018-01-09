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
        string isAddEdit = ""; //Variable to Store Current Action(Add,Edit)
        public FrmDeatilAssets()
        {
            InitializeComponent();
        }

        private void FrmDeatilAssets_Load(object sender, EventArgs e)
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


            if (grdAssests.RowCount > 0)
            {
                grdAssests.CurrentCell = grdAssests.Rows[0].Cells[0];  //Set 1st row as current row by default
                LoadDatatoTextBox();  // show data in Textbox from Gridview
            }
            cmdAdd.Focus();
        }

        private void LoadDatatoTextBox()
        {
            if (grdAssests.RowCount > 0)    // No Crashing problem when there is no data in gridview
            {
                DataGridViewRow row = this.grdAssests.Rows[0];
                txtRef.Text = row.Cells["CTX_REF"].Value.ToString();
                txtDes.Text = row.Cells["CTXT01"].Value.ToString();
                txtSupplier.Text = row.Cells["CTXT02"].Value.ToString();
                txtCost.Text = row.Cells["CTXT03"].Value.ToString();
                txtCom.Text = row.Cells["CTXT04"].Value.ToString();
            }
        }

        private void filltempTable()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                string sqlTrunc = "DELETE FROM Cp_Cd110";
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "INSERT INTO Cp_Cd110 SELECT * FROM Cx_Cd110 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds1, "Cp_Cd110");
                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cp_Cd110");
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

            //OleDbConnection conn = new OleDbConnection(connectionString);
            //string sqlTrunc = "DELETE FROM Cp_Cd110";
            //OleDbDataAdapter myadapter = new OleDbDataAdapter();
            //DataSet ds1 = new DataSet();
            //String sql = "INSERT INTO Cp_Cd110 SELECT * FROM Cp_Cd110 WHERE CL_REFNO=" + Global.prtyCode;
            //myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
            //myadapter.Fill(ds1, "Cp_Cd110");
            //myadapter.SelectCommand = new OleDbCommand(sql, conn);
            //myadapter.Fill(ds1, "Cp_Cd110");
            //ds1.Dispose();
            //conn.Close();


            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            dataAdapter = new OleDbDataAdapter("select * from Cp_Cd110 WHERE CL_REFNO=" + Global.prtyCode, con);
            dataAdapter.Fill(ds, "Cp_Cd110");
            grdAssests.DataMember = "Cp_Cd110";
            grdAssests.DataSource = ds;
            con.Close();

            //Show selected Column in Gridview
            for (int i = 0; i <= grdAssests.Columns.Count - 1; i++)
            {
                grdAssests.Columns[i].ReadOnly = true;
                grdAssests.Columns[i].Visible = false;
            }

            grdAssests.Columns[0].Visible = true;
            grdAssests.Columns[0].HeaderText = "Description";
            grdAssests.Columns[0].Width = 270;
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
                cmdDel.Size = Global.btnmedSize;
                cmdUpdate.Size = Global.btnmedSize;
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
                txt.Clear();
            }
            txtDes.Focus();
            grdAssests.Enabled = false;
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
            if (grdAssests.RowCount > 0)
            {
                DialogResult dialogResult1 = MessageBox.Show(GlobalMsg.deleteMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
                if (dialogResult1 == DialogResult.Yes)
                {
                    con = new OleDbConnection(connectionString);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    String sql = "delete from Cp_Cd110 where CTX_REF=" + txtRef.Text;
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

        private void grdAssests_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdAssests.Rows[e.RowIndex];
                txtRef.Text = row.Cells["CTX_REF"].Value.ToString();
                txtDes.Text = row.Cells["CTXT01"].Value.ToString();
                txtSupplier.Text = row.Cells["CTXT02"].Value.ToString();
                txtCost.Text = row.Cells["CTXT03"].Value.ToString();
                txtCom.Text = row.Cells["CTXT04"].Value.ToString();
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
            cmdDel.Enabled = false;
            cmdAdd.Enabled = true;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormAssets();
                this.Hide();

            }
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormAssets();
                this.Hide();

            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (txtDes.Text.Trim().Equals(""))
            {
                MessageBox.Show(GlobalMsg.desMsg, "Perfect Tax Reporter - CMA 1.0");
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
                sql = "insert into Cp_Cd110(CTXT01,CTXT02,CTXT03,CTXT04,CL_REFNO) values ('" + txtDes.Text + "','" + txtSupplier.Text + "','" + txtCost.Text + "','" + txtCom.Text + "'," + Global.prtyCode + ")";

            }
            else
            {
                sql = "update Cp_Cd110 set CTXT01='" + txtDes.Text + "',CTXT02='" + txtSupplier.Text + "',CTXT03='" + txtCost.Text + "',CTXT04='" + txtCom.Text + "' WHERE CTX_REF=" + txtRef.Text + " AND CL_REFNO=" + Global.prtyCode;
            }
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Enabled = false;

            }
            grdAssests.Enabled = true;
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
                grdAssests.Enabled = true;
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
            if (grdAssests.RowCount > 0)
            {
                foreach (TextBox txt in Controls.OfType<TextBox>())
                {
                    txt.Enabled = true;
                }
                txtDes.Focus();
                grdAssests.Enabled = false;
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
}
