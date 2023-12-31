using AutoMapper;
using Persona.Application.ViewModels.Contacto;
using Persona.Application.ViewModels.Persona;
using Persona.Domain.Entities;

namespace Persona.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() { 
            CreateMap<Domain.Entities.Persona, PersonaViewModel>();
            CreateMap<Contacto, ContactoViewModel>();
        }
    }
}
