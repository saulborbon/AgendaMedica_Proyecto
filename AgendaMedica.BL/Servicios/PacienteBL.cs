using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaMedica.BL.Modelos;
using System.Data;

namespace AgendaMedica.BL.Servicios
{
    public class PacienteBL //Clase encargada de la lógica de negocio relacionada con pacientes
                            //decide si los datos son válidos antes de guardar:)
    {

        public void ValidarPaciente(Paciente paciente) //método que recibe objetos de tipo Paciente
                                                      
        {
            if (string.IsNullOrWhiteSpace(paciente.Cedula))
                throw new Exception("Por favor ingrese la cédula");
            if (string.IsNullOrWhiteSpace(paciente.Nombre))
                throw new Exception("Por favor ingrese el nombre");
            if (string.IsNullOrWhiteSpace(paciente.Apellido))
                throw new Exception("Por favor ingrese el apellido");
        }
    }
}
