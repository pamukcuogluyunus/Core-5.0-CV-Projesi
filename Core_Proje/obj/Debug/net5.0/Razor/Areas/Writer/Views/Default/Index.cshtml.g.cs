#pragma checksum "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4fa8d86d8732f7b78399df4ec57251f69a2a882e06204706af8e8525632c5258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/Index.cshtml")]
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
#line 1 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4fa8d86d8732f7b78399df4ec57251f69a2a882e06204706af8e8525632c5258", @"/Areas/Writer/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

#nullable restore
#line 7 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
  
    string color = "";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Duyurular</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>Tür</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                         foreach (var item in Model)
                        {
                            if(item.Status == "Yeni Yazı")
                            {
                                color = "badge badge-danger";
                            }
                            if(item.Status == "Yeni Video")
                            {
                                color = "badge badge-warning";
                            }
                            if(item.Status == "Konferans")
                            {
                                color = "badge badge-info";

                            }
                            if(item.Status == "Workshop")
                            {
                                color = "badge badge-success";
                            }
                            if(item.Status == "Bootcamp")
                            {
                                color = "badge badge-primary";
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <tr>\r\n                                <th>");
            Write(
#nullable restore
#line 50 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                                     item.ID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                                <td>");
            Write(
#nullable restore
#line 51 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                                     item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 52 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                                      ((DateTime)item.Date).ToString("dd-MMM-yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td><label");
            BeginWriteAttribute("class", " class=\"", 2069, "\"", 2083, 1);
            WriteAttributeValue("", 2077, 
#nullable restore
#line 53 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                                                   color

#line default
#line hidden
#nullable disable
            , 2077, 6, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 53 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                                                           item.Status

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</label></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2150, "\"", 2201, 2);
            WriteAttributeValue("", 2157, "/Writer/Default/AnnouncementDetails/", 2157, 36, true);
            WriteAttributeValue("", 2193, 
#nullable restore
#line 54 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                                                                                  item.ID

#line default
#line hidden
#nullable disable
            , 2193, 8, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Detaylar</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\pamuk\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591