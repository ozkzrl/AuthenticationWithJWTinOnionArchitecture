using GymSpotterAPI.Application.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace GymSpotterAPI.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes ="Admin")]

    public class ProductsController : Controller
    {
        private readonly IProductReadRepository _productReadRepository;

        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){ Id=Guid.NewGuid(), Name="Product 1", Price=100, CreateDateTime=DateTime.UtcNow, Stock=10},
                new(){ Id=Guid.NewGuid(), Name="Product 2", Price=200, CreateDateTime=DateTime.UtcNow, Stock=20},
                new(){ Id=Guid.NewGuid(), Name="Product 3", Price=300, CreateDateTime=DateTime.UtcNow, Stock=30}

            });
            await _productWriteRepository.SaveAsync();
        }
    }
}
