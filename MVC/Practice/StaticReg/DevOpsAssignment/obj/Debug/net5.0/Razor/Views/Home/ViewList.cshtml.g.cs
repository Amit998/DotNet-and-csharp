#pragma checksum "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f452f6c732ba59f92255530fd24a661e6ef56c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewList), @"mvc.1.0.view", @"/Views/Home/ViewList.cshtml")]
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
#line 1 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\_ViewImports.cshtml"
using DevOpsAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\_ViewImports.cshtml"
using DevOpsAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f452f6c732ba59f92255530fd24a661e6ef56c0", @"/Views/Home/ViewList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2adbbf86b8d2041ab65b6ed5b8c405e975647c14", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevOpsAssignment.Models.StudentModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
  
    ViewData["Title"] = "ViewList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewList</h1>\r\n\r\n\r\n<div class=\"table-responsive\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentBatch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.DisplayFor(modelItem => item.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.DisplayFor(modelItem => item.StudentEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.DisplayFor(modelItem => item.StudentCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.DisplayFor(modelItem => item.StudentBatch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.StudnetId }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 51 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.StudnetId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 53 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.StudnetId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "D:\nagarro\MVC\assignment\DevOpsAssignment\DevOpsAssignment\Views\Home\ViewList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevOpsAssignment.Models.StudentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
