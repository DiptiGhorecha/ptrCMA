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
        public static Image startFrmBackImg = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Resources\\bg.png");

    }
}
