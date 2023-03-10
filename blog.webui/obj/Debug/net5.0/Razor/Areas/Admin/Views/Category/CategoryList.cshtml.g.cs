#pragma checksum "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b7c2414e8742c87b38cddd2983b499e86fdbe0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_CategoryList), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/CategoryList.cshtml")]
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
#line 1 "D:\CoreBlog\blog.webui\Areas\Admin\Views\_ViewImports.cshtml"
using blog.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CoreBlog\blog.webui\Areas\Admin\Views\_ViewImports.cshtml"
using blog.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CoreBlog\blog.webui\Areas\Admin\Views\_ViewImports.cshtml"
using blog.entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b7c2414e8742c87b38cddd2983b499e86fdbe0f", @"/Areas/Admin/Views/Category/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5c743236b781b1ec6613cd973b44bd197083d4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
  
    ViewData["Title"] = "CategoryList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""col-lg-12"">
            
    <div class=""ibox "">
        <a href=""/Admin/Category/AddCategory/"" class=""btn btn-info"">Yeni Kategori</a>
    <br>
        <div class=""ibox-title"">
            <h5>Kategoriler</h5>
            <div class=""ibox-tools"">
                <a class=""collapse-link"">
                    <i class=""fa fa-chevron-up""></i>
                </a>
                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                    <i class=""fa fa-wrench""></i>
                </a>
                <a class=""close-link"">
                    <i class=""fa fa-times""></i>
                </a>
            </div>
        </div>
        <div class=""ibox-content"">

            <table class=""table"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Kategori</th>
                        <th>Aktif</th>
                        <th>Pasif</th>
                        <th>????lemler</th>
        ");
            WriteLiteral("            </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 44 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 47 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
                           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td><a href=""#"" class=""btn btn-success"">Aktif Yap</a></td>
                            <td><a href=""#"" class=""btn btn-warning"">Pasif Yap</a></td>
                            <td>

                                <button type=""button"" class=""btn btn-danger btn-sm"" data-toggle=""modal""
                                data-target=""#Sil_");
#nullable restore
#line 54 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
                                             Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fa fa-trash-o\"></i>\r\n                                    \r\n                                </button>\r\n\r\n                                <!--Modal-->\r\n                            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2083, "\"", 2108, 2);
            WriteAttributeValue("", 2088, "Sil_", 2088, 4, true);
#nullable restore
#line 59 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
WriteAttributeValue("", 2092, item.CategoryId, 2092, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog""
                                aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                                    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Kategori Sil</h5>
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">&times;</span>
                                                </button>
                                            </div>
                                            <div class=""modal-body"">
                                                <h4>Kategoriyi silmek istiyor musunuz?</h4>
                                            <");
            WriteLiteral(@"/div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-info mx-4""
                                                data-dismiss=""modal"">Vazge??</button>
                                                ");
#nullable restore
#line 75 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
                                           Write(Html.ActionLink("Sil", "DeleteCategory","Category", new { area="Admin",id = @item.CategoryId }, new {
                                            @class = "btn btn-danger mx-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 83 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n        <br>\r\n        ");
#nullable restore
#line 89 "D:\CoreBlog\blog.webui\Areas\Admin\Views\Category\CategoryList.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("CategoryList", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
