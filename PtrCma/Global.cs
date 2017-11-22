using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace PtrCma
{
    public static class Global
    {
        public static string companyName = "Perfect Tax Reporter - CMA 1.0";
        public static Color appBackColr = System.Drawing.Color.LightSeaGreen;
        public static Image startFrmBackImg = Image.FromFile("Resources\\bg.png");
        public static int cmdBtnWidthMain = 200;
        public static int cmdBtnHeightMain = 68;
        public static Image cmdBnkStndIcon = Image.FromFile("Resources\\icon1.png");
        public static Image cmdCmsProjIcon = Image.FromFile("Resources\\icon2.png");
        public static Image cmdBackupIcon = Image.FromFile("Resources\\icon3.png");
        public static Image cmdRestoreIcon = Image.FromFile("Resources\\icon4.png");
        public static Image cmdExitIcon = Image.FromFile("Resources\\icon5.png");
        public static Image cmdBtnBack = Image.FromFile("Resources\\button1.png");
        public static Font cmdBtnfont = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Color cmdFontColr = System.Drawing.Color.White;
        public static Font lblCMSfont = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static Color lblCMSColr = System.Drawing.Color.White;
    }
}
