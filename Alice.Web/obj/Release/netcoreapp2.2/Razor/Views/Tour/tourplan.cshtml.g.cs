#pragma checksum "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0e25aa2e73b99f6a84b9bcba68b45855fffac45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour_tourplan), @"mvc.1.0.view", @"/Views/Tour/tourplan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tour/tourplan.cshtml", typeof(AspNetCore.Views_Tour_tourplan))]
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
#line 1 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
using Alice.Service.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0e25aa2e73b99f6a84b9bcba68b45855fffac45", @"/Views/Tour/tourplan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e93ce5880de5b382b5c3edaf77636ae93e9007", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_tourplan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourDTO>
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
#line 3 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
  
    ViewData["Title"] = Model.TourName;
    ViewData["SEODesctiption"] = Model.TourName;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(189, 62, true);
            WriteLiteral("\r\n<section class=\"mansetNoneSlide\">\r\n    <div class=\"littleBg\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 251, "\"", 298, 4);
            WriteAttributeValue("", 259, "background:", 259, 11, true);
            WriteAttributeValue(" ", 270, "url(", 271, 5, true);
#line 10 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 275, Model.TourSliderImage, 275, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 297, ")", 297, 1, true);
            EndWriteAttribute();
            BeginContext(299, 1794, true);
            WriteLiteral(@">
        <div class=""topSocialMedia"">
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
            WriteLiteral(@"         <i class=""fab fa-facebook-f""></i>
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
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""littleManset"">
                        <h3>
                            <span>");
            EndContext();
            BeginContext(2094, 14, false);
#line 46 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                             Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(2108, 179, true);
            WriteLiteral("</span>\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"featureList\">\r\n                        <ul>\r\n                            <li>\r\n");
            EndContext();
#line 52 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                  
                                    var q = ViewBag.urlPrefix.Remove(ViewBag.urlPrefix.Length - 1);
                                

#line default
#line hidden
            BeginContext(2459, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2493, "\"", 2509, 1);
#line 55 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 2500, $"{q}", 2500, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2510, 257, true);
            WriteLiteral(@">
                                    <i class=""flaticon-info""></i>
                                    Overview
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2767, "\"", 2808, 2);
#line 61 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 2774, $"{ViewBag.urlPrefix}", 2774, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 2799, "tour-plan", 2799, 9, true);
            EndWriteAttribute();
            BeginContext(2809, 274, true);
            WriteLiteral(@" class=""active"">
                                    <i class=""flaticon-map-1""></i>
                                    Tour Plan
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3083, "\"", 3123, 2);
#line 67 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 3090, $"{ViewBag.urlPrefix}", 3090, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3115, "tour-map", 3115, 8, true);
            EndWriteAttribute();
            BeginContext(3124, 256, true);
            WriteLiteral(@">
                                    <i class=""flaticon-map""></i>
                                    Tour Map
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3380, "\"", 3417, 2);
#line 73 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 3387, $"{ViewBag.urlPrefix}", 3387, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3412, "hotel", 3412, 5, true);
            EndWriteAttribute();
            BeginContext(3418, 256, true);
            WriteLiteral(@">
                                    <i class=""flaticon-urban""></i>
                                    Hotels
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3674, "\"", 3716, 2);
#line 79 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 3681, $"{ViewBag.urlPrefix}", 3681, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3706, "conditions", 3706, 10, true);
            EndWriteAttribute();
            BeginContext(3717, 261, true);
            WriteLiteral(@">
                                    <i class=""flaticon-accept""></i>
                                    Conditions
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3978, "\"", 4017, 2);
#line 85 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 3985, $"{ViewBag.urlPrefix}", 3985, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 4010, "gallery", 4010, 7, true);
            EndWriteAttribute();
            BeginContext(4018, 783, true);
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
            BeginContext(5081, 77, true);
            WriteLiteral("                            <li class=\"breadcrumb-item \" aria-current=\"page\">");
            EndContext();
            BeginContext(5159, 14, false);
#line 110 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                                        Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(5173, 368, true);
            WriteLiteral(@"</li>
                        </ol>
                    </nav>
                    <div class=""contentDetail"">
                        <div class=""contentLeft"">
                            <div class=""col-12 col-md-12 col-lg-8"">
                                <div class=""boldContextText containerText"">
                                    <h3 class=""bigText"">");
            EndContext();
            BeginContext(5542, 14, false);
#line 117 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                   Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(5556, 51, true);
            WriteLiteral("</h3>\r\n                                </div>\r\n\r\n\r\n");
            EndContext();
#line 121 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                 if (Model.TourType == 0)
                                {

#line default
#line hidden
            BeginContext(5701, 81, true);
            WriteLiteral("                                    <div id=\"accordion\" class=\"difAccordColor\">\r\n");
            EndContext();
#line 124 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                          
                                            var countCollapse = 0;
                                            foreach (var item in ((List<Alice.Service.Model.TourPlanListDTO>)ViewBag.TourDays))
                                            {
                                                var oneClass = "headingOne" + countCollapse;
                                                var collapse = "collapse" + countCollapse;
                                                var firstclass = "";
                                                var firstclasscollapsed = " collapsed";
                                                var ariaexpanded = "false";
                                                if (countCollapse == 0)
                                                {
                                                    firstclass = " show";
                                                    firstclasscollapsed = "";
                                                    ariaexpanded = "true";
                                                }
                                                countCollapse++;

#line default
#line hidden
            BeginContext(6963, 144, true);
            WriteLiteral("                                                <div class=\"card\">\r\n                                                    <div class=\"card-header\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7107, "\"", 7121, 1);
#line 141 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 7112, oneClass, 7112, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7122, 145, true);
            WriteLiteral(">\r\n                                                        <h5 class=\"mb-0\">\r\n                                                            <button");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 7267, "\"", 7308, 3);
            WriteAttributeValue("", 7275, "btn", 7275, 3, true);
            WriteAttributeValue(" ", 7278, "btn-link", 7279, 9, true);
#line 143 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue(" ", 7287, firstclasscollapsed, 7288, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7309, 38, true);
            WriteLiteral(" data-toggle=\"collapse\" data-target=\"#");
            EndContext();
            BeginContext(7348, 8, false);
#line 143 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                                                                                                              Write(collapse);

#line default
#line hidden
            EndContext();
            BeginContext(7356, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("aria-expanded", " aria-expanded=\"", 7357, "\"", 7386, 1);
#line 143 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 7373, ariaexpanded, 7373, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 7387, "\"", 7412, 1);
#line 143 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 7403, collapse, 7403, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7413, 77, true);
            WriteLiteral(">\r\n                                                                <span>Day ");
            EndContext();
            BeginContext(7491, 13, false);
#line 144 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                                     Write(countCollapse);

#line default
#line hidden
            EndContext();
            BeginContext(7504, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(7514, 13, false);
#line 144 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                                                            Write(item.DayTitle);

#line default
#line hidden
            EndContext();
            BeginContext(7527, 285, true);
            WriteLiteral(@" <i class=""flaticon-arrow""></i>
                                                            </button>
                                                        </h5>
                                                    </div>

                                                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7812, "\"", 7826, 1);
#line 149 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 7817, collapse, 7817, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 7827, "\"", 7855, 2);
            WriteAttributeValue("", 7835, "collapse", 7835, 8, true);
#line 149 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue(" ", 7843, firstclass, 7844, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 7856, "\"", 7883, 1);
#line 149 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 7874, oneClass, 7874, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7884, 172, true);
            WriteLiteral(" data-parent=\"#accordion\">\r\n                                                        <div class=\"card-body\">\r\n                                                            <p>");
            EndContext();
            BeginContext(8057, 14, false);
#line 151 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                          Write(item.DayDetail);

#line default
#line hidden
            EndContext();
            BeginContext(8071, 186, true);
            WriteLiteral("</p>\r\n                                                        </div>\r\n                                                    </div>\r\n                                                </div>\r\n");
            EndContext();
#line 155 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                            }
                                        

#line default
#line hidden
            BeginContext(8347, 44, true);
            WriteLiteral("                                    </div>\r\n");
            EndContext();
#line 158 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(8499, 1031, true);
            WriteLiteral(@"                                    <div id=""accordion"" class=""difAccordColor"">
                                        <div class=""card"">
                                            <div class=""card-header"" id=""headingOne"">
                                                <h5 class=""mb-0"">
                                                    <button class=""btn btn-link"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                                        <span>DAILY M</span>  <i class=""flaticon-arrow""></i>
                                                    </button>
                                                </h5>
                                            </div>

                                            <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
                                                <div class=""card-body"">
                                                ");
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(9531, 27, false);
#line 173 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                  Write(Html.Raw(Model.TourMorning));

#line default
#line hidden
            EndContext();
            BeginContext(9558, 1116, true);
            WriteLiteral(@"</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""card"">
                                            <div class=""card-header"" id=""headingTwo"">
                                                <h5 class=""mb-0"">
                                                    <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                                        <span>DAILY L</span>  <i class=""flaticon-arrow""></i>
                                                    </button>
                                                </h5>
                                            </div>
                                            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
                                    ");
            WriteLiteral("            <div class=\"card-body\">\r\n                                                    <p>");
            EndContext();
            BeginContext(10675, 25, false);
#line 187 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                  Write(Html.Raw(Model.TourLunch));

#line default
#line hidden
            EndContext();
            BeginContext(10700, 1127, true);
            WriteLiteral(@"</p>
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""card"">
                                            <div class=""card-header"" id=""headingThree"">
                                                <h5 class=""mb-0"">
                                                    <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                                                        <span>DAILY A</span> <i class=""flaticon-arrow""></i>
                                                    </button>
                                                </h5>
                                            </div>
                                            <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
                         ");
            WriteLiteral("                       <div class=\"card-body\">\r\n                                                    <p>");
            EndContext();
            BeginContext(11828, 29, false);
#line 202 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                  Write(Html.Raw(Model.TourAfternoon));

#line default
#line hidden
            EndContext();
            BeginContext(11857, 1120, true);
            WriteLiteral(@"</p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""card"">
                                            <div class=""card-header"" id=""headingFour"">
                                                <h5 class=""mb-0"">
                                                    <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapseFour"" aria-expanded=""false"" aria-controls=""collapseFour"">
                                                        <span>DAILY N</span> <i class=""flaticon-arrow""></i>
                                                    </button>
                                                </h5>
                                            </div>
                                            <div id=""collapseFour"" class=""collapse"" aria-labelledby=""headingFour"" data-parent=""#accordion"">
                                ");
            WriteLiteral("                <div class=\"card-body\">\r\n                                                    <p>");
            EndContext();
            BeginContext(12978, 21, false);
#line 216 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                  Write(Html.Raw(Model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(12999, 210, true);
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n\r\n\r\n                                    </div>\r\n");
            EndContext();
#line 223 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                }

#line default
#line hidden
            BeginContext(13244, 262, true);
            WriteLiteral(@"                            </div>
                            <div class=""col-12 col-md-12 col-lg-4"">
                                <div class=""fixedFormBox"">
                                    <h6>Book This Tour</h6>
                                    ");
            EndContext();
            BeginContext(13506, 2937, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0e25aa2e73b99f6a84b9bcba68b45855fffac4528457", async() => {
                BeginContext(13561, 2875, true);
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
            BeginContext(16443, 220, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
