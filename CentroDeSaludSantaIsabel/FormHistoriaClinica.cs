﻿using System;
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
    public partial class FormHistoriaClinica : Form
    {
        public FormHistoriaClinica()
        {
            InitializeComponent();
        }


        private void buttonPaciente_Click(object sender, EventArgs e)
        {
            FormPaciente formPaciente = new FormPaciente();
            formPaciente.Show();
        }
    }
}
