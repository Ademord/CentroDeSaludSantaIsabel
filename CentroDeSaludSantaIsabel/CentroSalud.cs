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
    public partial class CentroSalud : Form
    {
        public CentroSalud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_medicamento_Click(object sender, EventArgs e)
        {
            Medicamento formMed = new Medicamento();
            formMed.Show();
        }

        private void label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonNuevaHC_Click(object sender, EventArgs e)
        {
            HistoriaClinica formHC = new HistoriaClinica();
            formHC.Show();
        }
    }
}
