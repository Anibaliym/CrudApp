using Persona.Domain.Commands.Persona.Commands;

namespace Persona.Domain.Commands.Persona.Validations
{
    public class PersonaEliminarCommandValidations : PersonaValidation<PersonaEliminarCommand>
    {
        public PersonaEliminarCommandValidations() {
            ValidaId();
        }
    }
}
