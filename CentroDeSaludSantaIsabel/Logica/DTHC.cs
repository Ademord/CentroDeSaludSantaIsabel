using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class DTHC
    {
        public TipoRegistroDT tipoRegistro { get; set; }
        public DTPaciente paciente { get; set; }
        // List<DTResponsables> responsables { get; set; }
        public void AddPaciente(DTPaciente p)
        {
            paciente = p;
            //instrucciones.Add(new KeyValuePair<int, int>(buffer.Count, BD.INSTRUCTION_INSERT));
        }
        public void RemovePaciente(DTPaciente p)
        {
            paciente = null;
        }
 
	}
}
