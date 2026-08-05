using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Herencias.Clases
{
    public class DirectorCarrera : Docente
    {
        public string Facultad { get; set; }
        public DirectorCarrera(string cedula, string nombre, string apellido, DateOnly fechaNacimiento, string asignatura, int añosExperiencia, string facultad)
            : base(cedula, nombre, apellido, fechaNacimiento, asignatura, añosExperiencia)
        {
            Facultad = facultad;
        }
        public void dirigir()
        {
            Console.WriteLine($"Soy {Nombre} {Apellido}, dirijo la facultad de {Facultad} y enseño la asignatura de {Asignatura} con {AñosExperiencia} años de experiencia.");
        }
    }
}
