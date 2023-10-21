using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("insumoprenda");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasMaxLength(30);
            
            builder.HasOne(p => p.Insumo)
            .WithMany(p => p.InsumoPrendas)
            .HasForeignKey(p => p.InsumoIdFk);

            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.InsumoPrendas)
            .HasForeignKey(p => p.PrendaIdFk);

        }
    }
}