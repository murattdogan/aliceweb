#pragma checksum "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14b42af8a9eaa1bd612da20c2d32ade2cb9143b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_List), @"mvc.1.0.view", @"/Views/Categories/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/List.cshtml", typeof(AspNetCore.Views_Categories_List))]
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
#line 1 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
using Alice.Service.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14b42af8a9eaa1bd612da20c2d32ade2cb9143b5", @"/Views/Categories/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee27dff30bfd646508db1df94e1f606c5fbadd0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoriesDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/vendors/custom/datatables/datatables.bundle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/vendors/custom/datatables/datatables.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("kt-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Categories/Insert"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
  
    ViewData["Title"] = "Kategori Listesi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14b42af8a9eaa1bd612da20c2d32ade2cb9143b56293", async() => {
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
            BeginContext(245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(247, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14b42af8a9eaa1bd612da20c2d32ade2cb9143b57545", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(327, 364, true);
            WriteLiteral(@"

<div class=""kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid"">

    <div class=""kt-notification kt-margin-t-30 kt-margin-b-20 kt-scroll"" data-scroll=""true"" data-mobile-height=""220"">
        <div class=""kt-portlet kt-portlet--mobile"" id=""newcategory"" style=""display:none;"">

            <div class=""kt-portlet__body"">
                ");
            EndContext();
            BeginContext(691, 5109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14b42af8a9eaa1bd612da20c2d32ade2cb9143b59103", async() => {
                BeginContext(785, 3410, true);
                WriteLiteral(@"
                    <div class=""kt-portlet__body"">
                        <div class=""form-group form-group-last"">
                            <div class=""alert alert-secondary"" role=""alert"">
                                <div class=""alert-icon""><i class=""flaticon-warning kt-font-brand""></i></div>
                                <div class=""alert-text"">
                                    Kategori resmi eklerken 700x350 boyutundan büyük girmeyiniz!
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label>Id</label>
                            <input type=""number"" name=""id"" class=""form-control"" placeholder=""Id"">
                        </div>
                        <div class=""form-group"">
                            <label>Kategori Adı</label>
                            <input type=""text"" name=""CategoryName"" class=""form-control"" aria-describedby=""emailHelp"" ");
                WriteLiteral(@"placeholder=""Travel, Hotel vb."">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Kategori Path</label>
                            <input type=""text"" name=""CategoryPath"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""/travel gibi"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleSelect1"">Üst Kategori</label>
                            <select class=""form-control"" name=""TopCategory"" id=""TopCategory"">
                            </select>
                        </div>

                        <div class=""form-group"">
                            <label for=""exampleSelect1"">Kategori Başlık</label>
                            <input type=""text"" class=""form-control"" name=""Title"" id=""Title"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exa");
                WriteLiteral(@"mpleSelect1"">Kategori Açıklama</label>
                            <input type=""text"" class=""form-control"" name=""Description"" id=""Description"">
                        </div>

                        <div class=""form-group"">
                            <label for=""exampleSelect1"">SEO Title</label>
                            <input type=""text"" class=""form-control"" name=""SEOTitle"" id=""SEOTitle"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleSelect1"">SEO Description</label>
                            <input type=""text"" class=""form-control"" name=""SEODescription"" id=""SEODescription"">
                        </div>

                        <div class=""form-group"">
                            <label for=""exampleSelect1""></label>

                            <div class=""col-xl-12 alreadyimagelist"">

                            </div>
                        </div>

                        <div class=""form-group upd");
                WriteLiteral(@"ateimages"" style=""display:none;"">
                            <label><strong>Aramak İstediğiniz Resim için Anahtar Kelime Seçin</strong></label>
                            <div class=""input-group"">
                                <select name=""ImageSearch"" class=""form-control selectpicker col-10"" style=""border:1px solid #5578eb;"">
");
                EndContext();
#line 74 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                                     foreach (var item in (List<Alice.Service.Model.KeywordPoolDTO>)ViewBag.SelectAllKeyword)
                                    {

#line default
#line hidden
                BeginContext(4361, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(4401, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14b42af8a9eaa1bd612da20c2d32ade2cb9143b513547", async() => {
                    BeginContext(4432, 12, false);
#line 76 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                                                                 Write(item.Keyword);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 76 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                                           WriteLiteral(item.Keyword);

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
                BeginContext(4453, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 77 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                                    }

#line default
#line hidden
                BeginContext(4494, 1299, true);
                WriteLiteral(@"                                </select>
                                <div class=""input-group-append"">
                                    <button class=""btn btn-info resimara"" type=""button"">Galeride Ara</button>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group galeriload"">

                        </div>
                        <div class=""kt-portlet__foot updateimages"">
                            <div class=""kt-form__actions"">
                                <button type=""button"" class=""resmiekle btn btn-primary btn-sm"">Slider Olarak Ekle</button>
                                <button type=""button"" class=""currentresmiekle btn btn-info btn-sm"">Kategori Resmi Olarak Seç</button>
                            </div>
                        </div>
                    </div>
                    <div class=""kt-portlet__foot"">
                        <div class=""kt-form__actions"">
         ");
                WriteLiteral(@"                   <button type=""submit"" class=""btn btn-primary"">Kaydet</button>
                            <button type=""reset"" class=""btn btn-secondary"" id=""cancelnewcategory"">İptal Et</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5800, 1222, true);
            WriteLiteral(@"
            </div>
        </div>

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
                            <button type=""button"" class=""btn btn-success btn-elevate btn-elevate-air"" id=""newcategorytrigger"">Yeni Kategori Ekle</button>
                        </div>
                    </div>
                </div>
                <table class=""table table-striped- table-bordered table-hover table-checkable"" id=""kt_table_1"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>");
            WriteLiteral("Kategori Adı</th>\r\n                            <th>Url Yolu</th>\r\n                            <th>#</th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 130 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                         foreach (var item in Model)
                        {
                            var categoryName = string.Empty;
                            if (item.MainCategoryId != 0)
                            {
                                categoryName = $"<strong>{Model.First(x => x.Id == item.MainCategoryId).CategoryName}</strong> / {item.CategoryName}";
                            }
                            else
                            {
                                categoryName = item.CategoryName;
                            }


#line default
#line hidden
            BeginContext(7603, 41, true);
            WriteLiteral("                            <tr data-id=\"");
            EndContext();
            BeginContext(7645, 7, false);
#line 142 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                                    Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7652, 40, true);
            WriteLiteral("\">\r\n                                <td>");
            EndContext();
            BeginContext(7693, 7, false);
#line 143 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7700, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(7744, 22, false);
#line 144 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                               Write(Html.Raw(categoryName));

#line default
#line hidden
            EndContext();
            BeginContext(7766, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(7810, 9, false);
#line 145 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                               Write(item.Path);

#line default
#line hidden
            EndContext();
            BeginContext(7819, 183, true);
            WriteLiteral("</td>\r\n                                <td nowrap>\r\n                                    <button type=\"button\" class=\"btn btn-info btn-elevate btn-elevate-air categoryupdate\" data-id=\"");
            EndContext();
            BeginContext(8003, 7, false);
#line 147 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                                                                                                                              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(8010, 154, true);
            WriteLiteral("\">Güncelle</button>\r\n                                    <button type=\"button\" class=\"btn btn-danger btn-elevate btn-elevate-air categorydelete\" data-id=\"");
            EndContext();
            BeginContext(8165, 7, false);
#line 148 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                                                                                                                                Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(8172, 90, true);
            WriteLiteral("\">Sil</button>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 151 "E:\alice\Alice\Alice.Admin\Views\Categories\List.cshtml"
                        }

#line default
#line hidden
            BeginContext(8289, 120, true);
            WriteLiteral("                    </tbody>\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8426, 6397, true);
                WriteLiteral(@"
    <script>
        $(function () {


            $('.resimara').click(function () {
                var text = $(""select[name='ImageSearch']"").val();
                $("".galeriload"").load(""/Tour/GetGallerybyText?text="" + text);
                $('.imageselect').bind(""click"");
            });


            $("".categoryupdate"").click(function () {
                var Id = $(this).data(""id"");
                $(""input[name='id']"").val(Id);

                $.ajax({
                    type: ""POST"",
                    url: ""/Categories/GetById"",
                    data: { Id: parseInt(Id) },
                    success: function (e) {
                        renderCategory();
                        $(""input[name='CategoryName']"").val(e.categoryName);
                        $(""input[name='CategoryPath']"").val(e.path);
                        $('select[name=""TopCategory""]').val(e.mainCategoryId).change();
                        $(""input[name='Title']"").val(e.title);
                ");
                WriteLiteral(@"        $(""input[name='Description']"").val(e.description);
                        $(""input[name='SEOTitle']"").val(e.seoTitle);
                        $(""input[name='SEODescription']"").val(e.seoDescription);
                        $(""input[name='id']"").val(e.id);
                        $('#newcategory').fadeIn();
                        $('.updateimages').fadeIn();
                        $("".alreadyimagelist"").load(""/Categories/GetGalleryImages?Id="" + Id);
                    },
                    dataType: ""json""
                });
            });

            
            $('.currentresmiekle').click(function () {
                if (confirm(""Bu Resmi Kategori Resmi olarak eklemek istediğine Emin misin?"")) {
                    var galleryId = $(""input[name='GetGalleryByText']"").val();
                    var categoryId = parseInt($(""input[name='id']"").val());
                    $.ajax({
                        type: ""POST"",
                        url: ""/Categories/CategoryPicture");
                WriteLiteral(@"Update"",
                        data: {
                            ""galleryId"": galleryId,
                            ""categoryId"": categoryId
                        },
                        success: function (x) {
                            if (x == false) {
                                alert(""Bir Sorun Var! Lütfen tekrar deneyiniz."");
                            }
                            else {
                                swal.fire({
                                    title: ""Ekleniyor..."",
                                    text: ""Kategoriye Resim Ekleyeceğiz Demek vay beeee :) tamam hadi ekliyorum."",
                                    timer: 2000,
                                    onOpen: function () {
                                        swal.showLoading()
                                    }
                                }).then(function (result) {
                                    $("".alreadyimagelist"").load(""/Categories/GetGalleryImages?Id="" + $(""#Categ");
                WriteLiteral(@"oryId"").val());
                                });
                            }
                        },
                        dataType: ""json""
                    });
                }
            });

            $('.resmiekle').click(function () {
                if (confirm(""Güncellemek İstediğine Emin misin?"")) {
                    var galleryId = $(""input[name='GetGalleryByText']"").val();
                    var categoryId = parseInt($(""input[name='id']"").val());
                    $.ajax({
                        type: ""POST"",
                        url: ""/Categories/UpdateCategoryBox"",
                        data: {
                            ""galleryId"": galleryId,
                            ""categoryId"": categoryId
                        },
                        success: function (x) {
                            if (x == false) {
                                alert(""Bir Sorun Var! Lütfen tekrar deneyiniz."");
                            }
                    ");
                WriteLiteral(@"        else {
                                swal.fire({
                                    title: ""Ekleniyor..."",
                                    text: ""Kategoriye Resim Ekleyeceğiz Demek vay beeee :) tamam hadi ekliyorum."",
                                    timer: 2000,
                                    onOpen: function () {
                                        swal.showLoading()
                                    }
                                }).then(function (result) {
                                    $("".alreadyimagelist"").load(""/Categories/GetGalleryImages?Id="" +$(""input[name='id']"").val());
                                });
                            }
                        },
                        dataType: ""json""
                    });
                }
            });
            $("".categorydelete"").click(function () {
                $.ajax({
                    type: ""POST"",
                    url: ""/Categories/Delete"",
                    data:");
                WriteLiteral(@" { Id: parseInt($(this).data(""id"")) },
                    success: function (e) {
                        window.location.reload(false);
                    },
                    dataType: ""json""
                });
            });
            $('#newcategorytrigger').click(function () {
                $(""#categoryimage"").css({ ""color"": ""black"" }).text(""Resim"");
                $('.updateimages').fadeOut();
                renderCategory();
            });

            $('#cancelnewcategory').click(function () {
                $('#newcategory').fadeOut();
            });
        });

        function renderCategory() {
            $(""#TopCategory"").append(`<option value=""0"">Seç</option>`);
            $.ajax({
                type: ""POST"",
                url: ""/Categories/UpCategory"",
                data: null,
                success: function (e) {
                    $(""#CategoryId"").val(""0"");
                    $.each(e, function (key, value) {
                        $(""");
                WriteLiteral("#TopCategory\").append(`<option value=\"${e[key].id}\">${e[key].categoryName}</option>`);\r\n                    });\r\n                },\r\n                dataType: \"json\"\r\n            });\r\n\r\n            $(\'#newcategory\').fadeIn();\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoriesDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
