using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class AdapatadorUCPaciente
	{
        public CentroDeSaludSantaIsabel.UCPaciente PatToUCPat(Paciente p)
		{
            CentroDeSaludSantaIsabel.UCPaciente ucp = new CentroDeSaludSantaIsabel.UCPaciente();
            ucp.labelApellido.Text = p.Apellidos;
            ucp.labelNombre.Text = p.Nombres;
            ucp.labelGrupoSanguineo.Text = p.GrupoSanguineo + " " + p.FactorRH;
            ucp.labelSexo.Text = p.Sexo.ToString;
            ucp.labelTelefono.Text = p.Telefono.ToString;
		}

        public Paciente UCPatToPat(CentroDeSaludSantaIsabel.UCPaciente p)
		{

		}
	}
}
