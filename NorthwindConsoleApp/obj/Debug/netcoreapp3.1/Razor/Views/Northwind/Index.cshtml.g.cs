#pragma checksum "F:\GrandCircus\C#\NorthwindConsoleApp\NorthwindConsoleApp\Views\Northwind\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a97d98076650f626aea37059596f8be3abe6d978"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Northwind_Index), @"mvc.1.0.view", @"/Views/Northwind/Index.cshtml")]
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
#line 1 "F:\GrandCircus\C#\NorthwindConsoleApp\NorthwindConsoleApp\Views\_ViewImports.cshtml"
using NorthwindConsoleApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GrandCircus\C#\NorthwindConsoleApp\NorthwindConsoleApp\Views\_ViewImports.cshtml"
using NorthwindConsoleApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97d98076650f626aea37059596f8be3abe6d978", @"/Views/Northwind/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4186613e30007104ad4c3206a26233eb93659086", @"/Views/_ViewImports.cshtml")]
    public class Views_Northwind_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>GPA</th>\r\n        <th>Grad</th>\r\n        <th>Location</th>\r\n    </tr>\r\n");
#nullable restore
#line 9 "F:\GrandCircus\C#\NorthwindConsoleApp\NorthwindConsoleApp\Views\Northwind\Index.cshtml"
     foreach (var employee in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 12 "F:\GrandCircus\C#\NorthwindConsoleApp\NorthwindConsoleApp\Views\Northwind\Index.cshtml"
           Write(employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 14 "F:\GrandCircus\C#\NorthwindConsoleApp\NorthwindConsoleApp\Views\Northwind\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
