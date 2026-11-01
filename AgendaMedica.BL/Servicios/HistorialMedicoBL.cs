using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaMedica.BL.Modelos;

namespace AgendaMedica.BL.Servicios
{
    public class HistorialMedicoBL
    {
        public void ValidarHistorial(HistorialMedico historial)
        {
            if (historial.IdPaciente <= 0)
                throw new Exception("Debe seleccionar un paciente");
            if (historial.IdCita <= 0)
                throw new Exception("Debe seleccionar una cita");
            if (string.IsNullOrWhiteSpace(historial.Diagnostico))
                throw new Exception("Debe de ingresar Diagnóstico");
        }
    }
}
