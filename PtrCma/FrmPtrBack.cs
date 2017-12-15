using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;


namespace PtrCma
{
    
    public partial class FrmPtrBack : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        String pth= "E:\\Ptr1\\PtrBack";
        
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        public Action NotifyMainFormToCloseChildFormBackup;
        public FrmPtrBack()
        {
            InitializeComponent();
        }

        protected void FrmPtrBack_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
            
        
            //foreach(DriveType.CDRom)
            //{

            //}
            //comboDrive.DisplayMember = "Name";      
            Settings();
            fillgrid();
        }

     

        private void Settings()
        {
            this.BackgroundImage = Global.partyFrmBackImg;      // Show BackGround Image
            setControlcolor(); //Label and Textbox BackColor/Forecolor
            setControlsize(); //Label and TextBox Resize

            grdBackup.RowsDefaultCellStyle.BackColor = Color.White;     // Row Color of Gridview

            // Column Header Color of Gridview
            grdBackup.ColumnHeadersHeight = 30;
            grdBackup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdBackup.EnableHeadersVisualStyles = false;
            grdBackup.ColumnHeadersDefaultCellStyle.ForeColor = Global.grdPartyForeColor;
            grdBackup.ColumnHeadersDefaultCellStyle.BackColor = Global.grdPartyBackColor;
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
            grdBackup.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            grdBackup.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void cmdBackup_Click(object sender, EventArgs e)
        {
            

            if (comboDrive.SelectedText == "")
            {
                //string baseDirectory = "E:\\Ptr1\\PtrBack";
                //string baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                
                string mdbSourceFilePath =  Application.StartupPath + "\\Resources\\PtrCma.accdb"; 
                string mdbTargetFileName = "PtrCma.mdb";
                string fullDirectory = Path.Combine(comboDrive.Text, "PtrBack" );
                if (!Directory.Exists(fullDirectory))
                {
                    if (!Directory.Exists(comboDrive.Text))
                        Directory.CreateDirectory(comboDrive.Text);
                    if (!Directory.Exists(fullDirectory))
                        Directory.CreateDirectory(fullDirectory);

                    string mdbTargetFilePath = Path.Combine(fullDirectory, mdbTargetFileName);
                   
                        File.Copy(mdbSourceFilePath, mdbTargetFilePath);
                        MessageBox.Show("Backup Successfully Created");
                }
                   
               else
                {
                    MessageBox.Show("File alraedy Exist");
                }
            }
            fillgrid();
        }
    
        private void fillgrid()
        {
            //string strpath = @"E:\PtrBack\";
            //string[] folders = Directory.GetFiles(strpath, "*", SearchOption.TopDirectoryOnly);
            ////string[] folders = Directory.GetFiles("E:\\Ptr1\\PtrBack");
            //grdBackup.DataSource = folders;

            var currentDirInfo = new DirectoryInfo(this.comboDrive.Text + "\\PtrBack");
            //Path.GetFileName(filename);
          //  String dirName = dir.Name;
            var files = currentDirInfo.GetFiles("*", SearchOption.AllDirectories);
            //var files = currentDirInfo.GetFiles("*",SearchOption.AllDirectories);
            grdBackup.DataSource = files;

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
                foreach (var drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady != true)
                    {
                        comboDrive.Items.Add(drive.Name);
                        
                    }
                    else
                    {
                       
                    }
                }
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormBackup();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                NotifyMainFormToCloseChildFormBackup();
                this.Hide();
            }
        }
    }
}
