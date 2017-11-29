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
    public partial class FrmDeatilAssociate : Form
    {
        public FrmDeatilAssociate()
        {
            InitializeComponent();
        }


        private void FrmDeatilAssociate_Load(object sender, EventArgs e)
        {
            Settings();
           
            FrmDeatilAssociate frmAssociate = new FrmDeatilAssociate();
            frmAssociate.MdiParent = this;
            frmAssociate.StartPosition = FormStartPosition.CenterScreen;
            frmAssociate.Show();
        }

        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;

            foreach (Label lbl in Controls.OfType<Label>())
            {

                lbl.BackColor = Global.lblbackdetail;
                lbl.ForeColor = Global.lblforedetail;

            }

            lbltitle.BackColor = Global.lblbacktitle;
            lbltitle.ForeColor = Global.lblforetitle;

           // this.BackColor = Global.frmbgcolor;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                FrmMDICma frmCma = new FrmMDICma();
                frmCma.Show();
            }
        }

       
    }
}
