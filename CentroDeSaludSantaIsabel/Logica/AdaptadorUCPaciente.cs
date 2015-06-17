using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public static class AdaptadorUCPaciente
	{
        public static CentroSaludSantaIsabel.UCPaciente Traducir(Paciente p)
		{
            CentroSaludSantaIsabel.UCPaciente uchc = new CentroSaludSantaIsabel.UCPaciente();
            uchc.labelNombres.Text = p.Nombres;
            uchc.labelApellidos.Text = p.Apellidos;
            uchc.labelGrupoSanguineo.Text = p.GrupoSanguineo.ToString();
            uchc.labelSexo.Text = p.Sexo.ToString();
            return uchc;
		}
	}
}
