using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("venta");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Fecha)
            .HasColumnType("date")
            .IsRequired()
            .HasMaxLength(20);

            builder.HasOne(p => p.Empleado)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.EmpleadoIdFk);

            builder.HasOne(p => p.Cliente)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.ClienteIdFk);

            builder.HasOne(p => p.FormaPago)
            .WithMany(p => p.Ventas)
            .HasForeignKey(p => p.FormaPagoIdFk);
        }
    }
}