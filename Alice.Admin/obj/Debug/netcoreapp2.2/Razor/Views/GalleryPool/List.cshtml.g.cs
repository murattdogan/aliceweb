#pragma checksum "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e1cff2b05e91e4dce19f6180f022c6d0a11b5e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GalleryPool_List), @"mvc.1.0.view", @"/Views/GalleryPool/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GalleryPool/List.cshtml", typeof(AspNetCore.Views_GalleryPool_List))]
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
#line 1 "E:\alice\Alice\Alice.Admin\Views\_ViewImports.cshtml"
using Alice.Admin;

#line default
#line hidden
#line 2 "E:\alice\Alice\Alice.Admin\Views\_ViewImports.cshtml"
using Alice.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e1cff2b05e91e4dce19f6180f022c6d0a11b5e3", @"/Views/GalleryPool/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee27dff30bfd646508db1df94e1f606c5fbadd0a", @"/Views/_ViewImports.cshtml")]
    public class Views_GalleryPool_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alice.Service.Model.GalleryPoolDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("kt-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/GalleryPool/Insert"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
  
    ViewData["Title"] = "Galeri Havuzu";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(337, 130, true);
            WriteLiteral("\r\n\r\n<div class=\"kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid\" id=\"newimages\" style=\"display:none;\">\r\n    ");
            EndContext();
            BeginContext(467, 7118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e1cff2b05e91e4dce19f6180f022c6d0a11b5e35537", async() => {
                BeginContext(562, 4922, true);
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""kt-portlet"">
                    <div class=""kt-portlet__head"">
                        <div class=""kt-portlet__head-label"">
                            <h3>Resim Ayarları</h3>
                        </div>
                    </div>
                    <div class=""kt-portlet__body"">
                        <div class=""form-group"">
                            <label class=""kt-font-bold kt-font-success"">AnaSayfa Boyutları</label>
                            <div class=""kt-checkbox-list"">
                                <label class=""kt-checkbox kt-checkbox--success"">
                                    <input type=""checkbox"" name=""Genellogo_168_57"" value=""1""> Genellogo_168_57
                                    <span></span>
                                </label>
                                <label class=""kt-checkbox kt-checkbox--success"">
                                    <input type=""checkbox"" ");
                WriteLiteral(@"name=""AnaSayfa_401x289"" value=""1""> AnaSayfa_401x289
                                    <span></span>
                                </label>
                                <label class=""kt-checkbox kt-checkbox--success"">
                                    <input type=""checkbox"" value=""1"" name=""AnaSayfa_401x592""> AnaSayfa_401x592s
                                    <span></span>
                                </label>
                                <label class=""kt-checkbox kt-checkbox--success"">
                                    <input type=""checkbox"" value=""1"" name=""AnaSayfa_815x289""> AnaSayfa_815x289
                                    <span></span>
                                </label>
                                <label class=""kt-checkbox kt-checkbox--success"">
                                    <input type=""checkbox"" value=""1"" name=""AnasayfaSlider_1440_800""> AnasayfaSlider_1440_800
                                    <span></span>
                                </label>
  ");
                WriteLiteral(@"                              <label class=""kt-checkbox kt-checkbox--success"">
                                    <input type=""checkbox"" value=""1"" name=""AnasayfaSlider_1440_534""> AnasayfaSlider_1440_534
                                    <span></span>
                                </label>


                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""kt-font-bolder kt-font-info"">Kategori Boyutları</label>
                            <div class=""kt-checkbox-list"">
                                <label class=""kt-checkbox kt-checkbox--info"">
                                    <input type=""checkbox"" value=""1"" name=""KategoriDetay_285x285""> KategoriDetay_285x285
                                    <span></span>
                                </label>
                                <label class=""kt-checkbox kt-checkbox--info"">
                                    <input type=""checkbox"" value=""1"" na");
                WriteLiteral(@"me=""KategoriAltDetay_389_280""> KategoriAltDetay_389_280
                                    <span></span>
                                </label>
                            </div>
                        </div>

                        <div class=""form-group"">
                            <label class=""kt-font-bold kt-font-danger"">Tur Detay Boyutları</label>
                            <div class=""kt-checkbox-list"">
                                <label class=""kt-checkbox kt-checkbox--danger"">
                                    <input type=""checkbox"" value=""1"" name=""TourDetail_1440_550""> TourDetail_1440_550
                                    <span></span>
                                </label>
                                <label class=""kt-checkbox kt-checkbox--danger"">
                                    <input type=""checkbox"" value=""1"" name=""TourGallery_257_257""> TourGallery_257_257
                                    <span></span>
                                </label>
          ");
                WriteLiteral(@"                  </div>
                        </div>


                    </div>
                </div>

            </div>

            <div class=""col-md-9"">
                <div class=""kt-portlet"">
                    <div class=""kt-portlet__head"">
                        <div class=""kt-portlet__head-label"">
                            <h3 class=""kt-portlet__head-title"">Resim Detayları</h3>
                        </div>
                    </div>
                    <div class=""kt-portlet__body"">

                        <div class=""kt-portlet__body"">

                            <div class=""form-group"">
                                <label>Resim Kategori Adı</label>
                                <select class=""form-control"" name=""KeywordPool"">
                                    ");
                EndContext();
                BeginContext(5484, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e1cff2b05e91e4dce19f6180f022c6d0a11b5e311115", async() => {
                    BeginContext(5502, 3, true);
                    WriteLiteral("Seç");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5514, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 102 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
                                     foreach (var item in ((List<Alice.Service.Model.KeywordPoolDTO>)ViewBag.KeywordPool).OrderBy(x => x.Keyword))
                                    {

#line default
#line hidden
                BeginContext(5703, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(5743, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e1cff2b05e91e4dce19f6180f022c6d0a11b5e313018", async() => {
                    BeginContext(5769, 12, false);
#line 104 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
                                                            Write(item.Keyword);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 104 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5790, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 105 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
                                    }

#line default
#line hidden
                BeginContext(5831, 1747, true);
                WriteLiteral(@"                                </select>
                            </div>
                            <div class=""form-group"">
                                <label>Resim Kategori Adı</label>
                                <input type=""text"" name=""ImageCategoryName"" class=""form-control"" aria-describedby=""emailHelp"" placeholder=""Otel, Oda, Deniz v.b."">
                            </div>
                            <div class=""form-group"">
                                <label>Resim Prefix</label>
                                <input type=""text"" name=""imageNamePrefix"" class=""form-control"" aria-describedby=""emailHelp"" placeholder="""">
                            </div>
                            <div class=""form-group"">
                                <label id=""categoryimage"">Resim</label>
                                <div></div>
                                <div class=""custom-file"">
                                    <input type=""file"" name=""ImageFile"" class=""custom-file-input"" id=");
                WriteLiteral(@"""customFile"">
                                    <label class=""custom-file-label"" for=""customFile"">Resim Seç</label>
                                </div>
                            </div>

                        </div>
                        <div class=""kt-portlet__foot"">
                            <div class=""kt-form__actions"">
                                <button type=""submit"" class=""btn btn-primary"">Kaydet</button>
                                <button type=""reset"" class=""btn btn-secondary"" id=""cancelnewimage"">İptal Et</button>
                            </div>
                        </div>

                    </div>
                </div>

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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7585, 1369, true);
            WriteLiteral(@"
</div>

<div class=""kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid"">
    <div class=""kt-notification kt-margin-t-30 kt-margin-b-20 kt-scroll"" data-scroll=""true"" data-mobile-height=""220"">



        

        <div class=""kt-portlet kt-portlet--mobile"">

            <div class=""kt-portlet__body"">
                <div class=""row"">
                    <div class=""col-sm-6 text-left"">
                        <div id=""kt_table_1_filter"" class=""dataTables_filter"">
                            <label><br /><br /></label>
                        </div>
                    </div>
                    <div class=""col-sm-6 text-right"">
                        <div class=""dt-buttons btn-group"">
                            <button type=""button"" class=""btn btn-success btn-elevate btn-elevate-air"" id=""newimagestrigger"">Yeni Resim Ekle</button>
                        </div>
                    </div>
                </div>
                <table class=""table table-striped- table");
            WriteLiteral(@"-bordered table-hover table-checkable"" id=""kt_table_1"">
                    <thead>
                        <tr>
                            <th>Resim</th>
                            <th>Kullanılan Yer</th>
                            <th>#</th>
                        </tr>
                    </thead>

                    <tbody>
");
            EndContext();
#line 173 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(9035, 37, true);
            WriteLiteral("                        <tr data-id=\"");
            EndContext();
            BeginContext(9073, 7, false);
#line 175 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
                                Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(9080, 73, true);
            WriteLiteral("\">\r\n                            <td style=\"width:40px; height:40px;\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 9153, "\"", 9218, 1);
#line 176 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
WriteAttributeValue("", 9159, $"{item.Thumbnail}/{item.GalleryId}{item.PathExtension}", 9159, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9219, 65, true);
            WriteLiteral(" width=\"40\" height=\"40\" /></td>\r\n                            <td>");
            EndContext();
            BeginContext(9285, 14, false);
#line 177 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
                           Write(item.ImageSize);

#line default
#line hidden
            EndContext();
            BeginContext(9299, 259, true);
            WriteLiteral(@"</td>
                            <td><a href=""#"">Hangi Turlarda Kullanılıyor?</a></td>
                            <td nowrap>
                                <button type=""button"" class=""btn btn-danger btn-elevate btn-elevate-air gallerydelete"" data-id=""");
            EndContext();
            BeginContext(9559, 7, false);
#line 180 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
                                                                                                                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(9566, 82, true);
            WriteLiteral("\">Sil</button>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 183 "E:\alice\Alice\Alice.Admin\Views\GalleryPool\List.cshtml"
                        }

#line default
#line hidden
            BeginContext(9675, 120, true);
            WriteLiteral("                    </tbody>\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9812, 2359, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $("".gallerydelete"").click(function () {
                if (confirm(""Silmek İstediğinize Emin misiniz?"")) {
                    $.ajax({
                        type: ""GET"",
                        url: ""/GalleryPool/Delete"",
                        data: { Id: parseInt($(this).data(""id"")) },
                        success: function () {

                        },
                        dataType: ""json""
                    });
                    window.location.reload(false);
                }
            });
            $('#newimagestrigger').click(function () {
                $(""#newimages"").fadeIn();
                //renderCategory();
            });


            $('#AnaSayfa_401x289').click(function (e) {
                swal.fire({
                    title: 'Sweet!',
                    text: 'Modal with a custom image.',
                    imageUrl: 'https://unsplash.it/400/200',
                    imageWidth: 400,
");
                WriteLiteral(@"                    imageHeight: 200,
                    imageAlt: 'Custom image',
                    animation: false
                });
            });


            $('#cancelnewimage').click(function () {
                $('#newimages').fadeOut();
            });
            //    $("".categoryupdate"").click(function () {
            //        $.ajax({
            //            type: ""POST"",
            //            url: ""/Categories/GetById"",
            //            data: { Id: parseInt($(this).data(""id"")) },
            //            success: function (e) {
            //                $(""#categoryimage"").css({ ""color"": ""red"" }).text(""Kategori'nin resmini güncellemek istiyorsanız. Yeni resim seçebilirsiniz."");
            //                renderCategory();
            //                $(""input[name='CategoryName']"").val(e.categoryName);
            //                $(""input[name='CategoryPath']"").val(e.categoryPath);
            //                $('select[name=""TopCategory""");
                WriteLiteral(@"]').val(e.mainCategoryId).change();
            //                $(""#CategoryId"").val(e.id);

            //                $('#newimages').fadeIn();
            //            },
            //            dataType: ""json""
            //        });
            //    });


        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alice.Service.Model.GalleryPoolDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
