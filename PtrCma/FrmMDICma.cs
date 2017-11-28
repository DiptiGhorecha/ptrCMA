using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PtrCma
{
    public partial class FrmMDICma : Form
    {

        public FrmMDICma()
        {
            InitializeComponent();
            
        }

        private void FrmMDICma_Load(object sender, EventArgs e)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string[] names = myAssembly.GetManifestResourceNames();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Bitmap bmp = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("PtrCma.Resources.bg.png"));
            this.Text = Global.companyName;
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Global.appBackColr;
                    // 4#
                    break;
                }

            }
            this.BackColor = Global.appBackColr;
            //this.BackgroundImage = Global.startFrmBackImg;
            FrmCMAParty p = new FrmCMAParty();
            p.MdiParent = this;
            FrmMainCma f = new FrmMainCma();
            f.MdiParent = this;
           // f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            
           // f.Refresh();
            
        }

    }
}
