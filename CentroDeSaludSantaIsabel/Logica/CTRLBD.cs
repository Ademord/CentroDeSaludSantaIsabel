using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CentroSaludSantaIsabel
{
    static class CTRLBD
    {

        public static void Open()
        {
            BD.Instance.conn =
                new NpgsqlConnection("Host=" + BD.Instance.localhost 
                    + "; User=" + BD.Instance.user 
                    + "; Password=" + BD.Instance.password);
            BD.Instance.conn.Open();
        }

        public static void Execute(NpgsqlCommand cmd)
        {

            var reader = cmd.ExecuteReader();
            reader.Read();
        }

        public static void Close()
        {
            BD.Instance.conn.Close();
        }
    }
}
