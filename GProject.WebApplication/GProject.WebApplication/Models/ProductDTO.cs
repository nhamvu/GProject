using GProject.Data.DomainClass;
using GProject.Data.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GProject.WebApplication.Models
{
    public class ProductDTO
    {
        public Product Product { get; set; }

        public Category Category { get; set; }

        public Color Color { get; set; }

        public Size Size { get; set; }
        public Brand Brand { get; set; }

        public List<ProductVariation> ProductVariations { get; set; }
        public Promotion Promotion { get; set; }

        public PromotionDetail PromotionDetail { get; set; }
    }

    
    public class ProdOrder
    {
        public string cartId { get; set; }
        public string prodVariationId { get; set; }
        public string productId { get; set; }
        public float price { get; set; }
        public int size { get; set; }
        public int color { get; set; }
        public int quantity { get; set; }
        public float totalMoneyItem { get; set; }
    }
}
