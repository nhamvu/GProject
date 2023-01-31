using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace GProject.WebApplication.Services
{
    public class ProductMGRService
    {

        /// <summary>
        /// Lấy chi tiết sản phẩm được chọn
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ProductMGRDTO> GetDetailProduct(Guid? id)
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
                return prd;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

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
                throw;
            }

        }
    }
}
