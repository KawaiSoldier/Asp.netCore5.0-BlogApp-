#pragma checksum "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastDashboard\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f13316033f9fe5f320fe48d4b5e729af6760d86dc9dd25bc3a6a5ad9041f365d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLastDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLastDashboard/Default.cshtml")]
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
#line 1 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastDashboard\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f13316033f9fe5f320fe48d4b5e729af6760d86dc9dd25bc3a6a5ad9041f365d", @"/Views/Shared/Components/BlogLastDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLastDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son Yayınlanan 10 Bloglar</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> Blog Başlığı </th>
                                <th> Kategori </th>
                                <th>Tarih </th>
                                <th> Tracking ID </th>
                                <th>Detaylar </th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 22 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 985, "\"", 1015, 1);
            WriteAttributeValue("", 991, 
#nullable restore
#line 26 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastDashboard\Default.cshtml"
                                                   item.BlogThumbnailImage

#line default
#line hidden
#nullable disable
            , 991, 24, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"> ");
            Write(
#nullable restore
#line 26 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastDashboard\Default.cshtml"
                                                                                                       item.BlogTitle

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                    </td>\r\n                               \r\n                                    <td>\r\n                                        <label class=\"badge badge-gradient-success\">");
            Write(
#nullable restore
#line 30 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastDashboard\Default.cshtml"
                                                                                     item.Category.CategoryName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</label>\r\n                                    </td>\r\n                                    <td> ");
            Write(
#nullable restore
#line 32 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastDashboard\Default.cshtml"
                                           ((DateTime)item.BlogCrateDate).ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td> ");
            Write(
#nullable restore
#line 33 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastDashboard\Default.cshtml"
                                          item.BlogID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1549, "\"", 1586, 2);
            WriteAttributeValue("", 1556, "/Blog/BlogReadAll/", 1556, 18, true);
            WriteAttributeValue("", 1574, 
#nullable restore
#line 34 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastDashboard\Default.cshtml"
                                                                    item.BlogID

#line default
#line hidden
#nullable disable
            , 1574, 12, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-dark btn-sm\">Detaylar</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\BlogLastDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                           \r\n                 \r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
