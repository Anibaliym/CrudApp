using Persona.Domain.Core.Models;

namespace Persona.Application.EventSourcedNormalizers.Contacto
{
    public class ContactoHistoryData : HistoryData
    {
        public string Id { get; set; } = string.Empty;
        public string IdPersona { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string TipoDireccion { get; set; } = string.Empty;
    }
}
