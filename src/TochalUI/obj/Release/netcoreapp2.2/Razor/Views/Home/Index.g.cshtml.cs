#pragma checksum "E:\NewGit\src\TochalUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1743c80596ebd713574c458352b68ca773d0a609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\NewGit\src\TochalUI\Views\_ViewImports.cshtml"
using TochalUI;

#line default
#line hidden
#line 2 "E:\NewGit\src\TochalUI\Views\_ViewImports.cshtml"
using TochalUI.Models;

#line default
#line hidden
#line 1 "E:\NewGit\src\TochalUI\Views\Home\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#line 2 "E:\NewGit\src\TochalUI\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1743c80596ebd713574c458352b68ca773d0a609", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f0b304abae5b095fdcac43bf7aed30b591793f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(111, 38, true);
            WriteLiteral("<section class=\"background\">\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(150, 37, false);
#line 8 "E:\NewGit\src\TochalUI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Slider"));

#line default
#line hidden
            EndContext();
            BeginContext(187, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(196, 35, false);
#line 10 "E:\NewGit\src\TochalUI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("News"));

#line default
#line hidden
            EndContext();
            BeginContext(231, 50, true);
            WriteLiteral("\r\n\r\n    <div class=\"bullshit\"></div>\r\n</section>\r\n");
            EndContext();
            BeginContext(282, 37, false);
#line 14 "E:\NewGit\src\TochalUI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Ticket"));

#line default
#line hidden
            EndContext();
            BeginContext(319, 91, true);
            WriteLiteral("\r\n\r\n<!-- <hr style=\"margin: 100px 0 0 0;background-color:transparent;border: none;\"/> -->\r\n");
            EndContext();
            BeginContext(411, 39, false);
#line 17 "E:\NewGit\src\TochalUI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("MostVist"));

#line default
#line hidden
            EndContext();
            BeginContext(450, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(455, 43, false);
#line 19 "E:\NewGit\src\TochalUI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("SpecialEvent"));

#line default
#line hidden
            EndContext();
            BeginContext(498, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(503, 36, false);
#line 21 "E:\NewGit\src\TochalUI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Event"));

#line default
#line hidden
            EndContext();
            BeginContext(539, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(542, 37, false);
#line 22 "E:\NewGit\src\TochalUI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Season"));

#line default
#line hidden
            EndContext();
            BeginContext(579, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
