using APITesting.Models;
using APITesting.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITesting.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private readonly IBeerServices _beerServices;

        // Dependency Injection
        public BeerController(IBeerServices beerServices)
        {
            _beerServices = beerServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_beerServices.GetBeers());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var beer = _beerServices.GetBeer(id);

            if(beer == null)
            {
                return NotFound();
            }

            return Ok(beer);
        }

    }
}
