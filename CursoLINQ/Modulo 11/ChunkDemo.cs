using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11
{
    public class ChunkDemo
    {
        public void Ejemplo()
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var resultado = A.Chunk(3);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
