#pragma checksum "C:\Users\Sıla\Desktop\Yeni klasör (2)\Yeni klasör (3)\WebApplication1\WebApplication1\Views\Birim\BirimGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc09f5eba8a8b2f19b3a9f69ad4986e71c964b48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Birim_BirimGetir), @"mvc.1.0.view", @"/Views/Birim/BirimGetir.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Sıla\Desktop\Yeni klasör (2)\Yeni klasör (3)\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sıla\Desktop\Yeni klasör (2)\Yeni klasör (3)\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc09f5eba8a8b2f19b3a9f69ad4986e71c964b48", @"/Views/Birim/BirimGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Birim_BirimGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Birim>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sıla\Desktop\Yeni klasör (2)\Yeni klasör (3)\WebApplication1\WebApplication1\Views\Birim\BirimGetir.cshtml"
 using (Html.BeginForm("BirimGuncelle", "Birim", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Birim ID</b>\r\n");
#nullable restore
#line 6 "C:\Users\Sıla\Desktop\Yeni klasör (2)\Yeni klasör (3)\WebApplication1\WebApplication1\Views\Birim\BirimGetir.cshtml"
Write(Html.TextBoxFor(x => x.BirimID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Departman Adı</b>\r\n");
#nullable restore
#line 9 "C:\Users\Sıla\Desktop\Yeni klasör (2)\Yeni klasör (3)\WebApplication1\WebApplication1\Views\Birim\BirimGetir.cshtml"
Write(Html.TextBoxFor(x => x.BirimAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 13 "C:\Users\Sıla\Desktop\Yeni klasör (2)\Yeni klasör (3)\WebApplication1\WebApplication1\Views\Birim\BirimGetir.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Birim> Html { get; private set; }
    }
}
#pragma warning restore 1591
