using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public static class CTRLDTPaciente
	{
		public static void leerBD()
		{
			
		}
        public static void Guardar(DTPaciente dtp)
        {
            BD.Instance.execute(AdaptadorBDDTPaciente.Traducir(dtp));
        }
	}
}
