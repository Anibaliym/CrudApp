using Persona.Domain.Commands.Persona.Validations;
using Persona.Domain.Core.Messaging;

namespace Persona.Domain.Commands.Persona.Commands
{
    public class PersonaCrearCommand : PersonaCommand
    {
        public PersonaCrearCommand(string rut, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string sexo) {
            Rut = rut;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
        }

        public override bool IsValid()
        {
            CommandResponse.ValidationResult = new PersonaCrearCommandValidations().Validate(this);
            return CommandResponse.ValidationResult.IsValid;
        }
    }
}
