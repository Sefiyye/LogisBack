#pragma checksum "C:\Users\Ilhame\Desktop\LogicBack\LogicBack\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6707d6e77d2a099b265cff6e46fdf71337ef3ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\Ilhame\Desktop\LogicBack\LogicBack\Views\_ViewImports.cshtml"
using LogicBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilhame\Desktop\LogicBack\LogicBack\Views\_ViewImports.cshtml"
using LogicBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6707d6e77d2a099b265cff6e46fdf71337ef3ac", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a886c43f50c20751ffd6a93e2176a49f3c23c6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- ======= Header ======= -->
  <header id=""header"" class=""header d-flex align-items-center fixed-top"">
    <div class=""container-fluid container-xl d-flex align-items-center justify-content-between"">

      <a href=""index.html"" class=""logo d-flex align-items-center"">
        <!-- Uncomment the line below if you also wish to use an image logo -->
        <!-- <img src=""~/assets/img/logo.png"" alt=""""> -->
        <h1>");
#nullable restore
#line 9 "C:\Users\Ilhame\Desktop\LogicBack\LogicBack\Views\Shared\Components\Header\Default.cshtml"
       Write(Model.Settings.HeaderLogo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
      </a>

      <i class=""mobile-nav-toggle mobile-nav-show bi bi-list""></i>
      <i class=""mobile-nav-toggle mobile-nav-hide d-none bi bi-x""></i>
      <nav id=""navbar"" class=""navbar"">
        <ul>
          <li><a href=""index.html"" class=""active"">Home</a></li>
          <li><a href=""about.html"">About</a></li>
          <li><a href=""services.html"">Services</a></li>
          <li><a href=""pricing.html"">Pricing</a></li>
          <li class=""dropdown""><a href=""#""><span>Drop Down</span> <i class=""bi bi-chevron-down dropdown-indicator""></i></a>
            <ul>
              <li><a href=""#"">Drop Down 1</a></li>
              <li class=""dropdown""><a href=""#""><span>Deep Drop Down</span> <i class=""bi bi-chevron-down dropdown-indicator""></i></a>
                <ul>
                  <li><a href=""#"">Deep Drop Down 1</a></li>
                  <li><a href=""#"">Deep Drop Down 2</a></li>
                  <li><a href=""#"">Deep Drop Down 3</a></li>
                  <li><a href=""#"">Deep Drop Dow");
            WriteLiteral(@"n 4</a></li>
                  <li><a href=""#"">Deep Drop Down 5</a></li>
                </ul>
              </li>
              <li><a href=""#"">Drop Down 2</a></li>
              <li><a href=""#"">Drop Down 3</a></li>
              <li><a href=""#"">Drop Down 4</a></li>
            </ul>
          </li>
          <li><a href=""contact.html"">Contact</a></li>
          <li><a class=""get-a-quote"" href=""get-a-quote.html"">Get a Quote</a></li>
        </ul>
      </nav><!-- .navbar -->

    </div>
  </header><!-- End Header -->
  <!-- End Header -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
