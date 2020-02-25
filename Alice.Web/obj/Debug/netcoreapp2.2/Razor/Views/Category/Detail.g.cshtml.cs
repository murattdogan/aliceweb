#pragma checksum "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "982243611c4389c799390609a12b76dfaa741ee8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"982243611c4389c799390609a12b76dfaa741ee8", @"/Views/Category/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e93ce5880de5b382b5c3edaf77636ae93e9007", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoriesDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 2717, true);
            WriteLiteral(@"
<section class=""mansetNoneSlide"">
    <div class=""catSlide"">
        <!-- eğer 1 tane olacaksa catSlide divine onlyOneItem class'ı ekle -->
        <div class=""fullBg"" style=""background:url(assets/img/bg4.jpg)""></div> <!-- eğer 1 tane olacaksa catSlide divine onlyOneItem class'ı ekle -->
        <div class=""fullBg"" style=""background:url(assets/img/bg3.jpg)""></div>
        <div class=""fullBg"" style=""background:url(assets/img/bg2.jpg)""></div>
    </div>
    <div class=""topSocialMedia"">
        <!-- iç sayfalarda bu div bunun içinde yer almalı -->
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <ul>
                        <li class=""wow fadeIn"" data-wow-duration=""0.3s"" data-wow-delay=""0.3s"">
                            <a href=""javascript:;"">
                                <i class=""fab fa-instagram""></i>
                            </a>
                        </li>
                        <li class=""wow fadeIn"" data-wo");
            WriteLiteral(@"w-duration=""0.3s"" data-wow-delay=""0.6s"">
                            <a href=""javascript:;"">
                                <i class=""fab fa-youtube""></i>
                            </a>
                        </li>
                        <li class=""wow fadeIn"" data-wow-duration=""0.3s"" data-wow-delay=""0.9s"">
                            <a href=""javascript:;"">
                                <i class=""fab fa-facebook-f""></i>
                            </a>
                        </li>
                        <li class=""wow fadeIn"" data-wow-duration=""0.3s"" data-wow-delay=""1.2s"">
                            <a href=""javascript:;"">
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
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12");
            WriteLiteral(@" col-md-12 col-lg-6"">
                <div class=""grayBox"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item active""><a href=""#"">HOME</a></li>
                            <li class=""breadcrumb-item""><a href=""#"">Travel</a></li>
                            <li class=""breadcrumb-item""><a href=""#"">Tour packages </a></li>
                            <li class=""breadcrumb-item "" aria-current=""page"">Family</li>
                        </ol>
                    </nav>
                    <h1 class=""pageTitle wow slideInLeft"">
                        <span>");
            EndContext();
            BeginContext(2857, 18, false);
#line 61 "E:\alice\Alice\Alice.Web\Views\Category\Detail.cshtml"
                         Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(2875, 17453, true);
            WriteLiteral(@"</span>

                    </h1>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 col-md-12 col-lg-12"">
                <div class=""lineText"">
                    <p class=""wow slideInLeft"">
                        Luxury Istanbul is the premier address in Turkey for exclusive travel services; combining comfort and authenticity in the Turkey's captivating destinations. As being specialists in luxury tailor-made holidays; it is perfect for those times when you are looking to spoil yourself with a romantic getaway or special experience. <br><br>

                        This is where you will find high quality, exclusively private and personalized travel options to fulfill your individual or  corporate travel requirements for your holiday in Turkey.
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""events withThreeBlock"">
    <div class=""container"">
    ");
            WriteLiteral(@"    <div class=""row"">
            <div class=""col-12 col-md-4 col-lg-3"">
                <div class=""blurBox col3  wow fadeIn"" data-wow-delay=""0.1s"">
                    <div class=""insiderBox"">
                        <a>
                            <picture>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/c1.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Travel"">
                            </picture>
                        </a>
                        <div class=""insiderContent noneSubMenu"">
                            <!-- Eğer alt menu yoksa noneSubMenu class'ı ekle -->
                            <a class=""visibleText"" href=""family-packages.html"">Tailor your <br> Vacation</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-4 col-lg-3"">
                <div class=""blurBox col3 wow fadeIn"" data-wow-delay=""0.2s"">");
            WriteLiteral(@"
                    <div class=""insiderBox"">
                        <a>
                            <picture>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/c2.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Travel"">
                            </picture>
                        </a>
                        <div class=""insiderContent"">
                            <a class=""visibleText"" href=""family-packages.html"">Chauffeur <br> Services</a>
                            <ul>
                                <li>
                                    <a href=""family-packages.html"">
                                        Short Group Jeourney
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Culture
                                    </a");
            WriteLiteral(@">
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Family
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Culture
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Family
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Culture
                                    </a>
                                </li>
                            </ul>
 ");
            WriteLiteral(@"                       </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-4 col-lg-3"">
                <div class=""blurBox col3  wow fadeIn"" data-wow-delay=""0.3s"">
                    <div class=""insiderBox"">
                        <a>
                            <picture>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/c3.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Travel"">
                            </picture>
                        </a>
                        <div class=""insiderContent noneSubMenu"">
                            <!-- Eğer alt menu yoksa noneSubMenu class'ı ekle -->
                            <a class=""visibleText"" href=""family-packages.html"">Yacht & Boat <br> Charter</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-4 col-lg-");
            WriteLiteral(@"3"">
                <div class=""blurBox col3 wow fadeIn"" data-wow-delay=""0.4s"">
                    <div class=""insiderBox"">
                        <a>
                            <picture>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/c4.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Travel"">
                            </picture>
                        </a>
                        <div class=""insiderContent"">
                            <a class=""visibleText"" href=""family-packages.html"">Jet & Heli <br> Charter</a>
                            <ul>
                                <li>
                                    <a href=""family-packages.html"">
                                        Family
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                      ");
            WriteLiteral(@"                  Culture
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Resort
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Honeymoon
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Resort
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Honeymoon
                                    </a>
     ");
            WriteLiteral(@"                           </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col-12 col-md-4 col-lg-3"">
                <div class=""blurBox col3  wow fadeIn"" data-wow-delay=""0.5s"">
                    <div class=""insiderBox"">
                        <a>
                            <picture>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/c5.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Travel"">
                            </picture>
                        </a>
                        <div class=""insiderContent noneSubMenu"">
                            <!-- Eğer alt menu yoksa noneSubMenu class'ı ekle -->
                            <a class=""visibleText"" href=""family-packages.html"">Day <br> Tours</a>
                        </div>
                    </div>
                </div>
      ");
            WriteLiteral(@"      </div>
            <div class=""col-12 col-md-4 col-lg-3"">
                <div class=""blurBox col3 wow fadeIn"" data-wow-delay=""0.6s"">
                    <div class=""insiderBox"">
                        <a>
                            <picture>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/c6.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Travel"">
                            </picture>
                        </a>
                        <div class=""insiderContent"">
                            <a class=""visibleText"" href=""family-packages.html"">Tour <br> Packages</a>
                            <ul>
                                <li>
                                    <a href=""family-packages.html"">
                                        Culture
                                    </a>
                                </li>
                                <li>
                                  ");
            WriteLiteral(@"  <a href=""family-packages.html"">
                                        Family
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Resort
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Honeymoon
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Short Group Jeourney
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                            ");
            WriteLiteral(@"            Culture
                                    </a>
                                </li>
                                <li>
                                    <a href=""family-packages.html"">
                                        Family
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-4 col-lg-3"">
                <div class=""blurBox col3  wow fadeIn"" data-wow-delay=""0.7s"">
                    <div class=""insiderBox"">
                        <a>
                            <picture>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/c7.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Travel"">
                            </picture>
                        </a>
                        <div class=""");
            WriteLiteral(@"insiderContent noneSubMenu"">
                            <!-- Eğer alt menu yoksa noneSubMenu class'ı ekle -->
                            <a class=""visibleText"" href=""family-packages.html"">City <br> Brea</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-4 col-lg-3"">
                <div class=""blurBox col3 wow fadeIn"" data-wow-delay=""0.8s"">
                    <div class=""insiderBox"">
                        <a>
                            <picture>
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/c8.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Travel"">
                            </picture>
                        </a>
                        <div class=""insiderContent noneSubMenu"">
                            <!-- Eğer alt menu yoksa noneSubMenu class'ı ekle -->
                            <a class=""visibleText");
            WriteLiteral(@""" href=""family-packages.html"">Special <br> Interest</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""parallaxBox lazyload"" style=""background: url(assets/img/middleBox.jpg)"" data-link=""assets/css/parallaxModule.css"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""parallax"">
                    <h3>
                        Exclusive <br> Vip Experiences
                    </h3>
                    <p>
                        Luxury Istanbul is the premier address in Turkey for exclusive travel services; combining comfort and authenticity in the Turkey's  as being specialists in luxury tailor-made holidays; it is perfect . <br><br>
                        This is where you will find high quality, exclusively private and personalized travel options to fulfill your individual or  corporate travel requirements for your ho");
            WriteLiteral(@"liday in Turkey.

                    </p>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""testimonials lazyload"" data-link=""assets/css/commentModule.css"" data-script=""assets/js/commentModule.js"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col"">
                <div class=""commentSlider"">
                    <div class=""item"">
                        <div class=""itemContent"">
                            <img src=""assets/img/quote.png"">
                            <p>
                                There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum.
                            </p>
                            <span>
                                Sylvain Schuler <strong>Marketing Director of DIAC, Groupe DIAC");
            WriteLiteral(@"</strong>
                            </span>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""itemContent"">
                            <img src=""assets/img/quote.png"">
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
                            <img src=""assets/img/quote.png"">
                  ");
            WriteLiteral(@"          <p>
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
                        <img src=""assets/img/litlePrev.png"" alt="""">
                    </button>
                    <button type=""button"" class=""litleNext"">
                        <img src=""assets/img/litleNext.png"" alt="""">
                    </button>
                </div>
            </div>
        </div>
");
            WriteLiteral(@"    </div>
</section>

<section class=""recommended"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""discoveredBox"">
                    <div class=""recommendedBlackBox"">
                        <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/recoBox.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
                        <div class=""psAbslt"">
                            <h2 class=""colorableText"">Recommended By <span>Luxury Istanbul</span></h2>
                            <a href=""javascript:;"" class=""gradientBtn"">
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/discoverNow.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
                            </a>
                        </div>
                    </div>
                </div>
            </div");
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoriesDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
