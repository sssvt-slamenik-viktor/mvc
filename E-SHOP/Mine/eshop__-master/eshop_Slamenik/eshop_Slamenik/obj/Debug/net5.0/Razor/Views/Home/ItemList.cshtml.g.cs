#pragma checksum "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1aca81339dde240dfa23c43d4123f6c8992a3d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ItemList), @"mvc.1.0.view", @"/Views/Home/ItemList.cshtml")]
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
#line 1 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\_ViewImports.cshtml"
using eshop_Slamenik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\_ViewImports.cshtml"
using eshop_Slamenik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1aca81339dde240dfa23c43d4123f6c8992a3d5", @"/Views/Home/ItemList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9644d99b0c523aa7928cd9c7119330dc6fa1a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ItemList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eshop_Slamenik.Models.ItemModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml"
  
    //ViewData["Title"] = "List of Books";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>ITEMS</h1>\n");
#nullable restore
#line 9 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml"
  
    if (User.Identity.IsAuthenticated)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\n\n        <tr>\n            <th>Name</th>\n            <th>Popis</th>\n        </tr>\n\n");
#nullable restore
#line 21 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml"
         foreach (var item in Model.Items)
        {
            string path = "~/Content/img/"+item.ID+".jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 455, "\"", 504, 2);
            WriteAttributeValue("", 462, "http://localhost:30519/ItemDetail/", 462, 34, true);
#nullable restore
#line 25 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml"
WriteAttributeValue("", 496, item.ID, 496, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml"
                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                <td>");
#nullable restore
#line 26 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml"
               Write(item.Popis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 587, "\"", 611, 1);
#nullable restore
#line 27 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml"
WriteAttributeValue("", 593, Url.Content(path), 593, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height:200px;\" /></td>\n            </tr>\n");
#nullable restore
#line 29 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </table>\n");
#nullable restore
#line 33 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>You need to login</p>\n");
#nullable restore
#line 37 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\ItemList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eshop_Slamenik.Models.ItemModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
