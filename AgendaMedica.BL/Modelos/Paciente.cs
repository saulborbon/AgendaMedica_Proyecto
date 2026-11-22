using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.BL.Modelos
{
    public class Paciente: Persona
    {
        public int IdPaciente { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
