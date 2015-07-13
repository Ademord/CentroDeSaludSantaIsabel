using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaludSantaIsabel
{
    public enum TipoRegistroDT
    {
        DIRTY_REG_INSERT = 1,
        DIRTY_REG_UPDATE = 2, 
        DIRTY_REG_DELETE = 3,
        CLEAN_REG = 4 
    }
}
