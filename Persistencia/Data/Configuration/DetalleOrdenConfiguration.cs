using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("detalleOrden");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.CantidadProducir)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(p => p.CantidadProducida)
            .IsRequired()
            .HasMaxLength(20);

            builder.HasOne(p => p.Color)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.ColorIdFk);

            builder.HasOne(p => p.Orden)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.OrdenIdFk);

            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.PrendaIdFk);

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.EstadoIdFk);
        }
    }
}