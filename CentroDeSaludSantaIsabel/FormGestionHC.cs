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
        }

        protected virtual void buttonNuevo_Click(object sender, EventArgs e)
        {
            CentroSalud.ctrlHC.Nuevo();
        }
    }
}
