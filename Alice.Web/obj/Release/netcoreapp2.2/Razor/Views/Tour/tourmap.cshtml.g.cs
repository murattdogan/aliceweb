#pragma checksum "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43291f09d4147fe3fadaa322784550d4fe79cf3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour_tourmap), @"mvc.1.0.view", @"/Views/Tour/tourmap.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tour/tourmap.cshtml", typeof(AspNetCore.Views_Tour_tourmap))]
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
#line 1 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
using Alice.Service.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43291f09d4147fe3fadaa322784550d4fe79cf3f", @"/Views/Tour/tourmap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e93ce5880de5b382b5c3edaf77636ae93e9007", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_tourmap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourDTO>
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
#line 3 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
  
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
#line 10 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
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
#line 46 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
                             Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(2108, 179, true);
            WriteLiteral("</span>\r\n                        </h3>\r\n                    </div>\r\n                    <div class=\"featureList\">\r\n                        <ul>\r\n                            <li>\r\n");
            EndContext();
#line 52 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
                                  
                                    var q = ViewBag.urlPrefix.Remove(ViewBag.urlPrefix.Length - 1);
                                

#line default
#line hidden
            BeginContext(2459, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2493, "\"", 2509, 1);
#line 55 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
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
#line 61 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
WriteAttributeValue("", 2774, $"{ViewBag.urlPrefix}", 2774, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 2799, "tour-plan", 2799, 9, true);
            EndWriteAttribute();
            BeginContext(2809, 259, true);
            WriteLiteral(@">
                                    <i class=""flaticon-map-1""></i>
                                    Tour Plan
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3068, "\"", 3108, 2);
#line 67 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
WriteAttributeValue("", 3075, $"{ViewBag.urlPrefix}", 3075, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3100, "tour-map", 3100, 8, true);
            EndWriteAttribute();
            BeginContext(3109, 271, true);
            WriteLiteral(@" class=""active"">
                                    <i class=""flaticon-map""></i>
                                    Tour Map
                                </a>
                            </li>
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3380, "\"", 3417, 2);
#line 73 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
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
#line 79 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
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
#line 85 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
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
#line 110 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
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
#line 117 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
                                                   Write(Model.TourName);

#line default
#line hidden
            EndContext();
            BeginContext(5556, 87, true);
            WriteLiteral("</h3>\r\n                                </div>\r\n\r\n                                <span>");
            EndContext();
            BeginContext(5644, 17, false);
#line 120 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
                                 Write(Model.TourMapDesc);

#line default
#line hidden
            EndContext();
            BeginContext(5661, 59, true);
            WriteLiteral("</span><br /><br />\r\n\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5720, "\"", 5745, 1);
#line 122 "E:\alice\Alice\Alice.Web\Views\Tour\tourmap.cshtml"
WriteAttributeValue("", 5726, Model.TourMapImage, 5726, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5746, 271, true);
            WriteLiteral(@" />


                            </div>
                            <div class=""col-12 col-md-12 col-lg-4"">
                                <div class=""fixedFormBox"">
                                    <h6>Book This Tour</h6>
                                    ");
            EndContext();
            BeginContext(6017, 2937, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43291f09d4147fe3fadaa322784550d4fe79cf3f15163", async() => {
                BeginContext(6072, 2875, true);
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
            BeginContext(8954, 220, true);
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