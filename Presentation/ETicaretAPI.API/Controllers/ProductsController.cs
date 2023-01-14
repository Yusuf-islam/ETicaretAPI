using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
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
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;
        readonly private ICustomerReadRepository _customerReadRepository;


        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository, ICustomerReadRepository customerReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
            _customerReadRepository = customerReadRepository;

        }

        //[HttpGet]
        //public async Task Get()//DBye urun ekleme methodu
        //{
        //    /*
        //    var customerID = Guid.NewGuid();
        //    await _customerWriteRepository.AddAsync(new() { Id = customerID, Name = "Test User", CreatedDate = DateTime.UtcNow });
        //    await _orderWriteRepository.SaveAsync();
        //    */
        //    var customer = await _customerReadRepository.GetByIdAsync("b5c5b5b7-925f-4932-afd2-6eb5353683fb");
        //    customer.Name = "Yusuf İslam Önemli";
        //    await _customerWriteRepository.SaveAsync();

        //    var order = await _orderReadRepository.GetByIdAsync("d37f062f-78c1-4b6f-b502-fbbff7f87b8a");
        //    order.Address = @"Aksaray\Merkez";
        //    await _orderWriteRepository.SaveAsync();

        //    var productId = Guid.NewGuid();
        //    await _productWriteRepository.AddAsync(new() { Id = productId, Name = "Computer", Stock = 20, Price = 6000, CreatedDate = DateTime.UtcNow });
        //    await _productWriteRepository.SaveAsync();

        //    Order order = await _orderReadRepository.GetByIdAsync("a7bd183b-59a3-4dbe-aa37-7669e2ba6d55");
        //    order.Address = "Istanbul\\Kadikoy";
        //    await _orderWriteRepository.SaveAsync();
        //}

        [HttpGet]
      public async Task<IActionResult> Get()
        {

            return Ok("Merhaba");
        }

    }
}
