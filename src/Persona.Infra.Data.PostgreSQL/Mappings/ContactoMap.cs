using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persona.Domain.Entities;

namespace Persona.Infra.Data.PostgreSQL.Mappings
{
    public class ContactoMap : IEntityTypeConfiguration<Contacto>
    {
        public void Configure(EntityTypeBuilder<Contacto> builder) {
            builder.Property(c => c.Id).HasColumnName("Id").HasColumnType("UUID").IsRequired();
            builder.Property(c => c.IdPersona).HasColumnName("IdPersona").HasColumnType("UUID").IsRequired();
            builder.Property(c => c.Celular).HasColumnName("Celular").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            builder.Property(c => c.Correo).HasColumnName("Correo").HasColumnType("varchar").HasMaxLength(200).IsRequired();
            builder.Property(c => c.Direccion).HasColumnName("Direccion").HasColumnType("varchar").HasMaxLength(100).IsRequired();
        }
    }
}
