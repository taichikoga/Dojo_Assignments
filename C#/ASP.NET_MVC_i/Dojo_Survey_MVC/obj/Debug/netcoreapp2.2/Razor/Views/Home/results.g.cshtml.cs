#pragma checksum "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_i\Dojo_Survey_MVC\Views\Home\results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "778face3de7af17e1b861ef76ca173eb31c7822e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_results), @"mvc.1.0.view", @"/Views/Home/results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/results.cshtml", typeof(AspNetCore.Views_Home_results))]
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
#line 1 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_i\Dojo_Survey_MVC\Views\_ViewImports.cshtml"
using Dojo_Survey_MVC;

#line default
#line hidden
#line 4 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_i\Dojo_Survey_MVC\Views\_ViewImports.cshtml"
using Dojo_Survey_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778face3de7af17e1b861ef76ca173eb31c7822e", @"/Views/Home/results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88f3bbe865cfb4d9a971f14536190a1d365bdd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(52, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "778face3de7af17e1b861ef76ca173eb31c7822e3440", async() => {
                BeginContext(58, 141, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Submitted Info</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(206, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(208, 261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "778face3de7af17e1b861ef76ca173eb31c7822e4773", async() => {
                BeginContext(214, 81, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <h3>Submitted Info</h3>\r\n        <p>Name: ");
                EndContext();
                BeginContext(296, 10, false);
#line 13 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_i\Dojo_Survey_MVC\Views\Home\results.cshtml"
            Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(306, 32, true);
                WriteLiteral("</p>\r\n        <p>Dojo Location: ");
                EndContext();
                BeginContext(339, 14, false);
#line 14 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_i\Dojo_Survey_MVC\Views\Home\results.cshtml"
                     Write(Model.Location);

#line default
#line hidden
                EndContext();
                BeginContext(353, 36, true);
                WriteLiteral("</p>\r\n        <p>Favorite Language: ");
                EndContext();
                BeginContext(390, 14, false);
#line 15 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_i\Dojo_Survey_MVC\Views\Home\results.cshtml"
                         Write(Model.Language);

#line default
#line hidden
                EndContext();
                BeginContext(404, 26, true);
                WriteLiteral("</p>\r\n        <p>Comment: ");
                EndContext();
                BeginContext(431, 13, false);
#line 16 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ASP.NET_MVC_i\Dojo_Survey_MVC\Views\Home\results.cshtml"
               Write(Model.Comment);

#line default
#line hidden
                EndContext();
                BeginContext(444, 18, true);
                WriteLiteral("</p>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(469, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
