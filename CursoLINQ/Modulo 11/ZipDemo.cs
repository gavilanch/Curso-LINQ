using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11
{
    public class ZipDemo
    {
        public void Ejemplo()
        {
            int[] A = { 1, 2, 3 };
            int[] B = { 4, 5, 6 };

            var combinados = A.Zip(B);
            foreach (var combinacion in combinados)
            {
                Console.WriteLine($"({combinacion.First}, {combinacion.Second})");
            }

            var resultado = A.Zip(B, (a, b) => a * b);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
