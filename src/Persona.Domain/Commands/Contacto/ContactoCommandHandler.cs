using Persona.Domain.Core.Messaging;
using Persona.Domain.Interfaces;

namespace Persona.Domain.Commands.Contacto.Handlers
{
    public partial class ContactoCommandHandler : CommandHandler
    {
        private readonly IContactoRepository _contactoRepository;

        public ContactoCommandHandler(IContactoRepository accionRepository) {
            _contactoRepository = accionRepository ?? throw new ArgumentNullException(nameof(accionRepository));
        }
    }
}
