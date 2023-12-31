using Persona.Domain.Commands.Contacto.Validations;
using Persona.Domain.Core.Messaging;

namespace Persona.Domain.Commands.Contacto.Commands
{
    public class ContactoCrearCommand : ContactoCommand
    {
        public ContactoCrearCommand(Guid idPersona, string celular, string correo, string direccion)
        {
            IdPersona = idPersona;
            Celular = celular;
            Correo = correo;
            Direccion = direccion;
        }

        public override bool IsValid()
        {
            CommandResponse.ValidationResult = new ContactoCrearCommandValidations().Validate(this);
            return CommandResponse.ValidationResult.IsValid;
        }
    }
}
