using Persona.Domain.Core.Data;
using System;

namespace Persona.Domain.Interfaces
{
    public interface IPersonaRepository : IRepository<Entities.Persona>
    {
        void Crear(Entities.Persona modelo);
        void Modificar(Entities.Persona modelo);
        void Eliminar(Entities.Persona modelo);

        Task<Entities.Persona> BuscaPorId(Guid id);
        Task<Entities.Persona> BuscaPorRut(string rut);
        Task<IEnumerable<Entities.Persona>> BuscaPorNombreCoincidencias(string nombre);
        Task<IEnumerable<Entities.Persona>> BuscaPorApellidoPaternoCoincidencias(string apellidoPaterno);
        Task<IEnumerable<Entities.Persona>> BuscaPorApellidoMaternoCoincidencias(string apellidoMaterno);
    }
}
