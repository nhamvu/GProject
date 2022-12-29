using GProject.Data.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Data.Configurations
{
    public class CategoryProduct_Configuration : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.ToTable("CategoryProduct");
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.HasOne(d => d.ProductId_Navigation).WithMany(p => p.CategoryProducts).HasForeignKey(d => d.ProductId);
            builder.HasOne(d => d.CategoryId_Navigation).WithMany(p => p.CategoryProducts).HasForeignKey(d => d.CategoryId);
        }
    }
}
