#pragma checksum "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2539e01a3766ce66d50f36ad60a4817d2403a7ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Details.cshtml")]
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
#line 1 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\_ViewImports.cshtml"
using Shoe_Kart_Shopping_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\_ViewImports.cshtml"
using Shoe_Kart_Shopping_Project_Model.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2539e01a3766ce66d50f36ad60a4817d2403a7ef", @"/Areas/Customer/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27476bddb11cc03f9fdd6c2f4d3f872de98bba65", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customer_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shoe_Kart_Shopping_Model.ViewModels.ShoeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control  btn-square btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2539e01a3766ce66d50f36ad60a4817d2403a7ef6750", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2539e01a3766ce66d50f36ad60a4817d2403a7ef7047", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 5 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ShoppingCart.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <div class=""container backgroundWhite"">
        <div class=""card"">
            <div class=""card-header bg-light text-light ml-0  container"">
                <div class=""row"">
                    <div class=""col-12 col-md-6"">
                        <h1 class=""text-primary"">");
#nullable restore
#line 11 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
                                            Write(Model.ShoppingCart.Product.SerialNo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                        <p class=\"text-warning\">");
#nullable restore
#line 12 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
                                           Write(Model.ShoppingCart.Product.Brand.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-12 col-md-6 text-md-right pt-4\">\r\n                        <span class=\"badge bg-success pt-2 p-3\" style=\"height:30px;\"><font size=\"4\">");
#nullable restore
#line 15 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
                                                                                               Write(Model.ShoppingCart.Product.Brand.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</font></span>\r\n                        <span class=\"badge bg-info pt-2 p-3\" style=\"height:30px;\"><font size=\"4\">");
#nullable restore
#line 16 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
                                                                                            Write(Model.ShoppingCart.Product.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</font></span>\r\n");
                WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""container rounded p-2"">
                    <div class=""row"">
                        <div class=""col-8 col-lg-8"">


");
                WriteLiteral("                            <div class=\"row pl-2\">\r\n");
                WriteLiteral("                                ");
#nullable restore
#line 31 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
                           Write(Html.DropDownListFor(m => m.ShoppingCart.ShoeSizeSelectorId, Model.ShoeSizeList, "Select Size", new { @class = "" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2539e01a3766ce66d50f36ad60a4817d2403a7ef11834", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 32 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ShoppingCart.ShoeSizeSelectorId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n\r\n\r\n\r\n                            <div class=\"row pl-2\">\r\n                                <h5 class=\"text-muted pb-2\">List Price: <strike>");
#nullable restore
#line 38 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
                                                                           Write(Model.ShoppingCart.Product.ListPrice.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strike></h5>
                            </div>
                            <div class=""row text-center pl-2"">
                                <div class=""p-1 col-2 bg-secondary border-bottom"">
                                    <div>Quantity</div>
                                </div>
                                <div class=""p-1 col-2 bg-secondary border-bottom"">
                                    <div>1-49</div>
                                </div>
                                <div class=""p-1 col-2 bg-secondary border-bottom"">
                                    <div>50-99</div>
                                </div>
");
                WriteLiteral(@"                            </div>
                            <div class=""row text-center pl-2"" style=""color:maroon; font-weight:bold"">
                                <div class=""p-1 col-2 bg-secondary"">
                                    <div>Price</div>
                                </div>
                                <div class=""p-1 col-2 bg-secondary"">
                                    <div>");
#nullable restore
#line 59 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
                                    Write(Model.ShoppingCart.Product.Price.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n                                <div class=\"p-1 col-2 bg-secondary\">\r\n                                    <div>");
#nullable restore
#line 62 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
                                    Write(Model.ShoppingCart.Product.Price50.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n");
                WriteLiteral("                            </div>\r\n\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\r\n\r\n                            <div class=\"row pl-2\">\r\n                                <p class=\"text-secondary\">");
#nullable restore
#line 104 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
                                                     Write(Html.Raw(@Model.ShoppingCart.Product.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                            <br />
                            <div class=""row pl-2"">
                                <div class=""col-2 text-primary""><h4>Count</h4></div>
                                <div class=""col-10"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2539e01a3766ce66d50f36ad60a4817d2403a7ef17031", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 109 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ShoppingCart.Count);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-12 col-lg-3 offset-lg-1 text-center\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 6345, "\"", 6387, 1);
#nullable restore
#line 113 "D:\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Shoe_Kart_Shopping_Project\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 6351, Model.ShoppingCart.Product.ImageURL, 6351, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" width=""100%"" class=""rounded"" />
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card-footer"">
                <div class=""row"">
                    <div class=""col-12 col-md-6 pb-1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2539e01a3766ce66d50f36ad60a4817d2403a7ef19599", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <div class=""col-12 col-md-6 pb-1"">

                        <button type=""submit"" value=""Add to Cart"" class=""btn btn-primary btn-square btn-lg form-control"" style=""height:50px;"">Add to Cart</button>

                    </div>
                </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2539e01a3766ce66d50f36ad60a4817d2403a7ef22631", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shoe_Kart_Shopping_Model.ViewModels.ShoeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
