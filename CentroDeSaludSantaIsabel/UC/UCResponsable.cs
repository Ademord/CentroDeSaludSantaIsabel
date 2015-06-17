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
    public partial class UCResponsable : UserControl
    {
        public UCResponsable()
        {
            InitializeComponent();
        }

        private void buttonResponsable_Click(object sender, EventArgs e)
        {
            Personas.FormResponsable form = new Personas.FormResponsable();
            form.Show();
        }
    }
}
