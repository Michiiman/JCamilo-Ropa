using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("prenda");

            builder.HasAlternateKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.ValorUnitCop)
            .HasColumnType("int")
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.ValorUnitUsd)
            .HasColumnType("int")
            .IsRequired()
            .HasMaxLength(30);

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.EstadoIdFk);

            builder.HasOne(p => p.TipoProteccion)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.TipoProteccionIdFk);

            builder.HasOne(p => p.Genero)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.GeneroIdFk);

            
        }
    }
}