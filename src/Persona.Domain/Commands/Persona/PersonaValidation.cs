using FluentValidation;
using Persona.Domain.Commands.CommonValidators.Validators;
using Persona.Domain.Enumerations.Persona;

namespace Persona.Domain.Commands.Persona
{
    public abstract class PersonaValidation<T> : AbstractValidator<T> where T : PersonaCommand
    {
        protected void ValidaId() { 
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty).WithMessage("El campo 'Id' es invalido")
                .NotEmpty().WithMessage("El campo 'Id' no puede ser vacío.");
        }

        protected void ValidaRut()
        {
            RuleFor(c => c.Rut).NotEmpty().WithMessage("El campo 'Rut' no puede ser vacío.");
        }

        protected void ValidaNombre()
        {
            RuleFor(c => c.Nombre).NotEmpty().WithMessage("El campo 'Nombre' no puede ser vacío.");
        }

        protected void ValidaApellidoPaterno()
        {
            RuleFor(c => c.ApellidoPaterno).NotEmpty().WithMessage("El campo 'ApellidoPaterno' no puede ser vacío.");
        }

        protected void ValidaApellidoMaterno()
        {
            RuleFor(c => c.ApellidoMaterno).NotEmpty().WithMessage("El campo 'ApellidoMaterno' no puede ser vacío.");
        }

        protected void ValidaFechaNacimiento()
        {
            RuleFor(c => c.FechaNacimiento).NotEmpty().WithMessage("El campo 'FechaNacimiento' no puede ser vacío.");
        }

        protected void ValidaSexo()
        {
            RuleFor(c => c.Sexo).NotEmpty().WithMessage("El campo 'Sexo' no puede ser vacío.");

            RuleFor(c => c.Sexo)
                .NotEmpty().WithMessage("Por favor asegurese que el 'Sexo' no este vacio")
                .Must(CommonValidator.ValidadorDeEnumeraciones<SexoEnum>).WithMessage("El 'Sexo' debe estar entre los valores permitidos ('MASCULINO','FEMENINO').");
        }
    }
}
