#pragma checksum "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b12e498dab76487ce16a38557a92e0c57d2ad1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutUser), @"mvc.1.0.view", @"/Views/Shared/_LayoutUser.cshtml")]
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
#line 1 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b12e498dab76487ce16a38557a92e0c57d2ad1d", @"/Views/Shared/_LayoutUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b08ccb6f7db288cae79c4c47cdc6330c880c5d3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("36"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/UserContent/js/custom.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b12e498dab76487ce16a38557a92e0c57d2ad1d5640", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 5 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
      Write(ViewData["title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""description"" content=""Colo Shop Template"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" href=""/UserContent/styles/bootstrap4/bootstrap.min.css"">
    <link href=""/UserContent/plugins/font-awesome-4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" type=""text/css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/UserContent/plugins/OwlCarousel2-2.2.1/owl.carousel.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/UserContent/plugins/OwlCarousel2-2.2.1/owl.theme.default.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/UserContent/plugins/OwlCarousel2-2.2.1/animate.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/UserContent/styles/main_styles.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/UserContent/styles/responsive.css"">
    <script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
    <");
                WriteLiteral(@"script src=""https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js"" type=""text/javascript""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""https://maps.googleapis.com/maps/api/js?libraries=places&key=AIzaSyCKjLTXdq6Db3Xit_pW_GK4EXuPRtnod4o""></script>
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css"" />
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b12e498dab76487ce16a38557a92e0c57d2ad1d8581", async() => {
                WriteLiteral(@"

    <div class=""super_container"">

        <!-- Header -->

        <header class=""header trans_300"">

            <!-- Top Navigation -->

            <div class=""top_nav"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""top_nav_left"">free shipping on all u.s orders over $50</div>
                        </div>
                        <div class=""col-md-6 text-right"">
                            <div class=""top_nav_right"">
                                <ul class=""top_nav_menu"">

                                    <!-- Currency / Language / My Account -->

                                    <li class=""currency"">
                                        <a href=""#"">
                                            usd
                                            <i class=""fa fa-angle-down""></i>
                                        </a>
                               ");
                WriteLiteral(@"         <ul class=""currency_selection"">
                                            <li><a href=""#"">cad</a></li>
                                            <li><a href=""#"">aud</a></li>
                                            <li><a href=""#"">eur</a></li>
                                            <li><a href=""#"">gbp</a></li>
                                        </ul>
                                    </li>
                                    <li class=""language"">
                                        <a href=""#"">
                                            English
                                            <i class=""fa fa-angle-down""></i>
                                        </a>
                                        <ul class=""language_selection"">
                                            <li><a href=""#"">French</a></li>
                                            <li><a href=""#"">Italian</a></li>
                                            <li><a href=""#"">German</a></li>
 ");
                WriteLiteral("                                           <li><a href=\"#\">Spanish</a></li>\r\n                                        </ul>\r\n                                    </li>\r\n                                    <li class=\"account\">\r\n");
#nullable restore
#line 72 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
                                          
                                            var imgAvata = User.Claims.Where(c => c.Type == System.Security.Claims.ClaimTypes.Country)
                                            .Select(c => c.Value).FirstOrDefault();
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a href=\"#\">\r\n");
#nullable restore
#line 77 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
                                              
                                                if (string.IsNullOrEmpty(imgAvata))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b12e498dab76487ce16a38557a92e0c57d2ad1d12331", async() => {
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
#nullable restore
#line 81 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b12e498dab76487ce16a38557a92e0c57d2ad1d14132", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4865, "~/images/", 4865, 9, true);
#nullable restore
#line 84 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
AddHtmlAttributeValue("", 4874, imgAvata, 4874, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
#nullable restore
#line 85 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
#nullable restore
#line 87 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
                                        Write(string.IsNullOrEmpty(User.Identity.Name) == true ? "Tài khoản" : User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            <i class=""fa fa-angle-down""></i>
                                        </a>

                                        <ul class=""account_selection"" aria-labelledby=""dropdownMenuLink"">
                                            <li><a class=""dropdown-item"" href=""/user/change-password"">Đổi mật khẩu</a></li>
                                            <li><a class=""dropdown-item"" href=""/user/change-personal-infomation-employee-page"">Đổi thông tin cá nhân</a></li>
                                            <li><a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 5751, "\"", 5758, 0);
                EndWriteAttribute();
                WriteLiteral(@">Địa chỉ đặt hàng</a></li>
                                            <li><a class=""dropdown-item"" href=""/Login/logout"">Đăng xuất</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Main Navigation -->

            <div class=""main_nav_container"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-12 text-right"">
                            <div class=""logo_container"">
                                <a class=""navbar-brand"" href=""dashboard.html"">
                                    <!-- Logo icon -->
                                    <b class=""logo-icon"">
                                        <!-- Dark Logo icon -->
                                        <img src=""/images/imageLogo");
                WriteLiteral(@".PNG"" style=""width:110px; height:90px;"" alt=""homepage"" />
                                    </b>
                                    <!--End Logo icon -->
                                    <!-- Logo text -->
                                    <b class=""justify-content-center"">
                                        <!-- dark Logo text -->
                                        <strong style=""color:black;"">DREAM FASHION</strong>
                                    </b>
                                </a>
                            </div>
                            <nav class=""navbar"">
                                <ul class=""navbar_menu"">
                                    <li>
                                        <a href=""#"" style=""font-size:14px; color:white;""><i class=""fa fa-cubes"" aria-hidden=""true"" style=""margin-right:4px;""></i>Sản phẩm</a>
                                        <ul>
                                            <li>
                                         ");
                WriteLiteral(@"       <a href=""/statical/staticalpage"">Tất cả sản phẩm</a>
                                            </li>
                                            <li>
                                                <a href=""/statical/staticalpage"">Sản phẩm mới</a>
                                            </li>
                                            <li>
                                                <a href=""/statical/staticalpage"">Sản phẩm nổi bật</a>
                                            <li>
                                                <a href=""/statical/staticalpage"">Sản phẩm bán chạy</a>
                                            </li>
                                            <li>
                                                <a href=""/statical/staticalpage"">Sản phẩm đang giảm giá</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li>
            ");
                WriteLiteral(@"                            <a href=""#"" style=""font-size:14px; color:white;""><i class=""fa fa-calendar-plus-o"" aria-hidden=""true"" style=""margin-right:4px;""></i>Giảm giá</a>
                                        <ul>
                                            <li>
                                                <a href=""/statical/staticalpage"">Xắp diễn ra</a>
                                            </li>
                                            <li>
                                                <a href=""/statical/staticalpage"">Đang diễn ra</a>
                                            </li>
                                            <li>
                                                <a href=""/statical/staticalpage"">Đã kết thúc</a>
                                            <li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href=""/customer/customerpage"" sty");
                WriteLiteral(@"le=""font-size:14px; color:white;""><i class=""fa fa-newspaper-o"" aria-hidden=""true"" style=""margin-right:4px;""></i>Tin tức</a>
                                    </li>
                                    <li>
                                        <a href=""/customer/customerpage"" style=""font-size:14px; color:white;""><i class=""fa fa-users"" aria-hidden=""true"" style=""margin-right:4px;""></i>Chăm sóc khách hàng</a>
                                    </li>
                                    <li class=""arrow"">
                                        <a href=""/customer/customerpage"" style=""font-size:14px; color:white;""><i class=""fa fa-shopping-bag"" aria-hidden=""true"" style=""margin-right:4px;""></i>Trạng thái đơn hàng</a>
                                    </li>
                                </ul>
                                <ul class=""navbar_user"">
                                    <li><a href=""#""><i class=""fa fa-search"" aria-hidden=""true""></i></a></li>
                                    <li><a h");
                WriteLiteral(@"ref=""#""><i class=""fa fa-user"" aria-hidden=""true""></i></a></li>
                                    <li class=""checkout"">
                                        <a href=""#"">
                                            <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                                            <span id=""checkout_items"" class=""checkout_items"">2</span>
                                        </a>
                                    </li>
                                </ul>
                                <div class=""hamburger_container"">
                                    <i class=""fa fa-bars"" aria-hidden=""true""></i>
                                </div>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>

        </header>

        <div class=""fs_menu_overlay""></div>
        <div class=""hamburger_menu"">
            <div class=""hamburger_close""><i class=""fa fa-times"" aria-hidden=""tru");
                WriteLiteral(@"e""></i></div>
            <div class=""hamburger_menu_content text-right"">
                <ul class=""menu_top_nav"">
                    <li class=""menu_item has-children"">
                        <a href=""#"">
                            usd
                            <i class=""fa fa-angle-down""></i>
                        </a>
                        <ul class=""menu_selection"">
                            <li><a href=""#"">cad</a></li>
                            <li><a href=""#"">aud</a></li>
                            <li><a href=""#"">eur</a></li>
                            <li><a href=""#"">gbp</a></li>
                        </ul>
                    </li>
                    <li class=""menu_item has-children"">
                        <a href=""#"">
                            English
                            <i class=""fa fa-angle-down""></i>
                        </a>
                        <ul class=""menu_selection"">
                            <li><a href=""#"">French</a></li>
    ");
                WriteLiteral(@"                        <li><a href=""#"">Italian</a></li>
                            <li><a href=""#"">German</a></li>
                            <li><a href=""#"">Spanish</a></li>
                        </ul>
                    </li>
                    <li class=""menu_item has-children"">
                        <div class=""dropdown"">
                            <a class=""profile-pic dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
");
#nullable restore
#line 224 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
                                  
                                    if (string.IsNullOrEmpty(imgAvata))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b12e498dab76487ce16a38557a92e0c57d2ad1d26061", async() => {
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
#nullable restore
#line 228 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b12e498dab76487ce16a38557a92e0c57d2ad1d27815", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 13869, "~/images/", 13869, 9, true);
#nullable restore
#line 231 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
AddHtmlAttributeValue("", 13878, imgAvata, 13878, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
#nullable restore
#line 232 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <span class=\"text-white font-medium\">");
#nullable restore
#line 234 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
                                                                 Write(string.IsNullOrEmpty(User.Identity.Name) == true ? "Tài khoản" : User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                <i class=""fa fa-angle-down""></i>
                            </a>

                            <ul class=""menu_selection"" aria-labelledby=""dropdownMenuLink"">
                                <li><a class=""dropdown-item"" href=""/user/change-password"">Đổi mật khẩu</a></li>
                                <li><a class=""dropdown-item"" href=""/user/change-personal-infomation-employee-page"">Đổi thông tin cá nhân</a></li>
                                <li><a class=""dropdown-item"" href=""/Login/logout"">Đăng xuất</a></li>
                            </ul>
                        </div>
                    </li>
                    <li class=""menu_item""><a href=""#"">home</a></li>
                    <li class=""menu_item""><a href=""#"">shop</a></li>
                    <li class=""menu_item""><a href=""#"">promotion</a></li>
                    <li class=""menu_item""><a href=""#"">pages</a></li>
                    <li class=""menu_item""><a href=""#"">blog</a></li>
              ");
                WriteLiteral(@"      <li class=""menu_item""><a href=""#"">contact</a></li>
                </ul>
            </div>
        </div>

        <!-- Slider -->

        <div class=""main_slider"" style=""background-image:url(/UserContent/images/slider_1.jpg)"">
            <div class=""container fill_height"">
                <div class=""row align-items-center fill_height"">
                    <div class=""col"">
                        <div class=""main_slider_content"">
                            <h6>Spring / Summer Collection 2017</h6>
                            <h1>Get up to 30% Off New Arrivals</h1>
                            <div class=""red_button shop_now_button""><a href=""#"">shop now</a></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Banner -->

        <div class=""container"">
            <div class=""row justify-content-center"">
                ");
#nullable restore
#line 275 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>

        <!-- New Arrivals -->
        <!-- Footer -->

        <footer class=""footer"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""footer_nav_container d-flex flex-sm-row flex-column align-items-center justify-content-lg-start justify-content-center text-center"">
                            <ul class=""footer_nav"">
                                <li><a href=""#"">Blog</a></li>
                                <li><a href=""#"">FAQs</a></li>
                                <li><a href=""contact.html"">Contact us</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""footer_social d-flex flex-row align-items-center justify-content-lg-end justify-content-center"">
                            <ul>
                                <li><a hr");
                WriteLiteral(@"ef=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-instagram"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-skype"" aria-hidden=""true""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-pinterest"" aria-hidden=""true""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""footer_nav_container"">
                            <div class=""cr"">©2018 All Rights Reserverd. Made with <i class=""fa fa-heart-o"" aria-hidden=""true""></i> by <a href=""#"">Colorlib</a> &amp; distributed by <a href=""https://themewagon.com"">ThemeWagon</a></div>
                        </div>
 ");
                WriteLiteral(@"                   </div>
                </div>
            </div>
        </footer>

    </div>

    <script src=""/UserContent/js/jquery-3.2.1.min.js""></script>
    <script src=""/UserContent/styles/bootstrap4/popper.js""></script>
    <script src=""/UserContent/styles/bootstrap4/bootstrap.min.js""></script>
    <script src=""/UserContent/plugins/Isotope/isotope.pkgd.min.js""></script>
    <script src=""/UserContent/plugins/OwlCarousel2-2.2.1/owl.carousel.js""></script>
    <script src=""/UserContent/plugins/easing/easing.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b12e498dab76487ce16a38557a92e0c57d2ad1d35565", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 324 "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_LayoutUser.cshtml"
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
