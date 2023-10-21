using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("empresa");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Nit)
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.RazonSocial)
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.RepresentanteLegal)
            .IsRequired()
            .HasMaxLength(30);

            builder.Property(p => p.FechaCreacion)
            .HasColumnType("date")
            .IsRequired()
            .HasMaxLength(20);

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Empresas)
            .HasForeignKey(p => p.MunicipioIdFk);
            
        }
    }
}