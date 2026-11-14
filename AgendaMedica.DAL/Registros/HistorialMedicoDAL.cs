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
    public class HistorialMedicoDAL
    {
        public void Guardar(HistorialMedico historial)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"INSERT INTO historial_medico (id_paciente,id_cita,fecha_registro,diagnostico,observaciones)
                             VALUES (@IdPaciente,@IdCita,@FechaRegistro,@Diagnostico,@Observaciones)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdPaciente", historial.IdPaciente);
                cmd.Parameters.AddWithValue("@IdCita", historial.IdCita);
                cmd.Parameters.AddWithValue("@FechaRegistro", historial.FechaRegistro);
                cmd.Parameters.AddWithValue("@Diagnostico", historial.Diagnostico);
                cmd.Parameters.AddWithValue("@Observaciones", historial.Observaciones);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable MostrarHistorial()
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = "SELECT * FROM historial_medico";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public void Actualizar(HistorialMedico historial)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"UPDATE historial_medico
                             SET id_paciente=@IdPaciente,id_cita=@IdCita,fecha_registro=@FechaRegistro,
                             diagnostico=@Diagnostico,observaciones=@Observaciones WHERE id_historial=@IdHistorial";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdHistorial", historial.IdHistorial);
                cmd.Parameters.AddWithValue("@IdPaciente", historial.IdPaciente);
                cmd.Parameters.AddWithValue("@IdCita", historial.IdCita);
                cmd.Parameters.AddWithValue("@FechaRegistro", historial.FechaRegistro);
                cmd.Parameters.AddWithValue("@Diagnostico", historial.Diagnostico);
                cmd.Parameters.AddWithValue("@Observaciones", historial.Observaciones);

                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idHistorial)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql =
                    "DELETE FROM historial_medico WHERE id_historial=@Id";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Id", idHistorial);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
