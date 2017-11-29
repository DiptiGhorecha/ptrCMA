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
            this.BackColor = Global.appBackColr;
            //this.BackgroundImage = Global.startFrmBackImg;
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
            //if (frmParty.IsDisposed) { 
            //    frmParty = new FrmCMAParty();
            //    frmParty.Show();
            //}else
            //{
                frmParty.Show();
           // }
        
           frmMain.Enabled = false;
            
        }
        private void NotifyMainFormToCloseFormParty()
        {
            frmMain.Enabled = true;
            
        }
    }
 
}
