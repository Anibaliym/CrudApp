using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persona.Infra.Data.PostgreSQL.Mappings
{
    public class PersonaMap : IEntityTypeConfiguration<Domain.Entities.Persona>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Persona> builder)
        { 
            builder.Property(c => c.Id).HasColumnName("Id").HasColumnType("UUID").IsRequired();
            builder.Property(c => c.Rut).HasColumnName("Rut").HasColumnType("varchar").HasMaxLength(8).IsRequired();
            builder.Property(c => c.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(200).IsRequired();
            builder.Property(c => c.ApellidoPaterno).HasColumnName("ApellidoPaterno").HasColumnType("varchar").HasMaxLength(200).IsRequired();
            builder.Property(c => c.ApellidoMaterno).HasColumnName("ApellidoMaterno").HasColumnType("varchar").HasMaxLength(200).IsRequired();
            builder.Property(c => c.FechaNacimiento).HasColumnName("FechaNacimiento").HasColumnType("timestamp");
            builder.Property(c => c.Sexo).HasColumnName("Sexo").HasColumnType("varchar").HasMaxLength(20).IsRequired();
        }
    }
}
