using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroDeSaludSantaIsabel
{
    public partial class UCPaciente : UserControl
    {
        public UCPaciente()
        {
            InitializeComponent();
        }

        private void buttonGestionarPaciente_Click(object sender, EventArgs e)
        {
            Personas.FormPaciente f = new Personas.FormPaciente();
            f.Show();
        }
    }
}
