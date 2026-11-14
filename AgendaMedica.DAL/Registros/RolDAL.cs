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
    public class RolDAL
    {
        public void Guardar(Rol rol)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"INSERT INTO roles (nombre_rol)
                             VALUES (@NombreRol)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@NombreRol", rol.NombreRol);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable MostrarRoles()
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = "SELECT * FROM roles";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public void Actualizar(Rol rol)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"UPDATE roles
                             SET nombre_rol=@NombreRol WHERE id_rol=@IdRol";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdRol", rol.IdRol);
                cmd.Parameters.AddWithValue("@NombreRol", rol.NombreRol);

                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idRol)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql =
                    "DELETE FROM roles WHERE id_rol=@Id";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Id", idRol);

                cmd.ExecuteNonQuery();
            }
        }
    }
    
}

