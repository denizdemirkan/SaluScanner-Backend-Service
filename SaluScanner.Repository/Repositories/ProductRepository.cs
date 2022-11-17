using Microsoft.EntityFrameworkCore;
using SaluScanner.Core.Entities;
using SaluScanner.Core.Repositories;
using SaluScanner.Repository.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SaluScanner.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository<Product>
    {
        public ProductRepository(SqlServerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Product> GetProductByBarcodeAsync(string barcode)
        {
            var filteredProduct = dbContext.Products.Where(p => p.Barcode == barcode).;
            
            return await filteredProduct.FirstOrDefault();
        }
    }
}
