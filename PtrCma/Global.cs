using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PtrCma
{
    public static class Global
    {
        //MDI Form
        public static string companyName = "Perfect Tax Reporter - CMA 1.0";
        public static Color appBackColr = System.Drawing.Color.LightSeaGreen;
        public static Font lblCompNamefont = new System.Drawing.Font("Arial Rounded Mt", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Color lblCompColr = System.Drawing.Color.White;
        //MAIN form
        public static Bitmap startFrmBackImg = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.bg.png"));
        public static int cmdBtnWidthMain = 200;
        public static int cmdBtnHeightMain = 68;
        public static Bitmap cmdBnkStndIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.icon1.png"));    
        public static Bitmap cmdCmsProjIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.icon2.png"));   
        public static Bitmap cmdBackupIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.icon3.png"));      
        public static Bitmap cmdRestoreIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.icon4.png"));   
        public static Bitmap cmdExitIcon = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.icon5.png"));     
        public static Bitmap cmdBtnBack = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.button1.png"));    
        public static Font cmdBtnfont = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Color cmdFontColr = System.Drawing.Color.White;
        public static Font lblCMSfont = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Color lblCMSColr = System.Drawing.Color.White;
        

        //Party Master Form
        public static Bitmap partyFrmBackImg = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.center-bg.png"));
        public static Bitmap partyFrmCloseImg = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.close.png"));
        public static Bitmap cmdImg = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.buton.png"));
        public static Bitmap partyLblBackImg = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.partybg.png"));
        public static Color btnfore = System.Drawing.Color.White;   //Button Fore Color
        public static string PartyMaster = "Party Master"; //Title
        public static Color lblparty = System.Drawing.Color.CadetBlue; //Label BackColor of title
        public static Color lbltitle = System.Drawing.Color.FromArgb(68, 77, 62); //Label Fore Color of title
        public static Font lblPartyTitlefont = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Color backColorPartyMst = System.Drawing.Color.Transparent;   //.FromArgb(153,233,228);  //back ground color of partymaster table
        public static Color lblColorPartyMst = System.Drawing.Color.CadetBlue;   //Label Backcolor
        public static Color lblForeColorPartyMst = System.Drawing.Color.White;   //Label Fore/Text Color
        public static Font  lblPartyfont = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Color txtColorPartyMst = System.Drawing.Color.White;     //Textbox color
        public static Size smallsizelbl = new System.Drawing.Size(40, 16);          //Find Label Size
        public static Size medsizelbl = new System.Drawing.Size(85, 16);            //All Label Size    
        public static Size largesizelbl = new System.Drawing.Size(490, 30);         //Party Label Size
        public static Size txtCommonSize = new System.Drawing.Size(320, 20);
        public static Size txtFindSize = new System.Drawing.Size(195, 20);
        public static Size txtCodenoSize = new System.Drawing.Size(100, 20);
        public static Size txtBranchSize = new System.Drawing.Size(100, 20);
        public static Size txtNotesSize = new System.Drawing.Size(410, 70);
        public static Size grdPartySize = new System.Drawing.Size(301, 415);
        public static Size btnSmallSize = new System.Drawing.Size(50, 35);         // For add edit save exit Button
        public static Size btnmedSize = new System.Drawing.Size(60, 35);            // For Delete Cancel Butoon
        public static Size btnLargeSize = new System.Drawing.Size(170, 35);     // For Select Party Button
        public static Size smallBtn = new System.Drawing.Size(50, 22);          //For Reset Button
        public static Color grdPartyBackColor = System.Drawing.Color.CadetBlue;//FromArgb(31, 109, 96);
        public static Color grdPartyForeColor = System.Drawing.Color.White;
        public static Font txtSize=new System.Drawing.Font("Arial",10F);
        public static Font lblSize = new System.Drawing.Font("Arial", 10F);
        //public static Size lbl = system

        //All Form after click
        //  public static Bitmap partyFrmBackImg = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.center-bg.png"));
        public static Color frmbgcolor = System.Drawing.Color.FromArgb(102, 166, 173);  //back ground color of Detail of Director table
        public static Color lblbacktitle = System.Drawing.Color.FromArgb(122, 204, 203); //Label Back Color of title
        public static Color lblforetitle = System.Drawing.Color.DarkRed; //Label Fore Color of title
        public static Color lblbackdetail = System.Drawing.Color.CadetBlue;  //Label Back Color
        public static Color lblforedetail = System.Drawing.Color.White;  //Label Fore/Text Color

        //CMS form
        public static Color lstBxBackColorCMS = System.Drawing.Color.LightGoldenrodYellow;
        public static Color chartBackColorCMS = System.Drawing.Color.LightGoldenrodYellow;
        public static Color gridBackColorCMS = System.Drawing.Color.LightGray;
        public static Color gridHeaderColorCMS = System.Drawing.Color.Orange;
        public static int chrtLstViewHeight = 150;


    }
}
