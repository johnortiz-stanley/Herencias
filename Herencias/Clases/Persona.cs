using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias.Clases
{
    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateOnly FechaNacimiento { get; set; }

        public Persona(string cedula, string nombre, string apellido, DateOnly fechaNacimiento)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public void saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} {Apellido} y nací el {FechaNacimiento.ToString("dd/MM/yyyy")}");
        }


    }
}
