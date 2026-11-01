using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaMedica.BL.Modelos;

namespace AgendaMedica.BL.Servicios
{
    public class EspecialidadBL
    {
        public void ValidarEspecialidad(Especialidad especialidad)
        {
            if (string.IsNullOrWhiteSpace(especialidad.NombreEspecialidad))
                throw new Exception("Debe ingresar la especialidad");
        }
    }
}
