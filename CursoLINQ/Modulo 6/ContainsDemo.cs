using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_6
{
    public class ContainsDemo
    {
        public void Ejemplo()
        {
            var numeros = Enumerable.Range(1, 5);

            var estaElNumero3 = numeros.Contains(3);

            var estaElNumero20 = numeros.Contains(20);

        }
    }
}
