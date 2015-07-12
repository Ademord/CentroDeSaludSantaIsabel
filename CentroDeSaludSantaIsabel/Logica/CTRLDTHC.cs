using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public static class CTRLDTHC
	{
		public static void leerBD()
		{
			
		}
        public static void SaveBufferToBD(){
            BD.Instance.open();
            foreach (DTHC reg in BufferPaciente.Instance.buffer)
            {
                if (reg.tipoRegistro != TipoRegistroDT.CLEAN_REG)
                {
                    CTRLDTPaciente.Guardar(reg.paciente);
                }
            }
            BD.Instance.close();
        }
        public static void SetDeletes(int reg_index)
        {
            BufferPaciente.Instance.buffer[reg_index].paciente.instruccion = Instruccion.INSTRUCTION_DELETE;
            //update instructions for all members of this register.
            //cannot put INSTRUCTION DELETE ON INSTRUCTIONS INSERT, ONLY ON UPDATES.
        }
	}
}
