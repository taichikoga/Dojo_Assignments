#pragma checksum "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\Products_and_Categories\Views\Home\OneCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89f3defaee277047973e75b423f78029aad7ba4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneCategory), @"mvc.1.0.view", @"/Views/Home/OneCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OneCategory.cshtml", typeof(AspNetCore.Views_Home_OneCategory))]
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
#line 1 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\Products_and_Categories\Views\_ViewImports.cshtml"
using Products_and_Categories;

#line default
#line hidden
#line 2 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\Products_and_Categories\Views\_ViewImports.cshtml"
using Products_and_Categories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f3defaee277047973e75b423f78029aad7ba4f", @"/Views/Home/OneCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd6de6e6a9ac2d243eee5113369f84e5ce262d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AddCategoryToProductPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\Products_and_Categories\Views\Home\OneCategory.cshtml"
  
    ViewData["Title"] = "Category Page";
    Association newAssociation = new Association();

#line default
#line hidden
            BeginContext(119, 194, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <div class=\"header\">\r\n        <a href=\"/products\">Products</a> | \r\n        <a href=\"/categories\">Categories</a>\r\n    </div>\r\n    <div class=\"main\">\r\n        <h1>");
            EndContext();
            BeginContext(314, 10, false);
#line 13 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\Products_and_Categories\Views\Home\OneCategory.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(324, 52, true);
            WriteLiteral("</h1>\r\n        <div class=\"main-left\">\r\n            ");
            EndContext();
            BeginContext(376, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "89f3defaee277047973e75b423f78029aad7ba4f4476", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 15 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\Products_and_Categories\Views\Home\OneCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = newAssociation;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(453, 84, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"main-right\">\r\n            <h2>Products:</h2>\r\n");
            EndContext();
#line 19 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\Products_and_Categories\Views\Home\OneCategory.cshtml"
             foreach (var category in Model.ProductInCategory)
            {

#line default
#line hidden
            BeginContext(616, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(636, 21, false);
#line 21 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\Products_and_Categories\Views\Home\OneCategory.cshtml"
              Write(category.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(657, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 22 "C:\Users\Taichi\Desktop\Dojo_Assignments\C#\ORM\Products_and_Categories\Views\Home\OneCategory.cshtml"
            }

#line default
#line hidden
            BeginContext(678, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
