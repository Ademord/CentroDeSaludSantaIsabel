using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace CentroSaludSantaIsabel
{
	public class AdaptadorBDDTPaciente : AdaptadorBD
	{
        public static String table_name = "paciente";
        AdaptadorBDDTPaciente(string tn)
        {
            table_name = tn;
        }
        public static NpgsqlCommand QueryAll()
        {
            var cmd = BD.Instance.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + table_name + " ORDER BY apellidos, nombres;";
            return cmd;
        }
        public static DTPaciente Traducir(NpgsqlDataReader dr)
        {
            DTPaciente dtp = new DTPaciente();
            dtp.paciente.Nombres = (String)dr[0];
            dtp.paciente.Apellidos = dr[1].ToString();
            dtp.id = Int32.Parse(dr[2].ToString());
            dtp.paciente.Sexo = dr[3].ToString();
            dtp.paciente.FechaNac = Convert.ToDateTime(dr[4].ToString());
            dtp.paciente.Ocupacion = dr[5].ToString();
            dtp.paciente.EstadoCivil = dr[6].ToString();
            dtp.paciente.Nacionalidad = dr[7].ToString();
            dtp.paciente.IdiomaMaterno = dr[8].ToString();
            dtp.paciente.GrupoSanguineo = dr[9].ToString();
            dtp.paciente.FactorRH = dr[10].ToString();
            dtp.instruccion = Instruccion.INSTRUCTION_NONE;
            return dtp;
        }
        public static NpgsqlCommand Traducir(DTPaciente dtp)
        {
            if (dtp.instruccion == Instruccion.INSTRUCTION_INSERT)
                return insert(dtp);
            else if (dtp.instruccion == Instruccion.INSTRUCTION_UPDATE)
                return update(dtp);
            else return delete(dtp.id);
        }

		public static NpgsqlCommand insert(DTPaciente p)
		{
            var cmd = BD.Instance.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " INSERT INTO " + table_name + " (nombres, apellidos, sexo, fecha_nac," 
            + " ocupacion, estado_civil, nacionalidad, idioma_materno, grupo_sang, \"factorRH\")"
            + " VALUES (@nombres, @apellidos, @sexo, @fecha_nac,"
            + " @ocupacion, @estado_civil, @nacionalidad, @idioma_materno, @grupo_sang, @factorRH);";
            cmd.Parameters.AddWithValue("nombres", p.paciente.Nombres);
            cmd.Parameters.AddWithValue("apellidos", p.paciente.Apellidos);
            cmd.Parameters.AddWithValue("sexo", p.paciente.Sexo.ToString());
            cmd.Parameters.AddWithValue("fecha_nac", p.paciente.FechaNac.ToString());
            cmd.Parameters.AddWithValue("ocupacion", p.paciente.Ocupacion);
            cmd.Parameters.AddWithValue("estado_civil", p.paciente.EstadoCivil);
            cmd.Parameters.AddWithValue("nacionalidad", p.paciente.Nacionalidad);
            cmd.Parameters.AddWithValue("idioma_materno", p.paciente.IdiomaMaterno);
            cmd.Parameters.AddWithValue("grupo_sang", p.paciente.GrupoSanguineo);
            cmd.Parameters.AddWithValue("factorRH", p.paciente.FactorRH);
            return cmd;
		}

        public static NpgsqlCommand update(DTPaciente p)
		{
            var cmd = BD.Instance.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + table_name + " SET nombres = @nombres, apellidos = @apellidos, sexo = @sexo,"
            + " fecha_nac = @fecha_nac, ocupacion = @ocupacion, estado_civil = @estado_civil, nacionalidad = @nacionalidad,"
            + " idioma_materno = @idioma_materno, grupo_sang = @grupo_sang, \"factorRH\" = @factorRH WHERE id = " + p.id + ";";
            cmd.Parameters.AddWithValue("nombres", p.paciente.Nombres);
            cmd.Parameters.AddWithValue("apellidos", p.paciente.Apellidos);
            cmd.Parameters.AddWithValue("sexo", p.paciente.Sexo.ToString());
            cmd.Parameters.AddWithValue("fecha_nac", p.paciente.FechaNac.ToString());
            cmd.Parameters.AddWithValue("ocupacion", p.paciente.Ocupacion);
            cmd.Parameters.AddWithValue("estado_civil", p.paciente.EstadoCivil);
            cmd.Parameters.AddWithValue("nacionalidad", p.paciente.Nacionalidad);
            cmd.Parameters.AddWithValue("idioma_materno", p.paciente.IdiomaMaterno);
            cmd.Parameters.AddWithValue("grupo_sang", p.paciente.GrupoSanguineo);
            cmd.Parameters.AddWithValue("factorRH", p.paciente.FactorRH);
            return cmd;
		}

        public static NpgsqlCommand delete(int id)
		{
            var cmd = BD.Instance.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + table_name + " WHERE id = @id";
            cmd.Parameters.AddWithValue("id", id);
            return cmd;
		}
	}
}
