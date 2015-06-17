using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeSaludSantaIsabel
{
    class EstrategiaBusquedaApellido
    {
        public String buscar(String parametro)
        {
            return "SELECT * FROM " + CentroSaludSantaIsabel.AdaptadorBDDTPaciente.table_name + " WHERE apellidos = " + parametro
        }
    }
}
