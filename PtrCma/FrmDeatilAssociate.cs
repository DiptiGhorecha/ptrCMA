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
            foreach (Label l in Controls.OfType<Label>())
            {

                l.BackColor = Global.lblbackdetail;
                l.ForeColor = Global.lblforedetail;

            }

            lbltitle.BackColor = Global.lblbacktitle;
            lbltitle.ForeColor = Global.lblforetitle;

            this.BackColor = Global.frmbgcolor;

            FrmDeatilAssociate p = new FrmDeatilAssociate();
            p.MdiParent = this;
            p.StartPosition = FormStartPosition.CenterScreen;
            p.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                FrmMDICma c = new FrmMDICma();
                c.Show();
            }
        }

       
    }
}
