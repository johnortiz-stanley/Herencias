using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias.Clases
{
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }
        public int Semestre { get; set; }

        public Estudiante(string cedula, string nombre, string apellido, DateOnly fechaNacimiento, string carrera, int semestre)
            : base(cedula, nombre, apellido, fechaNacimiento)
        {
            Carrera = carrera;
            Semestre = semestre;
        }

        public void estudiar()
        {
            Console.WriteLine($"Soy {Nombre} {Apellido}, estudio {Carrera} y estoy en el semestre {Semestre}");
        }


    }
}
