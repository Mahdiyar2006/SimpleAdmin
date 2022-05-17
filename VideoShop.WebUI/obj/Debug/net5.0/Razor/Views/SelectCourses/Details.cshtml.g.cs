#pragma checksum "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb6eed0e346105a1e49d26b261b1c9c793edaeb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SelectCourses_Details), @"mvc.1.0.view", @"/Views/SelectCourses/Details.cshtml")]
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
#line 1 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Details.cshtml"
using VideoShop.Services.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6eed0e346105a1e49d26b261b1c9c793edaeb5", @"/Views/SelectCourses/Details.cshtml")]
    public class Views_SelectCourses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_MainLayout.cshtml";
    var item = new SelectCourseService().Get(ViewBag.Id);
    var Course = new CourseService().Get(item.CourseId);
    var AppUser = new AppUserService().Get(item.AppUserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"margin-top:10px\" class=\"container\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            Details\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p style=\"font-weight: bold\">Course Name: </p>\r\n            <p>");
#nullable restore
#line 18 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Details.cshtml"
          Write(Course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p style=\"font-weight: bold\">Course Subject: </p>\r\n            <p>");
#nullable restore
#line 20 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Details.cshtml"
          Write(Course.CourseSubject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p style=\"font-weight: bold\">Content: </p>\r\n            <p>");
#nullable restore
#line 22 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Details.cshtml"
          Write(Course.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p style=\"font-weight: bold\">Category Course: </p>\r\n            <p>");
#nullable restore
#line 24 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Details.cshtml"
           Write(new CategoryCourseService().Get(Course.CategoryCourseId).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p style=\"font-weight: bold\">Teacher Name: </p>\r\n            <p>");
#nullable restore
#line 26 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Details.cshtml"
           Write(new TeacherService().GetAll().Where(p => p.Id == Course.TeacherId).First().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p style=\"font-weight: bold\">First Name: </p>\r\n            <p>");
#nullable restore
#line 28 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Details.cshtml"
          Write(AppUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p style=\"font-weight: bold\">Last Name: </p>\r\n            <p>");
#nullable restore
#line 30 "C:\Users\mahdi\Desktop\Project\VideoShop\VideoShop\VideoShop.WebUI\Views\SelectCourses\Details.cshtml"
          Write(AppUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <br />\r\n            <a href=\"/SelectCourses/Index\" class=\"btn btn-primary\">Back</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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