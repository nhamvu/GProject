#pragma checksum "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Account\ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ae45b693f9eb150433964d621a46b1a74cb8cfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ForgotPassword), @"mvc.1.0.view", @"/Views/Account/ForgotPassword.cshtml")]
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
#line 2 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ae45b693f9eb150433964d621a46b1a74cb8cfe", @"/Views/Account/ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formdata"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("/quen-mat-khau.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Account\ForgotPassword.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css"">
<div class=""form-gap""></div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-4 col-md-offset-4"">
            <div class=""panel panel-default"">
                <div class=""panel-body"">
                    <div class=""text-center"">
                        <h3><i class=""fa fa-lock fa-4x""></i></h3>
                        <h2 class=""text-center"">Quên mật khẩu</h2>
                        <p>Mật khẩu sẽ được gửi về mail của bạn.</p>
                        <div class=""panel-body"">

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ae45b693f9eb150433964d621a46b1a74cb8cfe5720", async() => {
                WriteLiteral(@"

                                <div class=""form-group"">
                                    <div class=""input-group"">
                                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-envelope color-blue""></i></span>
                                        <input type=""email"" class=""form-control"" id=""email"" name=""email"" placeholder=""Email"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""input-group"">
                                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-envelope color-blue""></i></span>
                                        <input type=""text"" class=""form-control"" id=""phoneNumber"" name=""phoneNumber"" placeholder=""(+84)"">
                                    </div>
                                </div>
                                <div class=""form-group"">
               ");
                WriteLiteral(@"                     <input name=""recover-submit"" class=""btn btn-lg btn-primary btn-block"" value=""Gửi mật khẩu"" type=""submit"">
                                </div>

                                <input type=""hidden"" class=""hide"" name=""token"" id=""token""");
                BeginWriteAttribute("value", " value=\"", 2368, "\"", 2376, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
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
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#phoneNumber').keyup(function () {
            let regex = /^[0-9]+$/;
            if (!regex.test($(this).val()))
                $(this).val($(this).val().replace(/[^0-9.]/g, """"));
        });
    });

    function validatePhoneNumber(code) {
        var regex = /(84|0[3|5|7|8|9])+([0-9]{8})\b/;
        return regex.test(code);
    }
    document.querySelector('#formdata').addEventListener('submit', function (e) {
        var form = this;

        e.preventDefault();
        if (checkValidateData()) {
            swal(""Thông báo"", {
                title: 'Bạn chắc chắn với những thông tin này ?',
                icon: 'info',
                buttons: [""Không, tôi cần xem lại"", ""Có, tôi đồng ý""],
            }).then(function (isConfirm) {
                if (isConfi");
            WriteLiteral(@"rm) {
                    form.submit();
                } else {
                    swal(""Đã hủy"", ""Bạn đã không lưu những thay đổi này!"", ""error"");
                }
            });
        }
    });

    function checkValidateData() {
        if ($('#email').val() == '') {
            sweetAlert(""Thông báo"", ""Thông tin email không được để trống"", ""error"");
            return false;
        }
        if ($('#phoneNumber').val() == '') {
            sweetAlert(""Thông báo"", ""Thông tin số điện thoại không được để trống"", ""error"");
            return false;
        }
        if (!validatePhoneNumber($('#phoneNumber').val())) {
            sweetAlert(""Thông báo"", ""Số điện thoại không đúng định dạng"", ""error"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
