#pragma checksum "D:\CoreBlog\blog.webui\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9384a22bdd19659aed86297a7203c8c39f0850b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "D:\CoreBlog\blog.webui\Views\_ViewImports.cshtml"
using blog.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CoreBlog\blog.webui\Views\_ViewImports.cshtml"
using blog.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CoreBlog\blog.webui\Views\_ViewImports.cshtml"
using blog.entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9384a22bdd19659aed86297a7203c8c39f0850b8", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abc116ae17eebeba0af188895e26fbeb66f3ea8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\CoreBlog\blog.webui\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "../Shared/_BlogLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3 class=\"tittle\">Blog Posts</h3>\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 9 "D:\CoreBlog\blog.webui\Views\Blog\Index.cshtml"
     foreach (var blog in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4 card\">\r\n            <a href=\"single.html\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9384a22bdd19659aed86297a7203c8c39f0850b84471", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 303, "~/web/", 303, 6, true);
#nullable restore
#line 13 "D:\CoreBlog\blog.webui\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 309, blog.BlogImage, 309, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </a>\r\n            <div class=\"card-body\">\r\n                <ul class=\"blog-icons my-4\">\r\n                    <li>\r\n                        <a href=\"#\">\r\n                            <i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 19 "D:\CoreBlog\blog.webui\Views\Blog\Index.cshtml"
                                                           Write(blog.BlogCreateDate.ToString("yy-MMM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                    </li>
                    <li class=""mx-2"">
                        <a href=""#"">
                            <i class=""far fa-comment""></i> 21</a>
                    </li>
                    <li>
                        <a href=""#"">
                            <i class=""fas fa-eye""></i> ");
#nullable restore
#line 27 "D:\CoreBlog\blog.webui\Views\Blog\Index.cshtml"
                                                  Write(blog.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n\r\n                </ul>\r\n                <h5 class=\"card-title\">\r\n                    <a href=\"single.html\">");
#nullable restore
#line 32 "D:\CoreBlog\blog.webui\Views\Blog\Index.cshtml"
                                     Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </h5>\r\n                <p class=\"card-text mb-3\">");
#nullable restore
#line 34 "D:\CoreBlog\blog.webui\Views\Blog\Index.cshtml"
                                     Write(blog.BlogContent.Substring(0,blog.BlogContent.Substring(0,125).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ...</p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1344, "\"", 1380, 2);
            WriteAttributeValue("", 1351, "/Blog/BlogDetail/", 1351, 17, true);
#nullable restore
#line 36 "D:\CoreBlog\blog.webui\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1368, blog.BlogId, 1368, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "D:\CoreBlog\blog.webui\Views\Blog\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
