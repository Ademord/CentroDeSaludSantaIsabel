using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class BufferPaciente
	{
		private static BufferPaciente instance;
        public List<Paciente> buffer { get; set; }
        private BufferPaciente() {}

        public void addPaciente(Paciente p)
        {
            buffer.Add(p);
        }
        public void removePaciente(Paciente p)
        {
            buffer.Remove(p);
        }

        public static BufferPaciente Instance
        {
            get 
            {
                if (instance == null)
                {
                instance = new BufferPaciente();
                }
                return instance;
            }
        }
	}
}
