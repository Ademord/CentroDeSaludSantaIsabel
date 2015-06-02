using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public static class AdaptadorUCHClinica
	{
        public static CentroDeSaludSantaIsabel.UCHistoriaClinica PatToUCHistoriaC(Paciente p)
		{
            CentroDeSaludSantaIsabel.UCHistoriaClinica uchc = new CentroDeSaludSantaIsabel.UCHistoriaClinica();
            uchc.labelNombres.Text = p.Nombres;
            uchc.labelApellidos.Text = p.Apellidos;
            uchc.labelTelefono.Text = p.Telefono.ToString();
            return uchc;
		}
	}
}
