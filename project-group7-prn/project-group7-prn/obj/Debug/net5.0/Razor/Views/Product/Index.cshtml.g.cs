#pragma checksum "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f89ac361115b6d8cdeaf4a70ca0c9636ea8176d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 2 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\_ViewImports.cshtml"
using project_group7_prn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f89ac361115b6d8cdeaf4a70ca0c9636ea8176d", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb9ca2f82ac8512cdd6580a3111530fd08beff3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--content-->
<!---->
<div class=""product"">
    <div class=""container"">
        <div class=""col-md-3 product-price"">

            <div class="" rsidebar span_1_of_left"">
                <div class=""of-left"">
                    <h3 class=""cate"">Categories</h3>
                </div>
                <ul class=""menu"">
");
#nullable restore
#line 12 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                     foreach (Category ct in ViewBag.Category)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"item1\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f89ac361115b6d8cdeaf4a70ca0c9636ea8176d5549", async() => {
#nullable restore
#line 15 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                                                                                 Write(ct.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Cid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                                                                WriteLiteral(ct.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Cid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 17 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
            <div class=""product-middle"">

                <div class=""fit-top"">
                    <h6 class=""shop-top"">Lorem Ipsum</h6>
                    <a href=""single.html"" class=""shop-now"">SHOP NOW</a>
                    <div class=""clearfix""> </div>
                </div>
            </div>
            
            <!---->
            <div class=""product-bottom"">
                <div class=""of-left-in"">
                    <h3 class=""best"">Best Sellers</h3>
                </div>
                <div class=""product-go"">
                    <div class="" fashion-grid"">
                        <a href=""single.html""><img class=""img-responsive "" src=""images/p1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1368, "\"", 1374, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>

                    </div>
                    <div class="" fashion-grid1"">
                        <h6 class=""best2"">
                            <a href=""single.html"">
                                Lorem ipsum dolor sit
                                amet consectetuer
                            </a>
                        </h6>

                        <span class="" price-in1""> $40.00</span>
                    </div>

                    <div class=""clearfix""> </div>
                </div>
                <div class=""product-go"">
                    <div class="" fashion-grid"">
                        <a href=""single.html""><img class=""img-responsive "" src=""images/p2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2086, "\"", 2092, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>

                    </div>
                    <div class=""fashion-grid1"">
                        <h6 class=""best2"">
                            <a href=""single.html"">
                                Lorem ipsum dolor sit
                                amet consectetuer
                            </a>
                        </h6>

                        <span class="" price-in1""> $40.00</span>
                    </div>

                    <div class=""clearfix""> </div>
                </div>

            </div>
            <div class="" per1"">
                <a href=""single.html"">
                    <img class=""img-responsive"" src=""images/pro.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2781, "\"", 2787, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""six1"">
                        <h4>DISCOUNT</h4>
                        <p>Up to</p>
                        <span>60%</span>
                    </div>
                </a>
            </div>
        </div>
        <div class=""col-md-9 product1"">
            <div class="" bottom-product"">
");
#nullable restore
#line 85 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                 foreach (Product p in ViewBag.Product)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 bottom-cd simpleCart_shelfItem\">\r\n                    <div class=\"product-at \">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f89ac361115b6d8cdeaf4a70ca0c9636ea8176d11965", async() => {
                WriteLiteral("\r\n                            <img class=\"img-responsive\"");
                BeginWriteAttribute("src", " src=\"", 3478, "\"", 3492, 1);
#nullable restore
#line 90 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
WriteAttributeValue("", 3484, p.Img, 3484, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3493, "\"", 3499, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <div class=\"pro-grid\">\r\n                                <span class=\"buy-in\">Buy Now</span>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Pid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                                                            WriteLiteral(p.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Pid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Pid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Pid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <p class=\"tun\">");
#nullable restore
#line 96 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                               Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a href=\"#\" class=\"item_add\"><p class=\"number item_price\">\r\n                    <i> </i>\r\n");
#nullable restore
#line 99 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                     if (p.SalePrice != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <del style=\"margin-right: 20px\">");
#nullable restore
#line 101 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                                    Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                        <span>");
#nullable restore
#line 102 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                          Write(p.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 103 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 106 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                          Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 107 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p></a>\r\n                </div>\r\n");
#nullable restore
#line 110 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n        <div class=\"clearfix\"> </div>\r\n        <nav class=\"in\">\r\n            <ul class=\"pagination\">\r\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f89ac361115b6d8cdeaf4a70ca0c9636ea8176d18002", async() => {
                WriteLiteral("<span aria-hidden=\"true\">«</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Cid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                              WriteLiteral(ViewBag.Cid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Cid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                                                              WriteLiteral(ViewBag.pageNumber-1==0?1:ViewBag.pageNumber-1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 118 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                 for (int a = 1; a <= (ViewBag.Size); a++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li ");
#nullable restore
#line 120 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                    Write(ViewBag.pageNumber == a?"class=\"active\"":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f89ac361115b6d8cdeaf4a70ca0c9636ea8176d21788", async() => {
#nullable restore
#line 120 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                                                                                                                                Write(a);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span class=\"sr-only\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Cid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                                                                                   WriteLiteral(ViewBag.Cid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Cid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                                                                                                                   WriteLiteral(a);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 121 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f89ac361115b6d8cdeaf4a70ca0c9636ea8176d25534", async() => {
                WriteLiteral("<span aria-hidden=\"true\">»</span> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Cid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                               WriteLiteral(ViewBag.Cid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Cid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Cid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Product\Index.cshtml"
                                                                               WriteLiteral(ViewBag.pageNumber+1>ViewBag.Size?ViewBag.Size:ViewBag.pageNumber+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </li>\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n\r\n</div>\r\n\r\n<!---->\r\n<!--//content-->\r\n");
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
