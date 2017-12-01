using MessageBoxExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PtrCma
{
    public partial class FrmMDICma : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        private FrmMainCma frmMain;
        private FrmCMAParty frmParty;
        private FrmCredit frmCredit;
        private FrmCMA frmCmaa;
        public FrmMDICma()
        {
            InitializeComponent();
            
        }

        private void FrmMDICma_Load(object sender, EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
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
            frmParty.Location = new Point(this.Location.X + (this.Width - frmParty.Width) / 2, (frmParty.Location.Y + (this.Height - frmParty.Height) / 2) + 20);
            frmParty.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmParty.NotifyMainFormToOpenChildFormCma += NotifyMainFormToOpenFormCma;

            frmCmaa = new FrmCMA();
            frmCmaa.MdiParent = this;
            frmCmaa.Location = new Point(0, 70);
            frmCmaa.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;


            frmCredit = new FrmCredit();
            frmCredit.MdiParent = this;
           // frmCredit.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;

            frmMain = new FrmMainCma();
            frmMain.MdiParent = this;
            frmMain.NotifyMainFormToOpenChildFormParty += NotifyMainFormToOpenFormParty;
            
            // f.StartPosition = FormStartPosition.CenterScreen;
            frmMain.Show();
            
           // f.Refresh();
            
        }

        private void NotifyMainFormToOpenFormCma()
        {

            //frmParty.Location = new Point(this.Location.X + (this.Width - frmParty.Width) / 2, (frmParty.Location.Y + (this.Height - frmParty.Height) / 2)+35);

            frmCmaa.Show();
            frmMain.Enabled = false;
        }

        private void NotifyMainFormToOpenFormParty()
        {
    
            //frmParty.Location = new Point(this.Location.X + (this.Width - frmParty.Width) / 2, (frmParty.Location.Y + (this.Height - frmParty.Height) / 2)+35);
            
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
            lblCopyright.Width = this.Width-4;
            lblCopyright.BackgroundImage = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.footerbg.png"));
            lblCopyright.Left = this.Location.X + (this.Width - lblCopyright.Width) / 2;
            lblCopyright.Top = this.Bottom - lblCopyright.Height-6;
            

        }

        private void pictMinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictCloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.perfecttaxreporter.com");
        }
    }
 
}
