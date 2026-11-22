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
    public class MedicoDAL
    {
        public int Guardar(Medico medico)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"INSERT INTO medicos(cedula,nombre,apellido,telefono,correo,estado)
                             VALUES (@Cedula,@Nombre,@Apellido,@Telefono,@Correo,@Estado)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Cedula", medico.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", medico.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", medico.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", medico.Telefono);
                cmd.Parameters.AddWithValue("@Correo", medico.Correo);
                cmd.Parameters.AddWithValue("@Estado", medico.Estado);

                cmd.ExecuteNonQuery();

                return (int)cmd.LastInsertedId;
            }
        }

        public DataTable MostrarMedicos()
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = "SELECT * FROM medicos";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

      public void Actualizar(Medico medico)
{
    ConexionBD conexion = new ConexionBD();

    using (MySqlConnection con = conexion.ObtenerConexion())
    {
        con.Open();

        string sql = @"UPDATE medicos
                       SET cedula = @Cedula,
                           nombre = @Nombre,
                           apellido = @Apellido,
                           telefono = @Telefono,
                           correo = @Correo,
                           estado = @Estado
                       WHERE id_medico = @IdMedico";

        MySqlCommand cmd = new MySqlCommand(sql, con);

        cmd.Parameters.AddWithValue("@IdMedico",medico.IdMedico);
        cmd.Parameters.AddWithValue("@Cedula",medico.Cedula);
        cmd.Parameters.AddWithValue("@Nombre",medico.Nombre);
        cmd.Parameters.AddWithValue("@Apellido",medico.Apellido);
        cmd.Parameters.AddWithValue("@Telefono",medico.Telefono);
        cmd.Parameters.AddWithValue("@Correo",medico.Correo);
        cmd.Parameters.AddWithValue("@Estado",medico.Estado);

        cmd.ExecuteNonQuery();
    }
}

        public void Eliminar (int idMedico)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = "DELETE FROM medicos WHERE id_medico=@Id";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Id", idMedico);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
