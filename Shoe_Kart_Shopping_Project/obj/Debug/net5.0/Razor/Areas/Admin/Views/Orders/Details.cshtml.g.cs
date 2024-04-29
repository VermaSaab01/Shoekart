#pragma checksum "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b61db289767c6797edfeec1a41b55910670e2396"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Details.cshtml")]
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
#line 1 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\_ViewImports.cshtml"
using Shoe_Kart_Shopping_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\_ViewImports.cshtml"
using Shoe_Kart_Shopping_Project_Model.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61db289767c6797edfeec1a41b55910670e2396", @"/Areas/Admin/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27476bddb11cc03f9fdd6c2f4d3f872de98bba65", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shoe_Kart_Shopping_Model.OrderDetails>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <h2 class=\"text-primary text-center\">\r\n            All Details Of Order By :&nbsp; <i class=\"fas fa-user\"></i>&nbsp;");
#nullable restore
#line 5 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                                        Write(Model.OrderHeader.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </h2>
    </div>
</div>
<div class=""border container p-2 m-2"">
    <table class=""table table-striped table-bordered table-hover table-responsive active"">
        <thead>
            <tr>
                <th class=""text-center text-primary"">Customer Name      :</th>
                <td class=""text-center text-success"">");
#nullable restore
#line 14 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">Payment Status     :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 19 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.PaymentStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">Total Amount       :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 24 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.OrderTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">Order Status       :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 29 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">Date & Time        :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 34 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">TransactionId        :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 38 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.TransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>
        </thead>
    </table>
    <h2 class=""text-center text-primary""><i class=""fas fa-shopping-cart""></i>Products Details</h2>
    <table class=""table table-striped table-bordered table-hover table-responsive active"">
        <thead>
            <tr>
                <th class=""text-center text-primary"">Brand      :</th>
                <td class=""text-center text-success"">");
#nullable restore
#line 47 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.Product.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">Model Name     :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 52 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.Product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

            </tr>
            
          
          
        
           
        </thead>
    </table>
    <h2 class=""text-center text-primary""><i class=""fas fa-user""></i>User's Details'</h2>
    <table class=""table table-striped table-bordered table-hover table-responsive active"">
        <thead>
            <tr>
                <th class=""text-center text-primary"">Name      :</th>
                <td class=""text-center text-success"">");
#nullable restore
#line 67 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.ApplicationUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">Email Address     :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 72 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.ApplicationUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">Contact Number     :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 77 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.ApplicationUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">Street Address       :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 82 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.ApplicationUser.StreetAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">City       :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 87 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.ApplicationUser.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">State        :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 92 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.ApplicationUser.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th class=\"text-center text-primary\">Postal Code        :</th>\r\n                <td class=\"text-center text-success\">");
#nullable restore
#line 96 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Admin\Views\Orders\Details.cshtml"
                                                Write(Model.OrderHeader.ApplicationUser.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </thead>\r\n    </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shoe_Kart_Shopping_Model.OrderDetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591