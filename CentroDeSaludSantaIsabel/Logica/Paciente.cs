using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class Paciente : Persona
	{
		String Nacionalidad { get; set; }
        String IdiomaHablado { get; set; }
        String IdiomaMaterno { get; set; }
        string GrupoSanguineo { get; set; }
        bool FactorRH { get; set; }
	}
}
