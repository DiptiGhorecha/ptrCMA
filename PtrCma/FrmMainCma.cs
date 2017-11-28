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
            this.Visible = false;
            InitializeComponent();

        }

        private void FrmMainCma_Load(object sender, EventArgs e)
        {
            settings();
            this.Visible = true;
        }

        public void settings()
        {
            this.Dock = DockStyle.Fill;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImage = Global.startFrmBackImg;
            int spacing = (this.Width - (Global.cmdBtnWidthMain * 5)) / 6;
            List<Button> buttons = new List<Button>();
            for (int i = 0; i < 5; i++)
            {
                Button newButton = new Button();
                newButton.Width = Global.cmdBtnWidthMain;
                newButton.Height = Global.cmdBtnHeightMain;
                newButton.Top = this.Height - 200;
                //set background image of buttons
                newButton.BackgroundImage = Global.cmdBtnBack;

                newButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
                newButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                newButton.Font = Global.cmdBtnfont;
                newButton.ForeColor = Global.cmdFontColr;
                if (i == 0)
                {
                    newButton.Name = "cmdBnkStnd";
                    newButton.Text = "  BANK STANDARD";
                    newButton.Left = spacing;
                    newButton.Image = Global.cmdBnkStndIcon;
                    
                }
                if (i == 1)
                {
                    newButton.Name = "cmdCMAProj";
                    newButton.Text = "  CMA PROJECT";
                    newButton.Left = buttons[0].Right + spacing;
                    newButton.Image = Global.cmdCmsProjIcon;

                }
                if (i == 2)
                {
                    newButton.Name = "cmdBackup";
                    newButton.Text = "  BACKUP DATA";
                    newButton.Left = buttons[1].Right + spacing;
                    newButton.Image = Global.cmdBackupIcon;
                }
                if (i == 3)
                {
                    newButton.Name = "cmdRestore";
                    newButton.Text = "  RESTORE DATA";
                    newButton.Left = buttons[2].Right + spacing;
                    newButton.Image = Global.cmdRestoreIcon;
                }
                if (i == 4)
                {
                    newButton.Name = "cmdExit";
                    newButton.Text = "  EXIT";
                    newButton.Left = buttons[3].Right + spacing;
                    newButton.Image = Global.cmdExitIcon;
                }
                newButton.Click += new EventHandler(NewButton_Click);
                buttons.Add(newButton);
                this.Controls.Add(newButton);
            }

            
            //foreach (Button c in Controls.OfType<Button>())
            //{
            //    //set size of buttons
            //    c.Width = Global.cmdBtnWidthMain;
            //    c.Height = Global.cmdBtnHeightMain;
            //    c.Top= this.Height - 200;
            //    //set background image of buttons
            //    c.BackgroundImage = Global.cmdBtnBack;

            //    c.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            //    c.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //    c.Font = Global.cmdBtnfont;
            //    c.ForeColor = Global.cmdFontColr;

            //}
            //set position of command buttons on form

            //cmdBnkStnd.Left = spacing;
            //cmdCMAProj.Left = cmdBnkStnd.Right + spacing;
            //cmdBackup.Left = cmdCMAProj.Right + spacing;
            //cmdRestore.Left = cmdBackup.Right + spacing;
            //cmdExit.Left = cmdRestore.Right + spacing;

            ////set command button icon
            //cmdBnkStnd.Image = Global.cmdBnkStndIcon;
            //cmdCMAProj.Image = Global.cmdCmsProjIcon;
            //cmdBackup.Image = Global.cmdBackupIcon;
            //cmdRestore.Image = Global.cmdRestoreIcon;
            //cmdExit.Image = Global.cmdExitIcon;

            ////set command button text
            //cmdBnkStnd.Text = "  BANK STANDARD";
            //cmdCMAProj.Text = "  CMA PROJECT";
            //cmdBackup.Text = "  BACKUP DATA";
            //cmdRestore.Text = "  RESTORE DATA";
            //cmdExit.Text = "  EXIT DATA";
            Label newLbl = new Label();
            newLbl.Name = "lblCMSCaption";
            newLbl.Font = Global.lblCMSfont;
            newLbl.ForeColor = Global.lblCMSColr;
            newLbl.BackColor = System.Drawing.Color.Transparent;
            newLbl.Text = "CMS DATA v 1.0";
            newLbl.Location = new System.Drawing.Point(spacing, 100);
            newLbl.Visible = true;
            foreach (Button c in Controls.OfType<Button>())
            {
                //set size of buttons
                c.Visible = true;
            }
           
        }
        

        private void NewButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int counter = 4;
            for (int i = 0; i < counter; i++)
            {
                if (btn.Name == ("cmdCMAProj"))
                {
                    FrmCMAParty p = new FrmCMAParty();
                    p.StartPosition = FormStartPosition.Manual;
                    p.Location = new Point(this.Parent.Location.X + (this.Parent.Width - p.Width) / 2, p.Location.Y + (this.Parent.Height - p.Height) / 2);
                    p.Show();
                    this.Close();
                    break;
                }
            }
            for (int i = 1; i < counter; i++)
            {
                if (btn.Name == ("cmdExit"))
                {
                    System.Environment.Exit(1);
                }
            }
        }
        
        private void cmdCMAProj_Click(object sender, EventArgs e)
        {
            
          




        }

        private void cmdBackup_Click(object sender, EventArgs e)
        {
            //FrmMajorBuyer d = new FrmMajorBuyer();
            //d.StartPosition = FormStartPosition.Manual;
            //d.Location = new Point(this.Parent.Location.X + (this.Parent.Width - d.Width) / 2, d.Location.Y + (this.Parent.Height - d.Height) / 2);
            //d.Show();
            //this.Close();
        }
    }
}
