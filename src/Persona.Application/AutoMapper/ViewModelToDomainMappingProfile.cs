using AutoMapper;
using Persona.Application.ViewModels.Contacto;
using Persona.Application.ViewModels.Persona;
using Persona.Domain.Commands.Contacto.Commands;
using Persona.Domain.Commands.Persona.Commands;

namespace Persona.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {

            #region Persona
            CreateMap<PersonaCrearViewModel, PersonaCrearCommand>().ConstructUsing(persona => new PersonaCrearCommand(
                persona.Rut, 
                persona.Nombre, 
                persona.ApellidoPaterno, 
                persona.ApellidoMaterno, 
                persona.FechaNacimiento, 
                persona.Sexo
            ));

            CreateMap<PersonaModificarViewModel, PersonaModificarCommand>().ConstructUsing(persona => new PersonaModificarCommand(
                persona.Id, 
                persona.Nombre, 
                persona.ApellidoPaterno, 
                persona.ApellidoMaterno, 
                persona.FechaNacimiento, 
                persona.Sexo
            ));
            #endregion

            #region Contacto
            CreateMap<ContactoCrearViewModel, ContactoCrearCommand>().ConstructUsing(contacto => new ContactoCrearCommand(
                contacto.IdPersona, 
                contacto.Celular, 
                contacto.Correo, 
                contacto.Direccion
            ));

            CreateMap<ContactoModificarViewModel, ContactoModificarCommand>().ConstructUsing(contacto => new ContactoModificarCommand(contacto.Id, contacto.IdPersona, contacto.Celular, contacto.Correo, contacto.Direccion));
            #endregion
        }
    }
}
