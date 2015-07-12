using System;
using System.Collections.Generic;
using System.Text;


namespace CentroSaludSantaIsabel
{
	public static class CTRLPaciente
	{
        public static AdaptadorDTPaciente adaptadorDT = new AdaptadorDTPaciente();
        public static AdaptadorUCPaciente adaptadorUC = new AdaptadorUCPaciente();
        public static AdaptadorUIPaciente adaptadorUI = new AdaptadorUIPaciente();
        public static void GestionarPaciente(UCPaciente ucp)
        {
            DTPaciente p = new DTPaciente();
            Personas.FormPaciente form = new Personas.FormPaciente();
            
            if (ucp.index_paciente != CONFIG.NEW_REG)
            {
                form = CTRLPaciente.adaptadorUI.Traducir(CTRLPaciente.adaptadorDT.
                    Traducir(BufferPaciente.Instance.buffer[ucp.index_paciente].paciente));
            }
            else if (BufferPaciente.Instance.temp.paciente != null 
                && BufferPaciente.Instance.temp.paciente.id == 0)
            {
                form = CTRLPaciente.adaptadorUI.Traducir(CTRLPaciente.adaptadorDT.Traducir(BufferPaciente.Instance.temp.paciente));
            }
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                p = CTRLPaciente.adaptadorDT.Traducir(CTRLPaciente.adaptadorUI.Traducir(form));
                BufferPaciente.Instance.temp.paciente = p;
                if (ucp.index_paciente != CONFIG.NEW_REG) //not loaded from GestionarHC
                    BufferPaciente.Instance.temp.paciente.instruccion = Instruccion.INSTRUCTION_INSERT;
                else
                    BufferPaciente.Instance.temp.paciente.instruccion = Instruccion.INSTRUCTION_UPDATE;
                CTRLPaciente.adaptadorUC.Traducir(ucp, p.paciente);
            }
        }

	}
}
