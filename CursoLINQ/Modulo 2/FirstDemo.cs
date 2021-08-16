using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_2
{
    public class FirstDemo
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

            var primeraPersona = personas.First();
            var primeraPersona2 = personas.FirstOrDefault();

            var paises = new List<string>();
            try
            {
                var primerPais = paises.First();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ha ocurrido un error");
            }

            var primerPais2 = paises.FirstOrDefault();

            var numeros = new List<int>();
            var primerNumero = numeros.FirstOrDefault();

            var primeraPersonaNoSoltera = personas.FirstOrDefault(p => !p.Soltero);

            // Sintaxis de queries
            var primeraPersonaNoSoltera_2 = (from p in personas
                                             where !p.Soltero
                                             select p).FirstOrDefault();
        }
    }
}
