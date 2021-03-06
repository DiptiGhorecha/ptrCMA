﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ADODB;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using unvell.ReoGrid;
using unvell.ReoGrid.DataFormat;
using System.Windows.Forms.DataVisualization.Charting;

namespace PtrCma
{
    public partial class FrmCMA : Form
    {

        public Action NotifyMainFormToCloseChildFormCma;
        //public Action NotifyMainFormToOpenChildFormCma;
        public Action NotifyMainFormToOpenChildFormDirector;
        public Action NotifyMainFormToOpenChildFormBanking;
        public Action NotifyMainFormToOpenChildFormCredit;
        public Action NotifyMainFormToOpenChildFormAssociate;
        public Action NotifyMainFormToOpenChildFormRegistration;
        public Action NotifyMainFormToOpenChildFormPosition;
        public Action NotifyMainFormToOpenChildFormPurchase;
        public Action NotifyMainFormToOpenChildFormSales;
        public Action NotifyMainFormToOpenChildFormBuyer;
        public Action NotifyMainFormToOpenChildFormParameter;
        public Action NotifyMainFormToOpenChildFormAssets;
        public Action NotifyMainFormToOpenChildFormProposed;
        public Action NotifyMainFormToOpenChildFormImmovable;
        public Action NotifyMainFormToOpenChildFormMovable;
        public Action NotifyMainFormToOpenChildFormGuarantor;
        public Action NotifyMainFormToOpenChildFormDeclaration;
        public Action NotifyMainFormToOpenChildFormDocuments;
        public Action NotifyMainFormToOpenChildFormYear;
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        OleDbTransaction transaction;
        ADODB.Recordset chkrs1;
        ADODB.Connection xconn;
        String isEdited = "n";
       // private Chart chart = new Chart();
        public FrmCMA()
        {
            InitializeComponent();
        }

       
        void gridViewCMA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = gridViewCMA.Rows[e.RowIndex].Cells[e.ColumnIndex];
            e.CellStyle.BackColor = Global.gridBackColorCMS;

            if (e.ColumnIndex == 1) {
               e.Value = Convert.ToString(e.Value).Substring(2, 2);
            }
            var list = new List<int> {13,14, 15, 16, 17, 18, 23, 30, 31, 35, 36, 37, 40, 41, 42, 44, 45};
            if (list.Contains(e.RowIndex))
            {
               e.CellStyle.ForeColor = Color.Green;
            }
        }
        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void gridViewCMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void gridViewCMA_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)

        {

            if (e.Control is TextBox) //If it is a DataGridViewTextBoxCell

            {

                (e.Control as TextBox).MaxLength =250; //Set the MaxLength to 4

            }

        }

        private void FrmCMA_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            if (isEdited == "n") { 
            
            this.KeyPreview = true; //To handle enter key
                Settings();
                //  ((DataGridViewTextBoxColumn) gridViewCMA.Columns[11]).MaxInputLength = 250;
                gridViewCMA.Visible = true;
              //  gridViewCMA.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(gridViewCMA_EditingControlShowing);
                grdViewCMAOther.Visible = false;
                txtPrtyName.Visible = true;
                txtPrtyName.Enabled = false;
                txtCurYear.Enabled = false;
                pnlInsRow.Visible = false;
                pnlGraph.Visible = false;
                pnlChartDet.Visible = false;
                pnlChangeDesc.Visible = false;
                comboBxYear.Enabled = false;
                comboBoxCopyYear.Enabled = false;
                comboBoxRsIn.Enabled = false;
                txtPrtyName.Text = Global.prtyName;
                //fillcombo();
                if (Global.curYr.Trim().Equals(""))
                {
                    comboBxYear.Text = "4";
                }
                else
                {
                    comboBxYear.Text = Global.curYr;
                }
                if (Global.inrS.Trim().Equals(""))
                {
                    
                    comboBoxRsIn.Text = "Rs";
                }
                else
                {
                    comboBoxRsIn.Text = Global.inrS;
                }
                ///////////////////////////////
                
                setControlSize();
                fillTopicListBox();
                lstViewTopic.Items[0].Selected = true;
                checkTables();
            
            }
        }
        private void FrmCMA_Shown(object sender, EventArgs e)
        {
            fillTempTable();
            fillCMSDataGrid();
            fillCMSReoDataGrid();
        }

        private void setControlSize()
        {
            lblPic.Size = Global.lblPicTitle;
        }

        public void Settings()
        {
           // TextBox.CheckForIllegalCrossThreadCalls = false;
            //txtCurYear.che
            this.BackgroundImage = Global.cmsFrmBackImg;
            // panelCmdBtns.BackgroundImage = Global.cmsFrmBackImg;
            this.Width = this.Parent.Width - 4;
            this.Height = this.Parent.Height - 105;

            this.picFrmClose.Top = 7;
            this.picFrmClose.Left = this.Width - this.picFrmClose.Width - 15;

            this.BackColor = Global.appBackColr;
            //Topic list box label
            // lstViewTopic.Top = 0;
            lstViewTopic.Left = this.Left + 1;
            lstViewTopic.Width = (this.Width - panelCmdBtns.Width - 10) / 2;
            lstViewTopic.Height = Global.chrtLstViewHeight;
            lstViewTopic.BackColor = Global.lstBxBackColorCMS;
            
            chart2.BackColor = Global.chartBackColorCMS;

            panelCmdBtns.Left = lstViewTopic.Right + 1;
            chart2.Left = panelCmdBtns.Right + 2;
            chart2.Width = (this.Width - panelCmdBtns.Width) / 2;
            chart2.Height = Global.chrtLstViewHeight;
            gridViewCMA.Width = this.Width - 3;

            gridViewCMA.Top = lstViewTopic.Bottom + 25;
            gridViewCMA.Height = this.Height - Global.chrtLstViewHeight - 50;
            gridViewCMA.Left = this.Left + 1;

            // Column Header Color of Gridview
            gridViewCMA.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;
            gridViewCMA.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            gridViewCMA.ColumnHeadersHeight = 30;
            gridViewCMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridViewCMA.EnableHeadersVisualStyles = false;

            gridViewCMA.RowsDefaultCellStyle.BackColor = Color.White;    // Row Color of Gridview

            ////////////////////////////////
            //grdViewCMAOther.Width = this.Width - 3;

            //grdViewCMAOther.Top = lstViewTopic.Bottom + 25;
            //grdViewCMAOther.Height = this.Height - Global.chrtLstViewHeight - 50;
            //grdViewCMAOther.Left = this.Left + 1;

            //// Column Header Color of Gridview
            //grdViewCMAOther.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;
            //grdViewCMAOther.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            //grdViewCMAOther.ColumnHeadersHeight = 30;
            //grdViewCMAOther.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //grdViewCMAOther.EnableHeadersVisualStyles = false;

           // grdViewCMAOther.RowsDefaultCellStyle.BackColor = Color.White;    // Row Color of Gridview
            pnlInsRow.BackgroundImage = Global.partyFrmBackImg;
            pnlInsRow.Location = new Point((this.Width - pnlInsRow.Width) / 2, ((this.Height - pnlInsRow.Height) / 2) + 20);
            pnlChangeDesc.BackgroundImage = Global.partyFrmBackImg;
            pnlChangeDesc.Location = new Point((this.Width - pnlChangeDesc.Width) / 2, ((this.Height - pnlChangeDesc.Height) / 2) + 20);

            pnlFormula.BackgroundImage = Global.partyFrmBackImg;
            pnlFormula.Location = new Point((this.Width - pnlFormula.Width) / 2, ((this.Height - pnlFormula.Height) / 2) + 20);

            pnlCopyYr.BackgroundImage = Global.partyFrmBackImg;
            pnlCopyYr.Location = new Point((this.Width - pnlChartDet.Width) / 2, ((this.Height - pnlChartDet.Height) / 2) + 20);
            pnlChartDet.Width = 800;
            pnlChartDet.Height = 400;
            //pnlChartDet.BackgroundImage = Global.partyFrmBackImg;
            pnlChartDet.Location = new Point((this.Width - pnlChartDet.Width) / 2, ((this.Height - pnlChartDet.Height) / 2) + 20);
            pictChartDet.Left = pnlChartDet.Width - 55;
            pictChartDet.Top = 10;   /// pnlChartDet.Top + 10;
            pictPrint.Left = pnlChartDet.Width - 95;
            pictPrint.Top = 10;   /// pnlChartDet.Top + 10;
            ///////////////////////////////
            var worksheet = grdReoCMAOther.CurrentWorksheet;
            grdReoCMAOther.Width = this.Width - 3;
            grdReoCMAOther.Top = lstViewTopic.Bottom + 25;
            grdReoCMAOther.Height = this.Height - Global.chrtLstViewHeight - 50;
            grdReoCMAOther.Left = this.Left + 1;
            setPanelControlColor();
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Pink, e.Bounds);
            e.DrawText();
        }
        private void setPanelControlColor()
        {
            foreach (Button btn in panelCmdBtns.Controls.OfType<Button>())   //Disable Textbox
            {
                if(btn.Name.Equals("cmdSave") || btn.Name.Equals("cmdCancel"))
                {
                    btn.BackgroundImage = Global.cmdBtnDisBack;
                }
                else
                {
                    btn.BackgroundImage = Global.cmdImg;
                }
                
                btn.ForeColor = Global.btnfore;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
            cmdSave.Enabled = false;
            cmdCancel.Enabled = false;
            foreach (Button btn in pnlInsRow.Controls.OfType<Button>())   //Disable Textbox
            {
                btn.BackgroundImage = Global.cmdImg;
                btn.ForeColor = Global.btnfore;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
            foreach (Label lbl in pnlInsRow.Controls.OfType<Label>())   //Disable Textbox
            {
                lbl.Font = Global.lblSize;
                lbl.Size = Global.lblsmallCredit;
                lbl.AutoSize = false;
                lbl.BackColor = Global.lblbackdetail;
                lbl.ForeColor = Global.lblforedetail;
            }

            foreach (TextBox txt in pnlInsRow.Controls.OfType<TextBox>())  //Set Size of TextBox
            {
                txt.Font = Global.txtSize;
                if (txt.Name.Equals("txtDesc")){
                    //txt.Size = Global.medsizelbl;
                }
                else
                {
                    txt.Size = Global.txtsmall;
                }
                
                txt.AutoSize = false;
            }

            foreach (Button btn in pnlChangeDesc.Controls.OfType<Button>())   //Disable Textbox
            {
                btn.BackgroundImage = Global.cmdImg;
                btn.ForeColor = Global.btnfore;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
            foreach (Label lbl in pnlChangeDesc.Controls.OfType<Label>())   //Disable Textbox
            {
                lbl.Font = Global.lblSize;
                lbl.Size = Global.lblsmallCredit;
                lbl.AutoSize = false;
                lbl.BackColor = Global.lblbackdetail;
                lbl.ForeColor = Global.lblforedetail;
            }

            foreach (TextBox txt in pnlChangeDesc.Controls.OfType<TextBox>())  //Set Size of TextBox
            {
                txt.Font = Global.txtSize;
                if (txt.Name.Equals("txtDescChangeDesc"))
                {
                    //txt.Size = Global.medsizelbl;
                }
                else
                {
                    txt.Size = Global.txtsmall;
                }

                txt.AutoSize = false;
            }


            foreach (Button btn in pnlFormula.Controls.OfType<Button>())   //Disable Textbox
            {
                btn.BackgroundImage = Global.cmdImg;
                btn.ForeColor = Global.btnfore;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
            foreach (Label lbl in pnlFormula.Controls.OfType<Label>())   //Disable Textbox
            {
                lbl.Font = Global.lblSize;
             //   lbl.Size = Global.lblsmallCredit;
                lbl.AutoSize = false;
                lbl.BackColor = Global.lblbackdetail;
                lbl.ForeColor = Global.lblforedetail;
            }

            foreach (TextBox txt in pnlFormula.Controls.OfType<TextBox>())  //Set Size of TextBox
            {
                txt.Font = Global.txtSize;
                if (txt.Name.Equals("txtFormula"))
                {
                    //txt.Size = Global.medsizelbl;
                }
                else
                {
                    txt.Size = Global.txtsmall;
                }

                txt.AutoSize = false;
            }


            foreach (Button btn in pnlCopyYr.Controls.OfType<Button>())   //Disable Textbox
            {
                btn.BackgroundImage = Global.cmdImg;
                btn.ForeColor = Global.btnfore;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
            foreach (Label lbl in pnlCopyYr.Controls.OfType<Label>())   //Disable Textbox
            {
                lbl.Font = Global.lblSize;
                //   lbl.Size = Global.lblsmallCredit;
                lbl.AutoSize = false;
                lbl.BackColor = Global.lblbackdetail;
                lbl.ForeColor = Global.lblforedetail;
            }

            foreach (TextBox txt in pnlCopyYr.Controls.OfType<TextBox>())  //Set Size of TextBox
            {
                txt.Font = Global.txtSize;
                if (txt.Name.Equals("txtFormula"))
                {
                    //txt.Size = Global.medsizelbl;
                }
                else
                {
                    txt.Size = Global.txtsmall;
                }

                txt.AutoSize = false;
            }
            picFrmClose.BackColor = System.Drawing.Color.FromArgb(124,236,246);
            //picFrmClose.BackColor = System.Drawing.Color.Transparent;
        }

        private void checkTables()
        {try
            {
                OleDbConnection conn = GetConnection();
                OleDbDataAdapter myadapter = new OleDbDataAdapter();

                DataSet ds = new DataSet();
                String STR = "Select * from Cx_CdFm1 where CM_CLREFNO=" + Global.prtyCode + "";
                myadapter.SelectCommand = new OleDbCommand("Select * from Cx_CdFm1 where CM_CLREFNO=" + Global.prtyCode + "", conn);
                myadapter.Fill(ds, "Cx_CdFm1");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    OleDbDataAdapter myadapter1 = new OleDbDataAdapter();
                    DataSet ds1 = new DataSet();
                    String sql = "Update Cp_CdFm11 set [CM_CLREFNO]=" + Global.prtyCode + ";";
                    myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                    myadapter1.Fill(ds1, "Cp_CdFm11");
                    sql = "SELECT * FROM Cp_CdFm11 WHERE [CM_CLREFNO]=" + Global.prtyCode + ";";
                    myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                    myadapter1.Fill(ds1, "Cp_CdFm11");
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql = "INSERT INTO Cx_CdFm1 (CM_SEQNO,CM_TYPE,CM_FC,CM_BN,CM_DBNO,CM_MTNO,CM_HEAD,CM_DESC,CM_LNKFRM,CM_CLREFNO) values ('"+ds1.Tables[0].Rows[i]["CM_SEQNO"].ToString()+ "','" + ds1.Tables[0].Rows[i]["CM_TYPE"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_FC"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_BN"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_DBNO"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_MTNO"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_HEAD"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_DESC"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_LNKFRM"].ToString() + "'," + ds1.Tables[0].Rows[i]["CM_CLREFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                        myadapter1.Fill(ds2, "Cx_CdFm1");
                        ds2.Dispose();
                    }



                  //'  sql = "INSERT INTO Cp_CdFm1 SELECT CM_SEQNO,CM_TYPE,CM_FC,CM_BN,CM_DBNO,CM_MTNO,CM_HEAD,CM_DESC,CM_LNKFRM,CM_CLREFNO FROM Cp_CdFm11";
                  //'  myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                 // '  myadapter1.Fill(ds1, "Cp_CdFm11");
                    ds1.Dispose();





                        Calendar myCal = CultureInfo.InvariantCulture.Calendar;
                    txtCurYear.Text = DateTime.Now.Year + "-" + Convert.ToString(myCal.AddYears(DateTime.Now, 1).Year).Substring(2, 2);
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = connectionString;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);


                    String sql1 = "INSERT INTO Cx_Cd120 (CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CTXT06,CTXT07,CTXT08,CTXT09,CTXT10,CTXT11,CTXT12,CL_REFNO) VALUES ('" + DateTime.Now.Year + "-" + myCal.AddYears(DateTime.Now, 1).Year + "','" + myCal.AddYears(DateTime.Now, 1).Year + "-" + myCal.AddYears(DateTime.Now, 2).Year + "' , '" + myCal.AddYears(DateTime.Now, 2).Year + "-" + myCal.AddYears(DateTime.Now, 3).Year + "' , '" + myCal.AddYears(DateTime.Now, 3).Year + "-" + myCal.AddYears(DateTime.Now, 4).Year + "' , '" + myCal.AddYears(DateTime.Now, 4).Year + "-" + myCal.AddYears(DateTime.Now, 5).Year + "' , '" + myCal.AddYears(DateTime.Now, 5).Year + "-" + myCal.AddYears(DateTime.Now, 6).Year + "' , '" + myCal.AddYears(DateTime.Now, 6).Year + "-" + myCal.AddYears(DateTime.Now, 7).Year + "' , '" + myCal.AddYears(DateTime.Now, 7).Year + "-" + myCal.AddYears(DateTime.Now, 8).Year + "' , '" + myCal.AddYears(DateTime.Now, 8).Year + "-" + myCal.AddYears(DateTime.Now, 9).Year + "' , '" + myCal.AddYears(DateTime.Now, 9).Year + "-" + myCal.AddYears(DateTime.Now, 10).Year + "' , '" + myCal.AddYears(DateTime.Now, 10).Year + "-" + myCal.AddYears(DateTime.Now, 11).Year + "' , '" + myCal.AddYears(DateTime.Now, 11).Year + "-" + myCal.AddYears(DateTime.Now, 12).Year + "'," + Global.prtyCode + ")";

                    OleDbCommand cmd = new OleDbCommand(sql1, con);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    ds.Dispose();
                    conn.Close();
                }
                else
                {
                    xconn = new ADODB.Connection();
                    xconn.Open("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;", "", "", -1);
                    ADODB.Recordset chkrs1 = new ADODB.Recordset();
                    String stttr = "SELECT * FROM Cx_Cd120 where CL_REFNO=" + Global.prtyCode;
                    chkrs1.Open("SELECT * FROM Cx_Cd120 where CL_REFNO=" + Global.prtyCode, xconn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, 0);
                   
                  //  MessageBox.Show(chkrs1.Fields[0].Value.Substring(0, 7));
                    if (chkrs1.EOF == false)
                    {
                       
                       txtCurYear.Text = chkrs1.Fields[0].Value.Substring(0, 5) + chkrs1.Fields[0].Value.Substring(7, 2);
                        //txtCurYear.Text = chkrs1.Fields[0].Value;

                    }
                    chkrs1.Close();
                    xconn.Close();

                }

                ///////fm3

                DataSet ds4 = new DataSet();
                String STROther = "Select * from Cx_CdFm3 where FM_CLREFNO=" + Global.prtyCode + "";
                myadapter.SelectCommand = new OleDbCommand("Select * from Cx_CdFm3 where FM_CLREFNO=" + Global.prtyCode + "", conn);
                myadapter.Fill(ds4, "Cx_CdFm3");
                if (ds4.Tables[0].Rows.Count == 0)
                {
                    DataSet ds3 = new DataSet();
                    OleDbDataAdapter myadapter1 = new OleDbDataAdapter();
                    String sqlother = "Update Cp_CdFm33 set [FM_CLREFNO]=" + Global.prtyCode + ";";
                    myadapter1.SelectCommand = new OleDbCommand(sqlother, conn);
                    myadapter1.Fill(ds3, "Cp_CdFm33");
                    sqlother = "SELECT * FROM Cp_CdFm33 WHERE [FM_CLREFNO]=" + Global.prtyCode + ";";
                    myadapter1.SelectCommand = new OleDbCommand(sqlother, conn);
                    myadapter1.Fill(ds3, "Cp_CdFm33");
                    for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds22 = new DataSet();
                        String sql = "INSERT INTO Cx_CdFm3 (FM_SEQNO,FM_TYPE,FM_FC,FM_BN,FM_MTNO,FM_SNO1,FM_SNO2,FM_CV,FM_FORM,FM_ADDROW,FM_TOTROW,FM_DESC,FM_CLREFNO,FM_FOLIST,FM_FO01,FM_FO02,FM_FO03,FM_FO04,FM_FO05,FM_FO06,FM_FO07,FM_FO08,FM_FO09,FM_FO10,FM_FO11,FM_FO12) values ('" + ds3.Tables[0].Rows[i]["FM_SEQNO"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_TYPE"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FC"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_BN"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_MTNO"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_SNO1"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_SNO2"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_CV"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FORM"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_ADDROW"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_TOTROW"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_DESC"].ToString() + "'," + ds3.Tables[0].Rows[i]["FM_CLREFNO"].ToString() + ",'" + ds3.Tables[0].Rows[i]["FM_FOLIST"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO01"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO02"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO03"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO04"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO05"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO06"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO07"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO08"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO09"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO10"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO11"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO12"].ToString() + "')";
                        myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                        myadapter1.Fill(ds22, "Cx_CdFm3");
                        ds22.Dispose();
                    }



                    //'  sql = "INSERT INTO Cp_CdFm1 SELECT CM_SEQNO,CM_TYPE,CM_FC,CM_BN,CM_DBNO,CM_MTNO,CM_HEAD,CM_DESC,CM_LNKFRM,CM_CLREFNO FROM Cp_CdFm11";
                    //'  myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                    // '  myadapter1.Fill(ds1, "Cp_CdFm11");
                    ds4.Dispose();
                    ds3.Dispose();
                }////////fm3

                }
            catch (Exception e)
            {
              //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }

        private static OleDbConnection GetConnection()
        {
            OleDbConnection conn = new OleDbConnection();
            try
            {
                String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";
                conn = new OleDbConnection(connectionString);
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
        }

        private static void CloseConnection(OleDbConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void fillTempTable()
        {try { 
            OleDbConnection conn = new OleDbConnection(connectionString);
                string sqlTrunc = "DELETE FROM Cp_CdFm1";
    
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds1 = new DataSet();
            String sql = "INSERT INTO Cp_CdFm1 SELECT * FROM Cx_CdFm1 where CM_CLREFNO=" + Global.prtyCode;
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds1, "Cp_CdFm1");
                myadapter.SelectCommand = new OleDbCommand(sql, conn);
            myadapter.Fill(ds1, "Cp_CdFm1");

                string sqlTruncOther = "DELETE FROM Cp_CdFm3";

                
                String sqlOther = "INSERT INTO Cp_CdFm3 SELECT * FROM Cx_CdFm3 where FM_CLREFNO=" + Global.prtyCode;
                myadapter.SelectCommand = new OleDbCommand(sqlTruncOther, conn);
                myadapter.Fill(ds1, "Cp_CdFm3");
                myadapter.SelectCommand = new OleDbCommand(sqlOther, conn);
                myadapter.Fill(ds1, "Cp_CdFm3");

                ds1.Dispose();
            conn.Close();
        }
            catch (Exception e)
            {
              //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
}
        private void fillCMSDataGrid()
        {

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            myadapter.SelectCommand = new OleDbCommand("Select * from Cp_CdFm1 where CM_CLREFNO=" + Global.prtyCode+" order by CM_SEQNO", conn);
            myadapter.Fill(ds, "Cp_CdFm1");
            gridViewCMA.DataMember = "Cp_CdFm1";
            gridViewCMA.DataSource = ds;
            conn.Close();
            for(int i = 0 ; i<=gridViewCMA.Columns.Count - 1;i++){
                gridViewCMA.Columns[i].ReadOnly = true;
                gridViewCMA.Columns[i].Visible = false;
                    }
            gridViewCMA.Columns[1].Visible = true;
            gridViewCMA.Columns[1].HeaderText = "Sr. No.";
            gridViewCMA.Columns[1].Width = 100;

            gridViewCMA.Columns[8].Visible = true;
            gridViewCMA.Columns[8].HeaderText = "Description";
            gridViewCMA.Columns[8].Width = ((gridViewCMA.Width-100)*70)/100;

            gridViewCMA.Columns[11].Visible = true;
            gridViewCMA.Columns[11].ReadOnly = false;
            gridViewCMA.Columns[11].HeaderText = "Data";
            gridViewCMA.Columns[11].Width = ((gridViewCMA.Width-100)*30)/100;

            gridViewCMA.Refresh();
        }

        private void fillCMSReoDataGrid()
        {
            try {
                ControlAppearanceStyle rgcs = new ControlAppearanceStyle(Global.grdPartyBackColor, Color.Gray, false);
                rgcs[ControlAppearanceColors.ColHeadText] = Global.grdPartyForeColor;
                rgcs[ControlAppearanceColors.GridBackground] = Global.gridBackColorCMS;
                grdReoCMAOther.CurrentWorksheet.SelectionForwardDirection = SelectionForwardDirection.Down;
                grdReoCMAOther.ControlStyle = rgcs;
                grdReoCMAOther.CurrentWorksheet.SetSettings(WorksheetSettings.Formula_AutoUpdateReferenceCell, true);
                grdReoCMAOther.CurrentWorksheet.SetSettings(WorksheetSettings.Formula_AutoPickingCellAddress, true);
                grdReoCMAOther.CurrentWorksheet.SetSettings(WorksheetSettings.Formula_AutoFormat, true);
                OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            myadapter.SelectCommand = new OleDbCommand("Select * from Cp_CdFm3 where FM_CLREFNO=" + Global.prtyCode + " order by FM_SEQNO", conn);
            myadapter.Fill(ds, "Cp_CdFm3");
            //   grdReoCMAOther.CurrentWorksheet = ds.Tables[0];
            grdReoCMAOther.CurrentWorksheet.RowCount = ds.Tables[0].Rows.Count;
            grdReoCMAOther.CurrentWorksheet.ColumnCount = ds.Tables[0].Columns.Count;
            var list = new List<int> { 18,19,20,21 };
                var listRow = new List<int> { 0, 8, 39, 43, 55, 56, 75, 84, 112, 134, 138, 159, 190, 210, 217, 225, 251, 264, 275, 284, 291, 305, 306, 307, 317, 327, 337 };
                var listCol = new List<int> { 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41 };
                var listn = new List<int> { 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 };
                for (int row = 0; row < ds.Tables[0].Rows.Count; row++)
            {
                for (int col = 0; col < ds.Tables[0].Columns.Count; col++)
                {
                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[row][col])))
                        {
                            grdReoCMAOther.CurrentWorksheet.SetCellData(row, col, ds.Tables[0].Rows[row][col]);
                        }
                        else
                        {
                            if (listn.Contains(col))
                                grdReoCMAOther.CurrentWorksheet.SetCellData(row, col+12, Convert.ToDouble("0.00"));
                        }
                }
            }
            var range = grdReoCMAOther.CurrentWorksheet.Ranges["A1:AN1"];
            range = grdReoCMAOther.CurrentWorksheet.Ranges["A1:AN348"];
            grdReoCMAOther.CurrentWorksheet.HideColumns(0, 1);
            grdReoCMAOther.CurrentWorksheet.HideColumns(2,4);
            grdReoCMAOther.CurrentWorksheet.HideColumns(8, 4);
            grdReoCMAOther.CurrentWorksheet.HideColumns(13, 29);

            grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(1, 1, 100);
            grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(6, 2, 50);
            ushort ggd =(ushort)((grdReoCMAOther.Width - 220) - (120 * Convert.ToInt16(comboBxYear.Text))-40);
            grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(12, 1,ggd);
            String frmula1= "AE2+AE3";
            grdReoCMAOther.CurrentWorksheet.ColumnHeaders["B"].Text = "";
            grdReoCMAOther.CurrentWorksheet.ColumnHeaders["G"].Text = "";
            grdReoCMAOther.CurrentWorksheet.ColumnHeaders["H"].Text = "";
            grdReoCMAOther.CurrentWorksheet.ColumnHeaders["I"].Text = "";
            grdReoCMAOther.CurrentWorksheet.ColumnHeaders["M"].Text="Description";
            /////////////////////////
            String sql2 = "SELECT * FROM Cx_Cd120 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
            DataSet ds1 = new DataSet();
            myadapter.SelectCommand = new OleDbCommand(sql2, conn);
            myadapter.Fill(ds1, "Cx_Cd120");
            int counter = 30;
            if (ds1.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {

                    for (int ii = 1; ii <= Convert.ToInt16(comboBxYear.Text); ii++)
                    {
                        
                        switch (ii)
                        {
                            case 1:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(30, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AE"].Text = ds1.Tables[0].Rows[i]["CTXT01"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(30, 1, 120);
                                break;
                            case 2:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(31, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AF"].Text = ds1.Tables[0].Rows[i]["CTXT02"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(31, 1, 120);
                                break;
                            case 3:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(32, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AG"].Text = ds1.Tables[0].Rows[i]["CTXT03"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(32, 1, 120);
                                break;
                            case 4:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(33, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AH"].Text = ds1.Tables[0].Rows[i]["CTXT04"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(33, 1, 120);
                                break;
                            case 5:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(34, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AI"].Text = ds1.Tables[0].Rows[i]["CTXT05"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(34, 1, 120);
                                break;
                            case 6:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(35, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AJ"].Text = ds1.Tables[0].Rows[i]["CTXT06"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(35, 1, 120);
                                break;
                            case 7:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(36, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AK"].Text = ds1.Tables[0].Rows[i]["CTXT07"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(36, 1, 120);
                                break;
                            case 8:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(37, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AL"].Text = ds1.Tables[0].Rows[i]["CTXT08"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(37, 1, 120);
                                break;
                            case 9:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(38, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AM"].Text = ds1.Tables[0].Rows[i]["CTXT09"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(38, 1, 120);
                                break;
                            case 10:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(39, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AN"].Text = ds1.Tables[0].Rows[i]["CTXT10"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(39, 1, 120);
                                break;
                            case 11:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(40, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AO"].Text = ds1.Tables[0].Rows[i]["CTXT11"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(40, 1, 120);
                                break;
                            case 12:
                                grdReoCMAOther.CurrentWorksheet.ShowColumns(41, 1);
                                grdReoCMAOther.CurrentWorksheet.ColumnHeaders["AP"].Text = ds1.Tables[0].Rows[i]["CTXT12"].ToString();
                                grdReoCMAOther.CurrentWorksheet.SetColumnsWidth(41, 1, 120);
                                break;
                            default:
                                break;
                        }
                        counter = counter + 1;
                    }
                }
            }

                for (int row = 0; row < grdReoCMAOther.CurrentWorksheet.RowCount; row++)
                {
                   // MessageBox.Show(Convert.ToString(grdReoCMAOther.CurrentWorksheet.ColumnCount));
                    for (int col = 0; col < grdReoCMAOther.CurrentWorksheet.ColumnCount; col++)
                    {
                        if (list.Contains(col))
                        {
                            String MM = (String)grdReoCMAOther.CurrentWorksheet.GetCellData(row, col);
                            if (!string.IsNullOrEmpty(MM))
                            {
                                grdReoCMAOther.CurrentWorksheet.SetCellFormula(row, (col + 12), MM);
                                var cell = grdReoCMAOther.CurrentWorksheet.GetCell(row, col + 12);
                                cell.Style.TextColor = Color.Magenta;
                            }
                        }
                        if (listCol.Contains(col))
                        {
                            if (Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(row, 3)).Equals("Gr") && col <= (30 + Convert.ToInt16(comboBxYear.Text)))
                            {
                                var cell = grdReoCMAOther.CurrentWorksheet.GetCell(row, col);
                                cell.Style.BackColor = Color.Gray;
                                cell.Data = "";
                            }
                        }
                    }
                }

                grdReoCMAOther.CurrentWorksheet.SetRangeDataFormat("AE0:AP348", CellDataFormatFlag.Number,
  new NumberDataFormatter.NumberFormatArgs()
  {
      // decimal digit places, e.g. 0.1234
      DecimalPlaces = 2,

      // negative number style, e.g. -123 -> (123) 
      NegativeStyle = NumberDataFormatter.NumberNegativeStyle.RedBrackets,

      // use separator, e.g.123,456
      UseSeparator = false,
  });
               
                ds1.Dispose();
           
            ////////////////////////

            // colHeader.Text = "Year-1";
            ///(0, 12, 100);
            ds.Dispose();
            conn.Close();
            }
            catch (Exception e)
            {
                //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }
        private void fillCMSOtherDataGrid()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                myadapter.SelectCommand = new OleDbCommand("Select * from Cp_CdFm3 where FM_CLREFNO=" + Global.prtyCode + " order by FM_SEQNO", conn);
                myadapter.Fill(ds, "Cp_CdFm3");
                grdViewCMAOther.DataMember = "Cp_CdFm3";
                grdViewCMAOther.DataSource = ds;
                conn.Close();
                for (int i = 0; i <= grdViewCMAOther.Columns.Count - 1; i++)
                {
                    grdViewCMAOther.Columns[i].ReadOnly = true;
                    grdViewCMAOther.Columns[i].Visible = false;
                }
                grdViewCMAOther.Columns[1].Visible = true;
                grdViewCMAOther.Columns[1].HeaderText = " ";
                grdViewCMAOther.Columns[1].Width = 100;

                grdViewCMAOther.Columns[6].Visible = true;
                grdViewCMAOther.Columns[6].HeaderText = " ";
                grdViewCMAOther.Columns[6].Width = 50;

                grdViewCMAOther.Columns[7].Visible = true;
                grdViewCMAOther.Columns[7].HeaderText = " ";
                grdViewCMAOther.Columns[7].Width = 50;

                grdViewCMAOther.Columns[12].Visible = true;
                grdViewCMAOther.Columns[12].ReadOnly = true;
                grdViewCMAOther.Columns[12].HeaderText = "Description";
                grdViewCMAOther.Columns[12].Width = ((grdViewCMAOther.Width - 200) - (120 * Convert.ToInt16(comboBxYear.Text)));

                String sql2 = "SELECT * FROM Cx_Cd120 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                DataSet ds1 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter.Fill(ds1, "Cx_Cd120");
                int counter = 30;
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        for (int ii = 1; ii <= Convert.ToInt16(comboBxYear.Text); ii++)
                        {
                            grdViewCMAOther.Columns[counter].Visible = true;
                            grdViewCMAOther.Columns[counter].ReadOnly = false;
                            grdViewCMAOther.Columns[counter].HeaderText = "Description";
                            grdViewCMAOther.Columns[counter].Width = 120;
                            switch (ii)
                            {
                                case 1:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT01"].ToString();
                                    break;
                                case 2:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT02"].ToString();
                                    break;
                                case 3:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT03"].ToString();
                                    break;
                                case 4:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT04"].ToString();
                                    break;
                                case 5:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT05"].ToString();
                                    break;
                                case 6:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT06"].ToString();
                                    break;
                                case 7:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT07"].ToString();
                                    break;
                                case 8:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT08"].ToString();
                                    break;
                                case 9:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT09"].ToString();
                                    break;
                                case 10:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT10"].ToString();
                                    break;
                                case 11:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT11"].ToString();
                                    break;
                                case 12:
                                    grdViewCMAOther.Columns[counter].HeaderText = ds1.Tables[0].Rows[i]["CTXT12"].ToString();
                                    break;
                                default:
                                    break;
                            }
                            counter = counter + 1;
                        }
                    }
                }

                ds.Dispose();
                ds1.Dispose();
                conn.Close();
                grdViewCMAOther.Refresh();
            }
            catch (Exception e)
            {
                //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }


        private void fillTopicListBox()
        {
            lstViewTopic.View = View.Details;
            lstViewTopic.GridLines = true;
            lstViewTopic.FullRowSelect = true;
            System.Windows.Forms.ColumnHeader header1;
            header1 = new System.Windows.Forms.ColumnHeader();
            lstViewTopic.Columns.Clear();
            // Set the text, alignment and width for each column header.
            header1.Text = "Select Topic";
            header1.TextAlign = HorizontalAlignment.Center;
            
            header1.Width = lstViewTopic.Width - 19;
            lstViewTopic.Columns.Add(header1);
            //Add items in the listview

            lstViewTopic.Items.Add("Party Information");
            lstViewTopic.Items.Add("Operating Statement");
            lstViewTopic.Items.Add("Liability Statement");
            lstViewTopic.Items.Add("Assets Statement");
            lstViewTopic.Items.Add("Valid");
            lstViewTopic.Items.Add("Financial Indicators");
            lstViewTopic.Items.Add("WCC");
            lstViewTopic.Items.Add("ABF Assessements");
            lstViewTopic.Items.Add("Fundflow Statement");
            lstViewTopic.Items.Add("Assessement of working capital required");
            lstViewTopic.Items.Add("As per Nayak Comitee");
            lstViewTopic.Items.Add("Calculation of Drawing power");
        }

        private void FillYrListBox()
        {
            try
            {
                xconn = new ADODB.Connection();
                xconn.Open("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;", "", "", -1);
                ADODB.Recordset chkrs1 = new ADODB.Recordset();
                String stttr = "SELECT * FROM Cx_Cd120 where CL_REFNO=" + Global.prtyCode;
                chkrs1.Open("SELECT * FROM Cx_Cd120 where CL_REFNO=" + Global.prtyCode, xconn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, 0);

                while (chkrs1.EOF == false)
                {
                   
                    grdViewFormula.Columns[2].HeaderText = chkrs1.Fields[0].Value.Substring(0, 5);
                    grdViewYr.Rows.Add(chkrs1.Fields[0].Value.Substring(0, 5) + chkrs1.Fields[0].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[1].Value.Substring(0, 5) + chkrs1.Fields[1].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[2].Value.Substring(0, 5) + chkrs1.Fields[2].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[3].Value.Substring(0, 5) + chkrs1.Fields[3].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[4].Value.Substring(0, 5) + chkrs1.Fields[4].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[5].Value.Substring(0, 5) + chkrs1.Fields[5].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[6].Value.Substring(0, 5) + chkrs1.Fields[6].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[7].Value.Substring(0, 5) + chkrs1.Fields[7].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[8].Value.Substring(0, 5) + chkrs1.Fields[8].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[9].Value.Substring(0, 5) + chkrs1.Fields[9].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[10].Value.Substring(0, 5) + chkrs1.Fields[10].Value.Substring(7, 2));
                    grdViewYr.Rows.Add(chkrs1.Fields[11].Value.Substring(0, 5) + chkrs1.Fields[11].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[1].Value.Substring(0, 5) + chkrs1.Fields[1].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[2].Value.Substring(0, 5) + chkrs1.Fields[2].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[3].Value.Substring(0, 5) + chkrs1.Fields[3].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[4].Value.Substring(0, 5) + chkrs1.Fields[4].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[5].Value.Substring(0, 5) + chkrs1.Fields[5].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[6].Value.Substring(0, 5) + chkrs1.Fields[6].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[7].Value.Substring(0, 5) + chkrs1.Fields[7].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[8].Value.Substring(0, 5) + chkrs1.Fields[8].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[9].Value.Substring(0, 5) + chkrs1.Fields[9].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[10].Value.Substring(0, 5) + chkrs1.Fields[10].Value.Substring(7, 2));
                    //lstViewYr.Items.Add(chkrs1.Fields[11].Value.Substring(0, 5) + chkrs1.Fields[11].Value.Substring(7, 2));

                    //txtCurYear.Text = chkrs1.Fields[0].Value;
                    if (chkrs1.EOF == false)
                    {
                        chkrs1.MoveNext();
                    }
                }
                chkrs1.Close();
                xconn.Close();
                
                pnlFormula.Refresh();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
}
        private void cmdEdit_Click(object sender, EventArgs e)
        {
            isEdited = "y";
            cmdSave.Enabled =true;
            cmdCancel.Enabled = true;

            if (lstViewTopic.SelectedItems[0].Text.Equals("Party Information"))
            {
                gridViewCMA.CurrentCell = gridViewCMA.Rows[0].Cells[11];
            }
            else
            {
               // grdViewCMAOther.CurrentCell = grdViewCMAOther.Rows[0].Cells[30];

                txtCurYear.Enabled = true;
                comboBxYear.Enabled = true;
                comboBoxCopyYear.Enabled = true;
                comboBoxRsIn.Enabled = true;
                cmdInsRow.Enabled = true;
                cmdDelRow.Enabled = true;
                cmdChngDesc.Enabled = true;
                cmdFormula.Enabled = true;
                cmdResetDeta.Enabled = true;
                cmdCopyYr.Enabled = true;
            }

        }
        private void fillcombo()
        {
            try {
                if (InvokeRequired)
                {
                    MethodInvoker method = new MethodInvoker(fillcombo);
                    Invoke(method);
                    return;
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
           
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds1 = new DataSet();
            
            String sql2 = "SELECT CL_YEARS,CL_RSIN FROM Cd_MsCln where CL_REFNO=" + Global.prtyCode;
            myadapter.SelectCommand = new OleDbCommand(sql2, conn);
            myadapter.Fill(ds1, "Cd_MsCln");
            if (ds1.Tables[0].Rows.Count > 0)
            {
               // for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
               // {
     
                //    comboBoxRsIn.Invoke(new Action(() => comboBoxRsIn.Text = ds1.Tables[0].Rows[0]["CL_RSIN"].ToString()));
                  //  comboBxYear.Invoke(new Action(() => comboBoxRsIn.Text = ds1.Tables[0].Rows[0]["CL_YEARS"].ToString()));
                    comboBoxRsIn.Text = ds1.Tables[0].Rows[0]["CL_RSIN"].ToString();
                   comboBxYear.Text = ds1.Tables[0].Rows[0]["CL_YEARS"].ToString();
               // }
            }

            ds1.Dispose();

            conn.Close();
                if (comboBoxRsIn.Text.Trim().Equals(""))
                {
                    comboBoxRsIn.Text = "Rs";
                }
                if (comboBxYear.Text.Trim().Equals(""))
                {
                    comboBxYear.Text = "4";
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

}

private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                isEdited = "n";
                cmdSave.Enabled = false;
                cmdCancel.Enabled = false;
                String refno = "";

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = connectionString;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                transaction = con.BeginTransaction(IsolationLevel.ReadCommitted);
                for (int i = 0; i <= gridViewCMA.Rows.Count - 1; i++)
                {
                    refno = Convert.ToString(gridViewCMA.Rows[i].Cells[0].Value);


                    String sql = "update Cp_CdFm1 set CM_DATA='" + Convert.ToString(gridViewCMA.Rows[i].Cells[11].Value) + "' WHERE CM_CLREFNO=" + Global.prtyCode + " AND CM_REFNO=" + refno;
                    String sql1 = "update Cx_CdFm1 set CM_DATA='" + Convert.ToString(gridViewCMA.Rows[i].Cells[11].Value) + "' WHERE CM_CLREFNO=" + Global.prtyCode + " AND CM_REFNO=" + refno;
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    OleDbCommand cmd1 = new OleDbCommand(sql1, con);
                    cmd1.Transaction = transaction;
                    cmd1.ExecuteNonQuery();

                }
                string sqlTrunc = "DELETE FROM Cx_CdFm3 WHERE FM_CLREFNO=" + Global.prtyCode;
                OleDbCommand cmd333 = new OleDbCommand(sqlTrunc, con);
                cmd333.Transaction = transaction;
                cmd333.ExecuteNonQuery();

                string sqlTrunc1 = "DELETE FROM Cp_CdFm3 WHERE FM_CLREFNO=" + Global.prtyCode;
                OleDbCommand cmd334= new OleDbCommand(sqlTrunc1, con);
                cmd334.Transaction = transaction;
                cmd334.ExecuteNonQuery();


                for (int i = 0; i <= grdReoCMAOther.CurrentWorksheet.RowCount - 1; i++)
                {
                    refno = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i,0));
                    String ctx09,ctx10,ctx11, ctx12, ctx13, ctx14, ctx15, ctx16, ctx17, ctx18, ctx19, ctx20, ctx21, ctx22, ctx23, ctx24 = "";
                    ctx09 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 15)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 15)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 15)) : "Null");
                    ctx10 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 16)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 16)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 16)) : "Null");
                    ctx11 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 30)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 30)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 30)) : "Null");
                    ctx12 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 31)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 31)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 31)) : "Null");
                    ctx13 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 32)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 32)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 32)) : "Null");
                    ctx14 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 33)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 33)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 33)) : "Null");
                    ctx15 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 34)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 34)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 34)) : "Null");
                    ctx16 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 35)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 35)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 35)) : "Null");
                    ctx17 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 36)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 36)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 36)) : "Null");
                    ctx18 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 37)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 37)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 37)) : "Null");
                    ctx19 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 38)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 38)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 38)) : "Null");
                    ctx20 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 39)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 39)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 39)) : "Null");
                    ctx21 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 40)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 40)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 40)) : "Null");
                    ctx22 = ((Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 41)) != null && Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 41)) != String.Empty) ? Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 41)) : "Null");
                    //String sql = "INSERT INTO Cp_CdFm3 (FM_SEQNO,set FM_YR01=" + ctx11 + ",FM_YR02=" + ctx12 + ",FM_YR03=" + ctx13 + ",FM_YR04=" + ctx14 + ",FM_YR05=" + ctx15 + ",FM_YR06=" + ctx16 + ",FM_YR07=" + ctx17 + ",FM_YR08=" + ctx18 + ",FM_YR09=" + ctx19 + ",FM_YR10=" + ctx20 + ",FM_YR11=" + ctx21 + ",FM_YR12=" + ctx22 + " WHERE FM_CLREFNO=" + Global.prtyCode + " AND FM_REFNO=" + refno;
                    String sql = "INSERT INTO Cp_CdFm3(FM_SEQNO,FM_TYPE,FM_FC,FM_BN,FM_MTNO,FM_SNO1,FM_SNO2,FM_CV,FM_FORM,FM_ADDROW,FM_TOTROW,FM_DESC,FM_CLREFNO,FM_OTHER,FM_STBST,FM_ENBST,FM_FOLIST,FM_FO01,FM_FO02,FM_FO03,FM_FO04,FM_FO05,FM_FO06,FM_FO07,FM_FO08,FM_FO09,FM_FO10,FM_FO11,FM_FO12,FM_YR01,FM_YR02,FM_YR03,FM_YR04,FM_YR05,FM_YR06,FM_YR07,FM_YR08,FM_YR09,FM_YR10,FM_YR11,FM_YR12) values ('" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 1)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 2)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 3)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 4)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 5)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 6)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 7)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 8)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 9)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 10)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 11)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 12)) + "'," + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 13)) + ",'" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 14)) + "'," + ctx09 + "," + ctx10 + ",'" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 17)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 18)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 19)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 20)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 21)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 22)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 23)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 24)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 25)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 26)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 27)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 28)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 29)) + "'," + ctx11 + "," + ctx12 + "," + ctx13 + "," + ctx14 + "," + ctx15 + "," + ctx16 + "," + ctx17 + "," + ctx18 + "," + ctx19 + "," + ctx20 + "," + ctx21 + "," + ctx22 + ")";
                    //String sql = "update Cp_CdFm3 set FM_YR01=" + ctx11 + ",FM_YR02=" + ctx12 + ",FM_YR03=" + ctx13 + ",FM_YR04=" + ctx14 + ",FM_YR05=" + ctx15 + ",FM_YR06=" + ctx16 + ",FM_YR07=" + ctx17 + ",FM_YR08=" + ctx18 + ",FM_YR09=" + ctx19 + ",FM_YR10=" + ctx20 + ",FM_YR11=" + ctx21 + ",FM_YR12=" + ctx22 + " WHERE FM_CLREFNO=" + Global.prtyCode + " AND FM_REFNO=" + refno;
                    String sql1 = "INSERT INTO Cx_CdFm3(FM_SEQNO,FM_TYPE,FM_FC,FM_BN,FM_MTNO,FM_SNO1,FM_SNO2,FM_CV,FM_FORM,FM_ADDROW,FM_TOTROW,FM_DESC,FM_CLREFNO,FM_OTHER,FM_STBST,FM_ENBST,FM_FOLIST,FM_FO01,FM_FO02,FM_FO03,FM_FO04,FM_FO05,FM_FO06,FM_FO07,FM_FO08,FM_FO09,FM_FO10,FM_FO11,FM_FO12,FM_YR01,FM_YR02,FM_YR03,FM_YR04,FM_YR05,FM_YR06,FM_YR07,FM_YR08,FM_YR09,FM_YR10,FM_YR11,FM_YR12) values ('" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 1)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 2)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 3)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 4)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 5)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 6)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 7)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 8)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 9)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 10)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 11)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 12)) + "'," + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 13)) + ",'" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 14)) + "'," + ctx09 + "," + ctx10 + ",'" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 17)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 18)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 19)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 20)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 21)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 22)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 23)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 24)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 25)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 26)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 27)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 28)) + "','" + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(i, 29)) + "'," + ctx11 + "," + ctx12 + "," + ctx13 + "," + ctx14 + "," + ctx15 + "," + ctx16 + "," + ctx17 + "," + ctx18 + "," + ctx19 + "," + ctx20 + "," + ctx21 + "," + ctx22 + ")";
                    //String sql1 = "update Cx_CdFm3 set FM_YR01=" + ctx11 + ",FM_YR02=" + ctx12 + ",FM_YR03=" + ctx13 + ",FM_YR04=" + ctx14 + ",FM_YR05=" + ctx15 + ",FM_YR06=" + ctx16 + ",FM_YR07=" + ctx17 + ",FM_YR08=" + ctx18 + ",FM_YR09=" + ctx19 + ",FM_YR10=" + ctx20 + ",FM_YR11=" + ctx21 + ",FM_YR12=" + ctx22 + " WHERE FM_CLREFNO=" + Global.prtyCode + " AND FM_REFNO=" + refno;
                    OleDbCommand cmd3 = new OleDbCommand(sql, con);
                    cmd3.Transaction = transaction;
                    cmd3.ExecuteNonQuery();
                    OleDbCommand cmd4 = new OleDbCommand(sql1, con);
                    cmd4.Transaction = transaction;
                    cmd4.ExecuteNonQuery();

                }
                transaction.Commit();
                con.Close();
                OleDbConnection conn = new OleDbConnection(connectionString);
                sqlTrunc = "DELETE FROM Cx_Cd101 WHERE CL_REFNO=" + Global.prtyCode;
                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds11, "Cx_Cd101");
                ds11.Dispose();
             
                OleDbDataAdapter myadapter1 = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql2 = "SELECT * FROM Cp_Cd101 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cp_Cd101");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql2 = "INSERT INTO Cx_Cd101 (CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CTXT06,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT05"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT06"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                        myadapter1.Fill(ds2, "Cx_Cd101");
                        ds2.Dispose();
                    }
                }
                ds1.Dispose();

                //DETAIL ASSETS
                sqlTrunc = "DELETE FROM Cx_Cd110 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter = new OleDbDataAdapter();
                ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds11, "Cx_Cd110");
                ds11.Dispose();

                myadapter1 = new OleDbDataAdapter();
                ds1 = new DataSet();
                sql2 = "SELECT * FROM Cp_Cd110 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cp_Cd110");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql2 = "INSERT INTO Cx_Cd110 (CTXT01,CTXT02,CTXT03,CTXT04,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                        myadapter1.Fill(ds2, "Cx_Cd110");
                        ds2.Dispose();
                    }
                }
                ds1.Dispose();


                //DETAIL BANKING
                sqlTrunc = "DELETE FROM Cx_Cd102 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter = new OleDbDataAdapter();
                ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds11, "Cx_Cd102");
                ds11.Dispose();

                myadapter1 = new OleDbDataAdapter();
                ds1 = new DataSet();
                sql2 = "SELECT * FROM Cp_Cd102 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cp_Cd102");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql2 = "INSERT INTO Cx_Cd102 (CTXT01,CTXT02,CTXT03,CTXT04,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                        myadapter1.Fill(ds2, "Cx_Cd102");
                        ds2.Dispose();
                    }
                }
                ds1.Dispose();

                //DETAIL credit
                sqlTrunc = "DELETE FROM Cx_Cd109 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter = new OleDbDataAdapter();
                ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds11, "Cx_Cd109");
                ds11.Dispose();

                myadapter1 = new OleDbDataAdapter();
                ds1 = new DataSet();
                sql2 = "SELECT * FROM Cp_Cd109 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cp_Cd109");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();

						String ctx11, ctx12, ctx13, ctx14, ctx15, ctx16, ctx21, ctx22, ctx23, ctx24, ctx25, ctx26, ctx31, ctx32, ctx33, ctx34, ctx35, ctx36, ctx41, ctx42, ctx43, ctx44, ctx45, ctx46, ctx51, ctx52, ctx53, ctx54, ctx55, ctx56, ctx61, ctx62, ctx63, ctx64, ctx65, ctx66 = "";
						ctx11 = ((ds1.Tables[0].Rows[i]["CTXT11"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT11"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT11"].ToString() : "Null");
						ctx12 = ((ds1.Tables[0].Rows[i]["CTXT12"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT12"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT12"].ToString() : "Null");
						ctx13 = ((ds1.Tables[0].Rows[i]["CTXT13"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT13"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT13"].ToString() : "Null");
						ctx14 = ((ds1.Tables[0].Rows[i]["CTXT14"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT14"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT14"].ToString() : "Null");
						ctx15 = ((ds1.Tables[0].Rows[i]["CTXT15"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT15"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT15"].ToString() : "Null");
						ctx16 = ((ds1.Tables[0].Rows[i]["CTXT16"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT16"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT16"].ToString() : "Null");

						ctx21 = ((ds1.Tables[0].Rows[i]["CTXT21"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT21"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT21"].ToString() : "Null");
						ctx22 = ((ds1.Tables[0].Rows[i]["CTXT22"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT22"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT22"].ToString() : "Null");
						ctx23 = ((ds1.Tables[0].Rows[i]["CTXT23"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT23"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT23"].ToString() : "Null");
						ctx24 = ((ds1.Tables[0].Rows[i]["CTXT24"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT24"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT24"].ToString() : "Null");
						ctx25 = ((ds1.Tables[0].Rows[i]["CTXT25"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT25"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT25"].ToString() : "Null");
						ctx26 = ((ds1.Tables[0].Rows[i]["CTXT26"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT26"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT26"].ToString() : "Null");

						ctx31 = ((ds1.Tables[0].Rows[i]["CTXT31"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT31"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT31"].ToString() : "Null");
						ctx32 = ((ds1.Tables[0].Rows[i]["CTXT32"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT32"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT32"].ToString() : "Null");
						ctx33 = ((ds1.Tables[0].Rows[i]["CTXT33"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT33"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT33"].ToString() : "Null");
						ctx34 = ((ds1.Tables[0].Rows[i]["CTXT34"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT34"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT34"].ToString() : "Null");
						ctx35 = ((ds1.Tables[0].Rows[i]["CTXT35"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT35"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT35"].ToString() : "Null");
						ctx36 = ((ds1.Tables[0].Rows[i]["CTXT36"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT36"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT36"].ToString() : "Null");

						ctx41 = ((ds1.Tables[0].Rows[i]["CTXT41"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT41"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT41"].ToString() : "Null");
						ctx42 = ((ds1.Tables[0].Rows[i]["CTXT42"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT42"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT42"].ToString() : "Null");
						ctx43 = ((ds1.Tables[0].Rows[i]["CTXT43"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT43"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT43"].ToString() : "Null");
						ctx44 = ((ds1.Tables[0].Rows[i]["CTXT44"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT44"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT44"].ToString() : "Null");
						ctx45 = ((ds1.Tables[0].Rows[i]["CTXT45"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT45"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT45"].ToString() : "Null");
						ctx46 = ((ds1.Tables[0].Rows[i]["CTXT46"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT46"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT46"].ToString() : "Null");

						ctx51 = ((ds1.Tables[0].Rows[i]["CTXT51"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT51"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT51"].ToString() : "Null");
						ctx52 = ((ds1.Tables[0].Rows[i]["CTXT52"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT52"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT52"].ToString() : "Null");
						ctx53 = ((ds1.Tables[0].Rows[i]["CTXT53"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT53"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT53"].ToString() : "Null");
						ctx54 = ((ds1.Tables[0].Rows[i]["CTXT54"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT54"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT54"].ToString() : "Null");
						ctx55 = ((ds1.Tables[0].Rows[i]["CTXT55"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT55"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT55"].ToString() : "Null");
						ctx56 = ((ds1.Tables[0].Rows[i]["CTXT56"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT56"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT56"].ToString() : "Null");

						ctx61 = ((ds1.Tables[0].Rows[i]["CTXT61"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT61"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT61"].ToString() : "Null");
						ctx62 = ((ds1.Tables[0].Rows[i]["CTXT62"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT62"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT62"].ToString() : "Null");
						ctx63 = ((ds1.Tables[0].Rows[i]["CTXT63"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT63"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT63"].ToString() : "Null");
						ctx64 = ((ds1.Tables[0].Rows[i]["CTXT64"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT64"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT64"].ToString() : "Null");
						ctx65 = ((ds1.Tables[0].Rows[i]["CTXT65"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT65"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT65"].ToString() : "Null");
						ctx66 = ((ds1.Tables[0].Rows[i]["CTXT66"].ToString() != null && ds1.Tables[0].Rows[i]["CTXT66"].ToString() != String.Empty) ? ds1.Tables[0].Rows[i]["CTXT66"].ToString() : "Null");

						
						sql2 = "INSERT INTO Cx_Cd109 (CTXT11,CTXT12,CTXT13,CTXT14,CTXT15,CTXT16,CTXT21,CTXT22,CTXT23,CTXT24,CTXT25,CTXT26,CTXT31,CTXT32,CTXT33,CTXT34,CTXT35,CTXT36,CTXT41,CTXT42,CTXT43,CTXT44,CTXT45,CTXT46,CTXT51,CTXT52,CTXT53,CTXT54,CTXT55,CTXT56,CTXT61,CTXT62,CTXT63,CTXT64,CTXT65,CTXT66,CL_REFNO) values (" + ctx11 + ","+ctx12+","+ctx13+","+ctx14+","+ctx15+","+ctx16+","+ctx21+","+ctx22+","+ctx23+","+ctx24+","+ctx25+","+ctx26+","+ctx31+","+ctx32+","+ctx33+","+ctx34+","+ctx35+","+ctx36+","+ctx41+","+ctx42+","+ctx43+","+ctx44+","+ctx45+","+ctx46+","+ctx51+","+ctx52+","+ctx53+","+ctx54+","+ctx55+","+ctx56+ "," + ctx61 + "," + ctx62 + "," + ctx63 + "," + ctx64 + "," + ctx65 + "," + ctx66 + "," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                        myadapter1.Fill(ds2, "Cx_Cd109");
                        ds2.Dispose();
                    }
                }
                ds1.Dispose();


                //DETAIL Associates
                sqlTrunc = "DELETE FROM Cx_Cd103 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter = new OleDbDataAdapter();
                ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds11, "Cx_Cd103");
                ds11.Dispose();

                myadapter1 = new OleDbDataAdapter();
                ds1 = new DataSet();
                sql2 = "SELECT * FROM Cp_Cd103 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cp_Cd103");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql2 = "INSERT INTO Cx_Cd103 (CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT05"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                        myadapter1.Fill(ds2, "Cx_Cd103");
                        ds2.Dispose();
                    }
                }
                ds1.Dispose();

                //DETAIL Registration
                sqlTrunc = "DELETE FROM Cx_Cd104 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter = new OleDbDataAdapter();
                ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds11, "Cx_Cd104");
                ds11.Dispose();

                myadapter1 = new OleDbDataAdapter();
                ds1 = new DataSet();
                sql2 = "SELECT * FROM Cp_Cd104 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cp_Cd104");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql2 = "INSERT INTO Cx_Cd104 (CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT05"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                        myadapter1.Fill(ds2, "Cx_Cd104");
                        ds2.Dispose();
                    }
                }
                ds1.Dispose();

				//DETAIL Position Incometax
				sqlTrunc = "DELETE FROM Cx_Cd119 WHERE CL_REFNO=" + Global.prtyCode;
				myadapter = new OleDbDataAdapter();
				ds11 = new DataSet();
				myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
				myadapter.Fill(ds11, "Cx_Cd119");
				ds11.Dispose();

				myadapter1 = new OleDbDataAdapter();
				ds1 = new DataSet();
				sql2 = "SELECT * FROM Cp_Cd119 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
				myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
				myadapter1.Fill(ds1, "Cp_Cd119");
				if (ds1.Tables[0].Rows.Count > 0)
				{
					for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
					{
						DataSet ds2 = new DataSet();
						sql2 = "INSERT INTO Cx_Cd119 (CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT05"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
						myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
						myadapter1.Fill(ds2, "Cx_Cd119");
						ds2.Dispose();
					}
				}
				ds1.Dispose();

				//DETAIL Position Incometax
				sqlTrunc = "DELETE FROM Cx_Cd107 WHERE CL_REFNO=" + Global.prtyCode;
				myadapter = new OleDbDataAdapter();
				ds11 = new DataSet();
				myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
				myadapter.Fill(ds11, "Cx_Cd107");
				ds11.Dispose();

				myadapter1 = new OleDbDataAdapter();
				ds1 = new DataSet();
				sql2 = "SELECT * FROM Cp_Cd107 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
				myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
				myadapter1.Fill(ds1, "Cp_Cd107");
				if (ds1.Tables[0].Rows.Count > 0)
				{
					for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
					{
						DataSet ds2 = new DataSet();
						sql2 = "INSERT INTO Cx_Cd107 (CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CTXT06,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT05"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT06"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
						myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
						myadapter1.Fill(ds2, "Cx_Cd107");
						ds2.Dispose();
					}
				}
				ds1.Dispose();

				//DETAIL PURCHASE
				sqlTrunc = "DELETE FROM Cx_Cd105 WHERE CL_REFNO=" + Global.prtyCode;
				myadapter = new OleDbDataAdapter();
				ds11 = new DataSet();
				myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
				myadapter.Fill(ds11, "Cx_Cd105");
				ds11.Dispose();

				myadapter1 = new OleDbDataAdapter();
				ds1 = new DataSet();
				sql2 = "SELECT * FROM Cp_Cd105 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
				myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
				myadapter1.Fill(ds1, "Cp_Cd105");
				if (ds1.Tables[0].Rows.Count > 0)
				{
					for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
					{
						DataSet ds2 = new DataSet();
						sql2 = "INSERT INTO Cx_Cd105 (CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CTXT06,CTXT07,CTXT08,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT05"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT06"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT07"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT08"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
						myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
						myadapter1.Fill(ds2, "Cx_Cd105");
						ds2.Dispose();
					}
				}
				ds1.Dispose();

				//DETAIL Parameter
				sqlTrunc = "DELETE FROM Cx_Cd108 WHERE CL_REFNO=" + Global.prtyCode;
				myadapter = new OleDbDataAdapter();
				ds11 = new DataSet();
				myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
				myadapter.Fill(ds11, "Cx_Cd108");
				ds11.Dispose();

				myadapter1 = new OleDbDataAdapter();
				ds1 = new DataSet();
				sql2 = "SELECT * FROM Cp_Cd108 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
				myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
				myadapter1.Fill(ds1, "Cp_Cd108");
				if (ds1.Tables[0].Rows.Count > 0)
				{
					for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
					{
						DataSet ds2 = new DataSet();
						sql2 = "INSERT INTO Cx_Cd108 (CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CTXT06,CTXT07,CTXT08,CTXT09,CTXT10,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT05"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT06"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT07"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT08"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT09"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT10"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
						myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
						myadapter1.Fill(ds2, "Cx_Cd108");
						ds2.Dispose();
					}
				}
				ds1.Dispose();

				//DETAIL Expenditure
				sqlTrunc = "DELETE FROM Cx_Cd111 WHERE CL_REFNO=" + Global.prtyCode;
				myadapter = new OleDbDataAdapter();
				ds11 = new DataSet();
				myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
				myadapter.Fill(ds11, "Cx_Cd111");
				ds11.Dispose();

				myadapter1 = new OleDbDataAdapter();
				ds1 = new DataSet();
				sql2 = "SELECT * FROM Cp_Cd111 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
				myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
				myadapter1.Fill(ds1, "Cp_Cd111");
				if (ds1.Tables[0].Rows.Count > 0)
				{
					for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
					{
						DataSet ds2 = new DataSet();
						sql2 = "INSERT INTO Cx_Cd111 (CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CTXT06,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT05"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT06"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
						myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
						myadapter1.Fill(ds2, "Cx_Cd111");
						ds2.Dispose();
					}
				}
				ds1.Dispose();

				//DETAIL Buyers
				sqlTrunc = "DELETE FROM Cx_Cd106 WHERE CL_REFNO=" + Global.prtyCode;
				myadapter = new OleDbDataAdapter();
				ds11 = new DataSet();
				myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
				myadapter.Fill(ds11, "Cx_Cd106");
				ds11.Dispose();

				myadapter1 = new OleDbDataAdapter();
				ds1 = new DataSet();
				sql2 = "SELECT * FROM Cp_Cd106 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
				myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
				myadapter1.Fill(ds1, "Cp_Cd106");
				if (ds1.Tables[0].Rows.Count > 0)
				{
					for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
					{
						DataSet ds2 = new DataSet();
						sql2 = "INSERT INTO Cx_Cd106 (CTXT01,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString()+ "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
						myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
						myadapter1.Fill(ds2, "Cx_Cd106");
						ds2.Dispose();
					}
				}
				ds1.Dispose();


                //DETAIL Immovable Securities
                sqlTrunc = "DELETE FROM Cx_Cd112 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter = new OleDbDataAdapter();
                ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds11, "Cx_Cd112");
                ds11.Dispose();

                myadapter1 = new OleDbDataAdapter();
                ds1 = new DataSet();
                sql2 = "SELECT * FROM Cp_Cd112 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cp_Cd112");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql2 = "INSERT INTO Cx_Cd112 (CTXT01,CTXT02,CTXT03,CTXT04,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                        myadapter1.Fill(ds2, "Cx_Cd112");
                        ds2.Dispose();
                    }
                }
                ds1.Dispose();

                //DETAIL Movable Securities
                sqlTrunc = "DELETE FROM Cx_Cd113 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter = new OleDbDataAdapter();
                ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds11, "Cx_Cd113");
                ds11.Dispose();

                myadapter1 = new OleDbDataAdapter();
                ds1 = new DataSet();
                sql2 = "SELECT * FROM Cp_Cd113 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cp_Cd113");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql2 = "INSERT INTO Cx_Cd113 (CTXT01,CTXT02,CTXT03,CTXT04,ctxt05,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT05"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                        myadapter1.Fill(ds2, "Cx_Cd113");
                        ds2.Dispose();
                    }
                }
                ds1.Dispose();


                //DETAIL Guarantor
                sqlTrunc = "DELETE FROM Cx_Cd114 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter = new OleDbDataAdapter();
                ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds11, "Cx_Cd114");
                ds11.Dispose();

                myadapter1 = new OleDbDataAdapter();
                ds1 = new DataSet();
                sql2 = "SELECT * FROM Cp_Cd114 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cp_Cd114");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql2 = "INSERT INTO Cx_Cd114 (CTXT01,CTXT02,CTXT03,CTXT04,CTXT05,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT02"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT03"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT04"].ToString() + "','" + ds1.Tables[0].Rows[i]["CTXT05"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                        myadapter1.Fill(ds2, "Cx_Cd114");
                        ds2.Dispose();
                    }
                }
                ds1.Dispose();

                //DETAIL list of documents
                sqlTrunc = "DELETE FROM Cx_Cd115 WHERE CL_REFNO=" + Global.prtyCode;
                myadapter = new OleDbDataAdapter();
                ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds11, "Cx_Cd115");
                ds11.Dispose();

                myadapter1 = new OleDbDataAdapter();
                ds1 = new DataSet();
                sql2 = "SELECT * FROM Cp_Cd115 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cp_Cd115");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql2 = "INSERT INTO Cx_Cd115 (CTXT01,CL_REFNO) values ('" + ds1.Tables[0].Rows[i]["CTXT01"].ToString() + "'," + ds1.Tables[0].Rows[i]["CL_REFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                        myadapter1.Fill(ds2, "Cx_Cd115");
                        ds2.Dispose();
                    }
                }
                ds1.Dispose();

                //DETAIL Associates
                
              myadapter1 = new OleDbDataAdapter();
                ds1 = new DataSet();
                sql2 = "update Cd_MsCln set CL_YEARS=" + comboBxYear.Text+",CL_RSIN='"+comboBoxRsIn.Text+"' where CL_REFNO=" + Global.prtyCode;
                myadapter1.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter1.Fill(ds1, "Cd_MsCln");
                ds1.Dispose();

                conn.Close();  
                isEdited = "n";
                MessageBox.Show(GlobalMsg.insertMsg, "Perfect Tax Reporter - CMA 1.0");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            isEdited = "n";
            cmdSave.Enabled = false;
            cmdCancel.Enabled = false;
            fillTempTable();
            fillCMSDataGrid();
            fillCMSReoDataGrid();
            
        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            if (isEdited == "y")
            {
                MessageBox.Show(GlobalMsg.saveMsg, "Perfect Tax Reporter - CMA 1.0");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
               // NotifyMainFormToCloseChildFormParty();
                NotifyMainFormToCloseChildFormCma();
                this.Hide();
            }
        }

        private void gridViewCMA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isEdited = "y";
            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;
			//DataGridViewCell cell = gridViewCMA.Rows[e.RowIndex].Cells[e.ColumnIndex];
           
            var list = new List<int> { 13, 14, 15, 16, 17, 18, 23, 30, 31, 35, 36, 37, 40, 41, 42, 44, 45 };
            if (list.Contains(e.RowIndex))
            {
                DataGridViewCell cell = gridViewCMA.Rows[e.RowIndex].Cells[11];
                cell.Value = "";
            }
            switch (e.RowIndex)
            {
                case 13:
                    if (NotifyMainFormToOpenChildFormDirector != null)
                    {
                        NotifyMainFormToOpenChildFormDirector();
                    }
                    break;
                case 14:
                    if (NotifyMainFormToOpenChildFormBanking != null)
                    {
                        NotifyMainFormToOpenChildFormBanking();
                    }
                    break;
                case 15:
                    if (NotifyMainFormToOpenChildFormCredit != null)
                    {
                        NotifyMainFormToOpenChildFormCredit();
                    }
                    break;
                case 16:
                    if (NotifyMainFormToOpenChildFormAssociate != null)
                    {
                        NotifyMainFormToOpenChildFormAssociate();
                    }
                    break;
                case 17:
                    if (NotifyMainFormToOpenChildFormRegistration != null)
                    {
                        NotifyMainFormToOpenChildFormRegistration();
                    }
                    break;
                case 18:
                    if (NotifyMainFormToOpenChildFormPosition != null)
                    {
                        NotifyMainFormToOpenChildFormPosition();
                    }
                    break;
                case 23:
                    if (NotifyMainFormToOpenChildFormPurchase != null)
                    {
                        NotifyMainFormToOpenChildFormPurchase();
                    }
                    break;
                case 30:
                    if (NotifyMainFormToOpenChildFormBuyer != null)
                    {
                        NotifyMainFormToOpenChildFormBuyer();
                    }
                    break;
                case 31:
                    if (NotifyMainFormToOpenChildFormSales != null)
                    {
                        NotifyMainFormToOpenChildFormSales();
                    }
                    break;
                case 35:
                    if (NotifyMainFormToOpenChildFormParameter != null)
                    {
                        NotifyMainFormToOpenChildFormParameter();
                    }
                    break;
                case 36:
                    if (NotifyMainFormToOpenChildFormAssets != null)
                    {
                        NotifyMainFormToOpenChildFormAssets();
                    }
                    break;
                case 37:
                    if (NotifyMainFormToOpenChildFormProposed != null)
                    {
                        NotifyMainFormToOpenChildFormProposed();
                    }
                    break;
                case 40:
                    if (NotifyMainFormToOpenChildFormImmovable != null)
                    {
                        NotifyMainFormToOpenChildFormImmovable();
                    }
                    break;
                case 41:
                    if (NotifyMainFormToOpenChildFormMovable != null)
                    {
                        NotifyMainFormToOpenChildFormMovable();
                    }
                    break;
                case 42:
                    if (NotifyMainFormToOpenChildFormGuarantor != null)
                    {
                        NotifyMainFormToOpenChildFormGuarantor();
                    }
                    break;
                case 44:
                    if (NotifyMainFormToOpenChildFormMovable != null)
                    {
                        NotifyMainFormToOpenChildFormDeclaration();
                    }
                    break;
                case 45:
                    if (NotifyMainFormToOpenChildFormGuarantor != null)
                    {
                        NotifyMainFormToOpenChildFormDocuments();
                    }
                    break;
                default:
                    //optional 
                    //statements 
                    break;
            }
        }

        private void gridViewCMA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;
            var list = new List<int> { 13, 14, 15, 16, 17, 18, 23, 30, 31, 35, 36, 37, 40, 41, 42, 44, 45 };
            if (list.Contains(e.RowIndex) && e.ColumnIndex == 11)
            {
                DataGridViewCell cell = gridViewCMA.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Value = "Double click to open form";
            }
        }

        private void lstViewTopic_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
             
            // e.DrawText();
            using (StringFormat sf = new StringFormat())
            {
                // Store the column text alignment, letting it default
                // to Left if it has not been set to Center or Right.
                switch (e.Header.TextAlign)
                {
                    case HorizontalAlignment.Center:
                        sf.Alignment = StringAlignment.Center;
                        break;
                    case HorizontalAlignment.Right:
                        sf.Alignment = StringAlignment.Far;
                        break;
                }

                // Draw the standard header background.
                // e.DrawBackground();
                e.Graphics.FillRectangle(Brushes.CadetBlue, e.Bounds);
                // Draw the header text.
                using (Font headerFont =
                            new Font("Helvetica", 12, FontStyle.Bold)) //Font size!!!!
                {
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.White, e.Bounds, sf);
                }
            }
            
            return;
        }

        private void lstViewTopic_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void cmdChngPrty_Click(object sender, EventArgs e)
        {
//NotifyMainFormToCloseChildFormParty();
            NotifyMainFormToCloseChildFormCma();
            this.Hide();
        }

        private void cmdCurYr_Click(object sender, EventArgs e)
        {
            if (NotifyMainFormToOpenChildFormYear != null)
            {
                NotifyMainFormToOpenChildFormYear();
            }
        }

        private void lstViewTopic_Click(object sender, EventArgs e)
        {
            if (lstViewTopic.SelectedItems[0].Text.Equals("Party Information"))
            {
               // grdViewCMAOther.Visible = false;
                grdReoCMAOther.Visible = false;
                gridViewCMA.Visible = true;
            }
            else
            {
                //   grdViewCMAOther.Visible = true;
                gridViewCMA.Visible = false;
                grdReoCMAOther.Visible = true;
            }
        }

        private void cmdCopyYr_Click(object sender, EventArgs e)
        {
            if (lstViewTopic.SelectedItems[0].Text.Equals("Party Information"))
            {
                MessageBox.Show(GlobalMsg.editMsg, "Perfect Tax Reporter - CMA 1.0");
            }
            else
            {
                pnlCopyYr.BringToFront();
                pnlCopyYr.Visible = true;
                grdReoCMAOther.Enabled = false;
                panelCmdBtns.Enabled = false;
                lstViewTopic.Enabled = false;
                chart2.Enabled = false;
                grdCopyYr.Rows.Add("Party Information",1);
                grdCopyYr.Rows.Add("Operating Statement", 0);
                grdCopyYr.Rows.Add("Liability Statement", 1);
                grdCopyYr.Rows.Add("Assets Statement", 1);
                grdCopyYr.Rows.Add("Valid", 1);
                grdCopyYr.Rows.Add("Financial Indicators", 1);
                grdCopyYr.Rows.Add("WCC", 1);
                grdCopyYr.Rows.Add("ABF Assessements", 1);
                grdCopyYr.Rows.Add("Fundflow Statement", 1);
                grdCopyYr.Rows.Add("Assessement of working capital required", 1);
                grdCopyYr.Rows.Add("As per Nayak Comitee", 1);
                grdCopyYr.Rows.Add("Calculation of Drawing power", 1);

                xconn = new ADODB.Connection();
                xconn.Open("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;", "", "", -1);
                ADODB.Recordset chkrs1 = new ADODB.Recordset();
                String stttr = "SELECT * FROM Cx_Cd120 where CL_REFNO=" + Global.prtyCode;
                chkrs1.Open("SELECT * FROM Cx_Cd120 where CL_REFNO=" + Global.prtyCode, xconn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, 0);

                //  MessageBox.Show(chkrs1.Fields[0].Value.Substring(0, 7));
                if (chkrs1.EOF == false)
                {

                    comboSrYr.Items.Insert(0, chkrs1.Fields[0].Value.Substring(0, 5) + chkrs1.Fields[0].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(1, chkrs1.Fields[1].Value.Substring(0, 5) + chkrs1.Fields[1].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(2, chkrs1.Fields[2].Value.Substring(0, 5) + chkrs1.Fields[2].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(3, chkrs1.Fields[3].Value.Substring(0, 5) + chkrs1.Fields[3].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(4, chkrs1.Fields[4].Value.Substring(0, 5) + chkrs1.Fields[4].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(5, chkrs1.Fields[5].Value.Substring(0, 5) + chkrs1.Fields[5].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(6, chkrs1.Fields[6].Value.Substring(0, 5) + chkrs1.Fields[6].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(7, chkrs1.Fields[7].Value.Substring(0, 5) + chkrs1.Fields[7].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(8, chkrs1.Fields[8].Value.Substring(0, 5) + chkrs1.Fields[8].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(9, chkrs1.Fields[9].Value.Substring(0, 5) + chkrs1.Fields[9].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(10, chkrs1.Fields[10].Value.Substring(0, 5) + chkrs1.Fields[10].Value.Substring(7, 2));
                    comboSrYr.Items.Insert(11, chkrs1.Fields[11].Value.Substring(0, 5) + chkrs1.Fields[11].Value.Substring(7, 2));
                    comboSrYr.SelectedIndex = 0;
                    comboDestYr.Items.Insert(0, chkrs1.Fields[0].Value.Substring(0, 5) + chkrs1.Fields[0].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(1, chkrs1.Fields[1].Value.Substring(0, 5) + chkrs1.Fields[1].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(2, chkrs1.Fields[2].Value.Substring(0, 5) + chkrs1.Fields[2].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(3, chkrs1.Fields[3].Value.Substring(0, 5) + chkrs1.Fields[3].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(4, chkrs1.Fields[4].Value.Substring(0, 5) + chkrs1.Fields[4].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(5, chkrs1.Fields[5].Value.Substring(0, 5) + chkrs1.Fields[5].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(6, chkrs1.Fields[6].Value.Substring(0, 5) + chkrs1.Fields[6].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(7, chkrs1.Fields[7].Value.Substring(0, 5) + chkrs1.Fields[7].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(8, chkrs1.Fields[8].Value.Substring(0, 5) + chkrs1.Fields[8].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(9, chkrs1.Fields[9].Value.Substring(0, 5) + chkrs1.Fields[9].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(10, chkrs1.Fields[10].Value.Substring(0, 5) + chkrs1.Fields[10].Value.Substring(7, 2));
                    comboDestYr.Items.Insert(11, chkrs1.Fields[11].Value.Substring(0, 5) + chkrs1.Fields[11].Value.Substring(7, 2));
                    comboDestYr.SelectedIndex = 1;
                    // comboSrYr.Items.Insert(12, chkrs1.Fields[12].Value.Substring(0, 5) + chkrs1.Fields[12].Value.Substring(7, 2));
                    //txtCurYear.Text = chkrs1.Fields[0].Value;

                }
                chkrs1.Close();
                xconn.Close();
            }
        }

        private void cmdInsRow_Click(object sender, EventArgs e)
        {
            if (lstViewTopic.SelectedItems[0].Text.Equals("Party Information"))
            {
                MessageBox.Show(GlobalMsg.editMsg, "Perfect Tax Reporter - CMA 1.0");
            }
            else
            {
               // MessageBox.Show(Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 10)));
                if(Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 10)).Equals("Y"))
                {
                  //   grdReoCMAOther.CurrentWorksheet.SetSettings(WorksheetSettings.Formula_AutoUpdateReferenceCell, true);
                    pnlInsRow.BringToFront();
                    pnlInsRow.Visible = true;
                    grdReoCMAOther.Enabled = false;
                    panelCmdBtns.Enabled = false;
                    lstViewTopic.Enabled = false;
                    chart2.Enabled = false;
                    txtDesc.Text = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 12));
                    txtSr.Text = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 6));
                    txtSr1.Text = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 7));
                    //grdReoCMAOther.CurrentWorksheet.InsertRows(3, 1);
                }
                else
                {
                    MessageBox.Show(GlobalMsg.insRowMsg, "Perfect Tax Reporter - CMA 1.0");
                }
               

            }

        }

        private void cmdDelRow_Click(object sender, EventArgs e)
        {
            if (lstViewTopic.SelectedItems[0].Text.Equals("Party Information"))
            {
                MessageBox.Show(GlobalMsg.editMsg, "Perfect Tax Reporter - CMA 1.0");
            }
            else
            {

            }

        }

        private void cmdChngDesc_Click(object sender, EventArgs e)
        {
            if (lstViewTopic.SelectedItems[0].Text.Equals("Party Information"))
            {
                MessageBox.Show(GlobalMsg.editMsg, "Perfect Tax Reporter - CMA 1.0");
            }
            else
            {
                pnlChangeDesc.BringToFront();
                pnlChangeDesc.Visible = true;
                grdReoCMAOther.Enabled = false;
                panelCmdBtns.Enabled = false;
                lstViewTopic.Enabled = false;
                chart2.Enabled = false;
                txtDescChangeDesc.Text = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 12));
                txtSrChangeDesc.Text = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 6));
                txtSr1ChangeDesc.Text = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 7));
                //grdReoCMAOther.CurrentWorksheet.InsertRows(3, 1);
            }
        }

        private void cmdResetDeta_Click(object sender, EventArgs e)
        {
            if (lstViewTopic.SelectedItems[0].Text.Equals("Party Information"))
            {
                MessageBox.Show(GlobalMsg.editMsg, "Perfect Tax Reporter - CMA 1.0");
            }
            else
            {
                if (isEdited == "y")
                {
                    DialogResult dialogResult = MessageBox.Show("Reset data for this client????", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
                    if (dialogResult == DialogResult.Yes)
                    {
                        EmptyTables();
                        resetTables();
                        fillCMSDataGrid();
                        fillCMSReoDataGrid();
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Available in Edit mode only", "Perfect Tax Reporter - CMA 1.0");
                }
            }
        }

        private void EmptyTables()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                string sqlTrunc = "DELETE FROM Cp_CdFm1";

                OleDbDataAdapter myadapter = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                string sqlTruncOther = "DELETE FROM Cp_CdFm3";
                myadapter.SelectCommand = new OleDbCommand(sqlTrunc, conn);
                myadapter.Fill(ds1, "Cp_CdFm1");
                myadapter.SelectCommand = new OleDbCommand(sqlTruncOther, conn);
                myadapter.Fill(ds1, "Cp_CdFm3");
            }
            catch (Exception e)
            {
                //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }

        private void resetTables()
        {
            try
            {
                    OleDbConnection conn = GetConnection();
                    OleDbDataAdapter myadapter1 = new OleDbDataAdapter();
                    DataSet ds1 = new DataSet();
                    String sql = "Update Cp_CdFm11 set [CM_CLREFNO]=" + Global.prtyCode + ";";
                    myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                    myadapter1.Fill(ds1, "Cp_CdFm11");
                    sql = "SELECT * FROM Cp_CdFm11 WHERE [CM_CLREFNO]=" + Global.prtyCode + ";";
                    myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                    myadapter1.Fill(ds1, "Cp_CdFm11");
                    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds2 = new DataSet();
                        sql = "INSERT INTO Cp_CdFm1 (CM_SEQNO,CM_TYPE,CM_FC,CM_BN,CM_DBNO,CM_MTNO,CM_HEAD,CM_DESC,CM_LNKFRM,CM_CLREFNO) values ('" + ds1.Tables[0].Rows[i]["CM_SEQNO"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_TYPE"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_FC"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_BN"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_DBNO"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_MTNO"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_HEAD"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_DESC"].ToString() + "','" + ds1.Tables[0].Rows[i]["CM_LNKFRM"].ToString() + "'," + ds1.Tables[0].Rows[i]["CM_CLREFNO"].ToString() + ")";
                        myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                        myadapter1.Fill(ds2, "Cp_CdFm1");
                        ds2.Dispose();
                    }



                    //'  sql = "INSERT INTO Cp_CdFm1 SELECT CM_SEQNO,CM_TYPE,CM_FC,CM_BN,CM_DBNO,CM_MTNO,CM_HEAD,CM_DESC,CM_LNKFRM,CM_CLREFNO FROM Cp_CdFm11";
                    //'  myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                    // '  myadapter1.Fill(ds1, "Cp_CdFm11");
                    ds1.Dispose();

               ///////fm3


                    DataSet ds3 = new DataSet();
                    //OleDbDataAdapter myadapter1 = new OleDbDataAdapter();
                    String sqlother = "Update Cp_CdFm33 set [FM_CLREFNO]=" + Global.prtyCode + ";";
                    myadapter1.SelectCommand = new OleDbCommand(sqlother, conn);
                    myadapter1.Fill(ds3, "Cp_CdFm33");
                    sqlother = "SELECT * FROM Cp_CdFm33 WHERE [FM_CLREFNO]=" + Global.prtyCode + ";";
                    myadapter1.SelectCommand = new OleDbCommand(sqlother, conn);
                    myadapter1.Fill(ds3, "Cp_CdFm33");
                    for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                    {
                        DataSet ds22 = new DataSet();
                        String sql33 = "INSERT INTO Cp_CdFm3 (FM_SEQNO,FM_TYPE,FM_FC,FM_BN,FM_MTNO,FM_SNO1,FM_SNO2,FM_CV,FM_FORM,FM_ADDROW,FM_TOTROW,FM_DESC,FM_CLREFNO,FM_FOLIST,FM_FO01,FM_FO02,FM_FO03,FM_FO04,FM_FO05,FM_FO06,FM_FO07,FM_FO08,FM_FO09,FM_FO10,FM_FO11,FM_FO12) values ('" + ds3.Tables[0].Rows[i]["FM_SEQNO"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_TYPE"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FC"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_BN"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_MTNO"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_SNO1"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_SNO2"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_CV"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FORM"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_ADDROW"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_TOTROW"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_DESC"].ToString() + "'," + ds3.Tables[0].Rows[i]["FM_CLREFNO"].ToString() + ",'" + ds3.Tables[0].Rows[i]["FM_FOLIST"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO01"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO02"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO03"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO04"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO05"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO06"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO07"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO08"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO09"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO10"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO11"].ToString() + "','" + ds3.Tables[0].Rows[i]["FM_FO12"].ToString() + "')";
                        myadapter1.SelectCommand = new OleDbCommand(sql33, conn);
                        myadapter1.Fill(ds22, "Cp_CdFm3");
                        ds22.Dispose();
                    }

                    ds3.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                //  Console.WriteLine(e.Message);//
                MessageBox.Show(e.Message);
            }
        }

        private void cmdFormula_Click(object sender, EventArgs e)
        {
            if (lstViewTopic.SelectedItems[0].Text.Equals("Party Information"))
            {
                MessageBox.Show(GlobalMsg.editMsg, "Perfect Tax Reporter - CMA 1.0");
            }
            else
            {
                if (Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 18)).Equals(""))
                {
                    //MessageBox.Show(GlobalMsg.editMsg, "Perfect Tax Reporter - CMA 1.0");
                    MessageBox.Show("No Formula Exist", "Perfect Tax Reporter - CMA 1.0");
                }
                else
                {
                    pnlFormula.BringToFront();
                    pnlFormula.Visible = true;
                    grdReoCMAOther.Enabled = false;
                    panelCmdBtns.Enabled = false;
                    lstViewTopic.Enabled = false;
                    chart2.Enabled = false;
                    FillYrListBox();
                    var cell = grdReoCMAOther.CurrentWorksheet.GetCell(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, grdReoCMAOther.CurrentWorksheet.FocusPos.Col);
                    txtFormula.Text = cell.Formula;
                    String[] delimiterChars = { ",", "*", "%", "/", "+", "-", "IF(", ")", "MAX(", "MIN(", ">", "<", "(", "=" };
                    string[] words = cell.Formula.Split(delimiterChars, StringSplitOptions.None);
                    Array.Sort(words);
                    // Array.Reverse(words);
                    //  System.Console.WriteLine("Formula : " + MM);
                    int counter = 1;
                    String newSt, ss;
                    if (grdViewFormula.RowCount > 0)
                    {
                        for (int RowCount = 0; RowCount <= grdViewFormula.RowCount; RowCount++)
                        {
                            grdViewFormula.Rows.RemoveAt(0);
                        }
                    }
                    foreach (string s in words)
                    {
                      grdViewFormula.Rows.Add(s,grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.GetCell(s).Row, 12), grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.GetCell(s).Row, grdReoCMAOther.CurrentWorksheet.FocusPos.Col));
                    }
                }
            }

        }
        private void grdViewCMAOther_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdViewCMAOther_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdViewCMAOther_DoubleClick(object sender, EventArgs e)
        {
                isEdited = "y";
                cmdSave.Enabled = true;
                cmdCancel.Enabled = true;
            }

        private void grdViewCMAOther_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = grdViewCMAOther.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            e.CellStyle.BackColor = Global.gridBackColorCMS;

            //if (e.ColumnIndex == 1)
            //{
            //    e.Value = Convert.ToString(e.Value).Substring(2, 2);
            //}
            var list = new List<int> { 0, 8, 39,43,55,56,75,84,112,134,138,159,190,210,217,225,251,264,275,284,291,305,306,307,317,327,337 };
            var listCol = new List<int> { 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41};
            var listGreen = new List<int> { 0 };
            if (e.ColumnIndex == 30)
            {
                String formula = "";
                formula = Convert.ToString(grdViewCMAOther.Rows[e.RowIndex].Cells[18].Value);
                if (!string.IsNullOrEmpty(formula))
                {
                    //A004A = A002A + A003A
                    String[] delimiterChars = { " ", ",", ".", ":", "\t", "IIF(", ">=", "<=", ">", "<", "*", "%", "/", "{", "}", ")", "[", "]", "+", "-","?",":" };


                    System.Console.WriteLine("Original text: '{0}'", formula);
                    formula = formula.Substring(6, formula.Length - 6);
                    string[] words = formula.Split(delimiterChars, StringSplitOptions.None);
                    // System.Console.WriteLine("{0} words in text:", words.Length);
                    int counter = 1;
                    foreach (string s in words)
                    {
                        int n;
 
                        if (!string.IsNullOrEmpty(s) && int.TryParse(s, out n)==false)
                       {    String kk = "";
                            String ss = "";
                            if (s.IndexOf("=") >= 0)
                            {
                                ss = s.Substring(0, s.IndexOf("="));
                                DataGridViewRow row = grdViewCMAOther.Rows
                                   .Cast<DataGridViewRow>()
                                   .Where(r => r.Cells[1].Value.ToString().Equals(ss))
                                   .First();
                                formula = formula.Replace(ss, "grdViewCMAOther.Rows["+row.Index+"].Cells[30].Value");
                            }
                            else
                            {
                                ss = s;
                                System.Console.WriteLine(ss);
                                DataGridViewRow row = grdViewCMAOther.Rows
                                    .Cast<DataGridViewRow>()
                                    .Where(r => r.Cells[1].Value.ToString().Equals(ss))
                                    .First();
                                if (Convert.ToString(grdViewCMAOther.Rows[row.Index].Cells[18].Value).Equals(formula))
                                {
                                    formula = formula.Replace(s, "");
                                    if (counter == 1)
                                    {
                                        var regex = new Regex(Regex.Escape("="));
                                        formula = regex.Replace(formula, "", 1);
                                        // formula = formula.Replace("=", "");
                                        counter = counter + 1;
                                    }
                                }
                                else
                                {
                                    formula = formula.Replace(s, string.IsNullOrEmpty(Convert.ToString(grdViewCMAOther.Rows[row.Index].Cells[30].Value)) ? "0" : Convert.ToString(grdViewCMAOther.Rows[row.Index].Cells[30].Value));
                                }
                            }
                              
 
                        }
                    }
                    if (!string.IsNullOrEmpty(formula))
                    {
        
                        System.Console.WriteLine("New text: '{0}'", formula + "  ====  " + Evaluate(formula));
                        grdViewCMAOther.Rows[e.RowIndex].Cells[30].Value = Evaluate(formula);
                    }
                }
            }
            if (list.Contains(e.RowIndex) && listCol.Contains(e.ColumnIndex))
            {
                e.CellStyle.BackColor = Color.DarkGray;

                cell.ReadOnly = true;
            }
            if (list.Contains(e.RowIndex))
            {
                e.CellStyle.ForeColor = Color.Green;
            }
        }
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        private void grdViewCMAOther_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pictInsRowClose_Click(object sender, EventArgs e)
        {
            pnlInsRow.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            grdReoCMAOther.CurrentWorksheet.ResumeFormulaReferenceUpdates();
            var listRow = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y' };
            var listReplRow = new List<char> { 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            Char chr = Convert.ToChar(Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 1)).Substring(4, 1));
            String fld1 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 1)).Substring(0, 4) + Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 1)).Substring(4, 1).Replace(chr, listReplRow[listRow.FindIndex(x => x.Equals(chr))]);
            String fld2 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 2));
            String fld3 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 3));
            String fld4 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 4));
            String fld5 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 5));
            String fld6 = txtSr.Text;   // Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 6));
            String fld7 = txtSr1.Text;   // Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 7));
            String fld8 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 8));
            String fld9 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 9));
            String fld10 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 10));
            String fld11 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 11));
            String fld12 = txtDesc.Text;    // Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 12));
            String fld13 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 13));
            String fld14 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 14));
            String fld15 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 15));
            String fld16 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 16));
            String fld17 = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 17));
            pnlInsRow.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
            grdReoCMAOther.CurrentWorksheet.InsertRows(grdReoCMAOther.CurrentWorksheet.FocusPos.Row + 1, 1);
            int newRow = grdReoCMAOther.CurrentWorksheet.FocusPos.Row + 1;
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 1, fld1);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 2, fld2);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 3, fld3);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 4, fld4);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 5, fld5);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 6, fld6);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 7, fld7);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 8, fld8);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 9, fld9);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 10, fld10);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 11, fld11);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 12, fld12);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 13, fld13);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 14, fld14);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 15, fld15);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 16, fld16);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 17, fld17);

          //   String[] delimiterChars = { " ", ",", ".", ":", "\t", "IF(", ">=", "<=", ">", "<", "*", "%", "/", "{", "}", ")", "[", "]", "+", "-", "?", ":" };
            String[] delimiterChars = { "," , "*", "%", "/", "+", "-","IF(",")","MAX(","MIN(",">","<","(","=" };
            String[] origCell = { };

            for (int row = 0; row < grdReoCMAOther.CurrentWorksheet.RowCount; row++)
            {
                for (int col = 18; col < (18+Convert.ToInt16(comboBxYear.Text)); col++)
                {
                    String MM = "";
                    if (String.IsNullOrEmpty(Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(row, col))) || String.IsNullOrEmpty(Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(row, col))).Equals("null"))
                    {
                    }
                    else
                    {
                        MM = (String)grdReoCMAOther.CurrentWorksheet.GetCellData(row, col);
                        string[] words = MM.Split(delimiterChars, StringSplitOptions.None);
                        Array.Sort(words);
                        Array.Reverse(words);
                        System.Console.WriteLine("Formula : " + MM);
                        int counter = 1;
                        String newSt;
                        foreach (string s in words)
                        {
                            int n = 0;
                            if (!string.IsNullOrEmpty(s) && int.TryParse(s, out n) == false)
                            { 
                                System.Console.WriteLine(s + "    ----   " + (Convert.ToInt16(s.Substring(2, s.Length - 2)) + 1));
                                newSt=MM.Replace(s.Substring(2, s.Length - 2),Convert.ToString(Convert.ToInt16(s.Substring(2, s.Length - 2)) + 1));
                                MM = newSt;
                        }
                    }
                    }
                    System.Console.WriteLine("Formula NEW : " + MM);
                    //cell.Readonly = true;
                    grdReoCMAOther.CurrentWorksheet.SetCellFormula(row, col + 12, MM);
                }
            }

        }
            

        private void cmdCancelInsRow_Click(object sender, EventArgs e)
        {
            pnlInsRow.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
        }

        private void cmdOKChangeDesc_Click(object sender, EventArgs e)
        {
 
            String fld6 = txtSrChangeDesc.Text;   // Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 6));
            String fld7 = txtSr1ChangeDesc.Text;   // Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 7));
            String fld12 = txtDescChangeDesc.Text;    // Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, 12));
            pnlChangeDesc.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
            int newRow = grdReoCMAOther.CurrentWorksheet.FocusPos.Row;
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 6, fld6);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 7, fld7);
            grdReoCMAOther.CurrentWorksheet.SetCellData(newRow, 12, fld12);
        }

        private void cmdCancelChangeDesc_Click(object sender, EventArgs e)
        {
            pnlChangeDesc.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pnlChangeDesc.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
        }

        private void pictFormula_Click(object sender, EventArgs e)
        {
            pnlFormula.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
        }

        private void pictFormula_Click_1(object sender, EventArgs e)
        {

        }

        private void grdViewYr_Click(object sender, EventArgs e)
        {
            int i = grdViewYr.CurrentRow.Index;
          
            DataGridViewRow rows = this.grdViewYr.Rows[i];
            grdViewFormula.Columns[2].HeaderText = Convert.ToString(rows.Cells["Year"].Value);

            if (Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, (i+18))).Equals(""))
            {
                //MessageBox.Show(GlobalMsg.editMsg, "Perfect Tax Reporter - CMA 1.0");
                MessageBox.Show("No Formula Exist", "Perfect Tax Reporter - CMA 1.0");
            }
            else
            {
                var cell = grdReoCMAOther.CurrentWorksheet.GetCell(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, (30+i));
                txtFormula.Text = cell.Formula;
                String[] delimiterChars = { ",", "*", "%", "/", "+", "-", "IF(", ")", "MAX(", "MIN(", ">", "<", "(", "=" };
                string[] words = cell.Formula.Split(delimiterChars, StringSplitOptions.None);
                Array.Sort(words);
                // Array.Reverse(words);
                //  System.Console.WriteLine("Formula : " + MM);
                int counter = 1;
                String newSt, ss;
                for (int RowCount = 0; RowCount <= grdViewFormula.RowCount; RowCount++)
                {
                    grdViewFormula.Rows.RemoveAt(0);
                }
                
                foreach (string s in words)
                {
                    grdViewFormula.Rows.Add(s, grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.GetCell(s).Row, 12), grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.GetCell(s).Row, (grdReoCMAOther.CurrentWorksheet.FocusPos.Col+i)));
                }
            }

        }


        private void grdReoCMAOther_Click(object sender, EventArgs e)
        {
            isEdited = "y";
            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;

            if (lstViewTopic.SelectedItems[0].Text.Equals("Party Information"))
            {
                gridViewCMA.CurrentCell = gridViewCMA.Rows[0].Cells[11];
            }
            else
            {
                var cell = grdReoCMAOther.CurrentWorksheet.GetCell(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, (30));
                if (cell.IsReadOnly){

                }
                else
                {
                    DisplayChart();
                }
                txtCurYear.Enabled = true;
                comboBxYear.Enabled = true;
                comboBoxCopyYear.Enabled = true;
                comboBoxRsIn.Enabled = true;
                cmdInsRow.Enabled = true;
                cmdDelRow.Enabled = true;
                cmdChngDesc.Enabled = true;
                cmdFormula.Enabled = true;
                cmdResetDeta.Enabled = true;
                cmdCopyYr.Enabled = true;
            }
        }

        private void DisplayChart()
        {
           
            List<double> myCollectiony = new List<double>();
            List<int> myCollectionx = new List<int>();
            Boolean first = true;
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            String sql2 = "SELECT * FROM Cx_Cd120 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
            DataSet ds1 = new DataSet();
            myadapter.SelectCommand = new OleDbCommand(sql2, conn);
            myadapter.Fill(ds1, "Cx_Cd120");
            int counter = 30;
            if (ds1.Tables[0].Rows.Count > 0)
            {
                for (int i = grdReoCMAOther.CurrentWorksheet.FocusPos.Row; i <= grdReoCMAOther.CurrentWorksheet.FocusPos.Row; i++)
                {

                    for (int ii = 30; ii <= (29+Convert.ToInt16(comboBxYear.Text)); ii++)
                    {
                        var cell = grdReoCMAOther.CurrentWorksheet.GetCell(i, ii);

                            if (first)
                            {
                                switch (ii)
                                {
                                    case 30:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT01"].ToString().Substring(2, 2)));
                                        break;
                                    case 31:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT02"].ToString().Substring(2, 2)));
                                        break;
                                    case 32:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT03"].ToString().Substring(2, 2)));
                                        break;
                                    case 33:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT04"].ToString().Substring(2, 2)));
                                        break;
                                    case 34:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT05"].ToString().Substring(2, 2)));
                                        break;
                                    case 35:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT06"].ToString().Substring(2, 2)));
                                        break;
                                    case 36:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT07"].ToString().Substring(2, 2)));
                                        break;
                                    case 37:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT08"].ToString().Substring(2, 2)));
                                        break;
                                    case 38:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT09"].ToString().Substring(2, 2)));
                                        break;
                                    case 39:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT10"].ToString().Substring(2, 2)));
                                        break;
                                    case 40:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT11"].ToString().Substring(2, 2)));
                                        break;
                                    case 41:
                                        myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT12"].ToString().Substring(2, 2)));
                                        break;
                                    default:
                                        break;
                                }

                            }
                        if (!String.IsNullOrEmpty(Convert.ToString(cell.Data)))
                        {
                            myCollectiony.Add(Convert.ToDouble(cell.Data));
                            counter = counter + 1;
                        }
                       
                    }
                    first = false;
                }
                double[] yData = myCollectiony.ToArray();
                int[] xData = myCollectionx.ToArray();
                ChartArea area = chart2.ChartAreas[0];
                //chart2.ChartAreas.Add(area);
                //Create a series using the data
                Series barSeries = new Series();
                barSeries.Points.DataBindXY(xData,yData);
                //Set the chart type, Bar; horizontal bars
                barSeries.ChartType = SeriesChartType.Column;
                //Assign it to the required area
                barSeries.ChartArea = area.Name;
                area.AxisX.Title = "Year";
                area.AxisY.Title = "Rupees";
                foreach (var series in chart2.Series)
                {
                    series.Points.Clear();
                }
                chart2.Legends[0].Enabled = false;
                chart2.Series.Add(barSeries);
            }

        }
        private void CmdOkFormula_Click(object sender, EventArgs e)
        {
            int i = grdViewYr.CurrentRow.Index;
            var cell = grdReoCMAOther.CurrentWorksheet.GetCell(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, (30 + i));
            grdReoCMAOther.CurrentWorksheet.SetCellFormula(cell.Row,cell.Column, txtFormula.Text);
            
                String[] delimiterChars = { ",", "*", "%", "/", "+", "-", "IF(", ")", "MAX(", "MIN(", ">", "<", "(", "=" };
                string[] words = cell.Formula.Split(delimiterChars, StringSplitOptions.None);
                Array.Sort(words);
                int counter = 1;
                String newSt, ss;

            int ii = 0;
            foreach (string s in words)
                {
                   Cell cl = grdReoCMAOther.CurrentWorksheet.GetCell(s);
                   DataGridViewRow rowsf = this.grdViewFormula.Rows[ii];
                   cl.Data = Convert.ToString(rowsf.Cells["Year1"].Value);
            }
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = grdViewYr.CurrentRow.Index;
            var cell = grdReoCMAOther.CurrentWorksheet.GetCell(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, (30 + i));
            grdReoCMAOther.CurrentWorksheet.SetCellFormula(cell.Row, cell.Column, txtFormula.Text);
            String[] delimiterChars = { ",", "*", "%", "/", "+", "-", "IF(", ")", "MAX(", "MIN(", ">", "<", "(", "=" };
            string[] words = txtFormula.Text.Split(delimiterChars, StringSplitOptions.None);
            Array.Sort(words);
            // Array.Reverse(words);
            //  System.Console.WriteLine("Formula : " + MM);
            int counter = 1;
            String newSt, ss;
            for (int RowCount = 0; RowCount <= grdViewFormula.RowCount; RowCount++)
            {
                grdViewFormula.Rows.RemoveAt(0);
            }

            foreach (string s in words)
            {
                grdViewFormula.Rows.Add(s, grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.GetCell(s).Row, 12), grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.GetCell(s).Row, (grdReoCMAOther.CurrentWorksheet.FocusPos.Col + i)));
            }
        }

        private void btnCanForm_Click(object sender, EventArgs e)
        {
            int i = grdViewYr.CurrentRow.Index;
            var cell = grdReoCMAOther.CurrentWorksheet.GetCell(grdReoCMAOther.CurrentWorksheet.FocusPos.Row, (30 + i));
            txtFormula.Text = cell.Formula;
            String[] delimiterChars = { ",", "*", "%", "/", "+", "-", "IF(", ")", "MAX(", "MIN(", ">", "<", "(", "=" };
            string[] words = cell.Formula.Split(delimiterChars, StringSplitOptions.None);
            Array.Sort(words);
            // Array.Reverse(words);
            //  System.Console.WriteLine("Formula : " + MM);
            int counter = 1;
            String newSt, ss;
            for (int RowCount = 0; RowCount <= grdViewFormula.RowCount; RowCount++)
            {
                grdViewFormula.Rows.RemoveAt(0);
            }

            foreach (string s in words)
            {
                grdViewFormula.Rows.Add(s, grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.GetCell(s).Row, 12), grdReoCMAOther.CurrentWorksheet.GetCellData(grdReoCMAOther.CurrentWorksheet.GetCell(s).Row, (grdReoCMAOther.CurrentWorksheet.FocusPos.Col + i)));
            }
        }

        private void cmdSave_EnabledChanged(object sender, EventArgs e)
        {
            cmdSave.ForeColor = cmdSave.Enabled ? Global.btnfore : Global.btnDisfore;
            cmdSave.BackgroundImage = cmdSave.Enabled ? Global.cmdImg : Global.cmdBtnDisBack;
        }

        private void cmdCancel_EnabledChanged(object sender, EventArgs e)
        {
            cmdCancel.ForeColor = cmdCancel.Enabled ? Global.btnfore : Global.btnDisfore;
            cmdCancel.BackgroundImage = cmdCancel.Enabled ? Global.cmdImg : Global.cmdBtnDisBack;
        }

        private void panelCmdBtns_EnabledChanged(object sender, EventArgs e)
        {
            foreach (Button btn in panelCmdBtns.Controls.OfType<Button>())   //Disable Textbox
            {
                if (btn.Name.Equals("cmdSave") || btn.Name.Equals("cmdCancel"))
                {
                    cmdSave.ForeColor = cmdSave.Enabled ? Global.btnfore : Global.btnDisfore;
                    cmdSave.BackgroundImage = cmdSave.Enabled ? Global.cmdImg : Global.cmdBtnDisBack;
                    cmdCancel.ForeColor = cmdCancel.Enabled ? Global.btnfore : Global.btnDisfore;
                    cmdCancel.BackgroundImage = cmdCancel.Enabled ? Global.cmdImg : Global.cmdBtnDisBack;
                }
                else
                {
                    btn.ForeColor = btn.Enabled ? Global.btnfore : Global.btnDisfore;
                    btn.BackgroundImage = btn.Enabled ? Global.cmdImg : Global.cmdBtnDisBack;
                }

               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtIncrease.Text.Equals("0") || txtIncrease.Text.Trim().Equals("")){
                MessageBox.Show(GlobalMsg.CopyPercentMsg, "Perfect Tax Reporter - CMA 1.0");
                txtIncrease.Focus();
                return;
            }
            var colNo = comboSrYr.SelectedIndex + 30;
            Double cellVal;
            for (int row = 0; row < grdReoCMAOther.CurrentWorksheet.RowCount; row++)
            {
                var cell = grdReoCMAOther.CurrentWorksheet.GetCell(row, colNo);
                var cellDest = grdReoCMAOther.CurrentWorksheet.GetCell(row, comboDestYr.SelectedIndex + 30);
                if (cell.HasFormula && cell.IsReadOnly)
                {

                }
                else
                {
                    cellVal =Convert.ToDouble(txtIncrease.Text);
                    if (!string.IsNullOrEmpty(Convert.ToString(cell.Data)))
                    {
                        cellVal = Convert.ToDouble(cell.Data) + Convert.ToDouble(cell.Data) * cellVal / 100;
                        cellDest.Data = cellVal;
                    }
                }
                
            }
        }

        private void pictCopyYr_Click(object sender, EventArgs e)
        {
            pnlCopyYr.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
        }

        private void grdCopyYr_DoubleClick(object sender, EventArgs e)
        {
            int i = grdCopyYr.CurrentRow.Index;
            if (Convert.ToBoolean(grdCopyYr.CurrentRow.Cells["selected"].Value) == false)
            {
                grdCopyYr.CurrentRow.Cells["selected"].Value = true;
            }
            else { 
                grdCopyYr.CurrentRow.Cells["selected"].Value = false;
        }
    }

        private void grdCopyYr_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void grdCopyYr_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void grdCopyYr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                int i = grdCopyYr.CurrentRow.Index;
                if (Convert.ToBoolean(grdCopyYr.CurrentRow.Cells["selected"].Value) == false)
                {
                    grdCopyYr.CurrentRow.Cells["selected"].Value = true;
                }
                else
                {
                    grdCopyYr.CurrentRow.Cells["selected"].Value = false;
                }
            }
            else
            {
                if (e.Control && e.KeyCode == Keys.Add)
                {
                    for (int i = 0; i < grdCopyYr.RowCount; i++)
                    {
                        grdCopyYr[i,1].Value = true;
                    }
                }
                else
                {
                    if (e.Control && e.KeyCode == Keys.Subtract)
                    {
                        for (int i = 0; i < grdCopyYr.RowCount; i++)
                        {
                            grdCopyYr[i, 1].Value = false;
                        }
                    }

                }
            }
        }

        private void FrmCMA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && (e.KeyCode == Keys.Oemplus || e.KeyCode==Keys.Add))
            {
                for (int i = 0; i < grdCopyYr.RowCount; i++)
                {
                    grdCopyYr[1,i].Value = true;
                }
            }
            if (e.Control && (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract))
            {
                for (int i = 0; i < grdCopyYr.RowCount; i++)
                {
                    grdCopyYr[1,i].Value = false;
                }
            }
        }

        private void cmdCancelCopyYr_Click(object sender, EventArgs e)
        {
            pnlCopyYr.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
        }

        private void cmdPrntGrph_Click(object sender, EventArgs e)
        {
            pnlGraph.BringToFront();
            pnlGraph.Visible = true;
            grdReoCMAOther.Enabled = false;
            panelCmdBtns.Enabled = false;
            lstViewTopic.Enabled = false;
            chart2.Enabled = false;
            //grdChart.Rows.Add("Party Information");
            //grdChart.Rows.Add("Operating Statement");
            //grdChart.Rows.Add("Liability Statement");
            //grdChart.Rows.Add("Assets Statement");
            //grdChart.Rows.Add("Valid");
            //grdChart.Rows.Add("Financial Indicators");
            //grdChart.Rows.Add("WCC");
            //grdChart.Rows.Add("ABF Assessements");
            //grdChart.Rows.Add("Fundflow Statement");
            //grdChart.Rows.Add("Assessement of working capital required");
            //grdChart.Rows.Add("As per Nayak Comitee");
            //grdChart.Rows.Add("Calculation of Drawing power");
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            con.Open();
            dataAdapter = new OleDbDataAdapter("SELECT FM_DESC,FM_REFNO from Cp_CdFm3  order by FM_REFNO", con);
            dataAdapter.Fill(ds, "Cp_CdFm3");
            grdChart.DataMember = "Cp_CdFm3";
            grdChart.DataSource = ds;
            grdChart.Columns[0].Visible = true;
            grdChart.Columns[0].HeaderText = "Description";
            grdChart.Columns[0].Width = 253;
            grdChart.Columns[1].Visible = false;
  
            // grdViewParty.Focus();
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlGraph.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
        }

        private void radioStart_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStart.Checked == true)
            {
                grdChart.Rows[0].Selected = true;
            }
        }

        private void txtChart_KeyUp(object sender, KeyEventArgs e)
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            con.Open();
            dataAdapter = new OleDbDataAdapter("SELECT FM_DESC,FM_REFNO from Cp_CdFm3 where FM_DESC like '%" + txtChart.Text.Replace("'", "''") + "%'  order by FM_REFNO", con);
            dataAdapter.Fill(ds, "Cp_CdFm3");
            grdChart.DataMember = "Cp_CdFm3";
            grdChart.DataSource = ds;
            con.Close();
            
        }

        private void grdChart_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void grdChart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            // int row = grdChart.CurrentCell.RowIndex;
            // grdChart.Rows.RemoveAt(row);
            Boolean found = false;
            if (grdChartSelected.Rows.Count > 0)
            {
            }
            else
            {
                foreach (DataGridViewRow row1 in grdChartSelected.Rows)
                {
                    if (row1.Cells[1].Value.Equals(grdChart[e.ColumnIndex, e.RowIndex].Value.ToString()))
                    {
                        // row exists
                        found = true;
                        //  MessageBox.Show("Row already exists");
                        break;
                    }
                }
            }
            if (!found)
            {
                grdChartSelected.Rows.Add(grdChart[e.ColumnIndex, e.RowIndex].Value.ToString(), grdChart[e.ColumnIndex+1, e.RowIndex].Value.ToString());
            }
        }

        private void grdChartSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = grdChartSelected.CurrentCell.RowIndex;
            grdChartSelected.Rows.RemoveAt(row);
            //grdChart.Rows.Add(grdChartSelected[e.ColumnIndex, e.RowIndex].Value.ToString(), grdChartSelected[e.ColumnIndex+1, e.RowIndex].Value.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Boolean first = true;
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            String sql2 = "SELECT * FROM Cx_Cd120 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
            DataSet ds1 = new DataSet();
            myadapter.SelectCommand = new OleDbCommand(sql2, conn);
            myadapter.Fill(ds1, "Cx_Cd120");
            int counter = 30;
            int chHeight = 40;
            int chartCounter = 0;
            if (ds1.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < grdChartSelected.RowCount; j++)
                {
                    for (int i = 0; i < grdReoCMAOther.CurrentWorksheet.Rows; i++)
                    {
                        String str = Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCell(i, 0).Data);
                        if (Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCell(i, 0).Data).Equals(Convert.ToString(grdChartSelected.Rows[j].Cells[1].Value)))
                        {
                            first = true;
                            List<double> myCollectiony = new List<double>();
                            List<int> myCollectionx = new List<int>();
                            for (int ii = 30; ii <= (29 + Convert.ToInt16(comboBxYear.Text)); ii++)
                            {

                                var cell = grdReoCMAOther.CurrentWorksheet.GetCell(i, ii);

                                if (first)
                                {
                                    switch (ii)
                                    {
                                        case 30:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT01"].ToString().Substring(2, 2)));
                                            break;
                                        case 31:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT02"].ToString().Substring(2, 2)));
                                            break;
                                        case 32:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT03"].ToString().Substring(2, 2)));
                                            break;
                                        case 33:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT04"].ToString().Substring(2, 2)));
                                            break;
                                        case 34:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT05"].ToString().Substring(2, 2)));
                                            break;
                                        case 35:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT06"].ToString().Substring(2, 2)));
                                            break;
                                        case 36:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT07"].ToString().Substring(2, 2)));
                                            break;
                                        case 37:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT08"].ToString().Substring(2, 2)));
                                            break;
                                        case 38:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT09"].ToString().Substring(2, 2)));
                                            break;
                                        case 39:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT10"].ToString().Substring(2, 2)));
                                            break;
                                        case 40:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT11"].ToString().Substring(2, 2)));
                                            break;
                                        case 41:
                                            myCollectionx.Add(Convert.ToInt16(ds1.Tables[0].Rows[0]["CTXT12"].ToString().Substring(2, 2)));
                                            break;
                                        default:
                                            break;
                                    }

                                }
                                if (!String.IsNullOrEmpty(Convert.ToString(cell.Data)))
                                {
                                    myCollectiony.Add(Convert.ToDouble(cell.Data));
                                    counter = counter + 1;
                                }

                            }
                            first = false;
                            double[] yData = myCollectiony.ToArray();
                            int[] xData = myCollectionx.ToArray();
                            if (xData.Length==yData.Length)
                            {
                                Chart chart = new Chart();
                                this.Controls.Add(chart);
                                chart.Name = "chart" + chartCounter;
                                chart.Visible = true;
                                chart.Show();
               
                                chart.Titles.Add(Convert.ToString(grdReoCMAOther.CurrentWorksheet.GetCell(i, 12).Data));
                                if (chartCounter % 2 == 0)
                                {
                                    chart.Left = 50;
                                    chart.Top = 50 + 125 * (chartCounter);
                                    chHeight = chart.Top;
                                }
                                else
                                {
                                    chart.Left = 400;
                                    chart.Top = chHeight;
                                }



                                chart.Width = 300;
                                chart.Height = 160;

                                pnlChartDet.Controls.Add(chart);

                                //  chart.ChartAreas.RemoveAt(0);
                                ChartArea area = new ChartArea();
                                chart.ChartAreas.Add(area);
                                area.AxisX.Title = "Year";
                                area.AxisY.Title = "Ruppes";
                                //Create a series using the data
                                Series barSeries = new Series();
                                //  String nme = "series" + j;
                                barSeries.Points.DataBindXY(xData, yData);
                                //Set the chart type, Bar; horizontal bars
                                barSeries.ChartType = SeriesChartType.Column;
                                //Assign it to the required area
                                barSeries.ChartArea = area.Name;
                                foreach (var series in chart.Series)
                                {
                                    series.Points.Clear();
                                }
                                //chart.Legends[0].Enabled = false;
                                chart.Series.Add(barSeries);
                                chartCounter++;
                            }
                            
                           
                        }
                    }
                }
            }
            pnlGraph.Visible = false;
            pnlChartDet.Visible = true;
        }

        private void pictPrint_Click(object sender, EventArgs e)
        {
                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
                doc.Print();
            
        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int jj = 10;
            int kk = 300;
            int mm = 160;
            foreach (Chart chrt in pnlChartDet.Controls.OfType<Chart>())   //Disable Textbox
            {
                chrt.Printing.PrintPaint(e.Graphics, new Rectangle(0, jj, kk,mm));
                jj = jj+270;
                kk = kk + 270;
            }
        }

        private void pictChartDet_Click(object sender, EventArgs e)
        {
            pnlChartDet.Visible = false;
            grdReoCMAOther.Enabled = true;
            panelCmdBtns.Enabled = true;
            lstViewTopic.Enabled = true;
            chart2.Enabled = true;
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            CreateExcelDoc excell_app = new CreateExcelDoc();
            //creates the main header
            excell_app.createHeaders(2, 1, "CLIENT INFORMATION", "A2", "A2", 2, "", true, 10, "n");
            excell_app.createHeaders(5, 1, "Description", "A5", "A5", 2, "", true, 10, "n");
            excell_app.createHeaders(5, 2, "Data", "B5", "B5", 2, "", true, 10, "n");
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            myadapter.SelectCommand = new OleDbCommand("Select * from Cp_CdFm1 where CM_CLREFNO=" + Global.prtyCode + " order by CM_SEQNO", conn);
            myadapter.Fill(ds, "Cp_CdFm1");
            //gridViewCMA.DataMember = "Cp_CdFm1";
            //gridViewCMA.DataSource = ds;

            int rowCounter = 7;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                excell_app.createHeaders(rowCounter, 1, ds.Tables[0].Rows[i]["CM_DESC"].ToString(), "A"+ rowCounter, "A"+rowCounter, 2, "", true, 10, "n");
                excell_app.addData(rowCounter, 2, ds.Tables[0].Rows[i]["CM_DATA"].ToString());

                //excell_app.addData(i + 7, 1, Convert.ToString(gridViewCMA.Rows[i].Cells[8].Value));
                //excell_app.addData(i + 7, 2, Convert.ToString(gridViewCMA.Rows[i].Cells[11].Value));
                var list = new List<int> { 13, 14, 15, 16, 17, 18, 23, 30, 31, 35, 36, 37, 40, 41, 42, 44, 45 };
                if (list.Contains(i))
                {
                    if (i == 13)
                    {
                        String strDirector="";
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd101 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd101");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Name", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 3, "Age", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 4, "Pan", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 5, "Address", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 6, "Phone", "F" + rowCounter, "F" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 7, "Net", "G" + rowCounter, "G" + rowCounter, 2, "", true, 10, "n");
                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                            excell_app.addData(rowCounter, 7, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT06"]));
                            if (ii< ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                        }
                    if (i == 14)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd102 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd102");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Name of Bank/Branch", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 3, "Facility", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 4, "Limit", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 5, "Outstanding", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 6, "Banking Since", "F" + rowCounter, "F" + rowCounter, 2, "", true, 10, "n");
                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                          
                            if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }
                    if (i == 16)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd103 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd103");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Name of Unit", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 3, "Name(s) of Prop", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 4, "Banking with", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 5, "Limit", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 6, "Outstanding", "F" + rowCounter, "F" + rowCounter, 2, "", true, 10, "n");
                                
                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                           if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }
                    if (i == 17)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd104 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd104");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Pan", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 3, "Sales Tax", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 4, "Service Tax", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 5, "Excise", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 6, "Other", "F" + rowCounter, "F" + rowCounter, 2, "", true, 10, "n");

                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                            if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }
                    if (i == 18)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd119 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd119");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Income Tax", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 3, "Sales Tax", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 4, "Service Tax", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 5, "Excise", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 6, "Other", "F" + rowCounter, "F" + rowCounter, 2, "", true, 10, "n");

                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                            if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }
                    if (i == 40)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd112 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd112");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Description of property", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 3, "Name of owner", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 4, "Value of property", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 5, "Basis of valuation", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }
                    if (i == 41)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd113 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd113");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Description", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 3, "Name of owner", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 4, "Face value", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 5, "When acquired", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 6, "Present Value", "F" + rowCounter, "F" + rowCounter, 2, "", true, 10, "n");
                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                            if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }
                    if (i == 44)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd116 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd116");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Facility", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 3, "Date", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 4, "Place", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }
                    if (i == 42)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd114 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd114");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Name of Guarantor & Address", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 3, "Age", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 4, "Qualification", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 5, "Networth", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 6, "Banking with", "F" + rowCounter, "F" + rowCounter, 2, "", true, 10, "n");
                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                            if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }
                    if (i == 45)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd115 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd115");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Documents", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            
                            if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }
                    if (i == 36)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd110 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd110");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Description", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 3, "Detail of Supplier", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 4, "Cost", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                                excell_app.createHeaders(rowCounter, 5, "Time schedule for completion", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }
                    if (i == 30)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd106 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd106");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (ii == 0)
                            {
                                excell_app.createHeaders(rowCounter, 2, "Description", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                                rowCounter = rowCounter + 1;
                            }
                            excell_app.addData(rowCounter, 2, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            if (ii < ds1.Tables[0].Rows.Count - 1)
                            {
                                rowCounter = rowCounter + 1;
                            }
                        }
                        ds1.Dispose();
                    }

                    if (i == 31)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd107 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd107");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            excell_app.createHeaders(rowCounter, 3, "Domestic", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 4, "Export", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Credit sales to Total Sales", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Period of credit given", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Average receivable Level", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT06"]));
                     
                        }
                        ds1.Dispose();
                    }

                    if (i == 37)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd111 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd111");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            excell_app.createHeaders(rowCounter, 2, "Cost", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 3, "Amt", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 4, "Means", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 5, "Amt", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Land & Building", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.createHeaders(rowCounter, 4, "Own Funds", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Period of credit given", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.createHeaders(rowCounter, 4, "Other Loans", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Average receivable Level", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.createHeaders(rowCounter, 4, "Bank Loans", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT06"]));
                            excell_app.createHeaders(rowCounter, 2, "Total", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(Convert.ToDouble(ds1.Tables[0].Rows[ii]["CTXT01"])+ Convert.ToDouble(ds1.Tables[0].Rows[ii]["CTXT02"])+Convert.ToDouble(ds1.Tables[0].Rows[ii]["CTXT03"])));
                            excell_app.createHeaders(rowCounter, 4, "Total", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 5, Convert.ToString(Convert.ToDouble(ds1.Tables[0].Rows[ii]["CTXT04"]) + Convert.ToDouble(ds1.Tables[0].Rows[ii]["CTXT05"]) + Convert.ToDouble(ds1.Tables[0].Rows[ii]["CTXT06"])));

                        }
                        ds1.Dispose();
                    }
                    if (i == 35)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd108 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd108");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            excell_app.createHeaders(rowCounter, 3, "Past", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 4, "Projected", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Sales/Income", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT06"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Net Profit", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT07"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Depreciation/P & P", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT08"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Cash Accurals", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT09"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Tangible Net worth", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT10"]));
                        }
                        ds1.Dispose();
                    }

                    if (i == 23)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd105 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd105");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            excell_app.createHeaders(rowCounter, 3, "Domestic", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 4, "Import", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "% of credit purchase to total purchase", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT01"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT05"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Period of credit enjoyed", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT02"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT06"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Average level of sundry creditors", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT03"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT07"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Purchase under LC include above", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT04"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT08"]));
                        }
                        ds1.Dispose();
                    }
                    if (i == 15)
                    {
                        DataSet ds1 = new DataSet();
                        myadapter.SelectCommand = new OleDbCommand("Select * from Cp_Cd109 where CL_REFNO=" + Global.prtyCode, conn);
                        myadapter.Fill(ds1, "Cp_Cd109");
                        for (int ii = 0; ii < ds1.Tables[0].Rows.Count; ii++)
                        {
                            excell_app.createHeaders(rowCounter, 4, "Limit Required", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 7, "Limit Existing", "G" + rowCounter, "G" + rowCounter, 2, "", true, 10, "n");
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 3, "Fund Based", "C" + rowCounter, "C" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 4, "Non Fund Based", "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 5, "Total", "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 6, "Fund Based", "F" + rowCounter, "F" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 7, "Non Fund Based", "G" + rowCounter, "G" + rowCounter, 2, "", true, 10, "n");
                            excell_app.createHeaders(rowCounter, 8, "Total", "H" + rowCounter, "H" + rowCounter, 2, "", true, 10, "n");
                            rowCounter = rowCounter + 2;
                            excell_app.createHeaders(rowCounter, 2, "Cash Credit", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT11"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT12"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT13"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT14"]));
                            excell_app.addData(rowCounter, 7, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT15"]));
                            excell_app.addData(rowCounter, 8, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT16"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Over Draft", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT21"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT22"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT23"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT24"]));
                            excell_app.addData(rowCounter, 7, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT25"]));
                            excell_app.addData(rowCounter, 8, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT26"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "PC", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT31"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT32"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT33"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT34"]));
                            excell_app.addData(rowCounter, 7, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT35"]));
                            excell_app.addData(rowCounter, 8, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT36"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "LC", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT41"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT42"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT43"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT44"]));
                            excell_app.addData(rowCounter, 7, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT45"]));
                            excell_app.addData(rowCounter, 8, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT46"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Term Loan", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT51"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT52"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT53"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT54"]));
                            excell_app.addData(rowCounter, 7, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT55"]));
                            excell_app.addData(rowCounter, 8, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT56"]));
                            rowCounter = rowCounter + 1;
                            excell_app.createHeaders(rowCounter, 2, "Total", "B" + rowCounter, "B" + rowCounter, 2, "", true, 10, "n");
                            excell_app.addData(rowCounter, 3, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT61"]));
                            excell_app.addData(rowCounter, 4, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT62"]));
                            excell_app.addData(rowCounter, 5, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT63"]));
                            excell_app.addData(rowCounter, 6, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT64"]));
                            excell_app.addData(rowCounter, 7, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT65"]));
                            excell_app.addData(rowCounter, 8, Convert.ToString(ds1.Tables[0].Rows[ii]["CTXT66"]));
                        }
                        ds1.Dispose();
                    }
                }
                rowCounter = rowCounter + 1;
            }
            ds.Dispose();
            for (int kk = 1; kk < 12; kk++)
            {
                rowCounter = 3;
                String sql2 = "SELECT * FROM Cx_Cd120 WHERE [CL_REFNO]=" + Global.prtyCode + ";";
                DataSet ds11 = new DataSet();
                myadapter.SelectCommand = new OleDbCommand(sql2, conn);
                myadapter.Fill(ds11, "Cx_Cd120");
                int counter = 30;
                if (ds11.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds11.Tables[0].Rows.Count; i++)
                    {
                        for (int ii = 1; ii <= Convert.ToInt16(comboBxYear.Text); ii++)
                        {

                            switch (ii)
                            {
                                case 1:
                                    excell_app.createHeadersGross(rowCounter, 4, ds11.Tables[0].Rows[i]["CTXT01"].ToString(), "D" + rowCounter, "D" + rowCounter, 2, "", true, 10, "n",kk);

                                    break;
                                case 2:
                                    excell_app.createHeadersGross(rowCounter, 5, ds11.Tables[0].Rows[i]["CTXT02"].ToString(), "E" + rowCounter, "E" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                case 3:
                                    excell_app.createHeadersGross(rowCounter, 6, ds11.Tables[0].Rows[i]["CTXT03"].ToString(), "F" + rowCounter, "F" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                case 4:
                                    excell_app.createHeadersGross(rowCounter, 7, ds11.Tables[0].Rows[i]["CTXT04"].ToString(), "G" + rowCounter, "G" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                case 5:
                                    excell_app.createHeadersGross(rowCounter, 8, ds11.Tables[0].Rows[i]["CTXT05"].ToString(), "H" + rowCounter, "H" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                case 6:
                                    excell_app.createHeadersGross(rowCounter, 9, ds11.Tables[0].Rows[i]["CTXT06"].ToString(), "I" + rowCounter, "I" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                case 7:
                                    excell_app.createHeadersGross(rowCounter, 10, ds11.Tables[0].Rows[i]["CTXT07"].ToString(), "J" + rowCounter, "J" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                case 8:
                                    excell_app.createHeadersGross(rowCounter, 11, ds11.Tables[0].Rows[i]["CTXT08"].ToString(), "K" + rowCounter, "K" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                case 9:
                                    excell_app.createHeadersGross(rowCounter, 12, ds11.Tables[0].Rows[i]["CTXT09"].ToString(), "L" + rowCounter, "L" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                case 10:
                                    excell_app.createHeadersGross(rowCounter, 13, ds11.Tables[0].Rows[i]["CTXT10"].ToString(), "M" + rowCounter, "M" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                case 11:
                                    excell_app.createHeadersGross(rowCounter, 14, ds11.Tables[0].Rows[i]["CTXT11"].ToString(), "N" + rowCounter, "N" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                case 12:
                                    excell_app.createHeadersGross(rowCounter, 15, ds11.Tables[0].Rows[i]["CTXT12"].ToString(), "O" + rowCounter, "O" + rowCounter, 2, "", true, 10, "n",kk);
                                    break;
                                default:
                                    break;
                            }
                            counter = counter + 1;
                        }
                    }
                }
                ds11.Dispose();
                DataSet dsn = new DataSet();
                myadapter.SelectCommand = new OleDbCommand("Select * from Cp_CdFm3 where FM_CLREFNO=" + Global.prtyCode + " and FM_MTNO='" + kk + "' order by FM_SEQNO", conn);
                myadapter.Fill(dsn, "Cp_CdFm3");
                rowCounter = 5;
                String YrCount = "01";
                for (int i = 0; i < dsn.Tables[0].Rows.Count; i++)
                {

                    excell_app.addDataGross(rowCounter, 1, Convert.ToString(dsn.Tables[0].Rows[i]["FM_SNO1"]), kk);
                    excell_app.addDataGross(rowCounter, 2, Convert.ToString(dsn.Tables[0].Rows[i]["FM_SNO2"]), kk);
                    excell_app.addDataGross(rowCounter, 3, Convert.ToString(dsn.Tables[0].Rows[i]["FM_DESC"]), kk);
                    for (int ii = 1; ii <= Convert.ToInt16(comboBxYear.Text); ii++)
                    {
                        if (ii < 9)
                        {
                            YrCount = "0" + Convert.ToString(ii);
                        }
                        else
                        {
                            YrCount = Convert.ToString(ii);
                        }
                        excell_app.addDataGross(rowCounter, (ii + 3), Convert.ToString(dsn.Tables[0].Rows[i]["FM_YR" + YrCount]), kk);
                    }
                    rowCounter = rowCounter + 1;
                }
                dsn.Dispose();
            }
            conn.Close();
            excell_app.ShowApp();
        }
    }
}
