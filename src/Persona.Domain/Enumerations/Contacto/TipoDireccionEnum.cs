using Ardalis.SmartEnum;

namespace Persona.Domain.Enumerations.Contacto
{
    public sealed class TipoDireccionEnum : SmartEnum<TipoDireccionEnum>
    {
        public static readonly TipoDireccionEnum PARTICULAR = new("PARTICULAR", 1);
        public static readonly TipoDireccionEnum LABORAL = new("LABORAL", 2);

        private TipoDireccionEnum(string name, int value) : base(name, value) { }
    }
}
