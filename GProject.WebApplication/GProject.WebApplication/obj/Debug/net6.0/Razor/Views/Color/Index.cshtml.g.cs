#pragma checksum "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a4f39b34e552143a97c910b9553c730c0f576e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Color_Index), @"mvc.1.0.view", @"/Views/Color/Index.cshtml")]
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
#line 4 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
using GProject.Api.MyServices.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a4f39b34e552143a97c910b9553c730c0f576e5", @"/Views/Color/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Color_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<GProject.Data.DomainClass.Color>>
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
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Color/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:120px;height:50px; border;1px solid;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
  
    ViewBag.Title = "Quản lý màu sắc";
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
#line 32 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
     if (@ViewData["Mess"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 34 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                                             Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 35 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
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
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Danh mục</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" onclick=""Clear()""
                        aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a4f39b34e552143a97c910b9553c730c0f576e510616", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 52 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <input id=""Id"" name=""Id"" hidden=""hidden"" />
                        <div class=""form-group"">
                            <label class=""col-md-5"">Mã Màu:</label>
                            <div class=""form-input"">
                                <input id=""HEXCode"" name=""HEXCode"" placeholder=""Hex code (#)"" maxlength=""15""
                                    class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-5"">Tên Màu:</label>
                            <div class=""form-input"">
                                <input id=""Name"" name=""Name"" placeholder=""Color name"" maxlength=""200""
                                    class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-5"">Hình ảnh:</label>
              ");
                WriteLiteral(@"              <div class=""form-input"">
                                <input id=""Image_Upload"" name=""Image_Upload"" type=""file"" multiple
                                    class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label>Trạng thái</label>
                            <div>
                                <select id=""Status"" name=""Status"" class=""form-control"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a4f39b34e552143a97c910b9553c730c0f576e512806", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a4f39b34e552143a97c910b9553c730c0f576e514067", async() => {
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <hr style=\"color:red;\" />\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a4f39b34e552143a97c910b9553c730c0f576e517151", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""panel panel-default"">
                    <div class=""panel-body"">
                        <div class=""row"">
                            <div class=""col-md-4""></div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <div class=""col-12 col-xs-12"">
                                        <input placeholder=""Tìm kiếm theo mã màu..."" id=""sHEXCode"" name=""sHEXCode""");
                BeginWriteAttribute("value", " value=\"", 4557, "\"", 4586, 1);
#nullable restore
#line 109 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
WriteAttributeValue("", 4565, ViewData["sHEXCode"], 4565, 21, false);

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
                                    <div class=""col-12 col-xs-12"">
                                       <input placeholder=""Tìm kiếm theo tên"" id=""sName"" name=""sName""");
                BeginWriteAttribute("value", " value=\"", 5057, "\"", 5083, 1);
#nullable restore
#line 117 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
WriteAttributeValue("", 5065, ViewData["sName"], 5065, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                            class=""form-control"" />
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a4f39b34e552143a97c910b9553c730c0f576e520117", async() => {
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
                <h3 class=""panel-title"" style="" text-align:center; height:50px; padding:10px 10px 10px 10px;""><i
                        class=""fa fa-tachometer"" aria-hidden=""true"" style=""margin-right:10px;""></i>
                    Danh sách màu sắc
                </h3>
            </div>
            <div class=""panel-body"">
                <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                    <table class=""table table-bordered table-hover sticky-table"">
                        <thead class=""sticky-header"">
                            <tr>
                                <th>Mã Màu</th>
                                <th>Tên Màu</th>
                                <th>Hình ảnh</th>
                                <th>Trạng thái</th>
                                <th></th>
                            </tr>
                        </thead>
");
            WriteLiteral("                        <tbody>\r\n");
#nullable restore
#line 165 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                             if (Model != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 171 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                                       Write(item.HEXCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 174 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a4f39b34e552143a97c910b9553c730c0f576e525979", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8187, "~/images/", 8187, 9, true);
#nullable restore
#line 178 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
AddHtmlAttributeValue("", 8196, item.Image, 8196, 11, false);

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
#line 181 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                                        Write(item.Status == 1 ? "Đang sử dụng" : "Không sử dụng");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8571, "\"", 8612, 3);
            WriteAttributeValue("", 8581, "ViewDetailDataColor(\'", 8581, 21, true);
#nullable restore
#line 184 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
WriteAttributeValue("", 8602, item.Id, 8602, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8610, "\')", 8610, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <i class=\"fas fa-pen-square\" aria-hidden=\"true\"></i>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 188 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 188 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-footer\">\r\n                <div style=\"float: right\">\r\n                    ");
#nullable restore
#line 197 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
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

    function validateHEXCode(code) {
        var regex = /^#[a-zA-Z0-9]+$/;
        return regex.test(code);
    }
    document.querySelector('#formdata').addEventListener('submit', function (e) {
        var form = this;

        e.preventDefault();
        if (checkValidateData()) {
        }
    });

    function ViewDetailDataColor(id) {
        $(""#exampleModal"").modal('show');
        $.getJSON(""/Color/Detail?id="" + id");
            WriteLiteral(@", function (data) {
            $(""#Name"").val(data.name);
            $(""#HEXCode"").val(data.hexCode);
            $(""#Id"").val(data.id);
            $(""#Status"").val(data.status);
            $(""#exampleModal"").modal('show');
        });
    }
    function Clear() {
        $(""#Name"").val('');
        $(""#HEXCode"").val('');
        $(""#Id"").val('');
        $(""#Status"").val('');
    }

    function checkValidateData() {
        if ($('#HEXCode').val() == '') {
            sweetAlert(""Thông báo"", ""Thông tin mã màu không được để trống"", ""error"");
            return false;
        }
        if (!validateHEXCode($('#HEXCode').val())) {
            sweetAlert(""Thông báo"", ""Thông tin mã màu không đúng định dạng"", ""error"");
            return false;
        }
        if ($('#Name').val() == '') {
            sweetAlert(""Thông báo"", ""Thông tin tên màu không được để trống"", ""error"");
            return false;
        }
        return true;
    }

    $(document).ready(function () {
  ");
            WriteLiteral(@"      $(""#btnSave"").click(function () {
            if ($('#HEXCode').val() == '') {
                sweetAlert(""Thông báo"", ""Thông tin mã màu không được để trống"", ""error"");
                return false;
            }
            if (!validateHEXCode($('#HEXCode').val())) {
                sweetAlert(""Thông báo"", ""Thông tin mã màu không đúng định dạng"", ""error"");
                return false;
            }
            if ($('#Name').val() == '') {
                sweetAlert(""Thông báo"", ""Thông tin tên màu không được để trống"", ""error"");
                return false;
            }
            var id = $(""#Id"").val();
            var hexcode = $(""#HEXCode"").val();
            var name = $(""#Name"").val();
            var status = $(""#Status"").val();
            var image = $(""#Image_Upload"").get(0).files[0];
            var data = new FormData();
            data.append('Id', id);
            data.append('HEXCode', hexcode);
            data.append('Name', name);
            data.append('S");
            WriteLiteral(@"tatus', status);
            data.append('Image_Upload', image);
            $.ajax({
                url: ""/Color/CheckHEXCode"",
                type: ""POST"",
                data: { HEXCode: hexcode, Id: id },
                success: function (result) {
                    if (result.success) {
                        $.ajax({
                            url: ""/Color/CheckName"",
                            type: ""POST"",
                            data: { Name: name, Id: id },
                            success: function (result) {
                                if (result.success) {
                                    //var data = { Id: id, HEXCode: hexcode, Name: name, Image_Upload: image };
                                    $.ajax({
                                        url: ""/Color/Save"",
                                        type: ""POST"",
                                        data: data,
                                        contentType: false,
                         ");
            WriteLiteral(@"               processData: false,
                                        success: function (result) {
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
                          ");
            WriteLiteral(@"                  }
                                        },
                                        error: function (xhr, status, error) {
                                            alert(error);
                                        }
                                    });
                                } else {
                                    swal(""Lỗi"", ""Tên đã được sử dụng, vui lòng nhập tên khác"", ""error"");
                                }
                            }
                        });
                    }
                    else {
                        swal(""Lỗi"", ""Mã đã được sử dụng, vui lòng nhập mã khác"", ""error"");
                    }
                },
                error: function (xhr, status, error) {
                    alert(error);
                }
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<GProject.Data.DomainClass.Color>> Html { get; private set; }
    }
}
#pragma warning restore 1591
