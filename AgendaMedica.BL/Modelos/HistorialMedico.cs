using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.BL.Modelos
{
    public class HistorialMedico
    {
        public int IdHistorial { get; set; }
        public int IdPaciente { get; set; }
        public int IdCita { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Diagnostico { get; set; }
        public string Observaciones { get; set; }
    }
}
