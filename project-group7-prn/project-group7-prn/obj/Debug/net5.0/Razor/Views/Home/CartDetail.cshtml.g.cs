#pragma checksum "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34dab625159d586499c449031e94fd1c08a4f68e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CartDetail), @"mvc.1.0.view", @"/Views/Home/CartDetail.cshtml")]
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
#line 1 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\_ViewImports.cshtml"
using project_group7_prn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
using project_group7_prn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34dab625159d586499c449031e94fd1c08a4f68e", @"/Views/Home/CartDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb9ca2f82ac8512cdd6580a3111530fd08beff3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CartDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n        <div class=\"container\">\r\n");
#nullable restore
#line 9 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
              
                List<CartDetail> lst = ViewBag.cartDetails;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
             if (ViewBag.cartDetails == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"width:100%; height:500px; padding-top:50px;\">\r\n                    <div class=\"alert alert-danger\" role=\"alert\" style=\"text-align:center\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
                   Write(ViewBag.mess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 20 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"

            }
            else
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"check\">\r\n            <h1>My Shopping Bag (");
#nullable restore
#line 26 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
                            Write(lst.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</h1>
            <div class=""col-md-9 cart-items"">

                <script>
                    $(document).ready(function (c) {
                        $('.close1').on('click', function (c) {
                            $('.cart-header').fadeOut('slow', function (c) {
                                $('.cart-header').remove();
                            });
                        });
                    });
                </script>
");
#nullable restore
#line 38 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
                  
                    onlineShopSWPContext context = new onlineShopSWPContext();
                    foreach (CartDetail c in ViewBag.cartDetails)
                    {
                        Product p = context.Products.FirstOrDefault(x => x.ProductId == c.ProductId);




#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"cart-sec simpleCart_shelfItem\">\r\n                            <div class=\"cart-item cyc\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34dab625159d586499c449031e94fd1c08a4f68e8050", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1588, "~/Individual/User/Images/", 1588, 25, true);
#nullable restore
#line 48 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
AddHtmlAttributeValue("", 1613, p.Img, 1613, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"cart-item-info\">\r\n                                <h3><a");
            BeginWriteAttribute("href", " href=\"", 1787, "\"", 1794, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
                                          Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span>ID : ");
#nullable restore
#line 51 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
                                                                 Write(p.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                                <ul class=\"qty\">\r\n\r\n                                    <li><p>Qty : <input type=\"number\" name=\"txtNumber\"");
            BeginWriteAttribute("value", " value=\"", 1983, "\"", 2002, 1);
#nullable restore
#line 54 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
WriteAttributeValue("", 1991, c.Quantity, 1991, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></p></li>\r\n\r\n                                </ul>\r\n                            </div>\r\n\r\n                            <div class=\"clearfix\"></div>\r\n                        </div>\r\n");
#nullable restore
#line 61 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"


                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n\r\n\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34dab625159d586499c449031e94fd1c08a4f68e11764", async() => {
                WriteLiteral("\r\n                <div class=\"col-md-3 cart-total\">\r\n                    <div class=\"price-details\">\r\n                        <h3>Price Details</h3>\r\n                        <span>Total</span>\r\n                        <span class=\"total1\">");
#nullable restore
#line 75 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
                                        Write(ViewBag.cart.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                        <span>Discount</span>
                        <span class=""total1"">---</span>
                    </div>
                    <ul class=""total_price"">
                        <li class=""last_price""> <h4>TOTAL</h4></li>
                        <li class=""last_price""><span>");
#nullable restore
#line 81 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
                                                Write(ViewBag.cart.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n                        <div class=\"clearfix\"> </div>\r\n  \r\n                        <button type=\"submit\" >Submit</button>\r\n                    </ul>\r\n\r\n                    <input type=\"hidden\" name=\"txtCartId\"");
                BeginWriteAttribute("value", " value=\"", 3157, "\"", 3185, 1);
#nullable restore
#line 87 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
WriteAttributeValue("", 3165, ViewBag.cart.CartId, 3165, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <div class=\"clearfix\"> </div>\r\n        </div>\r\n");
#nullable restore
#line 94 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Home\CartDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
