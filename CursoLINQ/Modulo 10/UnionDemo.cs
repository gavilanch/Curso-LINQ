using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_10
{
    public class UnionDemo
    {
        public void Ejemplo()
        {
            var personasA = new List<Persona>() {
new Persona { Nombre = "Eduardo", EmpresaId = 1, },
new Persona { Nombre = "Nidia",  EmpresaId = 1 },
new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
};

            var personasB = new List<Persona>()
            {
                new Persona{Nombre = "Fernando", Edad = 25},
                new Persona { Nombre = "Eduardo", EmpresaId = 1, },
            };

            int[] numerosA = { 1, 2, 3, 1, 1, 6 };

            int[] numerosB = { 1, 2, 15 };

            var unionDeNumeros = numerosA.Union(numerosB);

            var unionDePersonas = personasA.UnionBy(personasB, x => x.Nombre);

        }
    }
}
