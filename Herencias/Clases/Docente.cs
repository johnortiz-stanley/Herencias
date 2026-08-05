using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Herencias.Clases
{
    public class Docente : Persona
    {
        public string Asignatura { get; set; }
        public int AñosExperiencia { get; set; }
        public Docente(string cedula, string nombre, string apellido, DateOnly fechaNacimiento, string asignatura, int añosExperiencia)
            : base(cedula, nombre, apellido, fechaNacimiento)
        {
            Asignatura = asignatura;
            AñosExperiencia = añosExperiencia;
        }
        public void enseñar()
        {
            Console.WriteLine($"Soy {Nombre} {Apellido}, enseño la asignatura de {Asignatura} y tengo {AñosExperiencia} años de experiencia.");
        }

    }
}
