#pragma checksum "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "595e97f490535d24e89749f5c1761b2b917ffbedd98ad71644c5c4ff43330fec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterEditProfile), @"mvc.1.0.view", @"/Views/Writer/WriterEditProfile.cshtml")]
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

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"595e97f490535d24e89749f5c1761b2b917ffbedd98ad71644c5c4ff43330fec", @"/Views/Writer/WriterEditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28e9796c92c1d16a3954ba6ba0aa2474261584969ce6f7ea25d023e9241fc234", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Writer_WriterEditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
  
    ViewData["Title"] = "WriterEditProfile";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
 using (Html.BeginForm("WriterEditProfile", "Writer", FormMethod.Post))
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Yazar Profil Bilgileri Düzenleme</h4>\r\n                ");
            Write(
#nullable restore
#line 13 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
                 Html.HiddenFor(x => x.WriterID , new{@class ="form-control"})

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                <p class=\"card-description\"> Basic form elements </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "595e97f490535d24e89749f5c1761b2b917ffbedd98ad71644c5c4ff43330fec5075", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Yazar Ad Soyad</label>\r\n                        ");
                Write(
#nullable restore
#line 18 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
                         Html.TextBoxFor(x => x.WriterName, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        ");
                Write(
#nullable restore
#line 19 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
                         Html.ValidationMessageFor(x => x.WriterName, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputEmail3\">Yazar Maili</label>\r\n                        ");
                Write(
#nullable restore
#line 23 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
                         Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        ");
                Write(
#nullable restore
#line 24 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
                         Html.ValidationMessageFor(x => x.WriterMail, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">Password</label>\r\n                       ");
                Write(
#nullable restore
#line 28 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
                        Html.PasswordFor(x => x.WriterPassword, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                       ");
                Write(
#nullable restore
#line 29 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
                        Html.ValidationMessageFor(x => x.WriterPassword, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"
                    </div>

                    <div class=""form-group"">
                        <label>Yazar Görsel</label>
                        <input type=""file"" name=""img[]"" class=""file-upload-default"">
                        <div class=""input-group col-xs-12"">
                            <input type=""text"" class=""form-control file-upload-info"" disabled placeholder=""Resim Yükle"">
                            <span class=""input-group-append"">
                                <button class=""file-upload-browse btn btn-gradient-primary"" type=""button"">Upload</button>
                            </span>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""exampleTextarea1"">Yazar Hakkında</label>
                        ");
                Write(
#nullable restore
#line 45 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
                         Html.TextAreaFor(x => x.WriterAbout,10 , 3 ,  new { @class = "form-control", @rows = "4" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        ");
                Write(
#nullable restore
#line 46 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
                         Html.ValidationMessageFor(x => x.WriterAbout, "", new { @class = "text-danger" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">Güncelle</button>\r\n                    <button class=\"btn btn-light\">İptal</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 54 "C:\Users\ibrah\Desktop\Asp.netCore5.0-BlogApp-\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral(" ;\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
