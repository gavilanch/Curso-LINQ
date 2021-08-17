using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11
{
    public class SequenceEqualDemo
    {
        public void Ejemplo()
        {
            string[] A = { "felipe", "fernando" };

            string[] B = { "felipe", "fernando" };

            string[] C = { "FEliPE", "FernandO" };

            string[] D = { "fernando", "felipe" };

            var AB = A.SequenceEqual(B);

            var AC = A.SequenceEqual(C);

            var ACSinImportarMayusculas = A.SequenceEqual(C, StringComparer.OrdinalIgnoreCase);

            var AD = A.SequenceEqual(D);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
