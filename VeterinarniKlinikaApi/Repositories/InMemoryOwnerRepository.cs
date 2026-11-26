using VeterinarniKlinikaApi.Entities;

namespace VeterinarniKlinikaApi.Repositories
{
    public class InMemoryOwnerRepository : IOwnerRepository
    {
        private readonly List<Owner> _owners = new List<Owner>
        {
            new Owner { Id = 1, Name = "Karel Černý", Phone = "607 420 888"},
            new Owner { Id = 2, Name = "Ivo Vykydal",  Phone = "676 767 676" },
            new Owner { Id = 3, Name = "Petr Bílý", Phone = "123 456 789" }

        };

        public Task<List<Owner>> GetAllAsync()
        {
            return Task.FromResult(_owners.ToList());
        }

        public Task<Owner?> GetByIdAsync(int id)
        {
            foreach (var a in _owners)
            {
                if (a.Id == id)
                {
                    return Task.FromResult(a);
                }
            }
            return null;
        }
        public InMemoryOwnerRepository()
        {
            Console.WriteLine("vytvořen InMemoryAuthorRepository");
        }
    }
}
