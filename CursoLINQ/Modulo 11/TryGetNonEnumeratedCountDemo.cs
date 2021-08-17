using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11
{
    public class TryGetNonEnumeratedCountDemo
    {
        public void Ejemplo()
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var conteo = 0;
            var pudoContarASinEnumerar = A.TryGetNonEnumeratedCount(out conteo);

            var personasA = new List<Persona>()
            {
                new Persona{Nombre = "Eduardo", EmpresaId = 1},
                new Persona{Nombre = "Nidia", EmpresaId = 1},
                new Persona{Nombre = "Esmerlin", EmpresaId = 3}
            };

            var personasCollection = new PersonasCollection();
            personasCollection.AddRange(personasA);

            var conteoPersonas2 = 0;
            var pudoContarPersonasSinEnumerar = personasCollection.TryGetNonEnumeratedCount(out conteoPersonas2);
        }

        public class PersonasCollection : IEnumerable<Persona>, ICollection<Persona>
        {
            private readonly List<Persona> _personas = new List<Persona>();

            public int Count => _personas.Count;

            public bool IsReadOnly => throw new NotImplementedException();

            public void Add(Persona persona)
            {
                _personas.Add(persona);
            }

            public void AddRange(IEnumerable<Persona> personas)
            {
                _personas.AddRange(personas);
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(Persona item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(Persona[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<Persona> GetEnumerator()
            {
                return _personas.GetEnumerator();
            }

            public bool Remove(Persona item)
            {
                throw new NotImplementedException();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<Persona>)_personas).GetEnumerator();
            }
        }


    }

}
