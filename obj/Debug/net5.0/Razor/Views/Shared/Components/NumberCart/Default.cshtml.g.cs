#pragma checksum "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Shared\Components\NumberCart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ea47ba5acb9eb928203a17b954483365ca2e75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NumberCart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NumberCart/Default.cshtml")]
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
#line 1 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\_ViewImports.cshtml"
using WebGoMarkets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\_ViewImports.cshtml"
using WebGoMarkets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ea47ba5acb9eb928203a17b954483365ca2e75", @"/Views/Shared/Components/NumberCart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d0241900b74c67b1ab47b177d7df3857318889", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NumberCart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebGoMarkets.ModelViews.CartItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Shared\Components\NumberCart\Default.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"minicart-wrap me-3 me-lg-0\">\r\n        <a href=\"#miniCart\" class=\"minicart-btn toolbar-btn\">\r\n            <i class=\"pe-7s-shopbag\"></i>\r\n            <span class=\"quantity\">");
#nullable restore
#line 7 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Shared\Components\NumberCart\Default.cshtml"
                              Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 10 "D:\CTIMSchool\TERM-5\ASP.NET\FinalProject\WebGoMarkets\Views\Shared\Components\NumberCart\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebGoMarkets.ModelViews.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591