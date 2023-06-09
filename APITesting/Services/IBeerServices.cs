using APITesting.Models;

namespace APITesting.Services
{
    public interface IBeerServices
    {
        public IEnumerable<Beer> GetBeers();
        public Beer? GetBeer(int id);
    }
}
