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
        public static string localhost { get; set; }
        public static string user { get; set; }
        public static string password { get; set; }
        public const int INSTRUCTION_INSERT = 0;
        public const int INSTRUCTION_UPDATE = 1;
        public const int INSTRUCTION_DELETE = 2;
        public const int NO_INDEX = 0;
        private BD() { }
        public static BD Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BD();
                    localhost = "localhost";
                    user = "centrosalud";
                    password = "cisco";
                }
                return instance;
            }
        }

		public void open()
		{
            instance.conn = new NpgsqlConnection("Host=" + localhost + "; User=" + user + "; Password=" + password);
            conn.Open();
		}

		public void execute(NpgsqlCommand cmd)
		{
           
                var reader = cmd.ExecuteReader();
                reader.Read();
  		}

		public void close()
		{
            conn.Close();
		}
	}
}
