﻿using MessageBoxExample;
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
        public Action NotifyMainFormToCloseChildFormParty;          // Party Form
        private FrmCMAParty frmParty;
        public Action NotifyMainFormToCloseChildFormBackup;          // Backup Form
        private FrmPtrBack frmBackup;
        public Action NotifyMainFormToCloseChildFormRestore;          // Restore Form
        private FrmPtrRestore frmRestore;
        public Action NotifyMainFormToCloseChildFormDirector;       // Detail of Director Form
        private FrmDetailDirector frmDirector;
        public Action NotifyMainFormToCloseChildFormBanking;        // Banking Arrangements Form
        private FrmBankingArrangements frmBanking;
        public Action NotifyMainFormToCloseChildFormCredit;         // Credit Form
        public FrmCredit frmCredit;
        public Action NotifyMainFormToCloseChildFormAssociate;      // Detail of Associate Form
        public FrmDeatilAssociate frmAssociate;
        public Action NotifyMainFormToCloseChildFormRegistration;   // Registration Form
        public FrmRegistration frmRegistration;
        public Action NotifyMainFormToCloseChildFormPosition;       // Position Income Tax Form
        public FrmPositionIncomeTax frmPosition;
        public Action NotifyMainFormToCloseChildFormPurchase;       // Terms of Purchase Form
        public FrmTermsPurchase frmPurchase;
        public Action NotifyMainFormToCloseChildFormSales;          // Terms of Sales Form
        public FrmTermsSales frmSales;
        public Action NotifyMainFormToCloseChildFormBuyer;          // Major Buyer Form
        public FrmMajorBuyer frmBuyer;
        public Action NotifyMainFormToCloseChildFormParameter;          // Parameter Past Form
        public FrmParameterPast frmParameter;
        public Action NotifyMainFormToCloseChildFormAssets;          // Assets Form
        public FrmDeatilAssets frmAssets;
        public Action NotifyMainFormToCloseChildFormProposed;          // Proposed Form
        public FrmProposedExpenditure frmProposed;
        public Action NotifyMainFormToCloseChildFormImmovable;          // Immovable property
        public FrmImmovableSecurities frmImmovable;
        public Action NotifyMainFormToCloseChildFormMovable;          // Movable property
        public FrmMovable frmMovable;
        public Action NotifyMainFormToCloseChildFormGuarantor;          // Guarantor
        public FrmGuarantor frmGuarantor;
        public Action NotifyMainFormToCloseChildFormDeclaration;          // Declaration
        public FrmDeclaration frmDeclaration;
        public Action NotifyMainFormToCloseChildFormDocuments;          // Documents
        public FrmDocuments frmDocuments;
        public Action NotifyMainFormToCloseChildFormYear;          // current year
        public FrmYears frmYear;
        private FrmMainCma frmMain;
        private FrmCMA frmCmaa;
        
        public FrmMDICma()
        {
            InitializeComponent();
        }
        // static public DialogResult ShowDialog(string title, string largeHeading, string smallExplanation, string leftButton, string rightButton);

 

        private void FrmMDICma_Load(object sender, EventArgs e)
        {
            
            Double ScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            Double ScreenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            if (ScreenWidth < 1280 || ScreenHeight < 768)
            {
                DialogResult dialogResult1 = MessageBox.Show(GlobalMsg.resolutionMsg, "Perfect Tax Reporter - CMA 1.0", MessageBoxButtons.YesNo);       //Cancel Button
                if (dialogResult1 == DialogResult.Yes)
                {
                }else
                {
                    this.Close();
                }

                }

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

            //Form Party
            frmParty = new FrmCMAParty();
            IntPtr dummy = frmParty.Handle;
            frmParty.MdiParent = this;
            frmParty.Location = new Point(this.Location.X + (this.Width - frmParty.Width) / 2, (frmParty.Location.Y + (this.Height - frmParty.Height) / 2) + 20);
            frmParty.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmParty.NotifyMainFormToOpenChildFormCma += NotifyMainFormToOpenFormCma;
           
            //Form Backup
            frmBackup = new FrmPtrBack();
            frmBackup.MdiParent = this;
            frmBackup.Location = new Point(this.Location.X + (this.Width - frmBackup.Width) / 2, (frmBackup.Location.Y + (this.Height - frmBackup.Height) / 2) + 20);
            frmBackup.NotifyMainFormToCloseChildFormBackup += NotifyMainFormToCloseFormBackup;

            //Form Restore
            frmRestore = new FrmPtrRestore();
            frmRestore.MdiParent = this;
            frmRestore.Location = new Point(this.Location.X + (this.Width - frmRestore.Width) / 2, (frmRestore.Location.Y + (this.Height - frmRestore.Height) / 2) + 20);
            frmRestore.NotifyMainFormToCloseChildFormRestore += NotifyMainFormToCloseFormRestore;

            frmCmaa = new FrmCMA();
            IntPtr dummy1 = frmCmaa.Handle;
            frmCmaa.MdiParent = this;
            frmCmaa.Location = new Point(0, 70);
            frmCmaa.NotifyMainFormToCloseChildFormCma += NotifyMainFormToCloseFormCma;
            frmCmaa.NotifyMainFormToOpenChildFormDirector += NotifyMainFormToOpenFormDirector;  //Use to open Detail of Director Form
            frmCmaa.NotifyMainFormToOpenChildFormBanking += NotifyMainFormToOpenFormBanking;    //Use to open Banking Arrangements Form    
            frmCmaa.NotifyMainFormToOpenChildFormCredit += NotifyMainFormToOpenFormCredit;      //Use to open Credit Form
            frmCmaa.NotifyMainFormToOpenChildFormAssociate += NotifyMainFormToOpenFormAssociate;   //Use to open Detail of Associate Form
            frmCmaa.NotifyMainFormToOpenChildFormRegistration += NotifyMainFormToOpenFormRegistration;   //Use to open Registration Form
            frmCmaa.NotifyMainFormToOpenChildFormPosition += NotifyMainFormToOpenFormPosition;   //Use to open Position Income Tax Form
            frmCmaa.NotifyMainFormToOpenChildFormPurchase += NotifyMainFormToOpenFormPurchase;   //Use to open Terms Purchase Form
            frmCmaa.NotifyMainFormToOpenChildFormSales += NotifyMainFormToOpenFormSales;   //Use to open Terms Sales Form
            frmCmaa.NotifyMainFormToOpenChildFormBuyer += NotifyMainFormToOpenFormBuyer;   //Use to open Major Buyer Form
            frmCmaa.NotifyMainFormToOpenChildFormParameter += NotifyMainFormToOpenFormParameter;   //Use to open Parameter Past Form
            frmCmaa.NotifyMainFormToOpenChildFormAssets += NotifyMainFormToOpenFormAssets;   //Use to open Detail Assets Form
            frmCmaa.NotifyMainFormToOpenChildFormProposed += NotifyMainFormToOpenFormProposed;   //Use to open Proposed Expenditure Form
            frmCmaa.NotifyMainFormToOpenChildFormImmovable += NotifyMainFormToOpenFormImmovable;   //Use to open Immovable Securities
            frmCmaa.NotifyMainFormToOpenChildFormMovable += NotifyMainFormToOpenFormMovable;   //Use to open Movable Securities
            frmCmaa.NotifyMainFormToOpenChildFormGuarantor += NotifyMainFormToOpenFormGuarantor;   //Use to open Movable Securities
            frmCmaa.NotifyMainFormToOpenChildFormDeclaration += NotifyMainFormToOpenFormDeclaration;   //Use to open Movable Securities
            frmCmaa.NotifyMainFormToOpenChildFormDocuments += NotifyMainFormToOpenFormDocuments;   //Use to open Movable Securities
            frmCmaa.NotifyMainFormToOpenChildFormYear += NotifyMainFormToOpenFormYear;   //Use to open current year
           //IntPtr dummy = frmCmaa.Handle;
            frmMain = new FrmMainCma();
            frmMain.MdiParent = this;
            frmMain.NotifyMainFormToOpenChildFormParty += NotifyMainFormToOpenFormParty;
            frmMain.NotifyMainFormToOpenChildFormBackup += NotifyMainFormToOpenFormBackup;
            frmMain.NotifyMainFormToOpenChildFormRestore += NotifyMainFormToOpenFormRestore;
            frmMain.Show();

            frmDirector = new FrmDetailDirector();
            frmDirector.MdiParent = this;
            frmDirector.Location = new Point(this.Location.X + (this.Width - frmDirector.Width) / 2, (frmDirector.Location.Y + (this.Height - frmDirector.Height) / 2) + 20);
            //frmDirector.Location = new Point(0, 70);
            frmDirector.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmDirector.NotifyMainFormToCloseChildFormDirector += NotifyMainFormToCloseFormDirector;

            frmBanking = new FrmBankingArrangements();
            frmBanking.MdiParent = this;
            frmBanking.Location = new Point(this.Location.X + (this.Width - frmBanking.Width) / 2, (frmBanking.Location.Y + (this.Height - frmBanking.Height) / 2) + 20);
            frmBanking.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmBanking.NotifyMainFormToCloseChildFormBanking += NotifyMainFormToCloseFormBanking;

            frmCredit = new FrmCredit();
            frmCredit.MdiParent = this;
            frmCredit.Location = new Point(this.Location.X + (this.Width - frmCredit.Width) / 2, (frmCredit.Location.Y + (this.Height - frmCredit.Height) / 2) + 20);
            frmCredit.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmCredit.NotifyMainFormToCloseChildFormCredit += NotifyMainFormToCloseFormCredit;

            frmAssociate = new FrmDeatilAssociate();
            frmAssociate.MdiParent = this;
            frmAssociate.Location = new Point(this.Location.X + (this.Width - frmAssociate.Width) / 2, (frmAssociate.Location.Y + (this.Height - frmAssociate.Height) / 2) + 20);
            frmAssociate.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmAssociate.NotifyMainFormToCloseChildFormAssociate += NotifyMainFormToCloseFormAssociate;

            frmRegistration = new FrmRegistration();
            frmRegistration.MdiParent = this;
            frmRegistration.Location = new Point(this.Location.X + (this.Width - frmRegistration.Width) / 2, (frmRegistration.Location.Y + (this.Height - frmRegistration.Height) / 2) + 20);
            frmRegistration.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmRegistration.NotifyMainFormToCloseChildFormRegistration += NotifyMainFormToCloseFormRegistration;

            frmPosition = new FrmPositionIncomeTax();
            frmPosition.MdiParent = this;
            frmPosition.Location = new Point(this.Location.X + (this.Width - frmPosition.Width) / 2, (frmPosition.Location.Y + (this.Height - frmPosition.Height) / 2) + 20);
            frmPosition.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmPosition.NotifyMainFormToCloseChildFormPosition += NotifyMainFormToCloseFormPosition;

            frmPurchase = new FrmTermsPurchase();
            frmPurchase.MdiParent = this;
            frmPurchase.Location = new Point(this.Location.X + (this.Width - frmPurchase.Width) / 2, (frmPurchase.Location.Y + (this.Height - frmPurchase.Height) / 2) + 20);
            frmPurchase.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmPurchase.NotifyMainFormToCloseChildFormPurchase += NotifyMainFormToCloseFormPurchase;

            frmSales = new FrmTermsSales();
            frmSales.MdiParent = this;
            frmSales.Location = new Point(this.Location.X + (this.Width - frmSales.Width) / 2, (frmSales.Location.Y + (this.Height - frmSales.Height) / 2) + 20);
            frmSales.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmSales.NotifyMainFormToCloseChildFormSales += NotifyMainFormToCloseFormSales;

            frmBuyer = new FrmMajorBuyer();
            frmBuyer.MdiParent = this;
            frmBuyer.Location = new Point(this.Location.X + (this.Width - frmBuyer.Width) / 2, (frmBuyer.Location.Y + (this.Height - frmBuyer.Height) / 2) + 20);
            frmBuyer.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmBuyer.NotifyMainFormToCloseChildFormBuyer += NotifyMainFormToCloseFormBuyer;

            frmParameter = new FrmParameterPast();
            frmParameter.MdiParent = this;
            frmParameter.Location = new Point(this.Location.X + (this.Width - frmParameter.Width) / 2, (frmParameter.Location.Y + (this.Height - frmParameter.Height) / 2) + 20);
            frmParameter.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmParameter.NotifyMainFormToCloseChildFormParameter += NotifyMainFormToCloseFormParameter;

            frmAssets = new FrmDeatilAssets();
            frmAssets.MdiParent = this;
            frmAssets.Location = new Point(this.Location.X + (this.Width - frmAssets.Width) / 2, (frmAssets.Location.Y + (this.Height - frmAssets.Height) / 2) + 20);
            frmAssets.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmAssets.NotifyMainFormToCloseChildFormAssets += NotifyMainFormToCloseFormAssets;

            frmProposed = new FrmProposedExpenditure();
            frmProposed.MdiParent = this;
            frmProposed.Location = new Point(this.Location.X + (this.Width - frmProposed.Width) / 2, (frmProposed.Location.Y + (this.Height - frmProposed.Height) / 2) + 20);
            frmProposed.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmProposed.NotifyMainFormToCloseChildFormProposed += NotifyMainFormToCloseFormProposed;

            frmImmovable = new FrmImmovableSecurities();
            frmImmovable.MdiParent = this;
            frmImmovable.Location = new Point(this.Location.X + (this.Width - frmImmovable.Width) / 2, (frmImmovable.Location.Y + (this.Height - frmProposed.Height) / 2) + 20);
            frmImmovable.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmImmovable.NotifyMainFormToCloseChildFormImmovable += NotifyMainFormToCloseFormImmovable;

            frmMovable = new FrmMovable();
            frmMovable.MdiParent = this;
            frmMovable.Location = new Point(this.Location.X + (this.Width - frmMovable.Width) / 2, (frmMovable.Location.Y + (this.Height - frmMovable.Height) / 2) + 20);
            frmMovable.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmMovable.NotifyMainFormToCloseChildFormMovable += NotifyMainFormToCloseFormMovable;

            frmGuarantor = new FrmGuarantor();
            frmGuarantor.MdiParent = this;
            frmGuarantor.Location = new Point(this.Location.X + (this.Width - frmGuarantor.Width) / 2, (frmGuarantor.Location.Y + (this.Height - frmGuarantor.Height) / 2) + 20);
            frmGuarantor.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmGuarantor.NotifyMainFormToCloseChildFormGuarantor += NotifyMainFormToCloseFormGuarantor;

            frmDeclaration = new FrmDeclaration();
            frmDeclaration.MdiParent = this;
            frmDeclaration.Location = new Point(this.Location.X + (this.Width - frmDeclaration.Width) / 2, (frmDeclaration.Location.Y + (this.Height - frmDeclaration.Height) / 2) + 20);
            frmDeclaration.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmDeclaration.NotifyMainFormToCloseChildFormDeclaration += NotifyMainFormToCloseFormDeclaration;

            frmDocuments = new FrmDocuments();
            frmDocuments.MdiParent = this;
            frmDocuments.Location = new Point(this.Location.X + (this.Width - frmDocuments.Width) / 2, (frmDocuments.Location.Y + (this.Height - frmDocuments.Height) / 2) + 20);
            frmDocuments.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmDocuments.NotifyMainFormToCloseChildFormDocuments += NotifyMainFormToCloseFormDocuments;

            frmYear = new FrmYears();
            frmYear.MdiParent = this;
            frmYear.Location = new Point(this.Location.X + (this.Width - frmYear.Width) / 2, (frmYear.Location.Y + (this.Height - frmYear.Height) / 2) + 20);
            frmYear.NotifyMainFormToCloseChildFormParty += NotifyMainFormToCloseFormParty;
            frmYear.NotifyMainFormToCloseChildFormYear += NotifyMainFormToCloseFormYear;

        }

        // Form Current Year
        private void NotifyMainFormToOpenFormYear()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmYear.Show();
        }
        private void NotifyMainFormToCloseFormYear()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }
        // Form Declaration
        private void NotifyMainFormToOpenFormDeclaration()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmDeclaration.Show();
        }
        private void NotifyMainFormToCloseFormDeclaration()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Documents
        private void NotifyMainFormToOpenFormDocuments()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmDocuments.Show();
        }
        private void NotifyMainFormToCloseFormDocuments()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }


        // Form Guarantor
        private void NotifyMainFormToOpenFormGuarantor()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmGuarantor.Show();
        }
        private void NotifyMainFormToCloseFormGuarantor()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Movable Property
        private void NotifyMainFormToOpenFormMovable()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmMovable.Show();
        }
        private void NotifyMainFormToCloseFormMovable()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Immovable Property
        private void NotifyMainFormToOpenFormImmovable()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmImmovable.Show();
        }
        private void NotifyMainFormToCloseFormImmovable()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Proposed Expenditure
        private void NotifyMainFormToOpenFormProposed()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmProposed.Show();
        }
        private void NotifyMainFormToCloseFormProposed()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Detail Assets
        private void NotifyMainFormToOpenFormAssets()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmAssets.Show();
        }
        private void NotifyMainFormToCloseFormAssets()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Parameter
        private void NotifyMainFormToOpenFormParameter()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmParameter.Show();
        }
        private void NotifyMainFormToCloseFormParameter()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Buyer
        private void NotifyMainFormToOpenFormBuyer()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmBuyer.Show();
        }
        private void NotifyMainFormToCloseFormBuyer()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Sales
        private void NotifyMainFormToOpenFormSales()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmSales.Show();
        }
        private void NotifyMainFormToCloseFormSales()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Purchase
        private void NotifyMainFormToOpenFormPurchase()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmPurchase.Show();
        }
        private void NotifyMainFormToCloseFormPurchase()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Registration
        private void NotifyMainFormToOpenFormPosition()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmPosition.Show();
        }
        private void NotifyMainFormToCloseFormPosition()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Registration
        private void NotifyMainFormToOpenFormRegistration()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmRegistration.Show();
        }
        private void NotifyMainFormToCloseFormRegistration()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Associate
        private void NotifyMainFormToOpenFormAssociate()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmAssociate.Show();
        }
        private void NotifyMainFormToCloseFormAssociate()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Credit
        private void NotifyMainFormToOpenFormCredit()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            frmCredit.Show();
        }
        private void NotifyMainFormToCloseFormCredit()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;
        }

        // Form Banking
        private void NotifyMainFormToOpenFormBanking()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;

            frmBanking.Show();
        }
        private void NotifyMainFormToCloseFormBanking()
        {
            frmMain.Enabled = true;
            frmCmaa.Enabled = true;

            //frmBanking.Show();
        }

        // Form Director
        private void NotifyMainFormToOpenFormDirector()
        {
            frmMain.Enabled = false;
            frmCmaa.Enabled = false;
            
            frmDirector.Show();
            
        }
        private void NotifyMainFormToCloseFormDirector()
        {
            frmCmaa.Enabled = true;
        }


        private void NotifyMainFormToCloseFormCma()
        {
            // frmCmaa.Enabled = true;
            frmCmaa.Hide();
            frmMain.Enabled = true;
        }

        //Form CMA
        private void NotifyMainFormToOpenFormCma()
        {

            //frmParty.Location = new Point(this.Location.X + (this.Width - frmParty.Width) / 2, (frmParty.Location.Y + (this.Height - frmParty.Height) / 2)+35);

            frmCmaa.Show();
            frmMain.Enabled = false;
        }

        // Form Party
        private void NotifyMainFormToOpenFormParty()
        {
           frmParty.Show();
           frmMain.Enabled = false;
        }
        private void NotifyMainFormToCloseFormParty()
        {
            frmMain.Enabled = true;
        }

        // Form Backup
        private void NotifyMainFormToOpenFormRestore()
        {
            frmRestore.Show();
            frmMain.Enabled = false;
        }
        private void NotifyMainFormToCloseFormRestore()
        {
            frmMain.Enabled = true;
        }

        // Form Backup
        private void NotifyMainFormToOpenFormBackup()
        {
            frmBackup.Show();
            frmMain.Enabled = false;
        }
        private void NotifyMainFormToCloseFormBackup()
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
