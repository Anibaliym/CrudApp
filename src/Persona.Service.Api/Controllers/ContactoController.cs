using Microsoft.AspNetCore.Mvc;
using Persona.Application.EventSourcedNormalizers.Contacto;
using Persona.Application.EventSourcedNormalizers.Persona;
using Persona.Application.Interfaces;
using Persona.Application.Services;
using Persona.Application.ViewModels.Contacto;

namespace Persona.Service.Api.Controllers
{
    [Route("api/[controller]")]
    public class ContactoController : ApiController
    {
        private readonly IContactoAppService _contactoAppService; 
        
        public ContactoController(IContactoAppService contactoAppService) 
        { 
            _contactoAppService = contactoAppService;
        }

        [HttpGet("BuscaPorId/{id:guid}")]
        public async Task<ContactoViewModel> BuscaPorId(Guid id)
        {
            return await _contactoAppService.BuscaPorId(id);
        }

        [HttpGet("BuscaPorIdPersona/{idPersona:guid}")]
        public async Task<ContactoViewModel> BuscaPorIdPersona(Guid idPersona)
        {
            return await _contactoAppService.BuscaPorIdPersona(idPersona);
        }

        [HttpPut("Modificar")]
        public async Task<IActionResult> Modificar(ContactoModificarViewModel modelo)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _contactoAppService.Modificar(modelo));
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear(ContactoCrearViewModel modelo)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _contactoAppService.Crear(modelo));
        }

        [HttpDelete("Eliminar/{id:Guid}")]
        public async Task<IActionResult> Eliminar(Guid id)
        {
            return CustomResponse(await _contactoAppService.Eliminar(id));
        }

        [HttpGet("History/{id:guid}")]
        public async Task<IList<ContactoHistoryData>> History(Guid id)
        {
            return await _contactoAppService.GetAllHistory(id);
        }

    }
}
