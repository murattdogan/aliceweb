#pragma checksum "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e15e5f42c1ba3f43b77396082cbaef88fddcb8c7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15e5f42c1ba3f43b77396082cbaef88fddcb8c7", @"/Views/Tour/tourplan.cshtml")]
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
    ViewData["Body"] = "graySection";

#line default
#line hidden
            BeginContext(228, 62, true);
            WriteLiteral("\r\n<section class=\"mansetNoneSlide\">\r\n    <div class=\"littleBg\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 290, "\"", 337, 4);
            WriteAttributeValue("", 298, "background:", 298, 11, true);
            WriteAttributeValue(" ", 309, "url(", 310, 5, true);
#line 11 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 314, Model.TourSliderImage, 314, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 336, ")", 336, 1, true);
            EndWriteAttribute();
            BeginContext(338, 1794, true);
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
            BeginContext(2133, 14, false);
#line 47 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                             Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(2147, 179, true);
            WriteLiteral("</span>\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"featureList\">\r\n                        <ul>\r\n                            <li>\r\n");
            EndContext();
#line 53 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                  
                                    var q = ViewBag.urlPrefix.Remove(ViewBag.urlPrefix.Length - 1);
                                

#line default
#line hidden
            BeginContext(2498, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2532, "\"", 2548, 1);
#line 56 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 2539, $"{q}", 2539, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2549, 257, true);
            WriteLiteral(@">
                                    <i class=""flaticon-info""></i>
                                    Overview
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2806, "\"", 2847, 2);
#line 62 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 2813, $"{ViewBag.urlPrefix}", 2813, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 2838, "tour-plan", 2838, 9, true);
            EndWriteAttribute();
            BeginContext(2848, 274, true);
            WriteLiteral(@" class=""active"">
                                    <i class=""flaticon-map-1""></i>
                                    Tour Plan
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3122, "\"", 3162, 2);
#line 68 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 3129, $"{ViewBag.urlPrefix}", 3129, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3154, "tour-map", 3154, 8, true);
            EndWriteAttribute();
            BeginContext(3163, 256, true);
            WriteLiteral(@">
                                    <i class=""flaticon-map""></i>
                                    Tour Map
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3419, "\"", 3456, 2);
#line 74 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 3426, $"{ViewBag.urlPrefix}", 3426, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3451, "hotel", 3451, 5, true);
            EndWriteAttribute();
            BeginContext(3457, 256, true);
            WriteLiteral(@">
                                    <i class=""flaticon-urban""></i>
                                    Hotels
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3713, "\"", 3755, 2);
#line 80 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 3720, $"{ViewBag.urlPrefix}", 3720, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3745, "conditions", 3745, 10, true);
            EndWriteAttribute();
            BeginContext(3756, 261, true);
            WriteLiteral(@">
                                    <i class=""flaticon-accept""></i>
                                    Conditions
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4017, "\"", 4056, 2);
#line 86 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 4024, $"{ViewBag.urlPrefix}", 4024, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 4049, "gallery", 4049, 7, true);
            EndWriteAttribute();
            BeginContext(4057, 783, true);
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
            BeginContext(5120, 77, true);
            WriteLiteral("                            <li class=\"breadcrumb-item \" aria-current=\"page\">");
            EndContext();
            BeginContext(5198, 14, false);
#line 111 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                                        Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(5212, 368, true);
            WriteLiteral(@"</li>
                        </ol>
                    </nav>
                    <div class=""contentDetail"">
                        <div class=""contentLeft"">
                            <div class=""col-12 col-md-12 col-lg-8"">
                                <div class=""boldContextText containerText"">
                                    <h3 class=""bigText"">");
            EndContext();
            BeginContext(5581, 14, false);
#line 118 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                   Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(5595, 51, true);
            WriteLiteral("</h3>\r\n                                </div>\r\n\r\n\r\n");
            EndContext();
#line 122 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                 if (Model.TourType == 0)
                                {

#line default
#line hidden
            BeginContext(5740, 81, true);
            WriteLiteral("                                    <div id=\"accordion\" class=\"difAccordColor\">\r\n");
            EndContext();
#line 125 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                          
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
            BeginContext(7002, 144, true);
            WriteLiteral("                                                <div class=\"card\">\r\n                                                    <div class=\"card-header\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7146, "\"", 7160, 1);
#line 142 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 7151, oneClass, 7151, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7161, 145, true);
            WriteLiteral(">\r\n                                                        <h5 class=\"mb-0\">\r\n                                                            <button");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 7306, "\"", 7347, 3);
            WriteAttributeValue("", 7314, "btn", 7314, 3, true);
            WriteAttributeValue(" ", 7317, "btn-link", 7318, 9, true);
#line 144 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue(" ", 7326, firstclasscollapsed, 7327, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7348, 38, true);
            WriteLiteral(" data-toggle=\"collapse\" data-target=\"#");
            EndContext();
            BeginContext(7387, 8, false);
#line 144 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                                                                                                              Write(collapse);

#line default
#line hidden
            EndContext();
            BeginContext(7395, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("aria-expanded", " aria-expanded=\"", 7396, "\"", 7425, 1);
#line 144 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 7412, ariaexpanded, 7412, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 7426, "\"", 7451, 1);
#line 144 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 7442, collapse, 7442, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7452, 77, true);
            WriteLiteral(">\r\n                                                                <span>Day ");
            EndContext();
            BeginContext(7530, 13, false);
#line 145 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                                     Write(countCollapse);

#line default
#line hidden
            EndContext();
            BeginContext(7543, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(7553, 13, false);
#line 145 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                                                            Write(item.DayTitle);

#line default
#line hidden
            EndContext();
            BeginContext(7566, 285, true);
            WriteLiteral(@" <i class=""flaticon-arrow""></i>
                                                            </button>
                                                        </h5>
                                                    </div>

                                                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7851, "\"", 7865, 1);
#line 150 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 7856, collapse, 7856, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 7866, "\"", 7894, 2);
            WriteAttributeValue("", 7874, "collapse", 7874, 8, true);
#line 150 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue(" ", 7882, firstclass, 7883, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 7895, "\"", 7922, 1);
#line 150 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
WriteAttributeValue("", 7913, oneClass, 7913, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7923, 172, true);
            WriteLiteral(" data-parent=\"#accordion\">\r\n                                                        <div class=\"card-body\">\r\n                                                            <p>");
            EndContext();
            BeginContext(8096, 14, false);
#line 152 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                          Write(item.DayDetail);

#line default
#line hidden
            EndContext();
            BeginContext(8110, 186, true);
            WriteLiteral("</p>\r\n                                                        </div>\r\n                                                    </div>\r\n                                                </div>\r\n");
            EndContext();
#line 156 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                            }
                                        

#line default
#line hidden
            BeginContext(8386, 44, true);
            WriteLiteral("                                    </div>\r\n");
            EndContext();
#line 159 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(8538, 1031, true);
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
            BeginContext(9570, 27, false);
#line 174 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                  Write(Html.Raw(Model.TourMorning));

#line default
#line hidden
            EndContext();
            BeginContext(9597, 1116, true);
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
            BeginContext(10714, 25, false);
#line 188 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                  Write(Html.Raw(Model.TourLunch));

#line default
#line hidden
            EndContext();
            BeginContext(10739, 1127, true);
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
            BeginContext(11867, 29, false);
#line 203 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                  Write(Html.Raw(Model.TourAfternoon));

#line default
#line hidden
            EndContext();
            BeginContext(11896, 1120, true);
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
            BeginContext(13017, 21, false);
#line 217 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                                  Write(Html.Raw(Model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(13038, 210, true);
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n\r\n\r\n                                    </div>\r\n");
            EndContext();
#line 224 "E:\alice\Alice\Alice.Web\Views\Tour\tourplan.cshtml"
                                }

#line default
#line hidden
            BeginContext(13283, 262, true);
            WriteLiteral(@"                            </div>
                            <div class=""col-12 col-md-12 col-lg-4"">
                                <div class=""fixedFormBox"">
                                    <h6>Book This Tour</h6>
                                    ");
            EndContext();
            BeginContext(13545, 2937, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e15e5f42c1ba3f43b77396082cbaef88fddcb8c728496", async() => {
                BeginContext(13600, 2875, true);
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
            BeginContext(16482, 220, true);
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
