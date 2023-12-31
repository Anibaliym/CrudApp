using Persona.Domain.Commands.Contacto.Commands;

namespace Persona.Domain.Commands.Contacto.Validations
{
    public class ContactoModificarCommandValidations : ContactoValidation<ContactoModificarCommand>
    {
        public ContactoModificarCommandValidations()
        {
            ValidaId(); 
            ValidaIdPersona();
            ValidaCelular();
            ValidaCorreo();
            ValidaDireccion();
            ValidaTipoDireccion();
        }
    }
}
