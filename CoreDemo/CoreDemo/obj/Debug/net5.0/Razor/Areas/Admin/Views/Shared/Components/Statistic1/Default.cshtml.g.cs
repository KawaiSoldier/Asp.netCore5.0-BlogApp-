#pragma checksum "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "428246a9511dfb4cf829a733d6b0c7443e2b237e3c791d7d3131374c3aa39d32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic1_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic1/Default.cshtml")]
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
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"428246a9511dfb4cf829a733d6b0c7443e2b237e3c791d7d3131374c3aa39d32", @"/Areas/Admin/Views/Shared/Components/Statistic1/Default.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Components_Statistic1_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""widget style1"">
            <div class=""row"">
                <div class=""col-4 text-center"">
                    <i class=""fa fa-trophy fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Toplam Blog Sayısı </span>
                    <h2 class=""font-bold"">");
            Write(
#nullable restore
#line 10 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                           ViewBag.BlogSayisi

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 navy-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-cloud fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> Hava Durumu </span>
                    <h2 class=""font-bold"">26'C</h2>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 lazur-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-envelope-o fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span>Toplam Mesaj Sayısı</span>
                    <h2 class=""font-bold"">");
            Write(
#nullable restore
#line 36 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                           ViewBag.MesajSayisi

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h2>
                  
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget style1 yellow-bg"">
            <div class=""row"">
                <div class=""col-4"">
                    <i class=""fa fa-music fa-5x""></i>
                </div>
                <div class=""col-8 text-right"">
                    <span> En Fazla Blog Yazan Yazar </span>
                    <h2 class=""font-bold""> ");
            Write(
#nullable restore
#line 50 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                                            ViewBag.EnFazlaBlogYazanYazar

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h2>\r\n                    <br />\r\n                    <small> ");
            Write(
#nullable restore
#line 52 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic1\Default.cshtml"
                             ViewBag.EnÇokBlogYazanYazarınYazdığıBlogSayısı

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" Adet Blog</small>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591