using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaluScanner.Core.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Barcode { get; set; }

        // Navigations & Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int NutritionId { get; set; }
        public Nutrition Nutrition { get; set; }

        public int ProductDetailId { get; set; }
        public ProductDetail ProductDetail { get; set; }

        public List<Certificate> Certificates { get; set; }

        public List<Content> Contents { get; set; }
    }
}
