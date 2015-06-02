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
            conn = new NpgsqlConnection("Host=" + localhost + "; User=" + user + "; Password=" + password);
            conn.Open();
		}

		public void execute(NpgsqlCommand cmd)
		{
            try
            {
                var reader = cmd.ExecuteReader();
                reader.Read();
            }
            catch (Exception _error)
            {
                System.Windows.Forms.MessageBox.Show("Error de bd");
            }
		}

		public void close()
		{
            conn.Close();
		}
	}
}
