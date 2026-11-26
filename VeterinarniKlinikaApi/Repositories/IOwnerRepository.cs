using VeterinarniKlinikaApi.Entities;

namespace VeterinarniKlinikaApi.Repositories
{
    public interface IOwnerRepository
    {
        Task<List<Owner>> GetAllAsync();
        Task<Owner?> GetByIdAsync(int id);
    }
}
