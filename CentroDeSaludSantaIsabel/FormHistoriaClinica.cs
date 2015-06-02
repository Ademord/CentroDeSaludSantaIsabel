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
            Salud.FormConsultaEnfermeria form = new Salud.FormConsultaEnfermeria();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK) flowLayoutPanelConsulta.Controls.Add(new UCConsultaEnfermeria());

        }

        private void buttonbuttonNuevaConsultaMedica_Click(object sender, EventArgs e)
        {
            Salud.FormConsultaMedica form = new Salud.FormConsultaMedica();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK) flowLayoutPanelConsulta.Controls.Add(new UCConsultaMedica());
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

            //guardar paciente
            CentroSaludSantaIsabel.AdapatadorUCPaciente
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonNuevoResponsable_Click(object sender, EventArgs e)
        {
            Personas.FormResponsable form = new Personas.FormResponsable();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK) flowLayoutPanelResponsable.Controls.Add(new UCResponsable());
        }

    }
}
