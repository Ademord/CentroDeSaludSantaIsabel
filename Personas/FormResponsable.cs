using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Personas
{
    public partial class FormResponsable : Form
    {
        public FormResponsable()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
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

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
