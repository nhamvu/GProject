using GProject.Data.DomainClass;
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
}
