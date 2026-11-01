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
    public class PacienteDAL //Clase encargada de realizar operaciones sobre
                             //la tabla Pacientes en la base de datos
    {
        public void Guardar(Paciente paciente)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string sql = @"INSERT INTO pacientes (cedula,nombre,apellido,telefono,correo,fecha_nacimiento)
                             VALUES (@Cedula,@Nombre,@Apellido,@Telefono,@Correo,@FechaNacimiento)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Cedula", paciente.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                cmd.Parameters.AddWithValue("@Correo", paciente.Correo);
                cmd.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);

                cmd.ExecuteNonQuery();

            }
        }
        public DataTable MostrarPacientes()
        {
            ConexionBD conexion = new ConexionBD();
            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = "SELECT * FROM Pacientes";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
        }
        public void Eliminar(int idPaciente)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = "DELETE FROM Pacientes WHERE id_paciente=@Id";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Id", idPaciente);

                cmd.ExecuteNonQuery();
            }
        }
        public void Actualizar(Paciente paciente)
        {
            ConexionBD conexion = new ConexionBD();

            using (MySqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"UPDATE Pacientes SET cedula=@Cedula,nombre=@Nombre,apellido=@Apellido,
                             telefono=@Telefono,correo=@Correo,fecha_nacimiento=@FechaNacimiento
                             WHERE id_paciente=@IdPaciente";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@IdPaciente", paciente.IdPaciente);
                cmd.Parameters.AddWithValue("@Cedula", paciente.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                cmd.Parameters.AddWithValue("@Correo", paciente.Correo);
                cmd.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
