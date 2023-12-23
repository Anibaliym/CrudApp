using FluentValidation;

namespace Persona.Domain.Commands.Persona
{
    public abstract class PersonaValidation<T> : AbstractValidator<T> where T : PersonaCommand
    {
        protected void ValidaRut()
        {
            RuleFor(c => c.Rut).NotEmpty().WithMessage("El campo 'Rut' no puede ser vacío.");
        }
    }
}
