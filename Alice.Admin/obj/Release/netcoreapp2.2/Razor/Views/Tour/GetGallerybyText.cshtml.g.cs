#pragma checksum "E:\alice\Alice\Alice.Admin\Views\Tour\GetGallerybyText.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbca41be2d64ac5cfc461818443679833e2322ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour_GetGallerybyText), @"mvc.1.0.view", @"/Views/Tour/GetGallerybyText.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tour/GetGallerybyText.cshtml", typeof(AspNetCore.Views_Tour_GetGallerybyText))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbca41be2d64ac5cfc461818443679833e2322ce", @"/Views/Tour/GetGallerybyText.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee27dff30bfd646508db1df94e1f606c5fbadd0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_GetGallerybyText : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alice.Service.Model.GalleryPoolDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 123, true);
            WriteLiteral("<div class=\"kt-section\">\r\n    <div class=\"kt-section__desc\">Bulunan Resimler</div>\r\n    <div class=\"kt-section__content\">\r\n");
            EndContext();
#line 5 "E:\alice\Alice\Alice.Admin\Views\Tour\GetGallerybyText.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(221, 66, true);
            WriteLiteral("            <a href=\"#\" class=\"imageselect\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 287, "\"", 352, 1);
#line 8 "E:\alice\Alice\Alice.Admin\Views\Tour\GetGallerybyText.cshtml"
WriteAttributeValue("", 293, $"{item.Thumbnail}/{item.GalleryId}{item.PathExtension}", 293, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(353, 14, true);
            WriteLiteral(" data-medium=\"");
            EndContext();
            BeginContext(369, 56, false);
#line 8 "E:\alice\Alice\Alice.Admin\Views\Tour\GetGallerybyText.cshtml"
                                                                                                Write($"{item.Thumbnail}/{item.GalleryId}{item.PathExtension}");

#line default
#line hidden
            EndContext();
            BeginContext(426, 43, true);
            WriteLiteral("\" class=\"imagelistitem\" alt=\"Seç\" data-id=\"");
            EndContext();
            BeginContext(470, 14, false);
#line 8 "E:\alice\Alice\Alice.Admin\Views\Tour\GetGallerybyText.cshtml"
                                                                                                                                                                                                     Write(item.GalleryId);

#line default
#line hidden
            EndContext();
            BeginContext(484, 22, true);
            WriteLiteral("\">\r\n            </a>\r\n");
            EndContext();
#line 10 "E:\alice\Alice\Alice.Admin\Views\Tour\GetGallerybyText.cshtml"
        }

#line default
#line hidden
            BeginContext(517, 486, true);
            WriteLiteral(@"
        <input type=""hidden"" value=""0"" name=""GetGalleryByText"" />
    </div>
</div>

<script>

        $(function () {
            $('.imageselect').click(function () {
                var galleryId = $(this).children(""img"").data(""id"");
                $(""input[name='GetGalleryByText']"").val(galleryId);
                $('.imagelistitem').css(""border"", ""0"");
                $(this).children(""img"").css(""border"", ""2px solid red"");
            });
        });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alice.Service.Model.GalleryPoolDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
