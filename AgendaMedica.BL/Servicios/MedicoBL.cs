using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaMedica.BL.Modelos;

namespace AgendaMedica.BL.Servicios
{
    public class MedicoBL
    {
        public void ValidarMedico(Medico medico)
        {
            if (string.IsNullOrWhiteSpace(medico.Cedula))
                throw new Exception("La cédula es obligatoria");
            if (string.IsNullOrWhiteSpace(medico.Nombre))
                throw new Exception("El nombre es obligatorio");
            if (string.IsNullOrWhiteSpace(medico.Apellido))
                throw new Exception("El apellido es obligatorio");
        }
    }
}
