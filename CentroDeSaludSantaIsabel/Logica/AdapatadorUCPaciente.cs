using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class AdapatadorUCPaciente
	{
        public CentroSaludSantaIsabel.UCPaciente PatToUCPat(Paciente p)
		{
            CentroSaludSantaIsabel.UCPaciente ucp = new CentroSaludSantaIsabel.UCPaciente();
            ucp.labelApellidos.Text = p.Apellidos;
            ucp.labelNombres.Text = p.Nombres;
            ucp.labelGrupoSanguineo.Text = p.GrupoSanguineo + " " + p.FactorRH;
            ucp.labelSexo.Text = p.Sexo.ToString();
            return ucp;
		}

        public Paciente UCPatToPat(CentroSaludSantaIsabel.UCPaciente ucp)
		{
            Paciente p = new Paciente();
            p.Apellidos = ucp.labelApellidos.Text.ToString();
            p.Nombres = ucp.labelNombres.Text.ToString();
            p.GrupoSanguineo = ucp.labelGrupoSanguineo.Text.ToString();
            //NO SE NECESITA CONVERTIR UN UCP A UN PACIENTE. METODO DEPRECATED.


            return p;

		}
	}
}
