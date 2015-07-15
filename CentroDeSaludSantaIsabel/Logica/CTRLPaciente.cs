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
           
            {
                bool valid = false;
                while (!valid && form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try 
                    {
                        form.DialogResult = System.Windows.Forms.DialogResult.None;
                        p = CTRLPaciente.adaptadorDT.Traducir(CTRLPaciente.adaptadorUI.Traducir(form));
                        
                        valid = true;
                        if (ucp.index_paciente != CONFIG.NEW_REG)
                        {
                            p.id = BufferPaciente.Instance.temp.paciente.id;
                            if (p == BufferPaciente.Instance.temp.paciente) 
                                //se hace un update innecesario con los mismos datos al no verificar
                                //que no se haya cambiado ningun dato. habria que agregar eventos a cada textbox..
                                break;
                            p.instruccion = Instruccion.INSTRUCTION_UPDATE;
                        }
                        else
                            p.instruccion = Instruccion.INSTRUCTION_INSERT;
                        BufferPaciente.Instance.temp.paciente = p;
                        BufferPaciente.Instance.temp.tipoRegistro = TipoRegistroDT.DIRTY_REG_INSERT;
                       CTRLPaciente.adaptadorUC.Traducir(ucp, p.paciente);
                    }
                    catch (NullReferenceException e)
                    {
                        System.Windows.Forms.MessageBox.Show("Ingresa bien tus datos! " + e.Message);
                    }
                }
                
                    
                
            }
        }

	}
}
