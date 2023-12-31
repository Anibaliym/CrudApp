using FluentValidation;
using Persona.Domain.Commands.CommonValidators.Validators;
using Persona.Domain.Enumerations.Persona;

namespace Persona.Domain.Commands.Persona
{
    public abstract class PersonaValidation<T> : AbstractValidator<T> where T : PersonaCommand
    {
        protected void ValidaId() { 
            RuleFor(persona => persona.Id)
                .NotEqual(Guid.Empty).WithMessage("El campo 'Id' es invalido")
                .NotEmpty().WithMessage("El campo 'Id' no puede ser vacío.");
        }

        protected void ValidaRut()
        {
            RuleFor(persona => persona.Rut).NotEmpty().WithMessage("El campo 'Rut' no puede ser vacío.");
        }

        protected void ValidaNombre()
        {
            RuleFor(persona => persona.Nombre).NotEmpty().WithMessage("El campo 'Nombre' no puede ser vacío.");
        }

        protected void ValidaApellidoPaterno()
        {
            RuleFor(persona => persona.ApellidoPaterno).NotEmpty().WithMessage("El campo 'ApellidoPaterno' no puede ser vacío.");
        }

        protected void ValidaApellidoMaterno()
        {
            RuleFor(persona => persona.ApellidoMaterno).NotEmpty().WithMessage("El campo 'ApellidoMaterno' no puede ser vacío.");
        }

        protected void ValidaFechaNacimiento()
        {
            RuleFor(persona => persona.FechaNacimiento).NotEmpty().WithMessage("El campo 'FechaNacimiento' no puede ser vacío.");
        }

        protected void ValidaSexo()
        {
            RuleFor(persona => persona.Sexo)
                .NotEmpty().WithMessage("Por favor asegurese que el 'Sexo' no este vacio")
                .Must(CommonValidator.ValidadorDeEnumeraciones<SexoEnum>).WithMessage("El 'Sexo' debe estar entre los valores permitidos ('MASCULINO','FEMENINO').");
        }
    }
}
