#pragma checksum "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d09064d94f3e9a17ebea7dced03516eabbd8be95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Detail), @"mvc.1.0.view", @"/Views/Invoice/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using GProject.WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
using GProject.Api.MyServices.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
using GProject.WebApplication.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
using GProject.Data.DomainClass;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09064d94f3e9a17ebea7dced03516eabbd8be95", @"/Views/Invoice/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GProject.WebApplication.Models.OrderDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:70px;height:70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
  
    ViewBag.Title = "Chi tiết hóa đơn";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

    Pager pager = new Pager();
    int pageNo = 0;

    if (ViewBag.Pager != null)
    {
        pager = ViewBag.Pager;
        pageNo = pager.CurrentPage;
    }
    var OrderData = Model.Select(c => c.Order).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    label {
        color: black;
    }

    h1 {
        color: black;
    }

    .sticky-header th {
        position: sticky;
        top: 0px;
        z-index: 1;
        background-color: #E5E5E5;
    }

    .sticky-table {
        border-collapse: separate !important;
    }

</style>

");
#nullable restore
#line 43 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
 if (@ViewData["Mess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 45 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                         Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 46 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""panel panel-default"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"" style=""background-color:#E5E5E5; text-align:center; height:50px; padding:10px 10px 10px 10px;""><i class=""fa fa-users"" aria-hidden=""true"" style=""margin-right:10px;""></i>THÔNG TIN KHÁCH HÀNG</h3>
        </div>
        <div class=""panel-body"">
            <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                <table class=""table table-bordered"">
                    <tr>
                        <th style=""width:300px;"">Thông tin</th>
                        <td><h5><strong>Thông tin liên quan</strong></h5></td>
                    </tr>
                    <tr>
                        <th>Tên khách hàng</th>
                        <td><h5><strong>");
#nullable restore
#line 61 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(OrderData.ShippingFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Email</th>\r\n                        <td><h5><strong>");
#nullable restore
#line 65 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(OrderData.ShippingEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Địa chỉ</th>\r\n                        <td><h5><strong>");
#nullable restore
#line 69 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(OrderData.ShippingAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Ngày đặt</th>\r\n                        <td><h5><strong>");
#nullable restore
#line 73 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(OrderData.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Phí ship</th>\r\n                        <td><h5><strong>");
#nullable restore
#line 77 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(string.Format("{0:0,0} VNĐ", OrderData.ShippingFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Trạng thái</th>\r\n                        <td>\r\n                            <h5>\r\n                                <strong>\r\n");
#nullable restore
#line 84 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                      
                                        switch ((int)OrderData.Status)
                                        {
                                            case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" class=\"btn btn-secondary\">Chờ xác nhận</button>\r\n");
#nullable restore
#line 89 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                            case 6:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" class=\"btn btn-warning\">Đã xác nhận</button>\r\n");
#nullable restore
#line 92 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" class=\"btn btn-info\">Đang vận chuyển</button>\r\n");
#nullable restore
#line 95 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                            case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" class=\"btn btn-primary\">Đang giao hàng</button>\r\n");
#nullable restore
#line 98 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" class=\"btn btn-success\">Đã hoàn thành</button>\r\n");
#nullable restore
#line 101 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                            default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" class=\"btn btn-danger\">Đã hủy</button>\r\n");
#nullable restore
#line 104 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </strong>\r\n                            </h5>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Mô tả</th>\r\n                        <td>");
#nullable restore
#line 113 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                       Write(OrderData.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>
<hr style=""color:red;"" />
<div class=""row"">
    <div class=""panel panel-default"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"" style=""background-color:#E5E5E5; text-align:center; height:50px; padding:10px 10px 10px 10px;""><i class=""fa fa-recycle"" aria-hidden=""true"" style=""margin-right:10px;""></i>DANH SÁCH SẢN PHẨM ĐẶT HÀNG</h3>
        </div>
        <div class=""panel-body"">
            <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                <table class=""table table-bordered table-hover sticky-table"">
                    <thead class=""sticky-header"">
                        <tr>
                            <th>STT</th>
                            <th>Hình ảnh</th>
                            <th>Tên sản phẩm</th>
                            <th>Màu sắc</th>
                            <th>Size</th>
                  ");
            WriteLiteral("          <th>Số lượng</th>\r\n                            <th>Đơn giá</th>\r\n                            <th>Thành tiền</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 142 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                         if (Model != null)
                        {
                            int index = 0;
                            foreach (var item in Model)
                            {
                                index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 149 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                    Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d09064d94f3e9a17ebea7dced03516eabbd8be9515729", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6366, "~/images/", 6366, 9, true);
#nullable restore
#line 150 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
AddHtmlAttributeValue("", 6375, item.ProductVariation.Image.NullToString(), 6375, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 151 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 152 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(item.Color.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 153 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(item.Size.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 154 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(item.OrderDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 155 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(string.Format("{0:0,0} VNĐ", item.OrderDetail.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 156 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(string.Format("{0:0,0} VNĐ", item.OrderDetail.TotalMoney));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 159 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GProject.WebApplication.Models.OrderDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
