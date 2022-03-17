using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        public ProductsController(IProductWriteRepository productWriteRepository,IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;   
            _productReadRepository = productReadRepository; 

        }

        [HttpGet]
        public async void Get()
        {

            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {  Name = "Product 1", Price = 100, CreatedDate = DateTime.UtcNow, Stock = 10 },
                new() {  Name = "Product 2", Price = 200, CreatedDate = DateTime.UtcNow, Stock = 20 },
                new() {  Name = "Product 3", Price = 300, CreatedDate = DateTime.UtcNow, Stock = 30 },
                new() {  Name = "Product 4", Price = 400, CreatedDate = DateTime.UtcNow, Stock = 40 }

            });
            await  _productWriteRepository.SaveAsync();
        }


    }
}
