#pragma checksum "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fb904d7ec97674fbbbfe0a9f43517abe9907c9a"
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
#line 4 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
using GProject.Api.MyServices.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb904d7ec97674fbbbfe0a9f43517abe9907c9a", @"/Views/Color/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Color_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<GProject.Data.DomainClass.Color>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Color/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formdata"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:120px;height:50px; border;1px solid;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
  
    ViewBag.Title = "QUẢN LÝ MÀU SẮC";
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

");
#nullable restore
#line 31 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
 if (@ViewData["Mess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 33 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                                         Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fb904d7ec97674fbbbfe0a9f43517abe9907c9a8641", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""panel panel-default"">
                <div class=""panel-body"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""col-md-3 control-label"">Mã màu</label>
                                <div class=""col-md-9 col-xs-12"">
                                    <input type=""text"" id=""sHEXCode"" name=""sHEXCode""");
                BeginWriteAttribute("value", " value=\"", 1402, "\"", 1431, 1);
#nullable restore
#line 45 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
WriteAttributeValue("", 1410, ViewData["sHEXCode"], 1410, 21, false);

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
                                <label class=""col-md-3 control-label"">Tên màu</label>
                                <div class=""col-md-9 col-xs-12"">
                                    <input type=""text"" id=""sName"" name=""sName""");
                BeginWriteAttribute("value", " value=\"", 1899, "\"", 1925, 1);
#nullable restore
#line 53 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
WriteAttributeValue("", 1907, ViewData["sName"], 1907, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
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
            WriteLiteral("\r\n<button class=\"btn btn-primary col-md-3\" id=\"changeform\" type=\"button\" onclick=\"ChangePanel()\">Thêm mới</button>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fb904d7ec97674fbbbfe0a9f43517abe9907c9a12902", async() => {
                WriteLiteral(@"
    <input id=""Id"" name=""Id"" hidden=""hidden"" />
    <div class=""row mt-5"">
        <div class=""col-md-4"">
            <label class=""col-md-5""><strong>Mã Màu:<span style=""color: red"">(*)</span></strong></label>
            <div class=""form-input"">
                <input id=""HEXCode"" name=""HEXCode"" placeholder=""Hex code (#)"" maxlength=""15"" class=""form-control"" />
            </div>
        </div>
        <div class=""col-md-4"">
            <label class=""col-md-5""><strong>Tên Màu:<span style=""color: red"">(*)</span></strong></label>
            <div class=""form-input"">
                <input id=""Name"" name=""Name"" placeholder=""Color name"" maxlength=""200"" class=""form-control"" />
            </div>
        </div>
        <div class=""col-md-4"">
            <label class=""col-md-5""><strong>Hình ảnh:<span style=""color: red"">(*)</span></strong></label>
            <div class=""form-input"">
                <input id=""Image_Upload"" name=""Image_Upload"" type=""file"" multiple class=""form-control"" />
         ");
                WriteLiteral(@"   </div>
        </div>
        <div class=""col-md-2"">
            <strong><label></label></strong>
            <div class=""form-input"">
                <button id=""btnSave"" class=""btn btn-success"" type=""submit"" style=""height:40px;width:110px;""><i class=""fa fa-plus"" aria-hidden=""true"" style=""margin-right:4px;""></i>Lưu</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
            <h3 class=""panel-title"" style=""background-color:#E5E5E5; text-align:center; height:50px; padding:10px 10px 10px 10px;""><i class=""fa fa-tachometer"" aria-hidden=""true"" style=""margin-right:10px;""></i>DANH SÁCH MÀU SẮC</h3>
        </div>
        <div class=""panel-body"">
            <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                <table class=""table table-bordered table-hover sticky-table"">
                    <thead class=""sticky-header"">
                        <tr>
                            <th>Mã Màu</th>
                            <th>Tên Màu</th>
                            <th>Hình ảnh</th>
                            <th>Chi tiết</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 114 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                         if (Model != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 120 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                                   Write(item.HEXCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 123 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9fb904d7ec97674fbbbfe0a9f43517abe9907c9a18463", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5554, "~/images/", 5554, 9, true);
#nullable restore
#line 126 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
AddHtmlAttributeValue("", 5563, item.Image, 5563, 11, false);

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
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5733, "\"", 5767, 3);
            WriteAttributeValue("", 5743, "ViewDetailData(", 5743, 15, true);
#nullable restore
#line 129 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
WriteAttributeValue("", 5758, item.Id, 5758, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5766, ")", 5766, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <i class=\"fa fa-eye\" aria-hidden=\"true\"></i>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 133 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n    ");
#nullable restore
#line 142 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Color\Index.cshtml"
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
            WriteLiteral(@"
</div>
<div id=""ViewDetail"" class=""modal modal-default in"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""padding: 5px 15px;"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""></button>
                <h3 class=""modal-title text-left"">Thông tin màu sắc</h3>
            </div>
            <div class=""modal-body"">
                <h5>Tên màu:<strong id=""namee""></strong></h5>
                <h5>Mã màu:<strong id=""code""></strong></h5>
            </div>
            <div class=""modal-footer"" style=""position:relative;clear:both;z-index:1000000"" id=""transport-footer"">
                <button type=""button"" class=""btn btn-default pull-left btn-sm"" data-dismiss=""modal"" onclick=""btnClose()""><i class=""fa fa-times""></i>Đóng</button>
            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#formdata').hide();
        v");
            WriteLiteral(@"ar er = document.getElementById('error')
        if (er != null){
            if($('#error').text() == 'Failed')
                swal(""Không thành công"", ""Vui lòng xem lại thông tin đã nhập"", ""error"");
            else
                swal(""Thành công"", ""Bạn đã lưu thành công thông tin đã nhập"", ""success"");
        }
    });
    
    function ChangePanel() {
        if ($(""#changeform"").text() == ""Thêm mới"") {
            $('#formdata').show();
            $(""#changeform"").text(""Hủy thay đổi"");
        } else if ($(""#changeform"").text() == ""Hủy thay đổi"") {
            $(""#Name"").val('');
            $(""#HEXCode"").val('');
            $('#formdata').hide();
            $(""#changeform"").text(""Thêm mới"");
        }
    }
    function validateHEXCode(code) {
        var regex = /^#[a-zA-Z0-9]+$/;
        return regex.test(code);
    }
    document.querySelector('#formdata').addEventListener('submit', function (e) {
        var form = this;

        e.preventDefault();
        if (chec");
            WriteLiteral(@"kValidateData()) {
            //swal(""Bạn chắc chắn lưu những thay đổi này?""
            //, {
            //    title: 'Bạn chắc chắn muốn lưu nhưng thay đổi này?',
            //    icon: 'info',
            //    buttons: [""Không, tôi cần xem lại"", ""Có, tôi đồng ý""],
            //}).then(function (isConfirm) {
            //    if (isConfirm) {
            //        form.submit();
            //    } else {
            //        swal(""Đã hủy"", ""Bạn đã không lưu những thay đổi này!"", ""error"");
            //    }
            //});
        }
    });
    function ViewDetailData(id) {
        $.getJSON(""/Color/Detail?id="" + id, function (data) {
            $(""#Name"").val(data.name);
            $(""#HEXCode"").val(data.hexCode);
            $(""#Id"").val(data.id);
            document.getElementById('namee').innerText = data.name;
            document.getElementById('code').innerText = data.hexCode;
            $(""#changeform"").text(""Thêm mới"");
            ChangePanel()
            $('");
            WriteLiteral(@"#ViewDetail').modal('show');
        });
    }
    function btnClose() {
        $('#ViewDetail').modal('hide');
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
        $(""#btnSave"").click(function () {
            if ($('#HEXCode').val() == '') {
                sweetAlert(""Thông báo"", ""Thông tin mã màu không được để trống"", ""error"");
                return false;
            }
            if (!validateHEXCode($('#HEXCode').val())) ");
            WriteLiteral(@"{
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
            var image = $(""#Image_Upload"").get(0).files[0];
            var data = new FormData();
            data.append('Id', id);
            data.append('HEXCode', hexcode);
            data.append('Name', name);
            data.append('Image_Upload', image);
            $.ajax({
                url: ""/Color/CheckHEXCode"",
                type: ""POST"",
                data: { HEXCode: hexcode, Id: id },
                success: function (result) {
                    if (result.success) {
                        $.ajax({
                            ");
            WriteLiteral(@"url: ""/Color/CheckName"",
                            type:""POST"",
                            data: { Name: name,Id:id },
                            success:function(result){
                                if (result.success) {
                                    //var data = { Id: id, HEXCode: hexcode, Name: name, Image_Upload: image };
                                    $.ajax({
                                        url: ""/Color/Save"",
                                        type: ""POST"",
                                        data: data,
                                        contentType: false,
                                        processData: false,
                                        success: function (result) {
                                            if (result.success) {
                                                swal(""Thành công"", ""Bạn đã lưu thành công thông tin đã nhập"", ""success"");
                                                setTimeout(function () {
     ");
            WriteLiteral(@"                                               location.reload();
                                                }, 2000);
                                            } else {
                                                swal(""Thành công!"", ""Bạn đã lưu thành công thông tin đã nhập"", ""success"");
                                                setTimeout(function () {
                                                    location.reload();
                                                }, 2000);
                                            }
                                        },
                                        error: function (xhr, status, error) {
                                            alert(error);
                                        }
                                    });
                                } else {
                                    swal(""Lỗi"", ""Tên đã được sử dụng, vui lòng nhập tên khác"", ""error"");
                                }
                  ");
            WriteLiteral(@"          }
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
