#pragma checksum "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "881601ea3b382f962ea0680dd1e8176525bb16e4f4a831b30c5faa3bac6b294e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
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
#line 1 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"881601ea3b382f962ea0680dd1e8176525bb16e4f4a831b30c5faa3bac6b294e", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"section pt-4 px-3 px-lg-4\" id=\"about\">\r\n    <div class=\"container-narrow\">\r\n");
#nullable restore
#line 6 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
         foreach (var item in Model)
        {
            
        

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <h2 class=\"h4 my-2\">");
            Write(
#nullable restore
#line 12 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                     item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h2>\r\n                <p>");
            Write(
#nullable restore
#line 13 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                    item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>
                <div class=""row mt-3"">
                    <div class=""col-sm-2"">
                        <div class=""pb-1"">Yaş:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
            Write(
#nullable restore
#line 19 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                     item.Age

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-sm-2"">
                        <div class=""pb-1"">Mail:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
            Write(
#nullable restore
#line 25 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                     item.Mail

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-sm-2"">
                        <div class=""pb-1"">Telefon:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
            Write(
#nullable restore
#line 31 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                     item.Phone

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</div>
                    </div>             
                    <div class=""col-sm-2"">
                        <div class=""pb-1"">Adres:</div>
                    </div>
                    <div class=""col-sm-10"">
                        <div class=""pb-1 fw-bolder"">");
            Write(
#nullable restore
#line 37 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                     item.Address

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n                    </div>           \r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-5 offset-md-1\" data-aos=\"fade-left\" data-aos-delay=\"100\"><img class=\"avatar img-fluid mt-2\"");
            BeginWriteAttribute("src", " src=\"", 1687, "\"", 1707, 1);
            WriteAttributeValue("", 1693, 
#nullable restore
#line 41 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                                                                                                 item.ImageUrl

#line default
#line hidden
#nullable disable
            , 1693, 14, false);
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"400\" alt=\"Walter Patterson\" /></div>\r\n        </div>\r\n");
#nullable restore
#line 43 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591