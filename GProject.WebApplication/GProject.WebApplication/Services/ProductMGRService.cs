using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;
using System.Xml.Linq;

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
                if (Product == null &&  Product.ProductVariationViewModel == null) return false;
                Guid uuid = Guid.NewGuid();

                //-- Set Product
                var productInfo = new Product();
                productInfo.Id = (Product.Id == Guid.Empty || Product.Id == null) ? uuid : Product.Id;
                productInfo.BrandId = Product.BrandId;
                productInfo.Name = Product.Name;
                productInfo.CategoryId = Product.CategoryId;
                productInfo.CreateDate = DateTime.Now;
                productInfo.UpdateDate = DateTime.Now;
                productInfo.CreateBy = CreateBy;
                productInfo.ViewCount = Product.ViewCount;
                productInfo.LikeCount = Product.LikeCount;
                productInfo.Price = Product.Price;
                productInfo.ImportPrice = Product.ImportPrice;
                productInfo.Status = Product.Status;
                productInfo.ProductType = Product.ProductType;
                if (!string.IsNullOrEmpty(Product.Description)) productInfo.Description = Product.Description;

                //-- Save Product Info
                string url = (Product.Id == Guid.Empty || Product.Id == null) ? Commons.mylocalhost + "ProductMGR/add-Product-mgr" : Commons.mylocalhost + "ProductMGR/update-Product-mgr";
                bool resultSaveProduct = await Commons.Add_or_UpdateAsync(productInfo, url);
                if (!resultSaveProduct) return false;

                //-- Set Value Productvariation 
                foreach (var colorVariation in Product.ProductVariationViewModel.Where(c => c.IsChecked == true))
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
                            CreateDate = DateTime.Now,
                            UpdateDate = DateTime.Now,
                            QuantityInStock = sizeVariation.QuantityInstock.NullToInt(),
                        };

                        string saveProductVariationUrl = (ProductVariationInfo.Id == Guid.Empty || ProductVariationInfo.Id == null) ? Commons.mylocalhost + "ProductVariation/add-ProductVariation" : Commons.mylocalhost + "ProductVariation/update-ProductVariation";
                        bool resultSaveProductVariation = await Commons.Add_or_UpdateAsync(ProductVariationInfo, saveProductVariationUrl);
                        saveProductVariationUrl = Commons.mylocalhost;
                    }
                }

                return resultSaveProduct;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ProductMGRDTO> GetProductViewModel()
        {
            try
            {
                var lstBrand = await Commons.GetAll<Brand>(String.Concat(Commons.mylocalhost, "Brand/get-all-Brand"));
                var lstColor = await Commons.GetAll<ProductVariationDTO>(String.Concat(Commons.mylocalhost, "Color/get-all-Color"));
                var lstSize = await Commons.GetAll<ProductSizeVariation>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));
                var lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
                //-- Lấy danh sách từ api
                var lstObjs = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "ProductMGR/get-all-Product-mgr"));
                var result = new ProductMGRDTO() { ProductVariationList = lstProductvariation, ProductList = lstObjs, ProductVariationViewModel = lstColor.Where(c => c.Status == 1).ToList(), SizeList = lstSize };
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<ProductMGRDTO> GetProduct(Guid? id)
        {
            try
            {
                List<Color>? lstColor = await Commons.GetAll<Color>(String.Concat(Commons.mylocalhost, "Color/get-all-Color"));
                List<Size>? lstSize = await Commons.GetAll<Size>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));
                List<ProductVariation>? lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
                var lstSizes = await Commons.GetAll<ProductSizeVariation>(String.Concat(Commons.mylocalhost, "Size/get-all-Size"));

                List<Product>? lstProduct = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "ProductMGR/get-all-Product-mgr"));
                ProductMGRDTO productData = new ProductMGRDTO();
                var product = lstProduct.FirstOrDefault(c => c.Id == id);
                productData.Id = id;
                productData.CategoryId = product.CategoryId;
                productData.Name = product.Name;
                productData.BrandId = product.BrandId;
                productData.CreateBy = product.CreateBy;
                productData.ViewCount = product.ViewCount;
                productData.LikeCount = product.LikeCount;
                productData.Price = product.Price;
                productData.ImportPrice = product.ImportPrice;
                productData.CreateDate = product.CreateDate;
                productData.Status = product.Status;
                productData.Description = product.Description;
                productData.ProductType = product.ProductType;

                List<ProductVariationDTO> lstPrdVariation = await Commons.GetAll<ProductVariationDTO>(String.Concat(Commons.mylocalhost, "Color/get-all-Color"));
                //-- Lấy danh sách color và Pariation 
                var DataObjects = (from x in lstColor
                              join y in lstProductvariation on x.Id equals y.ColorId
                              where y.ProductId == product.Id
                              select new { Colorss = x, ProdVariations = y }).DistinctBy(c => c.Colorss.Id).ToList();

                foreach (var item in DataObjects)
                {
                    //-- Lấy size và stock hiện tại của sản phẩm
                    List<ProductSizeVariation> SizeVariations = new List<ProductSizeVariation>();
                    var productVariations = lstProductvariation.Where(c => c.ProductId == item.ProdVariations.ProductId && c.ColorId == item.Colorss.Id).ToList();
                    //-- Lấy 
                    foreach (var itemVariation in productVariations)
                    {
                        SizeVariations.Add(new ProductSizeVariation() { Id = itemVariation.SizeId, Code = lstSize.Where(c => c.Id == itemVariation.SizeId).Select(c => c.Code).FirstOrDefault(), QuantityInstock = itemVariation.QuantityInStock });
                    }

                    ProductVariationDTO p = new ProductVariationDTO()
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
                        SizeAndStock = SizeVariations
                    };

                    //-- Nếu tìm thấy item đã có color này r, thì xóa bỏ thằng mặc điịnh đi
                    var VariationItemRemove = lstPrdVariation.Where(c => c.Id == p.Id).FirstOrDefault();
                    if (VariationItemRemove != null)
                        lstPrdVariation.Remove(VariationItemRemove);
                    lstPrdVariation.Add(p);
                }

                productData.SizeList = lstSizes;
                productData.ProductVariationViewModel = lstPrdVariation;

                return productData;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<bool> ChangeStatus(Guid? id)
        {
            try
            {
                List<Product>? lstProduct = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "ProductMGR/get-all-Product-mgr"));
                var product = lstProduct.FirstOrDefault(c => c.Id == id);
                if (product != null)
                {
                    if (product.Status == 0)
                        product.Status = 1;
                    else
                        product.Status = 0;
                    bool result = await Commons.Add_or_UpdateAsync(product, Commons.mylocalhost + "ProductMGR/update-Product-mgr");
                    return result;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
