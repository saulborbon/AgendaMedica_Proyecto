using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.BL.Modelos
{
    public class Medico: Persona
    {
        public int IdMedico { get; set; }
        public string Estado { get; set; }
    }
}
