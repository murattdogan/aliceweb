#pragma checksum "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3edae419379d3f2b8b5b734add3116bf7d58d109"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Detail), @"mvc.1.0.view", @"/Views/Category/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Detail.cshtml", typeof(AspNetCore.Views_Category_Detail))]
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
#line 1 "E:\alice\Alice\Alice.Web\Views\_ViewImports.cshtml"
using Alice.Web;

#line default
#line hidden
#line 2 "E:\alice\Alice\Alice.Web\Views\_ViewImports.cshtml"
using Alice.Web.Models;

#line default
#line hidden
#line 1 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
using Alice.Service.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3edae419379d3f2b8b5b734add3116bf7d58d109", @"/Views/Category/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e93ce5880de5b382b5c3edaf77636ae93e9007", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoriesDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/css/cssPlugins.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/img/quote.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/img/litlePrev.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/img/litleNext.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/js/plugins.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(141, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3edae419379d3f2b8b5b734add3116bf7d58d1096319", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(202, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3edae419379d3f2b8b5b734add3116bf7d58d1097572", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(256, 147, true);
            WriteLiteral("\r\n\r\n<section class=\"mansetNoneSlide\">\r\n    <div class=\"catSlide\">\r\n        <!-- eğer 1 tane olacaksa catSlide divine onlyOneItem class\'ı ekle -->\r\n");
            EndContext();
#line 14 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
          
            foreach (var item in ((Alice.Web.Models.CategoryModel)ViewBag.CategorySlider).ImagePath)
            {

#line default
#line hidden
            BeginContext(532, 35, true);
            WriteLiteral("                <div class=\"fullBg\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 567, "\"", 596, 3);
            WriteAttributeValue("", 575, "background:url(", 575, 15, true);
#line 17 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
WriteAttributeValue("", 590, item, 590, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 595, ")", 595, 1, true);
            EndWriteAttribute();
            BeginContext(597, 80, true);
            WriteLiteral("></div> <!-- eğer 1 tane olacaksa catSlide divine onlyOneItem class\'ı ekle -->\r\n");
            EndContext();
#line 18 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
            }
        

#line default
#line hidden
            BeginContext(703, 466, true);
            WriteLiteral(@"    </div>

</section>
<section class=""generallyInfo basicPages"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 col-md-12 col-lg-6"">
                <div class=""grayBox"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item active""><a href=""/"">HOME</a></li>
                            <li class=""breadcrumb-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1169, "\"", 1187, 1);
#line 31 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
WriteAttributeValue("", 1176, Model.Path, 1176, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1188, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1191, 22, false);
#line 31 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                                                          Write(Model.Title?.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1214, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
            BeginContext(1416, 149, true);
            WriteLiteral("                        </ol>\r\n                    </nav>\r\n                    <h1 class=\"pageTitle wow slideInLeft\">\r\n                        <span>");
            EndContext();
            BeginContext(1566, 11, false);
#line 37 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                         Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1577, 292, true);
            WriteLiteral(@"</span>

                    </h1>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 col-md-12 col-lg-12"">
                <div class=""lineText"">
                    <p class=""wow slideInLeft"">
                        ");
            EndContext();
            BeginContext(1870, 17, false);
#line 47 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                   Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1887, 211, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"events withThreeBlock\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 58 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
              
                foreach (var item in ((List<Alice.Service.Model.CategoriesDTO>)ViewBag.SubCategories))
                {
                    var image = ((Dictionary<int, string>)((Alice.Web.Models.CategoryModel)ViewBag.CategorySlider).NewCategoryImageList);

#line default
#line hidden
            BeginContext(2376, 328, true);
            WriteLiteral(@"                    <div class=""col-12 col-md-4 col-lg-3"">
                        <div class=""blurBox col3  wow fadeIn"" data-wow-delay=""0.1s"">
                            <div class=""insiderBox"">
                                <a>
                                    <picture>
                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2704, "\"", 2759, 1);
#line 67 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
WriteAttributeValue("", 2710, image.FirstOrDefault(x=> x.Key==item.Id).Value, 2710, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2760, 11, true);
            WriteLiteral(" data-src=\"");
            EndContext();
            BeginContext(2773, 46, false);
#line 67 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                                                                                           Write(image.FirstOrDefault(x=> x.Key==item.Id).Value);

#line default
#line hidden
            EndContext();
            BeginContext(2820, 115, true);
            WriteLiteral("\" data-loadMode=\"0\" alt=\"\">\r\n                                    </picture>\r\n                                </a>\r\n");
            EndContext();
#line 70 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                  
                                    if (item.SubCategory == null || item.SubCategory.Count() == 0)
                                    {

#line default
#line hidden
            BeginContext(3110, 148, true);
            WriteLiteral("                                        <div class=\"insiderContent noneSubMenu\">\r\n                                            <a class=\"visibleText\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3258, "\"", 3275, 1);
#line 74 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
WriteAttributeValue("", 3265, item.Path, 3265, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3276, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3278, 17, false);
#line 74 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                                                                Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(3295, 54, true);
            WriteLiteral("</a>\r\n                                        </div>\r\n");
            EndContext();
#line 76 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3469, 136, true);
            WriteLiteral("                                        <div class=\"insiderContent\">\r\n                                            <a class=\"visibleText\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3605, "\"", 3622, 1);
#line 80 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
WriteAttributeValue("", 3612, item.Path, 3612, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3623, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3625, 17, false);
#line 80 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                                                                Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(3642, 56, true);
            WriteLiteral("</a>\r\n                                            <ul>\r\n");
            EndContext();
#line 82 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                                 foreach (var jitem in item.SubCategory)
                                                {

#line default
#line hidden
            BeginContext(3839, 116, true);
            WriteLiteral("                                                    <li>\r\n                                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3955, "\"", 3980, 1);
#line 85 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
WriteAttributeValue("", 3962, $"{jitem.Path}", 3962, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3981, 63, true);
            WriteLiteral(">\r\n                                                            ");
            EndContext();
            BeginContext(4045, 18, false);
#line 86 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                                       Write(jitem.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(4063, 123, true);
            WriteLiteral("\r\n                                                        </a>\r\n                                                    </li>\r\n");
            EndContext();
#line 89 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                                }

#line default
#line hidden
            BeginContext(4237, 99, true);
            WriteLiteral("                                            </ul>\r\n                                        </div>\r\n");
            EndContext();
#line 92 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(4410, 96, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 97 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                }
            

#line default
#line hidden
            BeginContext(4540, 424, true);
            WriteLiteral(@"
            <section class=""tours"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""tab-content"" id=""myTabContent"">
                                <div class=""tab-pane fade show active"" id=""domesticTours"" role=""tabpanel"" aria-labelledby=""domesticTours-tab"">
                                    <ul>
");
            EndContext();
#line 107 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                         foreach (var item in ((List<Alice.Service.Model.TourDTO>)ViewBag.TourList))
                                        {

#line default
#line hidden
            BeginContext(5125, 204, true);
            WriteLiteral("                                            <li class=\"animated fadeIn\">\r\n                                                <figure class=\"borderBox\">\r\n                                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5329, "\"", 5369, 1);
#line 111 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
WriteAttributeValue("", 5336, $"{Model.Path}/{item.TourUrl}", 5336, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5370, 219, true);
            WriteLiteral(">\r\n                                                        <span class=\"wrap\">\r\n                                                            <picture>\r\n                                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5589, "\"", 5610, 1);
#line 114 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
WriteAttributeValue("", 5595, item.TourImage, 5595, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5611, 11, true);
            WriteLiteral(" data-src=\"");
            EndContext();
            BeginContext(5623, 14, false);
#line 114 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                                                                                Write(item.TourImage);

#line default
#line hidden
            EndContext();
            BeginContext(5637, 103, true);
            WriteLiteral("\" data-loadMode=\"0\" alt=\"\" />\r\n                                                            </picture>\r\n");
            EndContext();
            BeginContext(5842, 264, true);
            WriteLiteral(@"                                                        </span>
                                                    </a>
                                                    <figcaption class=""whiteBox"">
                                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6106, "\"", 6146, 1);
#line 120 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
WriteAttributeValue("", 6113, $"{Model.Path}/{item.TourUrl}", 6113, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6147, 146, true);
            WriteLiteral(">\r\n                                                            <b class=\"title\">\r\n                                                                ");
            EndContext();
            BeginContext(6294, 13, false);
#line 122 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                                           Write(item.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(6307, 134, true);
            WriteLiteral("\r\n                                                            </b>\r\n                                                            <span>");
            EndContext();
            BeginContext(6443, 23, false);
#line 124 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                                              Write(Html.Raw(item.TourSpot));

#line default
#line hidden
            EndContext();
            BeginContext(6467, 514, true);
            WriteLiteral(@"</span>
                                                            <em>
                                                                DISCOVER  MORE <i class=""fa fa-caret-right"" aria-hidden=""true""></i>
                                                            </em>
                                                        </a>
                                                    </figcaption>
                                                </figure>
                                            </li>
");
            EndContext();
#line 132 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                                        }

#line default
#line hidden
            BeginContext(7024, 229, true);
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n\r\n");
            EndContext();
            BeginContext(9718, 1379, true);
            WriteLiteral(@"
        </div>
    </div>
</section>

<section class=""parallaxBox lazyload"" style=""background: url(/Content/img/middleBox.jpg)"" data-link=""/Content/css/parallaxModule.css"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""parallax"">
                    <h3>
                        Exclusive <br> Vip Experiences
                    </h3>
                    <p>
                        Luxury Istanbul is the premier address in Turkey for exclusive travel services; combining comfort and authenticity in the Turkey's  as being specialists in luxury tailor-made holidays; it is perfect . <br><br>
                        This is where you will find high quality, exclusively private and personalized travel options to fulfill your individual or  corporate travel requirements for your holiday in Turkey.

                    </p>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""testimo");
            WriteLiteral(@"nials lazyload"" data-link=""/Content/css/commentModule.css"" data-script=""/Content/js/commentModule.js"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col"">
                <div class=""commentSlider"">
                    <div class=""item"">
                        <div class=""itemContent"">
                            ");
            EndContext();
            BeginContext(11097, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3edae419379d3f2b8b5b734add3116bf7d58d10926385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11132, 713, true);
            WriteLiteral(@"
                            <p>
                                There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum.
                            </p>
                            <span>
                                Sylvain Schuler <strong>Marketing Director of DIAC, Groupe DIAC</strong>
                            </span>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""itemContent"">
                            ");
            EndContext();
            BeginContext(11845, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3edae419379d3f2b8b5b734add3116bf7d58d10928275", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11880, 713, true);
            WriteLiteral(@"
                            <p>
                                There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum.
                            </p>
                            <span>
                                Sylvain Schuler <strong>Marketing Director of DIAC, Groupe DIAC</strong>
                            </span>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""itemContent"">
                            ");
            EndContext();
            BeginContext(12593, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3edae419379d3f2b8b5b734add3116bf7d58d10930165", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12628, 746, true);
            WriteLiteral(@"
                            <p>
                                There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum.
                            </p>
                            <span>
                                Sylvain Schuler <strong>Marketing Director of DIAC, Groupe DIAC</strong>
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""commentNav"">
                    <button type=""button"" class=""litlePrev"">
                        ");
            EndContext();
            BeginContext(13374, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3edae419379d3f2b8b5b734add3116bf7d58d10932090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13420, 119, true);
            WriteLiteral("\r\n                    </button>\r\n                    <button type=\"button\" class=\"litleNext\">\r\n                        ");
            EndContext();
            BeginContext(13539, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3edae419379d3f2b8b5b734add3116bf7d58d10933474", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13585, 1166, true);
            WriteLiteral(@"
                    </button>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""recommended"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""discoveredBox"">
                    <div class=""recommendedBlackBox"">
                        <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""~/Content/img/recoBox.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
                        <div class=""psAbslt"">
                            <h2 class=""colorableText"">Recommended By <span>Luxury Istanbul</span></h2>
                            <a href=""javascript:;"" class=""gradientBtn"">
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""~/Content/img/discoverNow.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
                            </a>
  ");
            WriteLiteral("                      </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(14768, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(14774, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3edae419379d3f2b8b5b734add3116bf7d58d10936162", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14821, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoriesDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591