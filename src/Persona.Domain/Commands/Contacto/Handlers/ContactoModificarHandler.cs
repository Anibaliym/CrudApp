using MediatR;
using Persona.Domain.Commands.Contacto.Commands;
using Persona.Domain.Core.Messaging;
using Persona.Domain.Events.Contacto.Events;

namespace Persona.Domain.Commands.Contacto.Handlers
{
    public partial class ContactoCommandHandler : IRequestHandler<ContactoModificarCommand, CommandResponse>
    {
        public async Task<CommandResponse> Handle(ContactoModificarCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.CommandResponse;

            var contacto = new Entities.Contacto(message.Id, message.IdPersona, message.Celular, message.Correo, message.Direccion, message.TipoDireccion);

            var existeContacto = await _contactoRepository.BuscaPorId(message.Id);

            if (existeContacto == null)
            {
                AddError($"No existe el contacto con el id '{ message.Id }'.");
                return CommandResponse;
            }

            contacto.AddDomainEvent(new ContactoModificarEvent(
                contacto.Id,
                contacto.IdPersona,
                contacto.Celular,
                contacto.Correo,
                contacto.Direccion, 
                contacto.TipoDireccion
            ));

            _contactoRepository.Modificar(contacto);

            CommandResponse.Data = contacto;
            CommandResponse.Result = true;

            return await Commit(_contactoRepository.UnitOfWork);
        }
    }
}
