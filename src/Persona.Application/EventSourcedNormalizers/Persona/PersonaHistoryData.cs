using Persona.Domain.Core.Models;

namespace Persona.Application.EventSourcedNormalizers.Persona
{
    public class PersonaHistoryData : HistoryData
    {
        public string Id { get; set; } = string.Empty;
        public string Rut { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string ApellidoMaterno { get; set; } = string.Empty;
        public string FechaNacimiento { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
    }
}
