using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.BL.Modelos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Estado { get; set; }
    }
}
