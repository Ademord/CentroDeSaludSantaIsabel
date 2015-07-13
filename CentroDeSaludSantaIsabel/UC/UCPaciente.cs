using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroSaludSantaIsabel
{
    public partial class UCPaciente : UserControl
    {
        public UCPaciente()
        {
            InitializeComponent();
            buttonGestionarPaciente.FlatAppearance.BorderSize = 0;
        }
        public int index_paciente = CONFIG.NEW_REG;
        private void buttonGestionarPaciente_Click(object sender, EventArgs e)
        {
            CTRLPaciente.GestionarPaciente(this);
        }

    }
}
