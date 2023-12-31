using MediatR;
using Persona.Domain.Commands.Contacto.Commands;
using Persona.Domain.Core.Messaging;
using Persona.Domain.Events.Contacto.Events;

namespace Persona.Domain.Commands.Contacto.Handlers
{
    public partial class ContactoCommandHandler : IRequestHandler<ContactoCrearCommand, CommandResponse>
    {
        public async Task<CommandResponse> Handle(ContactoCrearCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.CommandResponse;

            var contacto = new Entities.Contacto(Guid.NewGuid(), message.IdPersona, message.Celular, message.Correo, message.Direccion);
            var existeContacto = await _contactoRepository.BuscaPorId(message.Id);

            if (existeContacto != null)
            {
                AddError($"El contacto con el campo 'ID' ({message.Id}), ya existe.");
                return CommandResponse;
            }

            contacto.AddDomainEvent(new ContactoCrearEvent(contacto.Id, contacto.IdPersona, contacto.Celular, contacto.Correo, contacto.Direccion));

            _contactoRepository.Crear(contacto);

            CommandResponse.Data = contacto;
            CommandResponse.Result = true;

            return await Commit(_contactoRepository.UnitOfWork);
        }
    }
}
