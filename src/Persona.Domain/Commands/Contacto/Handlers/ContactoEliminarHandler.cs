using MediatR;
using Persona.Domain.Commands.Contacto.Commands;
using Persona.Domain.Core.Messaging;
using Persona.Domain.Events.Contacto.Events;
using Persona.Domain.Events.Persona.Events;

namespace Persona.Domain.Commands.Contacto.Handlers
{
    public partial class ContactoCommandHandler : IRequestHandler<ContactoEliminarCommand, CommandResponse>
    {
        public async Task<CommandResponse> Handle(ContactoEliminarCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.CommandResponse;

            var existeContacto = await _contactoRepository .BuscaPorId(message.Id);

            if (existeContacto == null)
            {
                AddError($"No existe el contacto con el id '{message.Id}'.");
                return CommandResponse;
            }

            existeContacto.AddDomainEvent(new ContactoEliminarEvent(existeContacto.Id));

            _contactoRepository.Eliminar(existeContacto);

            CommandResponse.Data = null;
            CommandResponse.Result = true;

            return await Commit(_contactoRepository.UnitOfWork);
        }
    }
}
