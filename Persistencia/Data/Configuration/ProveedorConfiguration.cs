using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("proveedor");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasAlternateKey(p=>p.NitProveedor);
            builder.Property(p => p.NitProveedor)
            .IsRequired()
            .HasMaxLength(30);

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.TipoPersonaIdFk);

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.MunicipioIdFk);
        }
    }
}