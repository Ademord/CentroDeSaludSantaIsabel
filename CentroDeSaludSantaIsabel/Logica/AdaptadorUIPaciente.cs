using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaludSantaIsabel
{
    public class AdaptadorUIPaciente
    {
        public Paciente Traducir(Personas.FormPaciente form)
        {

            Paciente p = new Paciente();
            p.Nombres = form.textBoxNombre.Text.ToString();
            p.Apellidos = form.textBoxApellidos.Text.ToString();
            p.FechaNac = form.dateTimePickerFechaNacimiento.Value;
            p.Sexo = form.comboBoxSexo.SelectedItem.ToString();
            p.Ocupacion = form.textBoxOcupacion.Text.ToString();
            p.EstadoCivil = form.textBoxEstadoCivil.Text.ToString();
            p.Nacionalidad = form.textBoxNacionalidad.Text.ToString();

            p.IdiomaMaterno = form.textBoxIdiomaMaterno.Text.ToString();
            p.GrupoSanguineo = form.comboBoxGrupoSanguineo.SelectedItem.ToString();
            p.FactorRH = form.comboBoxFactorRH.Text.ToString();

            return p;
        }
        public Personas.FormPaciente Traducir(Paciente p)
        {
            Personas.FormPaciente form = new Personas.FormPaciente();
            form.textBoxNombre.Text = p.Nombres;
            form.textBoxApellidos.Text = p.Apellidos;
            form.dateTimePickerFechaNacimiento.Value = p.FechaNac;
            form.comboBoxSexo.SelectedItem = p.Sexo;
            form.textBoxOcupacion.Text = p.Ocupacion;
            form.textBoxEstadoCivil.Text= p.EstadoCivil;
            form.textBoxNacionalidad.Text = p.Nacionalidad;

            form.textBoxIdiomaMaterno.Text = p.IdiomaMaterno;
            form.comboBoxGrupoSanguineo.SelectedItem = p.GrupoSanguineo;
            form.comboBoxFactorRH.Text = p.FactorRH;
            return form;
        }
    }
}
