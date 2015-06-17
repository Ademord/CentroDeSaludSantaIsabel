using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaludSantaIsabel
{
    public static class AdaptadorUIPaciente
    {
        public static Paciente Traducir(Personas.FormPaciente form)
        {

            //el form principal, centrosalud, llama al controlador de historia clinica
            //puede llamar para busqueda 
            //para la busqueda se puede utilizar el patron estrategia que define el parametro de busqueda
                //  en la busqueda el controlador de historia clinica llama al controladorPaciente 
                // que busca crea la instruccion de busqueda y la envia a la BD 
                //  se carga el resultado de la busqueda en buffer paciente
                //  la busqueda siempre muestra un formulario con UCPaciente si es que pillo
                // ** esta busqueda se carga en un formulario general FormBusqueda, que carga UCs de cualquier tipo
                // al controladorPaciente es el que le corresponde saber si el resultado del form fue
                // ok o cancel
                //  UCPaciente.gestionar llama al controlador el cual hace ShowDialog para FormPaciente
                // este FormPaciente se debe cargar, con la info del paciente
                // este paciente se ubica con UCPaciente.indice (var aux)
                // envia al controladorPaciente su indice, para que este ubique al paciente del buffer
            //FormCentroSalud.Buscar->
            //  CTRLHistoriaClinica.EstrategiaBusqueda = FactoriaEstrategiaBusqueda(TextBox.Text.Split[0])
            //  CTRLHistoriaClinica.EstrategiaBusqueda.Buscar(TextBox.Text.Split[1])->
            //      CTRLPaciente.Buscar(TextBox.Text.Split[1], TextBox.Text.Split[2])
            //  CTRLHistoriaClinica.FormBusqueda.Show()
            //  CTRLHistoriaClinica.EstrategiaBusqueda.CargarFormBusqueda(flowLayoutPanel)->
            //      CTRLPaciente.CargarFormBusqueda(flowLayoutPanel)->
            //          Foreach p in BufferPaciente: 
            //              ucp = AdaptadorUIHistoriaClinica.Traducir(p)
            //              ucp.index = _index++
            //              flowLayoutPanel.add(ucp)
            //
            //      UCHistoriaClinica.Gestionar()->CTRLHistoriaClinica.FormHistoriaC.ShowDialog(thisUCPaciente.index)->
            //          ->CTRLHistoriaClinica.FormHistoriaClinica.UCPaciente =
            //              CTRLPaciente->CargarUIPaciente(UCPaciente)->
            //                  CTRLPaciente->received_UCPaciente = AdaptadorUIPaciente.Traducir(
            //              CTRLHistoriaClinica->BufferPaciente.findByIndex(receivedUCPIndex): Paciente p)
            //          ->CTRLPaciente.HistoriaClinica.ShowDialog())
            //          
            //      
            //      ->if CTRLPaciente.FormPaciente.RESULT == OK : (FORM CAMBIADO)
            //              CTRLPaciente.Instrucciones.Add(index, INSTRUCTION_UPDATE)
            //              CTRLPaciente->BufferPaciente[index] = 
            //                  CTRLPaciente->AdaptadorUIPaciente.Traducir(FormPaciente)
            //              CTRLPaciente->CTRL
            //              return UCP
            //          ->else return null
            //      res = UCPaciente.Gestionar()->CTRLPaciente.ShowDialog(...).RESULT
            //      if res != null : this = res;
            //        
            
            //  puede llamar para nuevo
                //  se llama al controladorPaciente que abre un formularioPaciente vacio con NEW en true
                //  FormCentroSalud.Nuevo()->CTRLHistoriaClinica.ShowNew()->
                //  CTRLHistoriaClinica.FormHistoriaClinica.Show():
                //--PACIENTE--
                //  FormHistoriaClinica.NEW = TRUE;
                //  FormHistoriaClinica.UCPaciente.Gestionar()->FormHistoriaClinica.GestionarPaciente()->
                //  res = CTRLPaciente.GestionarPaciente()->
                //      -> CTRLPaciente.FormPaciente.ShowDialog(): return RESULT
                //      -> if CTRLPaciente.FormPaciente.RESULT == OK
                //          Paciente p = AdaptadorUIPaciente.Traducir(FormPaciente)
                //          BufferPaciente.Add(p)
                //          CTRLPaciente.Instrucciones.Add(NO_INDEX, NEW? INSTRUCTION_INSERT: INSTRUCTION_UPDATE)
                //          UCPaciente ucp = CTRLPaciente.AdaptadorUCPPaciente.Traducir(p)
                //          ucp.NEW = FALSE;
                //          return UCP;
                //      -> else return null
                //  if res != null : CTRLHistoriaClinica.FormHistoriaClinica.UCPaciente = res;
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
                //--RESPONSABLE--
                //  CTRLResponsable.indice_paciente = CTRLPaciente.indice_paciente
                //  FormHistoriaClinica.NuevoResponsable()->CTRLHistoriaClincia.NuevoResponsable()->
                //  res = CTRLResponsable.NuevoResponsable -> FormResponsable.Show() : UCResponsable ->
                //      -> CTRLResponsable.FormPaciente.ShowDialog(): return RESULT
                //      -> if CTRLResponsable.FormResponsable.RESULT == OK
                //          Responsable r = AdaptadorUIResponsable.Traducir(FormResponsable)
                //          CTRLResponsable.indice_responsable = BufferResponsable.Add(r)
                //          CTRLResponsable.Instrucciones.Add(NO_INDEX, INSTRUCTION_INSERT)
                //          UCResponsable ucr = CTRLPaciente.AdaptadorUCResponsable.Traducir(r)
                //          return ucr;
                //      -> else return null
                //
                //  if res != null : this = res;
                //  ...
                //--CONSULTA_ENFERMERIA--
                //  CTRLConsultaEnfemeria.indice_paciente = CTRLPaciente.indice_paciente
                //  ...
                //--CONSULTA_MEDICA--
                //  ...
            //FormCentroSalud.GuardarBD()->CTRLHistoriaClinica.Instrucciones

            // una vez que se guarda en BD 
                // CTRLDTPaciente toma los indices y traduce tales pacientes segun la instruccion
                // en sentencias sql

            //
        }
        public static Personas.FormPaciente Traducir(Paciente p)
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
