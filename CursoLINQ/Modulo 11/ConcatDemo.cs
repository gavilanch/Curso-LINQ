using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11
{
    public class ConcatDemo
    {
        public void Ejemplo()
        {
            int[] A = { 1, 2, 3 };

            int[] B = { 4, 5, 6 };

            var resultado = A.Concat(B);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
