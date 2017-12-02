using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PtrCma
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary
        ///
       private static Mutex mutex = null;
        [STAThread]
        

        static void Main()
        {
            const string appName = "PtrCma";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                //app is already running! Exiting the application  
                return;
            }
            Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMDICma());
                mutex.ReleaseMutex();
     
        }
         
          
          
            
        
    }
}
