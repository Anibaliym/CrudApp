using MediatR;
using Persona.Domain.Events.Persona.Events;

namespace Persona.Domain.Events.Persona.Handlers
{
    public partial class PersonaModificarEventHandler : INotificationHandler<PersonaModificarEvent>
    {
        public Task Handle(PersonaModificarEvent notification, CancellationToken cancellationToken)
        {
            // Send some notification e-mail
            return Task.CompletedTask;
        }
    }
}
