using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("cliente");

            builder.HasAlternateKey(e=>e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.FechaRegistro)
            .HasColumnType("date")
            .HasMaxLength(30);

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.TipoPersonaIdFk);

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.MunicipioIdFk);

        }
    }
}