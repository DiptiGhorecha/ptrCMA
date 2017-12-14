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
            setControlColor();
            setControlSize();
            checkTable();
			
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
