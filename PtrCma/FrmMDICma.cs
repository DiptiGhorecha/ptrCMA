using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PtrCma
{
    public partial class FrmMDICma : Form
    {
        private FrmMainCma frmMain;
        private FrmCMAParty frmParty;
        public FrmMDICma()
        {
            InitializeComponent();
            
        }

        private void FrmMDICma_Load(object sender, EventArgs e)
        {
            this.Text = Global.companyName;
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Global.appBackColr;
                    client.BackgroundImage = Global.startFrmBackImg;
                    // 4#
                    break;
                }

            }
            Settings();
            frmParty = new FrmCMAParty();
            frmParty.MdiParent = this;
            frmParty.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmMain = new FrmMainCma();
            frmMain.MdiParent = this;
            frmMain.NotifyMainFormToOpenChildFormParty += NotifyMainFormToOpenFormParty;
            // f.StartPosition = FormStartPosition.CenterScreen;
            frmMain.Show();
            
           // f.Refresh();
            
        }
        private void NotifyMainFormToOpenFormParty()
        {
           frmParty.Show();
           frmMain.Enabled = false;
        }
        private void NotifyMainFormToCloseFormParty()
        {
            frmMain.Enabled = true;
            
        }
        public void Settings()
        {
            this.BackColor = Global.appBackColr;
            this.BackgroundImage = Global.startFrmBackImg;
            this.lblCompanyName.Text = "Perfect Tax Reporter - CMA 1.0";
            this.lblCompanyName.Font = Global.lblCompNamefont;
            this.lblCompanyName.Top = 5;
            this.lblCompanyName.Left = 5;
            this.lblCompanyName.ForeColor = Global.lblCompColr;
            this.lblCompanyName.BackgroundImage = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.lblBack.png"));
            this.pictMinBtn.Top = 5;
            this.pictMinBtn.Left = this.Width - this.pictMinBtn.Width - this.pictCloseBtn.Width-5;
            this.pictCloseBtn.Top = 5;
            this.pictCloseBtn.Left = this.Width - this.pictCloseBtn.Width - 5;
        }

        private void pictMinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 
}
