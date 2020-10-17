using Microsoft.EntityFrameworkCore;
using Registro_Detalle.Models;

namespace Registro_Detalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Prestamos> Prestamos { get; set;}
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Moras> Moras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Data\PrestamoDB.db");
        }
    }
}