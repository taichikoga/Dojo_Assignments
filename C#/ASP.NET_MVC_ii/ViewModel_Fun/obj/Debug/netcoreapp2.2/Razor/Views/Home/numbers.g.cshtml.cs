#pragma checksum "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_ii\ViewModel_Fun\Views\Home\numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "398e3861c447a3b4344aec3d11eb095f7dfcf9a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_numbers), @"mvc.1.0.view", @"/Views/Home/numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/numbers.cshtml", typeof(AspNetCore.Views_Home_numbers))]
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
#line 1 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_ii\ViewModel_Fun\Views\_ViewImports.cshtml"
using ViewModel_Fun;

#line default
#line hidden
#line 1 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_ii\ViewModel_Fun\Views\Home\numbers.cshtml"
using ViewModel_Fun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"398e3861c447a3b4344aec3d11eb095f7dfcf9a0", @"/Views/Home/numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d67dacb5d440fdfd5c9974c666c8e8de3a51591", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Numbers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_ii\ViewModel_Fun\Views\Home\numbers.cshtml"
  
    ViewData["Title"] = "Numbers List Page";

#line default
#line hidden
            BeginContext(106, 84, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Here are some Numbers!</h1>\r\n");
            EndContext();
#line 10 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_ii\ViewModel_Fun\Views\Home\numbers.cshtml"
     foreach (var number in Model)
    {

#line default
#line hidden
            BeginContext(233, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(245, 10, false);
#line 12 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_ii\ViewModel_Fun\Views\Home\numbers.cshtml"
      Write(number.Num);

#line default
#line hidden
            EndContext();
            BeginContext(255, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_ii\ViewModel_Fun\Views\Home\numbers.cshtml"
    }

#line default
#line hidden
            BeginContext(268, 122, true);
            WriteLiteral("    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Numbers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
