using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_5
{
    public class Promedio
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", Edad = 19, },
                            new Persona { Nombre = "Nidia", Edad = 25 },
                            new Persona { Nombre = "Alejandro", Edad = 30 },
                            new Persona { Nombre = "Valentina", Edad = 22 }
                            };

            var numeros = Enumerable.Range(1, 5);

            Console.WriteLine($"El promedio de los números es {numeros.Average()}");

            Console.WriteLine($"El promedio de las edades es {personas.Average(p => p.Edad)}");

        }
    }
}
