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
    public partial class FrmBankingArrangements : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormBanking;
        public FrmBankingArrangements()
        {
            InitializeComponent();
        }

        private void FrmBankingArrangements_Load(object sender, EventArgs e)
        {
            Settings();
    
        }

        private void Settings()
        {
            setControlColor();
            setControlSize();

            this.BackgroundImage = Global.partyFrmBackImg;

            foreach (Label lbl in Controls.OfType<Label>())
            {

                lbl.BackColor = Global.lblbackdetail;
                lbl.ForeColor = Global.lblforedetail;

            }

            lblTitle.BackColor = Global.lblbacktitle;
            lblTitle.ForeColor = Global.lblforetitle;

          //  this.BackColor = Global.frmbgcolor;
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
           // pictitle.Size = Global.titlelbl;
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
            this.BackgroundImage = Global.partyFrmBackImg;

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
            grdBanking.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            grdBanking.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormBanking();
                this.Hide();
            }
        }
    }
}
