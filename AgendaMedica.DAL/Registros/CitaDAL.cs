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
    public class CitaDAL
    {
        public void Guardar(Cita cita)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"INSERT INTO citas (id_medico,id_paciente,fecha,hora_inicio,hora_fin,duracion_minutos,tipo_cita,estado_cita)
                             VALUES (@IdMedico,@IdPaciente,@Fecha,@HoraInicio,@HoraFin,@DuracionMinutos,@TipoCita,@EstadoCita)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdMedico", cita.IdMedico);
                cmd.Parameters.AddWithValue("@IdPaciente", cita.IdPaciente);
                cmd.Parameters.AddWithValue("@Fecha", cita.Fecha);
                cmd.Parameters.AddWithValue("@HoraInicio", cita.HoraInicio);
                cmd.Parameters.AddWithValue("@HoraFin", cita.HoraFin);
                cmd.Parameters.AddWithValue("@DuracionMinutos", cita.DuracionMinutos);
                cmd.Parameters.AddWithValue("@TipoCita", cita.TipoCita);
                cmd.Parameters.AddWithValue("@EstadoCita", cita.EstadoCita);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable MostrarCitas()
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = "SELECT * FROM citas";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public void Actualizar(Cita cita)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"UPDATE citas
                             SET id_medico=@IdMedico,id_paciente=@IdPaciente,fecha=@Fecha,hora_inicio=@HoraInicio,
                             hora_fin=@HoraFin,duracion_minutos=@DuracionMinutos,tipo_cita=@TipoCita,
                             estado_cita=@EstadoCita WHERE id_cita=@IdCita";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdCita", cita.IdCita);
                cmd.Parameters.AddWithValue("@IdMedico", cita.IdMedico);
                cmd.Parameters.AddWithValue("@IdPaciente", cita.IdPaciente);
                cmd.Parameters.AddWithValue("@Fecha", cita.Fecha);
                cmd.Parameters.AddWithValue("@HoraInicio", cita.HoraInicio);
                cmd.Parameters.AddWithValue("@HoraFin", cita.HoraFin);
                cmd.Parameters.AddWithValue("@DuracionMinutos", cita.DuracionMinutos);
                cmd.Parameters.AddWithValue("@TipoCita", cita.TipoCita);
                cmd.Parameters.AddWithValue("@EstadoCita", cita.EstadoCita);

                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idCita)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql =
                    "DELETE FROM citas WHERE id_cita=@Id";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Id", idCita);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
