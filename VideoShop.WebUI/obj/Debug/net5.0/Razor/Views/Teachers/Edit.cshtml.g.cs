#pragma checksum "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ad843b14b24d6957c378d42bd282155909e489c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teachers_Edit), @"mvc.1.0.view", @"/Views/Teachers/Edit.cshtml")]
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
#line 1 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Edit.cshtml"
using VideoShop.Services.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Edit.cshtml"
using VideoShop.WebUI.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad843b14b24d6957c378d42bd282155909e489c", @"/Views/Teachers/Edit.cshtml")]
    public class Views_Teachers_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
    var item = new TeacherService().GetAppTeacher(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div style=""margin-top:10px"" class=""container"">
    <div class=""card"">
        <div class=""card-header"">
            Edit
        </div>
        <div class=""card-body"">
            <form class=""col-12 align-middle form-group"" action=""/Teachers/EditOP"" method=""post"">
                <input");
            BeginWriteAttribute("value", " value=\"", 530, "\"", 546, 1);
#nullable restore
#line 18 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Edit.cshtml"
WriteAttributeValue("", 538, item.Id, 538, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\" name=\"id\" />\r\n                <p>Name: </p>\r\n                <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 650, "\"", 668, 1);
#nullable restore
#line 20 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Edit.cshtml"
WriteAttributeValue("", 658, item.Name, 658, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" name=\"name\" />\r\n\r\n                <p>Age: </p>\r\n                <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 773, "\"", 790, 1);
#nullable restore
#line 23 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Edit.cshtml"
WriteAttributeValue("", 781, item.Age, 781, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" name=\"age\" />\r\n\r\n                <p>Address: </p>\r\n                <input class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 898, "\"", 919, 1);
#nullable restore
#line 26 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\Teachers\Edit.cshtml"
WriteAttributeValue("", 906, item.Address, 906, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" name=\"address\" />\r\n\r\n                <br />\r\n                <input class=\"btn btn-success\" value=\"Submit\" type=\"submit\" />\r\n            </form>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591