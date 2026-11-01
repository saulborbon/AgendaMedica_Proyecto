using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaMedica.BL.Modelos;

namespace AgendaMedica.BL.Servicios
{
    public class RolBL
    {
        public void ValidarRol (Rol rol)
        {
            if (string.IsNullOrWhiteSpace(rol.NombreRol))
                throw new Exception("Ingrese el rol");
        }
    }
}
