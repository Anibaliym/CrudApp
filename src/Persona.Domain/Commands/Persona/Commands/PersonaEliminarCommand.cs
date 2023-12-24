using Persona.Domain.Commands.Persona.Validations;

namespace Persona.Domain.Commands.Persona.Commands
{
    public class PersonaEliminarCommand : PersonaCommand
    {
        public PersonaEliminarCommand(Guid id) { 
            Id = id;
        }

        public override bool IsValid()
        {
            CommandResponse.ValidationResult = new PersonaEliminarCommandValidations().Validate(this);
            return CommandResponse.ValidationResult.IsValid;
        }

    }
}
