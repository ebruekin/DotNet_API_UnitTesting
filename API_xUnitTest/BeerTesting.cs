using APITesting.Controllers;
using APITesting.Models;
using APITesting.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_xUnitTest
{
    public class BeerTesting
    {
        private readonly BeerController _controller;
        private readonly IBeerServices _service;

        public BeerTesting()
        {
            _service = new BeerServices();
            _controller = new BeerController(_service);
        }


        [Fact]
        public void GetById_Ok()
        {
            // Arrange
            int id = 1;

            // Act
            var result = (OkObjectResult) _controller.Get(id);

            // Assert
            var beer = Assert.IsType<Beer>(result?.Value);
            Assert.NotNull(beer);
            Assert.Equal(beer?.Id, id);
        }

        [Fact]
        public void GetById_NotFound()
        {
            // Arrange
            int id = 47;

            // Act
            var result = _controller.Get(id);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }



        [Fact]
        public void GetAllBeers_Ok()
        {
            var result = _controller.Get();

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetQuantity()
        {
            var result = (OkObjectResult) _controller.Get();

            var beers = Assert.IsType<List<Beer>>(result.Value);
            Assert.True(beers.Count > 0);
        }

        
    }
}