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
        public static string PartyMaster = "Party Master"; //Title
        public static Color lblparty = System.Drawing.Color.CadetBlue; //Label BackColor of title
        public static Color lbltitle = System.Drawing.Color.White; //Label Fore Color of title
        public static Color backColorPartyMst = System.Drawing.Color.FromArgb(153,233,228);  //back ground color of partymaster table
        public static Color lblColorPartyMst = System.Drawing.Color.CadetBlue;   //Label Backcolor
        public static Color lblForeColorPartyMst = System.Drawing.Color.White;   //Label Fore/Text Color
        public static Color txtColorPartyMst = System.Drawing.Color.White;     //Textbox color
      
        //public static Size lbl = system

        //All Form after click
        public static Color frmbgcolor = System.Drawing.Color.FromArgb(102, 166, 173);  //back ground color of Detail of Director table
        public static Color lblbacktitle = System.Drawing.Color.FromArgb(122, 204, 203); //Label Back Color of title
        public static Color lblforetitle = System.Drawing.Color.DarkRed; //Label Fore Color of title
        public static Color lblbackdetail = System.Drawing.Color.CadetBlue;  //Label Back Color
        public static Color lblforedetail = System.Drawing.Color.White;  //Label Fore/Text Color


    

    }
}
