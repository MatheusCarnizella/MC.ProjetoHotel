using HotelProject.Domain.Entities.Hotel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelProject.Infra.Context.Mappings
{
    public class QuartosMap : IEntityTypeConfiguration<Quartos>
    {
        public void Configure(EntityTypeBuilder<Quartos> builder)
        {
            builder.ToTable("Quartos", "Hotel")
                   .HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .ValueGeneratedOnAdd();
        }
    }
}
