#pragma checksum "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6fa1b6ab2a8a64bf8f7093c4390947af572e1da14235cba9cb22d452f4336cbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_SenderMessage), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/SenderMessage.cshtml")]
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
#line 1 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6fa1b6ab2a8a64bf8f7093c4390947af572e1da14235cba9cb22d452f4336cbe", @"/Areas/Writer/Views/Message/SenderMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Message_SenderMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
  
    ViewData["Title"] = "SenderMessage";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Giden Kutusu</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Konu</th>
                            <th>Alıcı</th>
                            <th>Tarih</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                         foreach (var item in Model)
                        {
                            

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <tr>\r\n                                <th>");
            Write(
#nullable restore
#line 52 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                                     item.WriterMessageID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                                <td>");
            Write(
#nullable restore
#line 53 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                                     item.Subject

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 54 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                                     item.ReceiverName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 55 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                                      ((DateTime)item.Date).ToString("dd-MMM-yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2094, "\"", 2161, 2);
            WriteAttributeValue("", 2101, "/Writer/Message/ReceiverMessageDetails/", 2101, 39, true);
            WriteAttributeValue("", 2140, 
#nullable restore
#line 56 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                                                                                     item.WriterMessageID

#line default
#line hidden
#nullable disable
            , 2140, 21, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Mesajı Gör</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
