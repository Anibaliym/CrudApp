using Persona.Domain.Core.Messaging;

namespace Persona.Domain.Events.Persona.Events
{

    public class PersonaEliminarEvent : Event
    {
        public PersonaEliminarEvent(Guid id)
        {
            Id = id;

            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
