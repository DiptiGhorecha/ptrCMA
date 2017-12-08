using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PtrCma
{
    public partial class FrmDetailDirector : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormDirector;

        public FrmDetailDirector()
        {
            InitializeComponent();
        }

        private void FrmDetailDirector_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            
            FrmDetailDirector frmDirector = new FrmDetailDirector();
            frmDirector.MdiParent = this;
            frmDirector.StartPosition = FormStartPosition.CenterParent;
            //frmDirector.StartPosition = FormStartPosition.CenterScreen;
            frmDirector.Show();

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

        private void cmdAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
