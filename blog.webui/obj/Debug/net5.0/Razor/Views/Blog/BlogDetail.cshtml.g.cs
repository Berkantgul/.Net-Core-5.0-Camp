#pragma checksum "D:\CoreBlog\blog.webui\Views\Blog\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d7ec298d54d8cfa330c190c43153d875c4d8542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetail), @"mvc.1.0.view", @"/Views/Blog/BlogDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7ec298d54d8cfa330c190c43153d875c4d8542", @"/Views/Blog/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abc116ae17eebeba0af188895e26fbeb66f3ea8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\CoreBlog\blog.webui\Views\Blog\BlogDetail.cshtml"
  
    Layout= "../Shared/_BlogLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d7ec298d54d8cfa330c190c43153d875c4d85424503", async() => {
                WriteLiteral(@"
	<title>Weblog a Blogging Category Bootstrap responsive WebTemplate | Single :: w3layouts</title>
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
	<meta charset=""utf-8"">
	<meta name=""keywords"" content=""Weblog a Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design"" />

	<script>
		addEventListener(""load"", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
	</script>
	<link href=""css/bootstrap.css"" rel='stylesheet' type='text/css' />
	<link rel=""stylesheet"" href=""css/single.css"">
	<link href=""css/style.css"" rel='stylesheet' type='text/css' />
	<link href=""css/fontawesome-all.css"" rel=""stylesheet"">
	<link href=""//fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800""
	    rel=""stylesheet"">
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d7ec298d54d8cfa330c190c43153d875c4d85426516", async() => {
                WriteLiteral("\r\n\t\r\n\t\r\n\t\r\n   \r\n\t<!--//banner-->\r\n\t<section class=\"banner-bottom\">\r\n\t\t<!--/blog-->\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 44 "D:\CoreBlog\blog.webui\Views\Blog\BlogDetail.cshtml"
                 foreach (var blogitem in Model)
                {
                     

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <!--left-->
				<div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
					<div class=""blog-grid-top"">
						<div class=""b-grid-top"">
							<div class=""blog_info_left_grid"">
								<a href=""single.html"">
									<img src=""images/b1.jpg"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 1682, "\"", 1688, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"blog-info-middle\">\r\n\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 60 "D:\CoreBlog\blog.webui\Views\Blog\BlogDetail.cshtml"
                                                                           Write(blogitem.BlogCreateDate.ToString("dd-MMM-yy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
									</li>
									<li class=""mx-2"">
										<a href=""#"">
											<i class=""far fa-thumbs-up""></i> 201 Likes</a>
									</li>
									<li>
										<a href=""#"">
											<i class=""far fa-comment""></i> 15 Comments</a>
									</li>
									
								</ul>
							</div>
						</div>

						<h3>
							<a href=""single.html"">");
#nullable restore
#line 76 "D:\CoreBlog\blog.webui\Views\Blog\BlogDetail.cshtml"
                                             Write(blogitem.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a>\r\n\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t<p>");
#nullable restore
#line 78 "D:\CoreBlog\blog.webui\Views\Blog\BlogDetail.cshtml"
                      Write(blogitem.BlogContent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\t\t\t\t\t\t<a href=\"single.html\" class=\"btn btn-primary read-m\">Read More</a>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 82 "D:\CoreBlog\blog.webui\Views\Blog\BlogDetail.cshtml"
               Write(await Component.InvokeAsync("GetCommentByBlog", new {id = ViewBag.id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t<div class=\"comment-top\">\r\n\t\t\t\t\t\t<h4>Leave a Comment</h4>\r\n\t\t\t\t\t\t<div class=\"comment-bottom\">\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d7ec298d54d8cfa330c190c43153d875c4d85429627", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"Name\" placeholder=\"Name\"");
                    BeginWriteAttribute("required", " required=\"", 2727, "\"", 2738, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"email\" name=\"Email\" placeholder=\"Email\"");
                    BeginWriteAttribute("required", " required=\"", 2823, "\"", 2834, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\r\n\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"Subject\" placeholder=\"Subject\"");
                    BeginWriteAttribute("required", " required=\"", 2924, "\"", 2935, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\r\n\t\t\t\t\t\t\t\t<textarea class=\"form-control\" name=\"Message\" placeholder=\"Message...\"");
                    BeginWriteAttribute("required", " required=\"", 3019, "\"", 3030, 0);
                    EndWriteAttribute();
                    WriteLiteral("></textarea>\r\n\t\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary submit\">Submit</button>\r\n\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 98 "D:\CoreBlog\blog.webui\Views\Blog\BlogDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\r\n\r\n\t\t\t\t<!--//left-->\r\n\t\t\t\t<!--right-->\r\n\t\t\t\t<aside class=\"col-lg-4 agileits-w3ls-right-blog-con text-right\">\r\n\t\t\t\t\t<div class=\"right-blog-info text-left\">\r\n\t\t\t\t\t\t<div class=\"tech-btm\">\r\n\t\t\t\t\t\t\t<img src=\"images/banner1.jpg\" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 3442, "\"", 3448, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"tech-btm\">\r\n\t\t\t\t\t\t\t<h4>Sign up to our newsletter</h4>\r\n\t\t\t\t\t\t\t<p>Pellentesque dui, non felis. Maecenas male </p>\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d7ec298d54d8cfa330c190c43153d875c4d854213334", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t<input type=\"email\" placeholder=\"Email\"");
                    BeginWriteAttribute("required", " required=\"", 3685, "\"", 3696, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<input type=\"submit\" value=\"Subscribe\">\r\n\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

						</div>
						<div class=""tech-btm"">
							<h4>Categories</h4>
							<ul class=""list-group single"">
									<li class=""list-group-item d-flex justify-content-between align-items-center"">
									  Cras justo odio
									  <span class=""badge badge-primary badge-pill"">14</span>
									</li>
									<li class=""list-group-item d-flex justify-content-between align-items-center"">
									  Dapibus ac facilisis in
									  <span class=""badge badge-primary badge-pill"">2</span>
									</li>
									<li class=""list-group-item d-flex justify-content-between align-items-center"">
									  Morbi leo risus
									  <span class=""badge badge-primary badge-pill"">1</span>
									</li>
								  </ul>
						</div>
						<div class=""tech-btm"">
							<h4>Top stories of the week</h4>

							<div class=""blog-grids row mb-3"">
								<div class=""col-md-5 blog-grid-left"">
									<a href=""single.html"">
										<img src=""images/1.jpg"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 4761, "\"", 4767, 0);
                EndWriteAttribute();
                WriteLiteral(@">
									</a>
								</div>
								<div class=""col-md-7 blog-grid-right"">

									<h5>
										<a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
									</h5>
									<div class=""sub-meta"">
										<span>
											<i class=""far fa-clock""></i> 20 Jan, 2018</span>
									</div>
								</div>

							</div>
							<div class=""blog-grids row mb-3"">
								<div class=""col-md-5 blog-grid-left"">
									<a href=""single.html"">
										<img src=""images/6.jpg"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 5309, "\"", 5315, 0);
                EndWriteAttribute();
                WriteLiteral(@">
									</a>
								</div>
								<div class=""col-md-7 blog-grid-right"">
									<h5>
										<a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
									</h5>
									<div class=""sub-meta"">
										<span>
											<i class=""far fa-clock""></i> 20 Feb, 2018</span>
									</div>
								</div>

							</div>
						</div>
						<div class=""single-gd my-5 tech-btm"">
							<h4>Our Progress</h4>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
								    aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
								    aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""widt");
                WriteLiteral(@"h: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
								    aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
								    aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
								    aria-valuemax=""100""></div>
							</div>
						</div>
						<div class=""single-gd tech-btm"">
							<h4>Recent Post</h4>
							<div class=""blog-grids"">
								<div class=""blog-grid-left"">
									<a href=""single.html"">
										<img src=""images/b1.jpg"" class=""img-fluid""");
                BeginWriteAttribute("alt", " alt=\"", 7137, "\"", 7143, 0);
                EndWriteAttribute();
                WriteLiteral(@">
									</a>
								</div>
								<div class=""blog-grid-right"">

									<h5>
										<a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
									</h5>
								</div>
								<div class=""clearfix""> </div>
							</div>
						</div>
					</div>

				</aside>
				<!--//right-->
			</div>
		</div>
	</section>
	<!--//main-->

	
	<!-- js -->
	<script src=""js/jquery-2.2.3.min.js""></script>
	<!-- //js -->
	<!--/ start-smoth-scrolling -->
	<script src=""js/move-top.js""></script>
	<script src=""js/easing.js""></script>
	<script>
		jQuery(document).ready(function ($) {
			$("".scroll"").click(function (event) {
				event.preventDefault();
				$('html,body').animate({
					scrollTop: $(this.hash).offset().top
				}, 900);
			});
		});
	</script>
	<!--// end-smoth-scrolling -->

	<script>
		$(document).ready(function () {
			/*
									var defaults = {
							  			containerID: 'toTop', // fading element id
										containerHoverID: 'toTopHover', // fadi");
                WriteLiteral(@"ng element hover id
										scrollSpeed: 1200,
										easingType: 'linear' 
							 		};
									*/

			$().UItoTop({
				easingType: 'easeOutQuart'
			});

		});
	</script>
	<a href=""#home"" class=""scroll"" id=""toTop"" style=""display: block;"">
		<span id=""toTopHover"" style=""opacity: 1;""> </span>
	</a>

	<!-- //Custom-JavaScript-File-Links -->
	<script src=""js/bootstrap.js""></script>


");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591