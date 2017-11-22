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
    public partial class FrmMainCma : Form
    {
        public FrmMainCma()
        {
            InitializeComponent();
        }

        private void FrmMainCma_Load(object sender, EventArgs e)
        {
            settings();
        }

        public void settings()
        {
            this.Dock = DockStyle.Fill;
            this.BackgroundImage = Global.startFrmBackImg;

     
            foreach (Button c in Controls.OfType<Button>())
            {
                //set size of buttons
                c.Width = Global.cmdBtnWidthMain;
                c.Height = Global.cmdBtnHeightMain;
                c.Top= this.Height - 200;
                //set background image of buttons
                c.BackgroundImage = Global.cmdBtnBack;
   
                c.ImageAlign = System.Drawing.ContentAlignment.TopRight;
                c.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                c.Font = Global.cmdBtnfont;
                c.ForeColor = Global.cmdFontColr;

            }
            //set position of command buttons on form
            int spacing = (this.Width - (Global.cmdBtnWidthMain * 5)) / 6;
            cmdBnkStnd.Left = spacing;
            cmdCMAProj.Left = cmdBnkStnd.Right + spacing;
            cmdBackup.Left = cmdCMAProj.Right + spacing;
            cmdRestore.Left = cmdBackup.Right + spacing;
            cmdExit.Left = cmdRestore.Right + spacing;

            //set command button icon
            cmdBnkStnd.Image = Global.cmdBnkStndIcon;
            cmdCMAProj.Image = Global.cmdCmsProjIcon;
            cmdBackup.Image = Global.cmdBackupIcon;
            cmdRestore.Image = Global.cmdRestoreIcon;
            cmdExit.Image = Global.cmdExitIcon;

            //set command button text
            cmdBnkStnd.Text = "  BANK STANDARD";
            cmdCMAProj.Text = "  CMA PROJECT";
            cmdBackup.Text = "  BACKUP DATA";
            cmdRestore.Text = "  RESTORE DATA";
            cmdExit.Text = "  EXIT DATA";

            lblCMSCaption.Font = Global.lblCMSfont;
            lblCMSCaption.ForeColor = Global.lblCMSColr;
            lblCMSCaption.BackColor = System.Drawing.Color.Transparent;
            lblCMSCaption.Location= new System.Drawing.Point(cmdBnkStnd.Left, 100);
        }

        private void cmdCMAProj_Click(object sender, EventArgs e)
        {
            FrmCMAParty p = new FrmCMAParty();
            p.StartPosition = FormStartPosition.Manual;
            p.Location = new Point(this.Parent.Location.X + (this.Parent.Width - p.Width) / 2, p.Location.Y + (this.Parent.Height - p.Height) / 2);
            p.Show();
            this.Close();
        }
    }
}
