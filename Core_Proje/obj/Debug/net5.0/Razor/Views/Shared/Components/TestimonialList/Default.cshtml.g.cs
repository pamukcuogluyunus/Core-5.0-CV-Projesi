#pragma checksum "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0ad3613c908a364fda5d16a29c37e816383c7103bed3e41dac0e0ab2e947a2d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TestimonialList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
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
#line 1 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0ad3613c908a364fda5d16a29c37e816383c7103bed3e41dac0e0ab2e947a2d3", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_TestimonialList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"testimonials\">\r\n    <div class=\"container-narrow\">\r\n        <div class=\"text-center mb-5\">\r\n            <h2 class=\"marker marker-center\">Referanslar</h2>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
             foreach (var item in Model)
            {
                
            

#line default
#line hidden
#nullable disable

            WriteLiteral("            <div class=\"col-md-12\" data-aos=\"fade-right\" data-aos-delay=\"100\">\r\n                <div class=\"d-flex ms-md-3\"><span><i class=\"fas fa-2x fa-quote-left\"></i></span><span class=\"m-2\">");
            Write(
#nullable restore
#line 15 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                                                                                   item.Comment

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span></div>\r\n                <div class=\"d-flex justify-content-end align-items-end\">\r\n                    <div class=\"text-end me-2\">\r\n                        <div class=\"fw-bolder\">");
            Write(
#nullable restore
#line 18 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                item.ClientName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n                        <div class=\"text-small\">");
            Write(
#nullable restore
#line 19 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                 item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" / ");
            Write(
#nullable restore
#line 19 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                               item.Company

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n                    </div><img class=\"me-md-3 rounded\"");
            BeginWriteAttribute("src", " src=\"", 940, "\"", 960, 1);
            WriteAttributeValue("", 946, 
#nullable restore
#line 20 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                             item.ImageUrl

#line default
#line hidden
#nullable disable
            , 946, 14, false);
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"client 1\" />\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591