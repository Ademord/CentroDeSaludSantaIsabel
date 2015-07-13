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
            buttonPacientes.FlatAppearance.BorderSize = 0;
            buttonSalud.FlatAppearance.BorderSize = 0;
            buttonPersonal.FlatAppearance.BorderSize = 0;
            buttonReportes.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatAppearance.BorderSize = 0;
        }

        private void button_medicamento_Click(object sender, EventArgs e)
        {
            Salud.FormMedicamento formMed = new Salud.FormMedicamento();
            formMed.Show();
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
        private void buttonPacientes_Click(object sender, EventArgs e)
        {
            this.buttonSalud.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPersonal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReportes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPacientes.BackColor = System.Drawing.SystemColors.Highlight;
            CentroSalud.Pacientes(panelDesk);
        }

        private void buttonSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalud_Click_1(object sender, EventArgs e)
        {
            this.buttonSalud.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPersonal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReportes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPacientes.BackColor = System.Drawing.SystemColors.HotTrack;
        }
 

    }
}
