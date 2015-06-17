using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroSaludSantaIsabel
{
    static class CentroSalud
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCentroSalud());
            CentroSaludSantaIsabel.BufferPaciente bufferpaciente = CentroSaludSantaIsabel.BufferPaciente.Instance;
        }
    }
}
