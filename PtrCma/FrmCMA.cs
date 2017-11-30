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
        public FrmCMA()
        {
            InitializeComponent();
        }

        public void Settings()
        {
            this.Width = this.Parent.Width-4;
            this.Height = this.Parent.Height - 105;
            
            this.BackColor = Global.appBackColr;
            //Topic list box label
            lstViewTopic.Top = 0;
            lstViewTopic.Left = this.Left+1;
            lstViewTopic.Width = (this.Width-panelCmdBtns.Width-10)/2;
            lstViewTopic.Height = Global.chrtLstViewHeight;
            lstViewTopic.BackColor = Global.lstBxBackColorCMS;
            chart2.BackColor = Global.chartBackColorCMS;
           
            panelCmdBtns.Left = lstViewTopic.Right + 1;
            chart2.Left = panelCmdBtns.Right+2;
            chart2.Width= (this.Width - panelCmdBtns.Width) / 2 ;
            chart2.Height = Global.chrtLstViewHeight;
            gridViewCMA.Width = this.Width-3;
            
            gridViewCMA.Top = lstViewTopic.Bottom+50;
            gridViewCMA.Height = this.Height - Global.chrtLstViewHeight - 50;
            gridViewCMA.Left = this.Left+1;
            gridViewCMA.ColumnHeadersDefaultCellStyle.BackColor = Global.gridHeaderColorCMS;
            gridViewCMA.ColumnHeadersHeight = 30;
            gridViewCMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridViewCMA.EnableHeadersVisualStyles = false;

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

            Settings();
            checkTables();
            fillTopicListBox();
            fillCMSDataGrid();
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
    }
}
