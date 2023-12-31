using Persona.Domain.Core.Messaging;

namespace Persona.Domain.Events.Contacto.Events
{
    public class ContactoEliminarEvent : Event
    {
        public ContactoEliminarEvent(Guid id)
        {
            Id = id;

            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
