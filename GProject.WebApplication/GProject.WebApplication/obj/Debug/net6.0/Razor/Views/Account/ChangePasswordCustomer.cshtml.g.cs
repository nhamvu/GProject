#pragma checksum "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Account\ChangePasswordCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a42cd140da39483a13f89cf1a25f720707b754e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ChangePasswordCustomer), @"mvc.1.0.view", @"/Views/Account/ChangePasswordCustomer.cshtml")]
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
#line 2 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a42cd140da39483a13f89cf1a25f720707b754e", @"/Views/Account/ChangePasswordCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ChangePasswordCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GProject.WebApplication.Models.ChangePasswordDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formdata"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePasswordCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validateFormData();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Account\ChangePasswordCustomer.cshtml"
  
    ViewBag.Title = "Thay đổi mật khẩu";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"margin-top: 200px;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a42cd140da39483a13f89cf1a25f720707b754e5156", async() => {
                WriteLiteral(@"
    <div class=""container-xl px-4 mt-4"">
        <div class=""row"">
            <div class=""card mb-4"">
                <div class=""card-header"">Đổi mật khẩu</div>
                <div class=""card-body"">
                    <div class=""mb-3"">
                        <label class=""small mb-1"" for=""inputUsername"">Mật khẩu hiện tại</label>
                        <input class=""form-control"" type=""password"" id=""currentPassword"" name=""CurrentPassword"">
                        <span class=""text-danger"">");
#nullable restore
#line 18 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Account\ChangePasswordCustomer.cshtml"
                                             Write(ViewBag.checkCurrentPass);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                    </div>
                    <div class=""row gx-3 mb-3"">
                        <div class=""col-md-6"">
                            <label class=""small mb-1"" for=""inputFirstName"">Mật khẩu mới</label>
                            <input class=""form-control"" type=""password"" id=""newPassword"" name=""NewPassword"">
                            <span id=""newPasswordError"" class=""text-danger""></span>
                        </div>
                        <div class=""col-md-6"">
                            <label class=""small mb-1"" for=""inputLastName"">Nhập lại mật khẩu mới</label>
                            <input class=""form-control"" type=""password"" id=""confirmNewPassword"" name=""ConfirmPassword"">
                            <span id=""confirmNewPasswordError"" class=""text-danger""></span>
                        </div>
                    </div>
                    <button class=""btn btn-primary"" id=""changePasswordButton"">Lưu thay đổi</button>
                </div>
            </d");
                WriteLiteral("iv>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
<script>
    
    function validateFormData() {
        var currentPassword = document.getElementById('currentPassword').value;
        var newPassword = document.getElementById('newPassword').value;
        var confirmNewPassword = document.getElementById('confirmNewPassword').value;
        if (currentPassword.trim() === '') {
            sweetAlert(""Thông báo"", ""Thông tin mật khẩu hiện tại không được để trống"", ""error"");
            return false;
        }
        if (newPassword.trim() === '') {
            sweetAlert(""Thông báo"", ""Thông tin mật khẩu mới được để trống"", ""error"");
            return false;
        }
        if (confirmNewPassword.trim() === '') {
            sweetAlert(""Thông báo"", ""Thông tin xác nhận mật khẩu mới được để trống"", ""error"");
            return false;
        }
        if (newPassword.trim() !== confirmNewPassword.trim()) {
            sweetAlert(""Thông báo"", ""Thông tin mật khẩu nhập lại không khớp với mật khẩu mới"", ""error"");
            return ");
            WriteLiteral("false;\r\n        }\r\n        return true;\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GProject.WebApplication.Models.ChangePasswordDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
