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
using System.Threading;

namespace PtrCma
{
    public partial class FrmMDICma : Form
    {
        public Action NotifyMainFormToCloseChildFormParty;
        public Action NotifyMainFormToCloseChildFormDirector;
        private FrmMainCma frmMain;
        private FrmCMAParty frmParty;
        private FrmCredit frmCredit;
        private FrmCMA frmCmaa;
        private FrmDetailDirector frmDirector;
        public FrmMDICma()
        {
            InitializeComponent();
        }


        private void FrmMDICma_Load(object sender, EventArgs e)
        {
           Double ScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            Double ScreenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            if (ScreenWidth < 1280 || ScreenHeight < 768)
            {
                MessageBox.Show(GlobalMsg.resolutionMsg, "Perfect Tax Reporter - CMA 1.0");
            }
            
            //string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            //string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
         
           // label1.Text = ("Resolution: " + screenWidth + "x" + screenHeight);
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
            frmDirector = new FrmDetailDirector();
            frmDirector.MdiParent = this;
            frmDirector.Location = new Point(0, 70);
            frmDirector.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmDirector.NotifyMainFormToCloseChildFormDirector += NotifyMainFormToCloseFormDirector;

            frmParty = new FrmCMAParty();
            frmParty.MdiParent = this;
            frmParty.Location = new Point(this.Location.X + (this.Width - frmParty.Width) / 2, (frmParty.Location.Y + (this.Height - frmParty.Height) / 2) + 20);
            frmParty.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmParty.NotifyMainFormToOpenChildFormCma += NotifyMainFormToOpenFormCma;

            frmCmaa = new FrmCMA();
            frmCmaa.MdiParent = this;
            frmCmaa.Location = new Point(0, 70);
            frmCmaa.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmCmaa.NotifyMainFormToOpenChildFormDirector += NotifyMainFormToOpenFormDirector;
      

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


        private void NotifyMainFormToOpenFormDirector()
        {

            //frmParty.Location = new Point(this.Location.X + (this.Width - frmParty.Width) / 2, (frmParty.Location.Y + (this.Height - frmParty.Height) / 2)+35);
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmDirector.Show();
            
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

        private void NotifyMainFormToCloseFormDirector()
        {
            frmCmaa.Enabled = true;

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
