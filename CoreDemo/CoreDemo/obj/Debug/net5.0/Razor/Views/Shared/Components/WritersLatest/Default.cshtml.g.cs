#pragma checksum "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\WritersLatest\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a0c8b21c1fddcdce7be9f2f4219b7a0a6bef9149ea406de4238cac13e782f0c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WritersLatest_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WritersLatest/Default.cshtml")]
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
#line 1 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\WritersLatest\Default.cshtml"
 using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a0c8b21c1fddcdce7be9f2f4219b7a0a6bef9149ea406de4238cac13e782f0c5", @"/Views/Shared/Components/WritersLatest/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WritersLatest_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"tech-btm\">\r\n\r\n\t<h4>  { Yazarın ismi } Diğer Yazıları</h4>\t\t\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\WritersLatest\Default.cshtml"
  foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("\t\t<div class=\"blog-grids row mb-3\">\r\n\t\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 282, "\"", 312, 1);
            WriteAttributeValue("", 288, 
#nullable restore
#line 14 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\WritersLatest\Default.cshtml"
                item.BlogThumbnailImage

#line default
#line hidden
#nullable disable
            , 288, 24, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 331, "\"", 337, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t</a>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t\t<h5>\r\n\t\t\t\t\t<a href=\"single.html\">");
            Write(
#nullable restore
#line 20 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\WritersLatest\Default.cshtml"
                            item.BlogTitle

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </a>\r\n\t\t\t\t</h5>\r\n\t\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"far fa-clock\"></i> ");
            Write(
#nullable restore
#line 24 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\WritersLatest\Default.cshtml"
                                     ((DateTime)item.BlogCrateDate).ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n");
#nullable restore
#line 30 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Shared\Components\WritersLatest\Default.cshtml"
    }		

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\t\r\n\r\n</div>");
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
