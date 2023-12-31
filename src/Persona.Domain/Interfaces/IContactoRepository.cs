using Persona.Domain.Core.Data;
using Persona.Domain.Entities;

namespace Persona.Domain.Interfaces
{
    public interface IContactoRepository : IRepository<Contacto>
    {
        void Crear(Contacto modelo);
        void Modificar(Contacto modelo);
        void Eliminar(Contacto modelo);
        Task<Contacto> BuscaPorId(Guid id);
        Task<Contacto> BuscaPorIdPersona(Guid idPersona);
    }
}
