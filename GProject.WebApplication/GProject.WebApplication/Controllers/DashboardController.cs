using GProject.Api.MyServices.IServices;
using GProject.Api.MyServices.Services;
using GProject.Data.DomainClass;
using GProject.WebApplication.Helpers;
using GProject.WebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace GProject.WebApplication.Controllers
{
    [GProject.WebApplication.Services.Authorize]
    public class DashboardController : Controller
    {
        private IColorService iColorService;
        public DashboardController()
        {
            iColorService = new ColorService();
        }

        public async Task<ActionResult> Index(string fromDate, string toDate)
        {
            try
            {
                var lstOrders = await Commons.GetAll<Order>(String.Concat(Commons.mylocalhost, "Order/get-all-Order"));
                var lstOrderDetail = await Commons.GetAll<OrderDetail>(String.Concat(Commons.mylocalhost, "Order/get-all-Order-detail"));
                var lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
                var lstProducts = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "ProductMGR/get-all-Product-mgr"));
                var lstEvaluate = await Commons.GetAll<Evaluate>(String.Concat(Commons.mylocalhost, "Evaluate/get-all-Evaluate"));
                var lstCustomer = await Commons.GetAll<Customer>(String.Concat(Commons.mylocalhost, "Customer/get-all-Customer"));
                var lstEmployee = await Commons.GetAll<Employee>(String.Concat(Commons.mylocalhost, "Employee/get-all-Employee"));
                var lstCategories = await Commons.GetAll<Category>(String.Concat(Commons.mylocalhost, "Category/get-all-Category"));

                //--Thông kê lợi nhuận = Tổng doanh thu - tổng chi phí
                var results = lstOrders
                                .Join(lstOrderDetail, b => b.Id, bhct => bhct.OrderId, (b, bhct) => new { Order = b, OrderDetail = bhct })
                                .Join(lstProductvariation, ab => ab.OrderDetail.ProductVariationId, s => s.Id, (ab, s) => new { ab.Order, ab.OrderDetail, Productvariation = s })
                                .Join(lstProducts, abs => abs.Productvariation.ProductId, p => p.Id, (abs, p) => new { abs.Order, abs.OrderDetail, abs.Productvariation, Product = p })
                                .Where(absp => absp.Order.PaymentDate != null && absp.Productvariation.Id == absp.OrderDetail.ProductVariationId)
                                .OrderBy(absp => absp.Order.CreateDate)
                                .GroupBy(absp => new { absp.Order.CreateDate.Date })
                                .Select(g => new
                                {
                                    Day = g.Key.Date,
                                    TongDonHang = g.Count(),
                                    TongThanhTien = g.Sum(c => c.OrderDetail.Quantity * c.OrderDetail.Price),
                                    TongChiPhi = Convert.ToDouble(g.Sum(c => c.OrderDetail.Quantity * getTotalCost(c.Productvariation.Id).Result)),
                                    TongLoiNhuan = g.Sum(c => c.OrderDetail.Quantity * c.OrderDetail.Price) - g.Sum(c => c.OrderDetail.Quantity * getTotalCost(c.Productvariation.Id).Result)
                                })
                                .ToList();

                //-- Thống kê theo danh mục sản phẩm
                var resultsCategoryStatical = lstOrders
                            .Join(lstOrderDetail, b => b.Id, bhct => bhct.OrderId, (b, bhct) => new { Order = b, OrderDetail = bhct })
                            .Join(lstProductvariation, ab => ab.OrderDetail.ProductVariationId, s => s.Id, (ab, s) => new { ab.Order, ab.OrderDetail, Productvariation = s })
                            .Join(lstProducts, abs => abs.Productvariation.ProductId, p => p.Id, (abs, p) => new { abs.Order, abs.OrderDetail, abs.Productvariation, Product = p })
                            .Where(absp => absp.Order.PaymentDate != null && absp.Productvariation.Id == absp.OrderDetail.ProductVariationId)
                            .OrderBy(absp => absp.Order.CreateDate)
                            .GroupBy(absp => new { absp.Product.CategoryId })
                            .Select(g => new
                            {
                                CategoryName = lstCategories.FirstOrDefault(x => x.Id == g.Key.CategoryId)?.Name ?? "",
                                TotalRevenue = g.Sum(c => c.OrderDetail.Quantity * c.OrderDetail.Price)
                            })
                            .ToList();

                //--Thống kê của Nhân Viên
                var resultsEmployeeStatical = lstOrders
                                .Join(lstOrderDetail, b => b.Id, bhct => bhct.OrderId, (b, bhct) => new { b, bhct })
                                .Join(lstEmployee, x => x.b.EmployeeId, s => s.Id, (x, s) => new { x.b, x.bhct, s })
                                .OrderBy(x => x.b.CreateDate)
                                .GroupBy(x => new
                                {
                                    x.s.EmployeeId,
                                    x.s.Name,
                                    x.s.PhoneNumber,
                                    x.s.Sex,
                                    x.b.CreateDate.Month,
                                })
                                .Select(g => new
                                {
                                    Employee_Id = g.Key.EmployeeId,
                                    Employee_Name = g.Key.Name,
                                    Phone_Number = g.Key.PhoneNumber,
                                    Sex = g.Key.Sex,
                                    Day = g.Key.Month,
                                    Total_Quantity = g.Count(),
                                    Total_Revenue = g.Sum(c => c.bhct.Quantity * c.bhct.Price),
                                    Total_number_Sales = g.Sum(c => c.bhct.Quantity)
                                })
                                .ToList();

                //-- Số đơn hàng
                var OrderDataStatical = lstOrders.Join(lstOrderDetail, x => x.Id, y => y.OrderId, (x, y) => new { Order = x, OrderDetail = y }).ToList();

                //-- Lọc
                if (!string.IsNullOrEmpty(fromDate))
                {
                    OrderDataStatical = OrderDataStatical.Where(c => c.Order.CreateDate >= DateTime.Parse(fromDate)).ToList();
                    resultsEmployeeStatical = resultsEmployeeStatical.Where(c => c.Day >= DateTime.Parse(fromDate).Month).ToList();
                    results = results.Where(c => c.Day >= DateTime.Parse(fromDate)).ToList();
                    lstEvaluate = lstEvaluate.Where(c => c.CreateDate >= DateTime.Parse(fromDate)).ToList();
                    lstProducts = lstProducts.Where(c => c.CreateDate >= DateTime.Parse(fromDate)).ToList();
                    lstCustomer = lstCustomer.Where(c => c.CreateDate >= DateTime.Parse(fromDate)).ToList();
                }
                if (!string.IsNullOrEmpty(toDate))
                {
                    OrderDataStatical = OrderDataStatical.Where(c => c.Order.CreateDate <= DateTime.Parse(toDate)).ToList();
                    resultsEmployeeStatical = resultsEmployeeStatical.Where(c => c.Day <= DateTime.Parse(fromDate).Month).ToList();
                    results = results.Where(c => c.Day <= DateTime.Parse(toDate)).ToList();
                    lstEvaluate = lstEvaluate.Where(c => c.CreateDate <= DateTime.Parse(toDate)).ToList();
                    lstProducts = lstProducts.Where(c => c.CreateDate <= DateTime.Parse(toDate)).ToList();
                    lstCustomer = lstCustomer.Where(c => c.CreateDate <= DateTime.Parse(toDate)).ToList();
                }
                ViewBag.CountOrder = OrderDataStatical.Select(c => c.Order).ToList().Count();
                ViewBag.CountProduct = OrderDataStatical.Sum(c => c.OrderDetail.Quantity);
                ViewBag.CountEvaluate = lstEvaluate.Count();
                ViewBag.CountLike = lstProducts.Sum(c => c.LikeCount);
                ViewBag.CountView = lstProducts.Sum(c => c.ViewCount);
                ViewBag.CountCustomer = lstCustomer.Count();

                this.ViewData[nameof(fromDate)] = (object)fromDate;
                this.ViewData[nameof(toDate)] = (object)toDate;

                this.ViewData["EmployeeStatical"] = Commons.ConverObject<List<EmployeeStaticalDTO>>(resultsEmployeeStatical);
                this.ViewData["CategoryStatical"] = Commons.ConverObject<List<CategoryStaticalDTP>>(resultsCategoryStatical);
                return View(Commons.ConverObject<List<MyChartData>>(results));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return RedirectToAction("AccessDenied", "Account");
            }
        }

        public async Task<decimal> getTotalCost(Guid? productVariatinId)
        {
            var lstProductvariation = await Commons.GetAll<ProductVariation>(String.Concat(Commons.mylocalhost, "ProductVariation/get-all-ProductVariation"));
            var lstProducts = await Commons.GetAll<Product>(String.Concat(Commons.mylocalhost, "ProductMGR/get-all-Product-mgr"));

            return lstProducts.Join(lstProductvariation, x => x.Id, y => y.ProductId, (x, y) => new { Product = x, Variation = y })
                           .Where(xy => xy.Variation.Id == productVariatinId)
                           .Select(xy => xy.Product.ImportPrice)
                           .FirstOrDefault().NullToDecimal();
        }
    }
}
