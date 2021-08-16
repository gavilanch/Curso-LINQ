using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_7
{
    public class TakeWhileSkipWhile
    {
        public void Ejemplo()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 3, 2, 1 };

            // Tomar los elementos mientras el predicado sea true.
            // A partir de que el predicado sea falso, dejar de tomar elementos.
            var resultadoTakeWhile = numeros.TakeWhile(x => x < 5).ToList();

            // Saltarse los elementos mientras el predicado sea true.
            // A partir de que el predicado sea falso, tomar todo lo que sigue.
            var resultadoSkipWhile = numeros.SkipWhile(x => x < 5).ToList();
        }
    }
}
