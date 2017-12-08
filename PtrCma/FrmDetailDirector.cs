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
    public partial class FrmDetailDirector : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormDirector;
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter dataAdapter;

        public FrmDetailDirector()
        {
            InitializeComponent();
        }

        private void FrmDetailDirector_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            fillgrid();
            FrmDetailDirector frmDirector = new FrmDetailDirector();
            frmDirector.MdiParent = this;
            frmDirector.StartPosition = FormStartPosition.CenterParent;
            frmDirector.Show();

          
        }

        private void fillgrid()
        {
            con = new OleDbConnection(connectionString);
            DataSet ds = new DataSet();
            dataAdapter = new OleDbDataAdapter("select * from Cx_Cd101",con);
            dataAdapter.Fill(ds, "Cx_Cd101");
            grdViewDirectors.DataMember = "Cx_Cd101";
            grdViewDirectors.DataSource = ds;
            con.Close();

            //Show selected Column in Gridview
            for (int i = 0; i <= grdViewDirectors.Columns.Count - 1; i++)
            {
                grdViewDirectors.Columns[i].ReadOnly = true;
                grdViewDirectors.Columns[i].Visible = false;
            }

            grdViewDirectors.Columns[1].Visible = true;
            grdViewDirectors.Columns[1].HeaderText = "Director Name";
            grdViewDirectors.Columns[1].Width = 250;

        }

        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;
            grdViewDirectors.RowsDefaultCellStyle.BackColor = Color.White;     // Row Color of Gridview

            // Column Header Color of Gridview
            grdViewDirectors.ColumnHeadersHeight = 30;
            grdViewDirectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdViewDirectors.EnableHeadersVisualStyles = false;
            grdViewDirectors.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            grdViewDirectors.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;
            setControlColor();
            setControlSize();
        }

        private void setControlSize()
        {
            foreach (Button btn in Controls.OfType<Button>())   //Set Size of Button
            {
                btn.Size = Global.smallbtn;
                cmdDelete.Size = Global.btnmedSize;
            }

            foreach (Label lbl in Controls.OfType<Label>()) //Set Size of Label
            {
                lbl.Font = Global.lblSize;
                lbl.Size = Global.lblmedSize;
                lbl.AutoSize = false;
            }
            pictitle.Size = Global.titlelbl;
           // pictitle.BackColor = Global.title;

            foreach (TextBox txt in Controls.OfType<TextBox>())  //Set Size of TextBox
            {
                txt.Font = Global.txtSize;
                txt.Size = Global.txtmedSize;
                txt.AutoSize = false;
            }
        }

        private void setControlColor()
        {
            

            foreach (Label lbl in Controls.OfType<Label>())
            {
                lbl.BackColor = Global.lblbackdetail;
                lbl.ForeColor = Global.lblforedetail;
            }

            //pictitle.BackColor = Global.lblbacktitle;
            //pictitle.ForeColor = Global.lblforetitle;

            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.ForeColor = Global.btnfore;
                btn.BackgroundImage = Global.cmdImg;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
          //  picFrmClose.BackColor = System.Drawing.Color.FromArgb(124, 236, 246);

            //  Set the Gridview Color
            grdViewDirectors.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            grdViewDirectors.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = connectionString;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "insert into Cx_Cd101(CD_NAME,CD_AGE,CD_PAN,CD_ADD,CD_PHONE,CD_NET)values('" + txtName.Text + "','" + txtAge.Text + "','" + txtPan.Text + "','" + txtAdd.Text + "','" + txtPhone.Text + "','" + txtNet.Text + "')";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            fillgrid();
        }
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormDirector();
                this.Hide();
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {

        }

      
    }
}
