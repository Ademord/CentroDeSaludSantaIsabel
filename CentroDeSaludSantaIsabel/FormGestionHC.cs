using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroSaludSantaIsabel
{
    public partial class FormGestionHC : Form
    {
        public FormGestionHC()
        {
            InitializeComponent();
            buttonNuevo.FlatAppearance.BorderSize = 0;
            buttonCargar.FlatAppearance.BorderSize = 0;
            buttonGuardar.FlatAppearance.BorderSize = 0;
        }

        protected virtual void buttonNuevo_Click(object sender, EventArgs e)
        {
            CentroSalud.ctrlHC.Nuevo();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            CentroSalud.ctrlHC.Save();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            CentroSalud.ctrlHC.Load();
        }
    }
}
