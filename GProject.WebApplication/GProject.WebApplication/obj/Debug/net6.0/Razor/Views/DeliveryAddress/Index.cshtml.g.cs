#pragma checksum "C:\Users\huy.luu\Downloads\GProject111\GProject\GProject.WebApplication\GProject.WebApplication\Views\DeliveryAddress\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dbc86f744e6ebfca246e50097a02e666955a87e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeliveryAddress_Index), @"mvc.1.0.view", @"/Views/DeliveryAddress/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dbc86f744e6ebfca246e50097a02e666955a87e", @"/Views/DeliveryAddress/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_DeliveryAddress_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GProject.WebApplication.Models.DeliveryAddressAndShippingFee.DeliveryAddressDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formdata"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: -20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""modal fade"" id=""showDataDeliveryAddress"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" style="" background-color:white; max-width:900px"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Địa Chỉ Đặt Hàng</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div style=""margin-left: 15px"">
                    <button class=""btn btn-success col-md-2"" id=""changeform"" type=""button"" onclick=""ChangePanel()"">Thêm mới</button>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dbc86f744e6ebfca246e50097a02e666955a87e6042", async() => {
                WriteLiteral(@"
                        <input id=""txtId"" value=""0"" style=""width:0px;height:0px;visibility: hidden;"" hidden=""hidden"" />
                        <div class=""row mt-5"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label >Họ và tên:<span style=""color: red"">(*)</span></label>
                                    <div class=""col-sm-12"" style=""margin-top: 10px; margin-bottom: 10px"">
                                        <input type=""text"" id=""ShippingFullName"" name=""ShippingFullName""");
                BeginWriteAttribute("value", " value=\"", 1511, "\"", 1519, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1520, "\"", 1534, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label >Số điện thoại:<span style=""color: red"">(*)</span></label>
                                    <div class=""col-sm-12"" style=""margin-top: 10px; margin-bottom: 10px"">
                                        <input type=""text"" id=""ShippingPhone"" name=""ShippingPhone""");
                BeginWriteAttribute("value", " value=\"", 2099, "\"", 2107, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""+84"" class=""form-control"" />
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label >Tỉnh/Thành phố:</label>
                                    <div class=""col-sm-12"" style=""margin-top: 10px; margin-bottom: 10px"">
                                        <select id=""selectProvince"" class=""form-select"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dbc86f744e6ebfca246e50097a02e666955a87e8537", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label >Quận/Huyện:</label>
                                    <div class=""col-sm-12"" style=""margin-top: 10px; margin-bottom: 10px"">
                                        <select id=""selectDistrict"" class=""form-select"">
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label >Phường/Xã:</label>
                                    <div class=""col-sm-12"" style=""margin-top: 10px; margin-bottom: 10px"">
                           ");
                WriteLiteral(@"             <select id=""selectWards"" class=""form-select"">
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label >Địa chỉ chi tiết:<span style=""color: red"">(*)</span></label>
                                    <div class=""col-sm-12"" style=""margin-top: 10px; margin-bottom: 10px"">
                                        <input type=""text"" id=""ShippingAddress"" name=""ShippingAddress""");
                BeginWriteAttribute("value", " value=\"", 4389, "\"", 4397, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-2"">
                                <label></label>
                                <div class=""form-input"">
                                    <a class=""btn btn-success"" onclick=""SaveDeliveryAddress()"" style=""height:40px;width:110px;"">
                                        <i class=""fa fa-plus"" aria-hidden=""true"" style=""margin-right:4px;""></i>
                                        Lưu
                                    </a>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""modal-header"">
                    <table id=""table_data"" class=""table"">
                        <thead>
                            <tr>
                                <th class=""col-sm-9"">Địa chỉ</th>
                                <th class=""col-sm-3""></th>
                            </tr>
                        </thead>
                        <tbody class=""tbody"" id=""tbody"">
");
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>

            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('#formdata').hide();
        LoadProvince();
        LoadDataTable();
        LoadDistrict();
        LoadWard(); 
    })

    

    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GProject.WebApplication.Models.DeliveryAddressAndShippingFee.DeliveryAddressDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
