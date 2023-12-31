using Persona.Domain.Commands.Contacto.Commands;

namespace Persona.Domain.Commands.Contacto.Validations
{
    public class ContactoCrearCommandValidations : ContactoValidation<ContactoCrearCommand>
    {
        public ContactoCrearCommandValidations() {
            ValidaIdPersona(); 
            ValidaCelular();
            ValidaCorreo();
            ValidaDireccion();
            ValidaTipoDireccion();
        }
    }
}
