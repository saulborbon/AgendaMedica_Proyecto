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
            if (cita.DuracionMinutos != 30 &&
                cita.DuracionMinutos != 45 &&
                cita.DuracionMinutos != 60)
            {
                throw new Exception("La duración debe ser 30, 45 o 60 minutos");
            }

            if (cita.HoraFin <= cita.HoraInicio)
            {
                throw new Exception("La hora final debe ser mayor a la inicial");
            }
        }
    }
}
