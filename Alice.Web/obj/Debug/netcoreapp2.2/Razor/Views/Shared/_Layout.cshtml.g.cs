#pragma checksum "E:\alice\Alice\Alice.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c6849f03814681254cd8dd28d3aaa7a27b05081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c6849f03814681254cd8dd28d3aaa7a27b05081", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e93ce5880de5b382b5c3edaf77636ae93e9007", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/css/cssPlugins.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\alice\Alice\Alice.Web\Views\Shared\_Layout.cshtml"
  
    var homeModel = (Alice.Web.Models.LayoutModel)ViewBag.HomePage;


#line default
#line hidden
            BeginContext(78, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(105, 1208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6849f03814681254cd8dd28d3aaa7a27b050816713", async() => {
                BeginContext(111, 43, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>");
                EndContext();
                BeginContext(155, 17, false);
#line 10 "E:\alice\Alice\Alice.Web\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(172, 103, true);
                WriteLiteral(" - Alice.Web</title>\r\n    <meta name=\"author\" content=\"Erkan Güzelküçük\">\r\n    <meta name=\"description\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 275, "\"", 328, 1);
#line 12 "E:\alice\Alice\Alice.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 285, ViewData["SEODescription"]??string.Empty, 285, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(329, 137, true);
                WriteLiteral(">\r\n    <meta name=\"keywords\" content=\"\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\r\n    ");
                EndContext();
                BeginContext(466, 187, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6849f03814681254cd8dd28d3aaa7a27b050818144", async() => {
                    BeginContext(500, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(510, 59, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c6849f03814681254cd8dd28d3aaa7a27b050818561", async() => {
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
                    BeginContext(569, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(579, 54, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c6849f03814681254cd8dd28d3aaa7a27b050819975", async() => {
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
                    BeginContext(633, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(653, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(659, 645, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6849f03814681254cd8dd28d3aaa7a27b0508112467", async() => {
                    BeginContext(694, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(704, 59, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c6849f03814681254cd8dd28d3aaa7a27b0508112885", async() => {
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
                    BeginContext(763, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(773, 54, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c6849f03814681254cd8dd28d3aaa7a27b0508114300", async() => {
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
                    BeginContext(827, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(1286, 4, true);
                    WriteLiteral("    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1304, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(1313, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1315, 12494, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6849f03814681254cd8dd28d3aaa7a27b0508117717", async() => {
                BeginContext(1321, 4404, true);
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
                            <a href=""/"">
                                <img src=""/Content/img/logo.png"" alt=""Luxury İstanbul"">
                            </a>
                        </div>
                        <div class=""menu-wrapper"">
                            <div class=""hamburger-menu""></div>
                        </div>
                        <div class=""search d-flex align-items-center justify-content-center"">
                            <span>SEAR");
                WriteLiteral(@"CH</span>
                            <a href=""javascript:;"" class=""searchButton"">
                                <i class=""flaticon""></i>
                            </a>
                            <input type=""text"" placeholder=""Search on site"">
                        </div>
                    </div>
                    <div class=""fixedBottomMenu homeMenu"">
                        <!-- Sadece anasyafa da diğerlerinden farklı olaarak homeMenu classı eklenicek -->
                        <ul class=""d-flex align-items-center justify-content-center"">
                            <li>
                                <a href=""/"">
                                    HOME
                                </a>
                            </li>
                            <li>
                                <a href=""/Page/our-services"">
                                    OUR SERVICES
                                </a>
                            </li>
                            <li>
     ");
                WriteLiteral(@"                           <a href=""/Page/about-us"">
                                    ABOUT
                                </a>
                            </li>
                            <li>
                                <a href=""/Page/why-luxury-istanbul"">
                                    WHY LUXURY ISTANBUL
                                </a>
                            </li>
                            <li>
                                <a href=""/Page/destinations"">
                                    DESTINATIONS
                                </a>
                            </li>
                            <li>
                                <a href=""/Page/contact-us"">
                                    CONTACT US
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <div class=""topSocialMedia"">
        <div cla");
                WriteLiteral(@"ss=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <ul>
                        <li class=""wow fadeIn"" data-wow-duration=""0.9s"" data-wow-delay=""0.3s"">
                            <a href=""javascript:;"">
                                <i class=""fab fa-instagram""></i>
                            </a>
                        </li>
                        <li class=""wow fadeIn"" data-wow-duration=""0.9s"" data-wow-delay=""0.6s"">
                            <a href=""javascript:;"">
                                <i class=""fab fa-youtube""></i>
                            </a>
                        </li>
                        <li class=""wow fadeIn"" data-wow-duration=""0.9s"" data-wow-delay=""0.9s"">
                            <a href=""javascript:;"">
                                <i class=""fab fa-facebook-f""></i>
                            </a>
                        </li>
                        <li class=""wow fadeIn"" data-wow-duration=""0.9s"" d");
                WriteLiteral(@"ata-wow-delay=""1.2s"">
                            <a href=""javascript:;"">
                                <i class=""fab fa-twitter""></i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    ");
                EndContext();
                BeginContext(5726, 12, false);
#line 126 "E:\alice\Alice\Alice.Web\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5738, 1622, true);
                WriteLiteral(@"
    <footer class=""footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col"">
                    <div class=""favourites"">
                        <ul class=""d-flex align-items-center justify-content-around"">
                            <li>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/f1.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
                            </li>
                            <li>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/f2.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
                            </li>
                            <li>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/f3.png"" data-loadMode=""0"" class=");
                WriteLiteral(@"""lazyload"" alt=""Luxury İstanbul"">
                            </li>
                            <li>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/f4.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
                            </li>

                        </ul>
                    </div>
                    <div class=""footerBottom"">
                        <div class=""newsletter"">
                            <h3>SIGN UP TO OUR NEWSLETTER</h3>
                            ");
                EndContext();
                BeginContext(7360, 1223, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6849f03814681254cd8dd28d3aaa7a27b0508124783", async() => {
                    BeginContext(7386, 1190, true);
                    WriteLiteral(@"
                                <div class=""form-div"">
                                    <input type=""text"" name=""name"" placeholder=""Full Name"">
                                </div>
                                <div class=""form-div"">
                                    <input type=""mail"" name=""mail"" placeholder=""Email Address"">
                                </div>
                                <div class=""formResult"">
                                    <input type=""submit"" value=""SIGN UP"">
                                    <div class=""check"">
                                        <div class=""custom-control custom-checkbox mr-sm-2"">
                                            <input type=""checkbox"" class=""custom-control-input"" id=""customControlAutosizing"">
                                            <label class=""custom-control-label"" for=""customControlAutosizing"">I am happy to receive emails from Jacada <br> Travel including the latest travel guides, <br> tips and information.</la");
                    WriteLiteral("bel>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                BeginContext(8583, 3952, true);
                WriteLiteral(@"
                        </div>
                        <div class=""footerSocialMedia"">
                            <ul class=""d-flex align-items-center"">
                                <li>
                                    <a href=""javascript:;"">
                                        <i class=""fab fa-instagram""></i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:;"">
                                        <i class=""fab fa-youtube""></i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:;"">
                                        <i class=""fab fa-facebook-f""></i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:;"">
     ");
                WriteLiteral(@"                                   <i class=""fab fa-twitter""></i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:;"">
                                        <i class=""fab fa-linkedin-in""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
                        <div class=""f-links d-flex align-items-center"">
                            <ul>
                                <li>
                                    <a href=""javascript:;"">
                                        BLOG
                                    </a>
                                </li>
                                <li>
                                    <a href=""/Page/terms-condations"">
                                        TERMS & CONDATIONS
                                    </a>
         ");
                WriteLiteral(@"                       </li>
                                <li>
                                    <a href=""/Page/privacy-policy"">
                                        PRIVACY POLICY
                                    </a>
                                </li>
                            </ul>
                            <ul>
                                <li>
                                    <a href=""/Page/agents"">
                                        AGENTS
                                    </a>
                                </li>
                                <li>
                                    <a href=""/Page/faqs"">
                                        FAQ'S
                                    </a>
                                </li>
                                <li>
                                    <a href=""/Page/sitemap"">
                                        SITEMAP
                                    </a>
                                </li>");
                WriteLiteral(@"
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <section class=""copyRight"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""d-flex align-items-center justify-content-between"">
                        <span class=""copy"">© Copyright 2019 Luxury Istanbul</span>
                        <h2 class=""grayLogo"">
                            <b>LUXURY</b> ISTANBUL
                        </h2>
                        <a href=""tel:00905353122642"" class=""f-tel"">
                            <i class=""fas fa-phone-volume""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>

    ");
                EndContext();
                BeginContext(12535, 111, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6849f03814681254cd8dd28d3aaa7a27b0508132008", async() => {
                    BeginContext(12569, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(12579, 47, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6849f03814681254cd8dd28d3aaa7a27b0508132430", async() => {
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
                    BeginContext(12626, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(12646, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(12652, 972, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6849f03814681254cd8dd28d3aaa7a27b0508134845", async() => {
                    BeginContext(12687, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(12697, 47, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6849f03814681254cd8dd28d3aaa7a27b0508135267", async() => {
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
                    BeginContext(12744, 4, true);
                    WriteLiteral("\r\n\r\n");
                    EndContext();
                    BeginContext(13606, 4, true);
                    WriteLiteral("    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13624, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(13633, 41, false);
#line 277 "E:\alice\Alice\Alice.Web\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(13674, 128, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(function () {\r\n            $(\'.fixedBottomMenu\').addClass(\"homeMenu\");\r\n        });\r\n    </script>\r\n");
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
            BeginContext(13809, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
