using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaludSantaIsabel
{
    class FactoriaEstrategiaBusqueda
    {
        public EstrategiaBusqueda getEstrategia(string ESTRATEGY)
        {
            //if (ESTRATEGY == "apellido")
                return new EstrategiaBusquedaApellido();
            
        }
    }
}
