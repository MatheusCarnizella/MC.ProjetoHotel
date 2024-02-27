using HotelProject.Domain.Entities.Hotel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelProject.Infra.Context.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario", "Hotel")
                   .HasKey(x => x.Id);

            builder.Property(x => x.Id)
                  .ValueGeneratedOnAdd();
        }
    }
}
