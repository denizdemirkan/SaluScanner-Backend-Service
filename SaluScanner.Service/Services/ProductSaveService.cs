using AutoMapper;
using SaluScanner.Core.DTOs;
using SaluScanner.Core.Entities;
using SaluScanner.Core.Repositories;
using SaluScanner.Core.Services;
using SaluScanner.Core.UnitOfWorks;
using SaluScanner.Service.Mapping;
using SaluScanner.SharedLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaluScanner.Service.Services
{
    public class ProductSaveService : GenericService<Product, SaveProductDto>, IProductSaveService
    {
        protected readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductSaveService(IGenericRepository<Product> _genericRepository, IUnitOfWork _unitOfWork, IProductRepository _productRepository, IMapper mapper) : base(_genericRepository, _unitOfWork)
        {
            this._repository = _productRepository;
            _mapper = mapper;
        }

        public async Task<Response<NoDataDto>> SaveAsync(SaveProductDto saveProductDto)
        {
            var entity = ObjectMapper.Mapper.Map<Product>(saveProductDto);

            if (entity != null)
            {
                await _repository.AddAsync(entity);

                return Response<NoDataDto>.Success(200);
            }

            return Response<NoDataDto>.Fail("Product can not be saved!", 404);
        }
    }
}