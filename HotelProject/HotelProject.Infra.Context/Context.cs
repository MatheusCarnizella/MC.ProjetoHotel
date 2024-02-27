using HotelProject.Domain.Entities.Hotel;
using HotelProject.Infra.Context.Mappings;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Infra.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt) { }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Quartos> Quartos { get; set; }
        public virtual DbSet<Aluguel> Aluguels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new QuartosMap());
            modelBuilder.ApplyConfiguration(new AluguelMap());
        }
    }
}
