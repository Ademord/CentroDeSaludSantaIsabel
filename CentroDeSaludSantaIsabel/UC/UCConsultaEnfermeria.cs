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
    public partial class UCConsultaEnfermeria : UserControl
    {
        public UCConsultaEnfermeria()
        {
            InitializeComponent();
        }

        private void buttonGestionar_Click(object sender, EventArgs e)
        {
            Salud.FormConsultaEnfermeria form = new Salud.FormConsultaEnfermeria();
            form.Show();
        }
    }
}
