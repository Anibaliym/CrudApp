using MediatR;
using Persona.Domain.Events.Contacto.Events;

namespace Persona.Domain.Events.Contacto.Handlers
{
    public partial class ContactoEliminarEventHandler : INotificationHandler<ContactoEliminarEvent>
    {
        public Task Handle(ContactoEliminarEvent notification, CancellationToken cancellationToken)
        {
            // Send some notification e-mail
            return Task.CompletedTask;
        }
    }
}
