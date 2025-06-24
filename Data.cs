

using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLSERVER2014ECE; Initial Catalog=DbCalendario; Integrated Security=SSPI; TrustServerCertificate=true;");
        }
        public DbSet<Calendario> Calendarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Atividades> Atividades { get; set; }
    }
}