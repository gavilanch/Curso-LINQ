using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEFCore
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite($"Data Source=cursoLINQ.db");
            optionsBuilder.UseSqlServer("Server=.;Database=CursoLINQ;Trusted_Connection=True");
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
