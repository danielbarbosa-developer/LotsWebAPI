using LotsWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LotsWebAPI.Infraestructure.Configuration
{
    public class CarEntityTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            
            builder.ToTable("CAR");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID").IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Plate).HasColumnName("PLATE").IsRequired().HasMaxLength(10);
            
        }
    }
}
