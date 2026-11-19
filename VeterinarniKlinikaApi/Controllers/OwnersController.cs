using Microsoft.AspNetCore.Mvc;
using VeterinarniKlinikaApi.Entities;

namespace VeterinarniKlinikaApi.Controllers
{
    [ApiController]
    [Route("api/owners")]
    public class OwnersController : ControllerBase
    {
        private static readonly List<Owner> _owners = new List<Owner>
        {
            new Owner { Id = 1, Name = "Karel Černý", Phone = "607 420 888"},
            new Owner { Id = 2, Name = "Ivo Vykydal",  Phone = "676 767 676" },
            new Owner { Id = 3, Name = "Petr Bílý", Phone = "123 456 789" }

        };

        [HttpGet]
        public ActionResult<List<Owner>> GetAll() //ActionResult protože nevím zda se výsledek povede, může být Ok(200) nebo nějaká chyba, třeba NotFound(400)
        {
            return Ok(_owners); //výsledek se musí zabalit do správného resultu v tomto případě Ok
        }

        [HttpGet("{id}")]
        public ActionResult<Owner> GetById(int id)
        {
            foreach (var a in _owners)
            {
                if (a.Id == id)
                {
                    return Ok(a); //povedlo se najít, vrátím 200
                }
            }
            return NotFound(); //404
        }
    }
}
