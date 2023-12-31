using System.ComponentModel;

namespace Persona.Application.ViewModels.Contacto
{
    public class ContactoModificarViewModel
    {
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [DisplayName("Identificador de la persona")]
        public Guid IdPersona { get; set; }

        [DisplayName("Celular de contacto")]
        public string Celular { get; set; } = string.Empty;

        [DisplayName("Correo de contacto")]
        public string Correo { get; set; } = string.Empty;

        [DisplayName("Direccion personal")]
        public string Direccion { get; set; } = string.Empty;

        [DisplayName("Tipo de dirección")]
        public string TipoDireccion { get; set; } = string.Empty;
    }
}
