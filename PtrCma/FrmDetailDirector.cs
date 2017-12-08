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
            Settings();
            
            FrmDetailDirector frmDirector = new FrmDetailDirector();
            frmDirector.MdiParent = this;
            frmDirector.StartPosition = FormStartPosition.CenterScreen;
            frmDirector.Show();

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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormDirector();
                this.Hide();
            }
        }
    }
}
