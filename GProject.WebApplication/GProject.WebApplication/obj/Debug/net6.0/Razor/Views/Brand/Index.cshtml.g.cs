#pragma checksum "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355a1f92ad75f270a339bffc0948bc20bcefee5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brand_Index), @"mvc.1.0.view", @"/Views/Brand/Index.cshtml")]
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
#line 4 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
using GProject.Api.MyServices.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355a1f92ad75f270a339bffc0948bc20bcefee5b", @"/Views/Brand/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Brand_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<GProject.Data.DomainClass.Brand>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formdata"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Brand/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
  
    ViewBag.Title = "Quản lý nhãn hiệu";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

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

<div class=""container"">

");
#nullable restore
#line 33 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
     if (@ViewData["Mess"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 35 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                                             Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 36 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    
    <div>
        <button type=""button"" class=""btn btn-success"" onclick=""ShowModal()"">Thêm mới</button>
    </div>
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Nhãn hiệu</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" onclick=""Clear()""
                        aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355a1f92ad75f270a339bffc0948bc20bcefee5b10076", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 51 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <input id=""Id"" name=""Id"" hidden=""hidden"" />
                        <div class=""form-group"">
                            <label class=""col-md-5"">Tên nhãn hiệu:
                            </label>
                            <div class=""form-input"">
                                <input id=""Name"" name=""Name""  maxlength=""200""
                                    class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label>Trạng thái</label>
                            <div>
                                <select id=""Status"" name=""Status"" class=""form-control"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355a1f92ad75f270a339bffc0948bc20bcefee5b11395", async() => {
                    WriteLiteral("Sử dụng");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355a1f92ad75f270a339bffc0948bc20bcefee5b12656", async() => {
                    WriteLiteral("Không sử dụng");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-5"">Mô tả:</label>
                            <div class=""form-input"">
                                <textarea id=""Description"" name=""Description"" class=""form-control""
                                    maxlength=""256""></textarea>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" onclick=""Clear()""
                                data-bs-dismiss=""modal"">Close</button>
                            <button id=""btnSave"" class=""btn btn-success"" type=""submit"">Lưu</button>
                        </div>

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <hr style=\"color:red;\" />\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355a1f92ad75f270a339bffc0948bc20bcefee5b16155", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-12"">
                <div class=""panel panel-default"">
                    <div class=""panel-body"">

                        <div class=""row"">
                            <div class=""col-4""></div>
                            <div class=""col-3"">
                                <div class=""form-group"">
                                    <div class=""col-12 col-xs-12"">
                                        <input placeholder=""Tìm kiếm theo tên..."" id=""sName"" name=""sName""");
                BeginWriteAttribute("value", " value=\"", 4142, "\"", 4168, 1);
#nullable restore
#line 102 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
WriteAttributeValue("", 4150, ViewData["sName"], 4150, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                            class=""form-control"" />
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <div class=""col-12 row"">
                                      
                                        <div class=""col-12"">
");
#nullable restore
#line 112 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                                          
                                            int status = int.Parse(Html.Encode(ViewData["sStatus"]));
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
#nullable restore
#line 115 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                                   Write(Html.DropDownList("sStatus",new[]
                                        {
                                        new SelectListItem{Text="-- Trạng thái --", Value="-1", Selected= (status== -1)},
                                        new SelectListItem{Text="Không sử dụng", Value="0", Selected= (status== 0)},
                                        new SelectListItem{Text="Đang sử dụng", Value="1", Selected= (status == 1)}
                                        }, new { @name = "sStatus", @class="searchText form-control select"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-2"">
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <div class=""col-3"">
                                            <button class=""btn btn-success"" onclick=""$('.searchText').removeAttr('disabled')"" type=""submit"">
                                                <i class=""fa fa-search""></i>
                                            </button>
                                        </div> 
                                        <div class=""col-4"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355a1f92ad75f270a339bffc0948bc20bcefee5b19904", async() => {
                    WriteLiteral("\r\n                                                <i class=\"fas fa-undo-alt\"></i>\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
                            </div>
                        </div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <div class=""row"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title""
                    style="" text-align:center; height:50px; padding:10px 10px 10px 10px;""><i
                        class=""fa fa-tachometer"" aria-hidden=""true"" style=""margin-right:10px;""></i>Danh sách nhãn hiệu
                </h3>
            </div>
            <div class=""panel-body"">
                <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                    <table class=""table table-bordered table-hover sticky-table"">
                        <thead class=""sticky-header"">
                            <tr>
                                <th>Tên nhãn hiệu</th>
                                <th>Lượt tìm kiếm</th>
                                <th>Trạng thái</th>
                                <th>Mô tả</th>
                                <th>Chi tiết</th>
                            </tr>
             ");
            WriteLiteral("           </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 169 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                             if (Model != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 175 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 178 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                                       Write(item.SearchCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 181 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                                        Write(item.Status == 1 ? "Đang sử dụng" : "Không sử dụng");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 184 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8784, "\"", 8823, 3);
            WriteAttributeValue("", 8794, "ViewDetailDataBrand(", 8794, 20, true);
#nullable restore
#line 187 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
WriteAttributeValue("", 8814, item.Id, 8814, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8822, ")", 8822, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fas fa-pen-square\" aria-hidden=\"true\"></i>\r\n                                            </button>\r\n                                            <button class=\"btn btn-danger delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 9065, "\"", 9099, 3);
            WriteAttributeValue("", 9075, "deleteObject(\'", 9075, 14, true);
#nullable restore
#line 190 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
WriteAttributeValue("", 9089, item.Id, 9089, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9097, "\')", 9097, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fas fa-trash-alt\"></i>\r\n                                            </button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 195 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-footer\">\r\n                <div style=\"float: right\">\r\n                    ");
#nullable restore
#line 204 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Brand\Index.cshtml"
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
    function deleteObject(id) {
        $.ajax({
            url: ""/Brand/CheckExistId"",
            data: { ""Id"": id },
            type: ""POST"",
            success: function (result) {
                if (result.success) {

                    swal(""Bạn có muốn xóa thông tin nhãn hiệu này không?"", {
                        title: 'Thông Báo!',
                        icon: 'info',
                        buttons: [""Không, tôi cần xem lại"", ""Có, tôi đồng ý""],
                    }).then(function (isConfirm) {
                        if (isConfirm) {
                            $.ajax({
                        url: ""/Brand/Delete"",
                        data: { ""Id"": id },
                        type: ""POST"",
                        success: function (result) {
                            if (result.success) {
                                swal(""Thành công"", ""Bạn đã xóa ");
            WriteLiteral(@"thành công"", ""success"");

                                setTimeout(function () {
                                    location.reload();
                                }, 2000);
                                Clear()
                            } else {
                                swal(""Thành công!"", ""Bạn đã xóa thành công"", ""success"");
                                setTimeout(function () {
                                    location.reload();
                                }, 2000);
                                Clear()
                            }
                        },
                        error: function (xhr, status, error) {
                            alert(error);
                        }
                    });
                        } else {
                            swal(""Đã hủy"", ""Xóa không thành công!"", ""error"");
                        }
                    });
                } else {
                    swal(""Xin lỗi"", ""Nhãn hiệu này đã được sử d");
            WriteLiteral(@"ụng."", ""error"");
                }
            },
            error: function (xhr, status, error) {
                alert(error);
            }
        });
    }
    $(document).ready(function () {
        
        var er = document.getElementById('error')
        if (er != null) {
            if ($('#error').text() == 'Failed')
                swal(""Không thành công"", ""Vui lòng xem lại thông tin đã nhập"", ""error"");
            else
                swal(""Thành công"", ""Bạn đã lưu thành công thông tin đã nhập"", ""success"");
        }
    });

    function ShowModal() {
        $(""#exampleModal"").modal('show');
    }

    document.querySelector('#formdata').addEventListener('submit', function (e) {
        var form = this;

        e.preventDefault();
        if (checkValidateData()) {
            //swal(""Bạn chắc chắn lưu những thay đổi này?"", {
            //    title: 'Bạn chắc chắn muốn lưu nhưng thay đổi này?',
            //    icon: 'info',
            //    buttons: [""Không");
            WriteLiteral(@", tôi cần xem lại"", ""Có, tôi đồng ý""],
            //}).then(function (isConfirm) {
            //    if (isConfirm) {
            //        form.submit();
            //    } else {
            //        swal(""Đã hủy"", ""Bạn đã không lưu những thay đổi này!"", ""error"");
            //    }
            //});
        }
    });
    function ViewDetailDataBrand(id) {
        $(""#exampleModal"").modal('show');
        $.getJSON(""/Brand/Detail?id="" + id, function (data) {
            $(""#Name"").val(data.name);
            $(""#Description"").val(data.description);
            $(""#Status"").val(data.status);
            $(""#Id"").val(data.id);
        });
    }

    function Clear()
    {
        $(""#Name"").val('');
        $(""#Description"").val('');
        $(""#Status"").val('');
        $(""#Id"").val('');
    }


    function checkValidateData() {
        if ($('#Name').val() == '') {
            sweetAlert(""Thông báo"", ""Thông tin tên không được để trống"", ""error"");
            return false");
            WriteLiteral(@";
        }
        return true;
    }
    $(document).ready(function () {
        $(""#btnSave"").click(function () {
            if ($('#Name').val() == '') {
                sweetAlert(""Thông báo"", ""Thông tin tên nhãn hiệu không được để trống"", ""error"");
                return false;
            }
            var id = $(""#Id"").val();
            var name = $(""#Name"").val();
            var status = $(""#Status"").val();
            var description = $(""#Description"").val();
            $.ajax({
                url: ""/Brand/CheckName"",
                type: ""POST"",
                data: { Name: name, Id: id },
                success: function (result) {
                    if (result.success) {
                        var data = { Id: id, Name: name, Status: status, Description: description };
                        $.ajax({
                            url: ""/Brand/Save"",
                            type: ""POST"",
                            data: data,
                            succ");
            WriteLiteral(@"ess: function (result) {
                                if (result.success) {
                                    swal(""Thành công"", ""Bạn đã lưu thành công thông tin đã nhập"", ""success"");
                                    setTimeout(function () {
                                        location.reload();
                                    }, 2000);
                                    Clear()
                                } else {
                                    swal(""Thành công!"", ""Bạn đã lưu thành công thông tin đã nhập"", ""success"");
                                    setTimeout(function () {
                                        location.reload();
                                    }, 2000);
                                    Clear()
                                }
                            },
                            error: function (xhr, status, error) {
                                alert(error);
                            }
                        });
        ");
            WriteLiteral(@"            } else {
                        swal(""Lỗi"", ""Tên đã được sử dụng, vui lòng nhập tên khác"", ""error"");
                    }
                },
                error: function (xhr, status, error) {
                    alert(error);
                }
            });
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<GProject.Data.DomainClass.Brand>> Html { get; private set; }
    }
}
#pragma warning restore 1591
