using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyService.UI
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
            Application.Run(new NewAppointmen(null) /* NewAppointmen(new ES.EntityLayer.Vehicle.Vehicle("Helooo", 2010, "Helooo", "Helooo", 4000))*/);
        }
    }
}
