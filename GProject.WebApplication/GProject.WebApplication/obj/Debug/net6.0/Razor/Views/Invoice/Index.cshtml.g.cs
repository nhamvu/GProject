#pragma checksum "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24d3de12efcaa36870ebc07dcdd8d25e957e4244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index), @"mvc.1.0.view", @"/Views/Invoice/Index.cshtml")]
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
#line 1 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using GProject.WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
using GProject.Api.MyServices.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
using GProject.WebApplication.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
using GProject.Data.DomainClass;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24d3de12efcaa36870ebc07dcdd8d25e957e4244", @"/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b08ccb6f7db288cae79c4c47cdc6330c880c5d3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GProject.WebApplication.Models.OrderDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Invoice/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pg", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
  
    ViewBag.Title = "Danh sách hóa đơn";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

    Pager pager = new Pager();
    int pageNo = 0;

    if (ViewBag.Pager != null)
    {
        pager = ViewBag.Pager;
        pageNo = pager.CurrentPage;
    }
    var lstOrderDetail = await Commons.GetAll<OrderDetail>(String.Concat(Commons.mylocalhost, "Order/get-all-Order-detail"));

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
#line 42 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
 if (@ViewData["Mess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 44 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                         Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24d3de12efcaa36870ebc07dcdd8d25e957e42448976", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""panel panel-default"">
                <div class=""panel-body"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""col-md-3 control-label"">Tên khách hàng</label>
                                <div class=""col-md-9 col-xs-12"">
                                    <input type=""text"" id=""sName"" name=""sName""");
                BeginWriteAttribute("value", " value=\"", 1715, "\"", 1741, 1);
#nullable restore
#line 56 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 1723, ViewData["sName"], 1723, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-md-3 control-label"">Email</label>
                                <div class=""col-md-9 col-xs-12"">
                                    <input type=""email"" id=""sEmail"" name=""sEmail""");
                BeginWriteAttribute("value", " value=\"", 2130, "\"", 2157, 1);
#nullable restore
#line 62 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 2138, ViewData["sEmail"], 2138, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-6"">
                            <div class=""form-group"">
                                <label class=""col-md-3 control-label"">Số điện thoại</label>
                                <div class=""col-md-9 col-xs-12"">
                                    <input type=""text"" id=""sPhone"" maxlength=""10"" name=""sPhone""");
                BeginWriteAttribute("value", " value=\"", 2648, "\"", 2675, 1);
#nullable restore
#line 70 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 2656, ViewData["sPhone"], 2656, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-md-3 control-label"">Hình thức thanh toán</label>
                                <div class=""col-md-9"">
");
#nullable restore
#line 76 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                      
                                        int gender = int.Parse(Html.Encode(ViewData["sPaymentType"]));
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
#nullable restore
#line 79 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                               Write(Html.DropDownList("sPaymentType",new[]
                                    {
                                    new SelectListItem{Text="-- Tất cả--", Value="-1", Selected= (gender== -1)},
                                    new SelectListItem{Text="Thanh toán khi nhận hàng", Value="0", Selected= (gender== 0)},
                                    new SelectListItem{Text="Thanh toán ngay khi đặt hàng", Value="1", Selected=  (gender == 1)}
                                    }, new { @name = "sPaymentType", @class="searchText form-control select"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""panel-footer text-center"">
                    <button class=""btn btn-success"" onclick=""$('.searchText').removeAttr('disabled')"" type=""submit""><i class=""fa fa-search""></i>Tìm kiếm</button>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<hr style=""color:red;"" />
<div class=""row"">
    <div class=""panel panel-default"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"" style=""background-color:#E5E5E5; text-align:center; height:50px; padding:10px 10px 10px 10px;""><i class=""fa fa-users"" aria-hidden=""true"" style=""margin-right:10px;""></i>DANH SÁCH ĐƠN ĐẶT HÀNG</h3>
        </div>
        <div class=""panel-body"">
            <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                <table class=""table table-bordered table-hover sticky-table"">
                    <thead class=""sticky-header"">
                        <tr>
                            <th>STT</th>
                            <th>Tên khách hàng</th>
                            <th>Email</th>
                            <th>Số điện thoại</th>
                            <th>Ngày đặt hàng</th>
                            <th>Tổng tiền</th>
                            <th>Trạng thái</th>
                            ");
            WriteLiteral("<th>Xem chi tiết</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 119 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                         if (Model.Orders != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                             for (int i = 0; i < Model.Orders.Count(); i++)
                            {
                                int statusSel = (int)Model.Orders[i].Status;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td hidden><input class=\"orderId\" disabled hidden=\"hidden\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5772, "\"", 5812, 1);
#nullable restore
#line 125 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 5780, Model.Orders[i].Id.ToString(), 5780, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                                    <td hidden><input class=\"customerId\" disabled hidden=\"hidden\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5930, "\"", 5978, 1);
#nullable restore
#line 126 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 5938, Model.Orders[i].CustomerId.ToString(), 5938, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                                    <td>");
#nullable restore
#line 127 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 128 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                   Write(Model.Orders[i].ShippingFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 129 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                   Write(Model.Orders[i].ShippingEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 130 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                   Write(Model.Orders[i].ShippingPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 131 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                   Write(Model.Orders[i].CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 132 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                   Write(string.Format("{0:0,0} VNĐ", Model.Orders[i].TotalMoney));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <button type=""button"" class=""btn btn-success"">Đã hoàn thành</button>
                                    </td>
                                    <td>
                                        <button class=""btn btn-info""");
            BeginWriteAttribute("onclick", " onclick=\"", 6755, "\"", 6844, 3);
            WriteAttributeValue("", 6765, "location.href=\'", 6765, 15, true);
#nullable restore
#line 137 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 6780, Url.Action("Detail", "Invoice",new { id = Model.Orders[i].Id}), 6780, 63, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6843, "\'", 6843, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <i class=\"fa fa-eye\"></i>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 141 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n");
#nullable restore
#line 150 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
     if (pager.TotalPages > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"pagination justify-content-end\">\r\n            <li class=\"page-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24d3de12efcaa36870ebc07dcdd8d25e957e424422952", async() => {
                WriteLiteral("First");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pg", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"] = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n            <li class=\"page-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24d3de12efcaa36870ebc07dcdd8d25e957e424424983", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pg", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 157 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                                                                    WriteLiteral(pager.CurrentPage - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pg", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n\r\n");
#nullable restore
#line 160 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
             for (int pge = pager.StartPage; pge < pager.EndPage; pge++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 7750, "\"", 7811, 2);
            WriteAttributeValue("", 7758, "page-item", 7758, 9, true);
#nullable restore
#line 162 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue(" ", 7767, pge == pager.CurrentPage ? "active" : "", 7768, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24d3de12efcaa36870ebc07dcdd8d25e957e424428432", async() => {
                WriteLiteral(" ");
#nullable restore
#line 163 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                                                                                     Write(pge);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pg", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 163 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                                                                       WriteLiteral(pge);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pg", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 165 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <li class=\"page-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24d3de12efcaa36870ebc07dcdd8d25e957e424431609", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pg", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 168 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                                                                    WriteLiteral(pager.CurrentPage + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pg", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n            <li class=\"page-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24d3de12efcaa36870ebc07dcdd8d25e957e424434226", async() => {
                WriteLiteral("Last");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pg", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 171 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                                                                    WriteLiteral(pager.TotalPages);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pg", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n");
#nullable restore
#line 174 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GProject.WebApplication.Models.OrderDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
