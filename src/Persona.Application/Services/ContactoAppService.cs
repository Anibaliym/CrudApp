using AutoMapper;
using Persona.Application.EventSourcedNormalizers.Contacto;
using Persona.Application.Interfaces;
using Persona.Application.ViewModels.Contacto;
using Persona.Domain.Commands.Contacto.Commands;
using Persona.Domain.Core.Mediator;
using Persona.Domain.Core.Messaging;
using Persona.Domain.Interfaces;
using Persona.Infra.Data.PostgreSQL.Repository.EventSourcing;

namespace Persona.Application.Services
{
    public class ContactoAppService : IContactoAppService
    {
        private readonly IMapper _mapper;
        private readonly IContactoRepository _contactoRepository;
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IMediatorHandler _mediator;

        public ContactoAppService(IMapper mapper, IContactoRepository contactoRepository, IEventStoreRepository eventStoreRepository, IMediatorHandler mediator)
        {
            _mapper = mapper;
            _contactoRepository = contactoRepository;
            _eventStoreRepository = eventStoreRepository;
            _mediator = mediator;
        }

        public async Task<ContactoViewModel> BuscaPorId(Guid id)
        {
            return _mapper.Map<ContactoViewModel>(await _contactoRepository.BuscaPorId(id));
        }

        public async Task<ContactoViewModel> BuscaPorIdPersona(Guid idPersona)
        {
            return _mapper.Map<ContactoViewModel>(await _contactoRepository.BuscaPorIdPersona(idPersona));
        }

        public async Task<CommandResponse> Crear(ContactoCrearViewModel modelo)
        {
            var createCommand = _mapper.Map<ContactoCrearCommand>(modelo);
            return await _mediator.SendCommand(createCommand);
        }


        public async Task<CommandResponse> Eliminar(Guid id)
        {
            var deleteCommand = new ContactoEliminarCommand(id);
            return await _mediator.SendCommand(deleteCommand);
        }

        public async Task<CommandResponse> Modificar(ContactoModificarViewModel modelo)
        {
            var updateCommand = _mapper.Map<ContactoModificarCommand>(modelo);
            return await _mediator.SendCommand(updateCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<IList<ContactoHistoryData>> GetAllHistory(Guid id)
        {
            return ContactoHistory.ToJavaScriptCustomerHistory(await _eventStoreRepository.All(id));
        }
    }
}
