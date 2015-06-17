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
        }
        public int index_paciente = -1;
        private void buttonGestionarPaciente_Click(object sender, EventArgs e)
        {
            var res = CTRLPaciente.GestionarPaciente(ref index_paciente);
            if (res != null) {
                labelApellidos.Text = res.labelApellidos.Text;
                labelNombres.Text = res.labelNombres.Text;
                labelSexo.Text = res.labelSexo.Text;
                labelGrupoSanguineo.Text = res.labelGrupoSanguineo.Text;
            }
            
        }

    }
}
