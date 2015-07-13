using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class DTPaciente: DTRegistroGeneral
	{
        public Instruccion instruccion { get; set; }

        public Paciente paciente { get; set; }

        public DTPaciente() {
            paciente = new Paciente();
        }
		public DTPaciente(Paciente _p, int _id)
		{
            paciente = _p;
            id = _id;
		}
        public DTPaciente(Paciente _p)
        {
            paciente = _p;
        }
	}
}
