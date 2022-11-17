﻿using SaluScanner.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaluScanner.Core.Repositories
{
    public interface IProductRepository<TEntity>
    {
        Task<TEntity> GetProductByBarcodeAsync(string barcode);
    }
}
