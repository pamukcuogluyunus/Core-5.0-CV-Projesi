#pragma checksum "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\VisitorMap\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1b8067a77aa0e1125e456d3cd65de5e44542624ce5aa1177c67cfe1d51fdef14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VisitorMap_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VisitorMap/Default.cshtml")]
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

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1b8067a77aa0e1125e456d3cd65de5e44542624ce5aa1177c67cfe1d51fdef14", @"/Views/Shared/Components/VisitorMap/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_VisitorMap_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Ziyaret Edilen Ülkeler</h4>
            <div class=""row"">
                <div class=""col-md-5"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td>
                                        <i class=""flag-icon flag-icon-tr""></i>
                                    </td>
                                    <td>Türkiye</td>
                                    <td class=""text-right""> 1500 </td>
                                    <td class=""text-right font-weight-medium""> 56.35% </td>
                                </tr>
                                <tr>
                                    <td>
                                        <i class=""flag-icon flag-icon-de""></i>
                                    </td>
          ");
            WriteLiteral(@"                          <td>Almanya</td>
                                    <td class=""text-right""> 800 </td>
                                    <td class=""text-right font-weight-medium""> 33.25% </td>
                                </tr>
                                <tr>
                                    <td>
                                        <i class=""flag-icon flag-icon-au""></i>
                                    </td>
                                    <td>Avustralya</td>
                                    <td class=""text-right""> 760 </td>
                                    <td class=""text-right font-weight-medium""> 15.45% </td>
                                </tr>
                                <tr>
                                    <td>
                                        <i class=""flag-icon flag-icon-gb""></i>
                                    </td>
                                    <td>Birleşik Krallık</td>
                                    <td class=""t");
            WriteLiteral(@"ext-right""> 450 </td>
                                    <td class=""text-right font-weight-medium""> 25.00% </td>
                                </tr>
                                <tr>
                                    <td>
                                        <i class=""flag-icon flag-icon-ro""></i>
                                    </td>
                                    <td>Romanya</td>
                                    <td class=""text-right""> 620 </td>
                                    <td class=""text-right font-weight-medium""> 10.25% </td>
                                </tr>
                                <tr>
                                    <td>
                                        <i class=""flag-icon flag-icon-br""></i>
                                    </td>
                                    <td>Brezilya</td>
                                    <td class=""text-right""> 230 </td>
                                    <td class=""text-right font-weight-medium""> 7");
            WriteLiteral(@"5.00% </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""col-md-7"">
                    <div id=""audience-map"" class=""vector-map""></div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
