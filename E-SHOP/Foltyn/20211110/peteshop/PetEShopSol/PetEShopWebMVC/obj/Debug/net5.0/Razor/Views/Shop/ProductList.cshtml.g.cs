#pragma checksum "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d30dd426b24b113af11460430b02c21ca85fbaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ProductList), @"mvc.1.0.view", @"/Views/Shop/ProductList.cshtml")]
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
#line 1 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\_ViewImports.cshtml"
using PetEShopWebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\_ViewImports.cshtml"
using PetEShopWebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d30dd426b24b113af11460430b02c21ca85fbaa", @"/Views/Shop/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c344c562e62ef21316b18ec0707e60de9e40e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PetEShopWebMVC.Models.Shop.ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
  
    ViewData["Title"] = "Pet Offer";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>We\'re offering these pets</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d30dd426b24b113af11460430b02c21ca85fbaa3918", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Price</th>
            <th>Pcs on-stock</th>
            <th>Image</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
 foreach (var pet in Model.Pets) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"center-vertically\">\r\n            <td>");
#nullable restore
#line 28 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
           Write(pet.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
           Write(pet.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
           Write(pet.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>USD</span></td>\r\n            <td>");
#nullable restore
#line 31 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
           Write(pet.PiecesOnStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("class", " class=\"", 833, "\"", 903, 2);
            WriteAttributeValue("", 841, "pet-in-list", 841, 11, true);
#nullable restore
#line 32 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
WriteAttributeValue(" ", 852, pet.IsImageLandscape ? "rotate-by-90-back" : "", 853, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 904, "\"", 937, 2);
            WriteAttributeValue("", 910, "/images/pets/", 910, 13, true);
#nullable restore
#line 32 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
WriteAttributeValue("", 923, pet.ImageFile, 923, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 938, "\"", 968, 3);
            WriteAttributeValue("", 944, "pet", 944, 3, true);
            WriteAttributeValue(" ", 947, "image", 948, 6, true);
#nullable restore
#line 32 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
WriteAttributeValue(" ", 953, pet.ImageFile, 954, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            <td>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 37 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
           Write(Html.ActionLink("Edit", "pet-edit", "product", new { id = pet.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 38 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 39 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Shop\ProductList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetEShopWebMVC.Models.Shop.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
