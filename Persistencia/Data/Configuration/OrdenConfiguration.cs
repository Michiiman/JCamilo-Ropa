using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("orden");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Fecha)
            .HasColumnType("date")
            .IsRequired()
            .HasMaxLength(30);

            builder.HasOne(p => p.Empleado)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.EmpleadoIdFk);

            builder.HasOne(p => p.Cliente)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.ClienteIdFk);

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Ordenes)
            .HasForeignKey(p => p.EstadoIdFk);
        }
    }
}