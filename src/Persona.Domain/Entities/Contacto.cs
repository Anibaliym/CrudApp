using Persona.Domain.Core.Dominio;

namespace Persona.Domain.Entities
{
    public class Contacto : Entity, IAggregateRoot
    { 
        public Contacto(Guid id, Guid idPersona, string celular, string correo, string direccion) {
            Id = id;
            IdPersona = idPersona;
            Celular = celular;
            Correo = correo;
            Direccion = direccion;
        }

        protected Contacto() { }

        public Guid IdPersona { get; set; }
        public string Celular { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
    }
}
