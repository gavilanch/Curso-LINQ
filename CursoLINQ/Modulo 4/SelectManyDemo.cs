using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_4
{
    public class SelectManyDemo
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo", Telefonos = { "123-456", "789-852" } },
new Persona { Nombre = "Nidia", Telefonos = { "998-478", "568-222" } },
new Persona { Nombre = "Alejandro", Telefonos = { "712-132" } },
new Persona { Nombre = "Valentina" }
};

            var telefonos = personas.SelectMany(x => x.Telefonos).ToList();

            // Ejemplo 2: Entendiendo SelectMany con dos colecciones diferentes
            int[] numeros = { 1, 2, 3 };

            var personasYNumeros = personas.SelectMany(p => numeros, (persona, numero) => new
            {
                Persona = persona,
                Numero = numero
            });

            foreach (var item in personasYNumeros)
            {
                //Console.WriteLine($"{item.Persona.Nombre} - {item.Numero}");
            }

            // Ejemplo 3: personas y telefonos

            var personasYTelefonos = personas.SelectMany(p => p.Telefonos, (persona, telefono) => new
            {
                Persona = persona,
                Telefono = telefono
            });

            foreach (var item in personasYTelefonos)
            {
                Console.WriteLine($"{item.Persona.Nombre} - {item.Telefono}");
            }

            // Sintaxis de queries
            var telefonos_2 = from p in personas
                              from telefono in p.Telefonos
                              select telefono;

            var personasYNumeros_2 = from p in personas
                                     from n in numeros
                                     select new
                                     {
                                         Persona = p,
                                         Numero = n
                                     };

        }
    }
}
