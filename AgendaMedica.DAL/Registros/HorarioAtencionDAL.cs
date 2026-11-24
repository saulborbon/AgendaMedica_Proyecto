using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaMedica.BL.Modelos;
using AgendaMedica.DAL.Conexion;
using MySql.Data.MySqlClient;
using System.Data;

namespace AgendaMedica.DAL.Registros
{
    public class HorarioAtencionDAL
    {
        public bool EstaDentroHorario(int idMedico, string diaSemana, TimeSpan hora)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql =
                @"SELECT COUNT(*)FROM horarios_atencion WHERE id_medico = @IdMedico AND dia_semana = @DiaSemana
                AND @Hora BETWEEN hora_inicio AND hora_fin";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdMedico", idMedico);

                cmd.Parameters.AddWithValue("@DiaSemana", diaSemana);

                cmd.Parameters.AddWithValue("@Hora", hora);

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                return cantidad > 0;
            }
        }

        public void Actualizar(HorarioAtencion horario)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"UPDATE horarios_atencion
                             SET id_medico=@IdMedico, dia_semana=@DiaSemana, hora_inicio=@HoraInicio,
                             hora_fin=@HoraFin WHERE id_horario=@IdHorario";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdHorario", horario.IdHorario);

                cmd.Parameters.AddWithValue("@IdMedico", horario.IdMedico);

                cmd.Parameters.AddWithValue("@DiaSemana", horario.DiaSemana);

                cmd.Parameters.AddWithValue("@HoraInicio", horario.HoraInicio);

                cmd.Parameters.AddWithValue("@HoraFin", horario.HoraFin);

                cmd.ExecuteNonQuery();
            }
        }
        public DataTable MostrarHorarios()
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql ="SELECT * FROM horarios_atencion";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
        public void Guardar(HorarioAtencion horario)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql =
                @"INSERT INTO horarios_atencion (id_medico,dia_semana,hora_inicio,hora_fin)
                VALUES (@IdMedico,@DiaSemana,@HoraInicio,@HoraFin)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdMedico", horario.IdMedico);

                cmd.Parameters.AddWithValue("@DiaSemana", horario.DiaSemana);

                cmd.Parameters.AddWithValue("@HoraInicio", horario.HoraInicio);

                cmd.Parameters.AddWithValue("@HoraFin", horario.HoraFin);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
