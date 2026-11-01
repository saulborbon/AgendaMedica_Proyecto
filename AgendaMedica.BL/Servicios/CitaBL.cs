using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaMedica.BL.Modelos;

namespace AgendaMedica.BL.Servicios
{
    public class CitaBL
    {
        public void ValidarCita(Cita cita)
        {
            if (cita.IdPaciente <= 0)
                throw new Exception("Debe de seleccionar el id de paciente");
            if (cita.IdMedico <= 0)
                throw new Exception("Debe seleccionar el id del medico");
            if (cita.DuracionMinutos <= 0)
                throw new Exception("Ingrese una duración valida");
        }
    }
}
