using VeterinarniKlinikaApi.Entities;
using VeterinarniKlinikaApi.Repositories;

namespace VeterinarniKlinikaApi.Services
{
    public class PetService
    {
        private readonly IPetRepository _repository;

        public PetService(IPetRepository repository)
        {
            _repository = repository;
            Console.WriteLine("Vytvořen PetService");
        }

        public async Task<List<Pet>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Pet?> GetByIdAsync(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            return await _repository.GetByIdAsync(id);
        }
    }
}
