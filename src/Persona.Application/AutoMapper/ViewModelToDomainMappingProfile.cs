using AutoMapper;
using Persona.Application.ViewModels.Persona;
using Persona.Domain.Commands.Persona.Commands;

namespace Persona.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PersonaCrearViewModel, PersonaCrearCommand>().ConstructUsing(persona => new PersonaCrearCommand(
                persona.Rut, 
                persona.Nombre, 
                persona.ApellidoPaterno, 
                persona.ApellidoMaterno, 
                persona.FechaNacimiento, 
                persona.Sexo
            ));
        }
    }
}
