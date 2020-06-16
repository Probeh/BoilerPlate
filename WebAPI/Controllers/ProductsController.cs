using Library.Data.Responses;
using Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/Products")]
    public class ProductsController : ControllerBase
    {
        private readonly IApplicationRepository<Product> _repository;

        public ProductsController(IApplicationRepository<Product> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetModels()
        {
            var result = await _repository.GetModels<ProductResponse>();
            return Ok(result);
        }
    }
}
