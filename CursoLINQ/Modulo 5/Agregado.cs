using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_5
{
    public class Agregado
    {
        public void Ejemplo()
        {
            var numeros = Enumerable.Range(1, 5);

            var resultado = numeros.Aggregate((a, b) => a * b); // 1x2x3x4x5

            Console.WriteLine("Resultado es " + resultado);

            var resultadoConValorInicial = numeros.Aggregate(10, (a, b) => a * b);

            Console.WriteLine("El resultado con el valor semilla es: " + resultadoConValorInicial);
        }
    }
}
