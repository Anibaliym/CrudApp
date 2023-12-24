using MediatR;
using Persona.Domain.Commands.Persona.Commands;
using Persona.Domain.Core.Messaging;
using Persona.Domain.Events.Persona.Events;

namespace Persona.Domain.Commands.Persona.Handlers
{
    public partial class PersonaCommandHandler : IRequestHandler<PersonaCrearCommand, CommandResponse>
    {
        public async Task<CommandResponse> Handle(PersonaCrearCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.CommandResponse;

            var persona = new Entities.Persona(Guid.NewGuid(),message.Rut, message.Nombre,message.ApellidoPaterno, message.ApellidoMaterno, message.FechaNacimiento, message.Sexo);
            var existePersonaPorRut = await _personaRepository.BuscaPorRut(message.Rut);

            if (existePersonaPorRut != null) {
                AddError($"La persona con el campo 'RUT' ({ message.Rut }), ya existe.");
                return CommandResponse;
            }

            persona.AddDomainEvent(new PersonaCrearEvent(
                persona.Id, 
                persona.Rut, 
                persona.Nombre, 
                persona.ApellidoPaterno, 
                persona.ApellidoMaterno, 
                persona.FechaNacimiento, 
                persona.Sexo
            ));

            _personaRepository.Crear(persona);

            CommandResponse.Data = persona;
            CommandResponse.Result = true;

            return await Commit(_personaRepository.UnitOfWork);
        }
    }
}
