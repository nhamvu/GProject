#pragma checksum "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6533286ad12e0e12ecaa0114098b866d06f9ee10"
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
#line 1 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using GProject.WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
using GProject.Api.MyServices.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
using GProject.WebApplication.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
using GProject.Data.DomainClass;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6533286ad12e0e12ecaa0114098b866d06f9ee10", @"/Views/Invoice/Detail.cshtml")]
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
#line 7 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
  
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
#line 43 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
 if (@ViewData["Mess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 45 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                         Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 46 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""panel panel-default"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"" style=""text-align:center; height:50px; padding:10px 10px 10px 10px;"">
                Thông tin đơn hàng
            </h3>
        </div>
        <div class=""panel-body"">
            <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                <table class=""table table-bordered"">
                    <tr>
                        <th style=""width:300px;"">Thông tin</th>
                        <td><label>Thông tin liên quan</label></td>
                    </tr>
                    <tr>
                        <th>Tên khách hàng</th>
                        <td><label>");
#nullable restore
#line 63 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                              Write(OrderData.ShippingFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Email</th>\r\n                        <td><label>");
#nullable restore
#line 67 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                              Write(OrderData.ShippingEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Địa chỉ</th>\r\n                        <td><label>");
#nullable restore
#line 71 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                              Write(OrderData.ShippingAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Ngày đặt</th>\r\n                        <td><label>");
#nullable restore
#line 75 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                              Write(OrderData.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Phí ship</th>\r\n                        <td><label>");
#nullable restore
#line 79 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                              Write(string.Format("{0:0,0} VNĐ", OrderData.ShippingFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Trạng thái</th>\r\n                        <td>\r\n                            <label>\r\n                                \r\n");
#nullable restore
#line 86 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                      
                                        switch ((int)OrderData.Status)
                                        {
                                            case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" disabled class=\"btn btn-secondary\">Chờ xác nhận</button>\r\n");
#nullable restore
#line 91 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                            case 6:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" disabled class=\"btn btn-warning\">Đã xác nhận</button>\r\n");
#nullable restore
#line 94 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" disabled class=\"btn btn-info\">Đang vận chuyển</button>\r\n");
#nullable restore
#line 97 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                            case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" disabled class=\"btn btn-primary\">Đang giao hàng</button>\r\n");
#nullable restore
#line 100 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" disabled class=\"btn btn-success\">Đã hoàn thành</button>\r\n");
#nullable restore
#line 103 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                            default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button type=\"button\" disabled class=\"btn btn-danger\">Đã hủy</button>\r\n");
#nullable restore
#line 106 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                                break;
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \r\n                            </label>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Mô tả</th>\r\n                        <td>");
#nullable restore
#line 115 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
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
            <h3 class=""panel-title"" style=""text-align:center; height:50px; padding:10px 10px 10px 10px;"">
                Danh sách sản phẩm đặt hàng
            </h3>
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
                            <th>Số lượng</th>
                            <th>Đơn giá<");
            WriteLiteral("/th>\r\n                            <th>Thành tiền</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 146 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
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
#line 153 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                    Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6533286ad12e0e12ecaa0114098b866d06f9ee1014672", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6205, "~/images/", 6205, 9, true);
#nullable restore
#line 154 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
AddHtmlAttributeValue("", 6214, item.ProductVariation.Image.NullToString(), 6214, 43, false);

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
#line 155 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 156 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(item.Color.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 157 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(item.Size.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 158 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(item.OrderDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 159 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(string.Format("{0:0,0} VNĐ", item.OrderDetail.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 160 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
                                   Write(string.Format("{0:0,0} VNĐ", item.OrderDetail.TotalMoney));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 163 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Detail.cshtml"
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
