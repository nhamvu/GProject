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
               .Join(lstBrand, a => a.BrandId, b => b.Id, (a, b) => new { a, b })
               .Select(i => new { Product = i.a, Brand = i.b, ProductVariations = lstProductvariation.Where(c => c.ProductId == i.a.Id).ToList() });
            return Commons.ConverObject<List<ProductDTO>>(data);
        }
    }
}
