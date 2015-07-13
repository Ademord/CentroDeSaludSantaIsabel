using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class BufferPaciente
	{
		private static BufferPaciente instance;
        public DTHC temp = new DTHC();
        public List<DTHC> buffer = new List<DTHC>();

        private BufferPaciente() {}

        public void AddTemp()
        {
            if (Instance.temp.paciente != null)
            {
                Instance.temp.paciente.id = Instance.buffer.Count;
                Instance.buffer.Add(Instance.temp);
            } 
        }
        public void DropTemp()
        {
            Instance.temp = new DTHC();
        }
        public void DropBuffer()
        {
            instance = new BufferPaciente();
        }
        public DTHC Find(int index)
        {
            return buffer[index];
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
