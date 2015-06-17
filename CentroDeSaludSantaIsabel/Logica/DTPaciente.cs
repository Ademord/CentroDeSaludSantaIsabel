using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class DTPaciente
	{
        public int id { get; set; }
        public Paciente paciente { get; set; }

        public DTPaciente() { }
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
