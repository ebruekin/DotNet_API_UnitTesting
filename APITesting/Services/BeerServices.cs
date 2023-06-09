using APITesting.Models;

namespace APITesting.Services
{
    public class BeerServices : IBeerServices
    {
        // Mock
        private List<Beer> beers = new List<Beer>()
        {
            new Beer(1, "Estrella", "Estrella Galicia"),
            new Beer(2, "Voll-Damm Doble Malta", "Damm"),
            new Beer(3, "Cerveza de Trigo", "Franziskaner")
        };

        public Beer? GetBeer(int id)
        {
            return beers.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Beer> GetBeers() => beers;

    }
}
