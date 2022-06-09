using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin formLog = new FormLogin();
            FormMenu formMenu = new FormMenu();

            Application.Run(formLog);
            
            if (formLog.SuperAdmin)
            {
                Application.Run(formMenu);                
            }
        }
    }
}
