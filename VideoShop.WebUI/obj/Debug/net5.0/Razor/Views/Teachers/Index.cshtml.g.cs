#pragma checksum "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fedc854e66104bbb4f2547aa6e53a1b52bcac7c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teachers_Index), @"mvc.1.0.view", @"/Views/Teachers/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
using VideoShop.Core.Domains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
using VideoShop.Services.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fedc854e66104bbb4f2547aa6e53a1b52bcac7c6", @"/Views/Teachers/Index.cshtml")]
    public class Views_Teachers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Teacher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.11.5/css/jquery.dataTables.css"">
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.11.5/js/jquery.dataTables.js""></script>
<div class=""container-fluid py-4"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <p>Teachers</p>
                    <a href=""/Teachers/Create"" class=""btn btn-success"">Create</a>
                </div>
                <div class=""card-body"">
                    <table id=""table_id"" class=""display"">
                        <thead>
                            <tr>
                                <th>Full Name</th>
                                <th>Age</th>
                                <th>Address</th>
                                <th></th>
                                <th></th>
                                <th></th>
                            </tr>
        ");
            WriteLiteral("                </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 35 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 36 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
                                   Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 37 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
                                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1616, "\"", 1651, 2);
            WriteAttributeValue("", 1623, "/Teachers/Edit?Id=", 1623, 18, true);
#nullable restore
#line 38 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
WriteAttributeValue("", 1641, item.Id, 1641, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a></td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1734, "\"", 1772, 2);
            WriteAttributeValue("", 1741, "/Teachers/Details?Id=", 1741, 21, true);
#nullable restore
#line 39 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
WriteAttributeValue("", 1762, item.Id, 1762, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Details</a></td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1858, "\"", 1895, 2);
            WriteAttributeValue("", 1865, "/Teachers/Delete?Id=", 1865, 20, true);
#nullable restore
#line 40 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
WriteAttributeValue("", 1885, item.Id, 1885, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n        let table = new DataTable(\'#table_id\', {\r\n    });\r\n</script>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591