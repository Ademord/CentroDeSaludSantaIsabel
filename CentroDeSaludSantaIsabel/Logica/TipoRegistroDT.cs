using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaludSantaIsabel
{
    public enum TipoRegistroDT
    {
        DIRTY_REG_INSERT = -1,
        DIRTY_REG_UPDATE = -3, 
        DIRTY_REG_DELETE = -4,
        CLEAN_REG = -2 
    }
}
