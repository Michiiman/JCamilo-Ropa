using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("insumo");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(40);

            builder.Property(p => p.ValorUnitario)
            .HasColumnType("int")
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.StockMin)
            .HasColumnType("int")
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.StockMax)
            .HasColumnType("int")
            .IsRequired()
            .HasMaxLength(30);

            builder
            .HasMany(p=>p.Proveedores)
            .WithMany(p=>p.Insumos)
            .UsingEntity<InsumoProveedor>(
            j=>j
            .HasOne(pt=>pt.Proveedor)
            .WithMany(t=>t.InsumoProveedores)
            .HasForeignKey(pt=>pt.ProveedorIdFk),
            j => j
            .HasOne(pt => pt.Insumo)
            .WithMany(t => t.InsumoProveedores)
            .HasForeignKey(pt => pt.InsumoIdFk),
            j =>
            {
            j.ToTable("insumoProveedor");
            j.HasKey(t => new { t.InsumoIdFk, t.ProveedorIdFk});
            });

        }
    }
}