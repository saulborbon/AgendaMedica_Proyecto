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
    public class EspecialidadDAL
    {
        public void Guardar(Especialidad especialidad)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"INSERT INTO especialidades (nombre_especialidad,descripcion)
                             VALUES (@NombreEspecialidad,@Descripcion)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@NombreEspecialidad", especialidad.NombreEspecialidad);
                cmd.Parameters.AddWithValue("@Descripcion", especialidad.Descripcion);

                cmd.ExecuteNonQuery();

            }
        }
        public DataTable MostrarEspecialidades()
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = "SELECT * FROM especialidades";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
        }

        public void Actualizar(Especialidad especialidad)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"UPDATE especialidades
                             SET nombre_especialidad=@NombreEspecialidad, descripcion=@Descripcion WHERE id_especialidad=@IdEspecialidad";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdEspecialidad", especialidad.IdEspecialidad);
                cmd.Parameters.AddWithValue("@NombreEspecialidad", especialidad.NombreEspecialidad);
                cmd.Parameters.AddWithValue("@Descripcion", especialidad.Descripcion);

                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idEspecialidad)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql =
                    "DELETE FROM especialidades WHERE id_especialidad=@Id";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Id", idEspecialidad);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

