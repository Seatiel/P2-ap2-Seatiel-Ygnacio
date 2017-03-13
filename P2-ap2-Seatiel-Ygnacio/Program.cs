using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace P2_ap2_Seatiel_Ygnacio
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
            Application.Run(new FormularioPrincipal());
        }
    }
}
