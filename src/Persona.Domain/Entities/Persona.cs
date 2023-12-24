using Persona.Domain.Core.Dominio;

namespace Persona.Domain.Entities
{
    public class Persona : Entity, IAggregateRoot
    {
        public Persona(Guid id, string rut, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string sexo) {
            Id = id;
            Rut = rut;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
        }

        protected Persona() { }

        public string Rut { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string ApellidoMaterno { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; } = string.Empty;
    }
}
