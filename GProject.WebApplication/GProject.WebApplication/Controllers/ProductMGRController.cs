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
                var lstBrand = await Commons.GetAll<Brand>(String.Concat(Commons.mylocalhost, "Brand/get-all-Brand"));
                var lstColor = await Commons.GetAll<ProductColorVariation>(String.Concat(Commons.mylocalhost, "Color/get-all-Color"));
                var lstSize = await Commons.GetAll<ProductSizeVariation>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));
                var lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
                //-- Lấy danh sách từ api
                var lstObjs = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "ProductMGR/get-all-Product-mgr"));
                
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
        public async Task<ActionResult> Save( ProductMGRDTO Product)
        {
            try
            {
                Guid uuid = Guid.NewGuid();
                //-- Gán Product
                var productInfo = new Product()
                {
                    Id = (Product.Id == Guid.Empty || Product.Id == null) ? uuid : Product.Id,
                    BrandId = Product.BrandId,
                    Name = Product.Name,
                    CreateDate = DateTime.Now,
                    CreateBy = User.Identity.Name != null ? User.Identity.Name : "",
                    ViewCount = Product.ViewCount,
                    LikeCount = Product.LikeCount,
                    Price = Product.Price,
                    ImportPrice = Product.ImportPrice,
                    Status = Product.Status,
                    Description = Product.Description
                };


                if (resultSaveProduct)
                {
                    //-- Gán Product variation
                    if (Product != null && Product.ColorList.Count >= 0 && Product.ColorList != null)
                    {
                        foreach (var colorVariation in Product.ColorList.Where(c => c.IsChecked == true))
                        {
                            foreach (var sizeVariation in colorVariation.SizeAndStock)
                            {
                                string image = "";
                                if (colorVariation.Image_Upload != null)
                                {
                                    string full_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", colorVariation.Image_Upload.FileName);
                                    using (var file = new FileStream(full_path, FileMode.Create))
                                    {
                                        colorVariation.Image_Upload.CopyTo(file);
                                    }
                                    image = colorVariation.Image_Upload.FileName;
                                }
                                var ProductVariationInfo = new ProductVariation()
                                {
                                    Id = colorVariation.VariationId,
                                    ProductId = productInfo.Id,
                                    ColorId = colorVariation.Id,
                                    SizeId = sizeVariation.Id,
                                    Image = image,
                                    QuantityInStock = sizeVariation.QuantityInstock.NullToInt(),
                                };
                                if (ProductVariationInfo.Id == Guid.Empty || ProductVariationInfo.Id == null) url2 += "ProductVariation/add-ProductVariation";
                                else url2 += "ProductVariation/update-ProductVariation";
                                bool resultSaveProductVariation = await Commons.Add_or_UpdateAsync(ProductVariationInfo, url2);
                                url2 = Commons.mylocalhost;
                            }
                        }
                    }
                }
                
                if (!resultSaveProduct)
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
                
                //-- TT sản phẩm
                var product = lstProduct.FirstOrDefault(c => c.Id == id);

                //-- Danh sách Color
                List<ProductColorVariation> productColorVariations= new List<ProductColorVariation>();
                var Colors = (from x in lstColor 
                              join y in lstProductvariation on x.Id equals y.ColorId
                              select new { Colorss = x, ProdVariations = y}).ToList();

                foreach (var item in Colors)
                {
                    ProductColorVariation p = new ProductColorVariation()
                    {
                        VariationId = item.ProdVariations.Id,
                        ProductId = item.ProdVariations.ProductId,
                        Id = item.Colorss.Id,
                        Name = item.Colorss.Name,
                        HEXCode = item.Colorss.HEXCode,
                        IsChecked = true,
                        Image = item.Colorss.Image,
                        ImageProduct = item.ProdVariations.Image,
                        Status = item.Colorss.Status,
                    };
                }

                var ProductVariations = new List<ProductVariation>();
                ProductMGRDTO prd = new ProductMGRDTO()
                {
                    Id = id,
                    Name = product.Name,
                    BrandId= product.BrandId,
                    CreateBy= product.CreateBy,
                    ViewCount = product.ViewCount,
                    LikeCount= product.LikeCount,
                    Price= product.Price,
                    ImportPrice= product.ImportPrice,
                    CreateDate= product.CreateDate,
                    Status= product.Status,
                    Description= product.Description
                };
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
