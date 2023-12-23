using Persona.Domain.Core.Messaging;

namespace Persona.Domain.Core.Events
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
