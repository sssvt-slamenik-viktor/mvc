#pragma checksum "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Test\Cars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ead06ea7c26f5b017e51e0f6432e285ac95cb91b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Cars), @"mvc.1.0.view", @"/Views/Test/Cars.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead06ea7c26f5b017e51e0f6432e285ac95cb91b", @"/Views/Test/Cars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c344c562e62ef21316b18ec0707e60de9e40e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Cars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PetEShopWebMVC.Models.CarModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Test\Cars.cshtml"
  
    ViewData["Title"] = "Car";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Car</h1>\r\n\r\n<h2>View example \"by convention\"</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Car brand</th>\r\n            <th>Model</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Test\Cars.cshtml"
 foreach (var car in Model.Cars)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Test\Cars.cshtml"
           Write(car.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Test\Cars.cshtml"
           Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Foltyn\20211110\peteshop\PetEShopSol\PetEShopWebMVC\Views\Test\Cars.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetEShopWebMVC.Models.CarModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
