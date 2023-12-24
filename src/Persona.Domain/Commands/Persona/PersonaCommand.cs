using Persona.Domain.Core.Messaging;

namespace Persona.Domain.Commands.Persona
{
    public abstract class PersonaCommand : Command
    {
        public Guid Id { get; set; }
        public string Rut { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string ApellidoMaterno { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; } = string.Empty;
    }
}
