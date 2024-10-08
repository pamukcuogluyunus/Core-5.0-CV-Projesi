#pragma checksum "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3ce68ade8454b7f705cb59ce1d8325fd2266ae26b95c66506adc857f2d71d991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
#line 1 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3ce68ade8454b7f705cb59ce1d8325fd2266ae26b95c66506adc857f2d71d991", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th> Ana Görsel </th>
                                <th> Proje Adı </th>
                                <th> URL </th>
                                <th> Fiyat </th>
                                <th> Tamamlanma </th>
                                <th> Durum </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 23 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach (var item in Model)
                            {



#line default
#line hidden
#nullable disable

            WriteLiteral("                                <tr>\r\n                                    <td>");
            Write(
#nullable restore
#line 28 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                         item.PortfolioID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1092, "\"", 1112, 1);
            WriteAttributeValue("", 1098, 
#nullable restore
#line 29 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                                   item.ImageUrl

#line default
#line hidden
#nullable disable
            , 1098, 14, false);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                    <td>");
            Write(
#nullable restore
#line 30 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                         item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td>");
            Write(
#nullable restore
#line 31 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                         item.ProjectUrl

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td>");
            Write(
#nullable restore
#line 32 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                         item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td>%");
            Write(
#nullable restore
#line 33 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                          item.Value

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1444, "\"", 1493, 2);
            WriteAttributeValue("", 1451, "/Portfolio/EditPortfolio/", 1451, 25, true);
            WriteAttributeValue("", 1476, 
#nullable restore
#line 35 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                                                           item.PortfolioID

#line default
#line hidden
#nullable disable
            , 1476, 17, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"badge badge-outline-success\">Detayları Gör</div>\r\n                                            </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
