using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PtrCma
{
    public partial class FrmPtrRestore : Form
    {
        public Action NotifyMainFormToCloseChildFormRestore;
        public FrmPtrRestore()
        {
            InitializeComponent();
            
        }
        private void FrmPtrRestore_Load(object sender, EventArgs e)
        {
            Settings();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
        }
        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;      // Show BackGround Image
            setControlcolor(); //Label and Textbox BackColor/Forecolor
            setControlsize(); //Label and TextBox Resize

            grdRestore.RowsDefaultCellStyle.BackColor = Color.White;     // Row Color of Gridview

            // Column Header Color of Gridview
            grdRestore.ColumnHeadersHeight = 30;
            grdRestore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdRestore.EnableHeadersVisualStyles = false;
            grdRestore.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            grdRestore.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;
            radioHD.Checked = true;
            if (radioHD.Checked == true)
            {
                comboDrive.ResetText();
                foreach (var drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady == true)
                    {
                        comboDrive.Items.Add(drive.Name);
                    }
                    else
                    {

                    }
                    //this.comboDrive.Items.Add("Select One "); //Error is Coming at this Point
                    return;
                }
                fillgrid();
            }
            else
            {
                comboDrive.ResetText();
                foreach (var drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady == true)
                    {

                    }
                    else
                    {
                        comboDrive.Items.Add(drive.Name);
                    }
                }
                fillgrid();
            }
        }

        private void setControlsize()
        {
            foreach (Label lbl in Controls.OfType<Label>()) //Set Size of Label
            {
                lbl.Font = Global.lblSize;
                lbl.Size = Global.medsizelbl;
                lbl.AutoSize = false;
            }
            foreach (Button btn in Controls.OfType<Button>())   //Set Size of Button
            {
                btn.Size = Global.btnbackup;
                cmdExit.Size = Global.btnSmallSize;
            }
        }

        private void setControlcolor()
        {
            foreach (Label lbl in Controls.OfType<Label>()) //Set the Label Color
            {
                lbl.BackColor = Global.lblColorPartyMst;
                lbl.ForeColor = Global.lblForeColorPartyMst;
                lbl.Font = Global.lblPartyfont;
            }

            foreach (Button btn in Controls.OfType<Button>())  // Set the  Button Color
            {
                btn.ForeColor = Global.btnfore;
                btn.BackgroundImage = Global.cmdImg;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }

            //  Set the Gridview Color
            grdRestore.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            grdRestore.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        public void fillgrid()
        {
            var currentDirInfo = new DirectoryInfo(this.comboDrive.Text + "\\PtrBack");
            var files = currentDirInfo.GetFiles("*", SearchOption.AllDirectories);
            grdRestore.DataSource = files;

            grdRestore.Columns[0].Visible = true;
            grdRestore.Columns[0].HeaderText = "Name";
            grdRestore.Columns[0].Width = 200;

            grdRestore.Columns[1].Visible = false;
            grdRestore.Columns[2].Visible = false;
            grdRestore.Columns[3].Visible = false;
            grdRestore.Columns[4].Visible = false;
            grdRestore.Columns[5].Visible = false;
            grdRestore.Columns[6].Visible = false;
            grdRestore.Columns[7].Visible = false;
            grdRestore.Columns[8].Visible = false;
            grdRestore.Columns[9].Visible = false;
            grdRestore.Columns[10].Visible = false;
            grdRestore.Columns[11].Visible = false;
            grdRestore.Columns[12].Visible = false;
            grdRestore.Columns[13].Visible = false;
            grdRestore.Columns[14].Visible = false;
        }

     

        private void radioHD_CheckedChanged(object sender, EventArgs e)
        {
            comboDrive.Items.Clear();

            if (radioHD.Checked == true)
            {
                foreach (var drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady == true)
                    {
                        comboDrive.Items.Add(drive.Name);
                    }
                    else
                    {

                    }
                }

            }
        }

        private void radioCD_CheckedChanged(object sender, EventArgs e)
        {
            comboDrive.Items.Clear();

            if (radioCD.Checked == true)
            {
                 comboDrive.Items.Clear();
                foreach (var drive in DriveInfo.GetDrives())
                {
                        if (drive.DriveType == DriveType.CDRom)
                        {
                            comboDrive.Items.Add(drive.Name);
                           // MessageBox.Show(drive.Name + " " + drive.IsReady.ToString());
                        }
                        else if(drive.DriveType == DriveType.Removable)
                        {
                            if (DriveType.Removable != null)
                            {
                             comboDrive.Items.Add(drive.Name);
                            }
                            else
                            {
                                MessageBox.Show("There is no Media Drive");
                            }
                        }
                    //}
                  
                }
            }
            fillgrid();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormRestore();
                this.Hide();
            }
            comboDrive.Items.Clear();
            grdRestore.DataSource = null;
            grdRestore.Rows.Clear();
            grdRestore.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormRestore();
                this.Hide();

            }
            comboDrive.Items.Clear();
            grdRestore.ClearSelection();
        }

        private void comboDrive_Click(object sender, EventArgs e)
        {
            if (radioCD.Checked == true)
            {
                comboDrive.Items.Clear();
                foreach (var drive in DriveInfo.GetDrives())
                {
                    if (drive.DriveType == DriveType.CDRom)
                    {
                        comboDrive.Items.Add(drive.Name);
                        // MessageBox.Show(drive.Name + " " + drive.IsReady.ToString());
                    }
                    else if (drive.DriveType == DriveType.Removable)
                    {
                        if (DriveType.Removable != null)
                        {
                            comboDrive.Items.Add(drive.Name);
                        }
                        else
                        {
                            MessageBox.Show("There is no Media Drive");
                        }
                    }
                    //}

                }
            }
            else
            {
                comboDrive.Items.Clear();
                foreach (var drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady == true)
                    {
                        comboDrive.Items.Add(drive.Name);
                        if (comboDrive.SelectedValue != "")
                        {
                            fillgrid();
                            break;
                        }

                    }
                    else if (drive.DriveType == DriveType.CDRom)
                    {

                    }
                    else if (drive.DriveType == DriveType.Removable)
                    {

                    }
                    else
                    {

                    }
                }
            }
        }

        private void cmdRestore_Click(object sender, EventArgs e)
        {
            cellClick();
            string dbFileName = "PtrCma.mdb";
            string pathBackup = (comboDrive.Text + "PtrBack" + "\\" + grdRestore.CurrentCell.Value); // backup path
          // string pathBackup = @"E:\\PtrBack\\PtrCma_20171216152117.mdb"; //you may use file dialog to select this backuppath
           // string CurrentDatabasePath = Path.Combine(Environment.CurrentDirectory,"\\Resources", dbFileName);
            string CurrentDatabasePath = Path.Combine(Application.StartupPath,  dbFileName);
            File.Copy(pathBackup, CurrentDatabasePath, true);
            MessageBox.Show("Successful Restore! ");
        }

        private void grdRestore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdRestore.Rows[e.RowIndex];
                cellClick();
            }
        }

        private void cellClick()
        {
                grdRestore.Columns[0].Visible = true;
                grdRestore.Columns[0].HeaderText = "Name";
                grdRestore.Columns[0].Width = 200;

                grdRestore.Columns[1].Visible = false;
                grdRestore.Columns[2].Visible = false;
                grdRestore.Columns[3].Visible = false;
                grdRestore.Columns[4].Visible = false;
                grdRestore.Columns[5].Visible = false;
                grdRestore.Columns[6].Visible = false;
                grdRestore.Columns[7].Visible = false;
                grdRestore.Columns[8].Visible = false;
                grdRestore.Columns[9].Visible = false;
                grdRestore.Columns[10].Visible = false;
                grdRestore.Columns[11].Visible = false;
                grdRestore.Columns[12].Visible = false;
                grdRestore.Columns[13].Visible = false;
                grdRestore.Columns[14].Visible = false;
                // txtRefParty.Text = row.Cells["CL_REFNO"].Value.ToString();
           
        }
    }
}
