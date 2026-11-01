using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AgendaMedica.DAL.Conexion
{
    public class ConexionBD
    {
        private string enlace = "Server=localhost;Database=agendamedicadb;username=root;password=Pas03xxx5672MYSQLdari03+;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(enlace);
        }
    }
}
