#pragma checksum "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e412975ab04952f36b94e408df25fba68321448"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml"
using project_group7_prn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e412975ab04952f36b94e408df25fba68321448", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb9ca2f82ac8512cdd6580a3111530fd08beff3", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <div class=""check"">
        <h1>My Order-Detail</h1>
        <div class=""col-md-9 cart-items"" id=""detail"" style=""display:none;"">
            <div class=""table Product"">
                <table class=""table table-striped"" id=""table"">
                    <thead>
                        <tr>
                            <th>Product</th>
                            <th>Quantity</th>
                            <th>Price</th>
                            <th>Sale</th>
                        </tr>
                    </thead>
                    <tbody id=""content-course"">
                        
                    </tbody>
                </table>
            </div>
            <div class=""totalMoney"" style="" display: flex; justify-content: end;"">
                <table id=""table"">
                    <thead>
                        <tr>
                            <th></th>
                            <th>Total</th>
                        </tr>
              ");
            WriteLiteral(@"      </thead>
                    <tbody id=""content-course"">
                        <tr>
                            <td style=""padding-right: 100px; padding-bottom: 5px; font-size: 17px"">Total Product:</td>
                            <td style=""font-size: 17px"" id=""ttProduct""></td>
                        </tr>
                        <tr>
                            <td style=""padding-right: 100px; padding-bottom: 5px; font-size: 17px"">Total Price:</td>
                            <td style=""font-size: 17px"" id=""ttPrice""></td>
                        </tr>
                        <tr>
                            <td style=""padding-right: 100px; padding-bottom: 5px; font-size: 17px"">Total Sale:</td>
                            <td style=""font-size: 17px"" id=""ttSale""></td>
                        </tr>
                        <hr>
                        <tr>
                            <td style=""padding-right: 100px; padding-bottom: 5px; font-size: 17px""><b>Total</b>:</td>
             ");
            WriteLiteral(@"               <td style=""font-size: 17px"" id=""tt""></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div class=""col-md-9 cart-items"" id=""detail-none"" >
        </div>
        <div class=""col-md-3 cart-total"">
");
#nullable restore
#line 54 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml"
             foreach(Order o in ViewBag.Order) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"continue\" style=\"cursor: pointer\"");
            BeginWriteAttribute("id", " id=\"", 2488, "\"", 2505, 1);
#nullable restore
#line 55 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml"
WriteAttributeValue("", 2493, o.OrderId, 2493, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2506, "\"", 2540, 3);
            WriteAttributeValue("", 2516, "ViewDetail(", 2516, 11, true);
#nullable restore
#line 55 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml"
WriteAttributeValue("", 2527, o.OrderId, 2527, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2539, ")", 2539, 1, true);
            EndWriteAttribute();
            WriteLiteral(">View Detail</a>\r\n            <div class=\"price-details\">\r\n                <h3>Order Date: ");
#nullable restore
#line 57 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml"
                            Write(o.OrderDate?.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p style=\"margin-left: 20px; margin-bottom: 5px;\">Full name: ");
#nullable restore
#line 58 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml"
                                                                         Write(o.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p style=\"margin-left: 20px; margin-bottom: 5px;\">Address: ");
#nullable restore
#line 59 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml"
                                                                       Write(o.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p style=\"margin-left: 20px; margin-bottom: 5px;\">Phone: ");
#nullable restore
#line 60 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml"
                                                                     Write(o.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"clearfix\"></div>\r\n            </div>\r\n            <ul class=\"total_price\">\r\n                <li class=\"last_price\"> <h4>Total Price:</h4></li>\r\n                <li class=\"last_price\"><span style=\"color:red\">");
#nullable restore
#line 65 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml"
                                                           Write(o.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                <div class=\"clearfix\"> </div>\r\n            </ul>\r\n");
#nullable restore
#line 68 "C:\Users\ASUS\OneDrive\Documents\Computer\project-prn\project-group7-prn\project-group7-prn\Views\Order\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""clearfix""></div>
            
        </div>

        <div class=""clearfix""> </div>
    </div>
</div>
<script>
    function ViewDetail(orderId) {
        document.getElementById('detail').style.display = 'block';
        document.getElementById('detail-none').style.display = 'none';
        $.ajax({
            url: '/Order/OrderDetail/',
            dataType: ""json"",
            type: ""POST"",
            data: { orderId: orderId },
            success: function (data) {
                const orderDetail = data;
                let ttproduct = 0;
                let ttprice = 0;
                let ttsale = 0;
                let tt = 0;
                var bodyTable = document.getElementById('content-course');
                for (var i = 0; i < orderDetail.length; i++) {
                    bodyTable.innerHTML +=  ""   <tr>"" +
                                            ""       <td> <img style=\""width: 10%;\"" src="" + orderDetail[i].img + ""> "" + orderDetail[i].");
            WriteLiteral(@"title + ""</td>"" +
                                            ""       <td>"" + orderDetail[i].quantity +""</td>"" +
                                            ""       <td style=\""color: red;\"">"" + orderDetail[i].price + ""</td>"" +
                                            ""       <td style=\""color: red;\"">"" + (orderDetail[i].price - orderDetail[i].salePrice) + ""</td>"" +
                                            ""   </tr >"";
                    ttproduct += orderDetail[i].quantity;
                    ttprice += (orderDetail[i].price * orderDetail[i].quantity);
                    ttsale += ((orderDetail[i].price - orderDetail[i].salePrice) * orderDetail[i].quantity);
                }
                tt = ttprice - ttsale;
                document.getElementById('ttProduct').innerHTML = ttproduct;
                document.getElementById('ttPrice').innerHTML = ttprice;
                document.getElementById('ttSale').innerHTML = ttsale;
                document.getElementById('tt').innerHTML = t");
            WriteLiteral("t;\r\n            },\r\n        });\r\n    }\r\n</script>\r\n\r\n    < !--//content-->\r\n");
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
