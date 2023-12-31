using Persona.Domain.Commands.Contacto.Commands;

namespace Persona.Domain.Commands.Contacto.Validations
{
    public class ContactoEliminarCommandValidations : ContactoValidation<ContactoEliminarCommand>
    {
        public ContactoEliminarCommandValidations() {
            ValidaId();
        }
    }
}
