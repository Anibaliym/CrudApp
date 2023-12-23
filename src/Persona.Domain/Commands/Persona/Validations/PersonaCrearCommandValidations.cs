using Persona.Domain.Commands.Persona.Commands;

namespace Persona.Domain.Commands.Persona.Validations
{
    public class PersonaCrearCommandValidations : PersonaValidation<PersonaCrearCommand>
    {
        public PersonaCrearCommandValidations() {
            ValidaRut();
        }
    }
}
