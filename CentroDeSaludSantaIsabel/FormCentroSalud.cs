using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CentroDeSaludSantaIsabel
{
    public partial class FormCentroSalud : Form
    {
        public FormCentroSalud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_medicamento_Click(object sender, EventArgs e)
        {
            FormMedicamento formMed = new FormMedicamento();
            formMed.Show();
        }

        private void label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonNuevaHC_Click(object sender, EventArgs e)
        {
            FormHistoriaClinica formHC = new FormHistoriaClinica();
            formHC.Show();
        }
    }
}
