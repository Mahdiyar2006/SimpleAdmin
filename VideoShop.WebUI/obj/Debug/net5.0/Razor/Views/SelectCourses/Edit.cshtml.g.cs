#pragma checksum "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "478b3a6e9fc13beb87842dc04b6b6da50e88fd81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SelectCourses_Edit), @"mvc.1.0.view", @"/Views/SelectCourses/Edit.cshtml")]
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
#line 1 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
using VideoShop.Services.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
using VideoShop.WebUI.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"478b3a6e9fc13beb87842dc04b6b6da50e88fd81", @"/Views/SelectCourses/Edit.cshtml")]
    public class Views_SelectCourses_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
    var item = new SelectCourseService().Get(ViewBag.Id);
    var CourseSelected = new CourseService().Get(item.CourseId);
    var AppUserSelected = new AppUserService().Get(item.AppUserId);
    var AppUsers = new AppUserService().GetAll();
    var Courses = new CourseService().GetAll();

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
            <form class=""col-12 align-middle form-group"" action=""/SelectCourses/EditOP"" method=""post"">
                <input");
            BeginWriteAttribute("value", " value=\"", 765, "\"", 781, 1);
#nullable restore
#line 22 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
WriteAttributeValue("", 773, item.Id, 773, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\" name=\"id\" />\r\n                <p>App User: </p>\r\n                <select class=\"form-control\" name=\"userId\">\r\n");
#nullable restore
#line 25 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                     foreach (var i in AppUsers)
                    {
                        if (i.Id == AppUserSelected.Id)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option selected");
            BeginWriteAttribute("value", " value=\"", 1108, "\"", 1121, 1);
#nullable restore
#line 29 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
WriteAttributeValue("", 1116, i.Id, 1116, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                                                      Write(i.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                                                                   Write(i.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 30 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1277, "\"", 1290, 1);
#nullable restore
#line 33 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
WriteAttributeValue("", 1285, i.Id, 1285, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                                             Write(i.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                                                          Write(i.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 34 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n                <p>Course: </p>\r\n                <select class=\"form-control\" name=\"courseId\">\r\n");
#nullable restore
#line 40 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                     foreach (var i in Courses)
                    {
                        if (i.Id == CourseSelected.Id)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option selected");
            BeginWriteAttribute("value", " value=\"", 1701, "\"", 1714, 1);
#nullable restore
#line 44 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
WriteAttributeValue("", 1709, i.Id, 1709, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                                                      Write(i.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 45 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1859, "\"", 1872, 1);
#nullable restore
#line 48 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
WriteAttributeValue("", 1867, i.Id, 1867, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                                             Write(i.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 49 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Edit.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n                <br />\r\n                <input class=\"btn btn-success\" value=\"Submit\" type=\"submit\" />\r\n            </form>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
