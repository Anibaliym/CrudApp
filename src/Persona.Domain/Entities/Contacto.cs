using Persona.Domain.Core.Dominio;

namespace Persona.Domain.Entities
{
    public class Contacto : Entity, IAggregateRoot
    { 
        public Contacto(Guid id, Guid idPersona, string celular, string correo, string direccion, string tipoDireccion) {
            Id = id;
            IdPersona = idPersona;
            Celular = celular;
            Correo = correo;
            Direccion = direccion;
            TipoDireccion = tipoDireccion;
        }

        protected Contacto() { }

        public Guid IdPersona { get; set; }
        public string Celular { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string TipoDireccion { get; set; } = string.Empty;
    }
}
