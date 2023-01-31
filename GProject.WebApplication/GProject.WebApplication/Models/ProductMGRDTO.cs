using GProject.Data.DomainClass;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GProject.WebApplication.Models
{
    public class ProductMGRDTO
    {
        public Guid? Id { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int ViewCount { get; set; }
        public int LikeCount { get; set; }
        public decimal Price { get; set; }
        public decimal ImportPrice { get; set; }
        public string CreateBy { get; set; }
        public int Status { get; set; } = 1; // 0: đang bán || 1: ngừng bán
        public string? Description { get; set; }
        public List<Product>? ProductList { get; set; }
        public List<ProductColorVariation>? ColorList { get; set; }
        public List<ProductSizeVariation>? SizeList { get; set; }
    }

    public class ProductColorVariation
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string HEXCode { get; set; }
        public bool IsChecked { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public ProductSizeVariation SizeAndStock { get; set; }
    }
    public class ProductSizeVariation
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int QuantityInstock { get; set; }
        public bool IsChecked { get; set; }
    }
}
