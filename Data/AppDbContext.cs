using Microsoft.EntityFrameworkCore;
using sistema_de_monitoramento.Models;

namespace sistema_de_monitoramento.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Equipamento> Equipamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipamento>()
                .Property(e => e.DataAquisicao)
                .HasColumnType("timestamp without time zone");

            base.OnModelCreating(modelBuilder);
        }
    }
}
