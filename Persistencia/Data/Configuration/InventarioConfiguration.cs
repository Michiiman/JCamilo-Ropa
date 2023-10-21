using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("inventario");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.CodInventario)
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.ValorVtaCop)
            .HasColumnType("int")
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.ValorVtaUsd)
            .HasColumnType("int")
            .IsRequired()
            .HasMaxLength(30);

            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.Inventarios)
            .HasForeignKey(p => p.PrendaIdFk);

        
        }
    }
}