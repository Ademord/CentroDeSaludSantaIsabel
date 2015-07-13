using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace CentroSaludSantaIsabel
{
	public class BD
	{
        private static BD instance;
        public NpgsqlConnection conn { get; set; }
        public string localhost { get; set; }
        public string user { get; set; }
        public string password { get; set; }

        public const int NO_INDEX = 0;
        private BD() { }
        public static BD Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BD();
                    Instance.localhost = "localhost";
                    Instance.user = "centrosalud";
                    Instance.password = "cisco";
                }
                return instance;
            }
        }

	}
}
