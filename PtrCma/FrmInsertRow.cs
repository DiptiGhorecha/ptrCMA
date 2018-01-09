using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PtrCma
{
    public partial class FrmInsertRow : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormInsertRow;
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        public FrmInsertRow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmInsertRow_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
         //   filltempTable();
          //  loadDataToTextBoxes();
        }

        private void loadDataToTextBoxes()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);

                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "select * from Cp_Cd109 WHERE CL_REFNO=" + Global.prtyCode;

                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cp_Cd109");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        txtSr.Text = ds1.Tables[0].Rows[i]["CTXT11"].ToString();
                        txtSr1.Text = ds1.Tables[0].Rows[i]["CTXT12"].ToString();
                        txtSr1.Text = ds1.Tables[0].Rows[i]["CTXT12"].ToString();
                    }
                }
                ds1.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }

        private void filltempTable()
        {
            try
            {

                OleDbConnection conn = new OleDbConnection(connectionString);
                string sqlTrunc = "DELETE FROM Cp_Cd109";
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "INSERT INTO Cp_Cd109 SELECT * FROM Cx_Cd109 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds1, "Cp_Cd109");
                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cp_Cd109");
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

            setControlColor();
            //    setControlSize();
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
                lbl.Size = Global.lblsmallCredit;
                lbl.AutoSize = false;
 
            }
            //pictitle.Size = Global.titlelbl;

            foreach (TextBox txt in Controls.OfType<TextBox>())  //Set Size of TextBox
            {
                txt.Font = Global.txtSize;
                txt.Size = Global.txtsmall;
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = connectionString;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "";
            string sqlSelect = "SELECT * FROM Cp_Cd109 WHERE CL_REFNO=" + Global.prtyCode;
            //String sql = "update Cp_CdFm3 set FM_YR01=" + ctx11 + ",FM_YR02=" + ctx12 + ",FM_YR03=" + ctx13 + ",FM_YR04=" + ctx14 + ",FM_YR05=" + ctx15 + ",FM_YR06=" + ctx16 + ",FM_YR07=" + ctx17 + ",FM_YR08=" + ctx18 + ",FM_YR09=" + ctx19 + ",FM_YR10=" + ctx20 + ",FM_YR11=" + ctx21 + ",FM_YR12=" + ctx22 + " WHERE FM_CLREFNO=" + Global.prtyCode + " AND FM_REFNO=" + refno;
          //  String sql1 = "INSERT INTO Cx_CdFm3(FM_SEQNO,FM_TYPE, set FM_YR01=" + ctx11 + ",FM_YR02=" + ctx12 + ",FM_YR03=" + ctx13 + ",FM_YR04=" + ctx14 + ",FM_YR05=" + ctx15 + ",FM_YR06=" + ctx16 + ",FM_YR07=" + ctx17 + ",FM_YR08=" + ctx18 + ",FM_YR09=" + ctx19 + ",FM_YR10=" + ctx20 + ",FM_YR11=" + ctx21 + ",FM_YR12=" + ctx22 + " WHERE FM_CLREFNO=" + Global.prtyCode + " AND FM_REFNO=" + refno;
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds1 = new DataSet();
            myadapter.SelectCommand = new OleDbCommand(sqlSelect, con);
            myadapter.Fill(ds1, "Cp_Cd109");
            String ctx11, ctx12, ctx13 = "";
            ctx11 = ((txtSr.Text != null && txtSr.Text.Trim() != String.Empty) ? txtSr.Text : "Null");
            ctx12 = ((txtSr1.Text != null && txtSr1.Text.Trim() != String.Empty) ? txtSr1.Text.ToString() : "Null");
            ctx13 = ((txtDesc.Text != null && txtDesc.Text.Trim() != String.Empty) ? txtDesc.Text.ToString() : "Null");
 
    
            myadapter.SelectCommand = new OleDbCommand(sql, con);
            myadapter.Fill(ds1, "Cp_Cd109");
            con.Close();
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormInsertRow();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormInsertRow();
                this.Hide();
            }
        }
        private void cmdExit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
