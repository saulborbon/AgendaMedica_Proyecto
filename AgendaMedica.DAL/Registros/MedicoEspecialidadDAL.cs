using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaMedica.DAL.Conexion;
using MySql.Data.MySqlClient;
using System.Data;

namespace AgendaMedica.DAL.Registros
{
    public class MedicoEspecialidadDAL
    {
        public void AsignarEspecialidad(
            int idMedico,
            int idEspecialidad)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"INSERT INTO medico_especialidad (id_medico,id_especialidad)
                VALUES (@IdMedico,@IdEspecialidad)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdMedico", idMedico);

                cmd.Parameters.AddWithValue("@IdEspecialidad", idEspecialidad);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable MostrarEspecialidadesMedico(
            int idMedico)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"SELECT e.id_especialidad, e.nombre_especialidad
                             FROM medico_especialidad me INNER JOIN especialidades e ON me.id_especialidad =
                             e.id_especialidad WHERE me.id_medico = @IdMedico";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                da.SelectCommand.Parameters.AddWithValue("@IdMedico", idMedico);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }

}
