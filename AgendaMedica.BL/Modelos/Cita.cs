using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.BL.Modelos
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdMedico { get; set; }
        public int IdPaciente { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int DuracionMinutos { get; set; }
        public string TipoCita { get; set; }
        public string EstadoCita { get; set; }

    }
}
