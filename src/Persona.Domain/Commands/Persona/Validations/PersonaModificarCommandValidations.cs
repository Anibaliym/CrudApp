using Persona.Domain.Commands.Persona.Commands;

namespace Persona.Domain.Commands.Persona.Validations
{
    public class PersonaModificarCommandValidations : PersonaValidation<PersonaModificarCommand>
    {
        public PersonaModificarCommandValidations()
        {
            ValidaId();
            ValidaNombre();
            ValidaApellidoPaterno();
            ValidaApellidoMaterno();
            ValidaFechaNacimiento();
            ValidaSexo();
        }
    }
}
