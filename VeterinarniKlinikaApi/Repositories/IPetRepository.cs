using VeterinarniKlinikaApi.Entities;

namespace VeterinarniKlinikaApi.Repositories
{
    public interface IPetRepository
    {
        Task<List<Pet>> GetAllAsync();
        Task<Pet?> GetByIdAsync(int id);
    }
}
