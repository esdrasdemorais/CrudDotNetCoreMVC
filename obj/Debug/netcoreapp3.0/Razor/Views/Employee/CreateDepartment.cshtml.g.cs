#pragma checksum "/home/esdras/Desktop/CrudDotNetCore/Views/Employee/CreateDepartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3b239f580c33a379491acfc3a3e08b04612a16c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_CreateDepartment), @"mvc.1.0.view", @"/Views/Employee/CreateDepartment.cshtml")]
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
#line 1 "/home/esdras/Desktop/CrudDotNetCore/Views/_ViewImports.cshtml"
using CrudDotNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/esdras/Desktop/CrudDotNetCore/Views/_ViewImports.cshtml"
using CrudDotNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/esdras/Desktop/CrudDotNetCore/Views/_ViewImports.cshtml"
using HtmlHelpers.BeginCollectionItemCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b239f580c33a379491acfc3a3e08b04612a16c", @"/Views/Employee/CreateDepartment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c98a1750974d2a3a7aa7cd4575525af12f8d6acd", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_CreateDepartment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrudDotNetCore.Models.Department>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<li style=\"padding-bottom:7px\">\n");
#nullable restore
#line 4 "/home/esdras/Desktop/CrudDotNetCore/Views/Employee/CreateDepartment.cshtml"
     using (Html.BeginCollectionItem("Departments")) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/esdras/Desktop/CrudDotNetCore/Views/Employee/CreateDepartment.cshtml"
   Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/esdras/Desktop/CrudDotNetCore/Views/Employee/CreateDepartment.cshtml"
   Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/esdras/Desktop/CrudDotNetCore/Views/Employee/CreateDepartment.cshtml"
   Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/esdras/Desktop/CrudDotNetCore/Views/Employee/CreateDepartment.cshtml"
                                                       
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" onclick=\"$(this).parent().remove();\">Delete</a>\n</li>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrudDotNetCore.Models.Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
