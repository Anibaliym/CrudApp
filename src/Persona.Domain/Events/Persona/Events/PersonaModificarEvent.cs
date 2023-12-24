using Persona.Domain.Core.Messaging;

namespace Persona.Domain.Events.Persona.Events
{
    public class PersonaModificarEvent : Event
    {
        public PersonaModificarEvent(Guid id, string rut, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string sexo)
        {
            Id = id;
            Rut = rut;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;

            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string Rut { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string ApellidoMaterno { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; } = string.Empty;
    }
}

