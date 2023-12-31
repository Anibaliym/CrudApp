using Persona.Domain.Core.Messaging;
using Persona.Domain.Commands.Persona.Validations;
using Persona.Domain.Commands.Contacto.Validations;

namespace Persona.Domain.Commands.Contacto.Commands
{
    public class ContactoEliminarCommand : ContactoCommand
    {
        public ContactoEliminarCommand(Guid id) {
            Id = id;
        }

        public override bool IsValid()
        {
            CommandResponse.ValidationResult = new ContactoEliminarCommandValidations().Validate(this);
            return CommandResponse.ValidationResult.IsValid;
        }
    }
}
