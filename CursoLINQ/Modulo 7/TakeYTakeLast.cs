using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_7
{
    public class TakeYTakeLast
    {
        public void Ejemplo()
        {
            var numeros = Enumerable.Range(1, 100);

            var primeros10Numeros = numeros.Take(10).ToList();

            var ultimos10Numeros = numeros.TakeLast(10).ToList();

            // Sintaxis de queries
            var primeros10Numeros_2 = (from n in numeros
                                       select n).Take(10);
        }
    }
}
