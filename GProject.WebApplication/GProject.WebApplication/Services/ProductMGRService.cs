using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace GProject.WebApplication.Services
{
    public class ProductMGRService
    {
        /// <summary>
        /// Hàm Lưu sản phâm
        /// </summary>
        /// <param name="Product"></param>
        /// <param name="CreateBy"></param>
        /// <returns></returns>
        public async Task<bool> Save(ProductMGRDTO Product, string CreateBy)
        {
            try
            {
                if (Product == null &&  Product.ColorList == null) return false;
                Guid uuid = Guid.NewGuid();

                //-- Set Product
                var productInfo = new Product()
                {
                    Id = (Product.Id == Guid.Empty || Product.Id == null) ? uuid : Product.Id,
                    BrandId = Product.BrandId,
                    Name = Product.Name,
                    CreateDate = DateTime.Now,
                    CreateBy = CreateBy,
                    ViewCount = Product.ViewCount,
                    LikeCount = Product.LikeCount,
                    Price = Product.Price,
                    ImportPrice = Product.ImportPrice,
                    Status = Product.Status,
                    Description = Product.Description
                };

                //-- Save Product Info
                string url = (Product.Id == Guid.Empty || Product.Id == null) ? Commons.mylocalhost + "ProductMGR/add-Product-mgr" : Commons.mylocalhost + "Product/update-Product-mgr";
                bool resultSaveProduct = await Commons.Add_or_UpdateAsync(productInfo, url);
                if (!resultSaveProduct) return false;

                //-- Set Value Productvariation 
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

                        string url2 = (ProductVariationInfo.Id == Guid.Empty || ProductVariationInfo.Id == null) ? Commons.mylocalhost + "ProductVariation/add-ProductVariation" : Commons.mylocalhost + "ProductVariation/update-ProductVariation";
                        bool resultSaveProductVariation = await Commons.Add_or_UpdateAsync(ProductVariationInfo, url2);
                        url2 = Commons.mylocalhost;
                    }
                }

                return resultSaveProduct;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
