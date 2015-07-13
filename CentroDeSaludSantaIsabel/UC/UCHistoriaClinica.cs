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
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonPaciente.FlatAppearance.BorderSize = 0;
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
        private void flowLayoutPanel2_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void pictureBoxFoto_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void pictureBoxFoto_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void labelApellidos_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void labelApellidos_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void labelNombres_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void labelNombres_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void flowLayoutPanel2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;

        }

        private void labelDescripcion_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void labelDescripcion_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void buttonPaciente_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void buttonPaciente_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void buttonEliminar_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void buttonEliminar_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        }
    }
}
