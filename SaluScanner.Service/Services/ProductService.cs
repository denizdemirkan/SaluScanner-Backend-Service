using AutoMapper;
using SaluScanner.Core.DTOs;
using SaluScanner.Core.Entities;
using SaluScanner.Core.Repositories;
using SaluScanner.Core.Services;
using SaluScanner.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaluScanner.Service.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {
        protected readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> _genericRepository, IUnitOfWork _unitOfWork, IProductRepository _productRepository, IMapper mapper) : base(_genericRepository, _unitOfWork)
        {
            this._repository = _productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductWithCertificateDto>> GetCertificateByProductWithBarcodeAsync(string barcode)
        {
           var products =  await _repository.GetCertificateByProductWithBarcodeAsync(barcode);
           return  _mapper.Map<List<ProductWithCertificateDto>>(products);
            
        }

        public async Task<Product> GetProductByBarcodeAsync(string barcode)
        {
            return await _repository.GetProductByBarcodeAsync(barcode);
        }
    }
}
