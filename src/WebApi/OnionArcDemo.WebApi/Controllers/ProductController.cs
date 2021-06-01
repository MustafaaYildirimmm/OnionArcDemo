using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArcDemo.Application.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArcDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allList = await _productRepository.GetAllAsync();
        }
    }
}
