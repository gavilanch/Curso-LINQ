// See https://aka.ms/new-console-template for more information

using EjemploEFCore;

using (var context = new ApplicationDbContext())
{
    var persona1 = new Persona() { Nombre = "Felipe" };
    var persona2 = new Persona() { Nombre = "Claudia" };

    context.AddRange(persona1, persona2);
    context.SaveChanges();
}

using (var context = new ApplicationDbContext())
{
    var personas = context.Personas.ToList();
    var personasNombre = context.Personas.Select(p => p.Nombre).ToList();
    var felipe = context.Personas.FirstOrDefault(p => p.Nombre == "Felipe");
    var guillermo = context.Personas.FirstOrDefault(p => p.Nombre == "Guillermo");

    // Sintaxis de queries
    var felipe_2 = (from p in context.Personas
                    where p.Nombre == "Felipe"
                    select p).FirstOrDefault();

    //var segmentos = context.Personas.Chunk(3).ToList();
}

Console.WriteLine("Hello, World!");
