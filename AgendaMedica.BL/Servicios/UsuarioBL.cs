using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaMedica.BL.Modelos;

namespace AgendaMedica.BL.Servicios
{
    public class UsuarioBL
    {
        public void ValidarUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Username))
                throw new Exception("Ingrese el usuario");
            if (string.IsNullOrWhiteSpace(usuario.Password))
                throw new Exception("Ingrese la contraseña");
        }
    }
}
