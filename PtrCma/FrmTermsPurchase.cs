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
    public partial class FrmTermsPurchase : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormPurchase;
        public FrmTermsPurchase()
        {
            InitializeComponent();
        }


        private void FrmTermsPurchase_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            Settings();
            setControlColor();
            setControlSize();
            //FrmTermsPurchase frmPurchase = new FrmTermsPurchase();
            //frmPurchase.MdiParent = this;
            //frmPurchase.StartPosition = FormStartPosition.CenterScreen;
            //frmPurchase.Show();
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
                lbl.Size = Global.lblmedSize;
                lbl.AutoSize = false;
                lblDomestic.Size = new System.Drawing.Size(100, 23);
                lblImport.Size = new System.Drawing.Size(100, 23);
            }
            //pictitle.Size = Global.titlelbl;

            //foreach (TextBox txt in Controls.OfType<TextBox>())  //Set Size of TextBox
            //{
            //    txt.Font = Global.txtSize;
            //    txt.Size = Global.txtmedSize;
            //    txt.AutoSize = false;
            //}
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

        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormPurchase();
                this.Hide();
            }
        }
    }
}
