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
    public partial class FrmProposedExpenditure : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormProposed;
		String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
		OleDbConnection con;
		OleDbCommand cmd;
		OleDbDataAdapter dataAdapter;
		public FrmProposedExpenditure()
        {
            InitializeComponent();
        }

        private void FrmProposedExpenditure_Load(object sender, EventArgs e)
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
				String sql = "select * from Cp_Cd111 WHERE CL_REFNO=" + Global.prtyCode;

				myadapter.SelectCommand = new OleDbCommand(sql, conn);
				myadapter.Fill(ds1, "Cp_Cd111");
				if (ds1.Tables[0].Rows.Count > 0)
				{
					for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
					{
						txtBuild.Text = ds1.Tables[0].Rows[i]["CTXT01"].ToString();
						txtEquip.Text = ds1.Tables[0].Rows[i]["CTXT02"].ToString();
						txtOther.Text = ds1.Tables[0].Rows[i]["CTXT03"].ToString();
						//txtTotal.Text = Convert.ToString((Convert.ToDecimal(txtBuild.Text) + Convert.ToDecimal(txtEquip.Text) + Convert.ToDecimal(txtOther.Text)));
						txtOwn.Text = ds1.Tables[0].Rows[i]["CTXT04"].ToString();
						txtLoan.Text = ds1.Tables[0].Rows[i]["CTXT05"].ToString();
						txtBank.Text = ds1.Tables[0].Rows[i]["CTXT06"].ToString();
						//txtTotal1.Text = Convert.ToString((Convert.ToDecimal(txtOwn.Text) + Convert.ToDecimal(txtLoan.Text) + Convert.ToDecimal(txtBank.Text)));
						Decimal val1 = 0;
						Decimal val2 = 0;
						Decimal val3 = 0;
						if (!string.IsNullOrEmpty(txtBuild.Text) && !string.IsNullOrEmpty(txtBuild.Text))
						{
							val1 = Convert.ToDecimal(txtBuild.Text);

						}
						if (!string.IsNullOrEmpty(txtEquip.Text) && !string.IsNullOrEmpty(txtEquip.Text))
						{
							val2 = Convert.ToDecimal(txtEquip.Text);
						}
						if (!string.IsNullOrEmpty(txtOther.Text) && !string.IsNullOrEmpty(txtOther.Text))
						{
							val3 = Convert.ToDecimal(txtOther.Text);
						}
						txtTotal.Text = Convert.ToString((val1 + val2 + val3));
						Decimal vall1 = 0;
						Decimal vall2 = 0;
						Decimal vall3 = 0;
						if (!string.IsNullOrEmpty(txtOwn.Text) && !string.IsNullOrEmpty(txtOwn.Text))
						{
							vall1 = Convert.ToDecimal(txtOwn.Text);

						}
						if (!string.IsNullOrEmpty(txtLoan.Text) && !string.IsNullOrEmpty(txtLoan.Text))
						{
							vall2 = Convert.ToDecimal(txtLoan.Text);
						}
						if (!string.IsNullOrEmpty(txtBank.Text) && !string.IsNullOrEmpty(txtBank.Text))
						{
							vall3 = Convert.ToDecimal(txtBank.Text);
						}
						txtTotal1.Text = Convert.ToString((vall1 + vall2 + vall3));
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
				string sqlTrunc = "DELETE FROM Cp_Cd111";
				OleDbDataAdapter myadapter = new OleDbDataAdapter();
				DataSet ds1 = new DataSet();
				String sql = "INSERT INTO Cp_Cd111 SELECT * FROM Cx_Cd111 WHERE CL_REFNO=" + Global.prtyCode;
				myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
				myadapter.Fill(ds1, "Cp_Cd111");
				myadapter.SelectCommand = new OleDbCommand(sql, conn);
				myadapter.Fill(ds1, "Cp_Cd111");
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
                lblAmt.Size = Global.lblSmall;
                lblAmt1.Size = Global.lblSmall;
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
			string sqlSelect = "SELECT * FROM Cp_Cd111 WHERE CL_REFNO=" + Global.prtyCode;

			OleDbDataAdapter myadapter = new OleDbDataAdapter();
			DataSet ds1 = new DataSet();
			myadapter.SelectCommand = new OleDbCommand(sqlSelect, con);
			myadapter.Fill(ds1, "Cp_Cd111");
			if (ds1.Tables[0].Rows.Count > 0)
			{
				sql = "update Cp_Cd111 set CTXT01='" + txtBuild.Text + "',CTXT02='" + txtEquip.Text + "',CTXT03='" + txtOther.Text + "',CTXT04='" + txtOwn.Text + "',CTXT05='" + txtLoan.Text + "',CTXT06='" + txtBank.Text + "' where CL_REFNO=" + Global.prtyCode;
			}
			else
			{
				sql = "insert into Cp_Cd111(CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CTXT06,CL_REFNO) values ('" + txtBuild.Text + "','" + txtEquip.Text + "','" + txtOther.Text + "','" + txtOwn.Text + "','" + txtLoan.Text + "','" + txtBank.Text + "'," + Global.prtyCode + ")";

			}
			myadapter.SelectCommand = new OleDbCommand(sql, con);
			myadapter.Fill(ds1, "Cp_Cd111");
			con.Close();
			DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
			if (dialogResult == DialogResult.Yes)
			{
				NotifyMainFormToCloseChildFormProposed();
				this.Hide();
			}
		}

		private void picFrmClose_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
			if (dialogResult == DialogResult.Yes)
			{
				NotifyMainFormToCloseChildFormProposed();
				this.Hide();
			}
		}

		private void txtBuild_TextChanged(object sender, EventArgs e)
		{
			Decimal val1 = 0;
			Decimal val2 = 0;
			Decimal val3 = 0;
			if (!string.IsNullOrEmpty(txtBuild.Text) && !string.IsNullOrEmpty(txtBuild.Text)){
				val1 = Convert.ToDecimal(txtBuild.Text);
				
		     }
			if (!string.IsNullOrEmpty(txtEquip.Text) && !string.IsNullOrEmpty(txtEquip.Text))
			{
				val2 = Convert.ToDecimal(txtEquip.Text);
			}
			if (!string.IsNullOrEmpty(txtOther.Text) && !string.IsNullOrEmpty(txtOther.Text))
			{
				val3 = Convert.ToDecimal(txtOther.Text);
			}
			txtTotal.Text = Convert.ToString((val1 + val2 + val3));
			//Convert.ToString((Convert.ToDecimal(txtBuild.Text) + Convert.ToDecimal(txtEquip.Text) + Convert.ToDecimal(txtOther.Text)));
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

        private void txtOwn_TextChanged(object sender, EventArgs e)
		{
			Decimal vall1 = 0;
			Decimal vall2 = 0;
			Decimal vall3 = 0;
			if (!string.IsNullOrEmpty(txtOwn.Text) && !string.IsNullOrEmpty(txtOwn.Text))
			{
				vall1 = Convert.ToDecimal(txtOwn.Text);

			}
			if (!string.IsNullOrEmpty(txtLoan.Text) && !string.IsNullOrEmpty(txtLoan.Text))
			{
				vall2 = Convert.ToDecimal(txtLoan.Text);
			}
			if (!string.IsNullOrEmpty(txtBank.Text) && !string.IsNullOrEmpty(txtBank.Text))
			{
				vall3 = Convert.ToDecimal(txtBank.Text);
			}
			txtTotal1.Text = Convert.ToString((vall1 + vall2 + vall3));
			
		}
	}
}
