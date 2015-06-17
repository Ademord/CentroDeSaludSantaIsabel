using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class Paciente : Persona
	{
        public String IdiomaMaterno { get; set; }
        public String GrupoSanguineo { get; set; }
        public String FactorRH { get; set; }
	}
}
