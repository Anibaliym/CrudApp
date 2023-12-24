using Ardalis.SmartEnum;

namespace Persona.Domain.Enumerations.Persona
{
    public sealed class SexoEnum : SmartEnum<SexoEnum>
    {
        public static readonly SexoEnum MASCULINO = new("MASCULINO", 1);
        public static readonly SexoEnum FEMENINO = new("FEMENINO", 2);

        private SexoEnum(string name, int value) : base(name, value) { }
    }
}
