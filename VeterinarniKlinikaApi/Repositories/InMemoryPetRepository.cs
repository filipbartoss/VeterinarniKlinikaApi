using VeterinarniKlinikaApi.Entities;

namespace VeterinarniKlinikaApi.Repositories
{
    public class InMemoryPetRepository : IPetRepository
    {
        private static readonly List<Pet> _pets = new List<Pet>
        {
            new Pet { Id = 1, Name = "Arnold", Species = "Kočka", BirthYear = 2022},
            new Pet { Id = 2, Name = "Schwartz", Species = "Pes", BirthYear = 2020},
            new Pet { Id = 3, Name = "Kořen", Species = "Morče", BirthYear = 2024}
        };

        public Task<List<Pet>> GetAllAsync()
        {
            return Task.FromResult(_pets.ToList());
        }

        public Task<Pet?> GetByIdAsync(int id)
        {
            foreach (var a in _pets)
            {
                if (a.Id == id)
                {
                    return Task.FromResult(a);
                }
            }
            return null;
        }
        public InMemoryPetRepository()
        {
            Console.WriteLine("vytvořen InMemoryAuthorRepository");
        }
    }
}
