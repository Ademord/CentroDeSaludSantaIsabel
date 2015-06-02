using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace CentroSaludSantaIsabel
{
	public class AdaptadorBDDTPaciente : AdaptadorBD
	{
        AdaptadorBDDTPaciente(string tn)
        {
            this.table_name = tn;
        }
		public NpgsqlCommand insert(DTPaciente p)
		{

            var cmd = BD.Instance.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO" + table_name + "(nombres, apellidos) VALUES (@nombres, @apellidos);";
            cmd.Parameters.AddWithValue("nombres", p.paciente.Nombres);
            cmd.Parameters.AddWithValue("apellidos", p.paciente.Apellidos);
            return cmd;
		}

        public NpgsqlCommand update(DTPaciente p)
		{
            var cmd = BD.Instance.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE @table_name SET nombres = '@nombres', apellidos = @apellidos WHERE id = @id" ;
            cmd.Parameters.AddWithValue("nombres", p.paciente.Nombres);
            cmd.Parameters.AddWithValue("apellidos", p.paciente.Apellidos);
            cmd.Parameters.AddWithValue("id", p.id);
            cmd.Parameters.AddWithValue("table_name", table_name);
            return cmd;
		}

        public NpgsqlCommand delete(int id)
		{
            var cmd = BD.Instance.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM @table_name WHERE id = @id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("table_name", table_name);
            return cmd;
		}
	}
}
