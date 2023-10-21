using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("inventarioTalla");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasMaxLength(30);

            builder.HasOne(p => p.Inventario)
            .WithMany(p => p.InventarioTallas)
            .HasForeignKey(p => p.InventarioIdFk);

            builder.HasOne(p => p.Talla)
            .WithMany(p => p.InventarioTallas)
            .HasForeignKey(p => p.TallaIdFk);

        }
    }
}