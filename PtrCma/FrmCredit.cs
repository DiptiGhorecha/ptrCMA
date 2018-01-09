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
    public partial class FrmCredit : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormCredit;
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        public FrmCredit()
        {
            this.Visible = false;
            InitializeComponent();
        }

        private void FrmCredit_Load(object sender, EventArgs e)
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
                String sql = "select * from Cp_Cd109 WHERE CL_REFNO=" + Global.prtyCode;
               
                myadapter.SelectCommand = new OleDbCommand(sql, conn);
                myadapter.Fill(ds1, "Cp_Cd109");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        txtFCash.Text = ds1.Tables[0].Rows[i]["CTXT11"].ToString();
                        txtNCash.Text = ds1.Tables[0].Rows[i]["CTXT12"].ToString();
                        txtTCash.Text = ds1.Tables[0].Rows[i]["CTXT13"].ToString();
                        txtFCash1.Text = ds1.Tables[0].Rows[i]["CTXT14"].ToString();
                        txtNCash1.Text = ds1.Tables[0].Rows[i]["CTXT15"].ToString();
                        txtTCash1.Text = ds1.Tables[0].Rows[i]["CTXT16"].ToString();
                        txtFDraft.Text = ds1.Tables[0].Rows[i]["CTXT21"].ToString();
                        txtNDraft.Text = ds1.Tables[0].Rows[i]["CTXT22"].ToString();
                        txtTDraft.Text = ds1.Tables[0].Rows[i]["CTXT23"].ToString();
                        txtFDraft1.Text = ds1.Tables[0].Rows[i]["CTXT24"].ToString();
                        txtNDraft1.Text = ds1.Tables[0].Rows[i]["CTXT25"].ToString();
                        txtTDraft1.Text = ds1.Tables[0].Rows[i]["CTXT26"].ToString();

                        txtFPC.Text = ds1.Tables[0].Rows[i]["CTXT31"].ToString();
                        txtTPC.Text = ds1.Tables[0].Rows[i]["CTXT33"].ToString();
                        txtNPC.Text = ds1.Tables[0].Rows[i]["CTXT32"].ToString();
                        txtFPC1.Text = ds1.Tables[0].Rows[i]["CTXT34"].ToString();
                        txtTPC1.Text = ds1.Tables[0].Rows[i]["CTXT36"].ToString();
                        txtNPC1.Text = ds1.Tables[0].Rows[i]["CTXT35"].ToString();
                        txtFLC.Text = ds1.Tables[0].Rows[i]["CTXT41"].ToString();
                        txtTLC.Text = ds1.Tables[0].Rows[i]["CTXT43"].ToString();
                        txtNLC.Text = ds1.Tables[0].Rows[i]["CTXT42"].ToString();
                        txtFLC1.Text = ds1.Tables[0].Rows[i]["CTXT44"].ToString();
                        txtTLC1.Text = ds1.Tables[0].Rows[i]["CTXT46"].ToString();
                        txtNLC1.Text = ds1.Tables[0].Rows[i]["CTXT45"].ToString();
                        txtFTeam.Text = ds1.Tables[0].Rows[i]["CTXT51"].ToString();
                        txtTTeam.Text = ds1.Tables[0].Rows[i]["CTXT53"].ToString();
                        txtNTeam.Text = ds1.Tables[0].Rows[i]["CTXT52"].ToString();
                        txtFTeam1.Text = ds1.Tables[0].Rows[i]["CTXT54"].ToString();
                        txtTTeam1.Text = ds1.Tables[0].Rows[i]["CTXT56"].ToString();
                        txtNTeam1.Text = ds1.Tables[0].Rows[i]["CTXT55"].ToString();

                        txtFTotal.Text = ds1.Tables[0].Rows[i]["CTXT61"].ToString();
                        txtTTotal.Text = ds1.Tables[0].Rows[i]["CTXT63"].ToString();
                        txtNTotal.Text = ds1.Tables[0].Rows[i]["CTXT62"].ToString();
                        txtFTotal1.Text = ds1.Tables[0].Rows[i]["CTXT64"].ToString();
                        txtTTotal1.Text = ds1.Tables[0].Rows[i]["CTXT66"].ToString();
                        txtNTotal1.Text = ds1.Tables[0].Rows[i]["CTXT65"].ToString();
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
                lblRequired.Size = Global.lblSmall;
                lblExisting.Size = Global.lblSmall;
                lblFund.Size = Global.lblSmall;
                lblFund1.Size = Global.lblSmall;
                lblNFund.Size = Global.lblSmall;
                lblNFund1.Size = Global.lblSmall;
                lblT.Size = Global.lblSmall;
                lblT1.Size = Global.lblSmall;
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
            
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds1 = new DataSet();
            myadapter.SelectCommand = new OleDbCommand(sqlSelect, con);
            myadapter.Fill(ds1, "Cp_Cd109");
            String ctx11, ctx12 ,ctx13,ctx14,ctx15,ctx16,ctx21,ctx22,ctx23,ctx24,ctx25,ctx26,ctx31,ctx32,ctx33,ctx34,ctx35,ctx36,ctx41,ctx42,ctx43,ctx44,ctx45,ctx46,ctx51,ctx52,ctx53,ctx54,ctx55,ctx56,ctx61,ctx62,ctx63,ctx64,ctx65,ctx66= "";
            ctx11 = ((txtFCash.Text != null && txtFCash.Text.Trim() != String.Empty) ? txtFCash.Text : "Null");
            ctx12 = ((txtNCash.Text != null && txtNCash.Text.Trim() != String.Empty) ? txtNCash.Text.ToString() : "Null");
            ctx13 = ((txtTCash.Text != null && txtTCash.Text.Trim() != String.Empty) ? txtTCash.Text.ToString() : "Null");
            ctx14 = ((txtFCash1.Text != null && txtFCash1.Text.Trim() != String.Empty) ? txtFCash1.Text.ToString() : "Null");
            ctx15 = ((txtNCash1.Text != null && txtNCash1.Text.Trim() != String.Empty) ? txtNCash1.Text.ToString() : "Null");
            ctx16 = ((txtTCash1.Text != null && txtTCash1.Text.Trim() != String.Empty) ? txtTCash1.Text.ToString() : "Null");

            ctx21 = ((txtFDraft.Text != null && txtFDraft.Text.Trim() != String.Empty) ? txtFDraft.Text.ToString() : "Null");
            ctx22 = ((txtNDraft.Text != null && txtNDraft.Text.Trim() != String.Empty) ? txtNDraft.Text.ToString() : "Null");
            ctx23 = ((txtTDraft.Text != null && txtTDraft.Text.Trim() != String.Empty) ? txtTDraft.Text.ToString() : "Null");
            ctx24 = ((txtFDraft1.Text != null && txtFDraft1.Text.Trim() != String.Empty) ? txtFDraft1.Text.ToString() : "Null");
            ctx25 = ((txtNDraft1.Text != null && txtNDraft1.Text.Trim() != String.Empty) ? txtNDraft1.Text.ToString() : "Null");
            ctx26 = ((txtTDraft1.Text != null && txtTDraft1.Text.Trim() != String.Empty) ? txtTDraft1.Text.ToString() : "Null");

            ctx31 = ((txtFPC.Text != null && txtFPC.Text.Trim() != String.Empty) ? txtFPC.Text.ToString() : "Null");
            ctx32 = ((txtNPC.Text != null && txtNPC.Text.Trim() != String.Empty) ? txtNPC.Text.ToString() : "Null");
            ctx33 = ((txtTPC.Text != null && txtTPC.Text.Trim() != String.Empty) ? txtTPC.Text.ToString() : "Null");
            ctx34 = ((txtFPC1.Text != null && txtFPC1.Text.Trim() != String.Empty) ? txtFPC1.Text.ToString() : "Null");
            ctx35 = ((txtNPC1.Text != null && txtNPC1.Text.Trim() != String.Empty) ? txtNPC1.Text.ToString() : "Null");
            ctx36 = ((txtTPC1.Text != null && txtTPC1.Text.Trim() != String.Empty) ? txtTPC1.Text.ToString() : "Null");


            ctx41 = ((txtFLC.Text != null && txtFLC.Text.Trim() != String.Empty) ? txtFLC.Text.ToString() : "Null");
            ctx42 = ((txtNLC.Text != null && txtNLC.Text.Trim() != String.Empty) ? txtNLC.Text.ToString() : "Null");
            ctx43 = ((txtTLC.Text != null && txtTLC.Text.Trim() != String.Empty) ? txtTLC.Text.ToString() : "Null");
            ctx44 = ((txtFLC1.Text != null && txtFLC1.Text.Trim() != String.Empty) ? txtFLC1.Text.ToString() : "Null");
            ctx45 = ((txtNLC1.Text != null && txtNLC1.Text.Trim() != String.Empty) ? txtNLC1.Text.ToString() : "Null");
            ctx46 = ((txtTLC1.Text != null && txtTLC1.Text.Trim() != String.Empty) ? txtTLC1.Text.ToString() : "Null");

            ctx51 = ((txtFTeam.Text != null && txtFTeam.Text.Trim() != String.Empty) ? txtFTeam.Text.ToString() : "Null");
            ctx52 = ((txtNTeam.Text != null && txtNTeam.Text.Trim() != String.Empty) ? txtNTeam.Text.ToString() : "Null");
            ctx53 = ((txtTTeam.Text != null && txtTTeam.Text.Trim() != String.Empty) ? txtTTeam.Text.ToString() : "Null");
            ctx54 = ((txtFTeam1.Text != null && txtFTeam1.Text.Trim() != String.Empty) ? txtFTeam1.Text.ToString() : "Null");
            ctx55 = ((txtNTeam1.Text != null && txtNTeam1.Text.Trim() != String.Empty) ? txtNTeam1.Text.ToString() : "Null");
            ctx56 = ((txtTTeam1.Text != null && txtTTeam1.Text.Trim() != String.Empty) ? txtTTeam1.Text.ToString() : "Null");

            ctx61 = ((txtFTotal.Text != null && txtFTotal.Text.Trim() != String.Empty) ? txtFTotal.Text.ToString() : "Null");
            ctx62 = ((txtNTotal.Text != null && txtNTotal.Text.Trim() != String.Empty) ? txtNTotal.Text.ToString() : "Null");
            ctx63 = ((txtTTotal.Text != null && txtTTotal.Text.Trim() != String.Empty) ? txtTTotal.Text.ToString() : "Null");
            ctx64 = ((txtFTotal1.Text != null && txtFTotal1.Text.Trim() != String.Empty) ? txtFTotal1.Text.ToString() : "Null");
            ctx65 = ((txtNTotal1.Text != null && txtNTotal1.Text.Trim() != String.Empty) ? txtNTotal1.Text.ToString() : "Null");
            ctx66 = ((txtTTotal1.Text != null && txtTTotal1.Text.Trim() != String.Empty) ? txtTTotal1.Text.ToString() : "Null");


            if (ds1.Tables[0].Rows.Count > 0)
            {
                sql = "update Cp_Cd109 set CTXT11="+ ctx11+ ",CTXT12="+ ctx12+",CTXT13="+ctx13+",CTXT14="+ ctx14+",CTXT15="+ ctx15+",CTXT16="+ ctx16+",CTXT21="+ ctx21+",CTXT22="+ ctx22+",CTXT23="+ ctx23+",CTXT24="+ ctx24+",CTXT25="+ ctx25+",CTXT26="+ ctx26+",CTXT31=" + ctx31+",CTXT32=" + ctx32+",CTXT33=" + ctx33+",CTXT34=" + ctx34+",CTXT35=" + ctx35+",CTXT36=" + ctx36+",CTXT41=" + ctx41+",CTXT42="+ ctx42+",CTXT43="+ ctx43+",CTXT44="+ ctx44+",CTXT45="+ ctx45+",CTXT46="+ ctx46+",CTXT51="+ ctx51+",CTXT52="+ ctx52+",CTXT53="+ ctx53+",CTXT54="+ ctx54+",CTXT55="+ ctx55+",CTXT56="+ ctx56+",CTXT61="+ ctx61+",CTXT62="+ ctx62+",CTXT63="+ ctx63+",CTXT64="+ ctx64+",CTXT65="+ ctx65+",CTXT66="+ ctx66 + " where CL_REFNO=" + Global.prtyCode;
            }
            else {
                sql = "insert into Cp_Cd109(CTXT11,CTXT12,CTXT13,CTXT14,CTXT15,CTXT16,CTXT21,CTXT22,CTXT23,CTXT24,CTXT25,CTXT26,CTXT31,CTXT32,CTXT33,CTXT34,CTXT35,CTXT36,CTXT41,CTXT42,CTXT43,CTXT44,CTXT45,CTXT46,CTXT51,CTXT52,CTXT53,CTXT54,CTXT55,CTXT56,CTXT61,CTXT62,CTXT63,CTXT64,CTXT65,CTXT66,CL_REFNO) values (" + ctx11 + "," +ctx12 + "," + ctx13 + "," + ctx14 + "," + ctx15 + "," + ctx16 + "," + ctx21 + "," + ctx22 + "," + ctx23 + "," + ctx24 + "," + ctx25 + "," + ctx26 + "," + ctx31 + "," + ctx32 + "," + ctx33 + "," + ctx34 + "," + ctx35 + "," + ctx36 + "," + ctx41 + "," + ctx42 + "," + ctx43 + "," + ctx44 + "," + ctx45 + "," + ctx46 + "," + ctx51 + "," + ctx52 + "," + ctx53 + "," + ctx54 + "," + ctx55 + "," + ctx56 + "," + ctx61 + "," + ctx62 + "," + ctx63 + "," + ctx64 + "," + ctx65 + "," + ctx66 + "," + Global.prtyCode + ")";
             
            }
            myadapter.SelectCommand = new OleDbCommand(sql, con);
            myadapter.Fill(ds1, "Cp_Cd109");
            con.Close();
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormCredit();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormCredit();
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

        private void txtFTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
