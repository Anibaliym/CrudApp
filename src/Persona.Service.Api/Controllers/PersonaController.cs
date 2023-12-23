using Microsoft.AspNetCore.Mvc;
using Persona.Application.EventSourcedNormalizers.Persona;
using Persona.Application.Interfaces;
using Persona.Application.ViewModels.Persona;

namespace Persona.Service.Api.Controllers
{
    [Route("api/[controller]")]

    public class PersonaController : ApiController
    {
        private readonly IPersonaAppService _personaAppService; 

        public PersonaController(IPersonaAppService personaAppService)
        {
            _personaAppService = personaAppService;
        }

        [HttpGet("BuscaPorId")]
        public async Task<PersonaViewModel> BuscaPorId(Guid id)
        {
            return await _personaAppService.BuscaPorId(id);
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear(PersonaCrearViewModel modelo)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _personaAppService.Crear(modelo));
        }

        [HttpGet("History/{id:guid}")]
        public async Task<IList<PersonaHistoryData>> History(Guid id)
        {
            return await _personaAppService.GetAllHistory(id);
        }
    }
}
