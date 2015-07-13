using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace CentroSaludSantaIsabel
{
	public static class CTRLDTPaciente
	{
        public static void LoadBufferPacientesFromBD(NpgsqlCommand cmd)
		{
            NpgsqlDataReader dr = cmd.ExecuteReader();
            List<DTHC> lstSelect = new List<DTHC>();
            while (dr.Read())
            {
                BufferPaciente.Instance.buffer.Add(new DTHC(AdaptadorBDDTPaciente.Traducir(dr)));
            }
		}
        public static void Guardar(DTPaciente dtp)
        {
            
            CTRLBD.Execute(AdaptadorBDDTPaciente.Traducir(dtp));
        }
	}
}
