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
        //OleDbConnection con;
        //OleDbCommand cmd;
      //  String pth= "E:\\Ptr1\\PtrBack";
        
        String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\Resources\\PtrCma.accdb;";  //Connection String
        public Action NotifyMainFormToCloseChildFormBackup;
        public FrmPtrBack()
        {
            InitializeComponent();
        }

        protected void FrmPtrBack_Load(object sender, EventArgs e)
        {
            comboDrive.DataSource = null;
            comboDrive.ResetText();
            //comboDrive.Items.Clear();
            //comboDrive.Refresh();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true); //Stop the Flickering
                
            Settings();
            // fillgrid();
            //comboDrive.Items.Clear();
            grdBackup.DataSource = null;
            grdBackup.Rows.Clear();
            grdBackup.Refresh();
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
            //if (radioHD.Checked == true)
            //{
            //    comboDrive.ResetText();
            //    foreach (var drive in DriveInfo.GetDrives())
            //    {
            //        if (drive.IsReady == true)
            //        {
            //           // fillgrid();
            //            comboDrive.Items.Add(drive.Name);
            //        }
            //        else
            //        {

            //        }
            //        //this.comboDrive.Items.Add("Select One "); //Error is Coming at this Point
            //        return;
            //    }
            //   // fillgrid();
            //}
            //else
            //{
            //    comboDrive.ResetText();
            //    foreach (var drive in DriveInfo.GetDrives())
            //    {
            //        if (drive.IsReady == true)
            //        {

            //        }
            //        else
            //        {
            //            comboDrive.Items.Add(drive.Name);
            //        }
            //    }
            // //   fillgrid();
            //}
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
            DateTime dt = DateTime.Now;
            try
            { 
            if (comboDrive.SelectedText == "")
            {
                   
                    string mdbSourceFilePath = Application.StartupPath + "\\Resources\\PtrCma.accdb";
                    //string mdbTargetFileName = "PtrCma_" + String.Format("yyyyMMdd_HHmmss", dt) +".mdb";
                    //string mdbTargetFileName = "PtrCma_" + DateTime.Now.ToString("yyyymmddhhmmss") + ".mdb";
                    string mdbTargetFileName = "PtrCma_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".mdb";
                    // String abc=String.Format("{0:d/M/yyyy HH:mm:ss}", DateTime.Now);
                    string fullDirectory = Path.Combine(comboDrive.Text, "PtrBack");

                    if (!Directory.Exists(fullDirectory))
                    {
                        if (!Directory.Exists(comboDrive.Text))
                            Directory.CreateDirectory(comboDrive.Text);
                        if (!Directory.Exists(fullDirectory))
                            Directory.CreateDirectory(fullDirectory);
                    }
                    try
                    {
                        if (mdbTargetFileName != null)
                        {
                            string mdbTargetFilePath = Path.Combine(fullDirectory, mdbTargetFileName);
                            File.Copy(mdbSourceFilePath, mdbTargetFilePath);
                            MessageBox.Show(GlobalMsg.backMsg, GlobalMsg.titleMsg);

                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, GlobalMsg.titleMsg);
                    }
                }
                fillgrid();
            }       
             catch (Exception er)
            {
                MessageBox.Show(er.Message, GlobalMsg.titleMsg);
            }
         
        }
    
        private void fillgrid()
        {
            //string fullDirectory = Path.Combine(comboDrive.Text, "PtrBack");
            //if (radioCD != null)
            //{ 
            var currentDirInfo = new DirectoryInfo(this.comboDrive.Text + "\\PtrBack");
            var files = currentDirInfo.GetFiles("*", SearchOption.AllDirectories);
            grdBackup.DataSource = files;
            
            grdBackup.Columns[0].Visible = true;
            grdBackup.Columns[0].HeaderText = "Name";
            grdBackup.Columns[0].Width = 200;

            grdBackup.Columns[1].Visible = false;
            grdBackup.Columns[2].Visible = false;
            grdBackup.Columns[3].Visible = false;
            grdBackup.Columns[4].Visible = false;
            grdBackup.Columns[5].Visible = false;
            grdBackup.Columns[6].Visible = false;
            grdBackup.Columns[7].Visible = false;
            grdBackup.Columns[8].Visible = false;
            grdBackup.Columns[9].Visible = false;
            grdBackup.Columns[10].Visible = false;
            grdBackup.Columns[11].Visible = false;
            grdBackup.Columns[12].Visible = false;
            grdBackup.Columns[13].Visible = false;
            grdBackup.Columns[14].Visible = false;
            //}
        }
       
        private void radioHD_CheckedChanged(object sender, EventArgs e)
        {
            comboDrive.Items.Remove(comboDrive.Text);
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
                fillgrid();
            }
            //fillgrid();
        }


        private void radioCD_CheckedChanged(object sender, EventArgs e)
        {
            comboDrive.Items.Remove(comboDrive.Text);
            comboDrive.Items.Clear();
            
            if (radioCD.Checked == true)
            {
                foreach (var drive in DriveInfo.GetDrives())
                {
                    if (drive.DriveType == DriveType.Removable)
                    {
                        comboDrive.Items.Add(drive.Name);
                    }
                    else
                    {
                       
                    }
                    if (drive.DriveType == DriveType.CDRom)
                    {
                        comboDrive.Items.Add(drive.Name);
                    }
                    else
                    {

                    }

                }
                
            }
           //fillgrid();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            
            //comboDrive.Items.Clear();
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                comboDrive.Items.Remove(comboDrive.Text);
                //comboDrive.DataSource = null;
                //comboDrive.ResetText();
                NotifyMainFormToCloseChildFormBackup();
                this.Hide();
            }
            grdBackup.DataSource = null;
            grdBackup.Rows.Clear();
            grdBackup.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(GlobalMsg.exitMsgDialog, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
            if (dialogResult == DialogResult.Yes)
            {
                comboDrive.Items.Remove(comboDrive.Text);
                NotifyMainFormToCloseChildFormBackup();
                this.Hide();
                
            }
            grdBackup.DataSource = null;
            grdBackup.Rows.Clear();
            grdBackup.Refresh();
        }

        private void comboDrive_Click(object sender, EventArgs e)
        {
            if (radioCD.Checked == true)
            {
                comboDrive.Items.Clear();
                foreach (var drive in DriveInfo.GetDrives())
                {
                    
                        //if (drive.IsReady != true
                    if (drive.DriveType == DriveType.Removable)
                    {
                        comboDrive.Items.Add(drive.Name);

                    }
                    else
                    {

                    }
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
                        fillgrid();
                    }
                    else
                    {

                    }
                }
               // 

            }
        }

     
    }
}
