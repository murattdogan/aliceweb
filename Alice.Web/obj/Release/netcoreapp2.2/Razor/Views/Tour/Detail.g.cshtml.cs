#pragma checksum "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9802c993b79b518b59788d0ac14520480ae431f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9802c993b79b518b59788d0ac14520480ae431f", @"/Views/Tour/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e93ce5880de5b382b5c3edaf77636ae93e9007", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 68, true);
            WriteLiteral("    <section class=\"mansetNoneSlide\">\r\n        <div class=\"littleBg\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 203, "\"", 250, 4);
            WriteAttributeValue("", 211, "background:", 211, 11, true);
            WriteAttributeValue(" ", 222, "url(", 223, 5, true);
#line 9 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
WriteAttributeValue("", 227, Model.TourSliderImage, 227, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 249, ")", 249, 1, true);
            EndWriteAttribute();
            BeginContext(251, 5350, true);
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
                ");
            WriteLiteral(@"                        <i class=""fab fa-facebook-f""></i>
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
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""littleManset"">
                            <h3>
                                <span>A Italian</span> <br>
                                Family Adventure
                            </h3>
                        </div>
                        <div class=""featureList"">");
            WriteLiteral(@"
                            <ul>
                                <li>
                                    <a href=""overview.html"" class=""active"">
                                        <i class=""flaticon-info""></i>
                                        Overview
                                    </a>
                                </li>
                                <li>
                                    <a href=""tour-plan.html"">
                                        <i class=""flaticon-map-1""></i>
                                        Tour Plan
                                    </a>
                                </li>
                                <li>
                                    <a href=""tour-map.html"">
                                        <i class=""flaticon-map""></i>
                                        Tour Map
                                    </a>
                                </li>
                                <li>
                           ");
            WriteLiteral(@"         <a href=""hotels.html"">
                                        <i class=""flaticon-urban""></i>
                                        Hotels
                                    </a>
                                </li>
                                <li>
                                    <a href=""conditions.html"">
                                        <i class=""flaticon-accept""></i>
                                        Conditions
                                    </a>
                                </li>
                                <li>
                                    <a href=""gallery.html"">
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
<section cla");
            WriteLiteral(@"ss=""tabSects"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""avaiBox"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb withMarginSpace"">
                            <!-- burda class eklendi farklı olarak withMarginSpace -->
                            <li class=""breadcrumb-item active""><a href=""#"">HOME</a></li>
                            <li class=""breadcrumb-item""><a href=""#"">Travel</a></li>
                            <li class=""breadcrumb-item""><a href=""#"">Tour packages </a></li>
                            <li class=""breadcrumb-item "" aria-current=""page"">Family</li>
                            <li class=""breadcrumb-item "" aria-current=""page"">Overview</li>
                        </ol>
                    </nav>
                    <div class=""contentDetail"">
                        <div class=""contentLeft"">
                            <div class=""col-12 col-md-12 col-lg-8""");
            WriteLiteral(">\r\n                                <div class=\"boldContextText containerText\">\r\n                                    <!-- burda class eklendi farklı olarak containerText -->\r\n                                    <h3 class=\"bigText\">");
            EndContext();
            BeginContext(5602, 14, false);
#line 114 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                                   Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(5616, 158, true);
            WriteLiteral("</h3>\r\n                                </div>\r\n                                <div class=\"downTitle\">\r\n                                    Tour Code : <span>");
            EndContext();
            BeginContext(5775, 14, false);
#line 117 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                                 Write(Model.TourCode);

#line default
#line hidden
            EndContext();
            BeginContext(5789, 109, true);
            WriteLiteral("</span>\r\n                                    <br>\r\n                                    Tour Activity : <span>");
            EndContext();
            BeginContext(5899, 18, false);
#line 119 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                                                     Write(Model.TourActivity);

#line default
#line hidden
            EndContext();
            BeginContext(5917, 234, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                                <p class=\"marginBt-60\">\r\n                                    <!-- burda class eklendi farklı olarak marginBt-60 -->\r\n                                    ");
            EndContext();
            BeginContext(6152, 14, false);
#line 123 "E:\alice\Alice\Alice.Web\Views\Tour\Detail.cshtml"
                               Write(Model.TourSpot);

#line default
#line hidden
            EndContext();
            BeginContext(6166, 4465, true);
            WriteLiteral(@"
                                </p>
                                <div class=""daysDetail"">
                                    <p><i>Day 1:</i><span>Lorem Ipsum <em> is simply dummy text of the printing and typesetting industry.</em></span> </p>

                                    <p><i>Day 2:</i><span>Departure<em> is simply dummy  and typesetting industry.</em></span>  </p>

                                    <p><i>Day 3:</i><span>Departure Time <em> is simply dummy text of the printing and typesetting industry.</em> </span> </p>

                                    <p><i>Day 4:</i><span>Return Time</span></p>

                                    <p><i>Day 5:</i><span>Included <em> Not is simply dummy text</em></span> </p>
                                </div>
                                <div class=""daysWeather"">
                                    <h3>
                                        Best Time to Visit
                                    </h3>
                           ");
            WriteLiteral(@"         <div class=""degreeItem"">
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
                                                Apr °C 11,2
                                            </li>
                                            <li class=""highBorder"">
                                                May °C 5.8
                                            </li>
                            ");
            WriteLiteral(@"                <li class=""highBorder"">
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
                                            <li class=""mediumBorder"">
                                                Oct °C 11,2
                                            </li>
                                            <li class=""lowBorder"">
                                                Nov °C 11.0
                    ");
            WriteLiteral(@"                        </li>
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
                                                Medium
                                            </li>
                                            <li class=""yellow"">
                                                High
                                            </li>
                        ");
            WriteLiteral(@"                </ul>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-12 col-md-12 col-lg-4"">
                                <div class=""fixedFormBox"">
                                    <h6>Book This Tour</h6>
                                    ");
            EndContext();
            BeginContext(10631, 2873, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9802c993b79b518b59788d0ac14520480ae431f17416", async() => {
                BeginContext(10665, 2832, true);
                WriteLiteral(@"
                                        <div class=""form-div"">
                                            <input type=""text"" class=""form-control"" placeholder=""Your Name"">
                                        </div>
                                        <div class=""form-div"">
                                            <input type=""text"" class=""form-control"" placeholder=""Phone Number"">
                                        </div>
                                        <div class=""form-div"">
                                            <input type=""mail"" class=""form-control"" placeholder=""Email Address"">
                                        </div>
                                        <div class=""form-div"">
                                            <textarea name="""" id="""" class=""form-control"" placeholder=""Notes""></textarea>
                                        </div>
                                        <div class=""form-div form-flex"">
                                         ");
                WriteLiteral(@"   <div class=""input-group"">
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
                                                    <span>Send to  friends</span>
             ");
                WriteLiteral(@"                                   </a>
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
            BeginContext(13504, 10170, true);
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
                        Most Popular  <br> <span>Family Tours</span>
                    </h3>
                </div>
                <div class=""tours withAbsoloute"">
                    <div class=""tab-content"">
                        <ul>
                            <li class=""animated fadeIn"">
                                <figure class=""borderBox"">
                                    <a href=""overview.html"">
                                        <span class=""wrap"">
                                            <picture>
                                                <img src=""data:ima");
            WriteLiteral(@"ge/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/t1.jpg"" data-loadMode=""0"" class=""lazyload"" alt="""" />
                                            </picture>
                                        </span>
                                    </a>
                                    <figcaption class=""whiteBox"">
                                        <a href=""overview.html"">
                                            <b class=""title"">
                                                New Zeland
                                            </b>
                                            <i>$ 3,268</i>
                                            <em>
                                                DISCOVER  MORE <i class=""fa fa-caret-right"" aria-hidden=""true""></i>
                                            </em>
                                        </a>
                                    </figcaption>
                                </figure>
          ");
            WriteLiteral(@"                  </li>
                            <li class=""animated fadeIn"">
                                <figure class=""borderBox"">
                                    <a href=""overview.html"">
                                        <span class=""wrap"">
                                            <picture>
                                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/t2.jpg"" data-loadMode=""0"" class=""lazyload"" alt="""" />
                                            </picture>
                                            <strong class=""overrideText"">
                                                <em>
                                                    Last Offer
                                                </em>
                                            </strong>
                                        </span>
                                    </a>
                                    <figcapt");
            WriteLiteral(@"ion class=""whiteBox"">
                                        <a href=""overview.html"">
                                            <b class=""title"">
                                                Thailand
                                            </b>
                                            <i>$ 3,268</i>
                                            <em>
                                                DISCOVER  MORE <i class=""fa fa-caret-right"" aria-hidden=""true""></i>
                                            </em>
                                        </a>
                                    </figcaption>
                                </figure>
                            </li>
                            <li class=""animated fadeIn"">
                                <figure class=""borderBox"">
                                    <a href=""overview.html"">
                                        <span class=""wrap"">
                                            <picture>
               ");
            WriteLiteral(@"                                 <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/t3.jpg"" data-loadMode=""0"" class=""lazyload"" alt="""" />
                                            </picture>
                                        </span>
                                    </a>
                                    <figcaption class=""whiteBox"">
                                        <a href=""overview.html"">
                                            <b class=""title"">
                                                Shangai
                                            </b>
                                            <i>$ 3,268</i>
                                            <em>
                                                DISCOVER  MORE <i class=""fa fa-caret-right"" aria-hidden=""true""></i>
                                            </em>
                                        </a>
                                    </figcaption>
     ");
            WriteLiteral(@"                           </figure>
                            </li>
                            <li class=""animated fadeIn"">
                                <figure class=""borderBox"">
                                    <a href=""overview.html"">
                                        <span class=""wrap"">
                                            <picture>
                                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/t4.jpg"" data-loadMode=""0"" class=""lazyload"" alt="""" />
                                            </picture>
                                            <strong class=""overrideText"">
                                                <em>
                                                    Last Offer
                                                </em>
                                            </strong>
                                        </span>
                                    </");
            WriteLiteral(@"a>
                                    <figcaption class=""whiteBox"">
                                        <a href=""overview.html"">
                                            <b class=""title"">
                                                Costa Rica
                                            </b>
                                            <i>$ 3,268</i>
                                            <em>
                                                DISCOVER  MORE <i class=""fa fa-caret-right"" aria-hidden=""true""></i>
                                            </em>
                                        </a>
                                    </figcaption>
                                </figure>
                            </li>
                            <li class=""animated fadeIn"">
                                <figure class=""borderBox"">
                                    <a href=""overview.html"">
                                        <span class=""wrap"">
                    ");
            WriteLiteral(@"                        <picture>
                                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/t3.jpg"" data-loadMode=""0"" class=""lazyload"" alt="""" />
                                            </picture>
                                            <strong class=""overrideText"">
                                                <em>
                                                    Last Offer
                                                </em>
                                            </strong>
                                        </span>
                                    </a>
                                    <figcaption class=""whiteBox"">
                                        <a href=""overview.html"">
                                            <b class=""title"">
                                                India
                                            </b>
                             ");
            WriteLiteral(@"               <i>$ 3,268</i>
                                            <em>
                                                DISCOVER  MORE <i class=""fa fa-caret-right"" aria-hidden=""true""></i>
                                            </em>
                                        </a>
                                    </figcaption>
                                </figure>
                            </li>
                            <li class=""animated fadeIn"">
                                <figure class=""borderBox"">
                                    <a href=""overview.html"">
                                        <span class=""wrap"">
                                            <picture>
                                                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""assets/img/t5.jpg"" data-loadMode=""0"" class=""lazyload"" alt="""" />
                                            </picture>
                                       ");
            WriteLiteral(@" </span>
                                    </a>
                                    <figcaption class=""whiteBox"">
                                        <a href=""overview.html"">
                                            <b class=""title"">
                                                South Africa
                                            </b>
                                            <i>$ 3,268</i>
                                            <em>
                                                DISCOVER  MORE <i class=""fa fa-caret-right"" aria-hidden=""true""></i>
                                            </em>
                                        </a>
                                    </figcaption>
                                </figure>
                            </li>
                        </ul>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TourDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
