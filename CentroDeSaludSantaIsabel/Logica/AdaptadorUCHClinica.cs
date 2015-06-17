using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public static class AdaptadorUCHClinica
	{
        public static CentroSaludSantaIsabel.UCHistoriaClinica PatToUCHistoriaC(Paciente p)
		{
            CentroSaludSantaIsabel.UCHistoriaClinica uchc = new CentroSaludSantaIsabel.UCHistoriaClinica();
            uchc.labelNombres.Text = p.Nombres;
            uchc.labelApellidos.Text = p.Apellidos;
            return uchc;
		}
	}
}
