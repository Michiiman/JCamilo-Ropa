using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("detalleVenta");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
            
            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.ValorUnitario)
            .HasColumnType("int")
            .IsRequired()
            .HasMaxLength(30);

            builder.HasOne(p => p.Venta)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.VentaIdFk);

            builder.HasOne(p => p.Talla)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.TallaIdFk);

            builder.HasOne(p => p.Inventario)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.InventarioIdFk);

        }
    }
}