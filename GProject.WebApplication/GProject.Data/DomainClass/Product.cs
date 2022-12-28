using GProject.Data.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Data.DomainClass
{
    public class Product
    {
        public int? Id { get; set; }
        public int? BrandId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string SearchCount { get; set; }
        public int ViewCount { get; set; }
        public int LikeCount { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal ImportPrice { get; set; }
        public string CreateBy { get; set; }
        public int Status { get; set; } = 1; // 0: đang bán || 1: ngừng bán
        public string? Description { get; set; }
        public Brand? BrandId_Navigation { get; set; }
        public List<ProductVariation>? ProductVariations { get; set; }
        public List<Evaluate>? Evaluates { get; set; }
        public List<PromotionDetail>? PromotionDetails { get; set; }
        public List<CategoryProduct>? CategoryProducts { get; set; }
    }
}
