#pragma checksum "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c1a0c55ec6eeb1c0919ca8adf777a52b5d277cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1a0c55ec6eeb1c0919ca8adf777a52b5d277cc", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details Page";

#line default
#line hidden
            BeginContext(61, 55, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(117, 10, false);
#line 7 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\Home\Details.cshtml"
                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(127, 48, true);
            WriteLiteral("</h1>\r\n    <p>by</p>\r\n    <h3 class=\"display-5\">");
            EndContext();
            BeginContext(176, 10, false);
#line 9 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\Home\Details.cshtml"
                     Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(186, 14, true);
            WriteLiteral("</h3>\r\n    <p>");
            EndContext();
            BeginContext(201, 17, false);
#line 10 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\Home\Details.cshtml"
  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(218, 23, true);
            WriteLiteral("</p>\r\n    <p>Calories: ");
            EndContext();
            BeginContext(242, 14, false);
#line 11 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\Home\Details.cshtml"
            Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(256, 24, true);
            WriteLiteral("</p>\r\n    <p>Tastiness: ");
            EndContext();
            BeginContext(281, 15, false);
#line 12 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\Home\Details.cshtml"
             Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(296, 73, true);
            WriteLiteral("</p>\r\n    <div class=\"buttons d-flex justify-content-around\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 369, "\"", 396, 2);
            WriteAttributeValue("", 376, "delete/", 376, 7, true);
#line 14 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\Home\Details.cshtml"
WriteAttributeValue("", 383, Model.DishId, 383, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(397, 23, true);
            WriteLiteral(">Delete</a>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 420, "\"", 445, 2);
            WriteAttributeValue("", 427, "edit/", 427, 5, true);
#line 15 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\CRUDelicious\Views\Home\Details.cshtml"
WriteAttributeValue("", 432, Model.DishId, 432, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(446, 145, true);
            WriteLiteral(">Edit</a>\r\n    </div>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
