using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class AdaptadorUCHClinica
	{
        public CentroSaludSantaIsabel.UCHistoriaClinica Traducir(DTPaciente p)
		{
            CentroSaludSantaIsabel.UCHistoriaClinica uchc = new CentroSaludSantaIsabel.UCHistoriaClinica();
            uchc.labelNombres.Text = p.paciente.Nombres;
            uchc.labelApellidos.Text = p.paciente.Apellidos;
            return uchc;
		}
        public void Traducir(ref UCHistoriaClinica uchc1, DTPaciente p)
        {
            CentroSaludSantaIsabel.UCHistoriaClinica uchc2 = Traducir(p);
            uchc1.labelNombres.Text = uchc2.labelNombres.Text;
            uchc1.labelApellidos.Text = uchc2.labelApellidos.Text;
        }
	}
}
