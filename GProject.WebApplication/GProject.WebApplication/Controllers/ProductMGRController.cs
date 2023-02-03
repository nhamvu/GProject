using GProject.Api.MyServices.IServices;
using GProject.Api.MyServices.Services;
using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata;

namespace GProject.WebApplication.Controllers
{
    [Authorize(Roles = "manager, employee")]
    public class ProductMGRController : Controller
    {
        private IProductMGRService iProductService;
        public ProductMGRController()
        {
            iProductService = new ProductMGRService();
        }

        [HttpGet]
        public async Task<ActionResult> Index(int pg = 1)
        {
            try
            {
                const int pageSize = 5;
                if (pg < 1)
                    pg = 1;
                int recsCount = lstObjs.Count();
                var pager = new Pager(recsCount, pg, pageSize);
                int recSkip = (pg - 1) * pageSize;
                var data = lstObjs.Skip(recSkip).Take(pageSize).ToList();

                var result = new ProductMGRDTO() { ProductVariationList = lstProductvariation, ProductList = data, ColorList = lstColor.Where(c => c.Status == 1).ToList(), SizeList = lstSize };
                this.ViewBag.Pager = pager;
                //this.ViewBag.Data = data;
                //-- truyền vào message nếu có thông báo
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("mess")))
                    ViewData["Mess"] = HttpContext.Session.GetString("mess");
                HttpContext.Session.Remove("mess");
                return View(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult> Save(ProductMGRDTO Product)
        {
            try
            {
                GProject.WebApplication.Services.ProductMGRService pService = new GProject.WebApplication.Services.ProductMGRService();
                bool result = await pService.Save(Product, User.Identity.Name != null ? User.Identity.Name : "");
                
                if (!result)
                    HttpContext.Session.SetString("mess", "Failed");
                else
                    HttpContext.Session.SetString("mess", "Success");
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        public async Task<ActionResult> Detail(Guid? id)
        {
            try
            {
                //-- Lấy thông tín ản phẩm
                List<Color>? lstColor = await Commons.GetAll<Color>(String.Concat(Commons.mylocalhost, "Color/get-all-Color"));
                List<Size>? lstSize = await Commons.GetAll<Size>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));
                List<ProductVariation>? lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
                List<Product>? lstProduct = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "ProductMGR/get-all-Product-mgr"));
                var lstSizes = await Commons.GetAll<ProductSizeVariation>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));

                //-- TT sản phẩm
                var product = lstProduct.FirstOrDefault(c => c.Id == id);

                //-- Danh sách Color
                List<ProductVariationDTO> ColorVariations = new List<ProductVariationDTO>();
                var Colors = (from x in lstColor
                              join y in lstProductvariation on x.Id equals y.ColorId
                              select new { Colorss = x, ProdVariations = y }).ToList();

                //-- lấy dữ liệu productvariation
                foreach (var itemColor in Colors)
                {
                    List<ProductSizeVariation> SizeVariations = new List<ProductSizeVariation>();
                    var productVariations = lstProductvariation.Where(c => c.Id == itemColor.ProdVariations.Id).ToList();
                    foreach (var itemSize in productVariations)
                    {
                        ProductSizeVariation valItem = new ProductSizeVariation() { Id = itemSize.SizeId, Code = lstSize.Where(c => c.Id == itemSize.SizeId).Select(c => c.Code).FirstOrDefault(), QuantityInstock = itemSize.QuantityInStock };
                        SizeVariations.Add(valItem);
                    }

                    ProductVariationDTO p = new ProductVariationDTO()
                    {
                        VariationId = itemColor.ProdVariations.Id,
                        ProductId = itemColor.ProdVariations.ProductId,
                        Id = itemColor.Colorss.Id,
                        Name = itemColor.Colorss.Name,
                        HEXCode = itemColor.Colorss.HEXCode,
                        IsChecked = true,
                        Image = itemColor.Colorss.Image,
                        ImageProduct = itemColor.ProdVariations.Image,
                        Status = itemColor.Colorss.Status,
                        SizeAndStock = SizeVariations
                    };
                    ColorVariations.Add(p);
                }

                //-- Set Data
                var ProductVariations = new List<ProductVariation>();
                ProductMGRDTO prd = new ProductMGRDTO()
                {
                    Id = id,
                    Name = product.Name,
                    BrandId = product.BrandId,
                    CreateBy = product.CreateBy,
                    ViewCount = product.ViewCount,
                    LikeCount = product.LikeCount,
                    Price = product.Price,
                    ImportPrice = product.ImportPrice,
                    CreateDate = product.CreateDate,
                    Status = product.Status,
                    Description = product.Description,
                    ColorList = ColorVariations,
                    SizeList = lstSizes
                };
                return View(prd);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
