using Persona.Domain.Commands.Persona.Validations;

namespace Persona.Domain.Commands.Persona.Commands
{
    public class PersonaModificarCommand : PersonaCommand
    {
        public PersonaModificarCommand(Guid id, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string sexo)
        {
            Id = id;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;

        }
        public override bool IsValid()
        {
            CommandResponse.ValidationResult = new PersonaModificarCommandValidations().Validate(this);
            return CommandResponse.ValidationResult.IsValid;
        }
    }
}
