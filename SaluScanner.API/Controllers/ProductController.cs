using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaluScanner.AuthAPI.Controllers;
using SaluScanner.Core.DTOs;
using SaluScanner.Core.Entities;
using SaluScanner.Core.Services;
using System.Collections.Generic;

namespace SaluScanner.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CustomBaseController
    {
        private readonly IProductService _service;

        public ProductController(IProductService _service)
        {
            this._service = _service;
        }

        // Just an example
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return ActionResultInstance(await _service.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            return ActionResultInstance(await _service.AddAsync(productDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            return ActionResultInstance(await _service.Update(productDto));
        }

        // api/product/id
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return ActionResultInstance(await _service.RemoveById(id));
        }

        /*
        [HttpGet("{barcode}")]
        public async Task<IActionResult> GetByBarcode(String barcode)
        {
            var product = await _service.GetProductByBarcodeAsync(barcode);

            return Ok(product);
        }
        */


        //[HttpGet("{barcode}")]
        //public async Task<IActionResult> GetByCertificateProduct(String barcode)
        //{
        //    var certificateProducts = await _service.GetCertificateByProductWithBarcodeAsync(barcode);
        //    return Ok(certificateProducts);
        //}




    }
}
