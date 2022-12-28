using GProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Data.DomainClass
{
    public class CategoryProduct
    {
        public Guid? ProductId { get; set; }
        public Guid? CategoryId { get; set; }
        public Product? ProductId_Navigation { get; set; }
        public Category? CategoryId_Navigation { get; set; }
    }
}
