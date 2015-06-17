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
    public partial class UCConsultaMedica : UserControl
    {
        public UCConsultaMedica()
        {
            InitializeComponent();
        }

        private void buttonGestionar_Click(object sender, EventArgs e)
        {
            Salud.FormConsultaMedica form = new Salud.FormConsultaMedica();
            form.Show();
        }
    }
}
