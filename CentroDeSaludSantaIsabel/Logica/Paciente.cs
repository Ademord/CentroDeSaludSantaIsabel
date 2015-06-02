using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class Paciente : Persona
	{
		public String Nacionalidad { get; set; }
        public String IdiomaHablado { get; set; }
        public String IdiomaMaterno { get; set; }
        public string GrupoSanguineo { get; set; }
        public bool FactorRH { get; set; }
	}
}
