#pragma checksum "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cb3182f180f4f35aa563831a44d8ff04e0e231a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Size_Index), @"mvc.1.0.view", @"/Views/Size/Index.cshtml")]
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
#line 3 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
using GProject.Api.MyServices.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cb3182f180f4f35aa563831a44d8ff04e0e231a", @"/Views/Size/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b08ccb6f7db288cae79c4c47cdc6330c880c5d3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Size_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GProject.WebApplication.Models.SizeDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:0px;height:0px;visibility: hidden;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("hidden", new global::Microsoft.AspNetCore.Html.HtmlString("hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Size code (XL)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("maxlength", new global::Microsoft.AspNetCore.Html.HtmlString("15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Size name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("maxlength", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formdata"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
  
    ViewBag.Title = "Quản lý kích cỡ";
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
#line 31 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
 if (@ViewData["Mess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"visibility: hidden;\" id=\"error\">");
#nullable restore
#line 33 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
                                         Write(ViewData["Mess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<button class=\"btn btn-primary\" id=\"changeform\" type=\"button\" onclick=\"ChangePanel()\">Thêm mới</button>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cb3182f180f4f35aa563831a44d8ff04e0e231a8188", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cb3182f180f4f35aa563831a44d8ff04e0e231a8450", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 37 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
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
                WriteLiteral("\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col-md-4\">\r\n            <label class=\"col-md-5\"><strong>Mã:<span style=\"color: red\">(*)</span></strong></label>\r\n            <div class=\"form-input\">\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cb3182f180f4f35aa563831a44d8ff04e0e231a10346", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 43 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Code);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <label class=\"col-md-5\"><strong>Tên:<span style=\"color: red\">(*)</span></strong></label>\r\n            <div class=\"form-input\">\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cb3182f180f4f35aa563831a44d8ff04e0e231a12254", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 50 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <strong><label>Trạng thái</label><span style=\"color: red\">(*)</span></strong>\r\n            <div style=\"margin-top:10px;\">\r\n                ");
#nullable restore
#line 56 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
           Write(Html.DropDownList("Status", new[]
                {
                new SelectListItem{Text="Không sử dụng", Value="0", Selected = (Model.Status != null ? (Model.Status == 0) : true)},
                new SelectListItem{Text="Sử dụng", Value="1",  Selected = (Model.Status != null ? (Model.Status == 1) : false)}
                }, new { @class = "form-control iscompany" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
        <div class=""col-md-2"">
            <strong><label></label></strong>
            <div class=""form-input"">
                <button class=""btn btn-success"" type=""submit"" style=""height:40px;width:110px;""><i class=""fa fa-plus"" aria-hidden=""true"" style=""margin-right:4px;""></i>Lưu</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
            <h3 class=""panel-title"" style=""background-color:#E5E5E5; text-align:center; height:50px; padding:10px 10px 10px 10px;""><i class=""fa fa-tachometer"" aria-hidden=""true"" style=""margin-right:10px;""></i>DANH SÁCH KÍCH THƯỚC</h3>
        </div>
        <div class=""panel-body"">
            <div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
                <table class=""table table-bordered table-hover sticky-table"">
                    <thead class=""sticky-header"">
                        <tr>
                            <th>Mã Size</th>
                            <th>Tên Size</th>
                            <th>Trạng thái</th>
                            <th>Chi tiết</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 89 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
                         if (Model.SizeList != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
                             foreach (var item in Model.SizeList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 95 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
                                   Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 98 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 101 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
                                    Write(item.Status == 1 ? "Đang sử dụng" : "Không sử dụng");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4248, "\"", 4282, 3);
            WriteAttributeValue("", 4258, "ViewDetailData(", 4258, 15, true);
#nullable restore
#line 104 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
WriteAttributeValue("", 4273, item.Id, 4273, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4281, ")", 4281, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <i class=\"fa fa-eye\" aria-hidden=\"true\"></i>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 108 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Size\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<div id=""ViewDetail"" class=""modal modal-default in"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""padding: 5px 15px;"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""></button>
                <h3 class=""modal-title text-left"">Thông tin Size</h3>
            </div>
            <div class=""modal-body"">
                <h5>Tên:<strong id=""namee""></strong></h5>
                <h5>Mã:<strong id=""code""></strong></h5>
                <h5>Trạng thái:<strong id=""status""></strong></h5>
            </div>
            <div class=""modal-footer"" style=""position:relative;clear:both;z-index:1000000"" id=""transport-footer"">
                <button type=""button"" class=""btn btn-default pull-left btn-sm"" data-dismiss=""modal"" onclick=""btnClose()""><i class=""fa fa-times""></i>Đóng</button>
         ");
            WriteLiteral(@"   </div>
        </div>
    </div>
</div>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#formdata').hide();
        var er = document.getElementById('error')
        if (er != null) {
            if ($('#error').text() == 'Failed')
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
            $(""#Code"").val('');
            $(""#Status"").val(0);
            $('#formdata').hide();
            $(""#changeform"").text(""Thêm mới"");
        }
    }
    function validateCode(code) {
        var regex = /^[a-zA-Z0-9]+$/;
        return");
            WriteLiteral(@" regex.test(code);
    }
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
    function ViewDetailData(id) {
        $.getJSON(""/Color/Detail?id="" + id, function (data) {
            $(""#Name"").val(data.name);
            $(""#Code"").val(data.Code);
            $(""#Status"").val(data.status);
            $(""#Id"").val(data.id);
            document.getElementById('namee').in");
            WriteLiteral(@"nerText = data.name;
            document.getElementById('code').innerText = data.code;
            document.getElementById('status').innerText = data.status ? ""Đang sử dụng"" : ""Không sử dụng"";
            $(""#changeform"").text(""Thêm mới"");
            ChangePanel()
            $('#ViewDetail').modal('show');
        });
    }
    function btnClose() {
        $('#ViewDetail').modal('hide');
    }

    function checkValidateData() {
        if ($('#Code').val() == '') {
            sweetAlert(""Thông báo"", ""Thông tin mã màu không được để trống"", ""error"");
            return false;
        }
        if (!validateCode($('#Code').val())) {
            sweetAlert(""Thông báo"", ""Thông tin mã màu không đúng định dạng"", ""error"");
            return false;
        }
        if ($('#Name').val() == '') {
            sweetAlert(""Thông báo"", ""Thông tin tên màu không được để trống"", ""error"");
            return false;
        }
        return true;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GProject.WebApplication.Models.SizeDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
