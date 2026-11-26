using Microsoft.AspNetCore.Mvc;
using VeterinarniKlinikaApi.Entities;
using VeterinarniKlinikaApi.Services;

namespace VeterinarniKlinikaApi.Controllers
{
    [ApiController]
    [Route("api/owners")]
    public class OwnersController : ControllerBase
    {
        private readonly OwnerService _service;

        public OwnersController(OwnerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Owner>>> GetAll() //ActionResult protože nevím zda se výsledek povede, může být Ok(200) nebo nějaká chyba, třeba NotFound(400)
        {
            List<Owner> owners = await _service.GetAllAsync();

            return Ok(owners); //výsledek se musí zabalit do správného resultu v tomto případě Ok
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Owner>> GetById(int id)
        {
            Owner? owner = await _service.GetByIdAsync(id);

            if (owner is null)
            {
                return NotFound(); //404
            }
            return Ok(owner);
        }
    }
}
