using MediatR;
using Persona.Domain.Events.Persona.Events;

namespace Persona.Domain.Events.Persona.Handlers
{
    public partial class PersonaCrearEventHandler : INotificationHandler<PersonaCrearEvent>
    {
        public Task Handle(PersonaCrearEvent notification, CancellationToken cancellationToken)
        {
            // Send some notification e-mail
            return Task.CompletedTask;
        }
    }
}
