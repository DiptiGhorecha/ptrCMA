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
    public partial class FrmTermsSales : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormSales;
		String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
		OleDbConnection con;
		OleDbCommand cmd;
		OleDbDataAdapter dataAdapter;
		public FrmTermsSales()
        {
            InitializeComponent();
        }

        private void FrmTermsSales_Load(object sender, EventArgs e)
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
				String sql = "select * from Cp_Cd107 WHERE CL_REFNO=" + Global.prtyCode;

				myadapter.SelectCommand = new OleDbCommand(sql, conn);
				myadapter.Fill(ds1, "Cp_Cd107");
				if (ds1.Tables[0].Rows.Count > 0)
				{
					for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
					{
						txtCreditD.Text = ds1.Tables[0].Rows[i]["CTXT01"].ToString();
						txtPeriodD.Text = ds1.Tables[0].Rows[i]["CTXT02"].ToString();
						txtAverageD.Text = ds1.Tables[0].Rows[i]["CTXT03"].ToString();
						txtCreditE.Text = ds1.Tables[0].Rows[i]["CTXT04"].ToString();
						txtPeriodE.Text = ds1.Tables[0].Rows[i]["CTXT05"].ToString();
						txtAverageE.Text = ds1.Tables[0].Rows[i]["CTXT06"].ToString();
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
				string sqlTrunc = "DELETE FROM Cp_Cd107";
				OleDbDataAdapter myadapter = new OleDbDataAdapter();
				DataSet ds1 = new DataSet();
				String sql = "INSERT INTO Cp_Cd107 SELECT * FROM Cx_Cd107 WHERE CL_REFNO=" + Global.prtyCode;
				myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
				myadapter.Fill(ds1, "Cp_Cd107");
				myadapter.SelectCommand = new OleDbCommand(sql, conn);
				myadapter.Fill(ds1, "Cp_Cd107");
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
                lbl.Size = Global.lbl;
                lblDomestic.Size = Global.lblSmall;
                lblExport.Size = Global.lblSmall;
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

		private void btnExit_Click(object sender, EventArgs e)
		{
			OleDbConnection con = new OleDbConnection();
			con.ConnectionString = connectionString;
			if (con.State == ConnectionState.Closed)
			{
				con.Open();
			}
			String sql = "";
			string sqlSelect = "SELECT * FROM Cp_Cd107 WHERE CL_REFNO=" + Global.prtyCode;

			OleDbDataAdapter myadapter = new OleDbDataAdapter();
			DataSet ds1 = new DataSet();
			myadapter.SelectCommand = new OleDbCommand(sqlSelect, con);
			myadapter.Fill(ds1, "Cp_Cd107");
			if (ds1.Tables[0].Rows.Count > 0)
			{
				sql = "update Cp_Cd107 set CTXT01='" + txtCreditD.Text + "',CTXT02='" + txtPeriodD.Text + "',CTXT03='" + txtAverageD.Text + "',CTXT04='" + txtCreditE.Text + "',CTXT05='" + txtPeriodE.Text + "',CTXT06='" + txtAverageE.Text + "' where CL_REFNO=" + Global.prtyCode;
			}
			else
			{
				sql = "insert into Cp_Cd107(CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CTXT06,CL_REFNO) values ('" + txtCreditD.Text + "','" + txtPeriodD.Text + "','" + txtAverageD.Text + "','" + txtCreditE.Text + "','" + txtPeriodE.Text + "','" + txtAverageE.Text + "',"+ Global.prtyCode + ")";

			}
			myadapter.SelectCommand = new OleDbCommand(sql, con);
			myadapter.Fill(ds1, "Cp_Cd107");
			con.Close();
			DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
			if (dialogResult == DialogResult.Yes)
			{
				NotifyMainFormToCloseChildFormSales();
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormSales();
                this.Hide();
            }
        }
    }
}
