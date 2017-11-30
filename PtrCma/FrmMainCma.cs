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
        public Action NotifyMainFormToOpenChildFormParty;
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
            for (int i = 0; i < 5; i++) // Adding five command buttons at runtime
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


            Label newLbl = new Label();  // Adding Application Caption Runtime
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
                    if (NotifyMainFormToOpenChildFormParty != null)
                    {
                        NotifyMainFormToOpenChildFormParty();
                    }

                    break;
                }
                if (btn.Name == ("cmdBackup"))
                {
                    if (NotifyMainFormToOpenChildFormParty != null)
                    {
                        NotifyMainFormToOpenChildFormParty();
                    }

                    break;
                }

                if (btn.Name == ("cmdExit"))
                {
                    DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Exit ?", "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
                    if (dialogResult == DialogResult.Yes)
                    {
                        System.Environment.Exit(1);
                    }



                }
            }

        }
   

        private void FrmMainCma_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
