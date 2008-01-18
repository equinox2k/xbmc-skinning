using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XBMCSkinEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //XBMCSkinEditor.Dialogs.Splash splash = new XBMCSkinEditor.Dialogs.Splash();
            //splash.ShowDialog();

            Application.Run(new MainWin());
        }
    }
}
