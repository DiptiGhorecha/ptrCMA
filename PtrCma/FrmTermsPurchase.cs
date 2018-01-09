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
    public partial class FrmTermsPurchase : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormPurchase;
		String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
		OleDbConnection con;
		OleDbCommand cmd;
		OleDbDataAdapter dataAdapter;
		public FrmTermsPurchase()
        {
            InitializeComponent();
        }


        private void FrmTermsPurchase_Load(object sender, EventArgs e)
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
				String sql = "select * from Cp_Cd105 WHERE CL_REFNO=" + Global.prtyCode;

				myadapter.SelectCommand = new OleDbCommand(sql, conn);
				myadapter.Fill(ds1, "Cp_Cd105");
				if (ds1.Tables[0].Rows.Count > 0)
				{
					for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
					{
						txtPTotalD.Text = ds1.Tables[0].Rows[i]["CTXT01"].ToString();
						txtPeriodD.Text = ds1.Tables[0].Rows[i]["CTXT02"].ToString();
						txtAverageD.Text = ds1.Tables[0].Rows[i]["CTXT03"].ToString();
						txtPurchaseD.Text = ds1.Tables[0].Rows[i]["CTXT04"].ToString();
						txtPTotalI.Text = ds1.Tables[0].Rows[i]["CTXT05"].ToString();
						txtPeriodI.Text = ds1.Tables[0].Rows[i]["CTXT06"].ToString();
						txtAverageI.Text = ds1.Tables[0].Rows[i]["CTXT07"].ToString();
						txtPurchaseI.Text = ds1.Tables[0].Rows[i]["CTXT08"].ToString();
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
				string sqlTrunc = "DELETE FROM Cp_Cd105";
				OleDbDataAdapter myadapter = new OleDbDataAdapter();
				DataSet ds1 = new DataSet();
				String sql = "INSERT INTO Cp_Cd105 SELECT * FROM Cx_Cd105 WHERE CL_REFNO=" + Global.prtyCode;
				myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
				myadapter.Fill(ds1, "Cp_Cd105");
				myadapter.SelectCommand = new OleDbCommand(sql, conn);
				myadapter.Fill(ds1, "Cp_Cd105");
				ds1.Dispose();
				conn.Close();
			}
			catch (Exception e)
			{
				//  Console.WriteLine(e.Message);//
				MessageBox.Show(e.Message);
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
                lbl.Size = Global.lblbig;
                lblDomestic.Size = Global.lblSmall;
                lblImport.Size = Global.lblSmall;
                lbl.AutoSize = false;
            }

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

        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;
            setControlColor();
            setControlSize();
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
			string sqlSelect = "SELECT * FROM Cp_Cd105 WHERE CL_REFNO=" + Global.prtyCode;

			OleDbDataAdapter myadapter = new OleDbDataAdapter();
			DataSet ds1 = new DataSet();
			myadapter.SelectCommand = new OleDbCommand(sqlSelect, con);
			myadapter.Fill(ds1, "Cp_Cd105");

			if (ds1.Tables[0].Rows.Count > 0)
			{
				sql = "update Cp_Cd105 set CTXT01='" + txtPTotalD.Text + "',CTXT02='" + txtPeriodD.Text + "',CTXT03='" + txtAverageD.Text + "',CTXT04='" + txtPurchaseD.Text + "',CTXT05='" + txtPTotalI.Text + "',CTXT06='" + txtPeriodI.Text + "',CTXT07='" + txtAverageI.Text + "',CTXT08='" + txtPurchaseI.Text + "' where CL_REFNO=" + Global.prtyCode;
			}
			else
			{
				sql = "insert into Cp_Cd105(CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CTXT06,CTXT07,CTXT08,CL_REFNO) values ('" + txtPTotalD.Text + "','" + txtPeriodD.Text + "','" + txtAverageD.Text + "','" + txtPurchaseD.Text + "','" + txtPTotalI.Text + "','" + txtPeriodI.Text + "','" + txtAverageI.Text + "','" + txtPurchaseI.Text + "'," + Global.prtyCode + ")";

			}
			myadapter.SelectCommand = new OleDbCommand(sql, con);
			myadapter.Fill(ds1, "Cp_Cd105");
			con.Close();
			DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
			if (dialogResult == DialogResult.Yes)
			{
				NotifyMainFormToCloseChildFormPurchase();
				this.Hide();
			}
		}
        private void textBox_KeyDown(object sender, KeyEventArgs e)     // Cursor go to the Next TextBox After Pressing Enter
        {
            Control ctrl;
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                //    if (e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, false, false, false);
                }
                else
                    return;

            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    this.SelectNextControl(ctrl, false, false, false, false);
                }
                else
                    return;
            }

        }
        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormPurchase();
                this.Hide();
            }
        }
    }
}
