#pragma checksum "D:\CoreBlog\blog.webui\Views\Shared\Components\AuthorDashboardCategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b41e0b14ec825bfe9492ea742d5b350a50a1c67b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AuthorDashboardCategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AuthorDashboardCategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b41e0b14ec825bfe9492ea742d5b350a50a1c67b", @"/Views/Shared/Components/AuthorDashboardCategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abc116ae17eebeba0af188895e26fbeb66f3ea8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AuthorDashboardCategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-md-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Kategoriler <i class=""mdi mdi-format-list-bulleted""></i></h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th> # </th>
                            <th> Kategori Ad?? </th>
                            <th> Durum </th>
                            <th> ????lemler </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 18 "D:\CoreBlog\blog.webui\Views\Shared\Components\AuthorDashboardCategoryList\Default.cshtml"
                         foreach (var category in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td> ");
#nullable restore
#line 21 "D:\CoreBlog\blog.webui\Views\Shared\Components\AuthorDashboardCategoryList\Default.cshtml"
                                Write(category.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 22 "D:\CoreBlog\blog.webui\Views\Shared\Components\AuthorDashboardCategoryList\Default.cshtml"
                                Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 23 "D:\CoreBlog\blog.webui\Views\Shared\Components\AuthorDashboardCategoryList\Default.cshtml"
                                Write(category.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-gradient-success"" role=""progressbar"" style=""width: 25%""
                                        aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </td>
                            </tr>
");
#nullable restore
#line 31 "D:\CoreBlog\blog.webui\Views\Shared\Components\AuthorDashboardCategoryList\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
