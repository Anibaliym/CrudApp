using MediatR;
using Persona.Domain.Events.Contacto.Events;

namespace Persona.Domain.Events.Contacto.Handlers
{
    public partial class ContactoModificarEventHandler : INotificationHandler<ContactoModificarEvent>
    {
        public Task Handle(ContactoModificarEvent notification, CancellationToken cancellationToken)
        {
            // Send some notification e-mail
            return Task.CompletedTask;
        }
    }
}
