#pragma checksum "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a16c000118632284a13c9a4f56ec000aca036227"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a16c000118632284a13c9a4f56ec000aca036227", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e93ce5880de5b382b5c3edaf77636ae93e9007", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
  
    var homeModel = (Alice.Web.Models.LayoutModel)ViewBag.HomePage;
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

    //Alice.Service.Helper.SliderHelper imageget = new Alice.Service.Helper.SliderHelper();

#line default
#line hidden
            BeginContext(252, 84, true);
            WriteLiteral("\r\n<section class=\"manset\">\r\n    <div class=\"mansetSlide\">\r\n        <div class=\"item\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 336, "\"", 409, 3);
            WriteAttributeValue("", 344, "background:url(\'", 344, 16, true);
#line 11 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 360, homeModel.SliderFirstImage.Replace("\\",@"/"), 360, 48, false);

#line default
#line hidden
            WriteAttributeValue("", 408, "\'", 408, 1, true);
            EndWriteAttribute();
            BeginContext(410, 217, true);
            WriteLiteral(">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"slideHeading animated fadeInLeft\">\r\n                            ");
            EndContext();
            BeginContext(628, 26, false);
#line 16 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                       Write(homeModel.SliderFirstTitle);

#line default
#line hidden
            EndContext();
            BeginContext(654, 88, true);
            WriteLiteral("\r\n                            <div class=\"btnTable\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 742, "\"", 781, 1);
#line 18 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 749, homeModel.SliderFirstButtonLink, 749, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(782, 56, true);
            WriteLiteral(" class=\"whiteBtn\">\r\n                                    ");
            EndContext();
            BeginContext(839, 32, false);
#line 19 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                               Write(homeModel.SliderFirstButtonTitle);

#line default
#line hidden
            EndContext();
            BeginContext(871, 269, true);
            WriteLiteral(@" <img src=""/Content/img/littleArrow.png"" alt="""">
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""item""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1140, "\"", 1213, 3);
            WriteAttributeValue("", 1148, "background:", 1148, 11, true);
            WriteAttributeValue(" ", 1159, "url(", 1160, 5, true);
#line 27 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1164, homeModel.SliderSecondImage.Replace("\\",@"/"), 1164, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1214, 217, true);
            WriteLiteral(">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"slideHeading animated fadeInLeft\">\r\n                            ");
            EndContext();
            BeginContext(1432, 27, false);
#line 32 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                       Write(homeModel.SliderSecondTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1459, 88, true);
            WriteLiteral("\r\n                            <div class=\"btnTable\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1547, "\"", 1587, 1);
#line 34 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1554, homeModel.SliderSecondButtonLink, 1554, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1588, 56, true);
            WriteLiteral(" class=\"whiteBtn\">\r\n                                    ");
            EndContext();
            BeginContext(1645, 33, false);
#line 35 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                               Write(homeModel.SliderSecondButtonTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 269, true);
            WriteLiteral(@" <img src=""/Content/img/littleArrow.png"" alt="""">
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""item""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1947, "\"", 2019, 3);
            WriteAttributeValue("", 1955, "background:", 1955, 11, true);
            WriteAttributeValue(" ", 1966, "url(", 1967, 5, true);
#line 43 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1971, homeModel.SliderThirdImage.Replace("\\",@"/"), 1971, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2020, 217, true);
            WriteLiteral(">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"slideHeading animated fadeInLeft\">\r\n                            ");
            EndContext();
            BeginContext(2238, 26, false);
#line 48 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                       Write(homeModel.SliderThirdTitle);

#line default
#line hidden
            EndContext();
            BeginContext(2264, 88, true);
            WriteLiteral("\r\n                            <div class=\"btnTable\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2352, "\"", 2391, 1);
#line 50 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2359, homeModel.SliderThirdButtonLink, 2359, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2392, 56, true);
            WriteLiteral(" class=\"whiteBtn\">\r\n                                    ");
            EndContext();
            BeginContext(2449, 32, false);
#line 51 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                               Write(homeModel.SliderThirdButtonTitle);

#line default
#line hidden
            EndContext();
            BeginContext(2481, 269, true);
            WriteLiteral(@" <img src=""/Content/img/littleArrow.png"" alt="""">
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""item""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2750, "\"", 2822, 3);
            WriteAttributeValue("", 2758, "background:", 2758, 11, true);
            WriteAttributeValue(" ", 2769, "url(", 2770, 5, true);
#line 59 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2774, homeModel.SliderForthImage.Replace("\\",@"/"), 2774, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2823, 217, true);
            WriteLiteral(">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"slideHeading animated fadeInLeft\">\r\n                            ");
            EndContext();
            BeginContext(3041, 26, false);
#line 64 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                       Write(homeModel.SliderForthTitle);

#line default
#line hidden
            EndContext();
            BeginContext(3067, 88, true);
            WriteLiteral("\r\n                            <div class=\"btnTable\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3155, "\"", 3194, 1);
#line 66 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3162, homeModel.SliderForthButtonLink, 3162, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3195, 56, true);
            WriteLiteral(" class=\"whiteBtn\">\r\n                                    ");
            EndContext();
            BeginContext(3252, 32, false);
#line 67 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                               Write(homeModel.SliderForthButtonTitle);

#line default
#line hidden
            EndContext();
            BeginContext(3284, 1974, true);
            WriteLiteral(@" <img src=""/Content/img/littleArrow.png"" alt="""">
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""slider-controls"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""whiteNavigation"">
                        <div class=""slideNumbers"">
                            <div class=""item""><strong class=""active"">01</strong> <span class=""totalSlide"">04</span> </div> <!-- Total Slide yukarıdaki slide item kaç taneyse o kadar olacak -->
                            <div class=""item""><strong class=""active"">02</strong> <span class=""totalSlide"">04</span> </div>
                            <div class=""item""><strong class=""active"">03</strong> <span class=""totalSlide"">04</span> </div>
                            <div class=""item""><strong class=""active"">04</strong> <span");
            WriteLiteral(@" class=""totalSlide"">04</span> </div>
                        </div>
                        <div class=""slide-m-dots""></div>
                        <div class=""slideArrows"">
                            <button type=""button"" class=""slide-m-prev"">
                                <img src=""/Content/img/left.png"" alt="""">
                            </button>
                            <button type=""button"" class=""slide-m-next"">
                                <img src=""/Content/img/right.png"" alt="""">
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ourLine"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""line d-flex align-items-start"">
                    <span class=""wow slideInLeft"">
                        ");
            EndContext();
            BeginContext(5259, 19, false);
#line 108 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                   Write(homeModel.texttitle);

#line default
#line hidden
            EndContext();
            BeginContext(5278, 105, true);
            WriteLiteral("\r\n                    </span>\r\n                    <p class=\"wow slideInRight\">\r\n                        ");
            EndContext();
            BeginContext(5384, 35, false);
#line 111 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                   Write(Html.Raw(homeModel.textdescription));

#line default
#line hidden
            EndContext();
            BeginContext(5419, 447, true);
            WriteLiteral(@"
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""events compatible"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 col-md-4 col-lg-4"">
                <div class=""blurBox col4 wow fadeIn"" data-wow-delay=""0.1s"">
                    <a href=""category.html"">
                        <picture>
                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5866, "\"", 5903, 1);
#line 125 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 5872, homeModel.HomeCategoryImageOne, 5872, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5904, 11, true);
            WriteLiteral(" data-src=\"");
            EndContext();
            BeginContext(5916, 30, false);
#line 125 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                                                                            Write(homeModel.HomeCategoryImageOne);

#line default
#line hidden
            EndContext();
            BeginContext(5946, 122, true);
            WriteLiteral("\" data-loadMode=\"0\"  alt=\"Travel\">\r\n                        </picture>\r\n                        <span class=\"visibleText\">");
            EndContext();
            BeginContext(6069, 35, false);
#line 127 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                                             Write(homeModel.HomeCategoryImageOneTitle);

#line default
#line hidden
            EndContext();
            BeginContext(6104, 61, true);
            WriteLiteral("</span>\r\n                        <i class=\"middleText\"><span>");
            EndContext();
            BeginContext(6166, 35, false);
#line 128 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                                               Write(homeModel.HomeCategoryImageOneTitle);

#line default
#line hidden
            EndContext();
            BeginContext(6201, 325, true);
            WriteLiteral(@"</span></i>
                    </a>
                </div>
            </div>
            <div class=""col-12 col-md-4 col-lg-4"">
                <div class=""blurBox col4 wow fadeIn"" data-wow-delay=""0.2s"">
                    <a href=""category.html"">
                        <picture>
                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6526, "\"", 6563, 1);
#line 136 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 6532, homeModel.HomeCategoryImageTwo, 6532, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6564, 11, true);
            WriteLiteral(" data-src=\"");
            EndContext();
            BeginContext(6576, 30, false);
#line 136 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                                                                            Write(homeModel.HomeCategoryImageTwo);

#line default
#line hidden
            EndContext();
            BeginContext(6606, 518, true);
            WriteLiteral(@""" data-loadMode=""0""  alt=""Travel"">
                        </picture>
                        <span class=""visibleText"">Event</span>
                        <i class=""middleText""><span>Event</span></i>
                    </a>
                </div>
            </div>
            <div class=""col-12 col-md-4 col-lg-4"">
                <div class=""blurBox col4 wow fadeIn"" data-wow-delay=""0.3s"">
                    <a href=""category.html"">
                        <picture>
                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 7124, "\"", 7163, 1);
#line 147 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 7130, homeModel.HomeCategoryImageThree, 7130, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7164, 11, true);
            WriteLiteral(" data-src=\"");
            EndContext();
            BeginContext(7176, 32, false);
#line 147 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                                                                              Write(homeModel.HomeCategoryImageThree);

#line default
#line hidden
            EndContext();
            BeginContext(7208, 572, true);
            WriteLiteral(@""" data-loadMode=""0"" alt=""Travel"">
                        </picture>
                        <span class=""visibleText"">Wedding</span>
                        <i class=""middleText""><span>Wedding</span></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 col-md-4 col-lg-4"">
                <div class=""blurBox col4Vertical wow fadeIn"" data-wow-delay=""0.4s"">
                    <a href=""category.html"">
                        <picture>
                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 7780, "\"", 7818, 1);
#line 160 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 7786, homeModel.HomeCategoryImageFour, 7786, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7819, 11, true);
            WriteLiteral(" data-src=\"");
            EndContext();
            BeginContext(7831, 31, false);
#line 160 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                                                                             Write(homeModel.HomeCategoryImageFour);

#line default
#line hidden
            EndContext();
            BeginContext(7862, 582, true);
            WriteLiteral(@""" data-loadMode=""0"" alt=""Travel"">
                        </picture>
                        <span class=""visibleText"">Real Estate</span>
                        <i class=""middleText""><span>Real Estate</span></i>
                    </a>
                </div>
            </div>
            <div class=""col-12 col-md-8 col-lg-8"">
                <div class=""w-100"">
                    <div class=""blurBox col8 wow fadeIn"" data-wow-delay=""0.5s"">
                        <a href=""category.html"">
                            <picture>
                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 8444, "\"", 8482, 1);
#line 172 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8450, homeModel.HomeCategoryImageFive, 8450, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8483, 11, true);
            WriteLiteral(" data-src=\"");
            EndContext();
            BeginContext(8495, 31, false);
#line 172 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                                                                                 Write(homeModel.HomeCategoryImageFive);

#line default
#line hidden
            EndContext();
            BeginContext(8526, 561, true);
            WriteLiteral(@""" data-loadMode=""0"" alt=""Travel"">
                            </picture>
                            <span class=""visibleText"">Signature Gifts</span>
                            <i class=""middleText""><span>Signature Gifts</span></i>
                        </a>
                    </div>
                </div>
                <div class=""w-50"">
                    <div class=""blurBox col4 wow fadeIn"" data-wow-delay=""0.6s"">
                        <a href=""category.html"">
                            <picture>
                                <img");
            EndContext();
            BeginWriteAttribute("src", "  src=\"", 9087, "\"", 9125, 1);
#line 183 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 9094, homeModel.HomeCategoryImageSix, 9094, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9126, 11, true);
            WriteLiteral(" data-src=\"");
            EndContext();
            BeginContext(9138, 30, false);
#line 183 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                                                                                 Write(homeModel.HomeCategoryImageSix);

#line default
#line hidden
            EndContext();
            BeginContext(9168, 573, true);
            WriteLiteral(@""" data-loadMode=""0"" alt=""Travel"">
                            </picture>
                            <span class=""visibleText"">Lifestyle & Concierge</span>
                            <i class=""middleText""><span>Lifestyle & Concierge</span></i>
                        </a>
                    </div>
                </div>
                <div class=""w-50"">
                    <div class=""blurBox col4 wow fadeIn"" data-wow-delay=""0.7s"">
                        <a href=""category.html"">
                            <picture>
                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 9741, "\"", 9780, 1);
#line 194 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 9747, homeModel.HomeCategoryImageSeven, 9747, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9781, 11, true);
            WriteLiteral(" data-src=\"");
            EndContext();
            BeginContext(9793, 32, false);
#line 194 "E:\alice\Alice\Alice.Web\Views\Home\Index.cshtml"
                                                                                  Write(homeModel.HomeCategoryImageSeven);

#line default
#line hidden
            EndContext();
            BeginContext(9825, 5729, true);
            WriteLiteral(@""" data-loadMode=""0"" alt=""Travel"">
                            </picture>
                            <span class=""visibleText"">Business Consultanct</span>
                            <i class=""middleText""><span>Business Consultanct</span></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""premiumOptions"" style=""background:url(/Content/img/optionBg.jpg)"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col"">
                <div class=""optionItems"">
                    <ul>
                        <li>
                            <a href=""javascript:;"" class=""wow slideInLeft"">
                                Premium
                                <span>Wedding</span> <i class=""flaticon-next""></i>
                            </a>
                        </li>
                        <li>
                            <a href=""javascript:;"" class=""wow fadeIn");
            WriteLiteral(@""">
                                Premium
                                <span>Yatchs</span> <i class=""flaticon-next""></i>
                            </a>
                        </li>
                        <li>
                            <a href=""javascript:;"" class=""wow slideInRight"">
                                Premium
                                <span>Chauffeur</span> <i class=""flaticon-next""></i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""brandArea"">
    <div class=""brands lazyload"" data-script=""~/Content/js/brandSlider.js "">
        <div class=""brandNav"">
            <button type=""button"" class=""litlePrev"">
                <img src=""/Content/img/litlePrev.png"" alt="""">
            </button>
        </div>
        <div class=""brandSlider"">
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQ");
            WriteLiteral(@"ABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/b1.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
            </div>
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/b2.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
            </div>
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/b3.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
            </div>
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/b4.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
            </div>
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data");
            WriteLiteral(@"-src=""/Content/img/b5.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
            </div>
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/b6.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
            </div>
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/b7.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
            </div>
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/b8.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
            </div>
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/b9.png"" data-loadMode=""0"" cla");
            WriteLiteral(@"ss=""lazyload"" alt=""Luxury İstanbul"">
            </div>
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/b10.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
            </div>
            <div class=""item"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/b11.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
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
                        <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/recoBox.jpg"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
        ");
            WriteLiteral(@"                <div class=""psAbslt"">
                            <h2 class=""colorableText"">Recommended By <span>Luxury Istanbul</span></h2>
                            <a href=""javascript:;"" class=""gradientBtn"">
                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""/Content/img/discoverNow.png"" data-loadMode=""0"" class=""lazyload"" alt=""Luxury İstanbul"">
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
