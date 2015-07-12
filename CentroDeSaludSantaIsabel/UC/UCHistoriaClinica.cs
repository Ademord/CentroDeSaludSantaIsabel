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
    public partial class UCHistoriaClinica : UserControl
    {
        public UCHistoriaClinica()
        {
            InitializeComponent();
        }
        private void buttonPaciente_Click(object sender, EventArgs e)
        {
            CentroSalud.ctrlHC.Gestionar(this, index_paciente);
            //MessageBox.Show(index_paciente.ToString());
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            CentroSalud.ctrlHC.Eliminar(this, index_paciente);
        }
    }
}
