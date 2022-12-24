using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persintence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       
        private readonly ICustomerReadRepository _customerReadRepository;
        public ProductsController( ICustomerReadRepository customerReadRepository)
        {
           
            _customerReadRepository = customerReadRepository;
        }
        [HttpGet]
        public IActionResult GetProducts() 
        {
           var result= _customerReadRepository.GetAll();


          return new JsonResult(result)  ;
        }

    }
}
