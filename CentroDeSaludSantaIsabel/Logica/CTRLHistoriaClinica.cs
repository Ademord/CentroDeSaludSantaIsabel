using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaludSantaIsabel
{
    class CTRLHistoriaClinica
    {
        public static EstrategiaBusqueda estrategiaBusqueda;
        public void NuevaHistoriaClinica()
        {
            FormHistoriaClinica form = new FormHistoriaClinica();
            var res = form.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                //save in BD
            }
            
        }
        
    }
}
