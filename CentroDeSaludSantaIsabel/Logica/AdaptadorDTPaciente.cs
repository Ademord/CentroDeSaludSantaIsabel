using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class AdaptadorDTPaciente
	{
        public Paciente Traducir(DTPaciente p)
		{
            return p.paciente;
		}

        //reg con index, instruction type
        public DTPaciente Traducir(Paciente p, int id)
		{
            if (id == CONFIG.NEW_REG) id = 0;
            return new DTPaciente(p, id);
  		}
        //reg sin index
        public DTPaciente Traducir(Paciente p)
        {
            return new DTPaciente(p, 0);
        }
	}
}
