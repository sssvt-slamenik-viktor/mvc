#pragma checksum "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9a473fb1b7cf4ce8e438e98020e16d093586f9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9a473fb1b7cf4ce8e438e98020e16d093586f9e", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9644d99b0c523aa7928cd9c7119330dc6fa1a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eshop_Slamenik.Models.SingleItemModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n\n<table class=\"table\">\n    <tr>\n        <th>Name</th>\n        <th>Popis</th>\n        <th>Picture</th>\n        <th>Dostupnost</th>\n    </tr>\n\n    <tr>\n");
#nullable restore
#line 15 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
          string path = "~/Content/img/" + Model.Item.ID + ".jpg"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 16 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
       Write(Model.Item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 17 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
       Write(Model.Item.Popis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td><img");
            BeginWriteAttribute("src", " src=\"", 352, "\"", 376, 1);
#nullable restore
#line 18 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
WriteAttributeValue("", 358, Url.Content(path), 358, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height:200px;\" /></td>\n");
#nullable restore
#line 19 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
         if (Model.Item.Availability == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>není skladem</td>\n");
#nullable restore
#line 22 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
 }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>");
#nullable restore
#line 25 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
Write(Model.Item.Availability);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 26 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </tr>\n");
#nullable restore
#line 30 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
      string a = Model.Item.ID.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"button\" value=\"Přídat do košíku\"");
            BeginWriteAttribute("onclick", " onclick=\"", 649, "\"", 698, 3);
            WriteAttributeValue("", 659, "location.href=\'", 659, 15, true);
#nullable restore
#line 31 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
WriteAttributeValue("", 674, Url.Action(a, "Kosik"), 674, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 697, "\'", 697, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 32 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
      string p = "AddItem/";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 34 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
     using (Html.BeginForm(p, "Home"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--<input type=\"submit\" />-->\n");
#nullable restore
#line 37 "D:\Škola\PRG\Projects\GITLAB\E-SHOP\Mine\eshop__-master\eshop_Slamenik\eshop_Slamenik\Views\Home\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eshop_Slamenik.Models.SingleItemModel> Html { get; private set; }
    }
}
#pragma warning restore 1591