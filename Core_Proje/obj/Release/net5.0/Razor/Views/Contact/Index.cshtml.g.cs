#pragma checksum "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Contact\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ac9556dccd96825982ed237e099b3e5e38c9617547588b2868258ce212bcb3cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ac9556dccd96825982ed237e099b3e5e38c9617547588b2868258ce212bcb3cc", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">İletişim Kutusu</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Gönderen</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Mesajı Gör</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                         foreach (var item in Model)
                        {



#line default
#line hidden
#nullable disable

            WriteLiteral("                            <tr>\r\n                                <td>");
            Write(
#nullable restore
#line 31 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                                     item.MessageID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 32 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                                     item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 33 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                                     item.Date

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1092, "\"", 1137, 2);
            WriteAttributeValue("", 1099, "/Contact/DeleteContact/", 1099, 23, true);
            WriteAttributeValue("", 1122, 
#nullable restore
#line 34 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                                                                     item.MessageID

#line default
#line hidden
#nullable disable
            , 1122, 15, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1222, "\"", 1268, 2);
            WriteAttributeValue("", 1229, "/Contact/ContactDetails/", 1229, 24, true);
            WriteAttributeValue("", 1253, 
#nullable restore
#line 35 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                                                                      item.MessageID

#line default
#line hidden
#nullable disable
            , 1253, 15, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Mesajı Gör</a></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Views\Contact\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
