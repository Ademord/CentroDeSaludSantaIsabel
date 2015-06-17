using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Text.RegularExpressions;

namespace Personas
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxNombre.Text, @"[a-zA-Z]"))
            {
                System.Windows.Forms.MessageBox.Show("Only use alphabates");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }



        
    }
}
