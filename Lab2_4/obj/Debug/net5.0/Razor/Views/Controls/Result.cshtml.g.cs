#pragma checksum "C:\Users\Roman\source\repos\Lab2_4\Lab2_4\Views\Controls\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18c3199068713142d6f9739120a940ae51f62c6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controls_Result), @"mvc.1.0.view", @"/Views/Controls/Result.cshtml")]
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
#line 1 "C:\Users\Roman\source\repos\Lab2_4\Lab2_4\Views\_ViewImports.cshtml"
using Lab2_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roman\source\repos\Lab2_4\Lab2_4\Views\_ViewImports.cshtml"
using Lab2_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18c3199068713142d6f9739120a940ae51f62c6c", @"/Views/Controls/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"399d17681a7cddb393f3a36ac9e6a42ef00738b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Controls_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>");
#nullable restore
#line 2 "C:\Users\Roman\source\repos\Lab2_4\Lab2_4\Views\Controls\Result.cshtml"
Write(ViewBag.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<div style=\"width:500px; display:flex\">\n    <div style=\"width:200px; text-align:right\">\n        <b>");
#nullable restore
#line 6 "C:\Users\Roman\source\repos\Lab2_4\Lab2_4\Views\Controls\Result.cshtml"
      Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n    </div>\n    <div style=\"width: 300px; margin-left: 10px; margin-top:2px\">\n        <pre>");
#nullable restore
#line 9 "C:\Users\Roman\source\repos\Lab2_4\Lab2_4\Views\Controls\Result.cshtml"
        Write(ViewBag.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\n    </div>\n</div>\n");
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
