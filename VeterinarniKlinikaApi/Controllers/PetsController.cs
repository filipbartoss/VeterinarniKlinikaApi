using Microsoft.AspNetCore.Mvc;
using VeterinarniKlinikaApi.Entities;

namespace VeterinarniKlinikaApi.Controllers
{
    [ApiController]
    [Route("api/pets")]
    public class PetsController : ControllerBase
    {
        private static readonly List<Pet> _pets = new List<Pet>
        {
            new Pet { Id = 1, Name = "Arnold", Species = "Kočka", BirthYear = 2022},
            new Pet { Id = 2, Name = "Schwartz", Species = "Pes", BirthYear = 2020},
            new Pet { Id = 3, Name = "Kořen", Species = "Morče", BirthYear = 2024}
        };

        [HttpGet]
        public ActionResult<List<Owner>> GetAll() //ActionResult protože nevím zda se výsledek povede, může být Ok(200) nebo nějaká chyba, třeba NotFound(400)
        {
            return Ok(_pets); //výsledek se musí zabalit do správného resultu v tomto případě Ok
        }

        [HttpGet("{id}")]
        public ActionResult<Owner> GetById(int id)
        {
            foreach (var a in _pets)
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
