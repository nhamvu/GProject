#pragma checksum "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53256972c15dbe616a1c0cc04771a9a568e94d55"
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
#line 4 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
using GProject.Api.MyServices.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
using GProject.WebApplication.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
using GProject.Data.DomainClass;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53256972c15dbe616a1c0cc04771a9a568e94d55", @"/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<GProject.Data.DomainClass.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Invoice/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
  
    ViewBag.Title = "Danh sách hóa đơn";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

    //Pager pager = new Pager();
    //int pageNo = 0;

    //if (ViewBag.Pager != null)
    //{
    //    pager = ViewBag.Pager;
    //    pageNo = pager.CurrentPage;
    //}
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
#line 43 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
 if (@ViewData["Mess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 45 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                         Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 46 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53256972c15dbe616a1c0cc04771a9a568e94d557511", async() => {
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
                BeginWriteAttribute("value", " value=\"", 1797, "\"", 1823, 1);
#nullable restore
#line 57 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 1805, ViewData["sName"], 1805, 18, false);

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
                BeginWriteAttribute("value", " value=\"", 2212, "\"", 2239, 1);
#nullable restore
#line 63 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 2220, ViewData["sEmail"], 2220, 19, false);

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
                BeginWriteAttribute("value", " value=\"", 2730, "\"", 2757, 1);
#nullable restore
#line 71 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 2738, ViewData["sPhone"], 2738, 19, false);

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
#line 77 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                      
                                        int gender = int.Parse(Html.Encode(ViewData["sPaymentType"]));
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
#nullable restore
#line 80 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
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
                    <button class=""btn btn-success"" onclick=""$('.searchText').removeAttr('disabled')"" type=""submit"">
                        <i class=""fa fa-search""></i>Tìm kiếm
                    </button>
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
#line 122 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                         if (Model != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                             for (int i = 0; i < Model.Count(); i++)
                            {
                                int statusSel = (int)Model[i].Status;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td hidden><input class=\"orderId\" disabled hidden=\"hidden\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5881, "\"", 5914, 1);
#nullable restore
#line 128 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 5889, Model[i].Id.ToString(), 5889, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                                    <td hidden><input class=\"customerId\" disabled hidden=\"hidden\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 6032, "\"", 6073, 1);
#nullable restore
#line 129 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 6040, Model[i].CustomerId.ToString(), 6040, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                                    <td>");
#nullable restore
#line 130 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 131 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                   Write(Model[i].ShippingFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 132 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                   Write(Model[i].ShippingEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 133 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                   Write(Model[i].ShippingPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 134 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                   Write(Model[i].CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 135 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                                   Write(string.Format("{0:0,0} VNĐ", Model[i].TotalMoney));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <button type=""button"" class=""btn btn-success"">Đã hoàn thành</button>
                                    </td>
                                    <td>
                                        <button class=""btn btn-info""");
            BeginWriteAttribute("onclick", " onclick=\"", 6815, "\"", 6897, 3);
            WriteAttributeValue("", 6825, "location.href=\'", 6825, 15, true);
#nullable restore
#line 140 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 6840, Url.Action("Detail", "Invoice",new { id = Model[i].Id}), 6840, 56, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6896, "\'", 6896, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <i class=\"fa fa-eye\"></i>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 144 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n    ");
#nullable restore
#line 153 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Invoice\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page = page }), new X.PagedList.Web.Common.PagedListRenderOptions()
    {
    ActiveLiElementClass = "active",
    PageClasses = new[]{ "page-link"},
    LiElementClasses=new[] { "page-item" },
    //LinkToNextPageFormat = "Next",
    //LinkToPreviousPageFormat = "Prev",
    DisplayLinkToFirstPage = X.PagedList.Web.Common.PagedListDisplayMode.Always,
    DisplayLinkToLastPage = X.PagedList.Web.Common.PagedListDisplayMode.Always,
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<GProject.Data.DomainClass.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
