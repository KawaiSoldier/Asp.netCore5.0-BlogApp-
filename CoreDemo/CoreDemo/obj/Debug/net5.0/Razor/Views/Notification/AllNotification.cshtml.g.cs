#pragma checksum "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e0d122c95d390a9609a5b28d08d64785b346d49b5ecb17182321c0d22c6d0bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllNotification), @"mvc.1.0.view", @"/Views/Notification/AllNotification.cshtml")]
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
#line 1 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e0d122c95d390a9609a5b28d08d64785b346d49b5ecb17182321c0d22c6d0bc8", @"/Views/Notification/AllNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Notification_AllNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
  
    ViewData["Title"] = "AllNotification";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>AllNotification</h1>\r\n\r\n<table class=\"table table-borderless\" >\r\n\r\n\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Bildirim</th>\r\n        <th>Tarih</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("       <tr>\r\n                     <td>");
            Write(
#nullable restore
#line 21 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
                          item.NotificationID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 22 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
                 item.NotificationDetails

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 23 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
                 item.NotificationDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n        \r\n       </tr>\r\n");
#nullable restore
#line 26 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
