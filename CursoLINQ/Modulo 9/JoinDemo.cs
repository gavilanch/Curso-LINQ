using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_9
{
    public class JoinDemo
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Alejandro", EmpresaId = 3 },
                            new Persona { Nombre = "Valentina",  EmpresaId = 2 },
                            new Persona { Nombre = "Roberto",  EmpresaId = 3 },
                            new Persona { Nombre = "Eugenia"},
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
                            };

            var empresas = new List<Empresa>()
            {
                new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
                new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
                new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"}
            };

            var personasYEmpresas = personas.Join(empresas, p => p.EmpresaId, e => e.Id, (persona, empresa) => new
            {
                Persona = persona,
                Empresa = empresa
            });

            // Sintaxis de queries
            var personasYEmpresas_2 = from persona in personas
                                      join empresa in empresas on persona.EmpresaId equals empresa.Id
                                      select new
                                      {
                                          Persona = persona,
                                          Empresa = empresa
                                      };

            foreach (var item in personasYEmpresas_2)
            {
                Console.WriteLine($"{item.Persona.Nombre} trabaja en {item.Empresa.Nombre}");
            }

        }
    }
}
