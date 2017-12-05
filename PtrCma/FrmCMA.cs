﻿using System;
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
    public partial class FrmCMA : Form
    {

        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToOpenChildFormCma;
        public FrmCMA()
        {
            InitializeComponent();
        }

       
        void gridViewCMA_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = gridViewCMA.Rows[e.RowIndex].Cells[e.ColumnIndex];
            e.CellStyle.BackColor = Global.gridBackColorCMS;
        }
        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCMA_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            checkTables();
            fillTopicListBox();
            fillCMSDataGrid();
            setControlSize();
            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.BackgroundImage = Global.cmdBackImg;
            }
        }

    

        private void setControlSize()
        {
            
            lblPic.Size = Global.lblPicTitle;
        }

        public void Settings()
        {
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
           
            setPanelControlColor();
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Pink, e.Bounds);
            e.DrawText();
        }
        private void setPanelControlColor()
        {
            // Set Back  of Control Panel
            cmdChngPrty.BackgroundImage = Global.cmdImg;
            cmdCurYr.BackgroundImage = Global.cmdImg;
            cmdCopyYr.BackgroundImage = Global.cmdImg;
            cmdRsIn.BackgroundImage = Global.cmdImg;
            cmdInsRow.BackgroundImage = Global.cmdImg;
            cmdDelRow.BackgroundImage = Global.cmdImg;
            cmdChngDesc.BackgroundImage = Global.cmdImg;
            cmdResetDeta.BackgroundImage = Global.cmdImg;
            cmdPrntGrph.BackgroundImage = Global.cmdImg;
            cmdEdit.BackgroundImage = Global.cmdImg;
            cmdSave.BackgroundImage = Global.cmdImg;
            cmdCancel.BackgroundImage = Global.cmdImg;
            cmdRefresh.BackgroundImage = Global.cmdImg;
            cmdFormula.BackgroundImage = Global.cmdImg;
            cmdExport.BackgroundImage = Global.cmdImg;
            cmdPrint.BackgroundImage = Global.cmdImg;

            // Set Fore Color of Control Panel
            cmdChngPrty.ForeColor = Global.btnfore;
            cmdCurYr.ForeColor = Global.btnfore;
            cmdCopyYr.ForeColor = Global.btnfore;
            cmdRsIn.ForeColor = Global.btnfore;
            cmdInsRow.ForeColor = Global.btnfore;
            cmdDelRow.ForeColor = Global.btnfore;
            cmdChngDesc.ForeColor = Global.btnfore;
            cmdResetDeta.ForeColor = Global.btnfore;
            cmdPrntGrph.ForeColor = Global.btnfore;
            cmdEdit.ForeColor = Global.btnfore;
            cmdSave.ForeColor = Global.btnfore;
            cmdCancel.ForeColor = Global.btnfore;
            cmdRefresh.ForeColor = Global.btnfore;
            cmdFormula.ForeColor = Global.btnfore;
            cmdExport.ForeColor = Global.btnfore;
            cmdPrint.ForeColor = Global.btnfore;

            //Set Style of Button
            cmdChngPrty.FlatStyle = FlatStyle.Flat;
            cmdCurYr.FlatStyle = FlatStyle.Flat;
            cmdCopyYr.FlatStyle = FlatStyle.Flat;
            cmdRsIn.FlatStyle = FlatStyle.Flat;
            cmdInsRow.FlatStyle = FlatStyle.Flat;
            cmdDelRow.FlatStyle = FlatStyle.Flat;
            cmdChngDesc.FlatStyle = FlatStyle.Flat;
            cmdResetDeta.FlatStyle = FlatStyle.Flat;
            cmdPrntGrph.FlatStyle = FlatStyle.Flat;
            cmdEdit.FlatStyle = FlatStyle.Flat;
            cmdSave.FlatStyle = FlatStyle.Flat;
            cmdCancel.FlatStyle = FlatStyle.Flat;
            cmdRefresh.FlatStyle = FlatStyle.Flat;
            cmdFormula.FlatStyle = FlatStyle.Flat;
            cmdExport.FlatStyle = FlatStyle.Flat;
            cmdPrint.FlatStyle = FlatStyle.Flat;

            cmdChngPrty.BackgroundImageLayout = ImageLayout.Stretch;
            cmdCurYr.BackgroundImageLayout = ImageLayout.Stretch;
            cmdCopyYr.BackgroundImageLayout = ImageLayout.Stretch;
            cmdRsIn.BackgroundImageLayout = ImageLayout.Stretch;
            cmdInsRow.BackgroundImageLayout = ImageLayout.Stretch;
            cmdDelRow.BackgroundImageLayout = ImageLayout.Stretch;
            cmdChngDesc.BackgroundImageLayout = ImageLayout.Stretch;
            cmdResetDeta.BackgroundImageLayout = ImageLayout.Stretch;
            cmdPrntGrph.BackgroundImageLayout = ImageLayout.Stretch;
            cmdEdit.BackgroundImageLayout = ImageLayout.Stretch;
            cmdSave.BackgroundImageLayout = ImageLayout.Stretch;
            cmdCancel.BackgroundImageLayout = ImageLayout.Stretch;
            cmdRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            cmdFormula.BackgroundImageLayout = ImageLayout.Stretch;
            cmdExport.BackgroundImageLayout = ImageLayout.Stretch;
            cmdPrint.BackgroundImageLayout = ImageLayout.Stretch;
            
            picFrmClose.BackColor = System.Drawing.Color.FromArgb(124,236,246);
            //picFrmClose.BackColor = System.Drawing.Color.Transparent;
        }

        private void checkTables()
        {
            OleDbConnection conn = GetConnection();
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            myadapter.SelectCommand = new OleDbCommand("Select * from Cp_CdFm1", conn);
            myadapter.Fill(ds, "Cp_CdFm1");
            if (ds.Tables[0].Rows.Count == 0) {
                OleDbDataAdapter myadapter1 = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "INSERT INTO Cp_CdFm1 SELECT * FROM Cp_CdFm11;";
                myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                myadapter1.Fill(ds1, "Cp_CdFm11");
                //foreach (DataRow item in ds1.Tables[0].Rows) //Iterate through each row of 2nd data table
                //{
                //    DataRow newRow = ds.Tables[0].NewRow();
                //    newRow.ItemArray = item.ItemArray;
                //    ds.Tables[0].Rows.Add(newRow); //Import the row in 1st data table
                //}
               // ds.Tables[0].Merge(ds1.Tables[0]);
                ds1.Dispose();
            }
            ds.Dispose();
            conn.Close();
            
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
        
        private void fillCMSDataGrid()
        {
            OleDbConnection conn = GetConnection();
            OleDbDataAdapter myadapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            myadapter.SelectCommand = new OleDbCommand("Select * from Cp_CdFm1", conn);
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

            gridViewCMA.Columns[9].Visible = true;
            gridViewCMA.Columns[9].HeaderText = "Description";
            gridViewCMA.Columns[9].Width = ((gridViewCMA.Width-100)*70)/100;

            gridViewCMA.Columns[12].Visible = true;
            gridViewCMA.Columns[12].ReadOnly = false;
            gridViewCMA.Columns[12].HeaderText = "Data";
            gridViewCMA.Columns[12].Width = ((gridViewCMA.Width-100)*30)/100;

            gridViewCMA.Refresh();
        }

        private void fillTopicListBox()
        {
            lstViewTopic.View = View.Details;
            lstViewTopic.GridLines = true;
            lstViewTopic.FullRowSelect = true;
            ColumnHeader header1;
            header1 = new ColumnHeader();
            
            // Set the text, alignment and width for each column header.
            header1.Text = "Select Topic";
            header1.TextAlign = HorizontalAlignment.Center;
            header1.Width = lstViewTopic.Width - 21;
            lstViewTopic.Columns.Add(header1);
            //Add items in the listview

            lstViewTopic.Items.Add("Parety Information");
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

        private void cmdEdit_Click(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }

        private void picFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormParty();
                this.Hide();

            }
        }
    }
}
