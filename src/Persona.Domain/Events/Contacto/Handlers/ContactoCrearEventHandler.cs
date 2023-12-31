using MediatR;
using Persona.Domain.Events.Contacto.Events;

namespace Persona.Domain.Events.Contacto.Handlers
{
    public partial class ContactoCrearEventHandler : INotificationHandler<ContactoCrearEvent>
    {
        public Task Handle(ContactoCrearEvent notification, CancellationToken cancellationToken)
        {
            // Send some notification e-mail
            return Task.CompletedTask;
        }
    }
}
