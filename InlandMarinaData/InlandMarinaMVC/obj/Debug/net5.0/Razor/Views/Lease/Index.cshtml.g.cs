#pragma checksum "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6591db1cc67d1fee1a8d02f2e19235b6b6558ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lease_Index), @"mvc.1.0.view", @"/Views/Lease/Index.cshtml")]
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
#line 1 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\_ViewImports.cshtml"
using InlandMarinaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\_ViewImports.cshtml"
using InlandMarinaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6591db1cc67d1fee1a8d02f2e19235b6b6558ab", @"/Views/Lease/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fef231f29a414e6bcf915f5743de44a710e5e4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Lease_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InlandMarinaData.Slip>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
  
    ViewData["Title"] = "Lease a Slip";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Slips Available for leasing</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DockID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DockID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
           Write(Html.ActionLink("Add Lease", "AddLease", new { id=item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\jacke\Desktop\C# SAIT 2022\InlandMarinaData\InlandMarinaMVC\Views\Lease\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InlandMarinaData.Slip>> Html { get; private set; }
    }
}
#pragma warning restore 1591
