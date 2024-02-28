using HotelProject.Domain.Entities.Hotel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;

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

            builder.HasOne(x => x.Aluguel).WithMany().HasForeignKey(x => x.IdAluguel);
        }
    }
}
