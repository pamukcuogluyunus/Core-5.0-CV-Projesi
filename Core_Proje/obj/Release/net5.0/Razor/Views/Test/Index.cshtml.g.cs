#pragma checksum "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Test\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fba3b5b7a9c19106714b3f7e50e5c67cbab382f6e7960be4ea1aa332778bb61e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fba3b5b7a9c19106714b3f7e50e5c67cbab382f6e7960be4ea1aa332778bb61e", @"/Views/Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Test\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""row"">

    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Bordered table</h4>
                <p class=""card-description"">
                    Add class <code>.table-bordered</code>
                </p>
                <div class=""table-responsive"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> First name </th>
                                <th> Progress </th>
                                <th> Amount </th>
                                <th> Deadline </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td> 1 </td>
                                <td> Herman Beck </td>
                         ");
            WriteLiteral(@"       <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                                <td> $ 77.99 </td>
                                <td> May 15, 2015 </td>
                            </tr>
                            <tr>
                                <td> 2 </td>
                                <td> Messsy Adam </td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                                <td> $245.30 </t");
            WriteLiteral(@"d>
                                <td> July 1, 2015 </td>
                            </tr>
                            <tr>
                                <td> 3 </td>
                                <td> John Richards </td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 90%"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                                <td> $138.00 </td>
                                <td> Apr 12, 2015 </td>
                            </tr>
                            <tr>
                                <td> 4 </td>
                                <td> Peter Meggik </td>
                                <td>
                                    <div class=""progress"">
                                        <div class");
            WriteLiteral(@"=""progress-bar bg-primary"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                                <td> $ 77.99 </td>
                                <td> May 15, 2015 </td>
                            </tr>
                            <tr>
                                <td> 5 </td>
                                <td> Edward </td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 35%"" aria-valuenow=""35"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                                <td> $ 160.25 </td>
                                <td> May 03, 2015 </td>
                            </tr>
                            <tr");
            WriteLiteral(@">
                                <td> 6 </td>
                                <td> John Doe </td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 65%"" aria-valuenow=""65"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                                <td> $ 123.21 </td>
                                <td> April 05, 2015 </td>
                            </tr>
                            <tr>
                                <td> 7 </td>
                                <td> Henry Tom </td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 20%"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
     ");
            WriteLiteral(@"                               </div>
                                </td>
                                <td> $ 150.00 </td>
                                <td> June 16, 2015 </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>


</div>
");
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