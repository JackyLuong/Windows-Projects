#pragma checksum "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b832967ef1348152461bef409789903df530533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rentals_Index), @"mvc.1.0.view", @"/Views/Rentals/Index.cshtml")]
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
#line 1 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\_ViewImports.cshtml"
using RentalsMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\_ViewImports.cshtml"
using RentalsMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b832967ef1348152461bef409789903df530533", @"/Views/Rentals/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d930e11965f1040d4d118a73699af35f8a7452b", @"/Views/_ViewImports.cshtml")]
    public class Views_Rentals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RentalsMVC.Models.RentalViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
  
    ViewData["Title"] = "Properties";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Rental Properties</h1>\r\n\r\n\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PropertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>           \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PropertyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>           \r\n        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\jacke\Desktop\Rentals\RentalsMVC\Views\Rentals\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RentalsMVC.Models.RentalViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
