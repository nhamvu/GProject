#pragma checksum "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Order\PaymentCallback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "616687718a794f989d7d0a2e1e75f46f4f71e8c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_PaymentCallback), @"mvc.1.0.view", @"/Views/Order/PaymentCallback.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"616687718a794f989d7d0a2e1e75f46f4f71e8c3", @"/Views/Order/PaymentCallback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b08ccb6f7db288cae79c4c47cdc6330c880c5d3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_PaymentCallback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Order\PaymentCallback.cshtml"
  
    if (ViewBag.Message)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"text-center text-warning\">Thanh toán không thành công bạn cần thực hiện lại!</h3>\r\n        <a href=\"/Product/ShowDetailMyCart\">Quay lại giỏ hàng</a>\r\n");
#nullable restore
#line 6 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Order\PaymentCallback.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"text-center text-warning\">Đơn hàng đã được thanh toán thành công!</h3>\r\n        <a href=\"/Product/Index\">Quay lại trang chủ</a>\r\n");
#nullable restore
#line 11 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Order\PaymentCallback.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
