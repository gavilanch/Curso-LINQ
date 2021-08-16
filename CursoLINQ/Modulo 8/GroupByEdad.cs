using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_8
{
    public class GroupByEdad
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
new Persona { Nombre = "Eugenia", Edad = 27, Soltero = false },
new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false }
};

            var agrupamientoPorRangoEdad = personas.GroupBy(p => p.Edad / 5);

            // Sintaxis de queries

            var agrupamientoPorRangoEdad_2 = from p in personas
                                             group p by p.Edad / 5 into grupos
                                             select grupos;

            foreach (var item in agrupamientoPorRangoEdad_2)
            {
                Console.WriteLine($"Grupo de las personas en el rango de edad {item.Key * 5} - {item.Key * 5 + 5 - 1}");

                foreach (var persona in item)
                {
                    Console.WriteLine($"- {persona.Nombre} (edad: {persona.Edad})");
                }
            }

        }
    }
}
