using System;
using System.Collections.Generic;
using System.Text;

namespace CentroSaludSantaIsabel
{
	public class AdaptadorUCPaciente
	{
        public CentroSaludSantaIsabel.UCPaciente Traducir( DTPaciente p)
		{
            CentroSaludSantaIsabel.UCPaciente uchc = new CentroSaludSantaIsabel.UCPaciente();
            uchc.labelNombres.Text = p.paciente.Nombres;
            uchc.labelApellidos.Text = p.paciente.Apellidos;
            uchc.labelGrupoSanguineo.Text = p.paciente.GrupoSanguineo.ToString();
            uchc.labelSexo.Text = p.paciente.Sexo.ToString();
            uchc.index_paciente = p.id;
            return uchc;
		}
        public void Traducir(UCPaciente ucp, Paciente p)
        {
            ucp.labelApellidos.Text = p.Apellidos;
            ucp.labelNombres.Text = p.Nombres;
            ucp.labelSexo.Text = p.Sexo;
            ucp.labelGrupoSanguineo.Text = p.GrupoSanguineo;
        }
	}
}
