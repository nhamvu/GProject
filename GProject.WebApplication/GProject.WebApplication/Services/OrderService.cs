using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Xml.Linq;

namespace GProject.WebApplication.Services
{
    public class OrderService
    {
        public async Task<bool> AddToOrder(int selectVoucher, string cGiamGia, string cShippingFee, string cTotalMoney, string ShippingFullName, string ShippingPhone,
            string ShippingCity, string ShippingDistrict, string ShippingTown, string ShippingAddress, string ShippingEmail, string cDescription, int PaymentType = 0, Guid? customer_id = null, List<ProdOrder>? prodOrders = null)
        {
            var lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
            string strUrl = "";
            Guid order_id = Guid.NewGuid();

            //Order
            Order order = new Order();
            order.OrderId = string.Concat(DateTime.Now.ToString("ddMMyy"), Commons.RandomString(9));
            order.Id = order_id;
            order.CustomerId = customer_id;
            order.CreateDate = DateTime.Now;
            order.UpdateDate = DateTime.Now;
            order.PaymentType = (GProject.Data.Enums.PaymentType)PaymentType;
            order.ShippingFullName = ShippingFullName;
            order.ShippingCountry = "Việt Nam";
            order.ShippingCity = ShippingCity.NullToString();
            order.ShippingDistrict = ShippingDistrict.NullToString();
            order.ShippingTown = ShippingTown.NullToString();
            order.ShippingAddress = ShippingAddress.NullToString();
            order.ShippingPhone = ShippingPhone;
            order.ShippingEmail = ShippingEmail;
            order.TotalMoney = decimal.Parse(cTotalMoney);
            order.ShippingFee = decimal.Parse(cShippingFee);
            order.Description = cDescription;
            order.Status = GProject.Data.Enums.OrderStatus.InProgress;
            order.VoucherId = selectVoucher;
            order.DiscountRate = Convert.ToSingle(cGiamGia);

            strUrl = String.Concat(Commons.mylocalhost, "Order/add-Order");
            if (!await Commons.Add_or_UpdateAsync(order, strUrl))
                return false;

            


            //-- Add vào bảng OrderDetail và xóa nó khỏi giỏ hàng
            foreach (var item in prodOrders)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderId = order_id;
                orderDetail.ProductVariationId = new Guid(item.prodVariationId);
                orderDetail.Price = decimal.Parse(item.price.ToString());
                orderDetail.Quantity = item.quantity;
                orderDetail.TotalMoney = decimal.Parse(item.totalMoneyItem.ToString());
                orderDetail.Status = GProject.Data.Enums.OrderDetailStatus.Watting;

                //-- Add vào OrderDetail
                if (!await Commons.Add_or_UpdateAsync(orderDetail, String.Concat(Commons.mylocalhost, "Order/add-Order-detail")))
                    return false;

                //-- Giảm số lượng còn lại của ProductVariation
                ProductVariation productVariation = lstProductvariation.FirstOrDefault(c => c.Id == new Guid(item.prodVariationId));
                if (productVariation == null) return false;
                productVariation.QuantityInStock = productVariation.QuantityInStock - item.quantity;
                if (!await Commons.Add_or_UpdateAsync(productVariation, String.Concat(Commons.mylocalhost, "ProductVariation/update-ProductVariation")))
                    return false;

                //-- Add thành công vào OrderDetail -> Remove khỏi CartDetail
                string urlRemoveCartDetail = string.Concat(Commons.mylocalhost, "Cart/delete-cart-detail?id=", new Guid(item.cartId), "&productVariation_id=", new Guid(item.prodVariationId));
                var RestRemoveCartDetail = new RestSharpHelper(urlRemoveCartDetail);
                var resRemoveCartDetail = await RestRemoveCartDetail.RequestBaseAsync(urlRemoveCartDetail, RestSharp.Method.Delete);
                if (!resRemoveCartDetail.IsSuccessful)
                    return false;
            }

            string urlRemoveCart = string.Concat(Commons.mylocalhost, "Cart/delete-Cart?id=", new Guid(prodOrders.Select(c => c.cartId).FirstOrDefault().NullToString()));
            var RestRemoveCart = new RestSharpHelper(urlRemoveCart);
            var resultRemoveCart = await RestRemoveCart.RequestBaseAsync(urlRemoveCart, RestSharp.Method.Delete);
            if (!resultRemoveCart.IsSuccessful)
                return false;

            return true;
        }


        public async Task<bool> BuyNow(string cShippingFee,string pTotalMoney, string ShippingFullName, string ShippingPhone,
            string ShippingCity, string ShippingDistrict, string ShippingTown, string ShippingAddress, string ShippingEmail, string cDescription, int PaymentType = 0, Guid? customer_id = null, List<ProdOrder>? prodOrders = null)
        {
            var lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
            string strUrl = "";
            Guid order_id = Guid.NewGuid();

            //Order
            Order order = new Order();
            order.OrderId = string.Concat(DateTime.Now.ToString("ddMMyy"), Commons.RandomString(9));
            order.Id = order_id;
            order.CustomerId = customer_id;
            order.CreateDate = DateTime.Now;
            order.UpdateDate = DateTime.Now;
            order.PaymentType = (GProject.Data.Enums.PaymentType)PaymentType;
            order.ShippingFullName = ShippingFullName;
            order.ShippingCountry = "Việt Nam";
            order.ShippingCity = ShippingCity.NullToString();
            order.ShippingDistrict = ShippingDistrict.NullToString();
            order.ShippingTown = ShippingTown.NullToString();
            order.ShippingAddress = ShippingAddress.NullToString();
            order.ShippingPhone = ShippingPhone;
            order.ShippingEmail = ShippingEmail;
            order.TotalMoney = decimal.Parse(pTotalMoney);
            order.ShippingFee = decimal.Parse(cShippingFee);
            order.Description = cDescription;
            order.Status = GProject.Data.Enums.OrderStatus.InProgress;

            strUrl = String.Concat(Commons.mylocalhost, "Order/add-Order");
            if (!await Commons.Add_or_UpdateAsync(order, strUrl))
                return false;

            //-- Add vào bảng OrderDetail và xóa nó khỏi giỏ hàng
            foreach (var item in prodOrders)
            {
                ProductVariation productVariation = lstProductvariation.FirstOrDefault(c => c.ProductId == new Guid(item.productId) && c.ColorId == item.color && c.SizeId == item.size);
                if (productVariation == null) return false;

                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderId = order_id;
                orderDetail.ProductVariationId = productVariation.Id;
                orderDetail.Price = decimal.Parse(item.price.ToString());
                orderDetail.Quantity = item.quantity;
                orderDetail.TotalMoney = decimal.Parse(item.totalMoneyItem.ToString());
                orderDetail.Status = GProject.Data.Enums.OrderDetailStatus.Watting;

                //-- Add vào OrderDetail
                if (!await Commons.Add_or_UpdateAsync(orderDetail, String.Concat(Commons.mylocalhost, "Order/add-Order-detail")))
                    return false;

                //-- Giảm số lượng còn lại của ProductVariation
                productVariation.QuantityInStock = productVariation.QuantityInStock - item.quantity;
                if (!await Commons.Add_or_UpdateAsync(productVariation, String.Concat(Commons.mylocalhost, "ProductVariation/update-ProductVariation")))
                    return false;

            }
            return true;
        }


    }
}
