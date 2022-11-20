using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaluScanner.Core.Entities;
using SaluScanner.Core.Services;

namespace SaluScanner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // It must be service that can be use in Controller level but it is an example

        private readonly IProductService _service;

        public ProductController(IProductService _service)
        {
            this._service = _service;
        }

        // Just an example
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetAllAsync();

            return Ok(products);
        }

        [HttpGet]
        public async Task<IActionResult> GetByBarcode(String barcode)
        {
            var product = await _service.GetProductByBarcodeAsync(barcode);

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            await _service.AddAsync(product);

            return Ok(product);
        }

    }
}
