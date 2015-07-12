using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaludSantaIsabel
{
    class EstrategiaBusquedaApellido: EstrategiaBusqueda
    {
        override public String buscar(String parametro)
        {
            return "SELECT * FROM " + CentroSaludSantaIsabel.AdaptadorBDDTPaciente.table_name + " WHERE apellidos = " + parametro + ";" ;
        }
    }
}
