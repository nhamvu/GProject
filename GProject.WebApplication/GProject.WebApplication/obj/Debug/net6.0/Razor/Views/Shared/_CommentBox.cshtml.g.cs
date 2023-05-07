#pragma checksum "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5613b96fce108e095cac7883b3d3e0c58b2c63d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentBox), @"mvc.1.0.view", @"/Views/Shared/_CommentBox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5613b96fce108e095cac7883b3d3e0c58b2c63d", @"/Views/Shared/_CommentBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fbcf431fddd7af05102fdaaa3deed8323ce67f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<GProject.Data.DomainClass.Product, List<GProject.Data.DomainClass.ProductVariation>, GProject.Data.DomainClass.Brand, EvaluateCommentDTO, decimal, int, GProject.Data.DomainClass.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:50%; width:35px; border:2px solid black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""/AdminContent/css/style.min.css"" rel=""stylesheet"">
<link href=""/AdminContent/css/InputCss.css"" rel=""stylesheet"">
<style>

    .commentBox {
        background-color: #efefef;
        padding: 10px;
        border-radius: 10px;
    }

    .starFade {
        background-image: url(""/images/saotrang.jpg"");
        width: 30px;
        height: 30px;
        display: inline-block;
        cursor: pointer;
    }

    .starFadeN {
        background-image: url(""/images/saotrang.jpg"");
        width: 30px;
        height: 30px;
        display: inline-block;
    }

    .starGlow {
        background-image: url(""/images/sao_vang.jpg"");
        min-width: 30px;
        min-height: 30px;
        display: inline-block;
        cursor: pointer;
    }

    .starGlowN {
        background-image: url(""/images/sao_vang.jpg"");
        width: 30px;
        height: 30px;
        display: inline-block;
    }
</style>
<div class=""dl-horizontal"">
    <dt>
        Bình luận
    ");
            WriteLiteral("</dt>\r\n    <dd>\r\n        <div class=\"commentBox\">\r\n");
#nullable restore
#line 48 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
             using (Html.BeginForm("Save", "Evaluate", FormMethod.Post, new { onsubmit = "return SubmitComment()" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
                                        ;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-horizontal"">
                    <div class=""form-group"">
                        <strong style=""font-weight:normal;"">Hãy giúp chúng tôi cải thiện sản phẩm bằng cách đánh giá và chia sẻ ý kiến của bạn.</strong>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-1 d-flex justify-content-between"">
");
#nullable restore
#line 57 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
                              
                                if (string.IsNullOrEmpty(Model.Item7.Image))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a5613b96fce108e095cac7883b3d3e0c58b2c63d7314", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a5613b96fce108e095cac7883b3d3e0c58b2c63d8814", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2278, "~/images/", 2278, 9, true);
#nullable restore
#line 64 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
AddHtmlAttributeValue("", 2287, Model.Item7.Image, 2287, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""col-md-7"">
                            <div onmouseout=""CRateSelected()"">
                                <span class=""starFade"" id=""Rate1"" onclick=""CRate(1)"" onmouseover=""CRateOver(1)""></span>
                                <span class=""starFade"" id=""Rate2"" onclick=""CRate(2)"" onmouseover=""CRateOver(2)""></span>
                                <span class=""starFade"" id=""Rate3"" onclick=""CRate(3)"" onmouseover=""CRateOver(3)""></span>
                                <span class=""starFade"" id=""Rate4"" onclick=""CRate(4)"" onmouseover=""CRateOver(4)""></span>
                                <span class=""starFade"" id=""Rate5"" onclick=""CRate(5)"" onmouseover=""CRateOver(5)""></span>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""form-group col-md-12"">
                            <input type=""text"" id=""Comment"" name=""Comment"" requi");
            WriteLiteral("red class=\"form-control\" placeholder=\"Thêm nhận xét\"");
            BeginWriteAttribute("value", " value=\"", 3514, "\"", 3542, 1);
#nullable restore
#line 80 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
WriteAttributeValue("", 3522, Model.Item4.Comment, 3522, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></input>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <div class=\"col-md-12\">\r\n                                <input type=\"hidden\" id=\"Id\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 3759, "\"", 3782, 1);
#nullable restore
#line 84 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
WriteAttributeValue("", 3767, Model.Item4.Id, 3767, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                                <input type=\"hidden\" id=\"ProductId\" name=\"ProductId\"");
            BeginWriteAttribute("value", " value=\"", 3871, "\"", 3901, 1);
#nullable restore
#line 85 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
WriteAttributeValue("", 3879, Model.Item4.ProductId, 3879, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                                <input type=\"hidden\" id=\"Rating\" name=\"Rating\" />\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 91 "C:\Users\Admin\OneDrive\Documents\GitHub\GProject\GProject.WebApplication\GProject.WebApplication\Views\Shared\_CommentBox.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </dd>
</div>
<script>
    function SubmitComment(){
        if($('#Rating').val() == '0'){
            alert(""Please rate this service provider."");
            return false;
        }else
        {
            return true;
        }
    }

    function CRate(r){
        $('#Rating').val(r);
        for(var i = 1; i <= r; i++){
            $(""#Rate"" + i).attr('class', 'starGlow');
        }

        for (var i = r + 1; i <= 5; i++) {
            $(""#Rate"" + i).attr('class', 'starFade');
        }
    }

    function CRateOver(r){
        for(var i = 1; i <= r; i++){
            $(""#Rate"" + i).attr('class', 'starGlow');
        }
    }
    function CRateOut(r){
        for(var i = 1; i <= r; i++){
            $(""#Rate"" + i).attr('class', 'starFade');
        }
    }
    function CRateSelected() {
        var setRating = $('#Rating').val();
        for (var i = 1; i <= setRating; i++) {
            $(""#Rate"" + i).attr('class', 'starGlow');
        }
    ");
            WriteLiteral("}\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<GProject.Data.DomainClass.Product, List<GProject.Data.DomainClass.ProductVariation>, GProject.Data.DomainClass.Brand, EvaluateCommentDTO, decimal, int, GProject.Data.DomainClass.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
