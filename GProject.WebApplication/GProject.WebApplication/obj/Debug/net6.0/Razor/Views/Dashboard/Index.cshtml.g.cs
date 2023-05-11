#pragma checksum "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b99c11e48efdfc7e5efe0c9e6676581fe8a8488f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using GProject.WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using GProject.WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b99c11e48efdfc7e5efe0c9e6676581fe8a8488f", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GProject.WebApplication.Models.MyChartData>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Dashboard/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Trang chủ";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    List<ProductStaticalDTO> ProductStaticals = (List<ProductStaticalDTO>)ViewData["ProductStatical"];
    List<CategoryStaticalDTP> categoryStaticals = (List<CategoryStaticalDTP>)ViewData["CategoryStatical"];

    var labels = new List<string>();
    var data = new List<decimal>();
    var backgroundColor = new List<string>();
    var hoverBackgroundColor = new List<string>();

    foreach (var result in categoryStaticals)
    {
        labels.Add(result.CategoryName);
        data.Add(result.TotalRevenue);
        backgroundColor.Add("#" + Guid.NewGuid().ToString().Substring(0, 6));
        hoverBackgroundColor.Add("#" + Guid.NewGuid().ToString().Substring(0, 6));
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-7\">\r\n        <h3>Thống kê</h3>\r\n    </div>\r\n    <div class=\"col-md-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b99c11e48efdfc7e5efe0c9e6676581fe8a8488f6372", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""form-group row"">
                        <label >Từ</label>
                        <div class=""col-md-12"">
                            <input type=""date"" id=""fromDate"" name=""fromDate"" style=""margin-top: -5px;""");
                BeginWriteAttribute("value", " value=\"", 1396, "\"", 1425, 1);
#nullable restore
#line 33 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 1404, ViewData["fromDate"], 1404, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
                        </div>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""form-group row"">
                        <label >Đến</label>
                        <div class=""col-md-12"">
                            <input type=""date"" id=""toDate"" name=""toDate"" style=""margin-top: -5px;""");
                BeginWriteAttribute("value", " value=\"", 1818, "\"", 1845, 1);
#nullable restore
#line 41 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 1826, ViewData["toDate"], 1826, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control col-12"" />
                        </div>
                    </div>
                </div>
                <div class=""col-md-3 mt-2"">
                    <label></label>
                    <div class=""col-md-12"" style=""margin-top: -5px;"">
                        <button class=""btn btn-success"" type=""submit""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
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
            WriteLiteral(@"
    </div>
</div>
<hr style=""color:red;"" />
<div class=""container-fluid"">
    <!-- ============================================================== -->
    <!-- Three charts -->
    <!-- ============================================================== -->
    <div class=""row justify-content-center"">
        <div class=""col-lg-3 col-md-12"">
            <div class=""white-box analytics-info"" style=""border: 1px solid #3399CC;"">
                <h5");
            BeginWriteAttribute("class", " class=\"", 2808, "\"", 2816, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-shopping-bag"" style=""margin-right:10px;""></i>Số đơn hàng</h5>
                <ul class=""list-inline two-part d-flex align-items-center mb-0"">
                    <li>
                        <div id=""sparklinedash"">
                            <canvas width=""67"" height=""30""
                                    style=""display: inline-block; width: 67px; height: 30px; vertical-align: top;""></canvas>
                        </div>
                    </li>
                    <li class=""ms-auto""><span class=""counter text-success"">");
#nullable restore
#line 72 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                                       Write(ViewBag.CountOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fa fa-shopping-bag""></i></span></li>
                </ul>
            </div>
        </div>
        <div class=""col-lg-3 col-md-12"">
            <div class=""white-box analytics-info"" style=""border: 1px solid #33FF66;"">
                <h5");
            BeginWriteAttribute("class", " class=\"", 3652, "\"", 3660, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-cubes"" style=""margin-right:10px;""></i>Số lượng sản phẩm</h5>
                <ul class=""list-inline two-part d-flex align-items-center mb-0"">
                    <li>
                        <div id=""sparklinedash2"">
                            <canvas width=""67"" height=""30""
                                    style=""display: inline-block; width: 67px; height: 30px; vertical-align: top;""></canvas>
                        </div>
                    </li>
                    <li class=""ms-auto""><span class=""counter text-purple"">");
#nullable restore
#line 86 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                                      Write(ViewBag.CountProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-cubes\"></i></span></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-3 col-md-12\">\r\n            <div class=\"white-box analytics-info\" style=\"border: 1px solid #FFCC33;\">\r\n                <h5");
            BeginWriteAttribute("class", " class=\"", 4490, "\"", 4498, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-users"" style=""margin-right: 10px;""></i>Số khách hàng</h5>
                <ul class=""list-inline two-part d-flex align-items-center mb-0"">
                    <li>
                        <div id=""sparklinedash5"">
                            <canvas width=""67"" height=""30""
                                    style=""display: inline-block; width: 67px; height: 30px; vertical-align: top;""></canvas>
                        </div>
                    </li>
                    <li class=""ms-auto"">
                        <span class=""counter text-info"">");
#nullable restore
#line 101 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                    Write(ViewBag.CountCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fa fa-users""></i></span>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""col-lg-3 col-md-12"">
            <div class=""white-box analytics-info"" style=""border: 1px solid #CC0000;"">
                <h5");
            BeginWriteAttribute("class", " class=\"", 5372, "\"", 5380, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-clone"" style=""margin-right: 10px;""></i>Lượt tương tác</h5>
                <ul class=""list-inline two-part d-flex align-items-center mb-0"">
                    <li>
                        <div id=""sparklinedash4"">
                            <canvas width=""67"" height=""30""
                                    style=""display: inline-block; width: 67px; height: 30px; vertical-align: top;""></canvas>
                        </div>
                    </li>
                    <li class=""ms-auto"">
                        <span class=""counter text-info""> ");
#nullable restore
#line 117 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                     Write(ViewBag.CountEvaluate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-comments\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 117 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                                                                                                Write(ViewBag.CountView);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-eye\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 117 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                                                                                                                                                                  Write(ViewBag.CountLike);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fa fa-thumbs-up""></i></span>
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- PRODUCTS YEARLY SALES -->
    <!-- ============================================================== -->
    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""white-box"" id=""chart-container"">
                <h5");
            BeginWriteAttribute("class", " class=\"", 6583, "\"", 6591, 0);
            EndWriteAttribute();
            WriteLiteral(@">Tổng doanh thu</h5>
                <div class=""col-md-12 col-lg-12 col-sm-12 col-xs-12"">
                    <canvas id=""myChart"" class=""col-md-12 w-100 h-100"" style=""box-sizing: border-box;""></canvas>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""white-box"">
                <h5");
            BeginWriteAttribute("class", " class=\"", 6947, "\"", 6955, 0);
            EndWriteAttribute();
            WriteLiteral(@">Doanh thu theo mục sản phẩm</h5>
                <div class=""col-md-12 col-lg-12 col-sm-12 col-xs-12"">
                    <canvas id=""myPieChart"" class=""col-md-12"" style=""box-sizing: border-box; width: 100%;""></canvas>
                </div>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- RECENT SALES -->
    <!-- ============================================================== -->
    <div class=""row"">
        <div class=""col-md-12 col-lg-12 col-sm-12"">
            <div class=""white-box"">
                <div class=""d-md-flex mb-3"">
                    <h3 class="" mb-0"">Bảng xếp hạng doanh số sản phẩm theo tháng</h3>
                </div>
                <div class=""table-responsive"">
                    <table class=""table no-wrap"">
                        <thead>
                            <tr>
                                <th class=""border-top-0"">STT</th>
                                <th class=""b");
            WriteLiteral(@"order-top-0"">Tháng</th>
                                <th class=""border-top-0"">Tên sản phẩm</th>
                                <th class=""border-top-0"">Loại danh mục</th>
                                <th class=""border-top-0"">Nhãn hiệu</th>
                                <th class=""border-top-0"">Loại sản phẩm</th>
                                <th class=""border-top-0"">Số lượng</th>
                                <th class=""border-top-0"">Doanh số</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 168 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                             for (int i = 0; i < ProductStaticals.Count(); i++)
                            {
                                string productType = "";
                                foreach (var item in ProductStaticals[i].ProdType.Split(',').Distinct().ToList())
                                {
                                    switch (item)
                                    {
                                        case "0":
                                            productType += "Sản phẩm bình thường";
                                            break;
                                        case "1":
                                            productType += ", Sản phẩm mới";
                                            break;
                                        case "2":
                                            productType += ", Sản phẩm nổi bật";
                                            break;
                                        case "3":
                                            productType += ", Sản phẩm được yêu thích";
                                            break;
                                        case "4":
                                            productType += ", Sản phẩm khuyến mại";
                                            break;
                                        default:
                                            break;
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 195 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"txt-oflo\">Tháng ");
#nullable restore
#line 196 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                           Write(ProductStaticals[i].CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"txt-oflo\">");
#nullable restore
#line 197 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                    Write(ProductStaticals[i].ProdName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"txt-oflo\">");
#nullable restore
#line 198 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                    Write(ProductStaticals[i].Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"txt-oflo\">");
#nullable restore
#line 199 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                    Write(ProductStaticals[i].Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"txt-oflo\">");
#nullable restore
#line 200 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                    Write(productType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"txt-oflo\">");
#nullable restore
#line 201 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                    Write(ProductStaticals[i].Total_Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"txt-oflo\"><span class=\"text-success\">");
#nullable restore
#line 202 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                                                                               Write(string.Format("{0:0,0} VNĐ", Convert.ToDouble(@ProductStaticals[i].Total_Revenue.ToString())));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                </tr>\r\n");
#nullable restore
#line 204 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>


<script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/chartjs-plugin-datalabels@2.0.0/dist/chartjs-plugin-datalabels.min.js""></script>
<script>

    //-- Doanh thu, Chi phí, lợi nhuận
    var chartData = ");
#nullable restore
#line 220 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
               Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    var labels = [];
    var tongThanhTienData = [];

    for (var i = 0; i < chartData.length; i++) {
        labels.push(formatDate(chartData[i].day));
        tongThanhTienData.push(chartData[i].tongThanhTien);
    }

    var ctx = document.getElementById('myChart').getContext('2d');
    var myChart = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: labels,
            datasets: [{
                label: 'Tổng doanh thu',
                data: tongThanhTienData,
                backgroundColor: 'rgba(72,209,204, 1)',
                borderColor: 'rgba(72,209,204, 1)',
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            plugins: {
                title: {
                    display: true
                },
                datalabels: {
                    color: '#fff',
                    anchor: 'center',
                    align: 'center',
                    formatter: functio");
            WriteLiteral(@"n (value, context) {
                        return value.toLocaleString(); // định dạng lại giá trị hiển thị
                    }
                }
            },
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });



    //-- Thống kê theo danh mục sản phẩm
    var ctxPieChart = document.getElementById('myPieChart').getContext('2d');

    var data = {
        labels: ");
#nullable restore
#line 272 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
           Write(Html.Raw(Json.Serialize(labels)));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        datasets: [{\r\n            data: ");
#nullable restore
#line 274 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
             Write(Html.Raw(Json.Serialize(data)));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n            backgroundColor: ");
#nullable restore
#line 275 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                        Write(Html.Raw(Json.Serialize(backgroundColor)));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n            hoverBackgroundColor: ");
#nullable restore
#line 276 "D:\DuAnTotNghiep\GProject.WebApplication\GProject.WebApplication\Views\Dashboard\Index.cshtml"
                             Write(Html.Raw(Json.Serialize(hoverBackgroundColor)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            }]
    };

    window.addEventListener('resize', function () {
        var chartContainer = document.getElementById('chart-container');
        var width = chartContainer.clientWidth;
        var height = chartContainer.clientHeight;
        console.log(width)
        myChart.resize(width, height);
    });

    var myPieChart = new Chart(ctxPieChart, {
        type: 'pie',
        data: data,
        options: {
            responsive: true,
            maintainAspectRatio: false
        }
    });


    function formatDate(date) {
            var d = new Date(date),
                month = '' + (d.getMonth() + 1),
                day = '' + d.getDate(),
                year = d.getFullYear();

            if (month.length < 2)
                month = '0' + month;
            if (day.length < 2)
                day = '0' + day;

            return [year, month, day].join('-');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GProject.WebApplication.Models.MyChartData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
