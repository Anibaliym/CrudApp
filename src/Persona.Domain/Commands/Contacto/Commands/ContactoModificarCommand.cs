using Persona.Domain.Commands.Contacto.Validations;

namespace Persona.Domain.Commands.Contacto.Commands
{
    public class ContactoModificarCommand : ContactoCommand
    {
        public ContactoModificarCommand(Guid id, Guid idPersona, string celular, string correo, string direccion, string tipoDireccion)
        {
            IdPersona = id;
            IdPersona = idPersona;
            Celular = celular;
            Correo = correo;
            Direccion = direccion;
            TipoDireccion = tipoDireccion;
        }

        public override bool IsValid()
        {
            CommandResponse.ValidationResult = new ContactoModificarCommandValidations().Validate(this);
            return CommandResponse.ValidationResult.IsValid;
        }
    }
}
