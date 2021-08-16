using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_2
{
    public class WhereDemo
    {
        public void Ejemplo()
        {
            int[] numeros = Enumerable.Range(1, 20).ToArray();

            var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();

            //Console.WriteLine("Los numeros impares son:");
            //foreach (var numero in numerosImpares)
            //{
            //    Console.WriteLine(numero);
            //}

            // Sintaxis de métodos 
            var numerosImparesMayoresQue10 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();

            // Sintaxis de query
            var numerosImparesMayoresQue10_2 = from n in numeros
                                               where n % 2 == 1 && n > 10
                                               select n;

            Console.WriteLine("Los números impares mayores que 10 son:");
            foreach (var numero in numerosImparesMayoresQue10_2)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
