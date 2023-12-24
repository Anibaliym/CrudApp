using AutoMapper;
using Persona.Application.ViewModels.Persona;

namespace Persona.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() { 
            CreateMap<Domain.Entities.Persona, PersonaViewModel>();
        }
    }
}
