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
    public partial class FrmPositionIncomeTax : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormPosition;
		String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
		OleDbConnection con;
		OleDbCommand cmd;
		OleDbDataAdapter dataAdapter;
		public FrmPositionIncomeTax()
        {
            InitializeComponent();
        }


        private void FrmPositionIncomeTax_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            filltempTable();
            loadDataToTextBoxes();
            this.Visible = true;

        }

        private void loadDataToTextBoxes()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "select * from Cp_Cd119 WHERE CL_REFNO=" + Global.prtyCode;

                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cp_Cd119");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        txtIncome.Text = ds1.Tables[0].Rows[i]["CTXT01"].ToString();
                        txtSales.Text = ds1.Tables[0].Rows[i]["CTXT02"].ToString();
                        txtService.Text = ds1.Tables[0].Rows[i]["CTXT03"].ToString();
                        txtExcise.Text = ds1.Tables[0].Rows[i]["CTXT04"].ToString();
                        txtOther.Text = ds1.Tables[0].Rows[i]["CTXT05"].ToString();
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
                string sqlTrunc = "DELETE FROM Cp_Cd119";
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "INSERT INTO Cp_Cd119 SELECT * FROM Cx_Cd119 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds1, "Cp_Cd119");
                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cp_Cd119");
                ds1.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }


        private void checkTable()
        {
            if (txtIncome.Text == String.Empty && txtSales.Text == String.Empty && txtService.Text == String.Empty && txtExcise.Text == String.Empty && txtOther.Text == String.Empty)
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = connectionString;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DataSet ds = new DataSet();
                String sql = "select * from Cx_Cd119";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtRef.Text = reader["CD_REFNO"].ToString();
                    txtIncome.Text = reader["CD_INCOME"].ToString();
                    txtSales.Text = reader["CD_SALES"].ToString();
                    txtService.Text = reader["CD_SERVICE"].ToString();
                    txtExcise.Text = reader["CD_EXCISE"].ToString();
                    txtOther.Text = reader["CD_OTHER"].ToString();
                }
                con.Close();
                //MessageBox.Show(GlobalMsg.insertMsg, "Perfect Tax Reporter - CMA 1.0");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = connectionString;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                String sql = "Update Cx_Cd119 set [CD_INCOME] = '" + txtIncome.Text + "',[CD_SALES]= '" + txtSales.Text + "', [CD_SERVICE]='" + txtService.Text + "',[CD-EXCISE]='" + txtExcise.Text + "', [CD_OTHER] = '" + txtOther.Text + "' where [CD_REFNO] ='" + txtRef.Text + "' ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(GlobalMsg.updateMsg, "Perfect Tax Reporter - CMA 1.0");
            }
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
        }

        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;


            
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
            string sqlSelect = "SELECT * FROM Cp_Cd119 WHERE CL_REFNO=" + Global.prtyCode;

            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds1 = new DataSet();
            myadapter.SelectCommand = new OleDbCommand(sqlSelect, con);
            myadapter.Fill(ds1, "Cp_Cd119");
            if (ds1.Tables[0].Rows.Count > 0)
            {
                sql = "update Cp_Cd119 set CTXT01=" + txtIncome.Text + ",CTXT02=" + txtSales.Text + ",CTXT03=" + txtService.Text + ",CTXT04=" + txtExcise.Text + ",CTXT05=" + txtOther.Text + ", where CL_REFNO=" + Global.prtyCode;
            }
            else
            {
                sql = "insert into Cp_Cd119(CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CL_REFNO) values (" + txtIncome.Text + "," + txtSales.Text + "," + txtService.Text + "," + txtExcise.Text + "," + txtOther.Text + "," + Global.prtyCode + ")";

            }
            myadapter.SelectCommand = new OleDbCommand(sql, con);
            myadapter.Fill(ds1, "Cp_Cd119");
            con.Close();
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormPosition();
                this.Hide();
            }
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormPosition();
                this.Hide();
            }
        }
    }
}
