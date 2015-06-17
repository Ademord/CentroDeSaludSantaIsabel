using System;
using System.Collections.Generic;
using System.Text;


namespace CentroSaludSantaIsabel
{
	public static class CTRLPaciente
	{
        //public int index_paciente;
        public static UCPaciente GestionarPaciente(ref int index_paciente)
        {
            Paciente p;
            if (index_paciente == -1)
            {
                Personas.FormPaciente form = new Personas.FormPaciente();
                var res = form.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    p = AdaptadorUIPaciente.Traducir(form);
                    index_paciente = BufferPaciente.Instance.add(p);
                    UCPaciente ucp = AdaptadorUCPaciente.Traducir(p);
                    return ucp;
                         
                }
                else return null;
            }
            else
            {
                //modificar
                p = BufferPaciente.Instance.find(index_paciente);
                Personas.FormPaciente form = AdaptadorUIPaciente.Traducir(p);
                var res = form.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    p = AdaptadorUIPaciente.Traducir(form);
                    if (form != AdaptadorUIPaciente.Traducir(p))
                    {
                        BufferPaciente.Instance.remove(p);
                        index_paciente = BufferPaciente.Instance.add(p);
                    }
                    UCPaciente ucp = AdaptadorUCPaciente.Traducir(p);
                    return ucp;
                }
                else return null;
            }
            



        }
		public static void cargarBuffer()
		{
			throw new NotImplementedException();
		}

		public static void guardarBufferEnBD()
		{
            BD.Instance.open();
            foreach (KeyValuePair<int,int> instruccion in BufferPaciente.Instance.instrucciones)
            {

                DTPaciente dtp =  AdaptadorDTPaciente.traducir(BufferPaciente.Instance.buffer[instruccion.Key-1]);
     
                BD.Instance.execute(AdaptadorBDDTPaciente.traducir(dtp,instruccion.Value));

            }
            BD.Instance.close();
            //FormHistoriaClincia.Guardar()->CTRLHistoriaClinica.GuardarBuffersEnBD()->
            //  CTRLPaciente.GuardarPacienteEnBD
            //  CTRLResponsable.GuardarResponsablesEnBD
		}
	}
}
