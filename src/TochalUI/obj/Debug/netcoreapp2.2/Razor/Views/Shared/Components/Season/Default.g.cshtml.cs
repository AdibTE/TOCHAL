#pragma checksum "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e48dc37d6abdf6a5415f61f26d184601cf5362ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Season_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Season/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Season/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Season_Default))]
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
#line 1 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
using Tochal.Core.DomainModels.Entity.Blog;

#line default
#line hidden
#line 2 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
using Tochal.Core.DomainModels.SSOT;

#line default
#line hidden
#line 4 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 7 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e48dc37d6abdf6a5415f61f26d184601cf5362ad", @"/Views/Shared/Components/Season/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f0b304abae5b095fdcac43bf7aed30b591793f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Season_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContentEntity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(190, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
  
    int count = 0;

#line default
#line hidden
            BeginContext(299, 51, true);
            WriteLiteral("<section class=\"seasons\" style=\"box-shadow:none\">\r\n");
            EndContext();
#line 16 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(549, 48, true);
            WriteLiteral("    <div class=\"s-img\" style=\"display: none;\">\r\n");
            EndContext();
            BeginContext(681, 12, true);
            WriteLiteral("        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 693, "\"", 742, 2);
#line 20 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
WriteAttributeValue("", 699, fileConfig.Value.WebAddress, 699, 28, false);

#line default
#line hidden
#line 20 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
WriteAttributeValue("", 727, item.MainImage, 727, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(743, 74, true);
            WriteLiteral(" alt=\"\">\r\n    </div>\r\n        <div class=\"s-text\">\r\n            <h3><span>");
            EndContext();
            BeginContext(818, 17, false);
#line 23 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
                 Write(item.ShortContent);

#line default
#line hidden
            EndContext();
            BeginContext(835, 14, true);
            WriteLiteral("</span></h3>\r\n");
            EndContext();
            BeginContext(930, 33, true);
            WriteLiteral("            <p>\r\n                ");
            EndContext();
            BeginContext(964, 22, false);
#line 26 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
           Write(Html.Raw(item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(986, 122, true);
            WriteLiteral("\r\n            </p>\r\n            <div class=\"s-more\">\r\n                <a href=\"#seasons\"><i class=\"fas fa-angle-left\"></i>");
            EndContext();
            BeginContext(1109, 17, false);
#line 29 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
                                                               Write(Localizer["More"]);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 42, true);
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 32 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"

    }

#line default
#line hidden
            BeginContext(1177, 70, true);
            WriteLiteral("\r\n   \r\n\r\n    <div class=\"s-btns\" style=\"position:absolute;right:0;\">\r\n");
            EndContext();
#line 38 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1296, 30, true);
            WriteLiteral("            <a href=\"#seasons\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1326, "\"", 1360, 3);
            WriteAttributeValue("", 1336, "seasonSlider(", 1336, 13, true);
#line 40 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
WriteAttributeValue("", 1349, count++, 1349, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1359, ")", 1359, 1, true);
            EndWriteAttribute();
            BeginContext(1361, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1363, 10, false);
#line 40 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"
                                                             Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1373, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 41 "E:\NewGit\src\TochalUI\Views\Shared\Components\Season\Default.cshtml"

        }

#line default
#line hidden
            BeginContext(1392, 26, true);
            WriteLiteral("\r\n    </div>\r\n</section>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<FileConfig> fileConfig { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContentEntity>> Html { get; private set; }
    }
}
#pragma warning restore 1591