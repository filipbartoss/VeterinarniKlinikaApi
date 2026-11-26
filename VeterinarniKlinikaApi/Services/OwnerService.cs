using VeterinarniKlinikaApi.Entities;
using VeterinarniKlinikaApi.Repositories;

namespace VeterinarniKlinikaApi.Services
{
    public class OwnerService
    {
        private readonly IOwnerRepository _repository;

        public OwnerService(IOwnerRepository repository)
        {
            _repository = repository;
            Console.WriteLine("Vytvořen OwnerService");
        }

        public async Task<List<Owner>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Owner?> GetByIdAsync(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            return await _repository.GetByIdAsync(id);
        }
    }
}
