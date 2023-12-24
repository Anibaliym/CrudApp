﻿using Ardalis.SmartEnum;

namespace Persona.Domain.Commands.CommonValidators.Validators
{
    public static partial class CommonValidator
    {
        public static bool ValidadorDeEnumeraciones<T>(string nombreEnumeracion) where T : SmartEnum<T>
        {
            var result = SmartEnum<T>.TryFromName(nombreEnumeracion, out _);
            return result;
        }
    }
}
