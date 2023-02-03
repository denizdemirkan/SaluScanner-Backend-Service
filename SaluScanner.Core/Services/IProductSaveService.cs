using SaluScanner.Core.DTOs;
using SaluScanner.Core.Entities;
using SaluScanner.SharedLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaluScanner.Core.Services
{
    public interface IProductSaveService : IGenericService<Product, SaveProductDto>
    {
        Task<Response<NoDataDto>> SaveAsync(SaveProductDto saveProductDto);
    }
}
