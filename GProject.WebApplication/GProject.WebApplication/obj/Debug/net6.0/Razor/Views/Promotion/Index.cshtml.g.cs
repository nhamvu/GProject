#pragma checksum "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3553ce0a3bb3056f1325a18fffef120cf279cd4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Promotion_Index), @"mvc.1.0.view", @"/Views/Promotion/Index.cshtml")]
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
#line 1 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using GProject.WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
using GProject.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
using GProject.WebApplication.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3553ce0a3bb3056f1325a18fffef120cf279cd4d", @"/Views/Promotion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Promotion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<GProject.Data.DomainClass.Promotion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Promotion/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:120px;height:50px; border;1px solid;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
  
    ViewBag.Title = "Quản lý giảm giá";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

    Pager pager = new Pager();
    int pageNo = 0;

    if (ViewBag.Pager != null)
    {
        pager = ViewBag.Pager;
        pageNo = pager.CurrentPage;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    label {
        color: black;
        text-align: right;
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

<div class=""container"">
");
#nullable restore
#line 43 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
     if (@ViewData["Mess"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 45 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                             Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 46 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1037, "\"", 1097, 3);
            WriteAttributeValue("", 1047, "location.href=\'", 1047, 15, true);
#nullable restore
#line 47 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 1062, Url.Action("Create", "Promotion"), 1062, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1096, "\'", 1096, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\"><i\r\n            class=\"fa fa-plus\" aria-hidden=\"true\"></i>Thêm mới</button>\r\n    <button class=\"btn btn-secondary \" id=\"changeformsearch\" type=\"button\" onclick=\"ChangeSearch()\">Tìm kiếm</button>\r\n    <hr style=\"color:red;\" />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3553ce0a3bb3056f1325a18fffef120cf279cd4d9422", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""panel panel-default"">
                    <div class=""panel-body"">
                        <div class=""row"">
                            <div class=""col-4"">
                                <div class=""form-group"">
                                    <label");
                BeginWriteAttribute("class", " class=\"", 1803, "\"", 1811, 0);
                EndWriteAttribute();
                WriteLiteral(">Mã giảm giá</label>\r\n                                    <div class=\"col-md-9 col-xs-12\">\r\n                                        <input id=\"sId\" name=\"sId\"");
                BeginWriteAttribute("value", " value=\"", 1970, "\"", 1994, 1);
#nullable restore
#line 61 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 1978, ViewData["sId"], 1978, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label>Tên</label>
                                    <div class=""col-md-9"">
                                        <input type=""text"" id=""sName"" name=""sName""");
                BeginWriteAttribute("value", " value=\"", 2361, "\"", 2387, 1);
#nullable restore
#line 67 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 2369, ViewData["sName"], 2369, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                            class=""form-control"" />
                                    </div>
                                </div>
                            </div>
                            <div class=""col-4"">
                                <div class=""form-group"">
                                    <label>Giảm giá từ:</label>
                                    <div class=""col-9"">
                                        <input type=""text"" id=""sfromDiscountRate"" maxlength=""10"" name=""sPhone""");
                BeginWriteAttribute("value", "\r\n                                            value=\"", 2918, "\"", 3001, 1);
#nullable restore
#line 77 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 2971, ViewData["sfromDiscountRate"], 2971, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label>Trạng thái</label>
                                    <div class=""col-md-9"">
");
#nullable restore
#line 83 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                          
                                            int status = int.Parse(Html.Encode(ViewData["sStatus"]));
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
#nullable restore
#line 86 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                   Write(Html.DropDownList("sStatus",new[]
                                        {
                                        new SelectListItem{Text="-- Tất cả--", Value="-1", Selected= (status== -1)},
                                        new SelectListItem{Text="Chưa diễn ra", Value="0", Selected= (status== 0)},
                                        new SelectListItem{Text="Đang diễn ra", Value="1", Selected= (status == 1)},
                                        new SelectListItem{Text="Đã kết thúc", Value="1", Selected= (status == 2)}
                                        }, new { @name = "sStatus", @class="searchText form-control select"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""col-4"">
                                <div class=""form-group"">
                                    <label>đến:</label>
                                    <div class=""col-9"">
                                        <input type=""text"" id=""stoDiscountRate"" maxlength=""10"" name=""sPhone""");
                BeginWriteAttribute("value", "\r\n                                            value=\"", 4631, "\"", 4712, 1);
#nullable restore
#line 101 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 4684, ViewData["stoDiscountRate"], 4684, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label>Giảm giá theo</label>
                                    <div class=""col-9"">
");
#nullable restore
#line 107 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                          
                                            int percent = int.Parse(Html.Encode(ViewData["sPercent"]));
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
#nullable restore
#line 110 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                   Write(Html.DropDownList("sPercent",new[]
                                        {
                                        new SelectListItem{Text="-- Tất cả--", Value="-1", Selected= (percent== -1)},
                                        new SelectListItem{Text="Theo VNĐ", Value="0", Selected= (percent== 0)},
                                        new SelectListItem{Text="Theo %", Value="1", Selected= (percent == 1)}
                                        }, new { @name = "sPercent", @class="searchText form-control select"}));

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
                        <button class=""btn btn-success"" onclick=""$('.searchText').removeAttr('disabled')""
                            type=""submit""><i class=""fa fa-search""></i></button>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3553ce0a3bb3056f1325a18fffef120cf279cd4d17066", async() => {
                    WriteLiteral("\r\n                            <i class=\"fas fa-undo-alt\"></i>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <div class=""row"" style=""margin-top: 10px;"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"" style="" text-align:center; height:50px; padding:10px 10px 10px 10px;"">Danh sách
                    giảm giá</h3>
            </div>
            <div class=""panel-body"">
                <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                    <table class=""table table-bordered table-hover sticky-table"">
                        <thead class=""sticky-header"">
                            <tr>
                                <th style=""width: 35px;"">STT</th>
                                <th>Hình ảnh</th>
                                <th>Mã</th>
                                <th>Tên</th>
                                <th>Đơn vị</th>
                                <th>Mức giảm giá</th>
                                <th>Ngày bắt đầu</th>
                                <th>Ngày");
            WriteLiteral(" kết thúc</th>\r\n                                <th>Trạng thái</th>\r\n                                <th>Sửa</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 157 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                             if (Model != null)
                            {
                                int i = 1;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 163 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3553ce0a3bb3056f1325a18fffef120cf279cd4d22481", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8245, "~/images/", 8245, 9, true);
#nullable restore
#line 166 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
AddHtmlAttributeValue("", 8254, item.Image, 8254, 11, false);

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
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 169 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                       Write(item.PromotionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 172 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                       Write(item.PromotionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 175 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                        Write(item.DiscountPercent == 0 ? "VNĐ" : "%");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 178 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                       Write(string.Format("{0:0,0}", item.DiscountRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 181 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                       Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 184 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                       Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 187 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                       Write(Commons.GetEnumDescription(item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", "\r\n                                                onclick=\"", 9599, "\"", 9728, 3);
            WriteAttributeValue("", 9658, "location.href=\'", 9658, 15, true);
#nullable restore
#line 191 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
WriteAttributeValue("", 9673, Url.Action("Update", "Promotion",new { id = item.Id}), 9673, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9727, "\'", 9727, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <i class=\"fas fa-pen-square\"></i>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 195 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                    i++;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 196 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel-footer\">\r\n                <div style=\"float: right\">\r\n                    ");
#nullable restore
#line 204 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Promotion\Index.cshtml"
               Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page = page }), new
                    X.PagedList.Web.Common.PagedListRenderOptions()
                    {
                    ActiveLiElementClass = "active",
                    PageClasses = new[]{ "page-link"},
                    LiElementClasses=new[] { "page-item" },
                    LinkToNextPageFormat = "Next",
                    LinkToPreviousPageFormat = "Prev",
                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>


<script type=""text/javascript"">
    $(document).ready(function () {
        
    
        if( $(""#sId"").val() != '' ||
            $(""#sName"").val() != '' ||
            $(""#sfromDiscountRate"").val() != ''||
            $(""#stoDiscountRate"").val() != ''
        )
        {
            $('#searchForm').show();
        }
        else{
            $('#searchForm').hide();
        }
        var er = document.getElementById('error')
        if (er != null) {
            if ($('#error').text() == 'Failed')
                swal(""Không thành công"", ""Vui lòng xem lại thông tin đã nhập"", ""error"");
            else
                swal(""Thành công"", ""Bạn đã lưu thành công thông tin đã nhập"", ""success"");
        }

        $('#sfromDiscountRate, #stoDiscountRate').keyup(function () {
            let regex = /^[0-9]+$/;
            if (!regex.test($(this).val()))
                $(this).val($(this).val().replace");
            WriteLiteral(@"(/[^0-9.]/g, """"));
        });
    });

    function ChangeSearch() {
        if ($(""#changeformsearch"").text() == ""Tìm kiếm"") {
            $('#searchForm').show();
            //$(""#ExpirationDate"").val(new Date().toJSON().slice(0,19));
            $(""#changeformsearch"").text(""Hủy tìm kiếm"");
        } else if ($(""#changeformsearch"").text() == ""Hủy tìm kiếm"") {
            $('#searchForm').hide();
            $(""#changeformsearch"").text(""Tìm kiếm"");
        }
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<GProject.Data.DomainClass.Promotion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
