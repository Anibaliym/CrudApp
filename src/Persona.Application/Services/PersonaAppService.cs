﻿using AutoMapper;
using Persona.Application.EventSourcedNormalizers.Persona;
using Persona.Application.Interfaces;
using Persona.Application.ViewModels.Persona;
using Persona.Domain.Commands.Persona.Commands;
using Persona.Domain.Core.Mediator;
using Persona.Domain.Core.Messaging;
using Persona.Domain.Interfaces;
using Persona.Infra.Data.PostgreSQL.Repository.EventSourcing;

namespace Persona.Application.Services
{
    public class PersonaAppService : IPersonaAppService
    {
        private readonly IMapper _mapper;
        private readonly IPersonaRepository _personaRepository;
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IMediatorHandler _mediator;

        public PersonaAppService(IMapper mapper, IPersonaRepository personaRepository, IEventStoreRepository eventStoreRepository, IMediatorHandler mediator)
        {
            _mapper = mapper;
            _personaRepository = personaRepository;
            _eventStoreRepository = eventStoreRepository;
            _mediator = mediator;
        }

        public async Task<CommandResponse> Crear(PersonaCrearViewModel modelo)
        {
            var createCommand = _mapper.Map<PersonaCrearCommand>(modelo);
            return await _mediator.SendCommand(createCommand);
        }

        public async Task<CommandResponse> Modificar(PersonaModificarViewModel modelo)
        {
            var updateCommand = _mapper.Map<PersonaModificarCommand>(modelo);
            return await _mediator.SendCommand(updateCommand);
        }

        public async Task<CommandResponse> Eliminar(Guid id)
        {
            var deleteCommand = new PersonaEliminarCommand(id);
            return await _mediator.SendCommand(deleteCommand);
        }

        public async Task<IList<PersonaHistoryData>> GetAllHistory(Guid id)
        {
            return PersonaHistory.ToJavaScriptCustomerHistory(await _eventStoreRepository.All(id));
        }

        public async Task<PersonaViewModel> BuscaPorId(Guid id)
        {
            return _mapper.Map<PersonaViewModel>(await _personaRepository.BuscaPorId(id));
        }

        public async Task<PersonaViewModel> BuscaPorRut(string rut)
        {
            return _mapper.Map<PersonaViewModel>(await _personaRepository.BuscaPorRut(rut));
        }

        public async Task<IList<PersonaViewModel>> BuscaPorNombreCoincidencias(string nombre)
        {
            return _mapper.Map<IList<PersonaViewModel>>(await _personaRepository.BuscaPorNombreCoincidencias(nombre));
        }

        public async Task<IList<PersonaViewModel>> BuscaPorApellidoPaternoCoincidencias(string apellidoPaterno)
        {
            return _mapper.Map<IList<PersonaViewModel>>(await _personaRepository.BuscaPorApellidoPaternoCoincidencias(apellidoPaterno));
        }

        public async Task<IList<PersonaViewModel>> BuscaPorApellidoMaternoCoincidencias(string apellidoMaterno)
        {
            return _mapper.Map<IList<PersonaViewModel>>(await _personaRepository.BuscaPorApellidoMaternoCoincidencias(apellidoMaterno));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
