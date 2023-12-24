using Persona.Domain.Core.Messaging;

namespace Persona.Domain.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T @event) where T : Event;
        Task<CommandResponse> SendCommand<T>(T command) where T : Command;
    }
}
