using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class BufferPaciente
	{
		private static BufferPaciente instance;
        public List<Paciente> buffer { get; set; }

        public List<KeyValuePair<int, int>> instrucciones;
        private BufferPaciente() {}
      
        public int add(Paciente p)
        {
            buffer.Add(p);
            instrucciones.Add(new KeyValuePair<int, int>(buffer.Count, BD.INSTRUCTION_INSERT));
            return buffer.Count;


        }
        public void remove(Paciente p)
        {
            buffer.Remove(p);
        }
        public void removePaciente(Paciente p)
        {
            buffer.Remove(p);
        }
        public Paciente find(int index)
        {
            return buffer[index-1];
        }
        public static BufferPaciente Instance
        {
            get 
            {
                if (instance == null)
                {
                    
                    instance = new BufferPaciente();
                    instance.buffer = new List<Paciente>();
                    instance.instrucciones = new List<KeyValuePair<int, int>>();
                }
                return instance;
            }
        }
	}
}
