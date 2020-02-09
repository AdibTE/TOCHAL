#pragma checksum "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0845ec57d8fbbf7ae08172af11f4d355a87f8b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Event_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Event/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Event/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Event_Default))]
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
#line 1 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
using Tochal.Core.DomainModels.Entity.Blog;

#line default
#line hidden
#line 2 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
using Tochal.Core.DomainModels.SSOT;

#line default
#line hidden
#line 4 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 6 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 8 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0845ec57d8fbbf7ae08172af11f4d355a87f8b5f", @"/Views/Shared/Components/Event/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f0b304abae5b095fdcac43bf7aed30b591793f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Event_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContentEntity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(219, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(301, 52, true);
            WriteLiteral("<section class=\"eventbox\">\r\n    <h3 class=\"e-title\">");
            EndContext();
            BeginContext(354, 18, false);
#line 11 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
                   Write(Localizer["Event"]);

#line default
#line hidden
            EndContext();
            BeginContext(372, 37, true);
            WriteLiteral("</h3>\r\n    <div class=\"events\">\r\n\r\n\r\n");
            EndContext();
#line 15 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
         if (Model.Count > 0)
        {
            foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(507, 72, true);
            WriteLiteral("                <div class=\"event\" id=\"event\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 579, "\"", 628, 2);
#line 20 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
WriteAttributeValue("", 585, fileConfig.Value.WebAddress, 585, 28, false);

#line default
#line hidden
#line 20 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
WriteAttributeValue("", 613, item.MainImage, 613, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(629, 10, true);
            WriteLiteral(" alt=\"\">\r\n");
            EndContext();
            BeginContext(749, 45, true);
            WriteLiteral("                    <div class=\"eventtext\">\r\n");
            EndContext();
#line 23 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
                         if (item.CreatedDate.HasValue)
                        {

#line default
#line hidden
            BeginContext(878, 32, true);
            WriteLiteral("                            <h5>");
            EndContext();
            BeginContext(911, 46, false);
#line 25 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
                           Write(item?.CreatedDate.Value.ToPersianDateTextify());

#line default
#line hidden
            EndContext();
            BeginContext(957, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 26 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(991, 28, true);
            WriteLiteral("                        <h3>");
            EndContext();
            BeginContext(1020, 10, false);
#line 27 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1030, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(1065, 17, false);
#line 28 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
                      Write(item.ShortContent);

#line default
#line hidden
            EndContext();
            BeginContext(1082, 80, true);
            WriteLiteral("</p>\r\n                        <a href=\"#event\"><i class=\"fas fa-angle-left\"></i>");
            EndContext();
            BeginContext(1163, 17, false);
#line 29 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
                                                                     Write(Localizer["More"]);

#line default
#line hidden
            EndContext();
            BeginContext(1180, 58, true);
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 32 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
            }
        }
        else
        {


#line default
#line hidden
            BeginContext(1291, 3869, true);
            WriteLiteral(@"            <div class=""event"" id=""event"">
                <img src=""http://www.tochal.org/images/contents/14474/222.jpg"" alt="""">
                <div class=""eventtext"">
                    <h5>هر روز: 29 مهر تا 5 آبان</h5>
                    <h3>بلیت اتوبوس رایگان</h3>
                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت تفاده قرار گیرد.</p>
                    <a href=""#event""><i class=""fas fa-angle-left""></i>ادامه مطلب</a>
                </div>
            </div>
            <div class=""event"" id=""event"">
                <img src=""http://www.tochal.org/images/contents/14474/222.jpg"" alt="""">
                <div class=""eventtext"">
                    <h5>هر روز: 29 مهر تا 5 آبان</h5>
                    <h3>بلیت اتوبوس رایگان</h3>
                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با ");
            WriteLiteral(@"هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد. در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها و شرایط سخت تایپ به پایان رسد وزمان مورد نیاز شامل حروفچینی دستاوردهای اصلی و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.</p>
                    <a href=""#event""><i class=""fas fa-angle-left""></i>ادامه مطلب</a>
                </div>
            </div>
            <div class=""event"" id=""event"">
                <img src=""http://www.tochal.org/images/contents/14474/222.jpg"" alt="""">
                <div class=""eventtext"">
                    <h5>هر روز: 29 مهر تا 5 آبان</h5>
                    <h3>بلیت اتوبوس رایگان</h3>
                    <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه ");
            WriteLiteral(@"و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد. در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها و شرایط سخت تایپ به پایان رسد وزمان مورد نیاز شامل حروفچینی دستاوردهای اصلی و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.</p>
                    <a href=""#event""><i class=""fas fa-angle-left""></i>ادامه مطلب</a>
                </div>
            </div>
            <div class=""event"" id=""event"">
                <img src=""http://www.tochal.org/images/contents/14474/222.jpg"" alt="""">
                <div class=""eventtext"">
                    <h5>هر روز: 29 مهر تا 5 آبان</h5>
                    <h3>بلیت اتوبوس رایگان</h3>
                    <p>لورم ایپسوم متن ساختگی ب");
            WriteLiteral(@"ا تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد. در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها و شرایط سخت تایپ به پایان رسد وزمان مورد نیاز شامل حروفچینی دستاوردهای اصلی و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.</p>
                    <a href=""#event""><i class=""fas fa-angle-left""></i>ادامه مطلب</a>
                </div>
            </div>
");
            EndContext();
#line 73 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"

        }

#line default
#line hidden
            BeginContext(5173, 72, true);
            WriteLiteral("\r\n    </div>\r\n    <a href=\"/Home/MoreEvent\" class=\"e-more\" href=\"#more\">");
            EndContext();
            BeginContext(5246, 22, false);
#line 77 "E:\NewGit\src\TochalUI\Views\Shared\Components\Event\Default.cshtml"
                                                     Write(Localizer["MoreEvent"]);

#line default
#line hidden
            EndContext();
            BeginContext(5268, 18, true);
            WriteLiteral("</a>\r\n</section>\r\n");
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
