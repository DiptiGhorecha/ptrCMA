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
    public partial class FrmYears : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormYear;
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        public FrmYears()
        {
            InitializeComponent();
        }

        private void FrmYears_Load(object sender, EventArgs e)
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
                String sql = "select * from Cx_Cd120 WHERE CL_REFNO=" + Global.prtyCode;

                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cx_Cd120");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        txtYr1.Text = ds1.Tables[0].Rows[i]["CTXT01"].ToString();
                        txtYr2.Text = ds1.Tables[0].Rows[i]["CTXT02"].ToString();
                        txtYr3.Text = ds1.Tables[0].Rows[i]["CTXT03"].ToString();
                        txtYr4.Text = ds1.Tables[0].Rows[i]["CTXT04"].ToString();
                        txtYr5.Text = ds1.Tables[0].Rows[i]["CTXT05"].ToString();
                        txtYr6.Text = ds1.Tables[0].Rows[i]["CTXT06"].ToString();
                        txtYr7.Text = ds1.Tables[0].Rows[i]["CTXT07"].ToString();
                        txtYr8.Text = ds1.Tables[0].Rows[i]["CTXT08"].ToString();
                        txtYr9.Text = ds1.Tables[0].Rows[i]["CTXT09"].ToString();
                        txtYr10.Text = ds1.Tables[0].Rows[i]["CTXT10"].ToString();
                        txtYr11.Text = ds1.Tables[0].Rows[i]["CTXT11"].ToString();
                        txtYr12.Text = ds1.Tables[0].Rows[i]["CTXT12"].ToString();
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
            //try
            //{
            //    OleDbConnection conn = new OleDbConnection(connectionString);
            //    string sqlTrunc = "DELETE FROM Cx_Cd120";
            //    OleDbDataAdapter myadapter = new OleDbDataAdapter();
            //    DataSet ds1 = new DataSet();
            //    String sql = "INSERT INTO Cp_Cd120 SELECT * FROM Cx_Cd120 WHERE CL_REFNO=" + Global.prtyCode;
            //    myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
            //    myadapter.Fill(ds1, "Cp_Cd120");
            //    myadapter.SelectCommand = new OleDbCommand(sql, conn);
            //    myadapter.Fill(ds1, "Cp_Cd120");
            //    ds1.Dispose();
            //    conn.Close();
            //}
            //catch (Exception e)
            //{
            //    //  Console.WriteLine(e.Message);//
            //    MessageBox.Show(e.Message);
            //}
        }


        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;

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
                // txt.Size = Global.txtmedSize;
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
            string sqlSelect = "SELECT * FROM Cx_Cd120 WHERE CL_REFNO=" + Global.prtyCode;

            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds1 = new DataSet();
            myadapter.SelectCommand = new OleDbCommand(sqlSelect, con);
            myadapter.Fill(ds1, "Cx_Cd120");
            if (ds1.Tables[0].Rows.Count > 0)
            {
                sql = "update Cx_Cd120 set CTXT01='" + txtYr1.Text + "',CTXT02='" + txtYr2.Text + "',CTXT03='" + txtYr3.Text + "',CTXT04='" + txtYr4.Text + "',CTXT05='" + txtYr5.Text + "',CTXT06='" + txtYr6.Text + "',CTXT07='" + txtYr7.Text + "',CTXT08='" + txtYr8.Text + "',CTXT09='" + txtYr9.Text + "',CTXT10='" + txtYr10.Text + "',CTXT11='" + txtYr11.Text + "',CTXT12='" + txtYr12.Text + "', where CL_REFNO=" + Global.prtyCode;
            }
            else
            {
                sql = "insert into Cx_Cd120(CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CTXT06,CTXT07,CTXT08,CTXT09,CTXT11,CTXT12,CL_REFNO) values ('" + txtYr1.Text + "','" + txtYr2.Text + "','" + txtYr3.Text + "','" + txtYr4.Text + "','" + txtYr5.Text + "','" + txtYr6.Text + "','" + txtYr7.Text + "','" + txtYr8.Text + "','" + txtYr9.Text + "','" + txtYr10.Text + "','" + txtYr11.Text + "','" + txtYr12.Text + "'," + Global.prtyCode + ")";

            }
            myadapter.SelectCommand = new OleDbCommand(sql, con);
            myadapter.Fill(ds1, "Cx_Cd120");
            con.Close();
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormYear();
                this.Hide();
            }
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormYear();
                this.Hide();
            }
        }

        private void picFrmClose_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormYear();
                this.Hide();
            }
        }
    }
}
