#pragma checksum "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ffec219aab22b04f7956d8060fca62d2a3f9e99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Promotion_Update), @"mvc.1.0.view", @"/Views/Promotion/Update.cshtml")]
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
#line 3 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
using GProject.WebApplication.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
using GProject.Data.DomainClass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ffec219aab22b04f7956d8060fca62d2a3f9e99", @"/Views/Promotion/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Promotion_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GProject.WebApplication.Models.PromotionDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:0px;height:0px;visibility: hidden;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("hidden", new global::Microsoft.AspNetCore.Html.HtmlString("hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Promotion Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("maxlength", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "datetime-local", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "<?php echo date(\'Y-m-d\'); ?>", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border:double 4px orange;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formdata"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
  
    ViewBag.Title = "Quản lí giảm giá";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    //-- Lấy danh sách sản phẩm
    List<Product> products = (List<Product>)ViewData["ProductList"];

    var lstCategory = await Commons.GetAll<Category>(String.Concat(Commons.mylocalhost, "Category/get-all-Category"));
    IList<SelectListItem> CategoryItems = new List<SelectListItem>();
    if (lstCategory.Count > 0)
    {
        CategoryItems.Add(new SelectListItem()
                {
                    Value = "-1",
                    Text = "-- Danh mục sản phẩm --",
                    Selected = "-1" == Model.CategoryApply.NullToString(),
                });

        foreach (var br in lstCategory)
        {
            CategoryItems.Add(new SelectListItem()
                    {
                        Value = br.Id.ToString(),
                        Text = br.Name,
                        Selected = br.Id.ToString() == Model.CategoryApply.NullToString(),
                    });
        }
    }

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
#line 56 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
 if (@ViewData["Mess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 58 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
                                         Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 59 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ffec219aab22b04f7956d8060fca62d2a3f9e9911840", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ffec219aab22b04f7956d8060fca62d2a3f9e9912134", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 62 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ffec219aab22b04f7956d8060fca62d2a3f9e9913813", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 63 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PromotionId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
#nullable restore
#line 64 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
   Write(Html.Hidden("ProductApply", Model.ProductApply));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 65 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
   Write(Html.Hidden("ImageURl", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label col-sm-5""><strong>Tên chương trình:<span style=""color: red"">(*)</span></strong></label>
                <div class=""col-sm-9"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ffec219aab22b04f7956d8060fca62d2a3f9e9916311", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 70 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PromotionName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label col-sm-5""><strong>Giảm giá theo:<span style=""color: red"">(*)</span></strong></label>
                <div class=""col-md-9"">
                    ");
#nullable restore
#line 78 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
               Write(Html.DropDownList("DiscountPercent", new[]
                    {
                    new SelectListItem{Text="VNĐ", Value="0", Selected = (Model.DiscountPercent != null ? (Model.DiscountPercent == 0) : true)},
                    new SelectListItem{Text="%", Value="1",  Selected = (Model.DiscountPercent != null ? (Model.DiscountPercent == 1) : true)}
                    }, new { @class = "form-control iscompany" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label col-sm-5""><strong>Mức giảm giá:<span style=""color: red"">(*)</span></strong></label>
                <div class=""col-sm-9"">
                    ");
#nullable restore
#line 90 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
               Write(Html.TextBox("DiscountRate", decimal.Parse(Model.DiscountRate.ToString("0.##")), new { @maxlength = "10", @class = "required form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label col-sm-5""><strong>Ngày bắt đầu:<span style=""color: red"">(*)</span></strong></label>
                <div class=""col-sm-9"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ffec219aab22b04f7956d8060fca62d2a3f9e9920107", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 98 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StartDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label col-sm-5""><strong>Ngày kết thúc:<span style=""color: red"">(*)</span></strong></label>
                <div class=""col-sm-9"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ffec219aab22b04f7956d8060fca62d2a3f9e9922538", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 106 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EndDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label col-sm-5""><strong>Loại danh mục:<span style=""color: red"">(*)</span></strong></label>
                <div class=""col-sm-9"">
                    ");
#nullable restore
#line 114 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
               Write(Html.DropDownList("CategoryApply", CategoryItems, new { @maxlength = "30", @class = "searchText form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label class=""control-label col-sm-5""><strong>Trạng thái:<span style=""color: red"">(*)</span></strong></label>
                <div class=""col-md-9"">
                    ");
#nullable restore
#line 122 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
               Write(Html.DropDownList("Status", new[]
                    {
                    new SelectListItem{Text="Chưa diễn ra", Value="0", Selected = (Model.Status != null ? (Model.Status == GProject.Data.Enums.PromotionStatus.Happenning) : true)},
                    new SelectListItem{Text="Đang diễn ra", Value="1", Selected = (Model.Status != null ? (Model.Status == GProject.Data.Enums.PromotionStatus.Happenning) : true)},
                    new SelectListItem{Text="Đã kết thúc", Value="2", Selected = (Model.Status != null ? (Model.Status == GProject.Data.Enums.PromotionStatus.Happend) : true)},
                    }, new { @class = "form-control iscompany" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <label class=""control-label col-sm-5""><strong>Trạng thái:<span style=""color: red"">(*)</span></strong></label>
            <div class=""col-sm-9"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ffec219aab22b04f7956d8060fca62d2a3f9e9926827", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 134 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Image_Upload);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label col-sm-3\"><strong>Mô tả:</strong></label>\r\n        <div class=\"col-sm-12\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ffec219aab22b04f7956d8060fca62d2a3f9e9928858", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 141 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
    </div>

    <h1>DANH SÁCH SẢN PHẨM</h1>
    <div class=""productDetail"">
        <table id=""ProductTable"" class=""col-md-12"">
            <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                
            </div>
        </table>
    </div>

    <button type=""submit"" class=""btn btn-sm btn-success"" id=""cpCopyBtn""><i class=""fa fa-check"" aria-hidden=""true""></i> Lưu thông tin</button>
    <button type=""button"" class=""btn btn-sm btn-dark btn-dimiss-modal"" onclick=""document.location = '/Promotion/index'"">
        <i class=""fa fa-times""></i> Quay lại
    </button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#formdata').hide();
        var er = document.getElementById('error');
        if (er != null) {
            if ($('#error').text() == 'Failed')
                swal(""Không thành công"", ""Vui lòng xem lại thông tin đã nhập"", ""error"");
            else
                swal(""Thành công"", ""Bạn đã lưu thành công thông tin đã nhập"", ""success"");
        }
        $('#ProductTable').load(""/Promotion/ReloadTable?id="" + $(this).val() + ""&price="" + $('#DiscountRate').val() + ""&promotionid="" + $('#Id').val());
    });
    $(""#CategoryApply"").change(function () {
        $('#ProductTable').load(""/Promotion/ReloadTable?id="" + $(this).val() + ""&price="" + $('#DiscountRate').val());
    });
    document.querySelector('#formdata').addEventListener('submit', function (e) {
        var form = this;

        e.preventDefault();
        if (checkValidateData()) {
            swal(""Bạn chắc chắn lưu những thay đổi này?"", {
        ");
            WriteLiteral(@"        title: 'Bạn chắc chắn muốn lưu nhưng thay đổi này?',
                icon: 'info',
                buttons: [""Không, tôi cần xem lại"", ""Có, tôi đồng ý""],
            }).then(function (isConfirm) {
                if (isConfirm) {
                    var products = GetPromotionDetail();
                    $('#ProductApply').val(JSON.stringify(products));
                    form.submit();
                } else {
                    swal(""Đã hủy"", ""Bạn đã không lưu những thay đổi này!"", ""error"");
                }
            });
        }
    });

    function compareDate(date1, date2) {
        if (date1.getFullYear() > date2.getFullYear()) return true;
        if (date1.getFullYear() == date2.getFullYear()) {
            if (date1.getMonth() > date2.getMonth()) return true;
            if (date1.getMonth() == date2.getMonth()) {
                if (date1.getDate() >= date2.getDate()) return true;
                else return false;
            }
            if (date1.getMonth(");
            WriteLiteral(@") < date2.getMonth()) return false;
        }
        if (date1.getFullYear() < date2.getFullYear()) return false;
    }

    function checkValidateData() {
        if ($('#PromotionName').val() == '') {
            sweetAlert(""Thông báo"", ""Thông tin tên chương trình giảm giá không được để trống"", ""error"");
            return false;
        }
        if (($('#DiscountRate').val() || 0) <= 0) {
            sweetAlert(""Thông báo"", ""Mức giảm giá không được bỏ trống"", ""error"");
            return false;
        }
        if (parseInt($('#DiscountPercent').val()) == 1) {
            if (parseFloat($('#DiscountRate').val() || 0) <= 0 || parseFloat($('#DiscountRate').val() || 0) > 100) {
                sweetAlert(""Thông báo"", ""Mức giảm giá không được cao hơn 100%"", ""error"");
                return false;
            }
        }
        var StartDateSplit = $('#StartDate').val().split('/');
        var EndDateSplit = $('#EndDate').val().split('/');
        if (!compareDate(new Date(EndDateSplit");
            WriteLiteral(@"[2] + ""-"" + EndDateSplit[1] + ""-"" + EndDateSplit[0]), new Date(StartDateSplit[2] + ""-"" + StartDateSplit[1] + ""-"" + StartDateSplit[0]))) {
            sweetAlert("""", ""Ngày kết thúc không được nhỏ hơn ngày bắt đầu"", ""error"");
            return false;
        }
        if ($('#ImageURl').val() == '') {
            sweetAlert(""Thông báo"", ""Thông tin hình ảnh không được để trống"", ""error"");
            return false;
        }
        return true;
    }

    function GetPromotionDetail() {
        var length = $('input[name=cbid]:checked').length;

        // Nếu không có checkbox nào được chọn, hiển thị thông báo lỗi
        if (length == 0) {
            swal('Lỗi', 'Bạn chưa chọn sản phẩm', 'error');
            return;
        }

        var products = [];
        $('input[name=cbid]:checked').each(function () {
            var _product = {};
            _product.ProductId = $(this).parents(""tr"").find(""input[type=text].prodId"").val();
            _product.InitialPrice = parseFloat($(thi");
            WriteLiteral(@"s).parents(""tr"").find(""input[type=text].prodPrice"").val()) || 0;

            let cCurrentPrice = 0;
            //Nếu là VNĐ
            if (parseInt($('#DiscountPercent').val()) == 0) {
                cCurrentPrice = _product.InitialPrice - (parseFloat($('#DiscountRate').val()) || 0);
            }//Nếu là %
            else {
                cCurrentPrice = _product.InitialPrice - (_product.InitialPrice * (parseFloat($('#DiscountRate').val()) || 0) / 100);
            }
            _product.CurrentPrice = cCurrentPrice || 0;
            products.push(_product);
        });
        if (products.length == 0) {
            swal('Lỗi', 'Bạn chưa chọn sản phẩm', 'error');
        }

        return products;
    }

    $('#Image_Upload').change(function () {
        var _file = $(this)[0].files[0];
        if (_file) {
            $('#ImageURl').val(_file.name);
        } else {
            $('#ImageURl').val('');
        }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GProject.WebApplication.Models.PromotionDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
