using FluentValidation;

namespace Persona.Domain.Commands.Contacto
{
    public abstract class ContactoValidation<T> : AbstractValidator<T> where T : ContactoCommand
    {
        protected void ValidaId()
        {
            RuleFor(contacto => contacto.Id)
                .NotEqual(Guid.Empty).WithMessage("El campo 'Id' es invalido")
                .NotEmpty().WithMessage("El campo 'Id' no puede ser vacío.");
        }

        protected void ValidaIdPersona()
        {
            RuleFor(contacto => contacto.IdPersona)
                .NotEqual(Guid.Empty).WithMessage("El campo 'IdPersona' es invalido")
                .NotEmpty().WithMessage("El campo 'IdPersona' no puede ser vacío.");
        }

        protected void ValidaCelular()
        {
            RuleFor(contacto => contacto.Celular).NotEmpty().WithMessage("El campo 'Celular' no puede ser vacío.");
        }

        protected void ValidaCorreo()
        {
            RuleFor(contacto => contacto.Correo).NotEmpty().WithMessage("El campo 'Correo' no puede ser vacío.");
        }
        protected void ValidaDireccion()
        {
            RuleFor(contacto => contacto.Direccion).NotEmpty().WithMessage("El campo 'Direccion' no puede ser vacío.");
        }
    }
}
