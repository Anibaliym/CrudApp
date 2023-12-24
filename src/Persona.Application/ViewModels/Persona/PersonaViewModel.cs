using System.ComponentModel;

namespace Persona.Application.ViewModels.Persona
{
    public class PersonaViewModel
    {
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [DisplayName("Rut")]
        public string Rut { get; set; } = string.Empty;

        [DisplayName("Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [DisplayName("Apellido Paterno")]
        public string ApellidoPaterno { get; set; } = string.Empty;

        [DisplayName("Apellido Materno")]
        public string ApellidoMaterno { get; set; } = string.Empty;

        [DisplayName("Fecha De Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Sexo")]
        public string Sexo { get; set; } = string.Empty;
    }
}
