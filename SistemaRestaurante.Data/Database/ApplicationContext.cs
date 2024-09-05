using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Domain.Entidades;

namespace SistemaRestaurante.Data.Database
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}
