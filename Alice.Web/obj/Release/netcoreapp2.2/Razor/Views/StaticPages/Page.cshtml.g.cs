#pragma checksum "E:\alice\Alice\Alice.Web\Views\StaticPages\Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46c7198d043a4bf0b40199c9ab3f79074831565b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StaticPages_Page), @"mvc.1.0.view", @"/Views/StaticPages/Page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StaticPages/Page.cshtml", typeof(AspNetCore.Views_StaticPages_Page))]
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
#line 1 "E:\alice\Alice\Alice.Web\Views\StaticPages\Page.cshtml"
using Alice.Service.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46c7198d043a4bf0b40199c9ab3f79074831565b", @"/Views/StaticPages/Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e93ce5880de5b382b5c3edaf77636ae93e9007", @"/Views/_ViewImports.cshtml")]
    public class Views_StaticPages_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StaticPagesDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/css/cssPlugins.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/css/commentModule.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/js/plugins.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/js/commentModule.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\alice\Alice\Alice.Web\Views\StaticPages\Page.cshtml"
  
    ViewData["Title"] = Model.PageTitle;
    ViewData["SEODescription"] = Model.PageTitle;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(198, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "46c7198d043a4bf0b40199c9ab3f79074831565b6857", async() => {
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
            BeginContext(257, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(259, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "46c7198d043a4bf0b40199c9ab3f79074831565b8110", async() => {
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
            BeginContext(313, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(315, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "46c7198d043a4bf0b40199c9ab3f79074831565b9363", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(377, 1363, true);
            WriteLiteral(@"

<header class=""header"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""fixedTopMenu d-flex align-items-center justify-content-between"">
                    <i class=""flaticon-search""></i>
                    <div class=""callUs"">
                        <span>Call Us 24/7</span>
                        <a href=""tel:00905353122642"">+90 535 312 2642</a>
                    </div>
                    <div class=""logo"">
                        <a href=""index.html"">
                            <img src=""/Content/img/logo.png"" alt=""Luxury İstanbul"">
                        </a>
                    </div>
                    <div class=""menu-wrapper"">
                        <div class=""hamburger-menu""></div>
                    </div>
                    <div class=""search d-flex align-items-center justify-content-center"">
                        <span>SEARCH</span>
                        <a href=""javascript:;"" class=""search");
            WriteLiteral(@"Button"">
                            <i class=""flaticon""></i>
                        </a>
                        <input type=""text"" placeholder=""Search on site"">
                    </div>
                </div>
            </div>
        </div>
    </div>
</header>

<section class=""mansetNoneSlide"">
    <div class=""fullBg""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1740, "\"", 1780, 3);
            WriteAttributeValue("", 1748, "background:url(", 1748, 15, true);
#line 44 "E:\alice\Alice\Alice.Web\Views\StaticPages\Page.cshtml"
WriteAttributeValue("", 1763, Model.PageImage, 1763, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1779, ")", 1779, 1, true);
            EndWriteAttribute();
            BeginContext(1781, 2077, true);
            WriteLiteral(@"></div>
    <div class=""topSocialMedia"">
        <!-- iç sayfalarda bu div bunun içinde yer almalı -->
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <ul>
                        <li class=""wow fadeIn"" data-wow-duration=""0.3s"" data-wow-delay=""0.3s"">
                            <a href=""https://www.instagram.com/luxuryistanbul/"">
                                <i class=""fab fa-instagram""></i>
                            </a>
                        </li>
                        <li class=""wow fadeIn"" data-wow-duration=""0.3s"" data-wow-delay=""0.6s"">
                            <a href=""javascript:;"">
                                <i class=""fab fa-youtube""></i>
                            </a>
                        </li>
                        <li class=""wow fadeIn"" data-wow-duration=""0.3s"" data-wow-delay=""0.9s"">
                            <a href=""https://www.facebook.com/LuxuryIstanbul/"">
                          ");
            WriteLiteral(@"      <i class=""fab fa-facebook-f""></i>
                            </a>
                        </li>
                        <li class=""wow fadeIn"" data-wow-duration=""0.3s"" data-wow-delay=""1.2s"">
                            <a href=""https://twitter.com/luxuryistanbul"">
                                <i class=""fab fa-twitter""></i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""generallyInfo basicPages"">
    <!-- Düz yazıların oldugu sayfalarda bu kısma basicPages classı ekle -->
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 col-md-6 col-lg-6"">
                <div class=""grayBox"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item active""><a href=""/"">HOME</a></li>
                            <li class=""breadcrum");
            WriteLiteral("b-item \" aria-current=\"page\">");
            EndContext();
            BeginContext(3859, 15, false);
#line 86 "E:\alice\Alice\Alice.Web\Views\StaticPages\Page.cshtml"
                                                                        Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(3874, 156, true);
            WriteLiteral("</li>\r\n                        </ol>\r\n                    </nav>\r\n                    <h1 class=\"pageTitle wow slideInLeft\">\r\n                        <span>");
            EndContext();
            BeginContext(4031, 15, false);
#line 90 "E:\alice\Alice\Alice.Web\Views\StaticPages\Page.cshtml"
                         Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(4046, 219, true);
            WriteLiteral("</span>\r\n                    </h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-md-12 col-lg-12\">\r\n                <div class=\"lineText\">\r\n\r\n");
            EndContext();
#line 99 "E:\alice\Alice\Alice.Web\Views\StaticPages\Page.cshtml"
                      
                        if (Model.PageTitle == "Contact Us")
                        {

#line default
#line hidden
            BeginContext(4378, 4676, true);
            WriteLiteral(@"                            <section class=""generallyInfo basicPages"">
                                <!-- Düz yazıların oldugu sayfalarda bu kısma basicPages classı ekle -->
                                <div class=""container"">
                                    <div class=""row"">
                                        <div class=""col-12 col-md-6 col-lg-6"">
                                            <div class=""grayBox"">
                                                <nav aria-label=""breadcrumb"">
                                                    <ol class=""breadcrumb"">
                                                        <li class=""breadcrumb-item active""><a href=""/"">HOME</a></li>
                                                        <li class=""breadcrumb-item "" aria-current=""page"">CONTACT</li>
                                                    </ol>
                                                </nav>
                                                <h1 class=""pageTitle wow slideI");
            WriteLiteral(@"nLeft"">
                                                    <span>Contact</span>   Us
                                                </h1>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-12 col-md-12 col-lg-12"">
                                            <div class=""lineText"">
                                                <p>
                                                    LuxuryIstanbul - Grand TTG Travel <br>
                                                    Licence Numver: A-5918 (TÜRSAB Association of Turkish Travel Agencies)
                                                </p>
                                            </div>
                                            <div class=""contactInfo"">
                                                <ul>
                                ");
            WriteLiteral(@"                    <li>
                                                        <h3>Address</h3>
                                                        <p>
                                                            Emin sinan Mah.  <br>
                                                            Emin Sinan Hamam Sok.  <br>
                                                            Beyzade Han  <br>
                                                            No:6 Kat:3 <br>
                                                            Sultanahmet - Istanbul / Turkey
                                                        </p>
                                                    </li>
                                                    <li>
                                                        <h3>Phone</h3>
                                                        <a href=""tel:00905413122642 "">+90 (541) 312 26 42 </a>
                                                        <a href=""tel:0090535312");
            WriteLiteral(@"2642 "">+90 (535) 312 26 42 </a>
                                                        <h3 class=""secondTitle"">Fax</h3>
                                                        <a href=""javascript:;"">+90 (212) 517 00 09</a>
                                                    </li>
                                                    <li>
                                                        <h3>Web Site</h3>
                                                        <a href=""http://www.luxuryistanbul.com"">http://www.luxuryistanbul.com</a>
                                                        <h3 class=""secondTitle"">E-mail</h3>
                                                        <a href=""mailto:luxuryistanbul@gmail.com"">luxuryistanbul@gmail.com</a>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class=""contactModel"">
               ");
            WriteLiteral(@"                                 <div class=""row"">
                                                    <div class=""col-12 col-md-12 col-lg-6"">
                                                        <h3>Have a Question?</h3>
                                                        <p>
                                                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's.
                                                        </p>
                                                        ");
            EndContext();
            BeginContext(9054, 3624, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46c7198d043a4bf0b40199c9ab3f79074831565b21059", async() => {
                BeginContext(9100, 3571, true);
                WriteLiteral(@"
                                                            <div class=""form-item"">
                                                                <p>
                                                                    Your Name
                                                                </p>
                                                                <input type=""text"" class=""form-control"" placeholder=""First Name, Surname"">
                                                            </div>
                                                            <div class=""form-item"">
                                                                <p>
                                                                    Contact Number
                                                                </p>
                                                                <input type=""tel"" class=""form-control"" placeholder=""+ 90 |"">
                                                            </div>
         ");
                WriteLiteral(@"                                                   <div class=""form-item"">
                                                                <p>
                                                                    Email Address
                                                                </p>
                                                                <input type=""mail"" class=""form-control"" placeholder=""Enter Email address"">
                                                            </div>
                                                            <div class=""form-item"">
                                                                <p>
                                                                    Country
                                                                </p>
                                                                <input type=""text"" class=""form-control"">
                                                            </div>
                                           ");
                WriteLiteral(@"                 <div class=""form-item"">
                                                                <p>
                                                                    Subject
                                                                </p>
                                                                <input type=""text"" class=""form-control"">
                                                            </div>
                                                            <div class=""form-item"">
                                                                <p>
                                                                    Message
                                                                </p>
                                                                <textarea name="""" id="""" class=""form-control""></textarea>
                                                            </div>
                                                            <div class=""form-item"">
                ");
                WriteLiteral(@"                                                <div class=""contactSub"">
                                                                    <input type=""submit"" class=""form-control"" value=""SEND"">
                                                                    <i class=""fas fa-caret-right""></i>
                                                                </div>
                                                            </div>
                                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12678, 1442, true);
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""col-12 col-md-12 col-lg-6"">
                                                        <div class=""contact-map"">
                                                            <iframe data-src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3219.631547220442!2d29.63268611556105!3d36.199841708961564!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14c1db16df060f7b%3A0x347fe3a07630a718!2sKa%C5%9F%20Antik%20Tiyatro!5e0!3m2!1str!2str!4v1579035012714!5m2!1str!2str"" width=""100%"" height=""100%"" frameborder=""0"" style=""border:0;"" allowfullscreen="""" class=""lazyload""></iframe>
                                                        </div>
                                                        <div class=""onlyImg"">
                                                            <img src=""/Content/img/tripadvisor.jpg"" data-src=""/Content/img/tripadvisor.jpg"" data-loadMode=""0"" class=""lazyload"" a");
            WriteLiteral(@"lt=""Travel"">
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </section>
");
            EndContext();
#line 221 "E:\alice\Alice\Alice.Web\Views\StaticPages\Page.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(14204, 65, true);
            WriteLiteral("                            <p>\r\n                                ");
            EndContext();
            BeginContext(14270, 24, false);
#line 225 "E:\alice\Alice\Alice.Web\Views\StaticPages\Page.cshtml"
                           Write(Html.Raw(Model.PageBody));

#line default
#line hidden
            EndContext();
            BeginContext(14294, 36, true);
            WriteLiteral("\r\n                            </p>\r\n");
            EndContext();
#line 227 "E:\alice\Alice\Alice.Web\Views\StaticPages\Page.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(14380, 94, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n \r\n \r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(14491, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(14497, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46c7198d043a4bf0b40199c9ab3f79074831565b29383", async() => {
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
                BeginContext(14544, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(14550, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46c7198d043a4bf0b40199c9ab3f79074831565b30641", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14603, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StaticPagesDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
