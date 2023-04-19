using GProject.Data.DomainClass;
using GProject.Data.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GProject.WebApplication.Models
{
    public class OrderDto
    {
        public Order Order { get; set; }
        public Brand Brand { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public Product Product { get; set; }
        public ProductVariation ProductVariation { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public List<Order> Orders { get; set; }
    }
}
