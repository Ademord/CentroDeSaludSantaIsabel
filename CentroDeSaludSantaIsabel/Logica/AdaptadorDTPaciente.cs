using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class AdaptadorDTPaciente
	{
		public Paciente DTPatToPat(DTPaciente p)
		{
            return p.paciente;
		}

		public DTPaciente PatToDTPat(Paciente p, int id)
		{
            return new DTPaciente(p, id);
  		}
	}
}
