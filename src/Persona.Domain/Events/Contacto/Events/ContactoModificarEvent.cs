using Persona.Domain.Core.Messaging;

namespace Persona.Domain.Events.Contacto.Events
{
    public class ContactoModificarEvent : Event
    {
        public ContactoModificarEvent(Guid id, Guid idPersona, string celular, string correo, string direccion)
        {
            Id = id;
            IdPersona = idPersona;
            Celular = celular;
            Correo = correo;
            Direccion = direccion;

            AggregateId = id;
        }

        public Guid Id { get; set; }
        public Guid IdPersona { get; set; }
        public string Celular { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
    }
}
