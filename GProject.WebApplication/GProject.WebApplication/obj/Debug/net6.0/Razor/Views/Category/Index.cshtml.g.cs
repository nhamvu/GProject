#pragma checksum "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "090e77f004a407f1d0888e511fa76cfb04a03f32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using GProject.WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
using GProject.Api.MyServices.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090e77f004a407f1d0888e511fa76cfb04a03f32", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<GProject.Data.DomainClass.Category>>
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
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Category/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
  
    ViewBag.Title = "Quản lý danh mục sản phẩm";
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
#line 33 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
     if (@ViewData["Mess"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 35 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                                             Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 36 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "090e77f004a407f1d0888e511fa76cfb04a03f3210316", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 51 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <input id=""Id"" name=""Id"" hidden=""hidden"" />
                        <div class=""form-group"">
                            <label class=""col-md-5"">Tên danh mục:</label>
                            <div class=""form-input"">
                                <input id=""Name"" name=""Name"" class=""form-control"" maxlength=""200"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label>Trạng thái</label>
                            <div>
                                <select id=""Status"" name=""Status"" class=""form-control"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "090e77f004a407f1d0888e511fa76cfb04a03f3211591", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "090e77f004a407f1d0888e511fa76cfb04a03f3212852", async() => {
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <hr style=\"color:red;\" />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "090e77f004a407f1d0888e511fa76cfb04a03f3216347", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""panel panel-default"">
                    <div class=""panel-body"">
                        <div class=""row"">
                            <div class=""col-md-5""></div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <div class=""col-12 col-xs-12"">
                                        <input id=""sName"" name=""sName""");
                BeginWriteAttribute("value", " value=\"", 4055, "\"", 4081, 1);
#nullable restore
#line 98 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
WriteAttributeValue("", 4063, ViewData["sName"], 4063, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                            placeholder=""Tìm kiếm theo tên..."" class=""form-control"" />
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-2"">
                                <div class=""form-group"">
                                    <div class=""col-12 col-xs-12"">
");
#nullable restore
#line 106 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                                          
                                            int status = int.Parse(Html.Encode(ViewData["sStatus"]));
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
#nullable restore
#line 109 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                                   Write(Html.DropDownList("sStatus",new[]
                                        {
                                        new SelectListItem{Text="-- Tất cả--", Value="-1", Selected= (status== -1)},
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


                            <div class=""col-2"">
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <div class=""col-3"">
                                            <button class=""btn btn-success""
                                                onclick=""$('.searchText').removeAttr('disabled')"" type=""submit""><i
                                                    class=""fa fa-search""></i></button>
                                        </div>
                                        <div class=""col-6"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "090e77f004a407f1d0888e511fa76cfb04a03f3220035", async() => {
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
                        class=""fa fa-tachometer"" aria-hidden=""true"" style=""margin-right:10px;""></i>Danh sách danh mục
                </h3>
            </div>
            <div class=""panel-body"">
                <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                    <table class=""table table-bordered table-hover sticky-table"">
                        <thead class=""sticky-header"">
                            <tr>
                                <th>Tên danh mục</th>
                                <th>Trạng thái</th>
                                <th>Mô tả</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 161 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                             if (Model != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 167 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 170 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                                        Write(item.Status == 1 ? "Đang sử dụng" : "Không sử dụng");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 173 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8342, "\"", 8378, 3);
            WriteAttributeValue("", 8352, "ViewDetailData(\'", 8352, 16, true);
#nullable restore
#line 176 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
WriteAttributeValue("", 8368, item.Id, 8368, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8376, "\')", 8376, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fas fa-pen-square\" aria-hidden=\"true\"></i>\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 181 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 181 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-footer\">\r\n                <div style=\"float: right\">\r\n                    ");
#nullable restore
#line 190 "C:\Users\Admin\Documents\GProject\GProject.WebApplication\GProject.WebApplication\Views\Category\Index.cshtml"
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

        $(""#btnSave"").click(function () {
            if ($('#Name').val() == '') {
                sweetAlert(""Thông báo"", ""Thông tin tên danh mục không được để trống"", ""error"");
                return false;
            }
            var id = $(""#Id"").val();
            var name = $(""#Name"").val();
            var status = $(""#Status"").val();
            var description = $(""#Description"").val();

            $.ajax({
                url: ""/Category/CheckName"",
                type: ""POST"",
                da");
            WriteLiteral(@"ta: { Name: name, Id: id },
                success: function (result) {
                    if (result.success) {
                        var data = { Id: id, Name: name, Status: status, Description: description };
                        $.ajax({
                            url: ""/Category/Save"",
                            type: ""POST"",
                            data: data,
                            success: function (result) {
                                if (result.success) {
                                    // Thành công, làm gì đó ở đây
                                    swal(""Thành công"", ""Bạn đã lưu thành công thông tin đã nhập"", ""success"");

                                    setTimeout(function () {
                                        location.reload();
                                    }, 2000);
                                    Clear()
                                } else {
                                    // Lỗi, hiển thị thông báo lỗi
                ");
            WriteLiteral(@"                    swal(""Thành công!"", ""Bạn đã lưu thành công thông tin đã nhập"", ""success"");
                                    setTimeout(function () {
                                        location.reload();
                                    }, 2000);
                                    Clear()
                                }
                            },
                            error: function (xhr, status, error) {
                                // Lỗi, hiển thị thông báo lỗi
                                alert(error);
                            }
                        });
                    } else {
                        // Tên đã được sử dụng, hiển thị thông báo lỗi
                        swal(""Lỗi"", ""Tên đã được sử dụng, vui lòng nhập tên khác"", ""error"");
                    }
                },
                error: function (xhr, status, error) {
                    // Lỗi, hiển thị thông báo lỗi
                    alert(error);
                }
       ");
            WriteLiteral(@"     });
        });

        document.querySelector('#formdata').addEventListener('submit', function (e) {
            var form = this;

            e.preventDefault();
            if (checkValidateData()) {
                swal(""Bạn chắc chắn lưu những thay đổi này?"", {
                    title: 'Bạn chắc chắn muốn lưu nhưng thay đổi này?',
                    icon: 'info',
                    buttons: [""Không, tôi cần xem lại"", ""Có, tôi đồng ý""],
                }).then(function (isConfirm) {
                    if (isConfirm) {
                        form.submit();
                    } else {
                        swal(""Đã hủy"", ""Bạn đã không lưu những thay đổi này!"", ""error"");
                    }
                });
            }
        });

    });

    function ShowModal() {
        $(""#exampleModal"").modal('show');
    }

    function ViewDetailData(_id) {
        $(""#exampleModal"").modal('show');
        $.getJSON(""/Category/Detail?id="" + _id, function (data) {
");
            WriteLiteral(@"            $(""#Name"").val(data.name);
            $(""#Id"").val(data.id);
            $(""#Status"").val(data.status);
            $(""#Description"").val(data.description);
            ChangePanel()

        });
    }

    function Clear() {
        $(""#Name"").val('');
        $(""#Id"").val('');
        $(""#Status"").val(1);
        $(""#Description"").val('');
    }



    function checkValidateData() {
        if ($('#Name').val() == '') {
            sweetAlert(""Thông báo"", ""Thông tin tên màu không được để trống"", ""error"");
            return false;
        }
        return true;
    }


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<GProject.Data.DomainClass.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
