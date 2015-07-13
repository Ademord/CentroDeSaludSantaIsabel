using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaludSantaIsabel
{
    public class AdaptadorUIHC
    {
        public FormHistoriaClinica Traducir(DTPaciente p)
        {
            FormHistoriaClinica form = new FormHistoriaClinica();
            form.ucPaciente.labelNombres.Text = p.paciente.Nombres;
            form.ucPaciente.labelApellidos.Text = p.paciente.Apellidos;
            form.ucPaciente.labelGrupoSanguineo.Text = p.paciente.GrupoSanguineo.ToString();
            form.ucPaciente.labelSexo.Text = p.paciente.Sexo.ToString();
            return form;
        }
    }
}
