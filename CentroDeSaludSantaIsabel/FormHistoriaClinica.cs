using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentroDeSaludSantaIsabel;
namespace CentroDeSaludSantaIsabel
{
    public partial class FormHistoriaClinica : Form
    {
        public FormHistoriaClinica()
        {
            InitializeComponent();
        }

        private void buttonNuevaConsultaEnfermeria_Click(object sender, EventArgs e)
        {
            Salud.FormConsultaEnfermeria formCE = new Salud.FormConsultaEnfermeria();
            formCE.Show();

        }

        private void buttonbuttonNuevaConsultaMedica_Click(object sender, EventArgs e)
        {
            Salud.FormConsultaMedica form = new Salud.FormConsultaMedica();
            form.Show();
        }

    }
}
