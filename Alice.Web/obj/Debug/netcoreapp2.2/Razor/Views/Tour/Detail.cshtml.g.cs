#pragma checksum "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae7c4e689e9dea03ece47021bcfdadc5dc43348c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour_Detail), @"mvc.1.0.view", @"/Views/Tour/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tour/Detail.cshtml", typeof(AspNetCore.Views_Tour_Detail))]
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
#line 1 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
using Alice.Service.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae7c4e689e9dea03ece47021bcfdadc5dc43348c", @"/Views/Tour/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e93ce5880de5b382b5c3edaf77636ae93e9007", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Tour/MessagePost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("post", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
  
    ViewData["Title"] = Model.TourName;
    ViewData["SEODesctiption"] = Model.TourName;
    Layout = "~/Views/Shared/_Layout.cshtml";
    var category = (List<Alice.Service.Model.TourCategoriesDTO>)ViewBag.Category;

#line default
#line hidden
            BeginContext(274, 60, true);
            WriteLiteral("<section class=\"mansetNoneSlide\">\r\n    <div class=\"littleBg\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 334, "\"", 381, 4);
            WriteAttributeValue("", 342, "background:", 342, 11, true);
            WriteAttributeValue(" ", 353, "url(", 354, 5, true);
#line 11 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
WriteAttributeValue("", 358, Model.TourSliderImage, 358, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 380, ")", 380, 1, true);
            EndWriteAttribute();
            BeginContext(382, 1715, true);
            WriteLiteral(@">
        <div class=""topSocialMedia"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <ul>
                            <li class=""wow fadeIn"" data-wow-duration=""0.3s"" data-wow-delay=""0.3s"">
                                <a href=""javascript:;"">
                                    <i class=""fab fa-instagram""></i>
                                </a>
                            </li>
                            <li class=""wow fadeIn"" data-wow-duration=""0.3s"" data-wow-delay=""0.6s"">
                                <a href=""javascript:;"">
                                    <i class=""fab fa-youtube""></i>
                                </a>
                            </li>
                            <li class=""wow fadeIn"" data-wow-duration=""0.3s"" data-wow-delay=""0.9s"">
                                <a href=""javascript:;"">
                                    <i class=""fab fa-facebook-f""></i>
             ");
            WriteLiteral(@"                   </a>
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
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""littleManset"">
                        <h3>
                            <span>");
            EndContext();
            BeginContext(2098, 14, false);
#line 47 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                             Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(2112, 213, true);
            WriteLiteral("</span>\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"featureList\">\r\n                        <ul>\r\n                            <li>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2325, "\"", 2357, 1);
#line 53 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
WriteAttributeValue("", 2332, $"{ViewBag.urlPrefix}", 2332, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2358, 272, true);
            WriteLiteral(@" class=""active"">
                                    <i class=""flaticon-info""></i>
                                    Overview
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2630, "\"", 2671, 2);
#line 59 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
WriteAttributeValue("", 2637, $"{ViewBag.urlPrefix}", 2637, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 2662, "tour-plan", 2662, 9, true);
            EndWriteAttribute();
            BeginContext(2672, 259, true);
            WriteLiteral(@">
                                    <i class=""flaticon-map-1""></i>
                                    Tour Plan
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2931, "\"", 2971, 2);
#line 65 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
WriteAttributeValue("", 2938, $"{ViewBag.urlPrefix}", 2938, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 2963, "tour-map", 2963, 8, true);
            EndWriteAttribute();
            BeginContext(2972, 256, true);
            WriteLiteral(@">
                                    <i class=""flaticon-map""></i>
                                    Tour Map
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3228, "\"", 3265, 2);
#line 71 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
WriteAttributeValue("", 3235, $"{ViewBag.urlPrefix}", 3235, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3260, "hotel", 3260, 5, true);
            EndWriteAttribute();
            BeginContext(3266, 256, true);
            WriteLiteral(@">
                                    <i class=""flaticon-urban""></i>
                                    Hotels
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3522, "\"", 3564, 2);
#line 77 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
WriteAttributeValue("", 3529, $"{ViewBag.urlPrefix}", 3529, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3554, "conditions", 3554, 10, true);
            EndWriteAttribute();
            BeginContext(3565, 261, true);
            WriteLiteral(@">
                                    <i class=""flaticon-accept""></i>
                                    Conditions
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3826, "\"", 3865, 2);
#line 83 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
WriteAttributeValue("", 3833, $"{ViewBag.urlPrefix}", 3833, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3858, "gallery", 3858, 7, true);
            EndWriteAttribute();
            BeginContext(3866, 781, true);
            WriteLiteral(@">
                                    <i class=""flaticon-art""></i>
                                    Gallery
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""tabSects"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""avaiBox"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb withMarginSpace"">
                            <!-- burda class eklendi farklı olarak withMarginSpace -->
                            <li class=""breadcrumb-item active""><a href=""/"">HOME</a></li>
");
            EndContext();
            BeginContext(4927, 77, true);
            WriteLiteral("                            <li class=\"breadcrumb-item \" aria-current=\"page\">");
            EndContext();
            BeginContext(5005, 14, false);
#line 107 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                                                        Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(5019, 462, true);
            WriteLiteral(@"</li>
                        </ol>
                    </nav>
                    <div class=""contentDetail"">
                        <div class=""contentLeft"">
                            <div class=""col-12 col-md-12 col-lg-8"">
                                <div class=""boldContextText containerText"">
                                    <!-- burda class eklendi farklı olarak containerText -->
                                    <h3 class=""bigText"">");
            EndContext();
            BeginContext(5482, 14, false);
#line 115 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                                   Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(5496, 158, true);
            WriteLiteral("</h3>\r\n                                </div>\r\n                                <div class=\"downTitle\">\r\n                                    Tour Code : <span>");
            EndContext();
            BeginContext(5655, 14, false);
#line 118 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                                 Write(Model.TourCode);

#line default
#line hidden
            EndContext();
            BeginContext(5669, 109, true);
            WriteLiteral("</span>\r\n                                    <br>\r\n                                    Tour Activity : <span>");
            EndContext();
            BeginContext(5779, 18, false);
#line 120 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                                     Write(Model.TourActivity);

#line default
#line hidden
            EndContext();
            BeginContext(5797, 234, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                                <p class=\"marginBt-60\">\r\n                                    <!-- burda class eklendi farklı olarak marginBt-60 -->\r\n                                    ");
            EndContext();
            BeginContext(6032, 24, false);
#line 124 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                               Write(Html.Raw(Model.TourBody));

#line default
#line hidden
            EndContext();
            BeginContext(6056, 98, true);
            WriteLiteral("\r\n                                </p>\r\n                                <div class=\"daysDetail\">\r\n");
            EndContext();
#line 127 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                     foreach (var item in ((List<Alice.Service.Model.TourPlanListDTO>)ViewBag.TourDays))
                                    {

#line default
#line hidden
            BeginContext(6315, 50, true);
            WriteLiteral("                                        <p><i>Day ");
            EndContext();
            BeginContext(6366, 8, false);
#line 129 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                             Write(item.Day);

#line default
#line hidden
            EndContext();
            BeginContext(6374, 12, true);
            WriteLiteral(" :</i><span>");
            EndContext();
            BeginContext(6387, 13, false);
#line 129 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                                                  Write(item.DayTitle);

#line default
#line hidden
            EndContext();
            BeginContext(6400, 6, true);
            WriteLiteral(" <em> ");
            EndContext();
            BeginContext(6407, 14, false);
#line 129 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                                                                      Write(item.DayDetail);

#line default
#line hidden
            EndContext();
            BeginContext(6421, 19, true);
            WriteLiteral("</em></span> </p>\r\n");
            EndContext();
#line 130 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                    }

#line default
#line hidden
            BeginContext(6479, 3712, true);
            WriteLiteral(@"                                </div>
                                <div class=""daysWeather"">
                                    <h3>
                                        Best Time to Visit
                                    </h3>
                                    <div class=""degreeItem"">
                                        <ul class=""degree"">
                                            <li class=""redBorder"">
                                                Jan °C 5.8
                                            </li>
                                            <li class=""redBorder"">
                                                Feb °C 5.8
                                            </li>
                                            <li class=""lowBorder"">
                                                Mar °C 7.3
                                            </li>
                                            <li class=""mediumBorder"">
                                                A");
            WriteLiteral(@"pr °C 11,2
                                            </li>
                                            <li class=""highBorder"">
                                                May °C 5.8
                                            </li>
                                            <li class=""highBorder"">
                                                Jun °C 5.8
                                            </li>
                                            <li class=""highBorder"">
                                                Jul °C 5.8
                                            </li>
                                            <li class=""highBorder"">
                                                Aug °C 5.8
                                            </li>
                                            <li class=""highBorder"">
                                                Sep °C 5.8
                                            </li>
                                            <li class=""medium");
            WriteLiteral(@"Border"">
                                                Oct °C 11,2
                                            </li>
                                            <li class=""lowBorder"">
                                                Nov °C 11.0
                                            </li>
                                            <li class=""redBorder"">
                                                Dec °C 5.8
                                            </li>
                                        </ul>
                                        <ul class=""colorBox"">
                                            <li class=""red"">
                                                Lower
                                            </li>
                                            <li class=""pink"">
                                                Low
                                            </li>
                                            <li class=""highGreen"">
                              ");
            WriteLiteral(@"                  Medium
                                            </li>
                                            <li class=""yellow"">
                                                High
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-12 col-md-12 col-lg-4"">
                                <div class=""fixedFormBox"">
                                    <h6>Book This Tour</h6>
                                    ");
            EndContext();
            BeginContext(10191, 3220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae7c4e689e9dea03ece47021bcfdadc5dc43348c21099", async() => {
                BeginContext(10246, 2839, true);
                WriteLiteral(@"
                                        <div class=""form-div"">
                                            <input type=""text"" class=""form-control"" name=""Name"" placeholder=""Your Name"">
                                        </div>
                                        <div class=""form-div"">
                                            <input type=""text"" class=""form-control"" name=""Phone"" placeholder=""Phone Number"">
                                        </div>
                                        <div class=""form-div"">
                                            <input type=""mail"" class=""form-control"" name=""Email"" placeholder=""Email Address"">
                                        </div>
                                        <div class=""form-div"">
                                            <textarea id="""" class=""form-control"" name=""Notes"" placeholder=""Notes""></textarea>
                                        </div>
                                        <div class=""form-div form-flex"">");
                WriteLiteral(@"
                                            <div class=""input-group"">
                                                <label class=""input-group-btn"">
                                                    <span class=""btn download-btn"">
                                                        <i class=""flaticon-download""></i>
                                                        <input type=""file"" name=""ozgecmis"" style=""display: none;"" accept="".doc, .docx, .pdf"">
                                                    </span>
                                                </label>
                                                <input type=""text"" class=""form-control"" readonly="""">
                                            </div>
                                            <div class=""sendFried"">
                                                <a href=""javascript:;"">
                                                    <i class=""flaticon-send""></i>
                                                    <");
                WriteLiteral(@"span>Send to  friends</span>
                                                </a>
                                            </div>
                                            <div class=""sendBtn"">
                                                <input type=""submit"" class=""form-control"" value=""SEND"">
                                            </div>
                                        </div>
                                        <div class=""tailor"">
                                            <a href=""javascript:;"" data-toggle=""modal"" data-target=""#tailor"">
                                                <span>TAILOR MY TRIP </span><i class=""fas fa-caret-right""></i>
                                            </a>
                                        </div>
");
                EndContext();
                BeginContext(13368, 36, true);
                WriteLiteral("                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13411, 663, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""populerTours"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""leftTitle"">
                    <h3>
                        Most Popular  <br> <span>Similar Tours</span>
                    </h3>
                </div>
                <div class=""tours withAbsoloute"">
                    <div class=""tab-content"">
                        <ul>
");
            EndContext();
#line 260 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                             foreach (var item in ((List<Alice.Service.Model.TourDTO>)ViewBag.SimilarTours))
                            {

#line default
#line hidden
            BeginContext(14215, 372, true);
            WriteLiteral(@"                                <li class=""animated fadeIn"">
                                    <figure class=""borderBox"">
                                        <a href=""overview.html"">
                                            <span class=""wrap"">
                                                <picture>
                                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 14587, "\"", 14608, 1);
#line 267 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
WriteAttributeValue("", 14593, item.TourImage, 14593, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(14609, 11, true);
            WriteLiteral(" data-src=\"");
            EndContext();
            BeginContext(14621, 14, false);
#line 267 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                                                                    Write(item.TourImage);

#line default
#line hidden
            EndContext();
            BeginContext(14635, 289, true);
            WriteLiteral(@""" alt="""" />
                                                </picture>
                                            </span>
                                        </a>
                                        <figcaption class=""whiteBox"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 14924, "\"", 15038, 1);
#line 272 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
WriteAttributeValue("", 14931, $"{Alice.Web.Helper.ConstHelper.UrlFriendly(category?.FirstOrDefault()?.CategoriesName)}/{item.TourUrl}", 14931, 107, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(15039, 122, true);
            WriteLiteral(">\r\n                                                <b class=\"title\">\r\n                                                    ");
            EndContext();
            BeginContext(15162, 13, false);
#line 274 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                               Write(item.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(15175, 56, true);
            WriteLiteral("\r\n                                                </b>\r\n");
            EndContext();
            BeginContext(15299, 421, true);
            WriteLiteral(@"                                                <em>
                                                    DISCOVER  MORE <i class=""fa fa-caret-right"" aria-hidden=""true""></i>
                                                </em>
                                            </a>
                                        </figcaption>
                                    </figure>
                                </li>
");
            EndContext();
#line 284 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(15751, 143, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TourDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
