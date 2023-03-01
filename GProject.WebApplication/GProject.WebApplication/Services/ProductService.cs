using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace GProject.WebApplication.Services
{
    public class ProductService
    {
        public async Task<List<ProductDTO>> GetProductViewModel()
        {
                var lstBrand = await Commons.GetAll<Brand>(String.Concat(Commons.mylocalhost, "Brand/get-all-Brand"));
                var lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
                var lstProducts = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "ProductMGR/get-all-Product-mgr"));
                var data = lstProducts
                    .Join(lstProductvariation, a => a.Id, b => b.ProductId, (a, b) => new { a, b })
                    .Join(lstBrand, c => c.a.BrandId, d => d.Id, (c, d) => new { c, d })
                    .Select(i => new { Product = i.c.a, ProductVariation = i.c.b, Brand = i.d});
                return Commons.ConverObject<List<ProductDTO>>(data);
            }
    }
}
