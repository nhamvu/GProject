#pragma checksum "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf4987ef56353b03ca3745051bce2c0c59e0a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAdmin), @"mvc.1.0.view", @"/Views/Shared/_LayoutAdmin.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#nullable restore
#line 1 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml"
using GProject.WebApplication.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf4987ef56353b03ca3745051bce2c0c59e0a0c", @"/Views/Shared/_LayoutAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/admin.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("36"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/js_deliveryaddress.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml"
  
    var user = GProject.WebApplication.Helpers.Commons.GetObjectFromJson<GProject.Data.DomainClass.Employee>(Context.Session, "userLogin");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html dir=\"ltr\" lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf4987ef56353b03ca3745051bce2c0c59e0a0c6248", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""keywords""
          content=""wrappixel, admin dashboard, html css dashboard, web dashboard, bootstrap 5 admin, bootstrap 5, css3 dashboard, bootstrap 5 dashboard, Ample lite admin bootstrap 5 dashboard, frontend, responsive bootstrap 5 admin template, Ample admin lite dashboard bootstrap 5 dashboard template"">
    <meta name=""description""
          content=""Ample Admin Lite is powerful and clean admin dashboard template, inpired from Bootstrap Framework"">
    <meta name=""robots"" content=""noindex,nofollow"">
    <title>");
#nullable restore
#line 20 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml"
      Write(ViewData["title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    <link rel=\"canonical\" href=\"https://www.wrappixel.com/templates/ample-admin-lite/\" />\r\n    <!-- Favicon icon -->\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"16x16\" href=\"/images/imageLogo.PNG\">\r\n    <!-- Custom CSS -->\r\n");
                WriteLiteral(@"    <!-- Custom CSS -->
    <link href=""/AdminContent/css/style.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" type=""text/css"" href=""/UserContent/styles/categories_styles.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/UserContent/styles/categories_responsive.css"">

    <script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js"" type=""text/javascript""></script>
");
                WriteLiteral(@"    <script src=""https://maps.googleapis.com/maps/api/js?libraries=places&key=AIzaSyCKjLTXdq6Db3Xit_pW_GK4EXuPRtnod4o""></script>
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css"" />

    <style>
        a {
            text-decoration: none
        }

    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf4987ef56353b03ca3745051bce2c0c59e0a0c9949", async() => {
                WriteLiteral(@"
    <div class=""preloader"">
        <div class=""lds-ripple"">
            <div class=""lds-pos""></div>
            <div class=""lds-pos""></div>
        </div>
    </div>
    <div id=""main-wrapper"" data-layout=""vertical"" data-navbarbg=""skin5"" data-sidebartype=""full""
         data-sidebar-position=""absolute"" data-header-position=""absolute"" data-boxed-layout=""full"" >
        <header class=""topbar"" data-navbarbg=""skin5"" style=""background-color: #152d36;"">
            <div class=""logo_container d-flex"">
                <a href=""/dashboard/index""><span style=""color: white;"">Dream</span><span>Fashions</span></a>
            </div>
            <nav class=""navbar top-navbar navbar-expand-md navbar-dark"">
                <div class=""navbar-collapse collapse"" id=""navbarSupportedContent"" style=""margin-top: -43px;"" data-navbarbg=""skin5"">
                    <ul class=""navbar-nav ms-auto d-flex align-items-center"" style=""background-color: #152d36;"">
                        <li>
                            <d");
                WriteLiteral("iv class=\"dropdown\">\r\n                                <a class=\"profile-pic dropdown-toggle\" href=\"#\" role=\"button\" id=\"dropdownMenuLink\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">\r\n");
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2cf4987ef56353b03ca3745051bce2c0c59e0a0c11592", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("                                    <span class=\"text-white font-medium\">");
#nullable restore
#line 71 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml"
                                                                     Write(user == null ? "Tài khoản" : user.Name.NullToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                </a>

                                <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
                                    <li><a class=""dropdown-item"" href=""/Doi-mat-khau-nhan-vien.html"">Đổi mật khẩu</a></li>
                                    <li><a class=""dropdown-item"" href=""/Thong-tin-nhan-vien.html"">Đổi thông tin cá nhân</a></li>
                                    <li><a class=""dropdown-item"" href=""/Account/logout"">Đăng xuất</a></li>
                                </ul>
                            </div>

                        </li>
                    </ul>
                </div>
            </nav>
        </header>
        <aside class=""left-sidebar"" data-sidebarbg=""skin6"" style=""background-color: #152d36;"">
            <!-- Sidebar scroll-->
            <div class=""scroll-sidebar"">
                <!-- Sidebar navigation-->
                <nav class=""sidebar-nav"">
                    <ul id=""sidebarnav"" style=""background-c");
                WriteLiteral(@"olor: #152d36;"">
                        <!-- User Profile-->
                        <li class=""sidebar-item pt-2"">
                            <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Dashboard/Index""
                               aria-expanded=""false"">
                                <i style=""color: white"" class=""fas fa-home""></i>
                                <span style="" color: white "" class=""hide-menu"">Trang chủ</span>
                            </a>
                        </li>
                        <li class=""sidebar-item pt-2"">
                            <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Order/Index""
                               aria-expanded=""false"">
                                <i style=""color: white"" class=""fa fa-shopping-bag""></i>
                                <span style="" color: white "" class=""hide-menu"">Quản lý đơn hàng</span>
                            </a>
                        </li>
            ");
                WriteLiteral(@"            <li class=""sidebar-item pt-2"">
                            <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Invoice/Index""
                               aria-expanded=""false"">
                                <i style=""color: white"" class=""fas fa-receipt""></i>
                                <span style="" color: white"" class=""hide-menu"">Danh sách hóa đơn</span>
                            </a>
                        </li>
");
#nullable restore
#line 114 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml"
                         if (user.Position == GProject.Data.Enums.EmployeePosition.Manager)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <li class=""sidebar-item pt-2"">
                                <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Promotion/Index""
                               aria-expanded=""false"">
                                    <i class=""fas fa-percent"" style=""color: white""></i>
                                    <span style="" color: white"" class=""hide-menu"">Giảm giá</span>
                                </a>
                            </li>
                            <li class=""sidebar-item dropdown"">
                                <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Voucher/Index""
                               aria-expanded=""false"">
                                    <i class=""fas fa-tags"" style=""color: white""></i>
                                    <span style="" color: white"" class=""hide-menu"">Mã khuyến mại</span>
                                </a>
                            </li>
                            <li ");
                WriteLiteral(@"class=""sidebar-item dropdown"">
                                <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Employee/Index""
                               aria-expanded=""false"">
                                    <i class=""fas fa-user-nurse"" style=""color: white""></i>
                                    <span style="" color: white"" class=""hide-menu"">Nhân viên</span>
                                </a>
                            </li>
");
#nullable restore
#line 137 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li class=""sidebar-item dropdown"">
                            <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Customer/Index""
                               aria-expanded=""false"">
                                <i class=""fas fa-users"" style=""color: white""></i>
                                <span style="" color: white"" class=""hide-menu"">Khách hàng</span>
                            </a>
                        </li>
                        <li class=""sidebar-item dropdown"">
                            <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/ProductMGR/Index""
                               aria-expanded=""false"">
                                <i class=""fas fa-cubes"" style=""color: white""></i>
                                <span style="" color: white"" class=""hide-menu"">Thông tin sản phẩm</span>
                            </a>
                        </li>
                        <li class=""sidebar-item dropdown"">
        ");
                WriteLiteral(@"                    <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Category/Index""
                               aria-expanded=""false"">
                                <i class=""fas fa-sitemap"" style=""color: white""></i>
                                <span style="" color: white"" class=""hide-menu"">Danh mục sản phẩm</span>
                            </a>
                        </li>
                        <li class=""sidebar-item dropdown"">
                            <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Color/Index""
                               aria-expanded=""false"">
                                <i class=""fas fa-palette"" style=""color: white""></i>
                                <span style="" color: white"" class=""hide-menu"">Màu sắc</span>
                            </a>
                        </li>
                        <li class=""sidebar-item dropdown"">
                            <a class=""sidebar-link waves-effect waves-dark sideba");
                WriteLiteral(@"r-link"" href=""/Size/Index""
                               aria-expanded=""false"">
                                <i class=""fas fa-digital-tachograph"" style=""color: white""></i>
                                <span style="" color: white"" class=""hide-menu"">Kích cỡ</span>
                            </a>
                        </li>
                        <li class=""sidebar-item dropdown"">
                            <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Brand/Index""
                               aria-expanded=""false"">
                                <i class=""fab fa-bandcamp"" style=""color: white""></i>
                                <span style="" color: white"" class=""hide-menu"">Nhãn hiệu</span>
                            </a>
                        </li>                        
                        <li class=""sidebar-item dropdown"">
                            <a class=""sidebar-link waves-effect waves-dark sidebar-link"" href=""/Evaluate/index""
                 ");
                WriteLiteral(@"              aria-expanded=""false"">
                                <i class=""fas fa-comment-dots"" style=""color: white""></i>
                                <span style="" color: white"" class=""hide-menu"">Bình luận đánh giá</span>
                            </a>
                        </li>                                                
                    </ul>

                </nav>
                <!-- End Sidebar navigation -->
            </div>
            <!-- End Sidebar scroll-->
        </aside>
        <div class=""page-wrapper"">
            <div class=""page-breadcrumb bg-white"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-6 col-md-4 col-sm-4 col-xs-12"">
                        <h4 style=""text-transform: uppercase"">");
#nullable restore
#line 198 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml"
                                                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
                    </div>
                </div>
                <!-- /.col-lg-12 -->
            </div>
            <div class=""container-fluid"" style=""background-color: white;"">
                <div class=""row justify-content-center"">
                    ");
#nullable restore
#line 205 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <!-- ============================================================== -->
            <footer class=""footer text-center"">
                2023 © Ample Admin brought to you by <a href=""https://www.wrappixel.com/"">wrappixel.com</a>
            </footer>
        </div>
    </div>
    <script src=""/AdminContent/plugins/bower_components/jquery/dist/jquery.min.js""></script>
    <!-- Bootstrap tether Core JavaScript -->
    <script src=""/AdminContent/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""/AdminContent/js/app-style-switcher.js""></script>
    <script src=""/AdminContent/plugins/bower_components/jquery-sparkline/jquery.sparkline.min.js""></script>
    <!--Wave Effects -->
    <script src=""/AdminContent/js/waves.js""></script>
    <!--Menu sidebar -->
    <script src=""/AdminContent/js/sidebarmenu.js""></script>
    <!--Custom JavaScript -->
    <script src=""/AdminContent/js/custom.js""></script>
    <!--This page JavaScri");
                WriteLiteral(@"pt -->
    <!--chartis chart-->
    <script src=""/AdminContent/plugins/bower_components/chartist/dist/chartist.min.js""></script>
    <script src=""/AdminContent/plugins/bower_components/chartist-plugin-tooltips/dist/chartist-plugin-tooltip.min.js""></script>
    <script src=""/AdminContent/js/pages/dashboards/dashboard1.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf4987ef56353b03ca3745051bce2c0c59e0a0c24552", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 230 "D:\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutAdmin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
