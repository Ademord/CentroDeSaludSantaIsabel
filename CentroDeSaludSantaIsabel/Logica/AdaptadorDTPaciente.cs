using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public static class AdaptadorDTPaciente
	{
        public static Paciente traducir(DTPaciente p)
		{
            return p.paciente;
		}

        public static DTPaciente traducir(Paciente p, int id)
		{
            return new DTPaciente(p, id);
  		}
        public static DTPaciente traducir(Paciente p)
        {
            return new DTPaciente(p);
        }
	}
}
