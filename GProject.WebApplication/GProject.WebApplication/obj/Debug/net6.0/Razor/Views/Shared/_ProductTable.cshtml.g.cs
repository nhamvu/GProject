#pragma checksum "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "859016dc2a1f0f2c6ac14a12ec932c3895d747e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductTable), @"mvc.1.0.view", @"/Views/Shared/_ProductTable.cshtml")]
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
#line 2 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using GProject.WebApplication.Models;

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
#line 2 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
using GProject.Data.DomainClass;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859016dc2a1f0f2c6ac14a12ec932c3895d747e2", @"/Views/Shared/_ProductTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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

<div class=""table-responsive"" style=""overflow-y: auto; max-height: 700px;"">
    <table class=""table table-bordered table-hover sticky-table"">
        <thead class=""sticky-header"">
            <tr>
                <th>STT</th>
                <th>Tên sản phẩm</th>
                <th>Loại sản phẩm</th>
                <th>Giá nhập</th>
                <th>Giá bán</th>
                <th>Trạng thái</th>
                <th style=""width: 40px; text-align: center"">
                    ");
#nullable restore
#line 35 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
               Write(Html.CheckBox("ckbAll", new { style="vertical-align:middle;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
              
                int index = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
             foreach (var item in Model)
            {
                string productType = "";
                switch (item.ProductType.ToString())
                {
                    case "0":
                        productType = "Sản phẩm thông thường";
                        break;
                    case "1":
                        productType = "Sản phẩm mới";
                        break;
                    case "2":
                        productType = "Sản phẩm nổi bật";
                        break;
                    case "3":
                        productType = "Sản phẩm được yêu thích";
                        break;
                    default:
                        productType = "Sản phẩm khuyến mại";
                        break;
                }
                index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td hidden><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1988, "\"", 2015, 1);
#nullable restore
#line 66 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
WriteAttributeValue("", 1996, item.Id.ToString(), 1996, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"prodId\" /></td>\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
                   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
                   Write(productType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
                   Write(item.ImportPrice.ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
                   Write(item.Price.ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"text\" hidden class=\"prodPrice\"");
            BeginWriteAttribute("value", " value=\"", 2323, "\"", 2342, 1);
#nullable restore
#line 71 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
WriteAttributeValue("", 2331, item.Price, 2331, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
                    Write(item.Status == 0 ? "Đang bán" : "Ngừng bán");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <input name=\"cbid\" id=\"cbid\" type=\"checkbox\" class=\"ckbProdItem\" onclick=\"changeSelectedProd(this)\" style=\"vertical-align:middle;\"");
            BeginWriteAttribute("value", " value=\"", 2610, "\"", 2618, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 77 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_ProductTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<script>
    $(document).ready(function () {
        $('#ckbAll').change(function () {
            if ($(this).is(':checked')) {
                $('.ckbProdItem').prop('checked', true);
            } else {
                $('.ckbProdItem').prop('checked', false);
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
