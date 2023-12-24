using Persona.Domain.Core.Messaging;
using Persona.Domain.Interfaces;

namespace Persona.Domain.Commands.Persona.Handlers
{
    public partial class PersonaCommandHandler : CommandHandler
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaCommandHandler(IPersonaRepository accionRepository){
            _personaRepository = accionRepository ?? throw new ArgumentNullException(nameof(accionRepository));
        }
    }
}
