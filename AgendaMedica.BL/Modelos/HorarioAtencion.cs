using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.BL.Modelos
{
    public class HorarioAtencion
    {
        public int IdHorario { get; set; }

        public int IdMedico { get; set; }

        public string DiaSemana { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }
    }
}
