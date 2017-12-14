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
    public partial class FrmCMA : Form
    {

        public Action NotifyMainFormToCloseChildFormParty;
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
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;
        OleDbTransaction transaction;
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

        private void FrmCMA_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            this.KeyPreview = true; //To handle enter key
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
            foreach (Button btn in panelCmdBtns.Controls.OfType<Button>())   //Disable Textbox
            {
                btn.BackgroundImage = Global.cmdImg;
                btn.ForeColor = Global.btnfore;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
            
            picFrmClose.BackColor = System.Drawing.Color.FromArgb(124,236,246);
            //picFrmClose.BackColor = System.Drawing.Color.Transparent;
        }

        private void checkTables()
        {
            OleDbConnection conn = GetConnection();
            OleDbDataAdapter myadapter = new OleDbDataAdapter();

            DataSet ds = new DataSet();
            String STR = "Select * from Cp_CdFm1 where CM_CLREFNO=" + Global.prtyCode + "";
            myadapter.SelectCommand = new OleDbCommand("Select * from Cp_CdFm1 where CM_CLREFNO=" + Global.prtyCode + "", conn);
            myadapter.Fill(ds, "Cp_CdFm1");
            if (ds.Tables[0].Rows.Count == 0) {
                OleDbDataAdapter myadapter1 = new OleDbDataAdapter();
                DataSet ds1 = new DataSet();
                String sql = "Update Cp_CdFm11 set [CM_CLREFNO]=" + Global.prtyCode + ";";
                myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                myadapter1.Fill(ds1, "Cp_CdFm11");
                sql = "INSERT INTO Cp_CdFm1 SELECT CM_SEQNO,CM_TYPE,CM_FC,CM_BN,CM_DBNO,CM_MTNO,CM_HEAD,CM_DESC,CM_LNKFRM,CM_CLREFNO FROM Cp_CdFm11;";
                myadapter1.SelectCommand = new OleDbCommand(sql, conn);
                myadapter1.Fill(ds1, "Cp_CdFm11");
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

        private void cmdEdit_Click(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
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


                String sql = "update Cp_CdFm1 set CM_DATA='" +  Convert.ToString(gridViewCMA.Rows[i].Cells[11].Value)+"' WHERE CM_CLREFNO=" + Global.prtyCode + " AND CM_REFNO=" + refno ;

                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                foreach(TextBox txt in Controls.OfType<TextBox>())
                {
                    txt.Clear();
                }
                     
            }
            transaction.Commit();
            con.Close();
            MessageBox.Show(GlobalMsg.insertMsg, "Perfect Tax Reporter - CMA 1.0");
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
                //checkTables();
                fillCMSDataGrid();
                foreach(TextBox txt in Controls.OfType<TextBox>())
                {
                    txt.Clear();
                }
            }
        }

        private void gridViewCMA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 13)
            {
                if (NotifyMainFormToOpenChildFormDirector != null)
                {
                    NotifyMainFormToOpenChildFormDirector();
                }
            }
            if(e.RowIndex == 14)
            {
                if(NotifyMainFormToOpenChildFormBanking !=null)
                {
                    NotifyMainFormToOpenChildFormBanking();
                }
            }
            if (e.RowIndex == 15)
            {
                if (NotifyMainFormToOpenChildFormCredit != null)
                {
                    NotifyMainFormToOpenChildFormCredit();
                }
            }
            if (e.RowIndex == 16)
            {
                if (NotifyMainFormToOpenChildFormAssociate != null)
                {
                    NotifyMainFormToOpenChildFormAssociate();
                }
            }
            if (e.RowIndex == 17)
            {
                if (NotifyMainFormToOpenChildFormRegistration != null)
                {
                    NotifyMainFormToOpenChildFormRegistration();
                }
            }
            if (e.RowIndex == 18)
            {
                if (NotifyMainFormToOpenChildFormPosition != null)
                {
                    NotifyMainFormToOpenChildFormPosition();
                }
            }
            if (e.RowIndex == 23)
            {
                if (NotifyMainFormToOpenChildFormPurchase != null)
                {
                    NotifyMainFormToOpenChildFormPurchase();
                }
            }
            if (e.RowIndex == 30)
            {
                if (NotifyMainFormToOpenChildFormBuyer != null)
                {
                    NotifyMainFormToOpenChildFormBuyer();
                }
            }
            if (e.RowIndex == 31)
            {
                if (NotifyMainFormToOpenChildFormSales != null)
                {
                    NotifyMainFormToOpenChildFormSales();
                }
            }
            if (e.RowIndex == 35)
            {
                if (NotifyMainFormToOpenChildFormParameter != null)
                {
                    NotifyMainFormToOpenChildFormParameter();
                }
            }
            if (e.RowIndex == 36)
            {
                if (NotifyMainFormToOpenChildFormAssets != null)
                {
                    NotifyMainFormToOpenChildFormAssets();
                }
            }
            if (e.RowIndex == 37)
            {
                if (NotifyMainFormToOpenChildFormProposed != null)
                {
                    NotifyMainFormToOpenChildFormProposed();
                }
            }

        }

        private void gridViewCMA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var list = new List<int> { 13, 14, 15, 16, 17, 18, 23, 30, 31, 35, 36, 37, 40, 41, 42, 44, 45 };
            if (list.Contains(e.RowIndex) && e.ColumnIndex == 11)
            {
                DataGridViewCell cell = gridViewCMA.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Value = "Double click to open form";
            }
        }
    }
}
