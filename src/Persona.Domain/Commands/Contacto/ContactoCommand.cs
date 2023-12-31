using Persona.Domain.Core.Messaging;

namespace Persona.Domain.Commands.Contacto
{
    public abstract class ContactoCommand : Command
    {
        public Guid Id { get; set; }
        public Guid IdPersona { get; set; }
        public string Celular { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string TipoDireccion { get; set; } = string.Empty;
    }
}
