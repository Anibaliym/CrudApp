using Persona.Application.EventSourcedNormalizers.Contacto;
using Persona.Application.ViewModels.Contacto;
using Persona.Domain.Core.Messaging;

namespace Persona.Application.Interfaces
{
    public interface IContactoAppService : IDisposable
    {
        Task<CommandResponse> Crear(ContactoCrearViewModel modelo);
        Task<CommandResponse> Modificar(ContactoModificarViewModel modelo);
        Task<CommandResponse> Eliminar(Guid id);
        Task<ContactoViewModel> BuscaPorId(Guid id);
        Task<ContactoViewModel> BuscaPorIdPersona(Guid idPersona);
        Task<IList<ContactoHistoryData>> GetAllHistory(Guid id);
    }
}
