#pragma checksum "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d92c14d71d4fd61c13cf05fdd7dc7fc4ab64b6bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\_ViewImports.cshtml"
using Gymany;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\_ViewImports.cshtml"
using Gymany.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92c14d71d4fd61c13cf05fdd7dc7fc4ab64b6bf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd2daf746351e1b25467b5be6f3116a2ee2c55df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.ListModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wrap-search-header flex-w p-l-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animsition"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d92c14d71d4fd61c13cf05fdd7dc7fc4ab64b6bf5985", async() => {
                WriteLiteral(@"
	<title>Home</title>
	<meta charset=""UTF-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
	<!--===============================================================================================-->
	<link rel=""icon"" type=""image/png"" href=""images/icons/favicon.png"" />
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/bootstrap/css/bootstrap.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""fonts/iconic/css/material-design-iconic-font.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesh");
                WriteLiteral(@"eet"" type=""text/css"" href=""fonts/linearicons-v1.0.0/icon-font.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/animate/animate.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/css-hamburgers/hamburgers.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/animsition/css/animsition.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/select2/select2.min.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/daterangepicker/daterangepicker.css"">");
                WriteLiteral(@"
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/slick/slick.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/MagnificPopup/magnific-popup.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""vendor/perfect-scrollbar/perfect-scrollbar.css"">
	<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""css/Product/util.css"">
	<link rel=""stylesheet"" type=""text/css"" href=""css/Product/main.css"">
	<!--===============================================================================================-->
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d92c14d71d4fd61c13cf05fdd7dc7fc4ab64b6bf10092", async() => {
                WriteLiteral(@"
	<!-- Modal Search -->
	<div class=""modal-search-header flex-c-m trans-04 js-hide-modal-search"">
		<div class=""container-search-header"">
			<button class=""flex-c-m btn-hide-modal-search trans-04 js-hide-modal-search"">
				<img src=""images/icons/icon-close2.png"" alt=""CLOSE"">
			</button>

			");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d92c14d71d4fd61c13cf05fdd7dc7fc4ab64b6bf10659", async() => {
                    WriteLiteral("\r\n\t\t\t\t<button class=\"flex-c-m trans-04\">\r\n\t\t\t\t\t<i class=\"zmdi zmdi-search\"></i>\r\n\t\t\t\t</button>\r\n\t\t\t\t<input class=\"plh3\" type=\"text\" name=\"search\" placeholder=\"Search...\">\r\n\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
		</div>
	</div>

	<!-- Slider -->
	<section class=""section-slide"">
		<div class=""wrap-slick1"">
			<div class=""slick1"">
				<div class=""item-slick1"" style=""background-image: url(images/Product/banner1.jpg);"">
					<div class=""container h-full"">
						<div class=""flex-col-l-m h-full p-t-100 p-b-30 respon5"">
							<div class=""layer-slick1 animated visible-false"" data-appear=""fadeInDown"" data-delay=""0"">
								<span class=""ltext-101 cl2 respon2 text-light"">
									""Changes your life style with us""
								</span>
							</div>

							<div class=""layer-slick1 animated visible-false"" data-appear=""fadeInUp"" data-delay=""800"">
								<h2 class=""ltext-201 cl2 p-t-19 p-b-43 respon1"">
									GYMANY
								</h2>
							</div>

							<div class=""layer-slick1 animated visible-false"" data-appear=""zoomIn"" data-delay=""1600"">
								<a href=""product.html""
									class=""flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04"">
									Shop Now
								</a>
							</div>
			");
                WriteLiteral(@"			</div>
					</div>
				</div>

				<div class=""item-slick1"" style=""background-image: url(images/Product/banner2.jpg);"">
					<div class=""container h-full"">
						<div class=""flex-col-l-m h-full p-t-100 p-b-30 respon5"">
							<div class=""layer-slick1 animated visible-false"" data-appear=""rollIn"" data-delay=""0"">
								<span class=""ltext-101 cl2 respon2 text-light"">
									IMPROVE HEALTHY CARE
								</span>
							</div>

							<div class=""layer-slick1 animated visible-false"" data-appear=""lightSpeedIn""
								data-delay=""800"">
								<h2 class=""ltext-201 cl2 p-t-19 p-b-43 respon1"">
									GOOD BODY
								</h2>
							</div>

							<div class=""layer-slick1 animated visible-false"" data-appear=""slideInUp"" data-delay=""1600"">
								<a href=""product.html""
									class=""flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04"">
									Shop Now
								</a>
							</div>
						</div>
					</div>
				</div>

				<div class=""item-slick1"" style=""background-imag");
                WriteLiteral(@"e: url(images/Product/banner3.jpg);"">
					<div class=""container h-full"">
						<div class=""flex-col-l-m h-full p-t-100 p-b-30 respon5"">
							<div class=""layer-slick1 animated visible-false"" data-appear=""rotateInDownLeft""
								data-delay=""0"">
								<span class=""ltext-101 cl2 respon2 text-light"">
									""BE THE BEST VERSION OF YOURSELF""
								</span>
							</div>

							<div class=""layer-slick1 animated visible-false"" data-appear=""rotateInUpRight""
								data-delay=""800"">
								<h2 class=""ltext-201 cl2 p-t-19 p-b-43 respon1"">
									SUCCESSFULL
								</h2>
							</div>

							<div class=""layer-slick1 animated visible-false"" data-appear=""rotateIn"" data-delay=""1600"">
								<a href=""product.html""
									class=""flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04"">
									Shop Now
								</a>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>


	<!-- Banner -->
	<div class=""container rsec-banner bg0 p-t-80 p-b-");
                WriteLiteral(@"50"">
		<div>
			<div class=""row"">
				<div class=""col-md-6 col-xl-4 p-b-30 m-lr-auto"">
					<!-- Block1 -->
					<div class=""block1 wrap-pic-w"">
						<img src=""images/Product/whey1.jpg"" alt=""IMG-BANNER"">

						<a href=""product.html""
							class=""block1-txt ab-t-l s-full flex-col-l-sb p-lr-38 p-tb-34 trans-03 respon3"">
							<div class=""block1-txt-child1 flex-col-l"">
								<span class=""block1-name ltext-102 trans-04 p-b-8"">
									Whey Protein
								</span>

								<span class=""block1-info stext-102 trans-04"">
									All Product
								</span>
							</div>

							<div class=""block1-txt-child2 p-b-4 trans-05"">
								<div class=""block1-link stext-101 cl0 trans-09"">
									Shop Now
								</div>
							</div>
						</a>
					</div>
				</div>

				<div class=""col-md-6 col-xl-4 p-b-30 m-lr-auto"">
					<!-- Block1 -->
					<div class=""block1 wrap-pic-w"">
						<img src=""images/Product/mass1.jpg"" alt=""IMG-BANNER"">

						<a href=""product.html""
							class=""blo");
                WriteLiteral(@"ck1-txt ab-t-l s-full flex-col-l-sb p-lr-38 p-tb-34 trans-03 respon3"">
							<div class=""block1-txt-child1 flex-col-l"">
								<span class=""block1-name ltext-102 trans-04 p-b-8"">
									Mass
								</span>

								<span class=""block1-info stext-102 trans-04"">
									All Product
								</span>
							</div>

							<div class=""block1-txt-child2 p-b-4 trans-05"">
								<div class=""block1-link stext-101 cl0 trans-09"">
									Shop Now
								</div>
							</div>
						</a>
					</div>
				</div>

				<div class=""col-md-6 col-xl-4 p-b-30 m-lr-auto"">
					<!-- Block1 -->
					<div class=""block1 wrap-pic-w"">
						<img src=""images/Product/acc1.jpg"" alt=""IMG-BANNER"">

						<a href=""product.html""
							class=""block1-txt ab-t-l s-full flex-col-l-sb p-lr-38 p-tb-34 trans-03 respon3"">
							<div class=""block1-txt-child1 flex-col-l"">
								<span class=""block1-name ltext-102 trans-04 p-b-8"">
									Accessories
								</span>

								<span class=""block1-info stext-102 tr");
                WriteLiteral(@"ans-04"">
									All Product
								</span>
							</div>

							<div class=""block1-txt-child2 p-b-4 trans-05"">
								<div class=""block1-link stext-101 cl0 trans-09"">
									Shop Now
								</div>
							</div>
						</a>
					</div>
				</div>
			</div>
		</div>
	</div>


	<!-- Product -->
	<section class=""container bg0 p-t-23 p-b-140"">
		<div>
			<div class=""p-b-10"">
				<h3 class=""ltext-103 cl5"">
					Product Overview
				</h3>
			</div>

			<div class=""flex-w flex-sb-m p-b-52"">
				<div class=""flex-w flex-l-m filter-tope-group m-tb-10"">
					<button class=""stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5 how-active1"" data-filter=""*"">
						All Products
					</button>
");
#nullable restore
#line 251 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
                     foreach (var item in Model.Categories)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t<button class=\"stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5\" data-filter=\".");
#nullable restore
#line 253 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
                                                                                                Write(item.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 254 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
                       Write(item.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</button>\r\n");
#nullable restore
#line 256 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"				</div>

				<div class=""flex-w flex-c-m m-tb-10"">
					<div
						class=""flex-c-m stext-106 cl6 size-104 bor4 pointer hov-btn3 trans-04 m-r-8 m-tb-4 js-show-filter"">
						<i class=""icon-filter cl2 m-r-6 fs-15 trans-04 zmdi zmdi-filter-list""></i>
						<i class=""icon-close-filter cl2 m-r-6 fs-15 trans-04 zmdi zmdi-close dis-none""></i>
						Filter
					</div>

					<div class=""flex-c-m stext-106 cl6 size-105 bor4 pointer hov-btn3 trans-04 m-tb-4 js-show-search"">
						<i class=""icon-search cl2 m-r-6 fs-15 trans-04 zmdi zmdi-search""></i>
						<i class=""icon-close-search cl2 m-r-6 fs-15 trans-04 zmdi zmdi-close dis-none""></i>
						Search
					</div>
				</div>

				<!-- Search product -->
				<div class=""dis-none panel-search w-full p-t-10 p-b-15"">
					<div class=""bor8 dis-flex p-l-15"">
						<button class=""size-113 flex-c-m fs-16 cl2 hov-cl1 trans-04"">
							<i class=""zmdi zmdi-search""></i>
						</button>

						<input class=""mtext-107 cl2 size-114 plh2 p-r-15"" type=""text"" name");
                WriteLiteral("=\"search-product\"\r\n\t\t\t\t\t\t\tplaceholder=\"Search\">\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"row isotope-grid\">\r\n");
#nullable restore
#line 288 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
                 foreach (var item in Model.ListProducts)
				{
					string CateType = "";
					foreach (var category in Model.Categories)
					{
						if (item.CategoryID == category.CategoryID)
						{
							CateType = category.Type;
						}
					}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<div");
                BeginWriteAttribute("class", " class=\"", 11147, "\"", 11211, 6);
                WriteAttributeValue("", 11155, "col-sm-6", 11155, 8, true);
                WriteAttributeValue(" ", 11163, "col-md-4", 11164, 9, true);
                WriteAttributeValue(" ", 11172, "col-lg-3", 11173, 9, true);
                WriteAttributeValue(" ", 11181, "p-b-35", 11182, 7, true);
                WriteAttributeValue(" ", 11188, "isotope-item", 11189, 13, true);
#nullable restore
#line 298 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 11201, CateType, 11202, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t<!-- Block2 -->\r\n\t\t\t\t\t\t<div class=\"block2\">\r\n\t\t\t\t\t\t\t<div class=\"block2-pic hov-img0\">\r\n\t\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 11320, "\"", 11337, 1);
#nullable restore
#line 302 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
WriteAttributeValue("", 11326, item.Image, 11326, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""IMG-PRODUCT"">

								<a href=""#""
									class=""block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1"">
									Quick View
								</a>
							</div>

							<div class=""block2-txt flex-w flex-t p-t-14"">
								<div class=""block2-txt-child1 flex-col-l "">
									");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d92c14d71d4fd61c13cf05fdd7dc7fc4ab64b6bf22962", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 314 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 312 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
                                                                                       WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t\t\t<span class=\"stext-105 cl3\">\r\n\t\t\t\t\t\t\t\t\t\t$");
#nullable restore
#line 318 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
									</span>
								</div>
								<div class=""block2-txt-child2 flex-r p-t-3"">
									<a href=""#"" class=""btn-addwish-b2 dis-block pos-relative js-addwish-b2"">
										<img class=""icon-heart1 dis-block trans-04"" src=""images/icons/icon-heart-01.png""
											alt=""ICON"">
										<img class=""icon-heart2 dis-block trans-04 ab-t-l""
											src=""images/icons/icon-heart-02.png"" alt=""ICON"">
									</a>
								</div>
							</div>
						</div>
					</div>
");
#nullable restore
#line 332 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t</div>\r\n\r\n\t\t\t<!-- Load more -->\r\n\t\t\t<div class=\"flex-c-m flex-w w-full p-t-45\">\r\n\t\t\t\t");
#nullable restore
#line 337 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Views\Home\Index.cshtml"
           Write(Html.PagedListPager((IPagedList)Model.ListProducts, page => Url.Action("Index", new { page = page }),
					new X.PagedList.Web.Common.PagedListRenderOptionsBase
				{
					LiElementClasses = new string[] { "page-item" },
					PageClasses = new string[] { "page-link" }
				}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\r\n\r\n\t<!-- Modal1 -->\r\n");
                WriteLiteral(@"
	<!--===============================================================================================-->
	<script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/animsition/js/animsition.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/bootstrap/js/popper.js""></script>
	<script src=""vendor/bootstrap/js/bootstrap.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/select2/select2.min.js""></script>
	<script>
		$("".js-select2"").each(function () {
			$(this).select2({
				minimumResultsForSearch: 20,
				dropdownParent: $(this).next('.dropDownSelect2')
			});
		})
	</script>
	<!--===============================================================================================-->
	<script sr");
                WriteLiteral(@"c=""vendor/daterangepicker/moment.min.js""></script>
	<script src=""vendor/daterangepicker/daterangepicker.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/slick/slick.min.js""></script>
	<script src=""js/Product/slick-custom.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/parallax100/parallax100.js""></script>
	<script>
		$('.parallax100').parallax100();
	</script>
	<!--===============================================================================================-->
	<script src=""vendor/MagnificPopup/jquery.magnific-popup.min.js""></script>
	<script>
		$('.gallery-lb').each(function () { // the containers for all your galleries
			$(this).magnificPopup({
				delegate: 'a', // the selector for gallery item
				type: 'image',
				gallery: {
					enabled: true
				},
				mainClass: 'mfp-fade'
			});
		});
	</script>");
                WriteLiteral(@"
	<!--===============================================================================================-->
	<script src=""vendor/isotope/isotope.pkgd.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/sweetalert/sweetalert.min.js""></script>
	<script>
		$('.js-addwish-b2').on('click', function (e) {
			e.preventDefault();
		});

		$('.js-addwish-b2').each(function () {
			var nameProduct = $(this).parent().parent().find('.js-name-b2').html();
			$(this).on('click', function () {
				swal(nameProduct, ""is added to wishlist !"", ""success"");

				$(this).addClass('js-addedwish-b2');
				$(this).off('click');
			});
		});

		$('.js-addwish-detail').each(function () {
			var nameProduct = $(this).parent().parent().parent().find('.js-name-detail').html();

			$(this).on('click', function () {
				swal(nameProduct, ""is added to wishlist !"", ""success"");

				$(this).addClass('js-addedwish-detail');
				$(t");
                WriteLiteral(@"his).off('click');
			});
		});

		/*---------------------------------------------*/

		$('.js-addcart-detail').each(function () {
			var nameProduct = $(this).parent().parent().parent().parent().find('.js-name-detail').html();
			$(this).on('click', function () {
				swal(nameProduct, ""is added to cart !"", ""success"");
			});
		});

	</script>
	<!--===============================================================================================-->
	<script src=""vendor/perfect-scrollbar/perfect-scrollbar.min.js""></script>
	<script>
		$('.js-pscroll').each(function () {
			$(this).css('position', 'relative');
			$(this).css('overflow', 'hidden');
			var ps = new PerfectScrollbar(this, {
				wheelSpeed: 1,
				scrollingThreshold: 1000,
				wheelPropagation: false,
			});

			$(window).on('resize', function () {
				ps.update();
			})
		});
	</script>
	<!--===============================================================================================-->
	<script src=""js/Product/main.");
                WriteLiteral("js\"></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gymany.Models.ListModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
