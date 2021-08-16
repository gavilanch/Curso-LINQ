using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_6
{
    public class AllDemo
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
                    new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
                    new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
                    new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
                    new Persona { Nombre = "Valentina", Edad = 22, Soltero = false }
                    };

            var sonTodasLasPersonasMayoresDeEdad = personas.All(p => p.Edad >= 18);

            var sonTodosSolteros = personas.All(p => p.Soltero);

        }
    }
}
