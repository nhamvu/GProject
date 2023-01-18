using GProject.Data.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GProject.WebApplication.Models
{
    public class ProductVariationDTO
    {
        public Guid? Id { get; set; }
        public Guid? ProductId { get; set; }
        public int? ColorId { get; set; }
        public int? SizeId { get; set; }
        public int QuantityInStock { get; set; }
        public string Image { get; set; }
        public Color? mColor { get; set; }
        public Size? mSize { get; set; }
        public List<ProductVariation>? ProductVariationList { get; set; }
    }
}
