using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_9
{
    public class GroupJoinDemo
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
                new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"},
                new Empresa{Id = 4, Nombre = "Ferreteria Lorenzo"}
            };

            var empresasYSusEmpleados = empresas.GroupJoin(personas, e => e.Id, p => p.EmpresaId,
                (empresa, personas) => new { Empresa = empresa, Personas = personas });

            // Sintaxis de queries
            var empresasYSusEmpleados_2 = from empresa in empresas
                                          join persona in personas
                                          on empresa.Id equals persona.EmpresaId into personas2
                                          select new
                                          {
                                              Empresa = empresa,
                                              Personas = personas2
                                          };

            foreach (var item in empresasYSusEmpleados_2)
            {
                Console.WriteLine($"Las siguientes personas trabajan en {item.Empresa.Nombre}");

                foreach (var persona in item.Personas)
                {
                    Console.WriteLine($"-{persona.Nombre}");
                }
            }

        }
    }
}
