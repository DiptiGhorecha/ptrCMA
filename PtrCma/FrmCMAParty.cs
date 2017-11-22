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
    public partial class FrmCMAParty : Form
    {
        public FrmCMAParty()
        {
            InitializeComponent();
        }

        private void FrmCMAParty_Load(object sender, EventArgs e)
        {
           // this.Dock = DockStyle.Fill;
            this.Text = Global.PartyMaster;


            foreach (Label l in Controls.OfType<Label>())
            {

                l.BackColor = Global.lblColorPartyMst;
                l.ForeColor = Global.lblForeColorPartyMst;
            }

            foreach (TextBox t in Controls.OfType<TextBox>())
            {

                t.BackColor = Global.lblColorPartyMst;
                
            }


            this.BackColor = Global.backColorPartyMst;
         //   FrmCMAParty p = new FrmCMAParty();
          //  p.MdiChildren = true;
          //  p.MdiParent = this;
    
          ////  p.StartPosition = FormStartPosition.CenterParent;
          //  p.StartPosition = FormStartPosition.Manual;
          //  p.Location = new Point(this.Location.X + (this.Width - p.Width) / 2, p.Location.Y + (this.Height - p.Height) / 2);
          //  p.Show();
            



           
      
        }


    }
}
