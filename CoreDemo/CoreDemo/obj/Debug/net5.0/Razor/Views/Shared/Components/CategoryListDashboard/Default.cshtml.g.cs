#pragma checksum "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "abd4fdded033d097759b8e4b28103e8e4301d79d0c0561687865fe3db8aabe99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryListDashboard/Default.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"abd4fdded033d097759b8e4b28103e8e4301d79d0c0561687865fe3db8aabe99", @"/Views/Shared/Components/CategoryListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Project Status</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Kategori Adı </th>
                                <th> Durum </th>
                                <th> İşlemler </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 20 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <tr>\r\n                                    <td> ");
            Write(
#nullable restore
#line 23 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                          item.CategoryID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </td>\r\n                                    <td> ");
            Write(
#nullable restore
#line 24 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                          item.CategoryName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n");
#nullable restore
#line 25 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                     if (item.CategoryStatus == true)
                                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                        <td> Aktif </td>\r\n");
#nullable restore
#line 28 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                        <td> Pasif </td>\r\n");
#nullable restore
#line 32 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
                                    <td>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                    </td>
                                </tr>
");
#nullable restore
#line 40 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                         \r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
