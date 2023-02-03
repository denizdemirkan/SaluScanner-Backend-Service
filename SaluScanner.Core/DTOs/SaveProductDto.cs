using SaluScanner.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaluScanner.Core.DTOs
{
    public class SaveProductDto : IDto
    {
        public string Barcode { get; set; }
        public Company Company { get; set; }
        public Category Category { get; set; }
        public Nutrition Nutrition { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
