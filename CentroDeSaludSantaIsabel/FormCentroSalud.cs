using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CentroSaludSantaIsabel
{
    public partial class FormCentroSalud : Form
    {
        public FormCentroSalud()
        {
            InitializeComponent();
        }

        private void button_medicamento_Click(object sender, EventArgs e)
        {
            Salud.FormMedicamento formMed = new Salud.FormMedicamento();
            formMed.Show();
        }

        private void buttonNuevaHC_Click(object sender, EventArgs e)
        {
            FormHistoriaClinica formHC = new FormHistoriaClinica();
            
            DialogResult result = formHC.ShowDialog();
                        
        }

        private void FormCentroSalud_Load(object sender, EventArgs e)
        {
            
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormCentroSalud_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            CTRLHistoriaClinica.
        }

 

    }
}
